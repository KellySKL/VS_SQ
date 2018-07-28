Public Class AppConfig
    '这结构可以做服务器切换
    '便于当前模式开发。

    Private Shared mip As String = ""
    Public Shared M_serverID As String = ""
    Public Shared M_sku As String = "makelanaln|sy2017|zjsq2017|sysanqi|sywt|master|*"
    'Public Shared M_sku As String = "sysanqi|sy2017|zjsq2017|sysanqi|sywt|master|*"
    Public Shared M_pws As String = "5p3iHERYenI=|5p3iHERYenI=|Naa6Uwt1sNxMKEdBeQJAcQ==|5p3iHERYenI=|5p3iHERYenI=|5p3iHERYenI=|5p3iHERYenI="
    Public Shared M_sa As String = "sa"
    Public Shared IsGuest As Boolean = True '测试模式
    Public Shared Islocal As Boolean = False   '本地数据库模式
    Public Shared IsReadtype As Integer = 2 '读取方式  appconfig,Dll,XML(Appconfig.xml)

    Public Shared Function IsBool(ist As Boolean) As Boolean
        If ist Then
            mip = "."
        Else
            mip = "192.168.1.15"
        End If
        M_serverID = mip & "|" & mip & "|47.96.0.251|" & mip & "|121.43.103.228|" & mip & "|" & mip
        Return ist
    End Function
End Class
