Public Class 售后服务维修物料库
    Dim flag As Boolean = False
    Public getId As Integer = -1 '读取的ID号
    Public cname As String = ""  '人名的问题有点复杂
    Public pT2 As String = ""  '这个不重要作为空值
    Public wxCode As String = ""  '维修单号
    Public backCode As String = "取消领料" '返回一个CODE号，是为了得到领料单的CODE 
    Dim setTitleList() As String
    Public wLIst As String
    Public wxID As Integer
    Dim sDT As New DataTable '
    Dim sIndex As Integer = -1
    Dim base As New 售后服务维修问题库base
    Private bacc As New 售后服务单作业管理Base

    Private Sub 售后服务维修物料库_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "售后维修计划领料单"
        Dim setTitleList() As String = {"物料代码", "编号", "物料", "型号", "单位", "数量"}
        For j As Integer = 0 To setTitleList.Length - 1
            Me.DatagridviewEx2.Columns.Add(setTitleList(j).ToString, setTitleList(j).ToString)
        Next

        If Bus_CurrentUser_Fullname = "lxd" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "张太春" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

        sDT = base.GetwxInfo(wxCode)
        Me.Label1.Text = IIf(IsDBNull(sDT.Rows(0)("client")), "读取失败", sDT.Rows(0)("client"))
        Me.Label2.Text = wxCode
        sDT = Nothing
        '这里逻辑线要改
        If cname = "" Then
            Label4.Text = "[未分配]"
            AddHandler Label4.Click, AddressOf Fenp_Click
        Else
            Label4.Text = cname
        End If

        Label5.Text = wxID

        Call ReadWlinfo()

    End Sub
    Private Sub Fenp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fep()
    End Sub
    Private Sub ReadWlinfo()
        '改写方法，不通过读取数据库。直接解析代码串
        If getId = -1 Then
        Else
            wLIst = base._rz_wllist(getId)
        End If
       

        '开始解析------物料信息-------
        Dim wFenz As String() = Nothing
        Dim WFens As String() = Nothing
        Dim wclist As New DataTable
        Dim chh As Integer = -1
        If wLIst.IndexOf("|") = -1 Then
            WFens = wLIst.Split("@")
            '  MessageBox.Show(WFens(0).IndexOf("CL"))
            If WFens(0).IndexOf("CL") = -1 Then
                chh = -1
            Else
                chh = 0
            End If
            wclist = base._rs_wlCode(WFens(0), WFens(1), chh)
            Me.DatagridviewEx2.Rows.Add(New Object() {wclist.Rows(0)("物料代码"), wclist.Rows(0)("编号"), wclist.Rows(0)("物料"), wclist.Rows(0)("型号"), wclist.Rows(0)("单位"), wclist.Rows(0)("数量")})
            wclist = Nothing
        Else
            wFenz = wLIst.Split("|")
            For i As Integer = 0 To wFenz.Count - 1
                WFens = wFenz(i).Split("@")
                '   MessageBox.Show(WFens(0).IndexOf("CL"))
                If WFens(0).IndexOf("CL") = -1 Then
                    chh = -1
                Else
                    chh = 0
                End If


                wclist = base._rs_wlCode(WFens(0), CType(WFens(1), Decimal), chh)
                Me.DatagridviewEx2.Rows.Add(New Object() {wclist.Rows(0)("物料代码"), wclist.Rows(0)("编号"), wclist.Rows(0)("物料"), wclist.Rows(0)("型号"), wclist.Rows(0)("单位"), wclist.Rows(0)("数量")})
                wclist = Nothing
                WFens = Nothing
                ' Me.DatagridviewEx2.Rows.Add(sDT.Rows)
            Next
        End If
        Dim hh As New Boolean
        '----------------------------
    End Sub
 

    Private Sub DatagridviewEx2_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DatagridviewEx2.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then 取值ToolStripMenuItem.Text = "编辑：" & IIf(IsDBNull(DatagridviewEx2.Rows(e.RowIndex).Cells("物料").Value), "", DatagridviewEx2.Rows(e.RowIndex).Cells("物料").Value) & "-" & IIf(IsDBNull(DatagridviewEx2.Rows(e.RowIndex).Cells("型号").Value), "", DatagridviewEx2.Rows(e.RowIndex).Cells("型号").Value)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ToolStripMenuItem2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.MouseLeave
        If Trim(ToolStripMenuItem2.Text) = "0" Or Trim(ToolStripMenuItem2.Text) = "" Then Exit Sub
        If MessageBox.Show("当前物料数量修改为:[" & ToolStripMenuItem2.Text & "]", "数量修改", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DatagridviewEx2.SelectedRows(0).Cells("数量").Value = CType(ToolStripMenuItem2.Text, Decimal)
        End If
    End Sub




    Private Sub Fep()
        Dim xName As String = ""
        '分配人员
        Dim seletfrm As New SyERP20.SelectFormBase
        Dim t1 As New TextBox
        seletfrm.ShowEditForm("puku", " and dept='维修员'", t1)
        If t1.Text <> "" Then
            xName = SyERP20.BusGet用户全名byusername(t1.Text)
            flag = bacc.立即审批(wxID, xName)
        End If
        If flag = True Then
            售后服务单作业接收时描述.getName = xName
            售后服务单作业接收时描述.addMan(xName)
            cname = xName
        End If



    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cname.Trim = "" Then Fep()




        backCode = ""
        Dim getcode As String = ""
        Dim 序号 As String = ""
        Dim upTime As DateTime = BuildFrmTo获得服务器时间()
        序号 = base.showCode("BILLnouse2", "YL")
        getcode = "YL" & upTime.ToString("yyyyMMdd") & Mid("0000", Len(序号.ToString) + 1) & 序号.ToString

        For i As Integer = 0 To Me.DatagridviewEx2.RowCount - 1
            Dim addStr As String = ""
            Dim Gf1 As String = IIf(IsDBNull(Me.DatagridviewEx2.Rows(i).Cells("编号").Value), "读取失败", Me.DatagridviewEx2.Rows(i).Cells("编号").Value)
            Dim Gf2 As String = IIf(IsDBNull(Me.DatagridviewEx2.Rows(i).Cells("物料").Value), "读取失败", Me.DatagridviewEx2.Rows(i).Cells("物料").Value)
            Dim Gf3 As String = IIf(IsDBNull(Me.DatagridviewEx2.Rows(i).Cells("型号").Value), "读取失败", Me.DatagridviewEx2.Rows(i).Cells("型号").Value)
            Dim Gf4 As String = IIf(IsDBNull(Me.DatagridviewEx2.Rows(i).Cells("单位").Value), "读取失败", Me.DatagridviewEx2.Rows(i).Cells("单位").Value)
            Dim Gf9 As String = IIf(IsDBNull(Me.DatagridviewEx2.Rows(i).Cells("数量").Value), "0.0000", Me.DatagridviewEx2.Rows(i).Cells("数量").Value)
            'ADD 自动生成领料单
            addStr = "INSERT into BILLnouse2 (   "
            addStr &= " code, Client, BILLDATE,  finishdate, billtype,paytype,materialcode,materialname, specs,unitname,  "
            addStr &= "introducerDate, introducer,quantity,refercode ,freestr10,discount,引用单号2,"
            addStr &= "boxes, origprice,price,amount,killbillqty, referqty,payedamount,MaxValue,taxtype,batchnumber,"
            addStr &= "auditing, billman,billnote,StorageName,StorageWhere,REMARK)"
            addStr &= "VALUES ('" & getcode & "','" & cname & "','" & upTime.Date & "','" & upTime.Date & "', '售后服务领料','" & wxCode & "','" & Gf1 & "','" & Gf2 & "','" & Gf3 & "','" & Gf4 & "',  "

            addStr &= " '" & upTime & "','" & Bus_CurrentUser_Fullname & "','" & Gf9 & "','" & pT2 & "','," & getcode & "','100.0000','" & pT2 & "','0.0000','0.0000','0.0000','0.0000','0.0000','-1.0000','0.0000',' ',' ',' ', "
            addStr &= " '','','','','','' )"
            base.AddSave(addStr)
            backCode &= getcode & ","
        Next
        Me.Close()

    End Sub
 
    Private Sub 重载物料信息ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重载物料信息ToolStripMenuItem.Click
        Call ReadWlinfo()
    End Sub

    Private Sub 删除当前物料ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除当前物料ToolStripMenuItem.Click
        If MessageBox.Show("是否删除选中的[" & Me.DatagridviewEx2.SelectedRows.Count & "]行数据？", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            For i As Integer = 0 To Me.DatagridviewEx2.SelectedRows.Count - 1
                Me.DatagridviewEx2.Rows.Remove(Me.DatagridviewEx2.SelectedRows(0))
            Next

        End If

    End Sub

  
  
  

   
End Class