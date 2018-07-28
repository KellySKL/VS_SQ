Public Class 新建客户查询

    Private Base As New 新建客户查询base
    Dim _nTab As New DataGridView
    Dim myName As String
    Dim myLiex As String
    Dim isOpenGNum As Integer = 0





    Private Sub ShowToos()
        Me.ToolStripStatusLabel2.Text = " 业务员：" & myName & " |  客户类型：" & myLiex & " [" & _nTab.RowCount - 1 & "] "
    End Sub

    Private Sub sizeTab()
        With Me.TabControl1
            .Top = 0
            .Left = 0
            .Width = Me.Panel2.Width
            .Height = Me.Panel2.Height
        End With
    End Sub




    Private Sub showTabinfo(ByVal isopenNumm As Integer)
        _nTab.DataSource = Nothing
        Me.TabControl1.TabPages(isOpenGNum).Controls.Clear()

        Dim sDt As New DataTable
        sDt = Base._show客户信息(myName, myLiex)
        If myLiex = "绩效表" Then
            Dim newRow As DataRow()
            newRow = sDt.Select("回访次数 < 2")
            If newRow.Length <> 0 Then

                Dim nDt As New DataTable
                nDt = newRow.CopyToDataTable
                _nTab.DataSource = nDt
            End If

        Else

            _nTab.DataSource = sDt
        End If



        Me.TabControl1.TabPages(isopenNumm).Controls.Add(_nTab)
        _nTab.Dock = DockStyle.Fill
        _nTab.BackgroundColor = Color.White
        _nTab.BorderStyle = BorderStyle.None
        _nTab.ReadOnly = True
        Call ShowToos()

    End Sub

    Private Sub doTime()
        Me.Panel3.Location = New Point(-1000, -500)
        Base.getDataTime = ""
        Select Case Me.ComboBox1.Text
            Case "所有"
                Base.getdataTime = "notime"
            Case "今天"
                DateTimePicker1.Value = BuildFrmTo获得服务器时间()
                DateTimePicker2.Value = BuildFrmTo获得服务器时间()
            Case "昨天"
                DateTimePicker1.Value = BuildFrmTo获得服务器时间.AddDays(-1)
                DateTimePicker2.Value = BuildFrmTo获得服务器时间.AddDays(-1)
            Case "本周"
                DateTimePicker1.Value = BuildFrmTo获得服务器时间.AddDays(-IIf(Today.DayOfWeek = 0, 7, Today.DayOfWeek) + 1)
                DateTimePicker2.Value = BuildFrmTo获得服务器时间()
            Case "上周"
                DateTimePicker1.Value = BuildFrmTo获得服务器时间.AddDays(-IIf(Today.DayOfWeek = 0, 7, Today.DayOfWeek) + 1 - 7)
                DateTimePicker2.Value = BuildFrmTo获得服务器时间.AddDays(-IIf(Today.DayOfWeek = 0, 7, Today.DayOfWeek) + 1 - 1)
            Case "本月"
                DateTimePicker1.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间), "01")
                DateTimePicker2.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间) + 1, "01").AddDays(-1)
            Case "上月"
                DateTimePicker1.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间) - 1, "01")
                DateTimePicker2.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间), "01").AddDays(-1)
            Case "本年"
                DateTimePicker1.Value = DateSerial(Year(BuildFrmTo获得服务器时间), "01", "01")
                DateTimePicker2.Value = DateSerial(Year(BuildFrmTo获得服务器时间) + 1, "01", "01").AddDays(-1)
            Case "去年"
                DateTimePicker1.Value = DateSerial(Year(BuildFrmTo获得服务器时间) - 1, "01", "01")
                DateTimePicker2.Value = DateSerial(Year(BuildFrmTo获得服务器时间), "01", "01").AddDays(-1)
            Case "最近一年"
                DateTimePicker1.Value = BuildFrmTo获得服务器时间.AddYears(-1)
                DateTimePicker2.Value = BuildFrmTo获得服务器时间()
            Case "自定义"
                Me.Panel3.Location = New Point(188, 84)
            Case Else
                MessageBox.Show("请正确选择时间！")
        End Select
        If Base.getDataTime <> "notime" Then Base.getDataTime = " and rq2>='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' and rq2<='" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"




    End Sub

    Private Sub 新建客户查询_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub



 


    Private Sub 新建客户查询_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim xGs As New DataTable
        xGs = Base._show业务员()
        For i As Integer = 0 To xGs.Rows.Count - 1
            Me.ListBox1.Items.Add("+" & xGs.Rows(i)("业务员"))
        Next
        Me.ListBox1.Items.Add("+查询所有客户")
        Dim aRlist As DataTable
        aRlist = Base._show客户类型
        For i As Integer = 0 To aRlist.Rows.Count - 1
            Me.TabControl1.TabPages.Add(aRlist.Rows(i)("text"))
        Next
        Me.TabControl1.TabPages.Add("汇总表")
        Me.TabControl1.TabPages.Add("绩效表")
        Call sizeTab()
        Me.ToolStripStatusLabel1.Text = "当前用户：" & Bus_CurrentUser_Fullname
        Me.ToolStripStatusLabel2.Text = ""
        Me.ComboBox1.Text = "所有"
        Me.ComboBox1.Items.AddRange(New Object() {"所有", "今天", "昨天", "本周", "上周", "本月", "上月", "本年", "去年", "最近一年", "自定义"})
        Me.Text = "客户统计表"
        Me.Panel3.Location = New Point(-1000, -500)


    End Sub

    Private Sub Panel2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Resize
        Call sizeTab()
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        isOpenGNum = Me.TabControl1.SelectedIndex
        myLiex = Trim(Me.TabControl1.TabPages(Me.TabControl1.SelectedIndex).Text.ToString)
        Call showTabinfo(Me.TabControl1.SelectedIndex)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim n As String = ""
        Dim arr As Array
        n = Me.ListBox1.Items(Me.ListBox1.SelectedIndex).ToString()
        arr = n.Split("[")
        myName = arr(0).ToString.Replace("+", "")
        If myName = "查询所有客户" Then
            isOpenGNum = Me.TabControl1.TabPages.Count - 2
            Me.TabControl1.SelectedIndex = isOpenGNum
        End If
        myLiex = Me.TabControl1.TabPages(isOpenGNum).Text.ToString


        Call showTabinfo(isOpenGNum)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If myName = "" Then myName = "查询所有客户"
        myLiex = "汇总表"
        isOpenGNum = Me.TabControl1.TabPages.Count - 2
        Me.TabControl1.SelectedIndex = isOpenGNum
        If Base.getDataTime <> "notime" Then Base.getDataTime = " and rq2>='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' and rq2<='" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"
        Call showTabinfo(isOpenGNum)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.Button1.PerformClick()
    End Sub

  
  
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call doTime()
    End Sub

 

End Class