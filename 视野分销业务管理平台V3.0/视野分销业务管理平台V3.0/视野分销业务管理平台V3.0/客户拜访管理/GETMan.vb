Public Class GETMan
    Dim bb As New 客户回访管理Base
    Private Sub GETMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.DataSource = bb.GetMan
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        TextBox1.Text = TextBox1.Text & DataGridView1.SelectedRows(0).Cells(1).Value.ToString() & "|"
    End Sub
End Class