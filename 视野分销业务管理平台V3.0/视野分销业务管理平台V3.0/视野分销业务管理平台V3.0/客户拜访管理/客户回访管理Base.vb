Imports SyERP.DAL
Public Class 客户回访管理Base

    Public Function GetPMan() As DataTable
        Dim dt As New DataTable
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = db.GetDataSetBySQL("select turename as 名字,dept as 职位  from puku where isstop='否' or disstop='' ").Tables(0)
        End Using
        Return dt
    End Function
    Public Function GetMan() As DataTable
        Dim dt As New DataTable
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = db.GetDataSetBySQL("select turename as 名字,dept as 职位  from puku where isstop='否' or disstop='' ").Tables(0)
        End Using
        Return dt
    End Function
    Public Function Get查询(ByVal whereStr As String) As DataTable
        Dim dt As DataTable = Nothing
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            '  Return db.GetDataSetBySQL("select [CODE],[BILLTYPE],[BILLDATE],convert(varchar(10),DATEDIFF(day, getdate(), (select top 1 rq1 from clientservice_kfku where name=client)))+'天' as 倒计时,[Client],[BillMan],[introducer],[introducerDate],[BillNote],[referCode],[finishDATE],[zf1],[zf2],[zf3],[zf4],[zf5],[zf6],[zf7],[zf8],[zf9] ,[zf10],[zf11] ,[zf12] ,[zf13],[zf14] ,[zf15] ,[zf16],[zf17],[zf18] ,[zf19] ,[zf20] ,[zf21],[zf22],[zf23],[zf24],[zf25],[zf26],[zf27] ,[zf28] ,[zf29],[zf30] ,[sz1],[sz2],[sz3],[sz4],[sz5],[sz6],[sz7],[sz8],[sz9],[sz10] ,[rq1],[rq2],[rq3],[rq4],[rq5],notepre,id from clientservice_VisitBill where left(code,1)<>'*' " & whereStr & where只能看到本区域 & " order by code ").Tables(0)
            dt = db.GetDataSetBySQL("select convert(int,DATEDIFF(day, getdate(), rq1)) as 倒计时,*,(select top 1 notepre from clientservice_VisitBill where client=ClientService_kfku.name and left(code,1)<>'*' order by id desc) as 最近一次拜访内容,(select top 1 count(id) from clientservice_VisitBill where client=ClientService_kfku.name and left(code,1)<>'*') as 拜访次数 from ClientService_kfku where 1=1  " & whereStr & " order by 倒计时 ").Tables(0)
            'dt = db.GetDataSetBySQL("select convert(int,DATEDIFF(day, getdate(), rq1)) as 倒计时,*, code as 最近一次拜访内容, code as 拜访次数 from ClientService_kfku where 1=1  " & whereStr & " order by 倒计时 ").Tables(0)
        End Using
        Return dt
    End Function



 

    Public Function _updateHF() As String
        Dim _where As String
        _where = "update ClientService_kfku set 回访间隔  = (select sz1 from LEVku where levku.lev=clientservice_kfku.LEV )"
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL(_where)

            db.Dispose()
        End Using
        Return "数据更新成功！"
    End Function

    Public Function _showHFnote(ByVal GSnAME As String, ByVal isNum As Integer) As String
        Dim _where As String = ""
        Dim showStr As String = ""
        If isNum = 1 Then _where = "select top 1 notepre from clientservice_VisitBill where client='" & GSnAME & "' and left(code,1)<>'*'"
        If isNum = 2 Then _where = "select top 1 count(id) from clientservice_VisitBill where client='" & GSnAME & "' and left(code,1)<>'*'"
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            showStr = db.GetStrBySQL(_where)
            db.Dispose()
        End Using
        Return showStr
    End Function


End Class
