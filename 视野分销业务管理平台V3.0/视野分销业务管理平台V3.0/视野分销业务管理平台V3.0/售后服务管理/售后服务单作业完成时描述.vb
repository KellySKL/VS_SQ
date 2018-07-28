Public Class 售后服务单作业完成时描述
    Private base As New 售后服务单作业完成时描述Base '
    Private bass As New 售后服务维修问题库base
    Dim ct As DataTable

    Dim ppNumn As Integer = 1
    Dim bman As String = ""
    Dim btel As String = ""



    Private Sub chColor()
        For i As Integer = 0 To Me.DatagridviewEx1.RowCount - 1
            If Me.DatagridviewEx1.Rows(i).Cells("billtype").Value = "售后服务领料" Then
                If IIf(IsDBNull(Me.DatagridviewEx1.Rows(i).Cells("auditing").Value), "", Me.DatagridviewEx1.Rows(i).Cells("auditing").Value) = "" Then
                    Me.DatagridviewEx1.Rows(i).Visible = False
                Else
                    Me.DatagridviewEx1.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen
                End If

            End If

        Next

    End Sub

    Public Sub showWl()
        '未处理物料
        Dim dt As New DataTable
        dt = base.GetppaLL(单号.Text)
        Tool_未入库合计.Text = IIf(IsDBNull(dt.Compute("sum(欠量)", "")), 0, dt.Compute("sum(欠量)", ""))
        DatagridviewEx1.DataSource = dt
        Call chColor()
    End Sub
    Private Sub 售后服务单作业完成时描述_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname
        'Me.DatagridviewEx2.当前用户名 = Bus_CurrentUser_Fullname
        'Me.DatagridviewEx3.当前用户名 = Bus_CurrentUser_Fullname
        'Me.DatagridviewEx4.当前用户名 = Bus_CurrentUser_Fullname '维修清单
        Me.DatagridviewEx5.当前用户名 = Bus_CurrentUser_Fullname
   
        Me.TabControl1.TabPages.RemoveAt(3)
        Me.TabControl1.TabPages.RemoveAt(2)
        Me.TabControl1.TabPages.RemoveAt(1)
        Me.Panel5.Height = 70
        Me.Panel4.Visible = False

        '服务单


        'TextBox_故障类别.Text = base.故障类别(单号.Text)
        Dim whe As String = " and code='" & 单号.Text.Trim & "'"
        ct = base.Get查询(whe)

        Me.Label10.Text = IIf(IsDBNull(ct.Rows(0)("zf27")), "", ct.Rows(0)("zf27"))
        Me.Label11.Text = IIf(IsDBNull(ct.Rows(0)("zf28")), "", ct.Rows(0)("zf28"))

        ppNumn = IIf(IsDBNull(ct.Rows(0)("sz8")) Or ct.Rows(0)("sz8") = 0.0, 1, ct.Rows(0)("sz8"))

        Me.Label7.Text = IIf(IsDBNull(ct.Rows(0)("client")), "", ct.Rows(0)("client"))
        Me.Label5.Text = IIf(IsDBNull(ct.Rows(0)("billtype")), "", ct.Rows(0)("billtype")) & " | 时间：" & IIf(IsDBNull(ct.Rows(0)("zf9")), "", ct.Rows(0)("zf9")) & " | 第[" & ppNumn & "]次服务"

        Me.TextBox_结论.Text = IIf(IsDBNull(ct.Rows(0)("zf5")), "", ct.Rows(0)("zf5"))
        Me.TextBox2.Text = IIf(IsDBNull(ct.Rows(0)("zf3")), "", ct.Rows(0)("zf3"))
        Me.TextBox4.Text = IIf(IsDBNull(ct.Rows(0)("notepre")), "", ct.Rows(0)("notepre"))
        Dim sbNum As Integer = CType(IIf(IsDBNull(ct.Rows(0)("sz10")), 99, ct.Rows(0)("sz10")), Integer)
        If sbNum = 0 Then  Me.ToolStripLabel5.Enabled = False




        showWl()

        Dim Jcode As String = ct.Rows(0)("zf1")
        DatagridviewEx5.DataSource = bass.GetwxInfo(Jcode, 1)
        ' DatagridviewEx4.DataSource = base.getWxkk(单号.Text.Trim)

    End Sub
   
    Private Sub show分配单(ByVal isTye As String, ByVal eindex As Integer, ByVal obc As Object)
        If Bus_CurrentUser_Fullname = "张太春" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "lxd" Then
            Dim isTypy As String = IIf(IsDBNull(obc.Rows(eindex).Cells("billtype").Value), "", obc.Rows(eindex).Cells("billtype").Value)
            If isTypy = isTye Then


                Dim ppm As String = IIf(IsDBNull(obc.Rows(eindex).Cells("auditing").Value), "", obc.Rows(eindex).Cells("auditing").Value)
                If ppm = "" And isTye = "售后服务领料" Then
                    MessageBox.Show("当前单据未审核，不能进行单据操作", "提示")
                    Exit Sub
                End If

                Dim ct1 As String = IIf(IsDBNull(obc.Rows(eindex).Cells("paytype").Value), "", obc.Rows(eindex).Cells("paytype").Value)
                Dim ct2 As String = IIf(IsDBNull(obc.Rows(eindex).Cells("code").Value), "", obc.Rows(eindex).Cells("code").Value)
                Dim ct3 As String = IIf(IsDBNull(obc.Rows(eindex).Cells("materialCODE").Value), "", obc.Rows(eindex).Cells("materialCODE").Value)
                Dim ct4 As String = IIf(IsDBNull(obc.Rows(eindex).Cells("materialNAME").Value), "", obc.Rows(eindex).Cells("materialNAME").Value)
                Dim BacNum As Decimal = base.readCkNum(ct1, ct2, ct3, ct4)


                If BacNum <= 0 And isTye = "售后服务领料" Then
                    MessageBox.Show("当前单据未出库，不能进行单据操作", "提示")
                    Exit Sub
                End If

                Dim isTnum As Decimal = IIf(IsDBNull(obc.Rows(eindex).Cells("freenum1").Value), 0, obc.Rows(eindex).Cells("freenum1").Value)
                Dim isTnums As Decimal = IIf(IsDBNull(obc.Rows(eindex).Cells("QUANTITY").Value), 0, obc.Rows(eindex).Cells("QUANTITY").Value)

                If (isTnum >= isTnums) Then
                    MessageBox.Show("数据已处理，请勿重复操作当前单据!", "提示")
                    Exit Sub
                End If
                Dim cc As New 售后领料单分配new(AddressOf showWl) With {
                    .pT1 = IIf(IsDBNull(obc.Rows(eindex).Cells("billtype").Value), "", obc.Rows(eindex).Cells("billtype").Value),
                    .pT2 = ct2,
                    .pT3 = ct1,
                    .pT5 = IIf(IsDBNull(ct.Rows(0)("billtype")), "", ct.Rows(0)("billtype")),
                    .pT4 = ppNumn,
                    .KF = Label7.Text.Trim(),
                    .id = CType(obc.SelectedRows(0).Cells("id").Value, Integer)
                }
                cc.ShowDialog()

            End If
        End If

    End Sub

 
    Private Sub DatagridviewEx3_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx3.CellDoubleClick
        ' show分配单("售后返厂维修", e.RowIndex, Me.DatagridviewEx3)
    End Sub

    Private Sub DatagridviewEx1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx1.CellDoubleClick
        show分配单("售后服务领料", e.RowIndex, Me.DatagridviewEx1)
    End Sub



    '    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel4.Click

    'haha:   Dim input As New SyERP20.InputboxForm '提示框
    '        input.Showitem("请输入服务费金额：")
    '        input.ShowDialog()
    '        If input.ReturnBillNote = "" Then Exit Sub
    '        Dim stNum As New Decimal
    '        stNum = CType(input.ReturnBillNote, Decimal)
    '        If stNum <= 0 Then
    '            MessageBox.Show("输入的数值：[" & input.ReturnBillNote & "] 为负数，请不要输入负数")
    '            GoTo haha
    '        End If


    '        If IsNumeric(stNum) Then
    '            Dim t As New SyERP20.F_SalesMakeBase
    '            t._BILLTYPE = "服务费结算"
    '            t._Client = ct.Rows(0)("client")
    '            t._Paytype = "应收帐款"
    '            Dim newrow As DataRow = t.ProductTable.NewRow
    '            newrow("货物代码") = "99999998"
    '            newrow("货物名称") = "售后服务费"
    '            newrow("数量") = 1
    '            newrow("单价") = input.ReturnBillNote
    '            newrow("引用单号") = 单号.Text
    '            newrow("引用id") = -1
    '            t.ProductTable.Rows.Add(newrow)
    '            t.AddSave()
    '            Dim err As New SyERP20.ErrorForm("完成！", Nothing)
    '            err.ShowDialog()
    '        End If
    '    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        If CType(Tool_未入库合计.Text, Integer) <> 0 Then
            Dim err As New SyERP20.ErrorForm("尚有未处理的维修零件清单,请先退库或结算开单！", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        'Dim Dm As New List(Of String)
        'For i = 0 To DatagridviewEx1.Rows.Count
        '    If DatagridviewEx1.Rows(i).Cells("分配组").Value = "售后服务领料" Then
        '        Dm.Add(DatagridviewEx1.Rows(1).Cells("分配组").Value)
        '    End If
        'Next



        If CType(Tool_未入库合计.Text, Integer) = 0 Then
            Dim whxx As String
            whxx = "'" + 单号.Text + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修员-维修完工-[工单编号：" & 单号.Text & "]，请做好电话回访工作',getdate(),'','','','','王娅丽','','','','','','','','手动发送','','')"
            base._setMsg(whxx)
            'whxx = "'" + 单号.Text + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修员-维修完工-[工单编号：" & 单号.Text & "]，请做好电话回访工作',getdate(),'','','','','卢龙','','','','','','','','手动发送','','')"
            'base._setMsg(whxx)
            MessageBox.Show("已通知相关部门继续后续工作！！")
            base.立即完成(单号.Text, Bus_CurrentUser_Fullname, Trim(TextBox_结论.Text), Trim(Me.TextBox2.Text))
        End If

        'If Val(Tool_售后服务单行数.Text) <= 0 Then
        '    Dim err As New SyERP20.ErrorForm("尚未进行服务单结算开单！不能继续！", Nothing)
        '    err.ShowDialog()
        '    Exit Sub
        'End If

        Close()


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        base.立即完成(单号.Text, "no", Trim(TextBox_结论.Text), Trim(Me.TextBox2.Text))
    End Sub

#Region "满意度调查"

    Private Sub RadioButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.Click
        If Me.RadioButton5.Checked = True Then Me.TextBox1.Text = "不满意"
    End Sub
    Private Sub RadioButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.Click
        If Me.RadioButton6.Checked = True Then Me.TextBox1.Text = "一般"
    End Sub
    Private Sub RadioButton8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton8.Click
        If Me.RadioButton8.Checked = True Then Me.TextBox1.Text = "满意"
    End Sub
    Private Sub RadioButton7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton7.Click
        If Me.RadioButton7.Checked = True Then Me.TextBox1.Text = "非常满意"
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If Me.RadioButton2.Checked = True Then Me.TextBox3.Text = "未完成维修任务" : Me.CheckBox1.Checked = True
    End Sub
    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If Me.RadioButton1.Checked = True Then Me.TextBox3.Text = "一般" : Me.CheckBox1.Checked = False
    End Sub
    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        If Me.RadioButton3.Checked = True Then Me.TextBox3.Text = "满意" : Me.CheckBox1.Checked = False
    End Sub
    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        If Me.RadioButton4.Checked = True Then Me.TextBox3.Text = "非常满意" : Me.CheckBox1.Checked = False
    End Sub

#End Region
    Private Sub ToolStripLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel5.Click
        If Bus_CurrentUser_Fullname = "王娅丽" Or Bus_CurrentUser_Fullname = "lxd" Or Bus_CurrentUser_Fullname = "郑昌仁" Then
            Me.Panel4.Visible = True
            Me.Panel5.Height = 247
        Else
            MessageBox.Show("你无法使用电话回访功能！", "提醒")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TextBox3.Text.Trim = "" Or Me.TextBox1.Text.Trim = "" Then
            MessageBox.Show("请输入电话回访反馈内容！", "提醒")
            Exit Sub
        End If
        If Me.CheckBox1.Checked = True Then
            MessageBox.Show(base.updReback(ct.Rows(0)("id"), False, "", Trim(Me.TextBox3.Text), Trim(Me.TextBox1.Text)), "提醒")
            Me.Close()
        Else
            MessageBox.Show(base.updReback(ct.Rows(0)("id"), True, Bus_CurrentUser_Fullname, Trim(Me.TextBox3.Text), Trim(Me.TextBox1.Text)), "提醒")
            Me.Close()

        End If
    End Sub
    Private Sub showList(ByVal xname As String)
        Try
            Dim mm As New 售后领料
            Dim obj As New SyERP20.F_领料计划单

            mm.Controls.Add(obj)
            mm.Show()
            obj.对方名称.Text = Bus_CurrentUser_Fullname
            obj.Base._Paytype = 单号.Text
            obj.ComboBoxBilltype.Items.Clear()
            obj.ComboBoxBilltype.Items.Add(xname)
            obj.ComboBoxBilltype.Text = xname

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel6.Click
        Call showList("售后返厂维修")
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Panel4.Visible = False
        Me.Panel5.Height = 70
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim t As New 售后服务维修问题库
        t.openMe(Trim(单号.Text))

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mm As New 售后附件表
        mm.mWxnm = 单号.Text
        mm.mName = Me.Label7.Text
        mm.cUname = Bus_CurrentUser_Fullname
        mm.ShowDialog()
    End Sub



    'Private Sub DatagridviewEx4_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx4.CellContentDoubleClick
    '    Dim tt As String = IIf(IsDBNull(Me.DatagridviewEx4.Rows(e.RowIndex).Cells("BILLTYPE").Value), "", Me.DatagridviewEx4.Rows(e.RowIndex).Cells("BILLTYPE").Value)
    '    Dim gg As String = IIf(IsDBNull(Me.DatagridviewEx4.Rows(e.RowIndex).Cells("freestr4").Value), "", Me.DatagridviewEx4.Rows(e.RowIndex).Cells("freestr4").Value)
    '    Dim nn As String = IIf(IsDBNull(Me.DatagridviewEx4.Rows(e.RowIndex).Cells("materialNAME").Value), "", Me.DatagridviewEx4.Rows(e.RowIndex).Cells("materialNAME").Value)
    '    Dim ii As Integer = IIf(IsDBNull(Me.DatagridviewEx4.Rows(e.RowIndex).Cells("id").Value), 0, Me.DatagridviewEx4.Rows(e.RowIndex).Cells("id").Value)
    '    If ii = 0 Then MsgBox("id错误！") : Exit Sub
    '    If gg = "" And tt = "售后待维修" Then Dim cc As New 售后返厂配件分配(单号.Text.Trim, Me.Label7.Text.Trim, nn, ii, Me)

    'End Sub
    '返回值

End Class