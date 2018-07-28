Imports SyERP.DAL
Public Class 新增销售订单base
    Inherits SyERP20.F_SalesOrderMakebase
    Public Function Add(ByVal DatagridviewMain1 As DataGridView) As Boolean
        '2.逐行加入到数据库中
        For j As Integer = 0 To ProductTable.Rows.Count - 1
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                Try
                    db.ClearParameters()
                    FillToAddParameter(ProductTable, db, j) '字段加入到过程参数
                    Dim tmp As ArrayList
                    tmp = db.GetOutputBySP("WaiNongwailiaiku_jia")
                    If tmp.Count < 1 Then Throw New ObjectDisposedException("数据库没有成功生成单据号", "")
                    If Len(Me._CODE) < 10 Then Me._CODE = tmp(0) '编号   第二次以上就是过程的输出参数CODE   
                    If Len(Me._CODE) < 10 Then '未生成提示
                        Throw New ObjectDisposedException("代码长度小于10", "没有生成单号")
                    End If
                    db.ClearParameters()
                Catch ex As Exception
                End Try
                db.Dispose() : End Using
        Next

        Return True
    End Function
End Class
