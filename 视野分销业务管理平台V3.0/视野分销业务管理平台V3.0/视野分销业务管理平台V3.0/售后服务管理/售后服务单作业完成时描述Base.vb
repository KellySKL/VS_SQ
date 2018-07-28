Imports SyERP.DAL
Public Class 售后服务单作业完成时描述Base

    Public Function GEtwulist() As DataTable
        Dim dt As DataTable = Nothing
        Dim _str As String = " "
        _str = "select CODE as 物料编号,materialNAME as 物料名称 ,SPECS as 物料型号 ,UNITNAME as 单位,0 as  唯一码 
 from dangdangpuku where LEFT(code,1)<>'*' and materialNAMEspell like '%销售配件库,%'"
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(_str, "noname").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt

    End Function

    Public Function updata内部维修人(ByVal isid As Integer, ByVal isMan As String, ByVal isTxt As String)
        Dim strm As String = ""
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                strm = " update RukuKu set freestr3='" & isTxt & "',freestr4='" & isMan & "' where id=" & isid
                db.GetNoneBySQL(strm)
                db.Dispose()
            End Using
        Catch ex As Exception

        End Try
        Return ""
    End Function

    Public Function getNum(ByVal Acode As String, ByVal Bcode As String, ByVal malecode As String, ByVal maleNmae As String) As Decimal
        Dim strm As String = ""
        Dim getN As Decimal = 0

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                strm = " select sum(QUANTITY) from billnouse2 where paytype='" & Bcode & "' and refercode='" & Acode & "'  and materialCODE='" & malecode & "' and materialName='" & maleNmae & "' and ( billtype='售后维修收费' or billtype='售后保修免费' or billtype='售后新件退还' )  "
                getN = db.GetIntBySQL(strm)
                db.Dispose()
            End Using
        Catch ex As Exception

        End Try
        Return getN
    End Function



    Public Function updata维修作废(ByVal isid As Integer )
        Dim strm As String = ""
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                strm = " update billnouse2 set code='*' + code   where id=" & isid
                db.GetNoneBySQL(strm)
                db.Dispose()
            End Using
        Catch ex As Exception

        End Try
        Return ""
    End Function

    Public Function updata维修量(ByVal isid As Integer, ByVal isNum As Decimal)
        Dim strm As String = ""
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                strm = " update billnouse2 set QUANTITY=" & isNum & "  where id=" & isid
                db.GetNoneBySQL(strm)
                db.Dispose()
            End Using
        Catch ex As Exception

        End Try
        Return ""
    End Function




    Public Function updata提起量(ByVal isid As Integer, ByVal isNum As Decimal)
        Dim strm As String = ""
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                strm = " update billnouse2 set freenum1=" & isNum & "  where id=" & isid
                db.GetNoneBySQL(strm)
                db.Dispose()
            End Using
        Catch ex As Exception

        End Try
        Return ""
    End Function


    Public Function updReback(ByVal sid As Integer, ByVal T1 As Boolean, ByVal T2 As String, ByVal T3 As String, ByVal T6 As String) As String
        Dim rBackinfo As String = ""
        Dim strm As String = ""


        Dim T4 As Integer = 0


        If T1 = False Then
            Try
                Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                    T4 = db.GetIntBySQL("select sz8 from clientservice_AfterServiceBill where id=" & sid)
                    db.Dispose()
                End Using
            Catch ex As Exception
                rBackinfo = ex.Message
            End Try

            T4 = IIf(IsDBNull(T4) Or T4 = 0, 1, T4) + 1
            strm = " update clientservice_AfterServiceBill set zf4= '', zf30 = '" & T2 & "' , zf29='" & T3 & "', zf26='" & T6 & "' ,sz8=" & T4 & ",sz10=0  where id=" & sid
            rBackinfo = "已撤销维修单！"
        End If
        If T1 = True Then
            strm = " update clientservice_AfterServiceBill set zf30 = '" & T2 & "' , zf29='" & T3 & "', zf26='" & T6 & "' ,sz10=2 where id=" & sid
            rBackinfo = "电话回访完成！"
        End If

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(strm)
                db.Dispose()
            End Using
        Catch ex As Exception
            rBackinfo = ex.Message
        End Try
        Return rBackinfo
    End Function


    Public Function showCode(ByVal isTabl As String, ByVal isLy As String)

        Dim 序号 As Integer = 0
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                Dim CODEDB As String
                CODEDB = db.GetStrBySQL(" select code from " & isTabl & " where left(code,10)='" & isLy & "'+CONVERT(varchar(12), getdate(),112)  order by id desc ")
                If Len(CODEDB) >= 4 Then
                    序号 = Val(Right(CODEDB, 4)) + 1
                Else
                    序号 = 1
                End If
                db.Dispose()
            End Using
        Catch ex As Exception
            序号 = 1
        End Try
        Return 序号
    End Function

    Public Function _setMsg(ByVal _where As String) As String
        Dim str As String = ""

        Dim filed1 As String = "code,tablename,send,sendnote,senddate,master,masterNote,MasterDate,billstatus,Sendto,inceptsign,inceptdate,SchemeDate,inceptNote,finishdate,finishNote,GUSERDEF1,GUSERDEF2,GUSERDEF3,GUSERDEF4)"


        str = "insert into statusku (" + filed1 + " values(" + _where + ""


        Dim reInfo As String = "消息发送成功！"
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(str)
                db.Dispose()
            End Using

        Catch ex As Exception
            reInfo = ex.Message
        End Try
        Return reInfo
    End Function

    Public Function updateme(ByVal sid As Integer, ByVal T1 As String, ByVal T2 As String, ByVal T3 As String, ByVal T4 As String) As String

        Dim rBackinfo As String
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL("update BILLnouse2 set freestr4='" & T1 & "',freestr8='" & T2 & "',freestr9='" & T3 & "' ,freestr7='" & T4 & "' where id=" & sid)
                db.Dispose()
                rBackinfo = "ok"
            End Using
        Catch ex As Exception
            rBackinfo = ex.Message
        End Try
        Return rBackinfo
    End Function



    Public Function readCkNum(ByVal pT1 As String, ByVal pT2 As String, ByVal pT3 As String, ByVal pT4 As String) As Decimal
        Dim ReNum As Decimal = 0
        Dim _str As String = "select SUM(QUANTITY) from cukuku  where BILLTYPE ='售后计划领料' and  Paytype ='" & pT1 & "' and referCode ='" & pT2 & "' and materialCODE ='" & pT3 & "' and materialNAME='" & pT4 & "' "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                ReNum = db.GetIntBySQL(_str)
                db.Dispose()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ReNum
    End Function





    Public Function ADD消除借条(ByVal where As String) As String

        Dim rBackinfo As String
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(where)
                db.Dispose()
                rBackinfo = "消除借条已完成，并通知相关部门做单据处理！"
            End Using
        Catch ex As Exception
            rBackinfo = ex.Message
        End Try
        Return rBackinfo
    End Function





    Public Function Get查询(ByVal where As String) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL("select * from  clientservice_AfterServiceBill  where left(code,1)<>'*' " & where, "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function Get单条物料D(ByVal T1 As String, ByVal T2 As String, ByVal T3 As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim str As String = " select * from  BILLnouse2  where left(code,1)<>'*' and billtype='" & T1 & "' and code ='" & T2 & "' and  Paytype ='" & T3 & "' "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(str, "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function Get单条物料byID(ByVal Pid As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim str As String = " select materialCODE ,materialNAME ,SPECS , UNITNAME ,QUANTITY,introducer  from  BILLnouse2  where id='" + Pid + "'"
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(str, "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function


    Public Function Get单条物料(ByVal T1 As String, ByVal T2 As String, ByVal T3 As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim str As String = " select * from  BILLnouse2  where left(code,1)<>'*' and billtype='" & T1 & "' and code ='" & T2 & "' and  Paytype ='" & T3 & "' "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(str, "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function


    Public Function getWxkk(ByVal code As String) As DataTable
        Dim dt As New DataTable
        Dim sqlr = "   select * from RukuKu  where StorageName ='维修零件库' and BILLTYPE ='售后待维修' and Paytype ='" & code & "' and LEFT(CODE,1)<>'*'"
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(sqlr, "noname").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetppaLL(ByVal code As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim isTr As String

        '售后新件退还
        Dim sqlGG As String = " (select sum(rukuku.quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*'  and  rukuku.billtype='售后领料归还' and rukuku.paytype='" & code & "' and rukuku.refercode=billnouse2.code )   "
        '维修零件结算
        Dim sqlMM As String = " (select sum(salescukuku.quantity) from salescukuku where salescukuku.freestr10 like '%'+billnouse2.freestr10+'%' and salescukuku.materialCODE=billnouse2.materialCODE   and left(salescukuku.code,1)<>'*' and  salescukuku.billtype='维修零件结算' and billnouse2.billtype<>'售后服务领料' and salescukuku.freestr8='" & code & "' and salescukuku.refercode=billnouse2.code )    "
        '售后新件销售
        Dim sqlCC As String = " (select sum(salescukuku.quantity) from salescukuku where salescukuku.freestr10 like '%'+billnouse2.freestr10+'%' and salescukuku.materialCODE=billnouse2.materialCODE   and left(salescukuku.code,1)<>'*' and  salescukuku.billtype='售后新件销售' and billnouse2.billtype<>'售后服务领料' and salescukuku.freestr8='" & code & "' and salescukuku.refercode=billnouse2.code )    "
        '借用拆回
        Dim sqlBB As String = " (select sum(rukuku.quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*' and  rukuku.billtype='售后借用拆回' and billnouse2.billtype<>'售后服务领料' and rukuku.freestr8='" & code & "' and rukuku.refercode=billnouse2.code )    "
        '新件报废
        Dim sqlAA As String = " (select sum(rukuku.quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*' and  rukuku.billtype='售后新件报废' and billnouse2.billtype<>'售后服务领料' and rukuku.freestr8='" & code & "' and rukuku.refercode=billnouse2.code )    "
        '售后返厂维修
        Dim sqlTT As String = " (select sum(m_rukuku.数量) from m_rukuku where m_rukuku.关联号=billnouse2.code and m_rukuku.编号=billnouse2.materialCODE   and left(m_rukuku.code,1)<>'*' and m_rukuku.is完成=4  and billnouse2.billtype<>'售后服务领料' )"


        isTr = "select * ,  "
        isTr &= " (case when billtype='售后服务领料'  then code "
        isTr &= " when billtype='维修零件结算'        then  referCode "
        isTr &= " when billtype='售后新件销售'        then  referCode "
        isTr &= " when billtype='借用拆回'            then  referCode "
        isTr &= " when billtype='新件报废'            then  referCode "
        isTr &= " when billtype='售后新件退还'        then  referCode "
        isTr &= " when billtype='售后返厂维修'        then  referCode "
        isTr &= " Else null end )as 分配组, "
        isTr &= " (case when  billtype='售后服务领料'  then freenum1 "
        isTr &= "  when   billtype='售后新件退还'      then  ( " & sqlGG & " )   "
        isTr &= "  when   billtype='售后新件销售'      then  ( " & sqlCC & " )  "
        isTr &= "  when   billtype='维修零件结算'      then  ( " & sqlMM & " )  "
        isTr &= "  when   billtype='借用拆回'          then  ( " & sqlBB & " )  "
        isTr &= "  when   billtype='新件报废'          then  ( " & sqlAA & " )  "
        isTr &= "  when   billtype='售后返厂维修'      then  ( " & sqlTT & " )  "
        isTr &= "  elsE 0 end ) as 已处理量  "

        isTr &= "  from BILLnouse2  where left(code,1)<>'*' and ( billtype='售后服务领料' or  billtype='售后新件退还' or billtype='维修零件结算' or billtype='售后新件销售' or billtype='借用拆回' or billtype='新件报废' or billtype='售后返厂维修'  ) and paytype='" & code & "' order by 分配组  "



        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(isTr, "noname").Tables(0)
                dt.Columns.Add("欠量", System.Type.GetType("System.Decimal"), "isnull(QUANTITY,0)-isnull(已处理量,0)")
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function
    Public Function GetppaLL22(ByVal code As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim isTr As String




        Dim sqlGG As String = " (select sum(rukuku.quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*'  and  rukuku.billtype='售后领料归还' and rukuku.paytype='" & code & "'  )   "
        Dim sqlMM As String = " (select sum(cukuku.quantity) from cukuku where cukuku.freestr10 like '%'+billnouse2.freestr10+'%' and cukuku.materialCODE=billnouse2.materialCODE   and left(cukuku.code,1)<>'*' and  cukuku.billtype='售后保修免费' and billnouse2.billtype<>'售后服务领料' and cukuku.freestr8='" & code & "' )    "
        Dim sqlNN As String = "  (select sum(quantity) from salescukuku where  salescukuku.freestr10 like '%'+billnouse2.freestr10+'%'  and salescukuku.materialCODE=billnouse2.materialCODE and left(salescukuku.code,1)<>'*' and salescukuku.billtype<>'售后服务领料' and salescukuku.freestr8='" & code & "' )    "


        isTr = "select * ,  "
        isTr &= " (case when billtype='售后服务领料' then code "
        isTr &= " when billtype='售后保修免费' then referCode "
        isTr &= " when billtype='售后维修收费' then  referCode "
        isTr &= " when billtype='售后新件退还' then  referCode "
        isTr &= " else null end )as 分配组, "
        isTr &= " (case when  billtype='售后服务领料'  then freenum1 "
        isTr &= "          when   billtype='售后新件退还' then  ( " & sqlGG & " )   "
        isTr &= "       when   billtype='售后保修免费' then  ( " & sqlMM & " )  "
        isTr &= "       when   billtype='售后维修收费' then ( " & sqlNN & "  ) "
        isTr &= "  else 0 end ) as 已处理量  "

        isTr &= "  from BILLnouse2  where left(code,1)<>'*' and ( billtype='售后服务领料' or  billtype='售后维修收费' or  billtype='售后保修免费' or  billtype='售后新件退还'   ) and paytype='" & code & "' order by 分配组  "



        'Dim sqlGG As String = " (select sum(rukuku.quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*'  and  rukuku.billtype='售后领料归还' and rukuku.paytype='" & code & "'  )   "
        'Dim sqlMM As String = " (select sum(cukuku.quantity) from cukuku where cukuku.freestr10 like '%'+billnouse2.freestr10+'%' and cukuku.materialCODE=billnouse2.materialCODE   and left(cukuku.code,1)<>'*' and  cukuku.billtype='售后保修免费' and billnouse2.billtype<>'售后服务领料' and cukuku.freestr8='" & code & "' )    "
        'Dim sqlNN As String = "  (select sum(quantity) from salescukuku where  salescukuku.freestr10 like '%'+billnouse2.freestr10+'%'  and salescukuku.materialCODE=billnouse2.materialCODE and left(salescukuku.code,1)<>'*' and salescukuku.billtype<>'售后服务领料' and salescukuku.freestr8='" & code & "' )    "


        'isTr = "select * ,  "
        'isTr &= " (case when billtype='售后服务领料' then code "

        'isTr &= " else null end )as 分配组, "
        'isTr &= " (case when  billtype='售后服务领料'  then ( " & sqlGG & " - " & sqlMM & " - " & sqlNN & " ) "

        'isTr &= "  else 0 end ) as 已处理量  "

        'isTr &= "  from BILLnouse2  where left(code,1)<>'*' and ( billtype='售后服务领料' or  billtype='售后维修收费' or  billtype='售后保修免费' or  billtype='售后新件退还'   ) and paytype='" & code & "' order by 分配组  "

        'Dim newStr As New msgboxmm(isTr)


        'isTr = "select * ,  "
        'isTr &= " (case when billtype='售后服务领料' then code "
        'isTr &= " when billtype='售后保修免费' then referCode "
        'isTr &= " when billtype='售后维修收费' then  referCode "
        'isTr &= " when billtype='售后新件退还' then  referCode "
        'isTr &= " else null end )as 分配组, "
        'isTr &= " (case when  (billtype='售后服务领料' OR BILLTYPE ='售后新件退还')  then (select sum(quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*'  and   billtype='售后领料归还' and paytype='" & code & "'  )   "
        'isTr &= "       when   billtype='售后保修免费' then (select sum(quantity) from cukuku where cukuku.freestr10 like '%'+billnouse2.freestr10+'%' and cukuku.materialCODE=billnouse2.materialCODE   and left(cukuku.code,1)<>'*' and  billtype='售后保修免费' and billnouse2.billtype<>'售后服务领料' and freestr8='" & code & "' )  "
        'isTr &= "       when   billtype='售后维修收费' then (select sum(quantity) from salescukuku where  salescukuku.freestr10 like '%'+billnouse2.freestr10+'%'  and salescukuku.materialCODE=billnouse2.materialCODE and left(salescukuku.code,1)<>'*' and billnouse2.billtype<>'售后服务领料' and freestr8='" & code & "' )    "
        'isTr &= "  else 0 end ) as 已处理量  "

        'isTr &= "  from BILLnouse2  where left(code,1)<>'*' and ( billtype='售后服务领料' or  billtype='售后维修收费' or  billtype='售后保修免费' or  billtype='售后新件退还'   ) and paytype='" & code & "' order by 分配组  "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(isTr, "noname").Tables(0)
                dt.Columns.Add("欠量", System.Type.GetType("System.Decimal"), "isnull(QUANTITY,0)-isnull(已处理量,0)")
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function


    Public Function GetggaLL(ByVal code As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim isTr As String
        isTr = "select * ,  "
        isTr &= " (case when billtype='售后返厂维修' then code "
        isTr &= " when billtype='售后返厂报废' then referCode "
        isTr &= " when billtype='售后采购维修' then referCode "
        isTr &= " when billtype='售后生产维修' then referCode "
        isTr &= " else null end )as 分配组, "
        isTr &= "(case when (billtype='售后返厂维修' OR BILLTYPE ='售后返厂报废')  then  (select sum(quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and  refercode=billnouse2.code  and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*'  and ( billtype='售后待维修' or  billtype='售后报废') and paytype='" & code & "' )   "
        isTr &= "  when   billtype='售后采购维修' then (select sum(quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and  refercode=billnouse2.code  and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*'  and  ( billtype='内部维修归还' or billtype='售后报废' ) and freestr4='采购部'  and paytype='" & code & "' )   "
        isTr &= "  when   billtype='售后生产维修' then (select sum(quantity) from rukuku where rukuku.freestr10 like '%'+billnouse2.freestr10+'%' and  refercode=billnouse2.code  and rukuku.materialCODE=billnouse2.materialCODE   and left(rukuku.code,1)<>'*'  and  ( billtype='内部维修归还' or billtype='售后报废' ) and freestr4='生产部' and paytype='" & code & "' )   "
        isTr &= "  else 0 end ) as 已处理量  "
        isTr &= "  from BILLnouse2  where left(code,1)<>'*' and (  billtype='售后返厂维修' or  billtype='售后返厂报废' or  billtype='售后采购维修' or  billtype='售后生产维修' ) and paytype='" & code & "' order by refercode  "

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(isTr, "noname").Tables(0)
                dt.Columns.Add("欠量", System.Type.GetType("System.Decimal"), "isnull(QUANTITY,0)-isnull(已处理量,0)")
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return dt
    End Function


 
    Public Function Get获得售后服务单清单查询(ByVal code As String) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL("select * from salescukuku  where left(code,1)<>'*' and materialname='售后服务费' and refercode='" & code & "' ", "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function
    Public Function 立即完成(ByVal 单号 As String, ByVal 审核人 As String, ByVal 结论 As String, ByVal 分析 As String) As Boolean
        Dim isboo As Boolean = False
        Dim isTnnn As String = ""

        If 审核人 = "no" Then
            isTnnn = "update clientservice_AfterServiceBill set  zf5='" & 结论 & "',zf3='" & 分析 & "'  where code='" & 单号 & "'"
        Else
            isTnnn = "update clientservice_AfterServiceBill set zf4='" & 审核人 & "' ,sz10=1  where code='" & 单号 & "' "
        End If


        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(isTnnn)
                db.Dispose()
                isboo = True

            End Using
        Catch ex As Exception
            isboo = False
        End Try
        Return isboo
    End Function
    Public Function 故障类别(ByVal 单号 As String) As String
        Dim isDD As String = ""
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                isDD = db.GetStrBySQL("select zf7 from clientservice_AfterServiceBill  where code='" & 单号 & "'")
                db.Dispose()
            End Using
        Catch ex As Exception
        End Try
        Return isDD
    End Function


    Public Sub AddSave(ByVal str As String)
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(str)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
