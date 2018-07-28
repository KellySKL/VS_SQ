Imports SyERP.DAL
Public Class 新建客户查询base

    Public getDataTime As String = ""

    Public Function _show业务员() As DataTable
        Dim dt As New DataTable
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL("select (FULLNAMEspell + '[' + cast(count(name)  as varchar(50)) +'家]') as 业务员 from clientservice_kfku   group by FULLNAMEspell  ", "noname").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function


    Public Function _show客户类型() As DataTable
        Dim dt As New DataTable
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL("select text from item16", "noname").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function



    Public Function _show客户信息(ByVal _FuName As String, ByVal _lxName As String) As DataTable
        Dim dt As New DataTable
        Dim newDt As New DataTable
        Dim dtStr As String = " and  TRADETYPENAME ='" & _lxName & "' and FULLNAMEspell='" & _FuName & "' "
        Dim _str As String = "select rq2 as 创建时间 , fullnamespell as 创建人, TRADETYPENAME   as 客户类型 ,(select COUNT(client) from clientservice_VisitBill where client = clientservice_kfku.NAME) as 回访次数,   NAME as 公司名称 ,  CONTACTOR as 联系人,  PHONE as 手机,ZF8 as 职位,AREANAME as 地区 , LEV as 等级 , CONTACTORspell as 地址,REMARK as 备注 from clientservice_kfku where 1=1 "

        Try

            If _FuName = "查询所有客户" Then dtStr = "  and  TRADETYPENAME ='" & _lxName & "' "
            If _lxName = "汇总表" Or _lxName = "绩效表" Then dtStr = "   and  ( FULLNAMEspell like '%" & _FuName & "%'  or name like '%" & _FuName & "%' or contactor like '%" & _FuName & "%'  )"
            If _FuName = "查询所有客户" And _lxName = "汇总表" Then dtStr = "   "
            If getDataTime = "notime" Then getDataTime = " "
         
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(_str & dtStr & getDataTime, "noname").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
        End Try



        
            Return dt


    End Function


End Class
