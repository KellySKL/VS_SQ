Public Class 售后服务单作业接收时描述
    Private base As New 售后服务单作业管理Base
    Private Bass As New 售后服务维修问题库base
    Public flag As Boolean = False
    Public cName As String = ""
    Public cWx As String = ""
    Public cInfo As String = ""
    Public cRemsg As String = ""
    Public Czrman As String = ""
    Public uWxman As String = ""
    Public Jcode As String = ""
    Public getName As String = ""
    Public cId As Integer
    Public Sub addMan(ByVal man As String)
        Me.Activate()
        ToolStripLabel5.Text = man
        getName = man
        ToolStripLabel5.Text = ToolStripLabel5.Text

    End Sub

    Private Sub 售后服务单作业接收时描述_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If getName.Trim <> "" Then ToolStripLabel5.Text = getName

    End Sub

 

    Private Sub 售后服务单作业接收时描述_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If ToolStripLabel5.Text = "[+未分配]" Or Trim(TextBox_原因分析.Text) = "" Then
            If MessageBox.Show("事务未完成是否要强关窗口？", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            End If

        End If

    End Sub
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        If ToolStripLabel5.Text = "[+未分配]" Then
            MessageBox.Show("请选择人员分配！", "提醒！")
            Exit Sub
        End If
        If Trim(TextBox_原因分析.Text) = "" Then
            MessageBox.Show("原因分析不能为空！", "提醒！")
            Exit Sub
        End If

        flag = base.初步审核(cId, Trim(Me.TextBox_原因分析.Text))
        If flag = True Then
            Me.Close()
        End If
    End Sub
    Private Sub 售后服务单作业接收时描述_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If getName.Trim <> "" Then ToolStripLabel5.Text = getName
        MsgBox(getName)
    End Sub
    Private Sub 售后服务单作业接收时描述_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = "客户：" & cName & "[" & cWx & "]" & "[" & cId & "]"
        Me.TextBox1.Text = "客户描述：" & cInfo
        Me.TextBox_原因分析.Text = cRemsg
        If Trim(Czrman) = "" Then
            ToolStripLabel5.Text = "[+未分配]"
        Else
            ToolStripLabel5.Text = Czrman
        End If
        Me.Label3.Text = uWxman
        Me.DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname
        DatagridviewEx1.DataSource = Bass.GetwxInfo(Jcode, 1)
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        flag = False
        Me.Close()
    End Sub






    Private Sub showList(ByVal xname As String)
        Try
            If ToolStripLabel5.Text = "[+未分配]" Then
                MessageBox.Show("你还未分配人员，系统无法读取责任人", "提醒")
                Exit Sub
            End If
            Dim mm As New 售后领料
            Dim obj As New SyERP20.F_领料计划单
            obj.Dock = DockStyle.Fill
            mm.Controls.Add(obj)
            mm.Show()
            obj.Base._Paytype = Tool_单号.Text
            obj.ComboBoxBilltype.DataSource = Nothing
            obj.ComboBoxBilltype.Items.Clear()
            obj.ComboBoxBilltype.ResetText()
            obj.ComboBoxBilltype.Items.Add(xname)
            obj.ComboBoxBilltype.Text = xname
            obj.对方名称.Text = cName
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ToolStripLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel5.Click
        Call Fep()
    End Sub

    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel4.Click
        Call Fep()
    End Sub
    Private Sub Xzm()
        Dim seletfrm As New SyERP20.SelectFormBase
        Dim t1 As New TextBox
        seletfrm.ShowEditForm("puku", " and dept='维修员'", t1)
        Dim xz As String = SyERP20.BusGet用户全名byusername(t1.Text)
        If t1.Text <> "" Then
            base.协助人(cId, xz)
            ToolStripLabel9.Text = xz
        End If
    End Sub

    Public Sub Fep()
        Dim xName As String = ""
        '分配人员
        Dim seletfrm As New SyERP20.SelectFormBase
        Dim t1 As New TextBox
        seletfrm.ShowEditForm("puku", " and (dept='维修员' or dept='服务部经理')", t1)
        If t1.Text <> "" Then
            xName = SyERP20.BusGet用户全名byusername(t1.Text)
            flag = base.立即审批(cId, xName)
        End If
        If flag = True Then
            ToolStripLabel5.Text = xName
        End If

    End Sub

    Private Sub ToolStripLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel6.Click

        If Bus_CurrentUser_Fullname = "张太春" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "lxd" Then
            If ToolStripLabel5.Text = "[+未分配]" Then
                MessageBox.Show("你还未分配人员，系统无法读取责任人", "提醒")
                Exit Sub
            End If
            Dim shDD As New 售后领料审核
            shDD.isUname = ToolStripLabel5.Text
            shDD.ShowDialog()
        End If

    End Sub

    Private Sub ToolStripLabel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel7.Click
        If Bus_CurrentUser_Fullname = "张太春" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "lxd" Then
            'If ToolStripLabel5.Text = "[+未分配]" Then
            '    MessageBox.Show("你还未分配人员，系统无法读取责任人", "提醒")
            '    Exit Sub
            'End If
            Dim t As New 售后服务维修问题库
            t.openMe(Trim(Tool_单号.Text), cId)

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ToolStripLabel7_Click(sender, e)
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        If Bus_CurrentUser_Fullname = "张太春" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "lxd" Then
            Call showList("售后服务领料")
        End If


    End Sub

    Private Sub ToolStripLabel9_Click(sender As Object, e As EventArgs) Handles ToolStripLabel9.Click
        Xzm()
    End Sub
End Class