<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 售后服务单分配
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(售后服务单分配))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DateTimePicker要求日期结束1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker要求日期开始1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel_高级搜索 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker开单日期结束1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker开单日期开始1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_关键字 = New System.Windows.Forms.TextBox()
        Me.ComboBox_要求完成日期 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_开单日期 = New System.Windows.Forms.ComboBox()
        Me.Button_高级查询 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DatagridviewEx1 = New DatagridviewEx.DatagridviewEx()
        Me.选择 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip_分配状态 = New System.Windows.Forms.ToolStripComboBox()
        Me.Tool_立即分配 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_反分配 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_打开搜索 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_导出EXCEL = New System.Windows.Forms.ToolStripButton()
        Me.DatagridviewEx2 = New DatagridviewEx.DatagridviewEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_正在执行 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ContextMenuStrip_图片附件 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl_标题 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel_高级搜索.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DatagridviewEx2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_正在执行.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.Controls.Add(Me.DateTimePicker要求日期结束1)
        Me.Panel3.Controls.Add(Me.DateTimePicker要求日期开始1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(130, 107)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 28)
        Me.Panel3.TabIndex = 63
        '
        'DateTimePicker要求日期结束1
        '
        Me.DateTimePicker要求日期结束1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DateTimePicker要求日期结束1.Location = New System.Drawing.Point(130, 3)
        Me.DateTimePicker要求日期结束1.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker要求日期结束1.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker要求日期结束1.Name = "DateTimePicker要求日期结束1"
        Me.DateTimePicker要求日期结束1.Size = New System.Drawing.Size(108, 21)
        Me.DateTimePicker要求日期结束1.TabIndex = 18
        '
        'DateTimePicker要求日期开始1
        '
        Me.DateTimePicker要求日期开始1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DateTimePicker要求日期开始1.Checked = False
        Me.DateTimePicker要求日期开始1.Location = New System.Drawing.Point(5, 3)
        Me.DateTimePicker要求日期开始1.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker要求日期开始1.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker要求日期开始1.Name = "DateTimePicker要求日期开始1"
        Me.DateTimePicker要求日期开始1.Size = New System.Drawing.Size(107, 21)
        Me.DateTimePicker要求日期开始1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(113, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "至"
        '
        'Panel_高级搜索
        '
        Me.Panel_高级搜索.BackColor = System.Drawing.Color.Lavender
        Me.Panel_高级搜索.Controls.Add(Me.Panel1)
        Me.Panel_高级搜索.Controls.Add(Me.Panel3)
        Me.Panel_高级搜索.Controls.Add(Me.Panel2)
        Me.Panel_高级搜索.Controls.Add(Me.TextBox_关键字)
        Me.Panel_高级搜索.Controls.Add(Me.ComboBox_要求完成日期)
        Me.Panel_高级搜索.Controls.Add(Me.ComboBox_开单日期)
        Me.Panel_高级搜索.Controls.Add(Me.Button_高级查询)
        Me.Panel_高级搜索.Controls.Add(Me.Label9)
        Me.Panel_高级搜索.Controls.Add(Me.Label7)
        Me.Panel_高级搜索.Controls.Add(Me.Label8)
        Me.Panel_高级搜索.Location = New System.Drawing.Point(324, 89)
        Me.Panel_高级搜索.Name = "Panel_高级搜索"
        Me.Panel_高级搜索.Size = New System.Drawing.Size(399, 204)
        Me.Panel_高级搜索.TabIndex = 77
        Me.Panel_高级搜索.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 32)
        Me.Panel1.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(376, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "高级搜索"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.DateTimePicker开单日期结束1)
        Me.Panel2.Controls.Add(Me.DateTimePicker开单日期开始1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(130, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 28)
        Me.Panel2.TabIndex = 63
        '
        'DateTimePicker开单日期结束1
        '
        Me.DateTimePicker开单日期结束1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DateTimePicker开单日期结束1.Location = New System.Drawing.Point(130, 3)
        Me.DateTimePicker开单日期结束1.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker开单日期结束1.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker开单日期结束1.Name = "DateTimePicker开单日期结束1"
        Me.DateTimePicker开单日期结束1.Size = New System.Drawing.Size(108, 21)
        Me.DateTimePicker开单日期结束1.TabIndex = 18
        '
        'DateTimePicker开单日期开始1
        '
        Me.DateTimePicker开单日期开始1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DateTimePicker开单日期开始1.Checked = False
        Me.DateTimePicker开单日期开始1.Location = New System.Drawing.Point(5, 3)
        Me.DateTimePicker开单日期开始1.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker开单日期开始1.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker开单日期开始1.Name = "DateTimePicker开单日期开始1"
        Me.DateTimePicker开单日期开始1.Size = New System.Drawing.Size(107, 21)
        Me.DateTimePicker开单日期开始1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "至"
        '
        'TextBox_关键字
        '
        Me.TextBox_关键字.Location = New System.Drawing.Point(48, 48)
        Me.TextBox_关键字.Name = "TextBox_关键字"
        Me.TextBox_关键字.Size = New System.Drawing.Size(320, 21)
        Me.TextBox_关键字.TabIndex = 53
        '
        'ComboBox_要求完成日期
        '
        Me.ComboBox_要求完成日期.DropDownHeight = 156
        Me.ComboBox_要求完成日期.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_要求完成日期.DropDownWidth = 90
        Me.ComboBox_要求完成日期.FormattingEnabled = True
        Me.ComboBox_要求完成日期.IntegralHeight = False
        Me.ComboBox_要求完成日期.Items.AddRange(New Object() {"今日", "昨天", "本周", "上周", "本月", "上月", "本年", "去年", "最近一年", "自定义"})
        Me.ComboBox_要求完成日期.Location = New System.Drawing.Point(79, 113)
        Me.ComboBox_要求完成日期.Name = "ComboBox_要求完成日期"
        Me.ComboBox_要求完成日期.Size = New System.Drawing.Size(45, 20)
        Me.ComboBox_要求完成日期.TabIndex = 59
        '
        'ComboBox_开单日期
        '
        Me.ComboBox_开单日期.DropDownHeight = 156
        Me.ComboBox_开单日期.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_开单日期.DropDownWidth = 90
        Me.ComboBox_开单日期.FormattingEnabled = True
        Me.ComboBox_开单日期.IntegralHeight = False
        Me.ComboBox_开单日期.Items.AddRange(New Object() {"今日", "昨天", "本周", "上周", "本月", "上月", "本年", "去年", "最近一年", "自定义"})
        Me.ComboBox_开单日期.Location = New System.Drawing.Point(79, 81)
        Me.ComboBox_开单日期.Name = "ComboBox_开单日期"
        Me.ComboBox_开单日期.Size = New System.Drawing.Size(45, 20)
        Me.ComboBox_开单日期.TabIndex = 59
        '
        'Button_高级查询
        '
        Me.Button_高级查询.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_高级查询.Location = New System.Drawing.Point(302, 150)
        Me.Button_高级查询.Name = "Button_高级查询"
        Me.Button_高级查询.Size = New System.Drawing.Size(74, 36)
        Me.Button_高级查询.TabIndex = 56
        Me.Button_高级查询.Text = "查询(C)"
        Me.Button_高级查询.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_高级查询.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(19, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "要求日期："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "开单日期："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(15, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "搜索："
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 41)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_高级搜索)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DatagridviewEx1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DatagridviewEx2)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1140, 512)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.TabIndex = 84
        '
        'DatagridviewEx1
        '
        Me.DatagridviewEx1.AllowUserToAddRows = False
        Me.DatagridviewEx1.AllowUserToDeleteRows = False
        Me.DatagridviewEx1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        Me.DatagridviewEx1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridviewEx1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DatagridviewEx1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridviewEx1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridviewEx1.ColumnHeadersHeight = 20
        Me.DatagridviewEx1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.选择})
        Me.DatagridviewEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewEx1.GridColor = System.Drawing.Color.Silver
        Me.DatagridviewEx1.Location = New System.Drawing.Point(0, 25)
        Me.DatagridviewEx1.Name = "DatagridviewEx1"
        Me.DatagridviewEx1.ReadOnly = True
        Me.DatagridviewEx1.RowHeadersWidth = 20
        Me.DatagridviewEx1.RowTemplate.Height = 23
        Me.DatagridviewEx1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridviewEx1.Size = New System.Drawing.Size(1140, 487)
        Me.DatagridviewEx1.TabIndex = 83
        Me.DatagridviewEx1.当前用户名 = Nothing
        Me.DatagridviewEx1.管理列的对应表名称 = ""
        Me.DatagridviewEx1.管理列的控件库名称 = "售后服务单分配管理"
        '
        '选择
        '
        Me.选择.HeaderText = "选择"
        Me.选择.Name = "选择"
        Me.选择.ReadOnly = True
        Me.选择.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.选择.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_分配状态, Me.Tool_立即分配, Me.Tool_反分配, Me.ToolStripLabel1, Me.ToolStripButton1, Me.Tool_打开搜索, Me.Tool_导出EXCEL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1140, 25)
        Me.ToolStrip1.TabIndex = 82
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStrip_分配状态
        '
        Me.ToolStrip_分配状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStrip_分配状态.Items.AddRange(New Object() {"未分配", "已分配", "所有"})
        Me.ToolStrip_分配状态.Name = "ToolStrip_分配状态"
        Me.ToolStrip_分配状态.Size = New System.Drawing.Size(121, 25)
        '
        'Tool_立即分配
        '
        Me.Tool_立即分配.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tool_立即分配.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tool_立即分配.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_立即分配.Name = "Tool_立即分配"
        Me.Tool_立即分配.Size = New System.Drawing.Size(98, 22)
        Me.Tool_立即分配.Text = "分析及分配(&S)..."
        '
        'Tool_反分配
        '
        Me.Tool_反分配.ForeColor = System.Drawing.Color.Red
        Me.Tool_反分配.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_反分配.Name = "Tool_反分配"
        Me.Tool_反分配.Size = New System.Drawing.Size(84, 22)
        Me.Tool_反分配.Text = "撤消分配(&S)..."
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripLabel1.Text = "查看售后历史领料单"
        Me.ToolStripLabel1.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "立即刷新..."
        '
        'Tool_打开搜索
        '
        Me.Tool_打开搜索.ForeColor = System.Drawing.Color.Black
        Me.Tool_打开搜索.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_打开搜索.Name = "Tool_打开搜索"
        Me.Tool_打开搜索.Size = New System.Drawing.Size(69, 22)
        Me.Tool_打开搜索.Text = "高级搜索..."
        '
        'Tool_导出EXCEL
        '
        Me.Tool_导出EXCEL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_导出EXCEL.Name = "Tool_导出EXCEL"
        Me.Tool_导出EXCEL.Size = New System.Drawing.Size(74, 22)
        Me.Tool_导出EXCEL.Text = "导出Excel..."
        '
        'DatagridviewEx2
        '
        Me.DatagridviewEx2.AllowUserToAddRows = False
        Me.DatagridviewEx2.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew
        Me.DatagridviewEx2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridviewEx2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DatagridviewEx2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridviewEx2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DatagridviewEx2.ColumnHeadersHeight = 20
        Me.DatagridviewEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewEx2.GridColor = System.Drawing.Color.Silver
        Me.DatagridviewEx2.Location = New System.Drawing.Point(0, 0)
        Me.DatagridviewEx2.Name = "DatagridviewEx2"
        Me.DatagridviewEx2.ReadOnly = True
        Me.DatagridviewEx2.RowHeadersWidth = 20
        Me.DatagridviewEx2.RowTemplate.Height = 23
        Me.DatagridviewEx2.Size = New System.Drawing.Size(150, 46)
        Me.DatagridviewEx2.TabIndex = 77
        Me.DatagridviewEx2.当前用户名 = Nothing
        Me.DatagridviewEx2.管理列的对应表名称 = "ProduceExeBill"
        Me.DatagridviewEx2.管理列的控件库名称 = "插件_采购订单审批管理"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "正在读取数据,请等待..."
        '
        'Panel_正在执行
        '
        Me.Panel_正在执行.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel_正在执行.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_正在执行.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_正在执行.Controls.Add(Me.Label2)
        Me.Panel_正在执行.Location = New System.Drawing.Point(397, 233)
        Me.Panel_正在执行.Name = "Panel_正在执行"
        Me.Panel_正在执行.Size = New System.Drawing.Size(234, 41)
        Me.Panel_正在执行.TabIndex = 83
        Me.Panel_正在执行.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 553)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1140, 22)
        Me.StatusStrip1.TabIndex = 82
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ContextMenuStrip_图片附件
        '
        Me.ContextMenuStrip_图片附件.Name = "ContextMenuStrip_图片附件"
        Me.ContextMenuStrip_图片附件.Size = New System.Drawing.Size(61, 4)
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.lbl_标题)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1140, 41)
        Me.Panel8.TabIndex = 79
        '
        'lbl_标题
        '
        Me.lbl_标题.AutoSize = True
        Me.lbl_标题.BackColor = System.Drawing.Color.Transparent
        Me.lbl_标题.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_标题.ForeColor = System.Drawing.Color.White
        Me.lbl_标题.Location = New System.Drawing.Point(12, 11)
        Me.lbl_标题.Name = "lbl_标题"
        Me.lbl_标题.Size = New System.Drawing.Size(177, 19)
        Me.lbl_标题.TabIndex = 1
        Me.lbl_标题.Text = "维修单审核及分配"
        '
        '售后服务单分配
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel_正在执行)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "售后服务单分配"
        Me.Size = New System.Drawing.Size(1140, 575)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel_高级搜索.ResumeLayout(False)
        Me.Panel_高级搜索.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DatagridviewEx2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_正在执行.ResumeLayout(False)
        Me.Panel_正在执行.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker要求日期结束1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker要求日期开始1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel_高级搜索 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker开单日期结束1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker开单日期开始1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_关键字 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_要求完成日期 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_开单日期 As System.Windows.Forms.ComboBox
    Friend WithEvents Button_高级查询 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DatagridviewEx2 As DatagridviewEx.DatagridviewEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel_正在执行 As System.Windows.Forms.Panel
    Friend WithEvents lbl_标题 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ContextMenuStrip_图片附件 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents DatagridviewEx1 As DatagridviewEx.DatagridviewEx
    Friend WithEvents 选择 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip_分配状态 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Tool_立即分配 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_反分配 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_打开搜索 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_导出EXCEL As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel

End Class
