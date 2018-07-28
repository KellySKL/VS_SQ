Imports SyERP.DAL
Public Class 本期收款查询Base
    Function Get客户应收款By业务主管(ByVal date1 As Date, ByVal date2 As Date, ByVal where As String) As DataTable
        Dim dt As DataTable
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = c.GetDataSetBySQL("select *  from  shoujiaidangKu where  PayedDate>='" + date1 + "' and PayedDate<='" + date2 + "' and left(code,1)<>'*'  " & where & " ").Tables(0)
            Dim dr As DataRow = dt.NewRow
            dr("name") = "合计"
            dr("amount") = dt.Compute("sum(amount)", "")
            dt.Rows.Add(dr)


        End Using
        Return dt
    End Function
End Class
