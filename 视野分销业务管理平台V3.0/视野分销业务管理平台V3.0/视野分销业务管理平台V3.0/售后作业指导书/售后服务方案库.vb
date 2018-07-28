Public Class 售后服务方案库

    Public getId As Integer
    Public wxCode As String
    Dim base As New 售后服务维修问题库base
    Dim dF As New DataTable

    Private Sub readImage(ByVal bts As Byte(), ByVal nn As String)
        Dim filepath As String = My.Computer.FileSystem.GetTempFileName()
        Dim fs As IO.FileStream = New IO.FileStream(filepath & nn, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        fs.Write(bts, 0, bts.GetUpperBound(0))
        fs.Close()
        System.Diagnostics.Process.Start(filepath & nn) '文件路径
    End Sub
    Private Sub getFjlist()
        dF = base.getFjls(getId, 1)
        Dim Dl As DataTable = base.getFjls(getId, 2)
        For i As Integer = 0 To Dl.Rows.Count - 1
            Dim tpage As New TabPage
            With tpage
                .Name = "TPage" & i
                .TabIndex = i
                .Text = Dl.Rows(i)("etitle").ToString
                Dim infoTxt As New TextBox
                infoTxt.Name = "TBox" & i
                infoTxt.Multiline = True
                infoTxt.ReadOnly = True
                infoTxt.Text = IIf(IsDBNull(Dl.Rows(i)("mtitle")), "读取数据失败", Dl.Rows(i)("mtitle"))
                infoTxt.Dock = DockStyle.Fill
                .Controls.Add(infoTxt)
            End With
            Me.TabControl1.TabPages.Add(tpage)
        Next
        If dF.Rows.Count > 0 Then
            For i As Integer = 0 To dF.Rows.Count - 1
                Dim lklabel As New LinkLabel
                lklabel.Text = dF.Rows(i)("mtitle").ToString
                lklabel.Name = "Txt" & i
                lklabel.Tag = i
                AddHandler lklabel.Click, AddressOf lklabel_Click
            Next
        End If

    End Sub

    Private Sub lklabel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim img As Byte()
        img = dF.Rows(sender.id)("fimg")
        Call readImage(img, sender.Text)
    End Sub


    Private Sub 售后服务方案库_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "解决方案"
        Call getFjlist()
    End Sub
End Class