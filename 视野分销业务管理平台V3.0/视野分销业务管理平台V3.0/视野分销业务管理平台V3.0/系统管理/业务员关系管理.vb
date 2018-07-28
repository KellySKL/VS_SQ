Public Class 业务员关系管理
    Private base As New 业务员关系管理Base
    Private Sub 业务员关系管理_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim arr As ArrayList
        arr = base.get业务员()
        For Each str1 As String In arr
            If str1 = "" Then Continue For
            ListView_业务员选择.Items.Add(str1)
        Next
    End Sub
    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_业务员选择.DoubleClick
        Try
            ListView1.Items.Add(ListView_业务员选择.SelectedItems.Item(0).Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button_获得业务员2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_获得业务员2.Click
        Dim t As New SyERP20.SelectFormBase
        t.ShowEditForm("puku", "", TextBox_业务经理)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Panel_选择业务员.Visible = True
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel_选择业务员.Visible = False
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim 业务员串 As String = ""
        For i As Integer = 0 To ListView1.Items.Count - 1
            业务员串 += ListView1.Items(i).Text & ","
        Next
        base.save(TextBox_业务经理.Text, 业务员串)
        Dim err As New SyERP20.ErrorForm("完成", Nothing)
        err.ShowDialog()
    End Sub

    Private Sub TextBox_业务经理_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_业务经理.TextChanged
        ListView1.Items.Clear()
        Dim t As String = base.get业务员By经理用户名(TextBox_业务经理.Text)
        For Each str1 As String In t.Split(",")
            If str1 = "" Then Continue For
            ListView1.Items.Add(str1)
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        For i As Integer = 0 To ListView_业务员选择.Items.Count - 1
            ListView1.Items.Add(ListView_业务员选择.Items(i).Text)
        Next
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        For i As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
            ListView1.Items.RemoveAt(ListView1.SelectedItems(i).Index)
        Next
    End Sub
End Class