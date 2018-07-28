Imports SyERP.DAL
Public Class 销售业绩划分输入Base
    Function Ge销售清单(ByVal date1 As Date, ByVal date2 As Date, ByVal where As String) As DataTable
        Dim dt As DataTable
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = c.GetDataSetBySQL("select *  from  SALEScukuKu业绩划分 a where  billdate>='" + date1 + "' and billdate<='" + date2 + "' and left(code,1)<>'*'  " & where & "  ").Tables(0)
        End Using
        Return dt
    End Function

    Function Save销售业绩划分输入(ByVal 金额 As Double, ByVal FromBillman As String, ByVal toBillman As String, ByVal billdate As Date, ByVal ComboBox_客户名称 As String, ByVal 类型 As String, ByVal 备注 As String) As Boolean
        Using conn As New SqlClient.SqlConnection(SqlStr.ConnStringBuilder.ConnectionString)
            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand("INSERT INTO [salescukuku业绩划分]([code],billdate,client,billtype,FromBillman,toBillman,[金额],[introducer],[introducerDate],[BillNote]) VALUES(@code,@billdate,@client,@billtype,@FromBillman,@toBillman,@金额,@introducer,@introducerDate ,@BillNote)", conn)
            command.Parameters.Add("@code", SqlDbType.NVarChar, 255).Value = ""
            command.Parameters.Add("@client", SqlDbType.NVarChar, 255).Value = ComboBox_客户名称
            command.Parameters.Add("@billtype", SqlDbType.NVarChar, 255).Value = 类型
            command.Parameters.Add("@FromBillman", SqlDbType.NVarChar, 255).Value = FromBillman
            command.Parameters.Add("@toBillman", SqlDbType.NVarChar, 255).Value = toBillman
            command.Parameters.Add("@金额", SqlDbType.Decimal).Value = 金额
            command.Parameters.Add("@introducer", SqlDbType.NVarChar, 255).Value = Bus_CurrentUser_Fullname
            command.Parameters.Add("@introducerDate", SqlDbType.DateTime, 255).Value = SyERP20.BuildFrmTo获得服务器时间
            command.Parameters.Add("@billdate", SqlDbType.DateTime, 255).Value = billdate.ToString("yyyy-MM-dd")
            command.Parameters.Add("@BillNote", SqlDbType.NVarChar, 255).Value = 备注
            conn.Open()
            command.ExecuteNonQuery()
            conn.Dispose()
            Return True
        End Using
    End Function

    Function Ge客户清单By经手人(ByVal billman As String) As ArrayList
        Dim arr As ArrayList
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            arr = c.GetArraylistBySQL("select distinct client  from  SALEScukuKu a where   left(code,1)<>'*'  and billman='" & billman & "' ")
        End Using
        Return arr
    End Function
    Function 删除销售运费(ByVal id As Integer) As Boolean
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            c.GetNoneBySQL("update salescukuku业绩划分 set code='*'+code where id=" & id & " ")
        End Using
        Return ""
    End Function
End Class
