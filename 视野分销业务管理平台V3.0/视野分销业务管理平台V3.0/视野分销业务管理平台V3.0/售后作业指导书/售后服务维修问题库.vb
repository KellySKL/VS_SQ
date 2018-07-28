Public Class 售后服务维修问题库
    Dim wxCode As String '维修单号
    Dim JcCode As String '机床编码
    Dim ddBan As String
    Dim ddNum As Integer '维修次数
    Dim ddName As String '公司名称
    Dim Biman As String '维修人员
    Dim flag As Boolean = False
    Dim getDt As New DataTable '维修信息
    Dim getList As New DataTable '步骤列表

    Dim base As New 售后服务维修问题库base
    Dim mLeft As Integer = 10 '定义控件的位置
    Dim allBNum As Integer = 1 '记录加载了多少个控件，便于删除
    Dim FaID As Integer = 0  '记录父ID 
    Dim isIntoNum As Single = 0  '记忆返回值
    Dim isKfn As Integer = 0
    Dim meLbTop As Integer = 35
    Dim openNum As Integer = 0
    Dim isFistReadNum As Boolean = False
    Dim wxid As Integer

    '---------------------
    '第一版：一问一答，单线路模式
    '第二版：以问题为核心，选择问题 ，多线路模式
    '第三版：固化流程格式
    '---------------------
    Public Sub openMe(ByVal mcode As String, Optional ByVal wxids As Integer = -1)
        ddBan = "售后作业指导书"
        wxid = wxids

        If Microsoft.VisualBasic.Left(Trim(mcode), 2) = "SH" Then
            wxCode = mcode
            base.isKf = 0
            isKfn = 0
            getDt = base.GetwxInfo(wxCode)
            JcCode = IIf(IsDBNull(getDt.Rows(0)("zf1")), "", getDt.Rows(0)("zf1"))
            'If Microsoft.VisualBasic.Left(JcCode, 2) <> "DD" Then JcCode = "DD" & JcCode
            ddNum = IIf(IsDBNull(getDt.Rows(0)("sz8")) Or getDt.Rows(0)("sz8") = 0.0, 1, getDt.Rows(0)("sz8"))
            ddName = IIf(IsDBNull(getDt.Rows(0)("client")), "", getDt.Rows(0)("client"))
            Biman = IIf(IsDBNull(getDt.Rows(0)("billman")), Bus_CurrentUser_Fullname, getDt.Rows(0)("billman"))
            getList = base.getlistinfo(JcCode)
            If getList.Rows.Count > 0 Then base.upListCode(wxCode, JcCode)
        Else
            wxCode = mcode
            JcCode = mcode
            ddNum = 1
            Biman = "客户问答" '维修人员
            base.isKf = 1 '读取特殊版本，比如客户问答
            isKfn = 1
        End If
        '通过JCCODE 机床编号 智能读取版本号
        ddBan = base.getBbName(JcCode)
        If ddBan = "" Then
            MessageBox.Show("无法读取版本号，系统将默认一个通用版本", Me.Text)
            ddBan = "售后作业指导书"
        End If
        Me.Show()
        If Me.DialogResult = DialogResult.OK Then
            MsgBox("ok")
        End If

    End Sub

    Private Sub readAlldata(ByVal pNum As Integer)
        Dim Sb As New DataTable
        If pNum = -1 Then
            Sb = base.getlistinfo(wxCode) '步骤
            moLIst(Sb)
            Sb = base.getlistinfo(wxCode, 1) '方案
            moLIst(Sb, 1)
            Sb = base.getlistinfo(wxCode, 2) '方案
            moLIst(Sb, 2)
            Sb = base.getlistinfo(wxCode, 3) '方案
            moLIst(Sb, 3)
        Else
            Sb = base.getlistinfo(wxCode, pNum)
            moLIst(Sb, pNum)
        End If
        Sb = Nothing
    End Sub

    Class nn
        Public nTttle As String '内容
        Public fid As String '上级ID 
        Public uid As String '自己ID 
    End Class

    Private Function GetParents(ByVal node As TreeNode) As String()
        Dim list As New List(Of String)
        Do Until node.Parent Is Nothing
            node = node.Parent
            list.Add(node.Text)
        Loop
        Return list.ToArray()
    End Function
    Private Sub addtoTree(ByVal nd As nn, ByVal nodes As TreeNodeCollection)
        Dim dd As TreeNode
        Dim tmpd As TreeNode
        If nd.fid = "0" Then
            tmpd = nodes.Add(nd.nTttle)
            tmpd.ToolTipText = nd.uid
            tmpd.Tag = nd.uid
            Exit Sub
        Else
            For Each dd In nodes
                If nd.fid = dd.ToolTipText Then
                    tmpd = dd.Nodes.Add(nd.nTttle)
                    tmpd.ToolTipText = nd.uid
                    tmpd.Tag = nd.uid
                    Exit Sub
                End If
                addtoTree(nd, dd.Nodes)
                dd.ExpandAll() '展开树结构
            Next
        End If
    End Sub

    Private Sub readtoTree()
        Dim IsNum As Integer = 0
        Dim cDt As New DataTable
        cDt = base._rz_getList(0)
        IsNum = cDt.Rows.Count
        If IsNum > 0 Then
            Me.TreeView1.Nodes.Clear()
            Dim nd(IsNum) As nn
            For i As Integer = 0 To IsNum - 1
                nd(i) = New nn
                nd(i).nTttle = cDt.Rows(i)("mtitle").ToString : nd(i).fid = cDt.Rows(i)("fid") : nd(i).uid = cDt.Rows(i)("id")
                addtoTree(nd(i), TreeView1.Nodes)

            Next
        End If
    End Sub
    Private Sub showDtlist(ByVal dtHeigt As Integer, ByVal objDGV As DataTable)
        With Me.DataGridView2
            .Height = dtHeigt
            If dtHeigt <> 0 Then
                ' .Rows.Clear()
                ' .Columns.Clear()
                .DataSource = Nothing
                .DataSource = objDGV
                .Columns("id").Visible = False
                .Columns("fid").Visible = False
                .Columns("istype").Visible = False
                .Columns("nid").Visible = False
                .Columns("iskf").Visible = False
                .Columns("ftitle").HeaderText = "类型"
                .Columns("mtitle").HeaderText = "内容"
                .Columns("ftitle").Width = 100
                .Columns("mtitle").Width = Me.Label3.Width - 100
            End If
        End With
    End Sub
    Private Sub 售后服务维修问题库_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = "维修单号:" & wxCode & "(" & ddNum & ")"
        CheckBox1.Visible = False

        Me.Width = 974
        Me.CheckBox2.Checked = False
        Me.Label1.Text = ddName
        Me.Panel1.Height = 50
        Me.TreeView1.Visible = False
        Me.Panel5.Visible = False
        Me.Label3.Text = ""
        Me.DataGridView2.Height = 0
        base.isddBan = ddBan
        getList = base.getlistinfo(wxCode)
        Call moLIst(getList)
        If getList.Rows.Count > 0 Then
            '自动补单
            Call ShowWt(getList.Rows(0)("BN"), getList.Rows(0)("问题"), 0) '自动补单
            '补 现象   补 检查项
           
        End If
     

        If isKfn = 1 Then
            '隐藏下...
            Me.TabControl1.TabPages.Remove(TabPage3)
            Me.TabControl1.TabPages.Remove(TabPage4)

        End If
        isFistReadNum = True

    End Sub
    Private Sub 售后服务维修问题库_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If flag = True Then
            If MessageBox.Show("事务未完成是否要强关窗口？", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            Else
                '  If FaID <> 0 Then ' Call Adddatlist("维修员[" & Bus_CurrentUser_Fullname & "] 强制关闭")
                Me.DialogResult = DialogResult.OK

            End If
        End If

    End Sub
    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Me.Panel1.Height = 50
        Me.Panel5.Visible = False

        Me.CheckBox1.Visible = True
    End Sub
    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Try
            '改了读取逻辑，好麻烦。哎，吐血中....
            'If TreeView1.SelectedNode.Parent Is Nothing Then Exit Sub
            Dim isNoNUm As Integer = CType(e.Node.Tag, Integer)
            ' Dim sTsx As String = e.Node.Parent.Text & "->" & e.Node.Text
            Dim sTsx As String = e.Node.Text
            Label4.Text = e.Node.Text
            Call ShowWt(isNoNUm, sTsx)
            Panel1_Click(sender, e)
        Catch ex As Exception
        End Try
    
    End Sub
    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        If e.RowIndex <= -1 Then Exit Sub
        If Me.DataGridView2.RowCount >= 0 Then
            '   Call Adddatlist(DataGridView2.Rows(e.RowIndex).Cells("mtitle").Value)
            Me.Label8.Text = DataGridView2.Rows(e.RowIndex).Cells("mtitle").Value
            Call ShowWt(CType(DataGridView2.Rows(e.RowIndex).Cells("id").Value, Integer), DataGridView2.Rows(e.RowIndex).Cells("mtitle").Value)
        End If
    End Sub

   




    Private Sub ShowWt(ByVal isTag As Integer, ByVal isTxt As String, Optional ByVal isTt As Integer = -1)


        mLeft = 12
        FaID = isTag
        Dim isTiaoz As Boolean = False
        Dim isPanDu As Boolean = False
        Dim isQuzhi As Boolean = False
        Dim isTid As Integer = 0
        Dim isTstr As String = ""
        Call killBut()
        If isTxt <> "_no_" Then Me.Label3.Text = isTxt
        If isTt = 0 Then Me.Label8.Text = base._rz_getFname(isTag) '跳的时候反向查询。。。需检查项
        Dim mm As New DataTable
        Dim MDt As New DataTable
        Dim CDt As New DataTable
        '先处理问题点

        mm = base._rz_getList(isTag)
        MDt = mm.Copy
        '无后续，直接关闭内容
        If MDt.Rows.Count <= 0 Then
            If isKfn = 1 Then
                Me.Label3.Text = "感谢客户的积极配合，到目前我们已经采集到了宝贵的客户问题！"
                mLeft = setBtn("客户问答结束", mLeft, FaID)
            Else
                Me.Label3.Text = "若我们的问题设计未能解决客户问题， " & vbCrLf & "我们非常抱歉！ " & vbCrLf & "请协助我们将目前的问题编辑入库 "
                mLeft = setBtn("维修问题结束", mLeft, FaID)
            End If
            ShowBtnlist(isTag, 1)
            Exit Sub
        End If



        Dim dv As DataView = MDt.DefaultView
        dv.RowFilter = "istype=0"
        MDt = dv.ToTable
        Call showDtlist(0, MDt) '初始化文件列表
        If MDt.Rows.Count > 0 Then
            '  If MDt.Rows(0)("ftitle") = "需检查项" Then Me.Label8.Text = MDt.Rows(0)("mtitle")
            '只有在跳的时候改变了线路。
            If isTxt = "_no_" Then Me.Label3.Text = MDt.Rows(0)("mtitle").ToString
            If MDt.Rows.Count = 1 Then
                Call ShowWt(CType(MDt.Rows(0)("id"), Integer), MDt.Rows(0)("mtitle").ToString)
                '固定读取下一级 56 
                ShowBtnlist(CType(MDt.Rows(0)("id"), Integer), 1)
            Else
                Me.Label3.Text = "请选择下列问题清单___?"
                Call showDtlist(380, MDt)
            End If
        End If
        '处理问题外
        CDt = mm.Copy
        Dim dc As DataView = CDt.DefaultView
        dc.RowFilter = "istype in (1,2,4,9)"
        MDt = dc.ToTable
        If MDt.Rows.Count > 0 Then
            For i As Integer = 0 To MDt.Rows.Count - 1
                '----------------------------------------------------
                '----------------------------------------------------
                If MDt.Rows(i)("istype") = 1 Then '判断
                    isPanDu = True
                    isTid = MDt.Rows(i)("id")
                    isTstr = Trim(MDt.Rows(i)("mtitle").ToString)
                    mLeft = setBtn(isTstr, mLeft, isTid)
                    '固定读取下一级 56783 --维修类型
                    ShowBtnlist(isTid, 1)

                End If
                If MDt.Rows(i)("istype") = 2 Then '取值
                    Me.Label3.Text = MDt.Rows(i)("mtitle")
                    isTid = MDt.Rows(i)("id")
                    isQuzhi = True
                    mLeft = setBtn("保存数值", mLeft, isTid)
                    '固定读取下一级 56 
                    ShowBtnlist(isTid, 1)
                End If
                If MDt.Rows(i)("istype") = 4 Then '跳转
                    isTiaoz = True
                    isTid = CType(MDt.Rows(i)("nid"), Integer)
                    Dim ismId As Integer = CType(MDt.Rows(i)("id"), Integer)
                    isTstr = MDt.Rows(i)("mtitle").ToString()

                    '固定读取下一级 56783 --维修类型
                    ShowBtnlist(ismId, 1)
                End If
                If MDt.Rows(i)("istype") = 9 Then
                    Me.Label3.Text = "问答结束"
                    mLeft = setBtn("问答结束", mLeft, FaID)
                    isTid = MDt.Rows(i)("id")
                    '插入读取方案及附件
                    ShowBtnlist(isTid, 1)
                    ReadFF(CType(MDt.Rows(i)("id"), Integer))

                End If
            Next

            If isTiaoz = True Then Call ShowWt(isTid, isTstr, 0)
        End If
    End Sub

    Private Sub ReadFF(ByVal isTid As Integer)
        Dim ndt As DataTable = base._rz_getList(isTid, 4)
        Me.Label3.Text = Me.Label3.Text & vbCrLf & vbCrLf & "----------------------" & vbCrLf & vbCrLf & "[解决方案]" & vbCrLf & vbCrLf & ndt.Rows(0)("mtitle").ToString
    End Sub



    '动态添加按钮方案将取消
    '---------------------------------------------------------------
    Private Sub ShowBtnlist(ByVal isTid As Integer, ByVal islistNum As Integer)
        Dim ndt As DataTable = base._rz_getList(isTid, islistNum)
        '获取 56783 
        If ndt.Rows.Count <= 0 Then Exit Sub
        For i As Integer = 0 To ndt.Rows.Count - 1
            '找到数据并添加数据值
            ' Dim imgId As Integer = -1
            ' If ndt.Rows(i)("istype") = 6 Then imgId = ndt.Rows(i)("id")
            Adddatlist(Trim(ndt.Rows(i)("mtitle").ToString), 1, ndt.Rows(i)("ftitle").ToString)
        Next

        ' Dim lc As LinkLabel = labShow(isTid)
        ' AddHandler lc.Click, AddressOf lc_Click
    End Sub
    Private Function labShow(ByVal isFid As Integer)
        Dim lb As New LinkLabel
        lb.Name = "makelanlan" & isFid
        lb.AutoSize = True
        lb.Text = Me.Label8.Text & "[" & isFid & "]"
        lb.Top = meLbTop
        meLbTop += 22
        lb.Cursor = Cursors.Hand
        lb.Tag = isFid
        Me.Panel7.Controls.Add(lb)
        Return lb
    End Function
    Private Sub lc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bb As New msgboxmm(sender.tag, wxCode, Biman)
    End Sub
    '---------------------------------------------------------------


    Private Sub Adddatlist(ByVal Numa As String, Optional ByVal isshow As Integer = 0, Optional ByVal byMM As String = "no", Optional ByVal isRr As Integer = 0)
        If isFistReadNum = False Then Exit Sub '第一次读取时候。屏蔽保存数据
        Application.DoEvents()
        Dim isRed As Integer = 0
        With Me.DataGridView1
            Dim dtt As DataTable = CType(.DataSource, DataTable)
            Dim dtv As DataView = dtt.DefaultView
            dtv.RowFilter = " BN=" & FaID & "   "
            If dtv.Count > 0 Then isRed = 1
            Dim upstr As String = ""
            Dim mtt As String = ""


            If isRr <> 0 Then isRed = isRr
            '写入库  郑总要求，边做边保存... 还是比较合理的
            Dim cyMM As String = ""

            If byMM = "no" Then
                cyMM = ""
                byMM = ""
                mtt = Trim(Me.Label3.Text)
            Else
                cyMM = ",ltitle "
                byMM = ",'" & byMM & "'"
                mtt = Trim(Me.Label8.Text)
            End If
            upstr = "INSERT into m_zyRecode  (   "
            upstr &= " fid,rtitle,mtitle,uname ,wcode,jcode,nNum,nstep,ndate,isred,isshow,del " & cyMM & ")  "
            upstr &= " VALUES (" & FaID & ",'" & Numa & "' ,'" & mtt & "','" & Bus_CurrentUser_Fullname & "','" & wxCode & "','" & JcCode & "'," & ddNum & ",(SELECT COUNT(id)+1 from m_zyRecode  where WCODe='" & wxCode & "'),'" & BuildFrmTo获得服务器时间() & "','" & isRed & "','" & isshow & "',0 " & byMM & ")"
            base.AddSave(upstr)
            flag = True
            '返读数据库
            readAlldata(openNum)

            'If Me.CheckBox1.Checked = False Then
            '    Dim nData As DataTable = base.getlistinfo(wxCode)
            '    moLIst(nData)
            'Else
            '    Dim cdr As DataRow = dtt.NewRow()
            '    cdr("序号") = 0
            '    cdr("维修员") = Bus_CurrentUser_Fullname
            '    cdr("类型") = Trim(Me.Label3.Text)
            '    cdr("问题") = Trim(Me.Label3.Text)
            '    cdr("结果") = Numa
            '    cdr("BN") = FaID
            '    '  cdr("isRed") = isRed
            '    dtt.Rows.Add(cdr)
            '    .Rows(.RowCount - 1).DefaultCellStyle.BackColor = Color.LightPink
            'End If
        End With

    End Sub
    Private Sub killBut()
        For i As Integer = 0 To allBNum
            For Each kj As Control In Me.Panel3.Controls
                Me.Panel3.Controls.Remove(kj)
            Next
        Next
        allBNum = 0


        'For Each tt As Control In Me.Panel7.Controls
        '    If (TypeOf tt Is LinkLabel) Then Me.Panel7.Controls.Remove(tt)
        '    MsgBox(tt.Text)
        'Next


    End Sub

    Private Function setBtn(ByVal btName As String, ByVal mLe As Integer, ByVal cTag As Integer)
        '生成按钮
        allBNum += 1

        Application.DoEvents()
        Dim bWidth As Integer = 0
        If btName = "保存数值" Then
            Dim bTxt As New Windows.Forms.TextBox
            bTxt.Width = 100
            bTxt.Multiline = True
            bTxt.Font = New Font("宋体", 16)
            bTxt.TextAlign = HorizontalAlignment.Center
            bTxt.BorderStyle = BorderStyle.FixedSingle
            bTxt.Location = New Drawing.Point(mLe + 2, 5)
            bTxt.Size = New Drawing.Size(bTxt.Width, 30)
            bWidth += mLe + bTxt.Width + 10
            Me.Panel3.Controls.Add(bTxt)
            mLe = bWidth
        End If

        Dim bxt As New Windows.Forms.Button
        '尺子 量宽度
        Dim label As New Windows.Forms.Label
        label.Text = btName
        label.AutoSize = True
        Me.Panel3.Controls.Add(label)
        bxt.Width = label.Width
        Me.Panel3.Controls.Remove(label)
        '---------------------------
        bxt.Text = btName
        bxt.AutoSize = False
        bxt.Location = New Drawing.Point(mLe, 5)
        bxt.Size = New Drawing.Size(bxt.Width + 20, 30)
        bxt.BackColor = Color.White
        bWidth += mLe + bxt.Width + 20
        bxt.Tag = cTag
        Me.Panel3.Controls.Add(bxt)
        AddHandler bxt.Click, AddressOf Btn_Click
        Return bWidth
    End Function

    Private Function EvrNum(ByVal Tag As Integer, ByVal evr As Single) As Integer
        Dim Num As Integer
        Dim qZdt As New DataTable
        qZdt = base._rz_getList(Tag)
        Dim lsPan As New DataView
        lsPan = qZdt.DefaultView
        lsPan.RowFilter = "istype=1"
        qZdt = lsPan.ToTable



        For i As Integer = 0 To qZdt.Rows.Count - 1
            Dim jsGs As String = qZdt.Rows(i)("mtitle").ToString
            '计算不等式
            '通过计算公式改写ID的赋值



            If jsGs.IndexOf("@") = -1 Then
                Num = qZdt.Rows(i)("id")
            Else
                Dim tempGs() As String = jsGs.Split("@")
                If Trim(tempGs(1)) <> "" And Trim(tempGs(0)) <> "" Then
                    Dim xx As String = Trim(tempGs(0)) & evr
                    Dim mm As String = evr & Trim(tempGs(1))
                    If New System.Data.DataTable().Compute(xx, "") = True And New System.Data.DataTable().Compute(mm, "") = True Then
                        Num = qZdt.Rows(i)("id")
                        Exit For
                    End If
                Else
                    jsGs = jsGs.Replace("@", evr)
                    If New System.Data.DataTable().Compute(jsGs, "") = True Then
                        Num = qZdt.Rows(i)("id")
                        Exit For
                    End If

                End If
            End If





        Next
        Return Num
    End Function

    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tt As Windows.Forms.Button = CType(sender, Windows.Forms.Button)
        If tt.Text = "保存数值" Then
            For Each kj As Control In Me.Panel3.Controls
                '多个TXT文本取值问题？应该不会存在。。。
                If kj.GetType.Name = "TextBox" Then
                    If IsNumeric(kj.Text) = False Then Exit Sub
                    If Trim(kj.Text) = "" Then Exit Sub
                    isIntoNum = CType(kj.Text, Single)
                    '做一个提醒，以防数字输入错误。
                    '   If MessageBox.Show("您输入的值是：" & isIntoNum, Me.Text, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    '插入运算
                    Dim isBack As Integer = EvrNum(tt.Tag, isIntoNum)
                    Call Adddatlist(isIntoNum)
                    Call ShowWt(isBack, "_no_")
                    Exit Sub
                    'Else
                    '    Exit Sub
                    '    End If
                End If
            Next
            Exit Sub
        End If

        If tt.Text = "客户问答结束" Or tt.Text = "维修问题结束" Or tt.Text = "问答结束" Then
            Call Adddatlist("维修员[" & Bus_CurrentUser_Fullname & "]- 问答结束", , , 2)
            flag = False
            Me.Close()
            Exit Sub
        End If
        '  If tt.Text <> "下一步" Then '补的 下一步 不做记录
        Call Adddatlist(sender.Text)
        ' End If
        Call ShowWt(CType(sender.Tag, Integer), "_no_")
        ' Me.Text.Contains()
        '刷新所有列表
    End Sub
      Private Sub Label4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.DoubleClick
        Label3_DoubleClick(sender, e)
    End Sub
    Private Sub Label3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.DoubleClick

        Me.CheckBox1.Visible = False
        Me.Panel5.Visible = True
        Me.Panel1.Height = Me.Height - Panel3.Height
        Me.TreeView1.Visible = True
        Me.Panel5.Controls.Add(Me.TreeView1)
        Me.TreeView1.Dock = DockStyle.Fill
        Me.Panel5.Height = Me.Panel1.Height - 100
        Call readtoTree()
    End Sub

 

    Private Sub moLIst(ByVal shData As DataTable, Optional ByVal Pnums As Integer = 0)
        Dim myobj As New DataGridView
        If Pnums = 0 Then myobj = Me.DataGridView1
        If Pnums = 1 Then myobj = Me.DataGridView3
        If Pnums = 2 Then myobj = Me.DataGridView4
        If Pnums = 3 Then myobj = Me.DataGridView5


        With myobj
            Dim sbDt As New DataTable
            sbDt = shData
            .DataSource = Nothing
            .DataSource = sbDt
            .ColumnHeadersHeight = 20
            .Columns(0).Visible = False
            .Columns(1).Width = 50
            .Columns(2).Width = 80
            If Pnums = 0 Then
                .Columns(2).Visible = False
                .Columns(3).Width = 200
                .Columns(4).Width = 260
            Else
                .Columns(3).Visible = False
                .Columns(4).Width = 400
            End If


            .Columns(5).Visible = False
            .Columns(6).Visible = False
            For i As Integer = 0 To sbDt.Rows.Count - 1
                If sbDt.Rows(i)("isred") = 1 Then .Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen
                If sbDt.Rows(i)("isred") = 2 Then
                    .Rows(i).DefaultCellStyle.BackColor = Color.Red
                    .Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If


            Next
        End With
    End Sub
 


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex <= -1 Then Exit Sub
        '  Call Adddatlist(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        Call ShowWt(CType(DataGridView1.Rows(e.RowIndex).Cells("bn").Value, Integer), DataGridView1.Rows(e.RowIndex).Cells("问题").Value)

    End Sub

    Private Sub btn_终止_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Call Adddatlist("维修员[" & Bus_CurrentUser_Fullname & "] 完成维修")

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Panel1_Click(sender, e)
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "动态列表"
        Else
            CheckBox1.Text = "锁定列表"
            Dim nData As DataTable = base.getlistinfo(wxCode)
            moLIst(nData)
        End If
    End Sub
 
    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        'If Me.CheckBox2.Checked = True Then
        '    CheckBox1.Visible = True
        '    Panel2.Visible = True
        '    Me.Width = 949
        'Else
        '    CheckBox1.Visible = False
        '    Panel2.Visible = False
        '    Me.Width = 517

        'End If
    End Sub
 
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        flag = False
        Me.Close()
    End Sub

 

    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        openNum = e.TabPageIndex
        readAlldata(openNum)

    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        '  Dim bb As New msgboxmm(CType(Me.DataGridView4.SelectedRows(0).Cells("id").Value, Integer), wxCode, Biman)
        Dim t As New 售后服务维修物料库
        t.wxCode = wxCode
        t.getId = CType(Me.DataGridView4.SelectedRows(0).Cells("id").Value, Integer) '单线查询，返读数据库，抽取数据内容
        t.wxid = wxid
        t.cname = Biman
        t.ShowDialog()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        If DataGridView4.Rows.Count <= 0 Then Exit Sub
        Dim wLists As String = ""
        For i As Integer = 0 To Me.DataGridView4.Rows.Count - 1
            wLists += Me.DataGridView4.Rows(i).Cells("物料").Value.Trim & "|"
        Next
        wLists = Microsoft.VisualBasic.Left(wLists, Len(wLists) - 1)


        Dim app As New 售后服务维修物料库
        app.wxCode = wxCode
        app.wxID = wxid
        app.cname = Biman
        app.wLIst = wLists '并线查询，读取所有数据库
        app.ShowDialog()
    End Sub
End Class



