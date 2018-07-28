Public Class MainFrm
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_标题栏.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.MaximumSize = My.Computer.Screen.WorkingArea.Size
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_标题栏.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_标题栏.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_标题栏.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_关闭.Click
        Me.Close()
    End Sub

    Private Sub PictureBox_最大化_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_最大化.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.MaximumSize = My.Computer.Screen.WorkingArea.Size
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox_最小化_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_最小化.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

  
    Private Sub TreeControl1_AfterSelect(ByVal tc As Crownwood.DotNetMagic.Controls.TreeControl, ByVal e As Crownwood.DotNetMagic.Controls.NodeEventArgs) Handles TreeControl1.AfterSelect
        If e.Node.Text = "市场客户维护" Then
            Dim t As New SyERP20.SelectFormBase
            t.ShowEditForm("ClientService_kfku", "", New TextBox)
        ElseIf e.Node.Text = "拜访单录入" Then
            Dim t As New Panel
            AddPages("加工编程分配", TabControl1, t)
        ElseIf e.Node.Text = "客户帐单" Then
            Dim t As New 客户对帐单
            AddPages("客户帐单", TabControl1, t)

        End If

    End Sub



    Private Sub TreeControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeControl1.Click

    End Sub

    Private Sub TreeControl1_NodesSelectableChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeControl1.NodesSelectableChanged
      
    End Sub

    Private Sub TreeControl1_UseSelectedFontStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeControl1.UseSelectedFontStyleChanged

    End Sub

    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
