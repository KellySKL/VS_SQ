Imports System.IO
Public Class 售后附件表
    Public mName As String = ""
    Public mWxnm As String = ""
    Public cUname As String = ""
    Dim ImgPath() As Byte
    Dim base As New 售后服务维修问题库base

    Private Sub 售后附件表_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "售后附件表"
        Me.Label1.Text = "公司:" & mName
        Me.Label2.Text = "单号：" & mWxnm
        moLIst(DatagridviewEx2)
        Adddatlist(mWxnm)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim fpath As New OpenFileDialog
        fpath.Title = "上传附件..."
        If fpath.ShowDialog() = DialogResult.OK Then
            ImgPath = ResFile(fpath.FileName) '读取图片二进制流
            Call addImage(ImgPath, System.IO.Path.GetFileName(fpath.FileName))
            Call Adddatlist(mWxnm)
            ImgPath = Nothing
        End If
    End Sub
    Private Sub Adddatlist(ByVal Fdh As String)
        '这方法无法获取ID 必须重新从数据库里面读取出来
        Dim imDt As DataTable = base._rz_getWxFjlist(Fdh)
        Call moLIst(Me.DatagridviewEx2)
        For i As Integer = 0 To imDt.Rows.Count - 1
            Me.DatagridviewEx2.Rows.Add(New Object() {imDt.Rows(i)("序号"), imDt.Rows(i)("文件名"), imDt.Rows(i)("单号"), imDt.Rows(i)("文件"), imDt.Rows(i)("人员")})
        Next

    End Sub


    Private Sub addImage(ByVal bts As Byte(), ByVal nn As String) '保存列表中的附件
        Dim addStr As String = "INSERT into m_zyimg (fid,fimg,mtitle,etitle,uname,istype,del)  VALUES ( @fId  ,@image ,@mtitle,@etitle,@uname,@istype,@del)"
        Dim cn As New SqlClient.SqlConnection(SyERP.DAL.SqlStr.ConnStringBuilder.ConnectionString)
        Dim cmd As New SqlClient.SqlCommand(addStr, cn)
        cmd.Parameters.Add("@fId", SqlDbType.Int, 100).Value = 0
        cmd.Parameters.Add("@image", SqlDbType.Image, bts.Length).Value = bts
        cmd.Parameters.Add("@mtitle", SqlDbType.NVarChar, 255).Value = nn
        cmd.Parameters.Add("@etitle", SqlDbType.NVarChar, 255).Value = mWxnm
        cmd.Parameters.Add("@uname", SqlDbType.NVarChar, 255).Value = cUname
        cmd.Parameters.Add("@istype", SqlDbType.Int, 100).Value = 99
        cmd.Parameters.Add("@del", SqlDbType.Int, 100).Value = 0
        cn.Open()
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub readImage(ByVal bts As Byte(), ByVal nn As String)
        Dim filepath As String = My.Computer.FileSystem.GetTempFileName()
        Dim fs As IO.FileStream = New IO.FileStream(filepath & nn, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        fs.Write(bts, 0, bts.GetUpperBound(0))
        fs.Close()
        System.Diagnostics.Process.Start(filepath & nn) '文件路径
    End Sub


    Private Function ResFile(ByVal filepath As String)
        Dim result() As Byte
        Dim fileStream As FileStream = New FileStream(filepath, FileMode.Open, FileAccess.Read)
        Dim binaryReader As BinaryReader = New BinaryReader(fileStream)
        result = binaryReader.ReadBytes(CType(fileStream.Length, Integer))
        binaryReader.Close()
        fileStream.Close()
        Return result
    End Function
    Private Sub moLIst(ByVal obj As Object)
        obj.DataSource = Nothing
        obj.Columns.Clear()
        With obj
            .Columns.Add("序号", "序号")
            .Columns.Add("文件名", "文件名")
            .Columns.Add("单号", "单号")
            .Columns.Add("文件", "文件")
            .Columns.Add("人员", "人员")
            .ColumnHeadersHeight = 20
            .Columns(0).Width = 70
            .Columns(1).Width = (.Width / 2) - 120
            .Columns(2).Width = (.Width / 2) - 120
            .Columns(3).Width = 80
            .Columns(4).Width = 80
        End With
    End Sub

    Private Sub DatagridviewEx2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx2.CellDoubleClick
        Call readImage(Me.DatagridviewEx2.Rows(e.RowIndex).Cells("文件").Value, Me.DatagridviewEx2.Rows(e.RowIndex).Cells("文件名").Value) '打开附件查看咯...
    End Sub
 

End Class