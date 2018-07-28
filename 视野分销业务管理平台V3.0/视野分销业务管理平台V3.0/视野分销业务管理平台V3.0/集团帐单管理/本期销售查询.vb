Public Class 本期销售查询
    Private base As New 本期销售查询Base
    Private _where As String

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal date11 As Date, ByVal date12 As Date, ByVal where As String)
        InitializeComponent()
        _where = where
        date1.Value = date11
        date2.Value = date12
    End Sub
    Sub doselect()
        If TextBox1.Text <> "" Then
            _where += " and (client like '%" & TextBox1.Text & "%' or  code like '%" & TextBox1.Text & "%' or batchnumber like '%" & TextBox1.Text & "%' or  refercode like '%" & TextBox1.Text & "%' or  freestr9 like '%" & TextBox1.Text & "%'  or  freestr1 like '%" & TextBox1.Text & "%')  "
        End If
        If CheckBox_包括期初.Checked = True Then
            DataGridView1.DataSource = base.Get客户应收款By业务主管(date1.Value, date2.Value, _where)
        Else
            DataGridView1.DataSource = base.Get客户应收款By业务主管(date1.Value, date2.Value, _where & " and materialname<>'期初录入'")
        End If
        Datagridview列管理Ex1.DataSource = base.Get客户业绩划分By业务主管(date1.Value, date2.Value, _where)
    End Sub
 
    Private Sub toexcel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toexcel.ButtonClick
        '   SyERP20.SaveToXls(DataGridView1, "查询")
        SyERP20.导出EXCELByNPOI(DataGridView1, Me.Label2, "查询", False, True)
    End Sub

    Private Sub 刷新_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新.Click
        doselect()
    End Sub

    Private Sub 本期销售查询_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        doselect()
    End Sub
End Class