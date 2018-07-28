Imports SyERP.DAL
Public Class LoginBase
  


    Public Function 获得客户端最新版本() As String
        Dim 客户端最新版本 As String = ""
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Try
                客户端最新版本 = c.GetStrBySQL("select top 1 Ver  from [UpdateVer] ")

            Catch ex As Exception
            End Try
            c.Dispose()
        End Using
        Return 客户端最新版本
    End Function

End Class
