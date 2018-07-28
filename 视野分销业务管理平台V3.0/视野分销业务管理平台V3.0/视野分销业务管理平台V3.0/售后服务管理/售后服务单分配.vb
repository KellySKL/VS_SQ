Public Class 售后服务单分配
    Private Base As New 售后服务单分配管理Base


    Private Sub 查询主窗口_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStrip_分配状态.Text = "未分配"
        DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname
        doselect("")
    End Sub
    Sub doselect(ByVal where As String)
        Panel_正在执行.Visible = True
        My.Application.DoEvents()
        Dim whereStr As String = ""
        If ToolStrip_分配状态.Text = "未分配" Then  '未审批
            whereStr = " and isnull(auditing,'')=''"
        ElseIf ToolStrip_分配状态.Text = "已分配" Then  '未审批
            whereStr = " and isnull(auditing,'')<>''"
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
        DatagridviewEx2.DataSource = Nothing
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
        If DatagridviewEx1.Columns(e.ColumnIndex).Name = "选择" Then
            DatagridviewEx1.Rows(e.RowIndex).Cells("选择").Value = Not DatagridviewEx1.Rows(e.RowIndex).Cells("选择").Value '只有加了这个代码才可以使用复选框
        End If
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
    Private Sub Tool_立即分配_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_立即分配.Click
        '2.1获得模板
        Dim flag As Boolean = False
        For i As Integer = 0 To DatagridviewEx1.Rows.Count - 1  '因为有个合计行；
            If IsNumeric(DatagridviewEx1.Rows(i).Cells("id").Value) Then
                If DatagridviewEx1.Rows(i).Cells("选择").Value = True Then

                    '插入分析报告

                    Dim fx As New 售后服务单作业接收时描述
                    fx.Jcode = Me.DatagridviewEx1.Rows(i).Cells("zf1").Value
                    fx.uWxman = "报修人：" & Me.DatagridviewEx1.Rows(i).Cells("zf27").Value & " 电话：" & Me.DatagridviewEx1.Rows(i).Cells("zf28").Value
                    fx.Tool_单号.Text = Me.DatagridviewEx1.Rows(i).Cells("code").Value
                    fx.cName = Me.DatagridviewEx1.Rows(i).Cells("client").Value
                    fx.cWx = Me.DatagridviewEx1.Rows(i).Cells("BILLTYPE").Value
                    fx.Czrman = Me.DatagridviewEx1.Rows(i).Cells("BillMan").Value
                    fx.cInfo = IIf(IsDBNull(Me.DatagridviewEx1.Rows(i).Cells("notepre").Value), "暂无分析", Me.DatagridviewEx1.Rows(i).Cells("notepre").Value)
                    fx.cRemsg = IIf(IsDBNull(Me.DatagridviewEx1.Rows(i).Cells("zf3").Value), "暂无分析", Me.DatagridviewEx1.Rows(i).Cells("zf3").Value)
                    fx.cId = Me.DatagridviewEx1.Rows(i).Cells("id").Value
                    fx.ShowDialog()
                    If fx.flag = False Then
                        ' MessageBox.Show("用户直接退出或数据异常", "错误！")
                        Exit Sub
                    Else
                        flag = True
                    End If

                   
                End If
            End If
        Next
        If flag = True Then
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            doselect("")
        End If
    End Sub

    Private Sub Tool_反审批_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_反分配.Click
        '2.1获得模板
        Dim flag As Boolean = False
        If MsgBox("请确认是否要继续撤消分配?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub
        For i As Integer = 0 To DatagridviewEx1.Rows.Count - 1  '因为有个合计行；
            If IsNumeric(DatagridviewEx1.Rows(i).Cells("id").Value) Then
                If DatagridviewEx1.Rows(i).Cells("选择").Value = True Then
                    Base.立即审批(DatagridviewEx1.Rows(i).Cells("id").Value, "")
                    flag = True
                End If
            End If
        Next
        If flag = True Then
            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
            err.ShowDialog()
            doselect("")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        doselect("")
    End Sub

    Private Sub ToolStrip_分配状态_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStrip_分配状态.DropDownClosed
        doselect("")
    End Sub

  
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Panel_高级搜索.Visible = False
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click

        If Bus_CurrentUser_Fullname = "张太春" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "lxd" Then
            Dim shDD As New 售后领料审核
            shDD.isUname = "no"
            shDD.ShowDialog()
        End If


    End Sub

 
End Class
