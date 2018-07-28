<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 业务拜访记录单历史查询
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(业务拜访记录单历史查询))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.每页行数 = New System.Windows.Forms.NumericUpDown()
        Me.HeadTxt = New System.Windows.Forms.Label()
        Me.分页 = New System.Windows.Forms.ComboBox()
        Me.Label_执行耗时 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.日期选择 = New System.Windows.Forms.Panel()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.Button_日期确定 = New System.Windows.Forms.Button()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox_所有客户 = New System.Windows.Forms.CheckBox()
        Me.显示所有 = New System.Windows.Forms.CheckBox()
        Me.获得对方名称 = New System.Windows.Forms.Button()
        Me.刷新 = New System.Windows.Forms.Button()
        Me.类型 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.对方名称 = New System.Windows.Forms.TextBox()
        Me.KeyTxt = New System.Windows.Forms.TextBox()
        Me.导出 = New System.Windows.Forms.ToolStrip()
        Me.toexcel = New System.Windows.Forms.ToolStripSplitButton()
        Me.按格式导出excelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.对方 = New System.Windows.Forms.Label()
        Me.按日期方式 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.打印次数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datagridview1 = New DatagridviewEx.DatagridviewEx()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel8.SuspendLayout()
        CType(Me.每页行数, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.日期选择.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.导出.SuspendLayout()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.每页行数)
        Me.Panel8.Controls.Add(Me.HeadTxt)
        Me.Panel8.Controls.Add(Me.分页)
        Me.Panel8.Controls.Add(Me.Label_执行耗时)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1143, 35)
        Me.Panel8.TabIndex = 4
        '
        '每页行数
        '
        Me.每页行数.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.每页行数.Location = New System.Drawing.Point(756, 7)
        Me.每页行数.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.每页行数.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.每页行数.Name = "每页行数"
        Me.每页行数.Size = New System.Drawing.Size(52, 21)
        Me.每页行数.TabIndex = 27
        Me.每页行数.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'HeadTxt
        '
        Me.HeadTxt.AutoSize = True
        Me.HeadTxt.BackColor = System.Drawing.Color.Transparent
        Me.HeadTxt.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HeadTxt.ForeColor = System.Drawing.Color.White
        Me.HeadTxt.Location = New System.Drawing.Point(4, 9)
        Me.HeadTxt.Name = "HeadTxt"
        Me.HeadTxt.Size = New System.Drawing.Size(184, 16)
        Me.HeadTxt.TabIndex = 1
        Me.HeadTxt.Text = "客户拜访记录单历史查询"
        '
        '分页
        '
        Me.分页.DropDownHeight = 406
        Me.分页.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.分页.DropDownWidth = 242
        Me.分页.FormattingEnabled = True
        Me.分页.IntegralHeight = False
        Me.分页.Items.AddRange(New Object() {"无分页"})
        Me.分页.Location = New System.Drawing.Point(810, 8)
        Me.分页.Name = "分页"
        Me.分页.Size = New System.Drawing.Size(94, 20)
        Me.分页.TabIndex = 26
        '
        'Label_执行耗时
        '
        Me.Label_执行耗时.AutoSize = True
        Me.Label_执行耗时.BackColor = System.Drawing.Color.Transparent
        Me.Label_执行耗时.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_执行耗时.ForeColor = System.Drawing.Color.Silver
        Me.Label_执行耗时.Location = New System.Drawing.Point(905, 15)
        Me.Label_执行耗时.Name = "Label_执行耗时"
        Me.Label_执行耗时.Size = New System.Drawing.Size(29, 12)
        Me.Label_执行耗时.TabIndex = 21
        Me.Label_执行耗时.Text = "SQL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(720, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "每页:"
        '
        '日期选择
        '
        Me.日期选择.BackColor = System.Drawing.Color.Lavender
        Me.日期选择.Controls.Add(Me.date2)
        Me.日期选择.Controls.Add(Me.Button_日期确定)
        Me.日期选择.Controls.Add(Me.date1)
        Me.日期选择.Controls.Add(Me.Label4)
        Me.日期选择.Location = New System.Drawing.Point(535, 3)
        Me.日期选择.Name = "日期选择"
        Me.日期选择.Size = New System.Drawing.Size(273, 28)
        Me.日期选择.TabIndex = 25
        Me.日期选择.Visible = False
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
        'Button_日期确定
        '
        Me.Button_日期确定.BackColor = System.Drawing.SystemColors.Control
        Me.Button_日期确定.ForeColor = System.Drawing.Color.Red
        Me.Button_日期确定.Location = New System.Drawing.Point(240, 2)
        Me.Button_日期确定.Name = "Button_日期确定"
        Me.Button_日期确定.Size = New System.Drawing.Size(26, 23)
        Me.Button_日期确定.TabIndex = 24
        Me.Button_日期确定.Text = "OK"
        Me.Button_日期确定.UseVisualStyleBackColor = False
        Me.Button_日期确定.Visible = False
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "至"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.CheckBox_所有客户)
        Me.Panel9.Controls.Add(Me.日期选择)
        Me.Panel9.Controls.Add(Me.显示所有)
        Me.Panel9.Controls.Add(Me.获得对方名称)
        Me.Panel9.Controls.Add(Me.刷新)
        Me.Panel9.Controls.Add(Me.类型)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.对方名称)
        Me.Panel9.Controls.Add(Me.KeyTxt)
        Me.Panel9.Controls.Add(Me.导出)
        Me.Panel9.Controls.Add(Me.对方)
        Me.Panel9.Controls.Add(Me.按日期方式)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.Label22)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 35)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1143, 32)
        Me.Panel9.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1079, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 12)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = " "
        '
        'CheckBox_所有客户
        '
        Me.CheckBox_所有客户.AutoSize = True
        Me.CheckBox_所有客户.Location = New System.Drawing.Point(887, 8)
        Me.CheckBox_所有客户.Name = "CheckBox_所有客户"
        Me.CheckBox_所有客户.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_所有客户.TabIndex = 67
        Me.CheckBox_所有客户.Text = "所有客户"
        Me.CheckBox_所有客户.UseVisualStyleBackColor = True
        '
        '显示所有
        '
        Me.显示所有.AutoSize = True
        Me.显示所有.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.显示所有.ForeColor = System.Drawing.Color.Red
        Me.显示所有.Location = New System.Drawing.Point(812, 8)
        Me.显示所有.Name = "显示所有"
        Me.显示所有.Size = New System.Drawing.Size(69, 16)
        Me.显示所有.TabIndex = 31
        Me.显示所有.Text = "显示作废"
        Me.显示所有.UseVisualStyleBackColor = True
        '
        '获得对方名称
        '
        Me.获得对方名称.Location = New System.Drawing.Point(132, 7)
        Me.获得对方名称.Name = "获得对方名称"
        Me.获得对方名称.Size = New System.Drawing.Size(23, 19)
        Me.获得对方名称.TabIndex = 34
        Me.获得对方名称.Text = "…"
        Me.获得对方名称.UseVisualStyleBackColor = True
        '
        '刷新
        '
        Me.刷新.BackColor = System.Drawing.SystemColors.Control
        Me.刷新.ForeColor = System.Drawing.Color.Blue
        Me.刷新.Location = New System.Drawing.Point(468, 3)
        Me.刷新.Name = "刷新"
        Me.刷新.Size = New System.Drawing.Size(61, 24)
        Me.刷新.TabIndex = 24
        Me.刷新.Text = "立即搜索"
        Me.刷新.UseVisualStyleBackColor = False
        '
        '类型
        '
        Me.类型.BackColor = System.Drawing.Color.WhiteSmoke
        Me.类型.DisplayMember = "生产入库"
        Me.类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.类型.DropDownWidth = 150
        Me.类型.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.类型.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.类型.ForeColor = System.Drawing.Color.Black
        Me.类型.FormattingEnabled = True
        Me.类型.ItemHeight = 12
        Me.类型.Location = New System.Drawing.Point(396, 5)
        Me.类型.Name = "类型"
        Me.类型.Size = New System.Drawing.Size(69, 20)
        Me.类型.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(369, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "类型"
        '
        '对方名称
        '
        Me.对方名称.BackColor = System.Drawing.Color.White
        Me.对方名称.Location = New System.Drawing.Point(40, 6)
        Me.对方名称.Name = "对方名称"
        Me.对方名称.Size = New System.Drawing.Size(117, 21)
        Me.对方名称.TabIndex = 0
        '
        'KeyTxt
        '
        Me.KeyTxt.Location = New System.Drawing.Point(202, 6)
        Me.KeyTxt.Name = "KeyTxt"
        Me.KeyTxt.Size = New System.Drawing.Size(83, 21)
        Me.KeyTxt.TabIndex = 0
        '
        '导出
        '
        Me.导出.BackColor = System.Drawing.Color.Transparent
        Me.导出.Dock = System.Windows.Forms.DockStyle.None
        Me.导出.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toexcel})
        Me.导出.Location = New System.Drawing.Point(987, 4)
        Me.导出.Name = "导出"
        Me.导出.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.导出.Size = New System.Drawing.Size(89, 25)
        Me.导出.TabIndex = 25
        Me.导出.Text = "ToolStrip1"
        '
        'toexcel
        '
        Me.toexcel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.按格式导出excelToolStripMenuItem})
        Me.toexcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toexcel.Name = "toexcel"
        Me.toexcel.Size = New System.Drawing.Size(77, 22)
        Me.toexcel.Text = "导出Excel"
        '
        '按格式导出excelToolStripMenuItem
        '
        Me.按格式导出excelToolStripMenuItem.Name = "按格式导出excelToolStripMenuItem"
        Me.按格式导出excelToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.按格式导出excelToolStripMenuItem.Text = "按格式导出excel"
        '
        '对方
        '
        Me.对方.AutoSize = True
        Me.对方.ForeColor = System.Drawing.Color.Black
        Me.对方.Location = New System.Drawing.Point(1, 10)
        Me.对方.Name = "对方"
        Me.对方.Size = New System.Drawing.Size(53, 12)
        Me.对方.TabIndex = 21
        Me.对方.Text = "客户名称"
        '
        '按日期方式
        '
        Me.按日期方式.DropDownHeight = 156
        Me.按日期方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.按日期方式.DropDownWidth = 90
        Me.按日期方式.FormattingEnabled = True
        Me.按日期方式.IntegralHeight = False
        Me.按日期方式.Items.AddRange(New Object() {"所有", "今天", "昨天", "本周", "上周", "本月", "上月", "本年", "去年", "最近一年", "自定义"})
        Me.按日期方式.Location = New System.Drawing.Point(320, 5)
        Me.按日期方式.Name = "按日期方式"
        Me.按日期方式.Size = New System.Drawing.Size(49, 20)
        Me.按日期方式.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(163, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "关键字:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(290, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 12)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "日期"
        '
        '打印次数
        '
        Me.打印次数.DataPropertyName = "打印次数"
        Me.打印次数.FillWeight = 60.0!
        Me.打印次数.HeaderText = "打印次数"
        Me.打印次数.Name = "打印次数"
        Me.打印次数.ReadOnly = True
        Me.打印次数.Visible = False
        Me.打印次数.Width = 60
        '
        'Datagridview1
        '
        Me.Datagridview1.AllowUserToAddRows = False
        Me.Datagridview1.AllowUserToDeleteRows = False
        Me.Datagridview1.AllowUserToOrderColumns = True
        Me.Datagridview1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        Me.Datagridview1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Datagridview1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Datagridview1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.打印次数})
        Me.Datagridview1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Datagridview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridview1.GridColor = System.Drawing.Color.LightSteelBlue
        Me.Datagridview1.Location = New System.Drawing.Point(0, 67)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.ReadOnly = True
        Me.Datagridview1.RowHeadersVisible = False
        Me.Datagridview1.RowTemplate.Height = 23
        Me.Datagridview1.RowTemplate.ReadOnly = True
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.ShowEditingIcon = False
        Me.Datagridview1.Size = New System.Drawing.Size(1143, 480)
        Me.Datagridview1.TabIndex = 9
        Me.Datagridview1.当前用户名 = Nothing
        Me.Datagridview1.管理列的对应表名称 = "clientservice_VisitBill"
        Me.Datagridview1.管理列的控件库名称 = "业务拜访记录单历史查询"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(960, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 21)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '业务拜访记录单历史查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Datagridview1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "业务拜访记录单历史查询"
        Me.Size = New System.Drawing.Size(1143, 547)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.每页行数, System.ComponentModel.ISupportInitialize).EndInit()
        Me.日期选择.ResumeLayout(False)
        Me.日期选择.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.导出.ResumeLayout(False)
        Me.导出.PerformLayout()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents 日期选择 As System.Windows.Forms.Panel
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button_日期确定 As System.Windows.Forms.Button
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents 每页行数 As System.Windows.Forms.NumericUpDown
    Friend WithEvents HeadTxt As System.Windows.Forms.Label
    Friend WithEvents 分页 As System.Windows.Forms.ComboBox
    Friend WithEvents Label_执行耗时 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents 显示所有 As System.Windows.Forms.CheckBox
    Friend WithEvents 刷新 As System.Windows.Forms.Button
    Friend WithEvents 类型 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KeyTxt As System.Windows.Forms.TextBox
    Friend WithEvents 导出 As System.Windows.Forms.ToolStrip
    Friend WithEvents toexcel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents 按格式导出excelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 按日期方式 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents 打印次数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datagridview1 As DatagridviewEx.DatagridviewEx
    Friend WithEvents 获得对方名称 As System.Windows.Forms.Button
    Friend WithEvents 对方名称 As System.Windows.Forms.TextBox
    Friend WithEvents 对方 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_所有客户 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
