Imports SyERP.DAL
Public Class loginfrm
    Private base As New LoginBase
    Sub New()
        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
    End Sub
    Private Sub loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If 不可自动登录 = False Then
            If autologin() = True Then Me.Close()
            Me.Activate()
            Me.Focus()
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        '关闭登陆对话框
        Me.Close()
        End
    End Sub

    '鼠标在上面
    Private Sub txt_password_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.MouseHover
        If txt_password.Focused = False Then
            txt_password.Focus() '获得焦点,
        End If
    End Sub
    '鼠标在上面
    Private Sub txt_Username_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Username.MouseHover
        If txt_Username.Focused = False Then
            txt_Username.Focus() '获得焦点,
        End If
    End Sub
    Private Sub txt_Username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Username.KeyPress
        '判断是否是回车键
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txt_password.Focus()
        End If
    End Sub
    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            '是回车键并调用【确定】按钮的单击事件响应函数
            Me.btnSubmit_Click(Nothing, Nothing)
        End If
    End Sub
    '是回车键并调用【确定】按钮的单击事件响应函数
    Public Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim tt As New SyERP.DAL.SqlStr
        tt.ReadSqlServerPath()
        If SqlStr.TestMaiConn() = False Then
            SyERP.DAL.SqlStr.ConnStringBuilderWithMaiDangDang = SyERP.DAL.SqlStr.ConnStringBuilderWithChuDangDang
            Dim T4 As New SyERP20.接口程序说明Base()
            T4.set连接串chuTOmai()
        End If
        If txt_Username.Text.Trim = "" Then Exit Sub
        Dim t As String
        Dim b As New SyERP20.LoginFrmBase
        t = b.UserValidate(txt_Username.Text.Trim, txt_password.Text.Trim, New Label, False)
        If Trim(t) <> "成功" Then
            Dim err As New SyERP20.ErrorForm(t, Nothing)
            err.ShowDialog()
        Else
            Bus_CurrentUser_Username = txt_Username.Text.Trim
            Try
                ' 在线心跳()
                Dim IP As String = ""
                Try
                    IP = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(0).ToString
                Catch ex As Exception
                End Try
                Dim hostname As String = System.Net.Dns.GetHostName() & "[" & IP & "]"
                Try
                    Dim Ver As New IO.StreamReader(Application.StartupPath & "\update.dat", False)
                    Dim var As String = Ver.ReadLine()
                    Bus_SystemSetup_当前版本号 = var
                Catch ex As Exception
                End Try
                Dim ti As String = base.获得客户端最新版本()
                If ti <> "" AndAlso LCase(ti) > LCase(Bus_SystemSetup_当前版本号) Then
                    If MsgBox("发现软件更新包程序(" & ti & ")！ 你需要升级本客户端！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "友情提示") = MsgBoxResult.Ok Then
                        Process.Start(My.Computer.FileSystem.CurrentDirectory & "\升级工具.exe")
                        End
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            Me.Close()
        End If
    End Sub


    Function autologin() As Boolean
        Dim u As String = "", p As String = "", auto As Boolean
        Try
            Dim XmlRead As New Xml.XmlTextReader(Application.StartupPath & "\autologin.xml") '东晓梁系统设置.xml
            Do While XmlRead.Read
                If XmlRead.NodeType = Xml.XmlNodeType.Element Then
                    If XmlRead.Name = "isauto" Then
                        XmlRead.Read()
                        auto = XmlRead.Value = 1 '打印的空白行数
                    End If
                    If XmlRead.Name = "user" Then
                        XmlRead.Read()
                        u = XmlRead.Value '打印的空白行数
                    End If
                    If XmlRead.Name = "password" Then
                        XmlRead.Read()
                        p = XmlRead.Value '软件打开时要的密码
                    End If
                End If
            Loop

            If auto = True Then
                Dim b As New SyERP20.LoginFrmBase
                If b.UserValidate(u, p, Label5, False) <> "成功" Then
                    Return False
                Else
                    Bus_CurrentUser_Username = u
                    Me.Close()
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 数据库设置.Click
        Dim inputfrm As New SyERP20.InputboxForm()
        inputfrm.Showitem("请输入密码：")
        inputfrm.原因.PasswordChar = "●"
        inputfrm.ShowDialog()
        If inputfrm.ReturnBillNote = "" Then Exit Sub
        If Replace(inputfrm.ReturnBillNote, vbCrLf, "") <> "62721120" Then
            Dim t1 As New SyERP20.ErrorForm("密码不正确", Nothing)
            t1.ShowDialog()
            Exit Sub
        End If
        Me.TopMost = False
        Dim err As New SyERP.ConnEnum
        err.ShowDialog()
    End Sub


 



    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Bus_CurrentUser_Username <> "" Then
        Else
            End
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim inputfrm As New SyERP20.InputboxForm()
        inputfrm.Showitem("请输入密码：")
        inputfrm.原因.PasswordChar = "●"
        inputfrm.ShowDialog()
        If inputfrm.ReturnBillNote = "" Then Exit Sub
        If Replace(inputfrm.ReturnBillNote, vbCrLf, "") <> "62721120" Then
            Dim t1 As New SyERP20.ErrorForm("密码不正确", Nothing)
            t1.ShowDialog()
            Exit Sub
        End If
        Me.TopMost = False
    End Sub
End Class