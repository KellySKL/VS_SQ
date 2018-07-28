Imports SyERP.DAL
Public Class 业务员业绩调整Base
    Public Function Get获得业务员1清单查询(ByVal 业务员名称 As String, ByVal where As String) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL("select client as 客户名称,code as 单号,sum(quantity) as 金额,billdate as 开单日期 from salescukuku  where left(code,1)<>'*' and billman='" & 业务员名称 & "' " & where & "  group by code,client,billdate", "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function
    Function Set调整业务员(ByVal 新业务员 As String, ByVal Code As String) As Boolean
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            c.GetNoneBySQL("update salescukuku set guserdef1=isnull(guserdef1,'')+'原业务员:'+ isnull(billman,'')  where code='" & Code & "' ")
            c.GetNoneBySQL("update salescukuku set billman='" & 新业务员 & "'  where code='" & Code & "' ")
            Return True
        End Using
    End Function
End Class
