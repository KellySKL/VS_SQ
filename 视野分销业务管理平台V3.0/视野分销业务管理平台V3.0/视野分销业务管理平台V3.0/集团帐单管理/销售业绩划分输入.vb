Public Class 销售业绩划分输入
    Private base As New 销售业绩划分输入Base
    Sub New()
        InitializeComponent()
    End Sub

    Sub doselect()
        DataGridView1.DataSource = base.Ge销售清单(date1.Value, date2.Value, "")
    End Sub


    Private Sub 刷新_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新.Click
        doselect()
    End Sub

    Private Sub Button_获得业务员1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_获得业务员1.Click
        Dim seletfrm As New SyERP20.SelectFormBase
        seletfrm.ShowEditForm("puku", "", textbox_业务员1)
    End Sub

    Private Sub Button_获得业务员2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_获得业务员2.Click
        Dim seletfrm As New SyERP20.SelectFormBase
        seletfrm.ShowEditForm("puku", "", textbox_业务员2)
    End Sub



    Private Sub Button_关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_关闭.Click
        Panel_业绩划分管理.Visible = False
    End Sub

    Private Sub Button_保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_保存.Click
        base.Save销售业绩划分输入(TextBox_金额.Text, textbox_业务员1.Text, textbox_业务员2.Text, DateTime_划分日期.Value, ComboBox_客户名称.Text, ComboBox_类型.Text, TextBox_备注.Text)
        Panel_业绩划分管理.Visible = False
        Dim err As New SyERP20.ErrorForm("完成！", Nothing)
        err.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel_业绩划分管理.Visible = True
    End Sub

    Private Sub textbox_业务员1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textbox_业务员1.TextChanged
        ComboBox_客户名称.DataSource = base.Ge客户清单By经手人(textbox_业务员1.Text)
    End Sub

    Private Sub 销售业绩划分输入_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBox_类型.Text = "销售"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        base.删除销售运费(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("id").Value)
        MsgBox("完成！")
        doselect()
    End Sub
End Class