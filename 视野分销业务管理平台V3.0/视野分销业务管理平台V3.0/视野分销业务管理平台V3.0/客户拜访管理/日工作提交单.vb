Public Class 日工作提交单
    Private base As New 日工作提交单Base
    Private _修改id As Integer
    Public _已保存 As Boolean
    Sub New()
        InitializeComponent()
        textbox_输入员.Text = Bus_CurrentUser_Fullname
        TextBox_输入日期.Text = Now
        '读一下业务记录
        Combo_拜访日期_ValueChanged(Nothing, Nothing)
    End Sub
    Sub New(ByVal id As Integer)
        InitializeComponent()
        Combo_拜访日期.Enabled = False
        _修改id = id
        If _修改id > 0 Then
            ToolStrip_作废.Enabled = True
            Dim dt As DataTable
            dt = base.GetDataTableByid(_修改id)
            If dt.Rows.Count >= 1 Then
                Combo_拜访日期.Text = IIf(IsDBNull(dt.Rows(0)("billdate")), "", dt.Rows(0)("billdate"))
                textbox_输入员.Text = IIf(IsDBNull(dt.Rows(0)("introducer")), "", dt.Rows(0)("introducer"))
                Datagridview1.DataSource = base.GetDataTableBy输入员(textbox_输入员.Text, Combo_拜访日期.Value)
                TextBox_输入日期.Text = IIf(IsDBNull(dt.Rows(0)("introducerdate")), "", dt.Rows(0)("introducerdate"))
                TextBox_打车费.Text = IIf(IsDBNull(dt.Rows(0)("sz1")), "", dt.Rows(0)("sz1"))
                TextBox_公交费.Text = IIf(IsDBNull(dt.Rows(0)("sz2")), "", dt.Rows(0)("sz2"))
                TextBox_住宿费.Text = IIf(IsDBNull(dt.Rows(0)("sz3")), "", dt.Rows(0)("sz3"))
                TextBox_开车补贴.Text = IIf(IsDBNull(dt.Rows(0)("sz4")), "", dt.Rows(0)("sz4"))
                TextBox_招待费.Text = IIf(IsDBNull(dt.Rows(0)("sz5")), "", dt.Rows(0)("sz5"))
                TextBox_餐饮费.Text = IIf(IsDBNull(dt.Rows(0)("sz6")), "", dt.Rows(0)("sz6"))
                TextBox_其他费用.Text = IIf(IsDBNull(dt.Rows(0)("sz7")), "", dt.Rows(0)("sz7"))
                If IIf(IsDBNull(dt.Rows(0)("auditing")), "", dt.Rows(0)("auditing")) <> "" Then
                    PictureBox_审核.Visible = True
                Else
                    PictureBox_审核.Visible = False
                End If

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
    Sub FrmToField()
        base._BILLDATE = Combo_拜访日期.Value
        base._introducer = textbox_输入员.Text
        base._BillMan = getbus_CurrentUser_mastername()
        base._sz1 = IIf(IsNumeric(TextBox_打车费.Text), TextBox_打车费.Text, 0)
        base._sz2 = IIf(IsNumeric(TextBox_公交费.Text), TextBox_公交费.Text, 0)
        base._sz3 = IIf(IsNumeric(TextBox_住宿费.Text), TextBox_住宿费.Text, 0)
        base._sz4 = IIf(IsNumeric(TextBox_开车补贴.Text), TextBox_开车补贴.Text, 0)

        
        base._sz5 = IIf(IsNumeric(TextBox_招待费.Text), TextBox_招待费.Text, 0)
        base._sz6 = IIf(IsNumeric(TextBox_餐饮费.Text), TextBox_餐饮费.Text, 0)
        base._sz7 = IIf(IsNumeric(TextBox_其他费用.Text), TextBox_其他费用.Text, 0)
    End Sub
    Private Sub Tool_保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_保存.Click
        If RicherTextBox_Note.Text = "" Then
            Dim err As New SyERP20.ErrorForm("内容不能为空！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If PictureBox_审核.Visible = True Then
            Dim t2 As New SyERP20.ErrorForm("已审核不能继续！", Nothing)
            t2.ShowDialog()
            Exit Sub
        End If
        FrmToField()
        If _修改id <= 0 Then
            If base.Get是否已提交过Bydate(textbox_输入员.Text, Combo_拜访日期.Value) = True Then
                Dim err4 As New SyERP20.ErrorForm(Combo_拜访日期.Value.ToString("yyyy-MM-dd") & "已经提交过，不能继续！", Nothing)
                err4.ShowDialog()
                Exit Sub
            End If
            base.AddSave(RicherTextBox_Note.rtbDocument)
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            _已保存 = True
            Me.Close()
        Else
            base.ModifySave(_修改id, RicherTextBox_Note.rtbDocument)
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            _已保存 = True
            Me.Close()
        End If
    End Sub

    Private Sub ToolStrip_作废_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip_作废.Click
        If PictureBox_审核.Visible = True Then
            Dim t2 As New SyERP20.ErrorForm("已审核不能继续！", Nothing)
            t2.ShowDialog()
            Exit Sub
        End If

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

  
    Private Sub Combo_拜访日期_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_拜访日期.ValueChanged
        If _修改id <= 0 Then
            Datagridview1.DataSource = base.GetDataTableBy输入员(textbox_输入员.Text, Combo_拜访日期.Value)
        End If
    End Sub

    Private Sub Tool_审核_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_审核.Click
        Dim t As New SyERP20.AccessAdminBase
        If LCase(t.Get_获得当然用户的审核权限状态By组名(getBus_CurrentUser_deptName, "业务拜访日报单")) <> "1" Then
            Dim err1 As New SyERP20.ErrorForm("没有权限!", Nothing)
            err1.ShowDialog()
            Exit Sub
        End If
        base.审核ById(_修改id)
        Dim err As New SyERP20.ErrorForm("审核完成!", Nothing)
        err.ShowDialog()
        Dim dt As DataTable
        dt = base.GetDataTableByid(_修改id)
        If dt.Rows.Count >= 1 Then
            If IIf(IsDBNull(dt.Rows(0)("auditing")), "", dt.Rows(0)("auditing")) <> "" Then
                PictureBox_审核.Visible = True
                RicherTextBox_Note.Enabled = False
            Else
                PictureBox_审核.Visible = False
                RicherTextBox_Note.Enabled = True
            End If
        End If
    End Sub

    Private Sub 日工作提交单_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub 日工作提交单_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Datagridview1.当前用户名 = Bus_CurrentUser_Fullname
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

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim t As New SyERP20.AccessAdminBase
        If LCase(t.Get_获得当然用户的审核权限状态By组名(getBus_CurrentUser_deptName, "业务拜访日报单")) <> "1" Then
            Dim err1 As New SyERP20.ErrorForm("没有权限!", Nothing)
            err1.ShowDialog()
            Exit Sub
        End If
        If PictureBox_审核.Visible = True Then
            base.反审核ById(_修改id)
            Dim err As New SyERP20.ErrorForm("反审核完成!", Nothing)
            err.ShowDialog()
            Dim dt As DataTable
            dt = base.GetDataTableByid(_修改id)
            If dt.Rows.Count >= 1 Then
                If IIf(IsDBNull(dt.Rows(0)("auditing")), "", dt.Rows(0)("auditing")) <> "" Then
                    PictureBox_审核.Visible = True
                    RicherTextBox_Note.Enabled = False
                Else
                    PictureBox_审核.Visible = False
                    RicherTextBox_Note.Enabled = True
                End If
            End If
        End If
    
    End Sub
End Class