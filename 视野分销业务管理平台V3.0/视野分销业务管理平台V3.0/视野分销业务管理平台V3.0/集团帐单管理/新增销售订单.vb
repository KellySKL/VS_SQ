Public Class 新增销售订单
    Dim base As New 新增销售订单base
    Public Sub New()
        InitializeComponent()
        DatagridviewEx1.DataSource = base.ProductTable
    End Sub
    Private Sub Tool_保存_Click(sender As Object, e As EventArgs) Handles Tool_保存.Click
        If Com_业务类型.Text = "" Then
            Dim err As New SyERP20.ErrorForm("请选择业务类型", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If TextBox_客户.Text = "" Then
            Dim err As New SyERP20.ErrorForm("请输入客户名称", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If TextBox_业务员.Text = "" Then
            Dim err As New SyERP20.ErrorForm("请输入业务员", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        base._Client = TextBox_客户.Text
        base._BillMan = TextBox_业务员.Text
        base._BILLDATE = Date开始日期.Value
        base._BILLTYPE = Com_业务类型.Text
        base.Add(DatagridviewEx1)
        Dim err1 As New SyERP20.ErrorForm("完成！", Nothing)
        err1.ShowDialog()
        clear()
    End Sub
    Sub clear()
        base.ProductTable.Clear()
        TextBox_客户.Text = ""
        TextBox_业务员.Text = ""
        Com_业务类型.Text = ""
    End Sub
    Private Sub DatagridviewEx1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridviewEx1.CellValueChanged
        If e.RowIndex < 0 Then Exit Sub
        If base.ProductTable.Columns(e.ColumnIndex).ColumnName = "数量" Then
            DatagridviewEx1.Rows(e.RowIndex).Cells("货物代码").Value = "ZDY999999"
            DatagridviewEx1.Rows(e.RowIndex).Cells("货物名称").Value = "系统调账"
        End If
    End Sub
    Private Sub Tool_删行_Click(sender As Object, e As EventArgs) Handles Tool_删行.Click
        If Not DatagridviewEx1.CurrentRow Is Nothing Then
            If DatagridviewEx1.CurrentRow.Index >= 0 Then
                DatagridviewEx1.Rows.RemoveAt(DatagridviewEx1.CurrentRow.Index)
                base.ProductTable.AcceptChanges()
            End If
        End If
    End Sub
End Class
