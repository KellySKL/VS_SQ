Public Class 售后领料审核
    Dim Base As New 售后领料审核base
    Dim isFIst As Boolean = True
    Dim zTmm As String = "未审核"
    Dim code As String
    Dim isZf As Boolean = False
    Dim isZx As Boolean = False
    Public isUname As String


    Private Sub 售后领料审核_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Base.uNmm = isUname

        Me.DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname
        Me.DatagridviewEx2.当前用户名 = Bus_CurrentUser_Fullname
        Call showLIst("no", zTmm)
        Me.Panel2.Visible = False
        Me.ComboBox2.Items.AddRange(New Object() {"未审核", "所有", "已审核", "已作废"})
        Me.ComboBox2.Text = "未审核"
        Me.ComboBox1.Items.AddRange(New Object() {"所有", "近期", "今天", "昨天", "本周", "上周", "本月", "上月", "本年", "去年", "最近一年", "自定义"})
        Me.ComboBox1.Text = "近期"
        isFIst = False


    End Sub

    Private Sub showLIst(ByVal txt As String, ByVal ztm As String)
        Base.uNmm = isUname
        Me.DatagridviewEx1.DataSource = Base._rz_getList(txt, ztm)
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If isFIst = False Then Call showLIst(Trim(Me.TextBox1.Text), Trim(Me.ComboBox2.Text))
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.Panel4.Location = New Point(-1000, -1000)
        Base.getdataTime = ""
        Select Case Me.ComboBox1.Text
            Case "近期"   '默认前后1个月时间
                DateTimePicker1.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间) - 1, "01")
                DateTimePicker2.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间) + 1, "01").AddDays(-1)
            Case "所有"
                Base.getdataTime = "no"
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
                Me.Panel4.Location = New Point(834, 10)
            Case Else
                MessageBox.Show("请正确选择时间！")
                Base.getdataTime = ""
                Exit Sub
        End Select
        If Base.getdataTime <> "no" Then Base.getdataTime = " and introducerDate >='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' and introducerDate <='" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"


        If isFIst = False Then Call showLIst(Trim(Me.TextBox1.Text), zTmm)
    End Sub


    Private Sub DatagridviewEx1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx1.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If Me.Panel2.Visible = True Then Exit Sub
        Dim isXf As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(e.RowIndex).Cells("freenum1").Value), "", Me.DatagridviewEx1.Rows(e.RowIndex).Cells("freenum1").Value)
        Dim isXx As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(e.RowIndex).Cells("auditing").Value), "", Me.DatagridviewEx1.Rows(e.RowIndex).Cells("auditing").Value)
        If isXf = "" Then isZf = True
        If isXx = "" Then isZx = True

        code = Me.DatagridviewEx1.Rows(e.RowIndex).Cells("code").Value

        Me.Panel2.Visible = True
        Me.DatagridviewEx2.DataSource = Base._rz_List(code)

        If isZf = False Then
            Me.Button2.Enabled = False
            Me.Button3.Enabled = False
        Else
            Me.Button2.Enabled = True
        End If
        If isZx = False Then
            Me.Button3.Enabled = False
        Else
            Me.Button3.Enabled = True
        End If

    End Sub


 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show(Base._rz_审核(Bus_CurrentUser_Fullname, code, 2), "提示")
        Label6_Click(sender, e)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Panel2.Visible = False
        Me.DatagridviewEx2.DataSource = Nothing
        isZf = False
        isZx = False

        Call showLIst(Trim(Me.TextBox1.Text), Trim(Me.ComboBox2.Text))
    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        '金额判断是否超过 500元。。。
        Dim isPrice As Decimal = 20

        Dim zf1 As String = ""
        Dim inJG As Decimal = 0
        Dim iscodem As String = IIf(IsDBNull(Me.DatagridviewEx2.Rows(0).Cells("CODE").Value), "", Me.DatagridviewEx2.Rows(0).Cells("CODE").Value)
        For i As Integer = 0 To Me.DatagridviewEx2.Rows.Count - 1
            zf1 = IIf(IsDBNull(Me.DatagridviewEx2.Rows(i).Cells("materialCODE").Value), "", Me.DatagridviewEx2.Rows(i).Cells("materialCODE").Value)
            inJG += Base._rz_价格(zf1)
        Next
        If inJG > isPrice Then
            MessageBox.Show("当前单据金额大于 " & isPrice & " ，已推送消息至总经办，请联系进行审核！", "提醒")
            Dim whxx As String
            whxx = "'" + iscodem + "','','" + Bus_CurrentUser_Fullname + "','[当前售后领料单：" & iscodem & "]，金额已经超过" & isPrice & "元，请总经办审批',getdate(),'','','','','郑昌仁','','','','','','','','手动发送','','')"
            Base._setMsg(whxx)
            Exit Sub
        End If



        MessageBox.Show(Base._rz_审核(Bus_CurrentUser_Fullname, code, 1), "提示")
        Label6_Click(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call showLIst(Trim(Me.TextBox1.Text), zTmm)
    End Sub

End Class