Public Class 售后领料单分配器

    Private base As New 售后服务单作业完成时描述Base
    Public pT1 As String
    Public pT2 As String
    Public pT3 As String
    Public pT4 As Integer
    Public pT5 As String
    Dim Ptt As String = ""  '客户借用标记
    Dim Ptc As String = "系统自动审核" '审核标记
    Dim isYs As String = ""
    Dim isInfo As String = ""
    Dim isBilltype As String = ""
    Dim insTname As String = ""
    Dim isGetRindex As Integer = 0
    Dim isSNum As Decimal
    Dim isPNum As Decimal


    Private Sub seTmessage(ByVal isopeN As Boolean)

        If Me.RadioButton1.Checked = True Then
            isBilltype = "售后维修收费"
            isYs = "Y"
            isInfo = "保修期内收费[维修单号：" & pT3 & "]"
            Dim whxx As String
            whxx = "'" + pT2 + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修人员请求-配件销售申请-[维修单号：" & pT3 & "]，请销售部做好相关工作',getdate(),'','','','','吴冬女','','','','','','','','手动发送','','')"
            Call base._setMsg(whxx)



        End If

        If Me.RadioButton2.Checked = True Then
            isBilltype = "售后保修免费"
            isYs = "N"
            isInfo = "保修期内免费[维修单号：" & pT3 & "]"

            Dim whxx As String
            whxx = "'" + pT2 + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修人员请求-配件免费申请-[维修单号：" & pT3 & "]，总经办审批',getdate(),'','','','','郑昌仁','','','','','','','','手动发送','','')"
            Call base._setMsg(whxx)

        End If

        If Me.RadioButton3.Checked = True Then
            isBilltype = "售后维修收费"
            isYs = "Y"
            isInfo = "保修期外收费[维修单号：" & pT3 & "]"

            Dim whxx As String
            whxx = "'" + pT2 + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修人员请求-配件销售申请-[维修单号：" & pT3 & "]，请销售部做好相关工作',getdate(),'','','','','吴冬女','','','','','','','','手动发送','','')"
            Call base._setMsg(whxx)


        End If

        If Me.RadioButton4.Checked = True Then
            isBilltype = "售后保修免费"
            isYs = "G" '特殊标记
            isInfo = "保修期外免费[维修单号：" & pT3 & "]"

            Dim whxx As String
            whxx = "'" + pT2 + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修人员请求-配件免费申请-[维修单号：" & pT3 & "]，总经办审批',getdate(),'','','','','郑昌仁','','','','','','','','手动发送','','')"
            Call base._setMsg(whxx)


        End If
 


        If Me.RadioButton6.Checked = True Then
            isYs = "F"
            isBilltype = "售后返厂报废"
            isInfo = "售后返厂报废[维修单号：" & pT3 & "]"

            Dim whxx As String
            whxx = "'" + pT2 + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修人员请求-售后返厂报废-[维修单号：" & pT3 & "]，请仓库做好相关借条清消工作',getdate(),'','','','','卢龙','','','','','','','','手动发送','','')"
            Call base._setMsg(whxx)

        End If


        If Me.RadioButton7.Checked = True Then
            isYs = "S"
            isBilltype = "售后新件退还"
            isInfo = "售后新件退还[维修单号：" & pT3 & "]"

            Dim whxx As String
            whxx = "'" + pT2 + "','','" + Bus_CurrentUser_Fullname + "','[" & Bus_CurrentUser_Fullname & "]维修人员请求-售后新件退还-[维修单号：" & pT3 & "]，请仓库做好相关借条清消工作',getdate(),'','','','','卢龙','','','','','','','','手动发送','','')"
            Call base._setMsg(whxx)

        End If



    End Sub


    Private Sub 售后领料单分配器_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname
        Me.DatagridviewEx1.DataSource = base.Get单条物料(pT1, pT2, pT3)
        CheckBox1.Enabled = False
        CheckBox1.Checked = False

        ToolStripStatusLabel2.Text = pT3  '维修单号
        ToolStripStatusLabel4.Text = pT4  '第几次维修
        ToolStripStatusLabel7.Visible = False

        insTname = IIf(IsDBNull(Me.DatagridviewEx1.Rows(0).Cells("introducer").Value), Bus_CurrentUser_Fullname, Me.DatagridviewEx1.Rows(0).Cells("introducer").Value)
        Me.ToolStripStatusLabel6.Text = "单据用户：" & insTname


        Me.Label6.Text = pT5

        Me.RadioButton1.Enabled = False
        Me.RadioButton2.Enabled = False
        Me.RadioButton3.Enabled = False
        Me.RadioButton4.Enabled = False
        Me.RadioButton6.Visible = False '返厂报废，现在报废线路
        Me.RadioButton7.Enabled = False


        If pT1 = "售后服务领料" Then
            ' Me.RadioButton6.Enabled = False
            Me.RadioButton7.Enabled = True
            If pT5 = "保修" Then
                Me.RadioButton1.Enabled = True
                Me.RadioButton2.Enabled = True
                RadioButton2.Checked = True
                '  CheckBox1.Checked = True
                Me.Label6.ForeColor = Color.Blue
            End If

            If pT5 = "维修" Then
                Me.RadioButton3.Enabled = True
                Me.RadioButton4.Enabled = True
                RadioButton3.Checked = True
                '  CheckBox1.Checked = True
                Me.Label6.ForeColor = Color.Red
            End If
        End If


        ' If pT1 = "售后返厂维修" Then Me.RadioButton6.Enabled = True
        '自动读取第一条信息
        Call getDatalist(0)

        '应该多线程来校对 提取量！！！ 做数据的完整性！

    End Sub

 
    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Me.TextBox1.Text = "保修期内收费[维修单号：" & pT3 & "]"
    End Sub
    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Me.TextBox1.Text = "保修期内免费[维修单号：" & pT3 & "]"
    End Sub
    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        Me.TextBox1.Text = "保修期外收费[维修单号：" & pT3 & "]"
    End Sub
    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        Me.TextBox1.Text = "保修期外免费[维修单号：" & pT3 & "]"
    End Sub
 
    Private Sub RadioButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.Click
        Me.TextBox1.Text = "售后返厂报废[维修单号：" & pT3 & "]"
    End Sub
    Private Sub RadioButton7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton7.Click
        Me.TextBox1.Text = "售后新件退还[维修单号：" & pT3 & "]"
    End Sub

    Private Sub getDatalist(ByVal RowNum As Integer)
        isSNum = CType(IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("QUANTITY").Value), 0, Me.DatagridviewEx1.Rows(RowNum).Cells("QUANTITY").Value), Decimal)
        isPNum = CType(IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("freenum1").Value), 0, Me.DatagridviewEx1.Rows(RowNum).Cells("freenum1").Value), Decimal)

        Me.TextBox4.Text = IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("id").Value), 0, Me.DatagridviewEx1.Rows(RowNum).Cells("id").Value)
        If isPNum > isSNum Then
            MessageBox.Show("数据异常(提取量大于实际数据量),请与管理员联系，进行数据校准", "提醒")
            Exit Sub
        End If
        '读取数据校准 sum 
        If pT1 <> "售后返厂维修" Then
            Dim zGf1 As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("materialCODE").Value), "读取失败", Me.DatagridviewEx1.Rows(RowNum).Cells("materialCODE").Value)
            Dim zGf2 As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("materialname").Value), "读取失败", Me.DatagridviewEx1.Rows(RowNum).Cells("materialname").Value)
            Dim isLyid As Integer
            isLyid = CType(Trim(Me.TextBox4.Text), Integer)
            Dim cgem As Decimal
            cgem = base.getNum(pT2, pT3, zGf1, zGf2)
            base.updata提起量(isLyid, cgem)
        End If

        Me.Label1.Text = IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("materialCODE").Value), "读取失败", Me.DatagridviewEx1.Rows(RowNum).Cells("materialCODE").Value)
        Me.Label1.Text &= " - " & IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("materialNAME").Value), "读取失败", Me.DatagridviewEx1.Rows(RowNum).Cells("materialNAME").Value)
        Me.Label1.Text &= " - " & IIf(IsDBNull(Me.DatagridviewEx1.Rows(RowNum).Cells("SPECS").Value), "读取失败", Me.DatagridviewEx1.Rows(RowNum).Cells("SPECS").Value)
        Me.TextBox3.Text = Format(isSNum - isPNum, ".00")

    End Sub

    Private Sub DatagridviewEx1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatagridviewEx1.CellContentDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        isGetRindex = e.RowIndex
        Call getDatalist(isGetRindex)
    End Sub

 
   
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click

        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False And RadioButton6.Checked = False And RadioButton7.Checked = False Then
            MessageBox.Show("请判断单据状态！", "提醒")
            Exit Sub
        End If

        Dim Gf5 As Decimal = CType(Trim(Me.TextBox3.Text), Decimal)

 
        If Gf5 = 0 Then
            MessageBox.Show("当前数量为0 ", "提醒")
            Exit Sub

        End If
        If Trim(Gf5) = "" Then
            MessageBox.Show("请输入分解数据", "提醒")
            Exit Sub

        End If

        If Gf5 > (isSNum - isPNum) Then
            MessageBox.Show("不允许超量提取！", "提醒")
            Exit Sub
        End If




        Call seTmessage(True) '消息
        '直动生成领料单+入库单

        Dim oldCode As String = ""

        Dim 序号 As String = ""
        Dim getcode As String = ""
        Dim upTime As DateTime = BuildFrmTo获得服务器时间()
        Dim addStr As String = ""
        序号 = base.showCode("BILLnouse2", "YL")
        getcode = "YL" & BuildFrmTo获得服务器时间.ToString("yyyyMMdd") & Mid("0000", Len(序号.ToString) + 1) & 序号.ToString
        oldCode = getcode

        Dim Gf1 As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(isGetRindex).Cells("materialCODE").Value), "读取失败", Me.DatagridviewEx1.Rows(isGetRindex).Cells("materialCODE").Value)
        Dim Gf2 As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(isGetRindex).Cells("materialname").Value), "读取失败", Me.DatagridviewEx1.Rows(isGetRindex).Cells("materialname").Value)
        Dim Gf3 As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(isGetRindex).Cells("specs").Value), "读取失败", Me.DatagridviewEx1.Rows(isGetRindex).Cells("specs").Value)
        Dim Gf4 As String = IIf(IsDBNull(Me.DatagridviewEx1.Rows(isGetRindex).Cells("unitname").Value), "读取失败", Me.DatagridviewEx1.Rows(isGetRindex).Cells("unitname").Value)
        Dim Gf6 As String = "," & pT2 & "," & getcode


        If Me.CheckBox1.Checked Then Ptt = "客户借用"
        If Me.RadioButton4.Checked Then Ptc = ""


        Dim isLyid As Integer
        isLyid = CType(Trim(Me.TextBox4.Text), Integer)
        Dim upNum As Decimal = isPNum + Gf5




        'ADD 自动生成领料单
        addStr = "INSERT into BILLnouse2 (   "
        addStr &= " code, Client, BILLDATE,  finishdate, billtype,paytype,materialcode,materialname, specs,unitname,  "
        addStr &= "introducerDate, introducer,quantity,refercode,freestr7,auditing,"
        addStr &= "freestr8,freestr9,freestr10,discount,引用单号2,"
        addStr &= "boxes, origprice,price,amount,killbillqty,"
        addStr &= " referqty,payedamount,MaxValue,taxtype,batchnumber)"

        addStr &= "VALUES ('" & getcode & "','" & insTname & "','" & upTime.Date & "','" & upTime.Date & "', '" & isBilltype & "','" & pT3 & "','" & Gf1 & "','" & Gf2 & "','" & Gf3 & "','" & Gf4 & "',  "
        addStr &= " '" & upTime & "','" & Bus_CurrentUser_Fullname & "'," & Gf5 & ",'" & pT2 & "','" & Ptt & "','" & Ptc & "',"
        addStr &= "'" & pT3 & "','" & Trim(Me.TextBox1.Text) & "', '" & Gf6 & "','100.0000','" & pT2 & "',"
        addStr &= " '0.0000','0.0000','0.0000','0.0000','0.0000', "
        addStr &= " '-1.0000','0.0000',' ',' ',' ') "
        base.AddSave(addStr)
        If pT1 = "售后返厂维修" Then
            If isBilltype = "售后返厂报废" Then

                If Gf5 = (isSNum - isPNum) Then
                    '直接作废维修单
                    base.updata维修作废(isLyid)
                Else
                    '减少维修单数量，并已经自动生成报废单
                    Dim leNum As Decimal = isSNum - isPNum - Gf5
                    base.updata维修量(isLyid, leNum)
                End If
            End If
        Else


            'ADD 自动入库单
            '从领料单上减去
            '自动生单 就要注意 作废流程！！ 
            If isBilltype <> "售后新件退还" Then
                If isYs = "G" Then
                    '保修外免费，处理下数据
                    '发一个什么消息比较好点？？？



                Else

                    序号 = ""
                    getcode = ""
                    序号 = base.showCode("RukuKu", "LR")
                    getcode = "LR" & BuildFrmTo获得服务器时间.ToString("yyyyMMdd") & Mid("0000", Len(序号.ToString) + 1) & 序号.ToString
                    Dim Gf7 As String = "," & pT2 & "," & getcode
                    addStr = "INSERT into rukuku  (   "
                    addStr &= "code,refercode,batchnumber,materialcode,materialName,specs,introducerdate,billdate,introducer,billtype,unitname,quantity, client, discount,boxes,origprice, price,amount,killbillqty, payedamount,freestr8,freestr9,freestr10,storagename,paytype,freestr6,REFERQTY)  "
                    addStr &= " VALUES ('" & getcode & " ','" & pT2 & "','" & getcode & "','" & Gf1 & "', '" & Gf2 & "','" & Gf3 & "','" & upTime & "','" & upTime & "','" & Bus_CurrentUser_Fullname & "','售后领料归还','" & Gf4 & "', " & Gf5 & ",'" & insTname & "',100.0000,0.0000,0.000,0.0000,0.0000,0.0000,0.0000,'" & pT3 & "','" & Trim(Me.TextBox1.Text) & "','" & Gf7 & "','原材料库','" & pT3 & "','" & oldCode & "','-1.0000')"
                    base.AddSave(addStr)
                    'updata 自动写入提取量，无需从入库单中找数据，大量减少工作量！


                End If
            End If

                '暂时屏蔽下。
                If isBilltype = "售后保修免费" Then
                    '自动保修免费自动生成出库单
                    If isYs = "G" Then
                        '保修外免费，处理下数据
                        '发一个什么消息比较好点？？？




                    Else
                        '保修内免费自动处理  出库单
                        序号 = ""
                        getcode = ""
                        序号 = base.showCode("cukuku", "LC")
                        getcode = "LC" & BuildFrmTo获得服务器时间.ToString("yyyyMMdd") & Mid("0000", Len(序号.ToString) + 1) & 序号.ToString
                        Dim Gf7 As String = "," & pT2 & "," & oldCode & "," & getcode
                        addStr = "INSERT into cukuku  (   "
                        addStr &= "code,refercode,batchnumber,materialcode,materialName,specs,introducerdate,billdate,introducer,billtype,unitname,quantity, client, discount,boxes,origprice, price,amount,killbillqty, payedamount,freestr8,freestr9,freestr10,storagename,paytype,freestr6,freestr7,REFERQTY)  "
                        addStr &= " VALUES ('" & getcode & " ','" & pT2 & "','" & getcode & "','" & Gf1 & "', '" & Gf2 & "','" & Gf3 & "','" & upTime & "','" & upTime & "','" & Bus_CurrentUser_Fullname & "','售后保修免费','" & Gf4 & "', " & Gf5 & ",'" & insTname & "',100.0000,0.0000,0.000,0.0000,0.0000,0.0000,0.0000,'" & pT3 & "','" & Trim(Me.TextBox1.Text) & "','" & Gf7 & "','原材料库','" & pT3 & "','" & oldCode & "','" & Ptt & "','-1.0000')"
                        base.AddSave(addStr)

                    End If

                End If


                Dim isupNum As Decimal
                isupNum = CType(Gf5 + isPNum, Decimal)
                base.updata提起量(isLyid, isupNum)
            End If
        '重刷界面
        '重新获取数据源，因为改变了提取量
        Me.DatagridviewEx1.DataSource = base.Get单条物料(pT1, pT2, pT3)
        getDatalist(isGetRindex)
        MessageBox.Show("已通知相关部门！", "提醒")

    End Sub


 
    
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ToolStripLabel1_Click(sender, e)
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Close()

    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            CheckBox1.Checked = False
            CheckBox1.Enabled = False
        Else
            CheckBox1.Checked = True
            CheckBox1.Enabled = True
        End If
        isTrues(RadioButton7, 2)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then ToolStripStatusLabel7.Visible = True Else ToolStripStatusLabel7.Visible = False
    End Sub

    Private Sub isTrues(ByVal rs As RadioButton, ByVal sNumm As Integer)
        If rs.Checked Then
            If sNumm = 1 Then
                CheckBox1.Enabled = True
                CheckBox1.Checked = True
            Else
                CheckBox1.Enabled = False
                CheckBox1.Checked = False
            End If

        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        isTrues(RadioButton4, 1)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        isTrues(RadioButton2, 1)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        isTrues(RadioButton1, 2)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        isTrues(RadioButton3, 2)
    End Sub
End Class