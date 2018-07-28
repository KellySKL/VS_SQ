Imports SyERP.DAL
Public Class 本期销售查询Base
    Function Get客户应收款By业务主管(ByVal date1 As Date, ByVal date2 As Date, ByVal where As String) As DataTable
        Dim dt As DataTable
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = c.GetDataSetBySQL("select *  from  SALEScukuKu where  billdate>='" + date1 + "' and billdate<='" + date2 + "' and left(code,1)<>'*'  " & where & " ").Tables(0)
        End Using
        Dim dr As DataRow = dt.NewRow
        dr("client") = "合计"
        dr("amount") = dt.Compute("sum(amount)", "")
        dt.Rows.Add(dr)
        Return dt
    End Function
    Function Get客户业绩划分By业务主管(ByVal date1 As Date, ByVal date2 As Date, ByVal where As String) As DataTable
        Dim dt从 As DataTable
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            where = where.Replace("billman=", "frombillman=")
            dt从 = c.GetDataSetBySQL("select *  from  salescukuku业绩划分 where  billdate>='" + date1 + "' and billdate<='" + date2 + "' and left(code,1)<>'*'  " & where & " ").Tables(0)
        End Using
        For Each row As DataRow In dt从.Rows
            row("金额") = -IIf(IsDBNull(row("金额")), 0, row("金额"))
        Next
        Dim dt到 As DataTable
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            where = where.Replace("frombillman=", "tobillman=")
            dt到 = c.GetDataSetBySQL("select *  from  salescukuku业绩划分 where  billdate>='" + date1 + "' and billdate<='" + date2 + "' and left(code,1)<>'*'  " & where & " ").Tables(0)
        End Using
        For Each row As DataRow In dt到.Rows
            dt从.ImportRow(row)
        Next
        Dim dr As DataRow = dt从.NewRow
        dr("client") = "合计"
        dr("金额") = dt从.Compute("sum(金额)", "")
        dt从.Rows.Add(dr)
        Return dt从
    End Function

End Class
