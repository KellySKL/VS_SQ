Public Class 业务员业绩调整
    Private base As New 业务员业绩调整Base
    Private Sub Button_获得业务员1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_获得业务员1.Click
        Dim seletfrm As New SyERP20.SelectFormBase
        seletfrm.ShowEditForm("puku", "", textbox_业务员1)
    End Sub

    Private Sub textbox_业务员1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textbox_业务员1.TextChanged
        Dim where As String = ""
        If TextBox1.Text <> "" Then
            where = " and (freestr9 like '%" & TextBox1.Text & "%' or client like '%" & TextBox1.Text & "%')"
        End If
        Datagridviewex_业务员1.DataSource = base.Get获得业务员1清单查询(textbox_业务员1.Text, where)
    End Sub
    Private Sub textbox_业务员2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textbox_业务员2.TextChanged
        Datagridviewex_业务员2.DataSource = base.Get获得业务员1清单查询(textbox_业务员2.Text, "")
    End Sub
    Private Sub Button_获得业务员2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_获得业务员2.Click
        Dim seletfrm As New SyERP20.SelectFormBase
        seletfrm.ShowEditForm("puku", "", textbox_业务员2)
    End Sub
    Private Sub DatagridviewEx2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datagridviewex_业务员2.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If Datagridviewex_业务员2.Columns(e.ColumnIndex).Name = "选择" Then
            Datagridviewex_业务员2.Rows(e.RowIndex).Cells("选择").Value = Not Datagridviewex_业务员2.Rows(e.RowIndex).Cells("选择").Value '只有加了这个代码才可以使用复选框
        End If
    End Sub
    Private Sub DatagridviewEx1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datagridviewex_业务员1.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If Datagridviewex_业务员1.Columns(e.ColumnIndex).Name = "选择" Then
            Datagridviewex_业务员1.Rows(e.RowIndex).Cells("选择").Value = Not Datagridviewex_业务员1.Rows(e.RowIndex).Cells("选择").Value '只有加了这个代码才可以使用复选框
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If textbox_业务员2.Text = "" Then
            Dim err As New SyERP20.ErrorForm("请输入业务员!", Nothing)
            err.ShowDialog()
            Exit Sub
        End If
        If MsgBox("您确定要继续吗？", MsgBoxStyle.YesNo) = vbYes Then
            For i As Integer = 0 To Datagridviewex_业务员1.RowCount - 1
                If Datagridviewex_业务员1.Rows(i).Cells("选择").Value = True Then

                    base.Set调整业务员(textbox_业务员2.Text, Datagridviewex_业务员1.Rows(i).Cells("单号").Value)
                End If
            Next
        End If
       
        textbox_业务员1_TextChanged(Nothing, Nothing)
        textbox_业务员2_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For i As Integer = 0 To Datagridviewex_业务员2.RowCount - 1
            If Datagridviewex_业务员2.Rows(i).Cells("选择1").Value = True Then
                base.Set调整业务员(textbox_业务员1.Text, Datagridviewex_业务员2.Rows(i).Cells("单号").Value)
            End If
        Next
        textbox_业务员1_TextChanged(Nothing, Nothing)
        textbox_业务员2_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub 刷新_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新.Click
        textbox_业务员1_TextChanged(Nothing, Nothing)
    End Sub
End Class