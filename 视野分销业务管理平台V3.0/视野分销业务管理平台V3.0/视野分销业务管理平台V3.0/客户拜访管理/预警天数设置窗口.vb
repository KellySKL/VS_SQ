Public Class 预警天数设置窗口
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            IO.File.WriteAllText(Application.StartupPath & "\DateType.dat", TextBox1.Text)
        Catch ex As Exception
        End Try
        Dim err3 As New SyERP20.ErrorForm("完成!", Nothing)
        err3.ShowDialog()
        Me.Close()
    End Sub

    Private Sub 工位设置窗口_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim tt As String = IO.File.ReadAllText(Application.StartupPath & "\DateType.dat")
            If tt <> "" Then
                TextBox1.Text = tt
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class