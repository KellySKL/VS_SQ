Imports SyERP.DAL
Public Class 售后领料审核base
    Public getdataTime As String
    Public uNmm As String




    Public Function _rz_List(ByVal aZcode As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim _str As String = " "
        _str = "select * from BILLnouse2 where BILLTYPE ='售后服务领料' and left(code,1)<>'*' and code='" & aZcode & "'  "
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


    Public Function _rz_价格(ByVal zf As String) As Decimal
        Dim jg As Decimal
        Dim _str As String = " "
        _str = "select sum(price) from dangdangpuku where  CODE ='" & zf & "'  "
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                jg = db.GetIntBySQL(_str)
                db.Dispose()
                End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
        Return jg
    End Function






    Public Function _rz_getList(ByVal txts As String, ByVal aZTm As String) As DataTable
        Dim dt As DataTable = Nothing
        If getdataTime = "no" Or getdataTime = "" Then getdataTime = ""
        If uNmm = "no" Or uNmm = "" Then
            uNmm = " "
        Else
            uNmm = " and client='" & uNmm & "' "
        End If
        If txts = "" Or txts = "no" Then
            txts = " "
        Else
            txts = " and code like '%" & txts & "%'"
        End If

        Dim _str As String =   "select * from BILLnouse2 where BILLTYPE ='售后服务领料'  "

        If aZTm = "未审核" Then
            _str &= "  and  Auditing  ='' and LEFT(CODE,1)<>'*'      "
        End If
        If aZTm = "已审核" Then
            _str &= "  and  Auditing <>'' and LEFT(CODE,1)<>'*'     "
        End If
        If aZTm = "已作废" Then
            _str &= "  and LEFT(CODE,1)='*'    "

        End If
        If aZTm = "所有" Then
            _str &= "  and LEFT(CODE,1)<>'*'   "
        End If

        _str &= txts & getdataTime & uNmm


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

    Public Function _rz_审核(ByVal aZTm As String, ByVal aZcode As String, ByVal aZint As Integer) As String
        Dim iinfo As String = "操作成功！"
        Dim _str As String = "update BILLnouse2 set Auditing ='" & aZTm & "' where CODE ='" & aZcode & "'  "
        If aZint = 2 Then _str = " update BILLnouse2 set code='*' & code where CODE ='" & aZcode & "'  "

        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(_str)
                db.Dispose()
            End Using
        Catch ex As Exception
            iinfo = ex.Message
        End Try
        Return iinfo
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
End Class
