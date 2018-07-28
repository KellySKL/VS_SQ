Imports System.IO

Public Class 客户回访管理
    Private Base As New 客户回访管理Base
    Public Rtext As String
    Public nexTime As Date


    Public Sub _showInfoli(ByVal Rowid As Integer)
        DatagridviewEx回访预警.Rows(Rowid).DefaultCellStyle.BackColor = Color.LightGreen
        DatagridviewEx回访预警.Rows(Rowid).DefaultCellStyle.ForeColor = Color.Black
        DatagridviewEx回访预警.Rows(Rowid).Cells("拜访次数").Value += 1
        DatagridviewEx回访预警.Rows(Rowid).Cells("倒计时").Value = DateDiff(DateInterval.Day, Now, nexTime) + DatagridviewEx回访预警.Rows(Rowid).Cells("回访间隔").Value
        DatagridviewEx回访预警.Rows(Rowid).Cells("最近一次拜访内容").Value = Rtext
    End Sub


    Private Sub 查询主窗口_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' ComboBox_天数.Items.Clear()
        DatagridviewEx回访预警.当前用户名 = Bus_CurrentUser_Fullname
        '执行效率非常慢，将取消这种方法
        'Dim 日期类型 As String = IO.File.ReadAllText(Application.StartupPath & "\DateType.dat")
        'Dim arr() As String = 日期类型.Split(Chr(13))
        'Dim flag As Boolean
        'If arr.Length >= 1 Then
        '    For Each str1 As String In arr
        '        Dim tt As String = str1.Replace(Chr(10), "").Replace(" ", "")
        '        If tt <> "" Then ComboBox_天数.Items.Add(tt) : flag = True
        '    Next
        'End If



        Me.ComboBox_天数.Items.AddRange(New Object() {"所有", "未回访", "已回访"})
        ' CheckBox_所有客户.Checked = True
        '  ComboBox_天数.Text = "未回访"
        'doselect()

        Me.CheckBox1.Text = "当前：" & Bus_CurrentUser_Fullname

        If Bus_CurrentUser_Fullname = "lxd" Or Bus_CurrentUser_Fullname = "admin" Or Bus_CurrentUser_Fullname = "王娅丽" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "张丽" Then
            CheckBox_所有客户.Visible = True
            CheckBox1.Checked = False
            ' CheckBox1.Enabled = False
        Else
            CheckBox_所有客户.Visible = False
            CheckBox1.Checked = True
            CheckBox1.Enabled = False

        End If

    End Sub

    Sub doselect()
        Panel_正在执行.Visible = True
        My.Application.DoEvents()
        Dim whereStr As String = ""
        If ComboBox_天数.Text.IndexOf("天") >= 0 Then
            whereStr += "   and   DATEDIFF(day, rq1, getdate()) >=  " & ComboBox_天数.Text.Trim.Replace("天", "") & " "
        ElseIf ComboBox_天数.Text.IndexOf("月") >= 0 Then
            whereStr += "   and   DATEDIFF(MONTH,  rq1, getdate()) >= " & ComboBox_天数.Text.Trim.Replace("月", "") & " "
        ElseIf ComboBox_天数.Text.IndexOf("年") >= 0 Then
            whereStr += "   and   DATEDIFF(YEAR,  rq1, getdate()) >= " & ComboBox_天数.Text.Trim.Replace("年", "") & " "
        ElseIf ComboBox_天数.Text.IndexOf("已回访") >= 0 Then
            whereStr += "   and   DATEDIFF(day,  rq1, getdate()) < = 0 "
        ElseIf ComboBox_天数.Text.IndexOf("未回访") >= 0 Then
            whereStr += "   and   DATEDIFF(day, rq1, getdate()) >0 "
        ElseIf ComboBox_天数.Text = "所有" Then '默认是导出所有数据 或许会卡
            whereStr += "     "

        End If


        If Len(关键字.Text) >= 1 Then
            Dim textArr() As String = 关键字.Text.Split(" ") '不错的空格 AND 查询
            For Each t As String In textArr
                If Len(Trim(t)) <= 0 Then Continue For
                If t.IndexOf("=") >= 0 Then Continue For
                whereStr += " and (name like '%" & t & "%' or " & _
                              " CODE like '%" & t & "%' or " & _
                              " FULLNAME like '%" & t & "%' or " & _
                              " AREANAME like '%" & t & "%' or " & _
                              " CONTACTOR like '%" & t & "%'   or " &
                                  " CONTACTORspell like '%" & t & "%'   or " & _
                              " PHONE like '%" & t & "%' or " & _
                              " TEL1 like '%" & t & "%' or " & _
                              " lev like '%" & t & "%' or " & _
                                "TRADETYPENAME like '%" & t & "%' or " & _
                              " TEL2 like '%" & t & "%' or " & _
                              " FAX like '%" & t & "%'  "
                whereStr += ")"
            Next
        End If


        If CheckBox_所有客户.Checked = False Then
            whereStr += " and  AREANAME in (select '='+AREANAME+'|' from areaku where guserdef1 like '%" & Bus_CurrentUser_Fullname & "%' or guserdef1 like '%" & bus_CurrentUser_mastername & "%')"
           
            '  whereStr += " and (FULLNAMEspell = '%" & Bus_CurrentUser_Fullname & "%' or 创建人 = '%" & Bus_CurrentUser_Fullname & "%' or MaxValue = '%" & Bus_CurrentUser_Fullname & "%')"



        End If


        If CheckBox1.Checked = True Then whereStr += " and (FULLNAMEspell = '" & Bus_CurrentUser_Fullname & "' or 创建人 = '" & Bus_CurrentUser_Fullname & "' or MaxValue = '" & Bus_CurrentUser_Fullname & "')"


        DatagridviewEx回访预警.DataSource = Base.Get查询(whereStr)
        Panel_正在执行.Visible = False






        'Dim GsName_ As String = ""
        'For i As Integer = 0 To DatagridviewEx回访预警.Rows.Count - 1
        '    '延后处理(为了读取速度)
        '    GsName_ = DatagridviewEx回访预警.Rows(i).Cells("name").Value.ToString
        '    DatagridviewEx回访预警.Rows(i).Cells("最近一次拜访内容").Value = Base._showHFnote(GsName_, 1)
        '    DatagridviewEx回访预警.Rows(i).Cells("拜访次数").Value = Base._showHFnote(GsName_, 2)
        'Next



    End Sub
    '日期更改时



    Private Sub DatagridviewEx回访预警_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx回访预警.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If DatagridviewEx回访预警.Columns(e.ColumnIndex).Name = "立即拜访" Then
            Dim 客户名称 As String
            客户名称 = DatagridviewEx回访预警.Rows(e.RowIndex).Cells("name").Value

            'Dim window As New Form
            'window.Size = New Size(1024, 600)
            'window.StartPosition = FormStartPosition.CenterScreen

            Dim t As New 业务拜访记录单
            t.ComboBox_客户类型.Text = DatagridviewEx回访预警.Rows(e.RowIndex).Cells("TRADETYPENAME").Value
            t.textbox_客户名称.Text = 客户名称
            t.frm = Me
            t.isOpenRowsNums = e.RowIndex
            t.isRetrun = True

            t.ShowDialog()
            'window.Controls.Add(t)
            'window.ShowDialog()


        End If
    End Sub

    Private Sub DatagridviewEx回访预警_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx回访预警.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Dim 客户名称 As String
        客户名称 = DatagridviewEx回访预警.Rows(e.RowIndex).Cells("name").Value


        Dim window As New Form
        window.Size = New Size(1024, 600)
        window.StartPosition = FormStartPosition.CenterScreen

        Dim t As New 业务拜访记录单历史查询
        t.CheckBox_所有客户.Checked = True
        t._where += " and client = '" & 客户名称 & "'"
        window.Controls.Add(t)
        window.ShowDialog()


    End Sub

    Private Sub DatagridviewEx回访预警_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DatagridviewEx回访预警.DataBindingComplete
        If e.ListChangedType = System.ComponentModel.ListChangedType.Reset Then

            For i As Integer = 0 To DatagridviewEx回访预警.Rows.Count - 1
                Try
                    If InStr(IIf(IsDBNull(DatagridviewEx回访预警.Rows(i).Cells("倒计时").Value), "", DatagridviewEx回访预警.Rows(i).Cells("倒计时").Value), "-") > 0 Then
                        DatagridviewEx回访预警.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                End Try
            Next
        End If
    End Sub



    Private Sub but_左侧显示_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_左侧显示.Click
        SplitContainer1.Panel1Collapsed = Not SplitContainer1.Panel1Collapsed
    End Sub
    Private Sub but_导出EXCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_导出EXCEL.Click
        '  SyERP20.SaveToXls(DatagridviewEx回访预警, lbl_标题.Text, True)

        SyERP20.导出EXCELByNPOI(DatagridviewEx回访预警, Me.Label5, lbl_标题.Text, False, True)
    End Sub
    Private Sub but_查询_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_查询.Click
        doselect()
    End Sub
    Private Sub ComboBox天数_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox_天数.SelectedIndexChanged
        If ComboBox_天数.Text <> "" Then doselect()
    End Sub

    Private Sub 关键字_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles 关键字.KeyUp
        If e.KeyCode = Keys.Enter Then doselect()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Tool_编辑预警天数.Click
        预警天数设置窗口.ShowDialog()
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        MessageBox.Show(Base._updateHF())

    End Sub

 
End Class


