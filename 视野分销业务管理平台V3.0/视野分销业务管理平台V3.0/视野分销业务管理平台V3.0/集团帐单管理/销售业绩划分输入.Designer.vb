<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 销售业绩划分输入
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.HeadTxt = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.日期选择 = New System.Windows.Forms.Panel()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.刷新 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New SyERP20.Datagridview列管理Ex()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTime_划分日期 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_对方名称 = New System.Windows.Forms.Label()
        Me.textbox_业务员1 = New System.Windows.Forms.TextBox()
        Me.Button_获得业务员1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textbox_业务员2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_金额 = New System.Windows.Forms.TextBox()
        Me.Button_获得业务员2 = New System.Windows.Forms.Button()
        Me.Button_保存 = New System.Windows.Forms.Button()
        Me.Button_关闭 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_客户名称 = New System.Windows.Forms.ComboBox()
        Me.Panel_业绩划分管理 = New System.Windows.Forms.Panel()
        Me.ComboBox_类型 = New System.Windows.Forms.ComboBox()
        Me.TextBox_备注 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.日期选择.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel_业绩划分管理.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.Controls.Add(Me.HeadTxt)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(992, 44)
        Me.Panel8.TabIndex = 5
        '
        'HeadTxt
        '
        Me.HeadTxt.AutoSize = True
        Me.HeadTxt.BackColor = System.Drawing.Color.Transparent
        Me.HeadTxt.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HeadTxt.ForeColor = System.Drawing.Color.White
        Me.HeadTxt.Location = New System.Drawing.Point(17, 11)
        Me.HeadTxt.Name = "HeadTxt"
        Me.HeadTxt.Size = New System.Drawing.Size(135, 19)
        Me.HeadTxt.TabIndex = 1
        Me.HeadTxt.Text = "业绩划分查询"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.日期选择)
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Controls.Add(Me.Button3)
        Me.Panel9.Controls.Add(Me.刷新)
        Me.Panel9.Controls.Add(Me.TextBox1)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 44)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(992, 39)
        Me.Panel9.TabIndex = 7
        '
        '日期选择
        '
        Me.日期选择.BackColor = System.Drawing.Color.Lavender
        Me.日期选择.Controls.Add(Me.date2)
        Me.日期选择.Controls.Add(Me.Button2)
        Me.日期选择.Controls.Add(Me.date1)
        Me.日期选择.Controls.Add(Me.Label3)
        Me.日期选择.Location = New System.Drawing.Point(12, 6)
        Me.日期选择.Name = "日期选择"
        Me.日期选择.Size = New System.Drawing.Size(273, 28)
        Me.日期选择.TabIndex = 61
        '
        'date2
        '
        Me.date2.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.date2.Location = New System.Drawing.Point(130, 3)
        Me.date2.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.date2.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(108, 21)
        Me.date2.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(240, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'date1
        '
        Me.date1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.date1.Checked = False
        Me.date1.Location = New System.Drawing.Point(5, 3)
        Me.date1.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.date1.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(107, 21)
        Me.date1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "至"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(508, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 27)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "业绩录入"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(609, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 27)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "业绩作废"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        '刷新
        '
        Me.刷新.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.刷新.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.刷新.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.刷新.Location = New System.Drawing.Point(430, 4)
        Me.刷新.Name = "刷新"
        Me.刷新.Size = New System.Drawing.Size(72, 27)
        Me.刷新.TabIndex = 31
        Me.刷新.Text = "立即搜索"
        Me.刷新.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.刷新.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(331, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 21)
        Me.TextBox1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "搜索："
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 83)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(992, 472)
        Me.DataGridView1.TabIndex = 8
        Me.DataGridView1.管理列的对应表名称 = Nothing
        Me.DataGridView1.管理列的控件库名称 = "分销业务管理平台_本期销售查询"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "日  期："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(400, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "业绩："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(398, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "业绩："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(438, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(438, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "0.00"
        '
        'DateTime_划分日期
        '
        Me.DateTime_划分日期.Location = New System.Drawing.Point(99, 67)
        Me.DateTime_划分日期.Name = "DateTime_划分日期"
        Me.DateTime_划分日期.Size = New System.Drawing.Size(129, 21)
        Me.DateTime_划分日期.TabIndex = 0
        '
        'lbl_对方名称
        '
        Me.lbl_对方名称.AutoSize = True
        Me.lbl_对方名称.Location = New System.Drawing.Point(36, 101)
        Me.lbl_对方名称.Name = "lbl_对方名称"
        Me.lbl_对方名称.Size = New System.Drawing.Size(65, 12)
        Me.lbl_对方名称.TabIndex = 71
        Me.lbl_对方名称.Text = "业务员从："
        '
        'textbox_业务员1
        '
        Me.textbox_业务员1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox_业务员1.Location = New System.Drawing.Point(102, 98)
        Me.textbox_业务员1.Name = "textbox_业务员1"
        Me.textbox_业务员1.ReadOnly = True
        Me.textbox_业务员1.Size = New System.Drawing.Size(289, 21)
        Me.textbox_业务员1.TabIndex = 73
        '
        'Button_获得业务员1
        '
        Me.Button_获得业务员1.Location = New System.Drawing.Point(369, 101)
        Me.Button_获得业务员1.Name = "Button_获得业务员1"
        Me.Button_获得业务员1.Size = New System.Drawing.Size(21, 17)
        Me.Button_获得业务员1.TabIndex = 72
        Me.Button_获得业务员1.Text = "…"
        Me.Button_获得业务员1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "业务员到："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "客户名称："
        '
        'textbox_业务员2
        '
        Me.textbox_业务员2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox_业务员2.Location = New System.Drawing.Point(102, 139)
        Me.textbox_业务员2.Name = "textbox_业务员2"
        Me.textbox_业务员2.ReadOnly = True
        Me.textbox_业务员2.Size = New System.Drawing.Size(289, 21)
        Me.textbox_业务员2.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "金额："
        '
        'TextBox_金额
        '
        Me.TextBox_金额.BackColor = System.Drawing.Color.White
        Me.TextBox_金额.Location = New System.Drawing.Point(102, 227)
        Me.TextBox_金额.Name = "TextBox_金额"
        Me.TextBox_金额.Size = New System.Drawing.Size(289, 21)
        Me.TextBox_金额.TabIndex = 76
        '
        'Button_获得业务员2
        '
        Me.Button_获得业务员2.Location = New System.Drawing.Point(368, 141)
        Me.Button_获得业务员2.Name = "Button_获得业务员2"
        Me.Button_获得业务员2.Size = New System.Drawing.Size(21, 17)
        Me.Button_获得业务员2.TabIndex = 75
        Me.Button_获得业务员2.Text = "…"
        Me.Button_获得业务员2.UseVisualStyleBackColor = True
        '
        'Button_保存
        '
        Me.Button_保存.Location = New System.Drawing.Point(207, 373)
        Me.Button_保存.Name = "Button_保存"
        Me.Button_保存.Size = New System.Drawing.Size(144, 46)
        Me.Button_保存.TabIndex = 77
        Me.Button_保存.Text = "保存"
        Me.Button_保存.UseVisualStyleBackColor = True
        '
        'Button_关闭
        '
        Me.Button_关闭.Location = New System.Drawing.Point(357, 373)
        Me.Button_关闭.Name = "Button_关闭"
        Me.Button_关闭.Size = New System.Drawing.Size(135, 46)
        Me.Button_关闭.TabIndex = 77
        Me.Button_关闭.Text = "关闭"
        Me.Button_关闭.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(517, 44)
        Me.Panel2.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(17, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "业绩划分录入"
        '
        'ComboBox_客户名称
        '
        Me.ComboBox_客户名称.DropDownHeight = 300
        Me.ComboBox_客户名称.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_客户名称.DropDownWidth = 500
        Me.ComboBox_客户名称.FormattingEnabled = True
        Me.ComboBox_客户名称.IntegralHeight = False
        Me.ComboBox_客户名称.Location = New System.Drawing.Point(102, 182)
        Me.ComboBox_客户名称.Name = "ComboBox_客户名称"
        Me.ComboBox_客户名称.Size = New System.Drawing.Size(289, 20)
        Me.ComboBox_客户名称.TabIndex = 79
        '
        'Panel_业绩划分管理
        '
        Me.Panel_业绩划分管理.Controls.Add(Me.ComboBox_类型)
        Me.Panel_业绩划分管理.Controls.Add(Me.ComboBox_客户名称)
        Me.Panel_业绩划分管理.Controls.Add(Me.Panel2)
        Me.Panel_业绩划分管理.Controls.Add(Me.Button_关闭)
        Me.Panel_业绩划分管理.Controls.Add(Me.Button_保存)
        Me.Panel_业绩划分管理.Controls.Add(Me.Button_获得业务员2)
        Me.Panel_业绩划分管理.Controls.Add(Me.TextBox_备注)
        Me.Panel_业绩划分管理.Controls.Add(Me.TextBox_金额)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label13)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label10)
        Me.Panel_业绩划分管理.Controls.Add(Me.textbox_业务员2)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label11)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label4)
        Me.Panel_业绩划分管理.Controls.Add(Me.Button_获得业务员1)
        Me.Panel_业绩划分管理.Controls.Add(Me.textbox_业务员1)
        Me.Panel_业绩划分管理.Controls.Add(Me.lbl_对方名称)
        Me.Panel_业绩划分管理.Controls.Add(Me.DateTime_划分日期)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label9)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label8)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label6)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label5)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label12)
        Me.Panel_业绩划分管理.Controls.Add(Me.Label2)
        Me.Panel_业绩划分管理.Location = New System.Drawing.Point(189, 105)
        Me.Panel_业绩划分管理.Name = "Panel_业绩划分管理"
        Me.Panel_业绩划分管理.Size = New System.Drawing.Size(517, 438)
        Me.Panel_业绩划分管理.TabIndex = 9
        Me.Panel_业绩划分管理.Visible = False
        '
        'ComboBox_类型
        '
        Me.ComboBox_类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_类型.FormattingEnabled = True
        Me.ComboBox_类型.Items.AddRange(New Object() {"销售", "回款"})
        Me.ComboBox_类型.Location = New System.Drawing.Point(278, 68)
        Me.ComboBox_类型.Name = "ComboBox_类型"
        Me.ComboBox_类型.Size = New System.Drawing.Size(111, 20)
        Me.ComboBox_类型.TabIndex = 80
        '
        'TextBox_备注
        '
        Me.TextBox_备注.BackColor = System.Drawing.Color.White
        Me.TextBox_备注.Location = New System.Drawing.Point(102, 263)
        Me.TextBox_备注.Multiline = True
        Me.TextBox_备注.Name = "TextBox_备注"
        Me.TextBox_备注.Size = New System.Drawing.Size(289, 104)
        Me.TextBox_备注.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(67, 266)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "备注："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(239, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "类型："
        '
        '销售业绩划分输入
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 555)
        Me.Controls.Add(Me.Panel_业绩划分管理)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "销售业绩划分输入"
        Me.Text = "本期销售查询"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.日期选择.ResumeLayout(False)
        Me.日期选择.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_业绩划分管理.ResumeLayout(False)
        Me.Panel_业绩划分管理.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents HeadTxt As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents 日期选择 As System.Windows.Forms.Panel
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents 刷新 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As SyERP20.Datagridview列管理Ex
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTime_划分日期 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_对方名称 As System.Windows.Forms.Label
    Friend WithEvents textbox_业务员1 As System.Windows.Forms.TextBox
    Private WithEvents Button_获得业务员1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents textbox_业务员2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_金额 As System.Windows.Forms.TextBox
    Private WithEvents Button_获得业务员2 As System.Windows.Forms.Button
    Friend WithEvents Button_保存 As System.Windows.Forms.Button
    Friend WithEvents Button_关闭 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_客户名称 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel_业绩划分管理 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox_类型 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox_备注 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
