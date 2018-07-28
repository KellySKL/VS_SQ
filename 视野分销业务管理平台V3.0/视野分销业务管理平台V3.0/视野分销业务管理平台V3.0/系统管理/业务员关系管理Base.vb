Imports SyERP.DAL
Public Class 业务员关系管理Base
    Function get业务主管(ByVal 业务员 As String) As ArrayList
        Dim arr As ArrayList
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            arr = c.GetArraylistBySQL("select distinct isnull(billman,'') from salescukuku ")
        End Using
        Return arr
    End Function
    Function get业务员() As ArrayList
        Dim arr As ArrayList
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            arr = c.GetArraylistBySQL("select distinct isnull(turename,'') from puku ")
        End Using
        Return arr
    End Function

    Sub save(ByVal 经理 As String, ByVal 业务员群 As String)
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            c.GetArraylistBySQL("update puku set CanReadedByIntroducer ='" & 业务员群 & "' where userpu='" & 经理 & "'")
        End Using
    End Sub
    Function get业务员By经理全名(ByVal 经理 As String) As String
        Dim str1 As String
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            str1 = c.GetStrBySQL("select CanReadedByIntroducer from puku where turename='" & 经理 & "' ")
        End Using
        Return str1
    End Function
    Function get业务员By经理用户名(ByVal 经理 As String) As String
        Dim str1 As String
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            str1 = c.GetStrBySQL("select CanReadedByIntroducer from puku where userpu='" & 经理 & "' ")
        End Using
        Return str1
    End Function
End Class
