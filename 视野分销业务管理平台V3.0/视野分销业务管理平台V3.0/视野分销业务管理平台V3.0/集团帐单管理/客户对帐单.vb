
Public Class 客户对帐单
    Private base As New 客户对帐单Base

    Private Sub 刷新_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新.Click
        Dim where As String = ""
        If ComboBox_业务主管.Text <> "" And ComboBox_业务主管.Text <> "所有" Then
            where = " and billman ='" & ComboBox_业务主管.Text & "'"
        Else
            Dim t As String = ""
            For i As Integer = 0 To ComboBox_业务主管.Items.Count - 1
                If ComboBox_业务主管.Items(i) = "" Then Continue For
                If ComboBox_业务主管.Items(i) = "所有" Then Continue For
                t += ",'" & ComboBox_业务主管.Items(i) & "'"
            Next
            If t <> "" Then
                where = " and billman in ('-1' " & t & ") "
            End If
        End If
        If TextBox_搜索.Text <> "" Then
            where += " and client like '%" & TextBox_搜索.Text & "%'"
        End If
        DataGridView1.DataSource = base.Get客户应收款By业务主管(date1.Value.ToString("yyyy-MM-dd"), date2.Value.ToString("yyyy-MM-dd"), where)
        DataGridView1.Columns("期初销售").Visible = False
        DataGridView1.Columns("期初收款").Visible = False
    End Sub

    Private Sub 客户对帐单_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBox_业务主管.Items.Add(Bus_CurrentUser_Fullname)
        Dim tt As New 业务员关系管理Base
        For Each str2 As String In tt.get业务员By经理全名(Bus_CurrentUser_Fullname).Split(",")
            ComboBox_业务主管.Items.Add(str2)
        Next
        ComboBox_业务主管.Items.Add("所有")
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        '  SyERP20.SaveToXls(DataGridView1, ComboBox_业务主管.Text & "[" & date1.Value.ToString("yyyy-MM-dd") & "至" & date2.Value.ToString("yyyy-MM-dd") & "]", True, True)

        SyERP20.导出EXCELByNPOI(DataGridView1, Me.Label5, ComboBox_业务主管.Text & "[" & date1.Value.ToString("yyyy-MM-dd") & "至" & date2.Value.ToString("yyyy-MM-dd") & "]", True, True)


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_业务员业绩调整.Click
        Dim t As New 业务员业绩调整
        t.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_主管权限定义.Click
        Dim t As New 业务员关系管理
        t.ShowDialog()
    End Sub

 

    Private Sub Tool_运费输入_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_运费输入.Click
        Dim t As New 销售运费输入
        t.ShowDialog()
    End Sub

    Private Sub Tool_业绩划分_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_业绩划分.Click
        Dim t As New 销售业绩划分输入
        t.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "本期销售" Then
            Dim where As String = ""
            where = " and billman='" & DataGridView1.Rows(e.RowIndex).Cells("业务员").Value & "' and client='" & DataGridView1.Rows(e.RowIndex).Cells("客户名称").Value & "' "
            Dim t2 As New 本期销售查询(date1.Value.ToString("yyyy-MM-dd"), date2.Value.ToString("yyyy-MM-dd"), where)
            t2.ShowDialog()
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "年度累计销售" Then
            Dim where As String = ""
            where += " and billman='" & DataGridView1.Rows(e.RowIndex).Cells("业务员").Value & "' and client='" & DataGridView1.Rows(e.RowIndex).Cells("客户名称").Value & "' "
            Dim t2 As New 本期销售查询("2016-01-01", DateSerial(Now.Year, "12", "31"), where)
            t2.ShowDialog()
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "本期收款" Then
            Dim where As String = ""
            where = " and billman='" & DataGridView1.Rows(e.RowIndex).Cells("业务员").Value & "' and name='" & DataGridView1.Rows(e.RowIndex).Cells("客户名称").Value & "' "
            Dim t2 As New 本期收款查询(date1.Value.ToString("yyyy-MM-dd"), date2.Value.ToString("yyyy-MM-dd"), where)
            t2.ShowDialog()
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "年度累计收款" Then
            Dim where As String = ""
            where = " and billman='" & DataGridView1.Rows(e.RowIndex).Cells("业务员").Value & "' and name='" & DataGridView1.Rows(e.RowIndex).Cells("客户名称").Value & "' "
            Dim t2 As New 本期收款查询("2016-01-01", DateSerial(Now.Year, "12", "31"), where)
            t2.ShowDialog()
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If IsNumeric(e.Value) AndAlso e.Value = 0 Then
            e.Value = DBNull.Value
        End If
    End Sub

    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.RowIndex < 0 Then Exit Sub
        If DataGridView1.SelectedCells.Count >= 2 Then
            Dim tt As Double
            For i As Integer = 0 To DataGridView1.SelectedCells.Count - 1
                tt += IIf(IsNumeric(DataGridView1.SelectedCells(i).Value), DataGridView1.SelectedCells(i).Value, 0)
            Next
            ToolS_框选合计.Text = tt
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim t As New 新增销售订单
        t.ShowDialog()

    End Sub
End Class
