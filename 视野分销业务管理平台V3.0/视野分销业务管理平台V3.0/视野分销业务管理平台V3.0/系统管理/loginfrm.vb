Imports SyERP.DAL
Public Class loginfrm
    Private base As New LoginBase
    Sub New()
        ' �˵����� Windows ���������������ġ�
        InitializeComponent()
        ' �� InitializeComponent() ����֮������κγ�ʼ����
    End Sub
    Private Sub loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If �����Զ���¼ = False Then
            If autologin() = True Then Me.Close()
            Me.Activate()
            Me.Focus()
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        '�رյ�½�Ի���
        Me.Close()
        End
    End Sub

    '���������
    Private Sub txt_password_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.MouseHover
        If txt_password.Focused = False Then
            txt_password.Focus() '��ý���,
        End If
    End Sub
    '���������
    Private Sub txt_Username_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Username.MouseHover
        If txt_Username.Focused = False Then
            txt_Username.Focus() '��ý���,
        End If
    End Sub
    Private Sub txt_Username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Username.KeyPress
        '�ж��Ƿ��ǻس���
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txt_password.Focus()
        End If
    End Sub
    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            '�ǻس��������á�ȷ������ť�ĵ����¼���Ӧ����
            Me.btnSubmit_Click(Nothing, Nothing)
        End If
    End Sub
    '�ǻس��������á�ȷ������ť�ĵ����¼���Ӧ����
    Public Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim tt As New SyERP.DAL.SqlStr
        tt.ReadSqlServerPath()
        If SqlStr.TestMaiConn() = False Then
            SyERP.DAL.SqlStr.ConnStringBuilderWithMaiDangDang = SyERP.DAL.SqlStr.ConnStringBuilderWithChuDangDang
            Dim T4 As New SyERP20.�ӿڳ���˵��Base()
            T4.set���Ӵ�chuTOmai()
        End If
        If txt_Username.Text.Trim = "" Then Exit Sub
        Dim t As String
        Dim b As New SyERP20.LoginFrmBase
        t = b.UserValidate(txt_Username.Text.Trim, txt_password.Text.Trim, New Label, False)
        If Trim(t) <> "�ɹ�" Then
            Dim err As New SyERP20.ErrorForm(t, Nothing)
            err.ShowDialog()
        Else
            Bus_CurrentUser_Username = txt_Username.Text.Trim
            Try
                ' ��������()
                Dim IP As String = ""
                Try
                    IP = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(0).ToString
                Catch ex As Exception
                End Try
                Dim hostname As String = System.Net.Dns.GetHostName() & "[" & IP & "]"
                Try
                    Dim Ver As New IO.StreamReader(Application.StartupPath & "\update.dat", False)
                    Dim var As String = Ver.ReadLine()
                    Bus_SystemSetup_��ǰ�汾�� = var
                Catch ex As Exception
                End Try
                Dim ti As String = base.��ÿͻ������°汾()
                If ti <> "" AndAlso LCase(ti) > LCase(Bus_SystemSetup_��ǰ�汾��) Then
                    If MsgBox("����������°�����(" & ti & ")�� ����Ҫ�������ͻ��ˣ�", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "������ʾ") = MsgBoxResult.Ok Then
                        Process.Start(My.Computer.FileSystem.CurrentDirectory & "\��������.exe")
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
            Dim XmlRead As New Xml.XmlTextReader(Application.StartupPath & "\autologin.xml") '������ϵͳ����.xml
            Do While XmlRead.Read
                If XmlRead.NodeType = Xml.XmlNodeType.Element Then
                    If XmlRead.Name = "isauto" Then
                        XmlRead.Read()
                        auto = XmlRead.Value = 1 '��ӡ�Ŀհ�����
                    End If
                    If XmlRead.Name = "user" Then
                        XmlRead.Read()
                        u = XmlRead.Value '��ӡ�Ŀհ�����
                    End If
                    If XmlRead.Name = "password" Then
                        XmlRead.Read()
                        p = XmlRead.Value '�����ʱҪ������
                    End If
                End If
            Loop

            If auto = True Then
                Dim b As New SyERP20.LoginFrmBase
                If b.UserValidate(u, p, Label5, False) <> "�ɹ�" Then
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


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���ݿ�����.Click
        Dim inputfrm As New SyERP20.InputboxForm()
        inputfrm.Showitem("���������룺")
        inputfrm.ԭ��.PasswordChar = "��"
        inputfrm.ShowDialog()
        If inputfrm.ReturnBillNote = "" Then Exit Sub
        If Replace(inputfrm.ReturnBillNote, vbCrLf, "") <> "62721120" Then
            Dim t1 As New SyERP20.ErrorForm("���벻��ȷ", Nothing)
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
        inputfrm.Showitem("���������룺")
        inputfrm.ԭ��.PasswordChar = "��"
        inputfrm.ShowDialog()
        If inputfrm.ReturnBillNote = "" Then Exit Sub
        If Replace(inputfrm.ReturnBillNote, vbCrLf, "") <> "62721120" Then
            Dim t1 As New SyERP20.ErrorForm("���벻��ȷ", Nothing)
            t1.ShowDialog()
            Exit Sub
        End If
        Me.TopMost = False
    End Sub
End Class