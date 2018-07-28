Public Class 售后服务单
    Private base As New 售后服务单Base
    Private Bass As New 售后服务维修问题库base
    Private _修改id As Integer
    Private Jccode As String = ""
    Private 单位CODE As String = ""


    Public _已保存 As Boolean
    Dim flag As Boolean = False
    Dim flopen As Boolean = False
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
                textbox_客户名称.Text = IIf(IsDBNull(dt.Rows(0)("Client")), "", dt.Rows(0)("Client"))
                日期.Text = IIf(IsDBNull(dt.Rows(0)("billdate")), "", dt.Rows(0)("billdate"))
                textbox_输入员.Text = IIf(IsDBNull(dt.Rows(0)("introducer")), "", dt.Rows(0)("introducer"))
                服务类型.Text = IIf(IsDBNull(dt.Rows(0)("billtype")), "", dt.Rows(0)("billtype"))
                txt_单号.Text = IIf(IsDBNull(dt.Rows(0)("code")), "", dt.Rows(0)("code"))
                txt_产品编号.Text = IIf(IsDBNull(dt.Rows(0)("zf1")), "", dt.Rows(0)("zf1"))
                TextBox_故障类别.Text = IIf(IsDBNull(dt.Rows(0)("zf7")), "", dt.Rows(0)("zf7"))
                ComboBox_上门方式.Text = IIf(IsDBNull(dt.Rows(0)("zf8")), "", dt.Rows(0)("zf8"))
                TextBox_保修到期.Text = IIf(IsDBNull(dt.Rows(0)("zf9")), "", dt.Rows(0)("zf9"))
                If Not IsDBNull(dt.Rows(0)("Note")) Then
                    Dim wWrite1 As Byte()
                    wWrite1 = dt.Rows(0)("Note")
                    Dim mstream As New System.IO.MemoryStream(wWrite1, False)
                    RicherTextBox_Note.rtbDocument.LoadFile(mstream, RichTextBoxStreamType.RichText)
                Else
                    RicherTextBox_Note.Text = IIf(IsDBNull(dt.Rows(0)("NotePre")), "", dt.Rows(0)("NotePre"))
                End If
                读聊天记录()
                read附件()
                If IIf(IsDBNull(dt.Rows(0)("zf4")), "", dt.Rows(0)("zf4")) <> "" Then
                    Tool_保存.Enabled = False
                End If
            End If
        End If
    End Sub
    Sub inicontrol()
        服务类型.DataSource = base.list类型()
        Me.TextBox_保修到期.ReadOnly = True
        Me.服务类型.Enabled = False
    End Sub

    Private Sub 售后服务单_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If _修改id = 0 Then Application.Exit()
    End Sub

    Private Sub 售后服务单_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If flag = False Then
            If MessageBox.Show("事务未完成是否要强关窗口？", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            Else
                Bass.delWxList(Jccode)
            End If
        End If
    End Sub

 
    Private Sub 业务拜访记录单_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim dt As DataTable = SyERP20.BusGetpulist("")
        '  用户名.Items.Clear()
        '  For Each row As DataRow In dt.Rows
        '用户名.Items.Add(IIf(IsDBNull(row("用户名")), "", row("用户名")) & "│" & IIf(IsDBNull(row("接收人")), "", row("接收人")) & "[" & IIf(IsDBNull(row("部门")), "", row("部门")) & "]")
        '  Next
        Me.DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname



    End Sub
    Sub FrmToField()
        base._Client = textbox_客户名称.Text
        base._BILLDATE = 日期.Text
        base._introducer = textbox_输入员.Text
        base._BILLTYPE = 服务类型.Text
        base._zf1 = txt_产品编号.Text
        base._zf7 = TextBox_故障类别.Text
        base._zf8 = ComboBox_上门方式.Text
        base._zf9 = TextBox_保修到期.Text
        base._zf27 = Me.TextBox3.Text.Trim
        base._zf28 = Me.TextBox2.Text.Trim
    End Sub

    Private Sub button_获得客户名称_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_获得客户名称.Click
        Dim t As New SyERP20.SelectFormBase
        t.ShowEditForm("kfku", "", textbox_客户名称)
    End Sub


    Private Sub textbox_客户名称_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textbox_客户名称.TextChanged
        Dim dt As DataTable
        dt = base.Get客户ByName(textbox_客户名称.Text)
        If dt.Rows.Count >= 1 Then
            txt_联系人.Text = dt.Rows(0)("contactor")
            TextBox1.Text = dt.Rows(0)("phone")
            txt_地址.Text = dt.Rows(0)("contactorspell")
            单位CODE = dt.Rows(0)("code")
        End If
        txt_产品编号.DataSource = base.Bus出厂信息(textbox_客户名称.Text)
    End Sub

    Private Sub Tool_保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_保存.Click
        If textbox_客户名称.Text = "" Then
            Dim err As New SyERP20.ErrorForm("客户名称不能为空！", Nothing)
            textbox_客户名称.BackColor = Color.Red
            textbox_客户名称.ForeColor = Color.White
            err.ShowDialog()
            Exit Sub
        End If
        'If TextBox_故障类别.Text = "" Or TextBox_故障类别.Text = "目录选择" Then
        '    Dim err As New SyERP20.ErrorForm("故障类别不能为空或不能选择[目录选择]！请重新选择。", Nothing)
        '    TextBox_故障类别.BackColor = Color.Red
        '    TextBox_故障类别.ForeColor = Color.White
        '    err.ShowDialog()
        '    Exit Sub
        'End If
        If 服务类型.Text = "" Then
            Dim err As New SyERP20.ErrorForm("服务类型不能为空！", Nothing)
            服务类型.BackColor = Color.Red
            服务类型.ForeColor = Color.White
            err.ShowDialog()
            Exit Sub
        End If
        If RicherTextBox_Note.Text = "" Then
            Dim err As New SyERP20.ErrorForm("内容不能为空！", Nothing)
            RicherTextBox_Note.BackColor = Color.Red
            RicherTextBox_Note.ForeColor = Color.White
            err.ShowDialog()
            Exit Sub
        End If
        If TextBox3.Text.Trim = "" Then
            Dim err As New SyERP20.ErrorForm("保修人名称不能为空！", Nothing)
            TextBox3.BackColor = Color.Red
            TextBox3.ForeColor = Color.White
            err.ShowDialog()
            Exit Sub
        End If

        If TextBox2.Text.Trim = "" Then
            Dim err As New SyERP20.ErrorForm("保修人电话号码不能为空！", Nothing)
            TextBox2.BackColor = Color.Red
            TextBox2.ForeColor = Color.White
            err.ShowDialog()
            Exit Sub
        End If
        FrmToField()
        If _修改id <= 0 Then
            base.AddSave(RicherTextBox_Note.rtbDocument)
        Else
            base.ModifySave(_修改id, RicherTextBox_Note.rtbDocument)
            _已保存 = True
        End If

        Dim stsql = "'" & 单位CODE & "','" & TextBox2.Text.Trim() & "' ,'" & TextBox3.Text.Trim() & "' ,'" & TextBox4.Text.Trim() & "'"
        base.AddMan(stsql)
        flag = True






        If MessageBox.Show("数据已经保存成功，是否关闭当前窗口？", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
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
            Dim T As New SyERP20.后台管理
            T.输入框_表名.Text = "clientservice_Billtype"
            T.ComboBox1.Enabled = False
            T.ShowDialog()
        End If
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
    Sub 读聊天记录()
        Dim dt历史 As DataTable
        dt历史 = SyERP20.GetBill单据的聊天记录(txt_单号.Text)
        历史消息.Text = ""
        Dim selectStart As Long = 0
        For Each row As DataRow In dt历史.Rows
            Dim str As String
            str = SyERP20.BusGet用户全名byusername(row("Send")) & " 已发送给 " & SyERP20.BusGet用户全名byusername(row("Sendto")) & " [" & IIf(IsDBNull(row("tablename")), "", row("tablename")) & "]"
            If row("senddate").ToString <> "" Then str += "(" & row("senddate").ToString & ")"
            历史消息.AppendText(str & Environment.NewLine)
            selectStart = 历史消息.TextLength
            历史消息.Select(selectStart, 历史消息.TextLength - 1)
            历史消息.SelectionColor = Color.Red
            '内容
            Dim 内容 As String
            If row("sendNOTE") = "" Then
                内容 = "   " & "-"
            Else
                内容 = "   " & row("sendNOTE")
            End If
            历史消息.AppendText(内容 & Environment.NewLine)
            selectStart = 历史消息.TextLength
            历史消息.Select(selectStart, 历史消息.TextLength - 1)
            历史消息.SelectionColor = Color.Blue
        Next
        历史消息.ScrollToCaret()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_单号.Text = "" Then
            Dim err As New SyERP20.ErrorForm("没有单号，不能继续！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        '传给工厂本销售单号 
        If 用户名.Text = "" Then
            Dim err As New SyERP20.ErrorForm("请选择接收人！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        Dim MessageBoxFormBs As New SyERP20.MessageBoxFormBase
        Dim 部门 As String = ""
        Try
            部门 = 用户名.Text.Split("[")(1)
            部门 = Replace(部门, "]", "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If MessageBoxFormBs.NewBillSendto(txt_单号.Text, 用户名.Text.Split("│")(0), 便条.Text, 部门) = False Then
            MsgBox("发送不成功！")
            Exit Sub
        Else
            便条.Text = ""
        End If
        读聊天记录()
    End Sub
    Private Sub 附件上传_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txt_单号.Text = "" Then
            Dim err As New SyERP20.ErrorForm("请先保存！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        Dim t As New SyERP20.单据附件上传器(txt_单号.Text)
        t.ShowDialog()
        read附件()
    End Sub
    Sub read附件()
        If txt_单号.Text = "" Then
            Exit Sub
        End If
        '3.获得附件记录
        Dim dt单据附件 As DataTable
        dt单据附件 = SyERP20.GetBill单据附件记录(txt_单号.Text, "", "")
        附件管理.Controls.Clear()
        Dim a1 As New Button
        a1.TextAlign = ContentAlignment.MiddleLeft
        a1.FlatStyle = FlatStyle.Flat
        a1.FlatAppearance.BorderColor = Color.FloralWhite
        a1.AutoSize = True
        a1.Text = "上传附件..."
        AddHandler a1.Click, New EventHandler(AddressOf 附件上传_LinkClicked)
        附件管理.Controls.Add(a1)
        For i As Integer = 0 To dt单据附件.Rows.Count - 1
            Dim a As New Button
            a.TextAlign = ContentAlignment.MiddleLeft
            a.FlatStyle = FlatStyle.Flat
            a.FlatAppearance.BorderColor = Color.FloralWhite
            a.AutoSize = True
            a.Tag = dt单据附件.Rows(i)("id")
            a.Text = dt单据附件.Rows(i)("Guserdef1")
            AddHandler a.Click, New EventHandler(AddressOf a_Click)
            AddHandler a.MouseDown, New MouseEventHandler(AddressOf a_MouseDown)
            附件管理.Controls.Add(a)
        Next
    End Sub
    Private Current附件id As Integer
    Private Sub a_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Current附件id = sender.tag
        If e.Button = Windows.Forms.MouseButtons.Right Then
            sender.ContextMenuStrip = 附件菜单
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            sender.ContextMenuStrip = 附件菜单
            附件菜单.Show(sender, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub 打开附件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开附件ToolStripMenuItem.Click
        Dim t As New SyERP20.单据附件上传器Base
        Dim filepath As String = ""
        filepath = t.download(Current附件id)
        Dim file As New IO.FileInfo(filepath)
        If file.Exists Then
            Dim dirprocess As New ProcessStartInfo
            dirprocess.FileName = filepath
            Process.Start(dirprocess)
        Else
            Dim err As New SyERP20.ErrorForm("文件不存在!", Nothing)
            err.ShowDialog()
        End If
    End Sub

    Private Sub txt_产品编号_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_产品编号.TextChanged
        Dim dt As DataTable
        dt = base.Bus出厂信息DT(txt_产品编号.Text)
        TextBox_保修到期.Text = ""
        If dt.Rows.Count >= 1 Then
            Try
                Dim dte As Date = dt.Rows(0)("保修结束日期")
                TextBox_保修到期.Text = dte.ToString("yyyy-MM-dd")
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub TextBox_保修到期_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_保修到期.TextChanged
        If TextBox_保修到期.Text < Now.ToString("yyyy-MM-dd") Then
            TextBox_保修到期.ForeColor = Color.Red
            服务类型.Text = "保外"
        Else
            TextBox_保修到期.ForeColor = Color.Black
            服务类型.Text = "保内"
        End If
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
 
    Private Sub txt_产品编号_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_产品编号.SelectedIndexChanged
        Jccode = Me.txt_产品编号.Text.Trim
        DatagridviewEx1.DataSource = Bass.GetwxInfo(Jccode, 1)
    End Sub
 
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Trim(txt_产品编号.Text) = "" Or Jccode = "" Then
            MessageBox.Show("请选择机床编号", Me.Text)
        Else
            txt_产品编号.Enabled = False
            flopen = True
            TextBox_故障类别.Text = Jccode
            Dim t As New 售后服务维修问题库
            t.openMe(Jccode)
        End If
    End Sub

    Private Sub DatagridviewEx1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx1.CellContentClick
        Dim t As New 售后服务单作业完成时描述
        t.单号.Text = DatagridviewEx1.SelectedRows(0).Cells("code").Value
        t.Tool维修人员.Text = DatagridviewEx1.SelectedRows(0).Cells("billman").Value
        t.ShowDialog()

    End Sub
End Class