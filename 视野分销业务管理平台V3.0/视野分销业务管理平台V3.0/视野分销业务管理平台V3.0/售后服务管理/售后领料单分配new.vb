Public Class 售后领料单分配new
    Private base As New 售后服务单作业完成时描述Base
    Public pT1 As String
    Public pT2 As String
    Public pT3 As String
    Public pT4 As Integer
    Public pT5 As String
    Public KF As String
    Private Ac As Action
    Private insTname As String


    '--------------------------------
    Public id As Integer
    Private CC As New DataTable
    Private isAllNum As Decimal = 0

    Public Sub New(ByVal _Ac As Action)
        Ac = _Ac
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub
    '--------------------------------
    Private Sub BaData()

        CC = base.Get单条物料byID(id.ToString())
        ' materialCODE , materialNAME, SPECS, UNITNAME, QUANTITY 
        Label1.Text = "新件处理：" & vbCrLf & "物料:" & CC.Rows(0)("materialCODE") & " " & CC.Rows(0)("materialNAME") & " " & CC.Rows(0)("SPECS") & " " & CC.Rows(0)("QUANTITY") & "(" & CC.Rows(0)("UNITNAME") & ")"
        isAllNum = CType(CC.Rows(0)("QUANTITY"), Decimal)
        ToolStripStatusLabel2.Text = pT3  '维修单号
        ToolStripStatusLabel4.Text = pT4  '第几次维修

        insTname = IIf(IsDBNull(CC.Rows(0)("introducer")), Bus_CurrentUser_Fullname, CC.Rows(0)("introducer"))
        Me.ToolStripStatusLabel6.Text = "单据用户：" & insTname
    End Sub
    ''' <summary>
    ''' 添加列
    ''' </summary>
    ''' <param name="d">datatable</param>
    ''' <param name="l">列表</param>
    Private Sub Add(d As DataTable, l As List(Of String))
        Dim dr As DataRow = d.NewRow()
        For i = 0 To l.Count - 1
            d.Columns.Add(l(i), GetType(Integer))
            dr(l(i)) = 0
        Next
        d.Rows.Add(dr)
    End Sub

    Private Sub ReadNewData()
        Me.DatagridviewEx1.DataSource = Nothing
        Dim Dtlist As New DataTable
        '动态添加列
        Dim p As New List(Of String) From {
            "新件销售",
            "新件维修",
            "客户借用",
            "领料退回"
        }
        Add(Dtlist, p)
        Me.DatagridviewEx1.DataSource = Dtlist
        DatagridviewEx1.Rows(0).Cells("新件销售").Style.BackColor = Color.Aqua
        DatagridviewEx1.Rows(0).Cells("新件维修").Style.BackColor = Color.Aqua
        DatagridviewEx1.Rows(0).Cells("客户借用").Style.BackColor = Color.Aqua
        DatagridviewEx1.Rows(0).Cells("领料退回").ReadOnly = True
    End Sub

    Private Sub ReadOldData()
        Me.DatagridviewEx2.DataSource = Nothing
        Dim Dtlist As New DataTable
        '动态添加列
        Dim p As New List(Of String) From {
            "旧件维修"
        }
        Add(Dtlist, p)
        Me.DatagridviewEx2.DataSource = Dtlist
    End Sub


    Private Sub 售后领料单分配new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DatagridviewEx1.当前用户名 = Bus_CurrentUser_Fullname
        '刷新数据
        ReadNewData()
        ReadOldData()
        BaData()
    End Sub

    Private Sub DatagridviewEx1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridviewEx1.CellEndEdit
        Dim IsXJXS As Decimal = DatagridviewEx1.Rows(0).Cells("新件销售").Value
        Dim IsXJBF As Decimal = DatagridviewEx1.Rows(0).Cells("新件维修").Value
        Dim IsKFJY As Decimal = DatagridviewEx1.Rows(0).Cells("客户借用").Value
        Dim IsLLTH As Decimal = 0
        IsLLTH = isAllNum - IsXJXS - IsXJBF - IsKFJY
        DatagridviewEx1.Rows(0).Cells("领料退回").Value = IsLLTH
        If IsLLTH < 0 Then
            MessageBox.Show("当前[领料退回]不能为负数")
            Return
        End If

    End Sub

    Private Sub DatagridviewEx2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridviewEx2.CellEndEdit
        Dim IsOLWX As Decimal = DatagridviewEx2.Rows(0).Cells("旧件维修").Value
        Dim IsKFJY As Decimal = DatagridviewEx1.Rows(0).Cells("客户借用").Value
        If IsOLWX < IsKFJY Then
            MessageBox.Show("当前[旧件维修]不能小于[客户借用]")
            Return
        End If

    End Sub







    Private Sub AddDD(_isBilltypes As String, _upNums As Integer, Optional _istype As String = "", Optional _isAutiong As String = "系统自动审核", Optional _Fwnum As Integer = 0)
        'ADD 自动生成单据
        Dim isBilltypes As String = _isBilltypes  '单据类型
        Dim upNums As Decimal = _upNums '处理的数量
        Dim Istypem As String = _istype '是否借用，或是新件维修
        Dim IsAUtiong As String = _isAutiong '自动审核
        Dim Fwnum As String = _Fwnum

        '生成code 
        Dim 序号 As String = ""
        Dim getcode As String = ""
        Dim upTime As DateTime = BuildFrmTo获得服务器时间()
        Dim addStr As String = ""
        序号 = base.showCode("BILLnouse2", "YL")
        getcode = "YL" & BuildFrmTo获得服务器时间.ToString("yyyyMMdd") & Mid("0000", Len(序号.ToString) + 1) & 序号.ToString

        '生成物料信息
        Dim Gf1 As String = CC.Rows(0)("materialCODE")
        Dim Gf2 As String = CC.Rows(0)("materialname")
        Dim Gf3 As String = IIf(IsDBNull(CC.Rows(0)("specs")), "读取失败", CC.Rows(0)("specs"))
        Dim Gf4 As String = IIf(IsDBNull(CC.Rows(0)("UNITNAME")), "读取失败", CC.Rows(0)("UNITNAME"))
        Dim Gf6 As String = "," & pT2 & "," & getcode


        addStr = "INSERT into BILLnouse2 (   "
        addStr &= " code, Client, BILLDATE,  finishdate, billtype,
                        paytype,materialcode,materialname, specs,unitname,  "
        addStr &= "introducerDate, introducer,quantity,refercode,freestr7,auditing,"
        addStr &= "freestr8,freestr9,freestr10,discount,引用单号2,"
        addStr &= "boxes, origprice,price,amount,killbillqty,"
        addStr &= " referqty,payedamount,MaxValue,taxtype,batchnumber)"

        addStr &= "VALUES ('" & getcode & "','" & KF & "','" & upTime.Date & "','" & upTime.Date & "', '" & isBilltypes
        addStr &= "','" & pT3 & "','" & Gf1 & "','" & Gf2 & "','" & Gf3 & "','" & Gf4 & "',  "
        addStr &= " '" & upTime & "','" & Bus_CurrentUser_Fullname & "'," & upNums & ",'" & pT2 & "','" & _istype & "','" & IsAUtiong & "',"
        addStr &= "'" & pT3 & "',' ', '" & Gf6 & "','100.0000','" & pT2 & "',"
        addStr &= " '0.0000','0.0000','0.0000','0.0000','0.0000', "
        addStr &= " '-1.0000','0.0000',' ',' ',' ') "
        base.AddSave(addStr)

        If Fwnum > 0 Then

            upNums = 1
            Gf1 = "99.001"
            Gf2 = "维修费"
            Gf3 = ""
            Gf4 = "次"



            addStr = "INSERT into BILLnouse2 (   "
            addStr &= " code, Client, BILLDATE,  finishdate, billtype,
                        paytype,materialcode,materialname, specs,unitname,  "
            addStr &= "introducerDate, introducer,quantity,refercode,freestr7,auditing,"
            addStr &= "freestr8,freestr9,freestr10,discount,引用单号2,"
            addStr &= "boxes, origprice,price,amount,killbillqty,"
            addStr &= " referqty,payedamount,MaxValue,taxtype,batchnumber)"

            addStr &= "VALUES ('" & getcode & "','" & KF & "','" & upTime.Date & "','" & upTime.Date & "', '" & isBilltypes
            addStr &= "','" & pT3 & "','" & Gf1 & "','" & Gf2 & "','" & Gf3 & "','" & Gf4 & "',  "
            addStr &= " '" & upTime & "','" & Bus_CurrentUser_Fullname & "'," & upNums & ",'" & pT2 & "','" & _istype & "','" & IsAUtiong & "',"
            addStr &= "'" & pT3 & "',' ', '" & Gf6 & "','100.0000','" & pT2 & "',"
            addStr &= " '0.0000','0.0000','" + Fwnum + "','0.0000','0.0000', "
            addStr &= " '-1.0000','0.0000',' ',' ',' ') "
            base.AddSave(addStr)
        End If


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim IsXJXS As Decimal = DatagridviewEx1.Rows(0).Cells("新件销售").Value
        Dim IsXJBF As Decimal = DatagridviewEx1.Rows(0).Cells("新件维修").Value
        Dim IsKFJY As Decimal = DatagridviewEx1.Rows(0).Cells("客户借用").Value
        Dim IsLLTH As Decimal = DatagridviewEx1.Rows(0).Cells("领料退回").Value
        Dim IsOLWX As Decimal = DatagridviewEx2.Rows(0).Cells("旧件维修").Value

        If IsLLTH < 0 Then
            MessageBox.Show("当前[领料退回]不能为负数")
            Return
        End If

        If IsOLWX < IsKFJY Then
            MessageBox.Show("当前[旧件维修]不能小于[客户借用]")
            Return
        End If

        Button1.Enabled = False
        If IsXJXS > 0 Then
            Dim myNum As Decimal = InputBox("请输入维修服务费用！")
            If myNum < 0 Then
                MessageBox.Show("服务费用少于0，单据无法进行！")
                Return
            End If
            AddDD("售后新件销售"， IsXJXS,,, myNum) ' '新件销售 推送冬女
        End If
        If IsLLTH > 0 Then AddDD("售后新件退还"， IsLLTH) ' '领料退回 推送仓库
        If IsKFJY > 0 Then AddDD("售后返厂维修"， IsKFJY, "客户借用") ' ' 售后返厂维修 推送下一流程
        If IsOLWX > 0 Then
            Dim IsNoname As Integer = IsOLWX - IsKFJY
            If IsNoname > 0 Then
                AddDD("售后返厂维修"， IsNoname) ' '售后返厂维修 推送下一流程
            End If
        End If

        If IsXJBF > 0 Then
            AddDD("售后返厂维修"， IsXJBF, "新件维修") ' '售后返厂维修 推送下一流程
        End If
        base.updata提起量(id, isAllNum)
        MessageBox.Show("所有单据处理完毕！")
        Ac()
        Close()
    End Sub
End Class