Public Class 售后服务判断结果
    Public getId As Integer
    Dim base As New 售后服务维修问题库base


    Dim dts As New DataTable
    Private Sub readImage(ByVal bts As Byte(), ByVal nn As String)
        Dim filepath As String = My.Computer.FileSystem.GetTempFileName()
        Dim fs As IO.FileStream = New IO.FileStream(filepath & nn, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        fs.Write(bts, 0, bts.GetUpperBound(0))
        fs.Close()
        System.Diagnostics.Process.Start(filepath & nn) '打开文件路径
    End Sub


    Private Sub 售后服务判断结果_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "解决方法及附件"
        dts = base._rz_getFjlist(getId, 3)
        For i As Integer = 0 To dts.Rows.Count - 1
            Dim t As New Panel
            t.Name = "panLIst_" & i
            t.Dock = DockStyle.Top
            t.BorderStyle = BorderStyle.None
            t.Height = 120
            t.DockPadding.All = 10
            '划线
            Dim linb As New Label
            linb.AutoSize = False
            linb.Dock = DockStyle.Top
            linb.Height = 1
            linb.Width = 100%
            linb.BorderStyle = BorderStyle.FixedSingle
            '内容
            Dim lab As New Label
            lab.Location = New Point(10, linb.Top + 30)
            lab.AutoSize = True
            ' lab.Dock = DockStyle.Top
            lab.Name = "FlNtxt_" & i
            lab.Text = dts.Rows(i)("etitle") & ":" & vbCrLf & vbCrLf
            If dts.Rows(i)("istype") = 1 Then
                Dim alLeft As Integer = 10
                Do Until dts.Rows(i)("istype") <> 1
                    Dim imgURL As New LinkLabel
                    imgURL.AutoSize = True
                    imgURL.Location = New Point(alLeft, lab.Top + 20)
                    alLeft += imgURL.Width
                    imgURL.Name = "Flimg_" & i
                    imgURL.Text = dts.Rows(i)("mtitle")
                    imgURL.Tag = i
                    AddHandler imgURL.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf imgURL_LinkClicked)
                    t.Controls.Add(imgURL)
                    i = i + 1
                Loop
                i = i - 1
            Else
                lab.Text &= dts.Rows(i)("mtitle")
            End If
            t.Controls.Add(lab)
            t.Controls.Add(linb)
            Panel2.Controls.Add(t)
        Next i
    End Sub
    Private Sub imgURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Call readImage(dts.Rows(sender.tag)("fimg"), dts.Rows(sender.tag)("mtitle"))
    End Sub
End Class