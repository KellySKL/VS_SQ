Public Class 售后服务单作业管理
    Private Base As New 售后服务单作业管理Base
    Dim isHCode As String

    Private Sub 查询主窗口_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStrip_作业状态.Text = "未完成"
        DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname
        Panel_高级搜索.Visible = False
        doselect("")
    End Sub
    Sub doselect(ByVal where As String)
        Panel_正在执行.Visible = True
        My.Application.DoEvents()
        Dim whereStr As String = "  "

        If Bus_CurrentUser_Fullname = "王娅丽" Or Bus_CurrentUser_Fullname = "lxd" Or Bus_CurrentUser_Fullname = "2" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "张太春" Then
            whereStr = ""
        Else
            whereStr = " and billman='" & Bus_CurrentUser_Fullname & "'"
        End If

        If ToolStrip_作业状态.Text = "未完成" Then
            whereStr += "  and sz10=0    "
        ElseIf ToolStrip_作业状态.Text = "维修完工" Then
            whereStr += "  and sz10=1  "
        ElseIf ToolStrip_作业状态.Text = "工单完成" Then  '未电话回访
            whereStr += "  and sz10=2 "
        Else
            '无
        End If

        Dim dt As DataTable
        dt = Base.Get查询(whereStr)
        Dim WhereStr1 As String = ""
        For Each t As String In TextBox_关键字.Text
            If Len(Trim(t)) <= 0 Then Continue For
            If t.IndexOf("=") >= 0 Then Continue For
            For o As Integer = 0 To dt.Columns.Count - 1
                If dt.Columns(o).DataType Is GetType(String) Then
                    If WhereStr1 = "" Then
                        WhereStr1 = dt.Columns(o).Caption & " like '%" & t & "%'  "
                    Else
                        WhereStr1 &= " or " & dt.Columns(o).Caption & " like '%" & t & "%'  "
                    End If
                End If
            Next
        Next
        Dim dv As DataView
        dv = dt.DefaultView
        dv.RowFilter = WhereStr1
        dt = dv.ToTable

        DatagridviewEx1.DataSource = dt
        Panel_正在执行.Visible = False
    End Sub

    Private Sub Tool_打开搜索_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_打开搜索.Click
        Panel_高级搜索.Visible = True
    End Sub


    Private Sub Button_高级查询_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_高级查询.Click
        doselect(Trim(TextBox_关键字.Text))
        Panel_高级搜索.Visible = False
    End Sub

    Private Sub DatagridviewEx1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx1.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub
        isHCode = DatagridviewEx1.Rows(e.RowIndex).Cells("code").Value

        If DatagridviewEx1.Columns(e.ColumnIndex).Name = "选择" Then
            DatagridviewEx1.Rows(e.RowIndex).Cells("选择").Value = Not DatagridviewEx1.Rows(e.RowIndex).Cells("选择").Value '只有加了这个代码才可以使用复选框
        End If

        If e.ColumnIndex = 2 Then
            Dim ss = IIf(IsDBNull(DatagridviewEx1.SelectedRows(0).Cells("zf2").Value), "", DatagridviewEx1.SelectedRows(0).Cells("zf2").Value)
            Dim tt = IIf(IsDBNull(DatagridviewEx1.SelectedRows(0).Cells("zf3").Value), "", DatagridviewEx1.SelectedRows(0).Cells("zf3").Value)
            If ss <> "" And tt <> "" Then
                If IIf(IsDBNull(DatagridviewEx1.SelectedRows(0).Cells("zf2").Value), "", DatagridviewEx1.SelectedRows(0).Cells("zf2").Value) = Bus_CurrentUser_Fullname Or Bus_CurrentUser_Fullname = "lxd" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "张太春" Then
                    Dim t As New 售后服务单作业完成时描述
                    t.单号.Text = DatagridviewEx1.SelectedRows(0).Cells("code").Value
                    t.Tool维修人员.Text = DatagridviewEx1.SelectedRows(0).Cells("billman").Value
                    t.ShowDialog()
                Else
                    MessageBox.Show("当前单据不属于[" & Bus_CurrentUser_Fullname & "] 维修人员！请选择自己的单据操作")
                End If
                doselect("")
            Else
                MessageBox.Show("维修人员或分析描述为空！无法打开窗口！")
            End If
        End If



    End Sub




    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        For i As Integer = 0 To DatagridviewEx1.Rows.Count - 1  '因为有个合计行；
            If DatagridviewEx1.Rows(i).Cells("选择").Value = True Then
                Dim ss = IIf(IsDBNull(DatagridviewEx1.Rows(i).Cells("zf2").Value), "", DatagridviewEx1.Rows(i).Cells("zf2").Value)
                Dim tt = IIf(IsDBNull(DatagridviewEx1.Rows(i).Cells("zf3").Value), "", DatagridviewEx1.Rows(i).Cells("zf3").Value)
                If ss <> "" And tt <> "" Then
                    If IIf(IsDBNull(DatagridviewEx1.Rows(i).Cells("zf2").Value), "", DatagridviewEx1.Rows(i).Cells("zf2").Value) = Bus_CurrentUser_Fullname Or Bus_CurrentUser_Fullname = "lxd" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "张太春" Then
                        Dim t As New 售后服务单作业完成时描述
                        t.单号.Text = DatagridviewEx1.Rows(i).Cells("code").Value
                        t.Tool维修人员.Text = DatagridviewEx1.Rows(i).Cells("billman").Value
                        t.ShowDialog()
                    Else
                        MessageBox.Show("当前单据不属于[" & Bus_CurrentUser_Fullname & "] 维修人员！请选择自己的单据操作")
                    End If
                Else
                    MessageBox.Show("维修人员或分析描述为空！无法打开窗口！")
                End If
            End If
        Next
        doselect("")





    End Sub




    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DatagridviewEx1.CellMouseUp
        If e.RowIndex < 0 Then Exit Sub
        If DatagridviewEx1.SelectedRows.Count >= 2 Then
            For i As Integer = 0 To DatagridviewEx1.SelectedRows.Count - 1
                DatagridviewEx1.SelectedRows(i).Cells("选择").Value = True
            Next
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim dt As DataTable
            dt = SyERP20.GetBill单据附件记录(DatagridviewEx1.Rows(e.RowIndex).Cells("code").Value, "", "")
            If dt.Rows.Count > 1 Then
                ContextMenuStrip_图片附件.Items.Clear()
                For k As Integer = 0 To dt.Rows.Count - 1
                    Dim t2 As New ToolStripMenuItem
                    t2.Tag = dt.Rows(k)("id")
                    t2.Text = dt.Rows(k)("guserdef1")
                    ContextMenuStrip_图片附件.Items.Add(t2)
                Next
                ContextMenuStrip_图片附件.Show(MousePosition.X, MousePosition.Y)
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_图片附件_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip_图片附件.ItemClicked
        Dim t As New SyERP20.单据附件上传器Base
        Dim filepath As String = ""
        filepath = t.download(e.ClickedItem.Tag)
        Dim file As New IO.FileInfo(filepath)
        If file.Exists Then
            Dim dirprocess As New ProcessStartInfo
            dirprocess.FileName = filepath
            Process.Start(dirprocess)
        Else
            Dim err As New SyERP20.ErrorForm("文件不存在!", Nothing)
            err.ShowDialog()
        End If
    End Sub
    Private Sub ToolStrip_作业状态_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStrip_作业状态.DropDownClosed
        doselect("")
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        '2.1获得模板
        Dim flag As Boolean = False
        'Dim tt As New 售后服务单作业接收时描述
        'tt.ShowDialog()
        For i As Integer = 0 To DatagridviewEx1.Rows.Count - 1  '因为有个合计行；
            If IsNumeric(DatagridviewEx1.Rows(i).Cells("id").Value) Then
                If DatagridviewEx1.Rows(i).Cells("选择").Value = True Then
                    If IIf(IsDBNull(DatagridviewEx1.Rows(i).Cells("billman").Value), "", DatagridviewEx1.Rows(i).Cells("billman").Value) <> Bus_CurrentUser_Fullname Then
                        MsgBox("只有" & IIf(IsDBNull(DatagridviewEx1.Rows(i).Cells("billman").Value), "", DatagridviewEx1.Rows(i).Cells("billman").Value) & "才可以接收")
                    Else
                        Dim seletfrm As New SyERP20.SelectFormBase
                        Base.立即接收(DatagridviewEx1.Rows(i).Cells("id").Value, Bus_CurrentUser_Fullname) 'tt.TextBox_原因分析.Text
                    End If
                End If
                    flag = True
                End If
        Next

        If flag = True Then
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            doselect("")
        End If
    End Sub

    Private Sub Tool_导出EXCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_导出EXCEL.Click
        ' SyERP20.SaveToXls(DatagridviewEx1, "售后服务单作业管理", False, True)
        SyERP20.导出EXCELByNPOI(DatagridviewEx1, Me.Label1, "售后服务单作业管理", False, True)


    End Sub
 
 
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Panel_高级搜索.Visible = False
    End Sub

  
End Class