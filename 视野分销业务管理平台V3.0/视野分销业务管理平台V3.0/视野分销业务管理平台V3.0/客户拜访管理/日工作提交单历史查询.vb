Public Class 日工作提交单历史查询
    Private base As New 日工作提交单历史查询Base
    Public _where As String = ""
    Private Sub 日工作提交单历史查询历史查询_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Datagridview1.当前用户名 = Bus_CurrentUser_Fullname
        按日期方式.Text = "最近一年"
        ComboBox_审核状态.Text = "未审核"
        doselect()
    End Sub

    Private Sub 刷新_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新.Click
        doselect()
    End Sub
    Sub doselect()
        Dim where As String = _where
        If SyERP20.Bus_CurrentUser_不能查看他人的单据 = True Then
            where += " and introducer='" & Bus_CurrentUser_Fullname & "'"
        End If
        If ComboBox_审核状态.Text = "未审核" Then
            where += " and isnull(auditing,'')=''"
        ElseIf ComboBox_审核状态.Text = "已审核" Then
            where += " and isnull(auditing,'')<>''"
        End If
        If 显示所有.Checked = False Then
            where += " and left(code,1)<>'*'"
        End If
        If date1.Value > "2000-01-01" Then
            If date1.Value < "2000-01-01" Then
                date1.Value = Today
            End If
            where += " and Billdate>='" & date1.Value.ToString("yyyy-MM-dd") & "' and billdate<='" & date2.Value.ToString("yyyy-MM-dd") & "'"
        End If
        If 对方名称.Text <> "" Then
            where += " and client like '%" & 对方名称.Text & "%'"
        End If
        If 类型.Text <> "" And 类型.Text <> "所有" Then
            where += " and billtype like '%" & 类型.Text & "%'"
        End If
        If KeyTxt.Text <> "" Then
            Dim textArr() As String = KeyTxt.Text.Split(" ") '不错的空格 AND 查询
            For Each t As String In textArr
                where += " and (CODE like '%" & t & "%' or " & _
                             " Client like '%" & t & "%' or " & _
                              " BillMan like '%" & t & "%' or " & _
                              " BillNote like '%" & t & "%' or " & _
                              " referCode like '%" & t & "%' or " & _
                                " zf1 like '%" & t & "%' or " & _
                                  " zf2 like '%" & t & "%' or " & _
                                    " zf3 like '%" & t & "%' or " & _
                                      " zf4 like '%" & t & "%' or " & _
                                         " zf5 like '%" & t & "%' or " & _
                                          " notepre like '%" & t & "%' or " & _
                              " zf6 like '%" & t & "%') "
            Next
        End If
        Datagridview1.DataSource = base.GetList(where)
    End Sub

    '日期更改时
    Private Sub 按日期方式_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles 按日期方式.TextChanged
        If 按日期方式.Text = "" Then Exit Sub
        If 按日期方式.Text = "自定义" Then
            日期选择.Visible = True
            Exit Sub
        Else
            日期选择.Visible = False
        End If
        Select Case 按日期方式.Text
            Case "今天"
                date1.Value = BuildFrmTo获得服务器时间()
                date2.Value = BuildFrmTo获得服务器时间()
            Case "昨天"
                date1.Value = BuildFrmTo获得服务器时间.AddDays(-1)
                date2.Value = BuildFrmTo获得服务器时间.AddDays(-1)
            Case "本周"
                date1.Value = BuildFrmTo获得服务器时间.AddDays(-IIf(Today.DayOfWeek = 0, 7, Today.DayOfWeek) + 1)
                date2.Value = BuildFrmTo获得服务器时间()
            Case "上周"
                date1.Value = BuildFrmTo获得服务器时间.AddDays(-IIf(Today.DayOfWeek = 0, 7, Today.DayOfWeek) + 1 - 7)
                date2.Value = BuildFrmTo获得服务器时间.AddDays(-IIf(Today.DayOfWeek = 0, 7, Today.DayOfWeek) + 1 - 1)
            Case "本月"
                date1.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间), "01")
                date2.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间) + 1, "01").AddDays(-1)
            Case "上月"
                date1.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间) - 1, "01")
                date2.Value = DateSerial(Year(BuildFrmTo获得服务器时间), Month(BuildFrmTo获得服务器时间), "01").AddDays(-1)
            Case "本年"
                date1.Value = DateSerial(Year(BuildFrmTo获得服务器时间), "01", "01")
                date2.Value = DateSerial(Year(BuildFrmTo获得服务器时间) + 1, "01", "01").AddDays(-1)
            Case "去年"
                date1.Value = DateSerial(Year(BuildFrmTo获得服务器时间) - 1, "01", "01")
                date2.Value = DateSerial(Year(BuildFrmTo获得服务器时间), "01", "01").AddDays(-1)
            Case "最近一年"
                date1.Value = BuildFrmTo获得服务器时间.AddYears(-1)
                date2.Value = BuildFrmTo获得服务器时间()
        End Select
        doselect()
    End Sub
    Private Sub Datagridview1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datagridview1.CellDoubleClick
        Dim id As Integer
        id = IIf(IsDBNull(Datagridview1.Rows(e.RowIndex).Cells("id").Value), "", Datagridview1.Rows(e.RowIndex).Cells("id").Value)
        If id > 0 Then
            Dim t As New 日工作提交单(id)
            t.ShowDialog()
            If t._已保存 = True Then
                doselect()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_日期确定.Click
        doselect()
    End Sub

    Private Sub 获得对方名称_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 获得对方名称.Click
        Dim SeltFrm As New SyERP20.SelectFormBase   '资料选择支持类
        SeltFrm.ShowEditForm("clientservice_kfku", "", 对方名称) '客户信息

    End Sub

    Private Sub 显示所有_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示所有.CheckedChanged
        doselect()
    End Sub

    Private Sub toexcel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toexcel.ButtonClick
        ' SyERP20.SaveToXls(Datagridview1, "日工作提交单历史查询")
    End Sub


    Private Sub ComboBox_审核状态_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_审核状态.SelectedIndexChanged
        doselect()
    End Sub
End Class
