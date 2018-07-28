Imports SyERP.DAL
Public Class 售后服务单作业管理Base
    Public Function Get查询(ByVal whereStr As String) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL("select * from clientservice_AfterServiceBill  where left(code,1)<>'*'  " & whereStr, "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function 立即接收(ByVal id As Integer, ByVal 审核人 As String) As Boolean
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL("update clientservice_AfterServiceBill set zf2='" & 审核人 & "' where id=" & id)
                db.Dispose()

            End Using
        Catch ex As Exception
        End Try
        Return True

    End Function


    Public Function 初步审核(ByVal id As Integer, ByVal 原因分析 As String) As Boolean
        Dim info As Boolean = True

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL("update clientservice_AfterServiceBill set zf3='" & 原因分析 & "' where id=" & id)
                db.Dispose()

            End Using
        Catch ex As Exception
            info = False
        End Try
        Return info

    End Function

    Public Function 立即审批(ByVal id As Integer, ByVal 任务接收人 As String) As Boolean
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL("update clientservice_AfterServiceBill set BillMan='" & 任务接收人 & "', auditing='" & IIf(任务接收人 = "", "", Bus_CurrentUser_Fullname) & "' where id=" & id)
                db.Dispose()
            End Using
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function


    Public Function 协助人(ByVal id As Integer, ByVal otherman As String) As Boolean
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL("update clientservice_AfterServiceBill set zf10='" & otherman & "'  where id=" & id)
                db.Dispose()
            End Using
        Catch ex As Exception
            Return False
        End Try
        Return True

    End Function


End Class
