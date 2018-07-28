Imports SyERP.DAL
Public Class 销售运费输入Base
    Function Ge销售清单(ByVal date1 As Date, ByVal date2 As Date, ByVal where As String) As DataTable
        Dim dt As DataTable
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = c.GetDataSetBySQL("select code as 单号,Client as 客户名称,BillMan as 业务员,max(billdate) as 日期,sum(amount) as 金额,(select sum(运费) from salescukuku运费 where code=a.code) as 运费,[运费记录]=stuff((select ' '+ CONVERT(varchar, introducerDate, 110 )+'运费:'+CONVERT(nvarchar(255), 运费 ) +'；' from salescukuku运费 t where t.code=a.code for xml path('')), 1, 1, '')  from  SALEScukuKu a where  billdate>='" + date1 + "' and billdate<='" + date2 + "' and left(code,1)<>'*'  " & where & " group by code,Client,BillMan ").Tables(0)
        End Using
        Return dt
    End Function

    Function 删除销售运费(ByVal code As String) As Boolean
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            c.GetNoneBySQL("update salescukuku运费 set code='*'+code where code='" & code & "'  ")
        End Using
        Return ""
    End Function
    Function Set调整业务员(ByVal 运费 As Double, ByVal Code As String) As Boolean
        Using conn As New SqlClient.SqlConnection(SqlStr.ConnStringBuilder.ConnectionString)
            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand("INSERT INTO [Sybyxs].[dbo].[salescukuku运费]([code],[运费],[introducer],[introducerDate],[BillNote]) VALUES(@code,@运费,@introducer,@introducerDate ,@BillNote)", conn)
            command.Parameters.Add("@code", SqlDbType.NVarChar, 255).Value = Code
            command.Parameters.Add("@运费", SqlDbType.Decimal, 255).Value = 运费
            command.Parameters.Add("@introducer", SqlDbType.NVarChar, 255).Value = Bus_CurrentUser_Fullname
            command.Parameters.Add("@introducerDate", SqlDbType.DateTime, 255).Value = SyERP20.BuildFrmTo获得服务器时间
            command.Parameters.Add("@BillNote", SqlDbType.NVarChar, 255).Value = ""
            conn.Open()
            command.ExecuteNonQuery()
            conn.Dispose()
            Return True
        End Using
    End Function
End Class
