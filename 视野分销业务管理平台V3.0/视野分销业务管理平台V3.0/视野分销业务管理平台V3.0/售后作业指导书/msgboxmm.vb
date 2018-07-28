Public Class msgboxmm
    Private idn As Integer = -1
    Private base As New 售后服务维修问题库base
    Dim wCode As String
    Dim wBman As String
    Dim wLid As Integer = -1
    Dim sMM As String = ""
    Dim dtp As New DataTable
    Dim dgv As New DataGridView
    Dim getStr As String
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal str As String)
        InitializeComponent()
        getStr = str

        Show()


    End Sub
    Public Sub New(ByVal id As Integer, ByVal wxCodem As String, ByVal wxBman As String, Optional ByVal mm As String = "")
        InitializeComponent()
        wCode = wxCodem
        wBman = wxBman
        idn = id
        sMM = mm
        Me.ShowDialog()

    End Sub
    Private Function TxtBox(ByVal ntxt As String)
        Dim nlb As New TextBox
        nlb.Multiline = True
        nlb.Dock = DockStyle.Fill
        nlb.Text = ntxt
        Me.Panel3.Controls.Add(nlb)
        Return nlb
    End Function
    Private Function Llabel(ByVal tsr As String, Optional ByVal tid As Integer = -1) As LinkLabel '工具先写入这里
        Dim nlb As New LinkLabel
        nlb.Text = tsr
        nlb.AutoSize = True
        nlb.Dock = DockStyle.Left
        nlb.TextAlign = ContentAlignment.MiddleCenter
        If tid = -1 Then
        Else
            nlb.Name = "pp"
            nlb.Tag = tid
        End If
        Me.Panel4.Controls.Add(nlb)
        Return nlb
    End Function

    Private Function labName(ByVal tsr As String) As Label '标题名称
        Dim nlb As New Label
        nlb.Dock = DockStyle.Fill
        nlb.Font = New Font("宋体", 15, FontStyle.Bold)
        nlb.TextAlign = ContentAlignment.MiddleCenter
        nlb.Text = tsr
        Me.Panel1.Controls.Add(nlb)
        Return nlb
    End Function
    Private Function ltbox(ByVal tsr As String) As ListBox '后期处理 再说
        Dim nlb As New ListBox
        nlb.Dock = DockStyle.Fill
        '工具需要遍历整个物料清单下的工具！
        nlb.Text = tsr
        Me.Panel4.Controls.Add(nlb)
        Return nlb
    End Function

    Private Function ltDgv(ByVal dt As DataTable) As DataGridView
        Dim gg As New DataGridView
        gg.Dock = DockStyle.Fill
        gg.DataSource = dt
        Me.Panel3.Controls.Add(gg)
        Return gg
    End Function
    Private Sub Reform(ByVal x As Integer, ByVal y As Integer)
        Me.Width = x
        Me.Height = y

    End Sub

    Private Sub addInfo()
        Dim isTt As String = ""
        For i As Integer = 0 To dtp.Rows.Count - 1


            If dtp.Rows(i)("istype") = 7 Then '工具 另外打开 不合并
                Reform(180, 220)
                Panel4.Visible = True
                'Panel3.Visible = False
                isTt &= "工具  "
                ' Dim gg As ListBox = ltbox(dtp.Rows(i)("mtitle").ToString)
                Dim llb As LinkLabel = Llabel("[工]" & dtp.Rows(i)("mtitle").ToString)
            End If


            '---------------------------一个小组----------------------
            If dtp.Rows(i)("istype") = 6 Then '图片
                '有图片的时候开启panel4
                isTt &= "附件   "
                Panel4.Visible = True
                ' Panel3.Visible = False
                Reform(300, 400)
                Dim imgPic As LinkLabel = Llabel("[附]" & dtp.Rows(i)("mtitle").ToString, dtp.Rows(i)("id"))
                ' AddHandler imgPic.Click, AddressOf imgPic_Click
            End If
            If dtp.Rows(i)("istype") = 5 Then '方法
                '  Panel3.Visible = True
                Reform(300, 400)
                isTt &= "方法  "
                Dim ntxt As TextBox = TxtBox(dtp.Rows(i)("mtitle").ToString)
                ntxt = Nothing
            End If

            '-------------------------------------------------------

            If dtp.Rows(i)("istype") = 3 Then '领料 另外打开 不合并
                Reform(200, 300)
                Panel4.Visible = True
                isTt &= "物料  "
                Dim wlllb As LinkLabel = Llabel("[料]" & dtp.Rows(i)("mtitle").ToString, dtp.Rows(i)("id"))
                AddHandler wlllb.Click, AddressOf wlllb_Click
            End If


        Next

        Dim meTxt As Label = labName(isTt)
        meTxt = Nothing
    End Sub
    Private Sub msgboxmm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "解决方法及其附件"
        ' Panel4.Visible = False
        ' dtp = base._rz_getList(CType(idn, Integer), 2) '2 是忽略版本号
        '  addInfo()
        Dim ttt As New TextBox
        ttt.Text = getStr
        ttt.Multiline = True
        ttt.Width = Me.Panel3.Width
        ttt.Height = Me.Panel3.Height
        Panel3.Controls.Add(ttt)


    End Sub


    Private Sub wlllb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New 售后服务维修物料库
        t.wxCode = wCode
        t.getId = sender.tag
        t.cname = wBman
        t.ShowDialog()
    End Sub

    'Private Sub imgPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgPic.Click
    '    Dim imgPath As Byte() = Nothing
    '    Dim bimg As DataTable = base._rz_getList(99, 3, sender.tag)
    '    imgPath = bimg.Rows(0)("imager")
    '    readImage(imgPath, bimg.Rows(0)("mtitle").ToString)
    'End Sub

    Private Sub readImage(ByVal bts As Byte(), ByVal nn As String)
        Dim filepath As String = My.Computer.FileSystem.GetTempFileName()
        Dim fs As IO.FileStream = New IO.FileStream(filepath & nn, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        fs.Write(bts, 0, bts.GetUpperBound(0))
        fs.Close()
        System.Diagnostics.Process.Start(filepath & nn) '文件路径
    End Sub
End Class