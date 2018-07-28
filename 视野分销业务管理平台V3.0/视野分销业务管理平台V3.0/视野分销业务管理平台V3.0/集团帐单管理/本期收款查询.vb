Public Class 本期收款查询
    Private base As New 本期收款查询Base
    Sub New()
        InitializeComponent()
    End Sub
    Sub New(ByVal date1 As Date, ByVal date2 As Date, ByVal where As String)
        InitializeComponent()
        If TextBox1.Text <> "" Then
            where += " and (name like '%" & TextBox1.Text & "%' or billman like '%" & TextBox1.Text & "%' or  code like '%" & TextBox1.Text & "%')  "
        End If
        DataGridView1.DataSource = base.Get客户应收款By业务主管(date1, date2, where)
    End Sub

    Private Sub toexcel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toexcel.ButtonClick
        'SyERP20.SaveToXls(DataGridView1, "收款查询")
        SyERP20.导出EXCELByNPOI(DataGridView1, Me.Label2, "收款查询", False, True)
    End Sub
End Class