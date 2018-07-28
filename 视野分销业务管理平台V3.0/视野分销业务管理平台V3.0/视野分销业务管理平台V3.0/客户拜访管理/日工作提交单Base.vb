Imports SyERP.DAL
'clientservice_VisitReportBillByDay
Public Class 日工作提交单Base
    Public _CODE As String = ""
    Public _BILLTYPE As String = ""
    Public _BILLDATE As Date = BuildFrmTo获得服务器时间()
    Public _Client As String = ""
    Public _BillMan As String = ""
    Public _Auditing As String = ""
    Public _introducer As String = ""
    Public _introducerDate As Date = BuildFrmTo获得服务器时间()
    Public _BillNote As String = ""
    Public _referCode As String = ""
    Public _finishDATE As Date = BuildFrmTo获得服务器时间()
    Public _zf1 As String = ""
    Public _zf2 As String = ""
    Public _zf3 As String = ""
    Public _zf4 As String = ""
    Public _zf5 As String = ""
    Public _zf6 As String = ""
    Public _zf7 As String = ""
    Public _zf8 As String = ""
    Public _zf9 As String = ""
    Public _zf10 As String = ""
    Public _zf11 As String = ""
    Public _zf12 As String = ""
    Public _zf13 As String = ""
    Public _zf14 As String = ""
    Public _zf15 As String = ""
    Public _zf16 As String = ""
    Public _zf17 As String = ""
    Public _zf18 As String = ""
    Public _zf19 As String = ""
    Public _zf20 As String = ""
    Public _zf21 As String = ""
    Public _zf22 As String = ""
    Public _zf23 As String = ""
    Public _zf24 As String = ""
    Public _zf25 As String = ""
    Public _zf26 As String = ""
    Public _zf27 As String = ""
    Public _zf28 As String = ""
    Public _zf29 As String = ""
    Public _zf30 As String = ""
    Public _sz1 As Double
    Public _sz2 As Double
    Public _sz3 As Double
    Public _sz4 As Double
    Public _sz5 As Double
    Public _sz6 As Double
    Public _sz7 As Double
    Public _sz8 As Double
    Public _sz9 As Double
    Public _sz10 As Double
    Public _rq1 As DateTime = BuildFrmTo获得服务器时间()
    Public _rq2 As DateTime = BuildFrmTo获得服务器时间()
    Public _rq3 As DateTime = BuildFrmTo获得服务器时间()
    Public _rq4 As DateTime = BuildFrmTo获得服务器时间()
    Public _rq5 As DateTime = BuildFrmTo获得服务器时间()
    Sub AddSave(ByVal RicherTextBox_Note As RichTextBox)
        Using conn As New SqlClient.SqlConnection(SqlStr.ConnStringBuilder.ConnectionString)
            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand("INSERT INTO [clientservice_VisitBillByDayReport] ([CODE],[BILLTYPE],[BILLDATE],[Client],[BillMan],[introducer],[introducerDate],[BillNote],[referCode],[finishDATE],[zf1],[zf2],[zf3],[zf4],[zf5],[zf6],[zf7],[zf8],[zf9] ,[zf10],[zf11] ,[zf12] ,[zf13],[zf14] ,[zf15] ,[zf16],[zf17],[zf18] ,[zf19] ,[zf20] ,[zf21],[zf22],[zf23],[zf24],[zf25],[zf26],[zf27] ,[zf28] ,[zf29],[zf30] ,[sz1],[sz2],[sz3],[sz4],[sz5],[sz6],[sz7],[sz8],[sz9],[sz10] ,[rq1],[rq2],[rq3],[rq4],[rq5],note,notepre) VALUES(@CODE,@BILLTYPE,@BILLDATE,@Client,@BillMan,@introducer,@introducerDate,@BillNote,@referCode,@finishDATE,@zf1,@zf2,@zf3,@zf4,@zf5 ,@zf6,@zf7,@zf8,@zf9 ,@zf10,@zf11,@zf12,@zf13,@zf14,@zf15,@zf16,@zf17,@zf18,@zf19,@zf20,@zf21,@zf22,@zf23,@zf24 ,@zf25,@zf26,@zf27,@zf28,@zf29,@zf30,@sz1,@sz2,@sz3,@sz4 ,@sz5 ,@sz6 ,@sz7,@sz8,@sz9,@sz10,@rq1,@rq2,@rq3,@rq4,@rq5,@note,@notepre)", conn)
            Dim 序号 As Integer
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                Try
                    Dim CODEDB As String
                    CODEDB = db.GetStrBySQL(" select code from clientservice_VisitBillByDayReport where left(code,10)='YW'+CONVERT(varchar(12), getdate(),112)  order by id desc ")
                    If Len(CODEDB) >= 4 Then
                        序号 = Val(Right(CODEDB, 4)) + 1
                    Else
                        序号 = 1
                    End If
                Catch ex As Exception
                    序号 = 1
                End Try
            End Using
            Dim code As String = "YB" '业务日报单
            code &= BuildFrmTo获得服务器时间.ToString("yyyyMMdd") & Mid("0000", Len(序号.ToString) + 1) & 序号.ToString
            command.Parameters.Add("@code", SqlDbType.NVarChar, 255).Value = code
            command.Parameters.Add("@BILLTYPE", SqlDbType.NVarChar, 255).Value = _BILLTYPE
            command.Parameters.Add("@BILLDATE", SqlDbType.DateTime).Value = _BILLDATE.ToString("yyyy-MM-dd")
            command.Parameters.Add("@Client", SqlDbType.NVarChar, 255).Value = _Client
            command.Parameters.Add("@BillMan", SqlDbType.NVarChar, 255).Value = _BillMan
            command.Parameters.Add("@introducer", SqlDbType.NVarChar, 255).Value = _introducer
            command.Parameters.Add("@introducerDate", SqlDbType.DateTime).Value = _introducerDate
            command.Parameters.Add("@BillNote", SqlDbType.NVarChar, 255).Value = _BillNote
            command.Parameters.Add("@referCode", SqlDbType.NVarChar, 255).Value = _referCode
            command.Parameters.Add("@finishDATE", SqlDbType.DateTime).Value = _finishDATE
            command.Parameters.Add("@zf1", SqlDbType.NVarChar, 255).Value = _zf1
            command.Parameters.Add("@zf2", SqlDbType.NVarChar, 255).Value = _zf2
            command.Parameters.Add("@zf3", SqlDbType.NVarChar, 255).Value = _zf3
            command.Parameters.Add("@zf4", SqlDbType.NVarChar, 255).Value = _zf4
            command.Parameters.Add("@zf5", SqlDbType.NVarChar, 255).Value = _zf5
            command.Parameters.Add("@zf6", SqlDbType.NVarChar, 255).Value = _zf6
            command.Parameters.Add("@zf7", SqlDbType.NVarChar, 255).Value = _zf7
            command.Parameters.Add("@zf8", SqlDbType.NVarChar, 255).Value = _zf8
            command.Parameters.Add("@zf9", SqlDbType.NVarChar, 255).Value = _zf9
            command.Parameters.Add("@zf10", SqlDbType.NVarChar, 255).Value = _zf10
            command.Parameters.Add("@zf11", SqlDbType.NVarChar, 255).Value = _zf11
            command.Parameters.Add("@zf12", SqlDbType.NVarChar, 255).Value = _zf12
            command.Parameters.Add("@zf13", SqlDbType.NVarChar, 255).Value = _zf13
            command.Parameters.Add("@zf14", SqlDbType.NVarChar, 255).Value = _zf14
            command.Parameters.Add("@zf15", SqlDbType.NVarChar, 255).Value = _zf15
            command.Parameters.Add("@zf16", SqlDbType.NVarChar, 255).Value = _zf16
            command.Parameters.Add("@zf17", SqlDbType.NVarChar, 255).Value = _zf17
            command.Parameters.Add("@zf18", SqlDbType.NVarChar, 255).Value = _zf18
            command.Parameters.Add("@zf19", SqlDbType.NVarChar, 255).Value = _zf19
            command.Parameters.Add("@zf20", SqlDbType.NVarChar, 255).Value = _zf20
            command.Parameters.Add("@zf21", SqlDbType.NVarChar, 255).Value = _zf21
            command.Parameters.Add("@zf22", SqlDbType.NVarChar, 255).Value = _zf22
            command.Parameters.Add("@zf23", SqlDbType.NVarChar, 255).Value = _zf23
            command.Parameters.Add("@zf24", SqlDbType.NVarChar, 255).Value = _zf24
            command.Parameters.Add("@zf25", SqlDbType.NVarChar, 255).Value = _zf25
            command.Parameters.Add("@zf26", SqlDbType.NVarChar, 255).Value = _zf26
            command.Parameters.Add("@zf27", SqlDbType.NVarChar, 255).Value = _zf27
            command.Parameters.Add("@zf28", SqlDbType.NVarChar, 255).Value = _zf28
            command.Parameters.Add("@zf29", SqlDbType.NVarChar, 255).Value = _zf29
            command.Parameters.Add("@zf30", SqlDbType.NVarChar, 255).Value = _zf30
            command.Parameters.Add("@sz1", SqlDbType.Decimal).Value = _sz1
            command.Parameters.Add("@sz2", SqlDbType.Decimal).Value = _sz2
            command.Parameters.Add("@sz3", SqlDbType.Decimal).Value = _sz3
            command.Parameters.Add("@sz4", SqlDbType.Decimal).Value = _sz4
            command.Parameters.Add("@sz5", SqlDbType.Decimal).Value = _sz5
            command.Parameters.Add("@sz6", SqlDbType.Decimal).Value = _sz6
            command.Parameters.Add("@sz7", SqlDbType.Decimal).Value = _sz7
            command.Parameters.Add("@sz8", SqlDbType.Decimal).Value = _sz8
            command.Parameters.Add("@sz9", SqlDbType.Decimal).Value = _sz9
            command.Parameters.Add("@sz10", SqlDbType.Decimal).Value = _sz10
            command.Parameters.Add("@rq1", SqlDbType.DateTime).Value = _rq1
            command.Parameters.Add("@rq2", SqlDbType.DateTime).Value = _rq2
            command.Parameters.Add("@rq3", SqlDbType.DateTime).Value = _rq3
            command.Parameters.Add("@rq4", SqlDbType.DateTime).Value = _rq4
            command.Parameters.Add("@rq5", SqlDbType.DateTime).Value = _rq5
            'richtextbox 的保存 _问题描述
            Dim MemoryStream1 As New System.IO.MemoryStream
            RicherTextBox_Note.SaveFile(MemoryStream1, RichTextBoxStreamType.RichText)
            Dim bwrite As Byte() = MemoryStream1.ToArray
            command.Parameters.Add("@note", SqlDbType.Image).Value = bwrite
            command.Parameters.Add("@notepre", SqlDbType.NVarChar).Value = RicherTextBox_Note.Text
            conn.Open()
            command.ExecuteNonQuery()
            conn.Dispose()
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL("update clientservice_VisitBill set refercode='" & code & "' where  left(code,1)<>'*' and  introducer='" & _introducer & "'  and billdate='" & _BILLDATE.ToString("yyyy-MM-dd") & "'")
            End Using
        End Using
    End Sub
    Sub ModifySave(ByVal id As Integer, ByVal RicherTextBox_Note As RichTextBox)
        Using conn As New SqlClient.SqlConnection(SqlStr.ConnStringBuilder.ConnectionString)
            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand("UPDATE [clientservice_VisitBillByDayReport] SET [BILLTYPE] = @BILLTYPE ,[BILLDATE] = @BILLDATE,[Client] = @Client,[BillMan] = @BillMan,[introducer] = @introducer ,[introducerDate] = @introducerDate ,[BillNote] = @BillNote,[referCode] =@referCode,[finishDATE] = @finishDATE,[zf1] = @zf1,[zf2] =@zf2,[zf3] = @zf3 ,[zf4] = @zf4,[zf5] =@zf5 ,[zf6] = @zf6,[zf7] = @zf7,[zf8] = @zf8 ,[zf9] = @zf9 ,[zf10] = @zf10,[zf11] = @zf11,[zf12] = @zf12,[zf13] = @zf13,[zf14] = @zf14 ,[zf15] = @zf15 ,[zf16] = @zf16 ,[zf17] =@zf17,[zf18] =@zf18,[zf19] = @zf19,[zf20] = @zf20,[zf21] =@zf21,[zf22] = @zf22 ,[zf23] =@zf23,[zf24] = @zf24,[zf25] = @zf25 ,[zf26] =@zf26 ,[zf27] = @zf27,[zf28] = @zf28,[zf29] = @zf29,[zf30] = @zf30,[sz1] =@sz1 ,[sz2] = @sz2,[sz3] = @sz3 ,[sz4] = @sz4,[sz5] = @sz5,[sz6] =@sz6 ,[sz7] = @sz7,[sz8] =@sz8,[sz9] =@sz9 ,[sz10] = @sz10,[rq1] =@rq1,[rq2] = @rq2,[rq3] =@rq3,[rq4] =@rq4,[rq5] =@rq5,note=@note,notepre=@notepre WHERE id=" & id, conn)
            command.Parameters.Add("@BILLTYPE", SqlDbType.NVarChar, 255).Value = _BILLTYPE
            command.Parameters.Add("@BILLDATE", SqlDbType.DateTime).Value = _BILLDATE
            command.Parameters.Add("@Client", SqlDbType.NVarChar, 255).Value = _Client
            command.Parameters.Add("@BillMan", SqlDbType.NVarChar, 255).Value = _BillMan
            command.Parameters.Add("@introducer", SqlDbType.NVarChar, 255).Value = _introducer
            command.Parameters.Add("@introducerDate", SqlDbType.DateTime).Value = _introducerDate
            command.Parameters.Add("@BillNote", SqlDbType.NVarChar, 255).Value = _BillNote
            command.Parameters.Add("@referCode", SqlDbType.NVarChar, 255).Value = _referCode
            command.Parameters.Add("@finishDATE", SqlDbType.DateTime).Value = _finishDATE
            command.Parameters.Add("@zf1", SqlDbType.NVarChar, 255).Value = _zf1
            command.Parameters.Add("@zf2", SqlDbType.NVarChar, 255).Value = _zf2
            command.Parameters.Add("@zf3", SqlDbType.NVarChar, 255).Value = _zf3
            command.Parameters.Add("@zf4", SqlDbType.NVarChar, 255).Value = _zf4
            command.Parameters.Add("@zf5", SqlDbType.NVarChar, 255).Value = _zf5
            command.Parameters.Add("@zf6", SqlDbType.NVarChar, 255).Value = _zf6
            command.Parameters.Add("@zf7", SqlDbType.NVarChar, 255).Value = _zf7
            command.Parameters.Add("@zf8", SqlDbType.NVarChar, 255).Value = _zf8
            command.Parameters.Add("@zf9", SqlDbType.NVarChar, 255).Value = _zf9
            command.Parameters.Add("@zf10", SqlDbType.NVarChar, 255).Value = _zf10
            command.Parameters.Add("@zf11", SqlDbType.NVarChar, 255).Value = _zf11
            command.Parameters.Add("@zf12", SqlDbType.NVarChar, 255).Value = _zf12
            command.Parameters.Add("@zf13", SqlDbType.NVarChar, 255).Value = _zf13
            command.Parameters.Add("@zf14", SqlDbType.NVarChar, 255).Value = _zf14
            command.Parameters.Add("@zf15", SqlDbType.NVarChar, 255).Value = _zf15
            command.Parameters.Add("@zf16", SqlDbType.NVarChar, 255).Value = _zf16
            command.Parameters.Add("@zf17", SqlDbType.NVarChar, 255).Value = _zf17
            command.Parameters.Add("@zf18", SqlDbType.NVarChar, 255).Value = _zf18
            command.Parameters.Add("@zf19", SqlDbType.NVarChar, 255).Value = _zf19
            command.Parameters.Add("@zf20", SqlDbType.NVarChar, 255).Value = _zf20
            command.Parameters.Add("@zf21", SqlDbType.NVarChar, 255).Value = _zf21
            command.Parameters.Add("@zf22", SqlDbType.NVarChar, 255).Value = _zf22
            command.Parameters.Add("@zf23", SqlDbType.NVarChar, 255).Value = _zf23
            command.Parameters.Add("@zf24", SqlDbType.NVarChar, 255).Value = _zf24
            command.Parameters.Add("@zf25", SqlDbType.NVarChar, 255).Value = _zf25
            command.Parameters.Add("@zf26", SqlDbType.NVarChar, 255).Value = _zf26
            command.Parameters.Add("@zf27", SqlDbType.NVarChar, 255).Value = _zf27
            command.Parameters.Add("@zf28", SqlDbType.NVarChar, 255).Value = _zf28
            command.Parameters.Add("@zf29", SqlDbType.NVarChar, 255).Value = _zf29
            command.Parameters.Add("@zf30", SqlDbType.NVarChar, 255).Value = _zf30
            command.Parameters.Add("@sz1", SqlDbType.Decimal).Value = _sz1
            command.Parameters.Add("@sz2", SqlDbType.Decimal).Value = _sz2
            command.Parameters.Add("@sz3", SqlDbType.Decimal).Value = _sz3
            command.Parameters.Add("@sz4", SqlDbType.Decimal).Value = _sz4
            command.Parameters.Add("@sz5", SqlDbType.Decimal).Value = _sz5
            command.Parameters.Add("@sz6", SqlDbType.Decimal).Value = _sz6
            command.Parameters.Add("@sz7", SqlDbType.Decimal).Value = _sz7
            command.Parameters.Add("@sz8", SqlDbType.Decimal).Value = _sz8
            command.Parameters.Add("@sz9", SqlDbType.Decimal).Value = _sz9
            command.Parameters.Add("@sz10", SqlDbType.Decimal).Value = _sz10
            command.Parameters.Add("@rq1", SqlDbType.DateTime).Value = _rq1
            command.Parameters.Add("@rq2", SqlDbType.DateTime).Value = _rq2
            command.Parameters.Add("@rq3", SqlDbType.DateTime).Value = _rq3
            command.Parameters.Add("@rq4", SqlDbType.DateTime).Value = _rq4
            command.Parameters.Add("@rq5", SqlDbType.DateTime).Value = _rq5
            'richtextbox 的保存 _问题描述
            Dim MemoryStream1 As New System.IO.MemoryStream
            RicherTextBox_Note.SaveFile(MemoryStream1, RichTextBoxStreamType.RichText)
            Dim bwrite As Byte() = MemoryStream1.ToArray
            command.Parameters.Add("@note", SqlDbType.Image).Value = bwrite
            command.Parameters.Add("@notepre", SqlDbType.NVarChar).Value = RicherTextBox_Note.Text
            conn.Open()
            command.ExecuteNonQuery()
            conn.Dispose()
        End Using
    End Sub
    Function GetDataTableByid(ByVal id As Integer) As DataTable
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Return db.GetDataSetBySQL("select * from clientservice_VisitBillByDayReport where id=" & id).Tables(0)
        End Using
    End Function
    Function Get是否已提交过Bydate(ByVal 输入员 As String, ByVal date1 As Date) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Dim count As Integer = db.GetIntBySQL("select count(id) from clientservice_VisitBillByDayReport where  left(code,1)<>'*' and  introducer='" & 输入员 & "'  and billdate='" & date1.ToString("yyyy-MM-dd") & "'")
            If count >= 1 Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Function GetDataTableBy输入员(ByVal 输入员 As String, ByVal date1 As Date) As DataTable
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Return db.GetDataSetBySQL("select * from clientservice_VisitBill where introducer='" & 输入员 & "' and billdate='" & date1.ToString("yyyy-MM-dd") & "'").Tables(0)
        End Using
    End Function

    Public Function killBill(ByVal id As Integer) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("update clientservice_VisitBillByDayReport set code='*'+code where id=" & id)
            Return True
        End Using
    End Function
    Public Function 审核ById(ByVal id As Integer) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("update clientservice_VisitBillByDayReport set auditing='" & Bus_CurrentUser_Fullname & "' where id=" & id)
            Return True
        End Using
    End Function
    Public Function 反审核ById(ByVal id As Integer) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("update clientservice_VisitBillByDayReport set auditing='' where id=" & id)
            Return True
        End Using
    End Function
End Class
