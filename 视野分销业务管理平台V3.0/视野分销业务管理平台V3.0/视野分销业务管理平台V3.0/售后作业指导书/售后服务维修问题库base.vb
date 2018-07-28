Imports SyERP.DAL
Public Class 售后服务维修问题库base
    Public isddBan As String
    Public isKf As Integer = 0

    Public Function _rz_getList(ByVal addNum As Integer, Optional ByVal isTys As Integer = 0, Optional ByVal mId As Integer = -1) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                Dim getlist As String = ""
                getlist = Trim(db.GetStrBySQL("select ubb from m_zylist where  del <>1 and mtitle  ='" & Trim(isddBan) & "' ").ToString)
                getlist = "'" & Replace(Trim(getlist), ",", "','") & "'"
                '获取版本继承 
                Dim _str As String = " "
                Dim getKf As String = ""
                If isKf = 1 Then
                    getKf = " and iskf=1 "
                Else
                    getKf = "  "
                End If
                Dim isst As String = "  and del<>1 " & getKf & "  and  ubb in (" & getlist & ")  "
                _str = "select id, fid, istype, ftitle, mtitle, nid,  iskF from  m_zylist where fid=" & addNum & " and  istype >= 0  " & isst & "  order by orderbyId "
                If addNum = -1 Then _str = "select id, fid, istype, ftitle, mtitle, nid,  iskF from  m_zylist  " & isst & "    order by orderbyId "
                'If addNum = 0 Then _str = "select * from  m_zylist where ( fid=0 or  fid in (select id from  m_zylist where fid=0 ) )  " & isst & "    order by fid"
                If addNum = 0 Then _str = "select id, fid, istype, ftitle, mtitle, nid,  iskF from  m_zylist where  fid=0    " & isst & "    order by  id"


                '读取 56783
                If isTys = 1 Then _str = "select id, fid, istype, ftitle, mtitle,  iskF  from  m_zylist where fid=" & addNum & " and  istype in (5,6,7,8,3)  " & isst & "  order by orderbyId "

                If isTys = 2 Then _str = "select id, fid, istype, ftitle, mtitle from m_zylist where fid=" & addNum & "  and istype in (5,6,7,8,3)  and del<>1 order by istype desc  "

                If isTys = 3 Then _str = "select mtitle, imager form m_zylist where id=" & mId

                If isTys = 4 Then _str = "select top 1  fid, istype, mtitle from m_zylist where fid=" & addNum & "  and istype =5  and del<>1 order by istype desc  "


                dt = db.GetDataSetBySQL(_str, "makelanlan").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function


    Public Function _rz_getwllist(ByVal id As Integer) As DataTable
        Dim dt As DataTable = Nothing
        Dim _str As String
        _str = "select  materialNAME as 物料, SPECS as 型号, UNITNAME as 单位,sNum as 数量 , SPECSspell as 代码,  jc as 设备 ,code as 编号 from m_zywul where fid = " & id
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(_str, "makelanlan").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function
    Public Function _rz_wllist(ByVal id As Integer) As String
        Dim str As String = ""
        Dim csqlStr As String = "select top 1 rtitle  from m_zyRecode where id=" & id
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                str = db.GetStrBySQL(csqlStr)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return str
    End Function

    Public Function _rs_wlCode(ByVal cd As String, ByVal wNum As Decimal, Optional ByVal hh As Integer = -1) As DataTable
        Dim dt As New DataTable
        Dim tm As String = ""

        If hh = -1 Then
            tm = " and SPECSspell ='" & cd & "'"
        Else
            tm = " and  code ='" & cd & "'"
        End If
        '  Dim isBinfo As String = " select SPECSspell as 物料代码,CODE as 编号,materialNAME as 物料 ,SPECS as 型号 ,UNITNAME as 单位   from dangdangpuku where left(code,1)<>'*' and materialNAMEspell like '%销售配件库%' where SPECSspell ='" & cd & "'"
        Dim isBinfo As String = " select top 1 SPECSspell as 物料代码,CODE as 编号,materialNAME as 物料 ,SPECS as 型号 ,UNITNAME as 单位   from dangdangpuku where left(code,1)<>'*'  " & tm

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(isBinfo, "makelanlan").Tables(0)
                dt.Columns.Add("数量", System.Type.GetType("System.Decimal"), wNum)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
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


    Public Sub delWxList(ByVal jc As String)
        Dim str As String = "update  m_zyrecode set del = 1 where wcode ='" & jc & "'"

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(str)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub upListCode(ByVal wx As String, ByVal jc As String)
        Dim str As String = "update  m_zyrecode set wcode ='" & wx & "' where wcode ='" & jc & "'"

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(str)
                db.Dispose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

 

    Public Function getlistinfo(ByVal cTcode As String, Optional ByVal outINum As Integer = 0) As DataTable
        Dim dt As DataTable = Nothing
        Dim otStr As String = ""
        Dim otNum As Integer = 0
        Dim subTitle As String = "结果"
        Dim subltitle As String = "检查项"
        If outINum = 0 Then
            otNum = 0
        Else
            otNum = 1
        End If

        If outINum = 1 Then
            otStr = " and ( ltitle like '方案%'    or ltitle like '附件%'  ) "
            subTitle = "方案" '附件及其方案
            subltitle = "归属"
        End If

        If outINum = 2 Then
            otStr = " and  ltitle = '物料'  "
            subTitle = "物料" '物料情况
            subltitle = "归属"
        End If
    
        If outINum = 3 Then
            otStr = " and  ltitle ='工具'  "
            subTitle = "工具" '工具
            subltitle = "归属"
        End If


        Dim str As String = "select nstep as 序号,uname as 维修员,ltitle as " & subltitle & " ,mtitle as 问题 ,rtitle as  " & subTitle & " ,fid as BN ,isRed ,id  from  m_zyrecode  where   wcode='" & cTcode & "' and del=0 and isshow=" & otNum & otStr & "   order by nstep desc "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(str, "noname").Tables(0)
                db.Dispose()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提醒")
        End Try
        Return dt
    End Function



    Public Function GetwxInfo(ByVal cTcode As String, Optional ByVal cjsNum As Integer = 0) As DataTable
        Dim dt As DataTable = Nothing
        Dim cjStr As String = "select top 1 * from  clientservice_AfterServiceBill  where left(code,1)<>'*'  and code='" & cTcode & "' "
        If cjsNum = 1 Then   cjStr = "select  * from  clientservice_AfterServiceBill  where left(code,1)<>'*'  and  zf1='" & cTcode & "' "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                dt = db.GetDataSetBySQL(cjStr, "noname").Tables(0)
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function


    Public Function getBbName(ByVal cTcode As String) As String
        Dim st As String = " "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                st = db.GetStrBySQL("select top 1 jc_ban from  cukku_SerialNumber  where 出厂编号='" & cTcode & "' ")
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return st
    End Function



    '------------获取附件----------------
    Public Function getFjls(ByVal oid As Integer, ByVal iid As Integer) As DataTable
        Dim st As New DataTable
        Dim str As String = ""
        If iid = 1 Then str = "select fimg,mtitle  from m_zyimg where fid='" & oid & "' and istype = 1 and del <> 1   " '获取附件
        If iid = 2 Then str = "select mtitle,etitle  from m_zyimg where fid='" & oid & "' and istype = 2 and del <> 1   " '获取问题

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                st = db.GetDataSetBySQL(str, "noname").Tables(0)
                'If iid = 1 Then
                '    st.Columns.Add("nn", System.Type.GetType("System.Integer"), "isnull(QUANTITY,0)-isnull(已处理量,0)")
                'End If
                db.Dispose() : End Using
        Catch ex As Exception
        End Try
        Return st
    End Function


    Public Function _rz_getFname(ByVal fid As Integer) As String
        Dim Fname As String = ""
        Dim NextId As Integer = fid
        Dim Flist As String = ""
        Dim Fdata As New DataTable
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)

                For i As Integer = 0 To 100
                    Dim _str As String = "select top 1  fid, mtitle,ftitle from  m_zylist where id=" & NextId
                    Fdata = db.GetDataSetBySQL(_str, "noname").Tables(0)
                    If Fdata.Rows.Count > 0 Then
                        NextId = Fdata.Rows(0)("fid")
                        Flist = Fdata.Rows(0)("ftitle")
                        Fname = Fdata.Rows(0)("mtitle")
                        If Flist = "需检查项" Then Exit For
                    Else
                        Flist = "需检查项"
                        Fname = "无法读取数据"
                        Exit For
                    End If
                Next
                db.Dispose()
            End Using
        Catch ex As Exception
        End Try
        Return Fname
    End Function




    '=====================================================================================================================================================================
    '附件管理器 + 上传解决方案
    '=====================================================================================================================================================================
    '读取列表


    Public Function _rz_getFjlist(ByVal DDid As Integer, ByVal istp As Integer) As DataTable
        Dim dt As DataTable = Nothing
        Dim _str As String = ""
        If istp = 3 Then _str = "select fid,mtitle,etitle,fimg,istype,id from m_zyimg where del<>1  and  fid=" & DDid & " order by istype , etitle "
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


    Public Function _rz_getWxFjlist(ByVal ddstr As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim _str As String = "select  mtitle as 文件名 ,etitle as 单号 ,fimg as 文件 ,uname as 人员 , istype,id as 序号 from m_zyimg where del<>1    and istype=99 and   etitle='" & ddstr & "' order by id desc   "
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



End Class
