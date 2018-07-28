Imports SyERP.DAL
Public Class 业务拜访记录单Base
    Public _CODE As String = ""
    Public _BILLTYPE As String = ""
    Public _BILLDATE As Date = BuildFrmTo获得服务器时间()
    Public _Client As String = ""
    Public _TRADETYPENAME As String = ""
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
            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand("INSERT INTO [clientservice_visitBill] ([CODE],[BILLTYPE],[BILLDATE],[Client],[BillMan],[introducer],[introducerDate],[BillNote],[referCode],[finishDATE],[zf1],[zf2],[zf3],[zf4],[zf5],[zf6],[zf7],[zf8],[zf9] ,[zf10],[zf11] ,[zf12] ,[zf13],[zf14] ,[zf15] ,[zf16],[zf17],[zf18] ,[zf19] ,[zf20] ,[zf21],[zf22],[zf23],[zf24],[zf25],[zf26],[zf27] ,[zf28] ,[zf29],[zf30] ,[sz1],[sz2],[sz3],[sz4],[sz5],[sz6],[sz7],[sz8],[sz9],[sz10] ,[rq1],[rq2],[rq3],[rq4],[rq5],note,notepre) VALUES(@CODE,@BILLTYPE,@BILLDATE,@Client,@BillMan,@introducer,@introducerDate,@BillNote,@referCode,@finishDATE,@zf1,@zf2,@zf3,@zf4,@zf5 ,@zf6,@zf7,@zf8,@zf9 ,@zf10,@zf11,@zf12,@zf13,@zf14,@zf15,@zf16,@zf17,@zf18,@zf19,@zf20,@zf21,@zf22,@zf23,@zf24 ,@zf25,@zf26,@zf27,@zf28,@zf29,@zf30,@sz1,@sz2,@sz3,@sz4 ,@sz5 ,@sz6 ,@sz7,@sz8,@sz9,@sz10,@rq1,@rq2,@rq3,@rq4,@rq5,@note,@notepre)", conn)
            Dim 序号 As Integer
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                Try
                    Dim CODEDB As String
                    CODEDB = db.GetStrBySQL(" select code from clientservice_visitBill where left(code,10)='YW'+CONVERT(varchar(12), getdate(),112)  order by id desc ")
                    If Len(CODEDB) >= 4 Then
                        序号 = Val(Right(CODEDB, 4)) + 1
                    Else
                        序号 = 1
                    End If
                Catch ex As Exception
                    序号 = 1
                End Try
            End Using
            Dim code As String = "YW" '业务记录单
            code &= BuildFrmTo获得服务器时间.ToString("yyyyMMdd") & Mid("0000", Len(序号.ToString) + 1) & 序号.ToString
            command.Parameters.Add("@code", SqlDbType.NVarChar, 255).Value = code
            command.Parameters.Add("@BILLTYPE", SqlDbType.NVarChar, 255).Value = _BILLTYPE
            command.Parameters.Add("@BILLDATE", SqlDbType.DateTime).Value = _BILLDATE.ToString("yyyy-MM-dd")
            command.Parameters.Add("@Client", SqlDbType.NVarChar, 255).Value = _Client
            ' command.Parameters.Add("@TRADETYPENAME", SqlDbType.NVarChar, 255).Value = _TRADETYPENAME
            command.Parameters.Add("@BillMan", SqlDbType.NVarChar, 255).Value = _BillMan
            command.Parameters.Add("@introducer", SqlDbType.NVarChar, 255).Value = _introducer
            command.Parameters.Add("@introducerDate", SqlDbType.DateTime).Value = _introducerDate
            command.Parameters.Add("@BillNote", SqlDbType.NVarChar, 255).Value = _BillNote
            command.Parameters.Add("@referCode", SqlDbType.NVarChar, 255).Value = _referCode
            command.Parameters.Add("@finishDATE", SqlDbType.DateTime).Value = _finishDATE
            command.Parameters.Add("@zf1", SqlDbType.NVarChar, 255).Value = _TRADETYPENAME
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
    Sub ModifySave(ByVal id As Integer, ByVal RicherTextBox_Note As RichTextBox)
        Using conn As New SqlClient.SqlConnection(SqlStr.ConnStringBuilder.ConnectionString)
            Dim command As SqlClient.SqlCommand = New SqlClient.SqlCommand("UPDATE [clientservice_visitBill] SET [BILLTYPE] = @BILLTYPE ,[BILLDATE] = @BILLDATE,[Client] = @Client,[BillMan] = @BillMan,[introducer] = @introducer ,[introducerDate] = @introducerDate ,[BillNote] = @BillNote,[referCode] =@referCode,[finishDATE] = @finishDATE,[zf1] = @zf1,[zf2] =@zf2,[zf3] = @zf3 ,[zf4] = @zf4,[zf5] =@zf5 ,[zf6] = @zf6,[zf7] = @zf7,[zf8] = @zf8 ,[zf9] = @zf9 ,[zf10] = @zf10,[zf11] = @zf11,[zf12] = @zf12,[zf13] = @zf13,[zf14] = @zf14 ,[zf15] = @zf15 ,[zf16] = @zf16 ,[zf17] =@zf17,[zf18] =@zf18,[zf19] = @zf19,[zf20] = @zf20,[zf21] =@zf21,[zf22] = @zf22 ,[zf23] =@zf23,[zf24] = @zf24,[zf25] = @zf25 ,[zf26] =@zf26 ,[zf27] = @zf27,[zf28] = @zf28,[zf29] = @zf29,[zf30] = @zf30,[sz1] =@sz1 ,[sz2] = @sz2,[sz3] = @sz3 ,[sz4] = @sz4,[sz5] = @sz5,[sz6] =@sz6 ,[sz7] = @sz7,[sz8] =@sz8,[sz9] =@sz9 ,[sz10] = @sz10,[rq1] =@rq1,[rq2] = @rq2,[rq3] =@rq3,[rq4] =@rq4,[rq5] =@rq5,note=@note,notepre=@notepre WHERE id=" & id, conn)
            command.Parameters.Add("@BILLTYPE", SqlDbType.NVarChar, 255).Value = _BILLTYPE
            command.Parameters.Add("@BILLDATE", SqlDbType.DateTime).Value = _BILLDATE
            command.Parameters.Add("@Client", SqlDbType.NVarChar, 255).Value = _Client
            '   command.Parameters.Add("@TRADETYPENAME", SqlDbType.NVarChar, 255).Value = _TRADETYPENAME
            command.Parameters.Add("@BillMan", SqlDbType.NVarChar, 255).Value = _BillMan
            command.Parameters.Add("@introducer", SqlDbType.NVarChar, 255).Value = _introducer
            command.Parameters.Add("@introducerDate", SqlDbType.DateTime).Value = _introducerDate
            command.Parameters.Add("@BillNote", SqlDbType.NVarChar, 255).Value = _BillNote
            command.Parameters.Add("@referCode", SqlDbType.NVarChar, 255).Value = _referCode
            command.Parameters.Add("@finishDATE", SqlDbType.DateTime).Value = _finishDATE
            command.Parameters.Add("@zf1", SqlDbType.NVarChar, 255).Value = _TRADETYPENAME
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
            Return db.GetDataSetBySQL("select * from clientservice_visitBill where id=" & id).Tables(0)
        End Using
    End Function
    Function list类型(ByVal 客户类型) As ArrayList
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                Dim where As String = ""
                If 客户类型 <> "" Then   where = "  and 客户类型='" & 客户类型 & "' "
                If 客户类型 = "noname" Then where = "  group by 业务类型  "
                Return db.GetArraylistBySQL("select 业务类型 from clientservice_Billtype where 单据名称='业务拜访记录单'" & where)
            End Using
        Catch ex As Exception
        End Try
        Return New ArrayList
    End Function
    Function Get子业务类型(ByVal 业务类型 As String) As ArrayList
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                Return db.GetArraylistBySQL("select 子业务类型 from clientservice_BilltypeChildtype where 业务类型='" & 业务类型 & "' and  单据名称='业务拜访记录单' ")
            End Using
        Catch ex As Exception
        End Try
        Return New ArrayList
    End Function
    Function Get市场潜在客户类型分类() As ArrayList
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Return db.GetArraylistBySQL("select text from item16")
        End Using
    End Function

    Function Get市场潜在客户ByName(ByVal 客户名称 As String) As DataTable
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            Return db.GetDataSetBySQL("select *,[联系人]=stuff((select isnull([姓名],'')+'['+isnull([办公室电话],'') +isnull([手机],'')  +'];    ' from clientservice_kfku_contacter t where t.单位代码=clientservice_kfku.code for xml path('')), 1, 1, '') from clientservice_kfku where name='" & 客户名称 & "'").Tables(0)
        End Using
    End Function


    Function Set值Byid(ByVal 字段名 As String, ByVal 字段值 As String, ByVal id As Integer) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("update clientservice_kfku set " & 字段名 & "='" & 字段值 & "'where id=" & id)
        End Using
        Return True
    End Function
    Function 建表() As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("IF OBJECT_ID ('clientservice_Billtype', 'U') IS NULL  CREATE TABLE [dbo].[clientservice_Billtype]([id] [int] IDENTITY(1,1) NOT NULL,[单据名称] [varchar](250) NULL,[业务类型] [varchar](250) NULL,[备注] [varchar](250) NULL,CONSTRAINT [PK_clientservice_Billtype] PRIMARY KEY  CLUSTERED 	( [id]	)  ON [PRIMARY]) ON [PRIMARY]")
            db.GetNoneBySQL("IF OBJECT_ID ('clientservice_BilltypeChildtype', 'U') IS NULL  CREATE TABLE [dbo].[clientservice_BilltypeChildtype]([id] [int] IDENTITY(1,1) NOT NULL,[单据名称] [varchar](250) NULL,[业务类型] [varchar](250) NULL,[子业务类型] [varchar](250) NULL,[备注] [varchar](250) NULL,CONSTRAINT [PK_clientservice_BilltypeChildtype] PRIMARY KEY  CLUSTERED 	( [id]	)  ON [PRIMARY]) ON [PRIMARY]")
        End Using
        Return True
    End Function
    Public Function killBill(ByVal id As Integer) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("update clientservice_visitBill set code='*'+code where id=" & id)
            Return True
        End Using
    End Function
    Public Function 审核单据(ByVal id As Integer) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("update clientservice_visitBill set auditing='" & Bus_CurrentUser_Fullname & "' where id=" & id)
            Return True
        End Using
    End Function
    Public Function 反审核单据(ByVal id As Integer) As Boolean
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            db.GetNoneBySQL("update clientservice_visitBill set auditing='' where id=" & id)
            Return True
        End Using
    End Function
    Sub 改变客户类型(ByVal 是否对手 As Boolean, ByVal id As Integer)
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            If 是否对手 = False Then
                If MsgBox("您确定要将此客户修改为竞争对手客户吗？", vbYesNo) = vbYes Then
                    db.GetNoneBySQL("update clientservice_kfku set TRADETYPENAME=TRADETYPENAME+',竞争对手' where id=" & id)
                End If
            Else
                If MsgBox("您确定要将去掉竞争对手标识吗？", vbYesNo) = vbYes Then
                    db.GetNoneBySQL("update clientservice_kfku set TRADETYPENAME=replace(TRADETYPENAME,',竞争对手','') where id=" & id)
                End If
            End If

        End Using
    End Sub



    Public Function _update潜在客户(ByVal _xxxcode As String) As String
        Try
            Dim _where As String
            _where = "update clientservice_kfku set TRADETYPENAME='潜在客户'  where TRADETYPENAME='新建客户' and code='" & _xxxcode & "'"
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL(_where)
                db.Dispose()
            End Using
        Catch ex As Exception
        End Try
        Return ""

    End Function
  
End Class
