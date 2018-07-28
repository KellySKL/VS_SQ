'*******************************************************
'模块描述：业务拜访记录单
'作    者：梁晓东 
'开发时间：2016-10-3
'说    明：
'产品结构类 
'***************************************
Public Class 业务拜访记录单
    Private base As New 业务拜访记录单Base
    Private _修改id As Integer
    Public _已保存 As Boolean
    Dim me_sex_code As String
    Public frm As Object
    Public isOpenRowsNums As Integer
    Public isRetrun As Boolean = False
  


    Sub New()
        InitializeComponent()
        inicontrol()
        textbox_输入员.Text = Bus_CurrentUser_Fullname
    End Sub
    Sub New(ByVal id As Integer)
        InitializeComponent()
        inicontrol()
        _修改id = id


        If _修改id > 0 Then
            ToolStrip_作废.Enabled = True
            Dim dt As DataTable
            dt = base.GetDataTableByid(_修改id)
            If dt.Rows.Count >= 1 Then
                ComboBox_客户类型.Text = IIf(IsDBNull(dt.Rows(0)("zf1")), "", dt.Rows(0)("zf1"))
                textbox_客户名称.Text = IIf(IsDBNull(dt.Rows(0)("Client")), "", dt.Rows(0)("Client"))
                Combo_拜访日期.Text = IIf(IsDBNull(dt.Rows(0)("billdate")), "", dt.Rows(0)("billdate"))
                textbox_输入员.Text = IIf(IsDBNull(dt.Rows(0)("introducer")), "", dt.Rows(0)("introducer"))
                ComboBox_拜访方式.Text = IIf(IsDBNull(dt.Rows(0)("zf2")), "", dt.Rows(0)("zf2"))
                ComboBox_业务类型.Text = IIf(IsDBNull(dt.Rows(0)("billtype")), "", dt.Rows(0)("billtype"))
                ComboBox_备注项.Text = IIf(IsDBNull(dt.Rows(0)("zf3")), "", dt.Rows(0)("zf3"))
                DateTimePicker_下次拜访日期.Text = IIf(IsDBNull(dt.Rows(0)("finishDATE")), "", dt.Rows(0)("finishDATE"))
                Tool_审核状态.Text = IIf(IsDBNull(dt.Rows(0)("auditing")), "", dt.Rows(0)("auditing"))
                Tool_日报单号.Text = IIf(IsDBNull(dt.Rows(0)("refercode")), "", dt.Rows(0)("refercode"))
                If Not IsDBNull(dt.Rows(0)("Note")) Then
                    Dim wWrite1 As Byte()
                    wWrite1 = dt.Rows(0)("Note")
                    Dim mstream As New System.IO.MemoryStream(wWrite1, False)
                    RicherTextBox_Note.rtbDocument.LoadFile(mstream, RichTextBoxStreamType.RichText)
                Else
                    RicherTextBox_Note.Text = IIf(IsDBNull(dt.Rows(0)("NotePre")), "", dt.Rows(0)("NotePre"))
                End If
            End If
        End If
    End Sub
    Sub inicontrol()

        ComboBox_客户类型.DataSource = base.Get市场潜在客户类型分类

    End Sub

    Private Sub 业务拜访记录单_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If isRetrun = False Then Application.Exit()
    End Sub

 

   
    Private Sub 业务拜访记录单_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    
    End Sub
    Sub FrmToField()
        base._zf1 = ComboBox_客户类型.Text
        base._Client = textbox_客户名称.Text
        base._BILLDATE = Combo_拜访日期.Text
        base._introducer = textbox_输入员.Text
        base._zf2 = ComboBox_拜访方式.Text
        base._BILLTYPE = ComboBox_业务类型.Text
        base._BillMan = getbus_CurrentUser_mastername()
        base._zf3 = ComboBox_备注项.Text
        base._finishDATE = DateTimePicker_下次拜访日期.Text
        base._TRADETYPENAME = Me.TextBox_客户类型.Text


    End Sub

    Private Sub button_获得客户名称_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_获得客户名称.Click
        Dim t As New SyERP20.SelectFormBase
        Dim where As String = ""




        where = " and AREANAME in (select '='+AREANAME+'|' from areaku where guserdef1 like '%" & Bus_CurrentUser_Fullname & "%' or guserdef1 like '%" & bus_CurrentUser_mastername & "%')"
        t.ShowEditForm("clientservice_kfku", "and tradetypename like '%" & ComboBox_客户类型.Text & "%'" & where, textbox_客户名称)





    End Sub



    Private Sub textbox_客户名称_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textbox_客户名称.TextChanged
        Dim dt As DataTable
        dt = base.Get市场潜在客户ByName(textbox_客户名称.Text)
        If dt.Rows.Count >= 1 Then
            GroupBox_客户信息.Text = dt.Rows(0)("id")
            me_sex_code = dt.Rows(0)("code")

            Label6.Text = IIf(IsDBNull(dt.Rows(0)("联系人")), "", dt.Rows(0)("联系人"))
            '
            TextBox_联系人.Text = IIf(IsDBNull(dt.Rows(0)("contactor")), "", dt.Rows(0)("contactor"))
            TextBox_联系人.Tag = "contactor"
            '
            If dt.Rows(0)("TRADETYPENAME") = "新建客户" Then
                TextBox_客户类型.Text = "潜在客户"
                TextBox_客户类型.Tag = "TRADETYPENAME"
            Else
                TextBox_客户类型.Text = IIf(IsDBNull(dt.Rows(0)("TRADETYPENAME")), "", dt.Rows(0)("TRADETYPENAME"))
                TextBox_客户类型.Tag = "TRADETYPENAME"
            End If




            ''
            TextBox_联系人电话.Text = IIf(IsDBNull(dt.Rows(0)("PHONE")), "", dt.Rows(0)("PHONE"))
            TextBox_联系人电话.Tag = "PHONE"

            TextBox_联系人职务.Text = IIf(IsDBNull(dt.Rows(0)("ZF8")), "", dt.Rows(0)("ZF8"))
            TextBox_联系人职务.Tag = "ZF8"
            ''
            TextBox_设备需求情况.Text = IIf(IsDBNull(dt.Rows(0)("ZF9")), "", dt.Rows(0)("ZF9"))
            TextBox_设备需求情况.Tag = "ZF9"

            ''
            TextBox_现有中走丝数量.Text = IIf(IsDBNull(dt.Rows(0)("ZF15")), "", dt.Rows(0)("ZF15"))
            TextBox_现有中走丝数量.Tag = "ZF15"
            ''
            TextBox_地址.Text = IIf(IsDBNull(dt.Rows(0)("CONTACTORspell")), "", dt.Rows(0)("CONTACTORspell"))
            TextBox_地址.Tag = "CONTACTORspell"
            ''
            TextBox_现有设备使用情况.Text = IIf(IsDBNull(dt.Rows(0)("REMARK")), "", dt.Rows(0)("REMARK"))
            TextBox_现有设备使用情况.Tag = "REMARK"
            ''
            TextBox_是否外加工.Text = IIf(IsDBNull(dt.Rows(0)("ZF18")), "", dt.Rows(0)("ZF18"))
            TextBox_是否外加工.Tag = "ZF18"

            TextBox_模具生产人数.Text = IIf(IsDBNull(dt.Rows(0)("ZF10")), "", dt.Rows(0)("ZF10"))
            TextBox_模具生产人数.Tag = "ZF10"

            TextBox_现有快走丝数.Text = IIf(IsDBNull(dt.Rows(0)("ZF14")), "", dt.Rows(0)("ZF14"))
            TextBox_现有快走丝数.Tag = "ZF14"

            TextBox_经营项目.Text = IIf(IsDBNull(dt.Rows(0)("ZF21")), "", dt.Rows(0)("ZF21"))
            TextBox_经营项目.Tag = "ZF21"


            TextBox_模具精度要求.Text = IIf(IsDBNull(dt.Rows(0)("ZF17")), "", dt.Rows(0)("ZF17"))
            TextBox_模具精度要求.Tag = "ZF17"


            TextBox_现有设备品牌.Text = IIf(IsDBNull(dt.Rows(0)("ZF22")), "", dt.Rows(0)("ZF22"))
            TextBox_现有设备品牌.Tag = "ZF22"

            TextBox_信誉状态.Text = IIf(IsDBNull(dt.Rows(0)("ZF24")), "", dt.Rows(0)("ZF24"))
            TextBox_信誉状态.Tag = "ZF24"


            TextBox_辐射范围.Text = IIf(IsDBNull(dt.Rows(0)("ZF23")), "", dt.Rows(0)("ZF23"))
            TextBox_辐射范围.Tag = "ZF23"


            TextBox_年销售额加工.Text = IIf(IsDBNull(dt.Rows(0)("ZF25")), "", dt.Rows(0)("ZF25"))
            TextBox_年销售额加工.Tag = "ZF25"


            TextBox_客户区域.Text = IIf(IsDBNull(dt.Rows(0)("AREANAME")), "", dt.Rows(0)("AREANAME"))
            TextBox_客户区域.Tag = "AREANAME"


            ''
            'TextBox14.Text = dt.Rows(0)("")
            'TextBox14.Tag = ""
            ''

            TextBox_客户信息描述.Text = IIf(IsDBNull(dt.Rows(0)("zf21")), "", dt.Rows(0)("zf21"))
            TextBox_客户信息描述.Tag = "zf21"
            'TextBox7.Text = 
            'TextBox7.Tag = ""
            ''


            TextBox_客户等级.Text = IIf(IsDBNull(dt.Rows(0)("LEV")), "", dt.Rows(0)("LEV"))
            TextBox_客户等级.Tag = "LEV"

            'TextBox11.Text = dt.Rows(0)("")
            'TextBox11.Tag = ""
            ''
            'TextBox15.Text = dt.Rows(0)("")
            'TextBox15.Tag = ""
        Else
            GroupBox_客户信息.Text = ""
            TextBox_联系人.Text = ""
            '
            TextBox_客户类型.Text = ""
            ''
            TextBox_联系人电话.Text = ""

            TextBox_联系人职务.Text = ""
            ''
            TextBox_设备需求情况.Text = ""
            ''
            TextBox_现有中走丝数量.Text = ""
            TextBox_地址.Text = ""
            ''
            TextBox_现有设备使用情况.Text = ""
            TextBox_是否外加工.Text = ""
            TextBox_客户信息描述.Text = ""
            TextBox_客户等级.Text = ""
            TextBox_模具生产人数.Text = ""
            TextBox_现有快走丝数.Text = ""
            TextBox_经营项目.Text = ""
            TextBox_模具精度要求.Text = ""
            TextBox_现有设备品牌.Text = ""
            TextBox_信誉状态.Text = ""
            TextBox_辐射范围.Text = ""
            TextBox_年销售额加工.Text = ""
            TextBox_客户区域.Text = ""
        End If
    End Sub

    Private Sub TextBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_联系人职务.DoubleClick, TextBox_设备需求情况.DoubleClick, TextBox_现有中走丝数量.DoubleClick, TextBox_地址.DoubleClick, TextBox_现有设备使用情况.DoubleClick, TextBox_是否外加工.DoubleClick, TextBox14.DoubleClick, TextBox11.DoubleClick, TextBox_客户信息描述.DoubleClick, TextBox_信誉状态.DoubleClick, TextBox_现有设备品牌.DoubleClick, TextBox_现有快走丝数.DoubleClick, TextBox_年销售额加工.DoubleClick, TextBox_模具精度要求.DoubleClick, TextBox_辐射范围.DoubleClick, TextBox_经营项目.DoubleClick, TextBox_模具生产人数.DoubleClick
        TextBox_修改客户信息.Tag = sender.tag
        Panel_修改.Visible = True
    End Sub

    Private Sub Button_修改_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_修改.Click
        If IsNumeric(GroupBox_客户信息.Text) Then
            base.Set值Byid(TextBox_修改客户信息.Tag, TextBox_修改客户信息.Text, GroupBox_客户信息.Text)
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            Panel_修改.Visible = False
            textbox_客户名称_TextChanged(Nothing, Nothing)
        End If
    End Sub
    Private Sub Tool_保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_保存.Click
        If Tool_日报单号.Text <> "" Then
            Dim err As New SyERP20.ErrorForm("已编制日报！不能继续！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If

        Dim MeDateTime As DateTime = BuildFrmTo获得服务器时间()

        If Bus_CurrentUser_Fullname = "王娅丽" Then


        Else


            If Today.DayOfWeek = DayOfWeek.Monday Then
                If Combo_拜访日期.Value < MeDateTime.AddDays(-3) Then
                    Dim err As New SyERP20.ErrorForm("只能提交3天内的内容！不能继续！", Nothing)
                    err.ShowDialog()
                    Exit Sub
                End If
            Else
                If Combo_拜访日期.Value < MeDateTime.AddDays(-2) Then
                    Dim err As New SyERP20.ErrorForm("只能提交2天内的内容！不能继续！", Nothing)
                    err.ShowDialog()
                    Exit Sub
                End If
            End If
            If CType(Combo_拜访日期.Value.ToString("yyyyMMdd"), Integer) > CType(MeDateTime.ToString("yyyyMMdd"), Integer) Then
                Dim err As New SyERP20.ErrorForm("不能提交将来的内容！不能继续！", Nothing)
                err.ShowDialog()
                Exit Sub
            End If
        End If



        If Tool_审核状态.Text <> "" Then
            Dim err As New SyERP20.ErrorForm("已审核！不能继续！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If textbox_客户名称.Text = "" Then
            Dim err As New SyERP20.ErrorForm("客户名称不能为空！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If ComboBox_拜访方式.Text = "" Then
            Dim err As New SyERP20.ErrorForm("拜访方式不能为空！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If ComboBox_业务类型.Text = "" Then
            Dim err As New SyERP20.ErrorForm("业务类型不能为空！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If RicherTextBox_Note.Text = "" Then
            Dim err As New SyERP20.ErrorForm("内容不能为空！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If textbox_输入员.Text <> Bus_CurrentUser_Fullname Then
            Dim err As New SyERP20.ErrorForm("只有输入员：" & textbox_输入员.Text & "才可以修改！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If

        FrmToField()

        If _修改id <= 0 Then
            base.AddSave(RicherTextBox_Note.rtbDocument)
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            _已保存 = True

            base._update潜在客户(me_sex_code)


            If isRetrun = True Then
                frm.nexTime = Combo_拜访日期.Value
                frm.Rtext = RicherTextBox_Note.Text
                frm._showInfoli(isOpenRowsNums)
            End If





        Else
            base.ModifySave(_修改id, RicherTextBox_Note.rtbDocument)
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            _已保存 = True
            base._update潜在客户(me_sex_code)

            '
            '

            Application.Exit()
        End If



        Me.Close()

    End Sub




    Private Sub ToolStrip_备注项录入_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip_备注项录入.Click
        Dim inputfrm As New SyERP20.InputboxForm()
        inputfrm.Showitem("请输入密码：(tel)")
        inputfrm.原因.PasswordChar = "●"
        inputfrm.ShowDialog()
        If inputfrm.ReturnBillNote = "" Then Exit Sub
        If Replace(inputfrm.ReturnBillNote, vbCrLf, "") <> "62721120" Then
            Dim t1 As New SyERP20.ErrorForm("密码不正确", Nothing)
            t1.ShowDialog()
            Exit Sub
        Else
            base.建表()
            Dim T As New SyERP20.后台管理
            T.输入框_表名.Text = "clientservice_BilltypeChildtype"
            T.ComboBox1.Enabled = False
            T.ShowDialog()
        End If


    End Sub
    Private Sub Tool_业务类型录入_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_业务类型录入.Click
        Dim inputfrm As New SyERP20.InputboxForm()
        inputfrm.Showitem("请输入密码：(tel)")
        inputfrm.原因.PasswordChar = "●"
        inputfrm.ShowDialog()
        If inputfrm.ReturnBillNote = "" Then Exit Sub
        If Replace(inputfrm.ReturnBillNote, vbCrLf, "") <> "62721120" Then
            Dim t1 As New SyERP20.ErrorForm("密码不正确", Nothing)
            t1.ShowDialog()
            Exit Sub
        Else
            base.建表()
            Dim T As New SyERP20.后台管理
            T.输入框_表名.Text = "clientservice_Billtype"
            T.ComboBox1.Enabled = False
            T.ShowDialog()
        End If
    End Sub
    Private Sub ComboBox_业务类型_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_业务类型.TextChanged
        ComboBox_备注项.DataSource = base.Get子业务类型(ComboBox_业务类型.Text)
    End Sub

    Private Sub ToolStrip_作废_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip_作废.Click
        Dim inputfrm As New SyERP20.InputboxForm()
        inputfrm.Showitem("请输入作废原因：")
        inputfrm.ShowDialog()
        If inputfrm.ReturnBillNote = "" Then  '输入原因时点退出，则什么都不做
            MsgBox("已取消!")
            Exit Sub
        End If
        base.killBill(_修改id)
        SyERP20.SaveLog(Bus_CurrentUser_Fullname, _修改id, "业务拜访记录单作废：" & inputfrm.ReturnBillNote, "成功")
        Dim t1 As New SyERP20.ErrorForm("完成！", Nothing)
        t1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ToolStrip_退出_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip_退出.Click
        Me.Close()
    End Sub

    Private Sub TextBox15_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_客户类型.DoubleClick
        If IsNumeric(GroupBox_客户信息.Text) Then
            base.改变客户类型(IIf(TextBox_客户类型.Text.IndexOf("竞争对手") >= 0, True, False), GroupBox_客户信息.Text)
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            Panel_修改.Visible = False
            textbox_客户名称_TextChanged(Nothing, Nothing)
        End If
    End Sub


    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_客户类型.TextChanged
        Dim 是否为竞争对方 As Boolean = IIf(TextBox_客户类型.Text.IndexOf("竞争对手") >= 0, True, False)
        If 是否为竞争对方 = True Then
            TextBox_客户类型.BackColor = Color.Red
        Else
            TextBox_客户类型.BackColor = Color.WhiteSmoke
        End If

    End Sub

    Private Sub Button_隐藏修改_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_隐藏修改.Click
        Panel_修改.Visible = False
    End Sub

    Private Sub Tool_历史记录查询_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_历史记录查询.Click
        If textbox_客户名称.Text <> "" Then
            Dim window As New Form
            window.Size = New Size(1024, 500)
            window.StartPosition = FormStartPosition.CenterScreen
            Dim t As New 业务拜访记录单历史查询
            t._where += " and client = '" & textbox_客户名称.Text & "'"
            window.Controls.Add(t)
            window.ShowDialog()
        Else
            Dim err As New SyERP20.ErrorForm("请选择客户名称！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub ComboBox_客户类型_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_客户类型.TextChanged
        textbox_客户名称.Text = ""
        ComboBox_业务类型.DataSource = base.list类型(ComboBox_客户类型.Text)


        '三奇专用
        Label8.Visible = False
        TextBox_模具生产人数.Visible = False
        Label13.Visible = False
        TextBox_现有设备使用情况.Visible = False
        Label29.Visible = False
        TextBox_经营项目.Visible = False
        Label12.Visible = False
        TextBox_设备需求情况.Visible = False
        Label26.Visible = False
        TextBox_现有快走丝数.Visible = False
        Label17.Visible = False
        TextBox_现有中走丝数量.Visible = False
        Label32.Visible = False
        TextBox_模具精度要求.Visible = False
        Label18.Visible = False
        TextBox_是否外加工.Visible = False
        Label8.Visible = False
        TextBox_模具生产人数.Visible = False
        Label13.Visible = False
        TextBox_现有设备使用情况.Visible = False
        Label29.Visible = False
        TextBox_经营项目.Visible = False
        Label12.Visible = False
        TextBox_设备需求情况.Visible = False
        Label26.Visible = False
        TextBox_现有快走丝数.Visible = False
        Label17.Visible = False
        TextBox_现有中走丝数量.Visible = False
        Label32.Visible = False
        TextBox_模具精度要求.Visible = False
        Label18.Visible = False
        TextBox_是否外加工.Visible = False
        Label13.Visible = False
        TextBox_现有设备使用情况.Visible = False
        Label29.Visible = False
        TextBox_经营项目.Visible = False
        Label26.Visible = False
        TextBox_现有快走丝数.Visible = False
        Label17.Visible = False
        TextBox_现有中走丝数量.Visible = False
        Label27.Visible = False
        TextBox_年销售额加工.Visible = False
        Label24.Visible = False
        TextBox_现有设备品牌.Visible = False
        Label29.Visible = False
        TextBox_经营项目.Visible = False
        Label27.Visible = False
        TextBox_年销售额加工.Visible = False
        Label33.Visible = False
        TextBox_辐射范围.Visible = False
        Label30.Visible = False
        TextBox_信誉状态.Visible = False
        If ComboBox_客户类型.Text = "公司客户" Then
            Label8.Visible = True
            TextBox_模具生产人数.Visible = True
            Label13.Visible = True
            TextBox_现有设备使用情况.Visible = True
            Label29.Visible = True
            TextBox_经营项目.Visible = True
            Label12.Visible = True
            TextBox_设备需求情况.Visible = True
            Label26.Visible = True
            TextBox_现有快走丝数.Visible = True
            Label17.Visible = True
            TextBox_现有中走丝数量.Visible = True
            Label32.Visible = True
            TextBox_模具精度要求.Visible = True
            Label18.Visible = True
            TextBox_是否外加工.Visible = True
        ElseIf ComboBox_客户类型.Text = "潜在客户" Then
            Label8.Visible = True
            TextBox_模具生产人数.Visible = True
            Label13.Visible = True
            TextBox_现有设备使用情况.Visible = True
            Label29.Visible = True
            TextBox_经营项目.Visible = True
            Label12.Visible = True
            TextBox_设备需求情况.Visible = True
            Label26.Visible = True
            TextBox_现有快走丝数.Visible = True
            Label17.Visible = True
            TextBox_现有中走丝数量.Visible = True
            Label32.Visible = True
            TextBox_模具精度要求.Visible = True
            Label18.Visible = True
            TextBox_是否外加工.Visible = True
        ElseIf ComboBox_客户类型.Text = "竞争对手" Then
            Label13.Visible = True
            TextBox_现有设备使用情况.Visible = True
            Label29.Visible = True
            TextBox_经营项目.Visible = True
            Label26.Visible = True
            TextBox_现有快走丝数.Visible = True
            Label17.Visible = True
            TextBox_现有中走丝数量.Visible = True
            Label27.Visible = True
            TextBox_年销售额加工.Visible = True
            Label24.Visible = True
            TextBox_现有设备品牌.Visible = True
        ElseIf ComboBox_客户类型.Text = "外部渠道" Then
            Label29.Visible = True
            TextBox_经营项目.Visible = True
            Label27.Visible = True
            TextBox_年销售额加工.Visible = True
            Label33.Visible = True
            TextBox_辐射范围.Visible = True
            Label30.Visible = True
            TextBox_信誉状态.Visible = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim t As New SyERP20.AccessAdminBase
        If LCase(t.Get_获得当然用户的审核权限状态By组名(getBus_CurrentUser_deptName, "业务拜访单")) <> "1" Then
            Dim err1 As New SyERP20.ErrorForm("没有权限!", Nothing)
            err1.ShowDialog()
            Exit Sub
        End If
        If base.审核单据(_修改id) = True Then
            Dim err As New SyERP20.ErrorForm("审核完成！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip_反审核.Click
        Dim t As New SyERP20.AccessAdminBase
        If LCase(t.Get_获得当然用户的审核权限状态By组名(getBus_CurrentUser_deptName, "业务拜访单")) <> "1" Then
            Dim err1 As New SyERP20.ErrorForm("没有权限!", Nothing)
            err1.ShowDialog()
            Exit Sub
        End If
        If base.反审核单据(_修改id) = True Then
            Dim err As New SyERP20.ErrorForm("反审核完成！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
    End Sub
  

    Private Sub RicherTextBox_Note_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RicherTextBox_Note.KeyDown
        _已保存 = False
    End Sub
    '退出系统
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If _已保存 = False AndAlso MsgBox("尚未保存数据，您确认要退出吗?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
            e.Cancel = True
            Exit Sub
        End If
        Me.Dispose()
    End Sub


End Class