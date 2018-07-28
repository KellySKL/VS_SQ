Imports SyERP.DAL
Public Class 售后服务单历史查询Base
    Public Function GetList(ByVal where As String) As DataTable
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Return db.GetDataSetBySQL("select * from clientservice_AfterServiceBill where left(code,1)<>'*' and isnull(zf4,'')<>'' " & where & " order by code DESC").Tables(0)
        End Using
    End Function
End Class
