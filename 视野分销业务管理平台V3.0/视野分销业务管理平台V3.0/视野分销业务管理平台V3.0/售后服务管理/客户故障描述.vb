Public Class 客户故障描述


    Private base As New 售后服务维修问题库base
    Public Reback As Object


    Class nn
        Public nTttle As String '内容
        Public fid As String '上级ID 
        Public uid As String '自己ID 
    End Class
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
 


    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick

        If TreeView1.SelectedNode.Parent Is Nothing Then Exit Sub
        Reback.text = e.Node.Text
        Me.Close()

    End Sub
 
    Private Sub 客户故障描述_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "客户故障描述"
        base.isddBan = "故障描述"
        Call readtoTree()
    End Sub

 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
  Call readtoTree()
    End Sub

 
End Class