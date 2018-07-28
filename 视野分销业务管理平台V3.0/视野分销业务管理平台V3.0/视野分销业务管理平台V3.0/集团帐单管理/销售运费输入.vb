Public Class 销售运费输入
    Private base As New 销售运费输入Base
    Sub New()
        InitializeComponent()
    End Sub
  
    Sub doselect()
        Dim where As String = ""
        If TextBox1.Text <> "" Then
            where += " and (client like '%" & TextBox1.Text & "%' or  code like '%" & TextBox1.Text & "%' or batchnumber like '%" & TextBox1.Text & "%' or  refercode like '%" & TextBox1.Text & "%')  "
        End If
        DataGridView1.DataSource = base.Ge销售清单(date1.Value, date2.Value, where)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "作废" Then
            If MsgBox("您确定要作废吗？", MsgBoxStyle.YesNo) = vbYes Then
                base.删除销售运费(DataGridView1.Rows(e.RowIndex).Cells("单号").Value)
                doselect()
            End If
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "输入" Then
            Dim input As New SyERP20.InputboxForm
            input.Showitem("请输入运费：")
            input.ShowDialog()
            If IsNumeric(input.ReturnBillNote) Then
                base.Set调整业务员(input.ReturnBillNote, DataGridView1.Rows(e.RowIndex).Cells("单号").Value)
                Dim err As New SyERP20.ErrorForm("完成！", Nothing)
                err.ShowDialog()
                doselect()
            End If
        End If

    End Sub

   

    Private Sub 刷新_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新.Click
        doselect()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class