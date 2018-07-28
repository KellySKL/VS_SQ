Imports SyERP.DAL
Public Class 业务拜访记录单历史查询Base
    Public Function GetList(ByVal where As String) As DataTable
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Return db.GetDataSetBySQL("select [CODE],[BILLTYPE],[BILLDATE],[Client],[BillMan],[introducer],[introducerDate],[BillNote],[referCode],[finishDATE],[zf1],[zf2],[zf3],[zf4],[zf5],[zf6],[zf7],[zf8],[zf9] ,[zf10],[zf11] ,[zf12] ,[zf13],[zf14] ,[zf15] ,[zf16],[zf17],[zf18] ,[zf19] ,[zf20] ,[zf21],[zf22],[zf23],[zf24],[zf25],[zf26],[zf27] ,[zf28] ,[zf29],[zf30] ,[sz1],[sz2],[sz3],[sz4],[sz5],[sz6],[sz7],[sz8],[sz9],[sz10] ,[rq1],[rq2],[rq3],[rq4],[rq5],notepre,id from clientservice_VisitBill where left(code,1)<>'*' " & where & " order by code ").Tables(0)
        End Using
    End Function
End Class
