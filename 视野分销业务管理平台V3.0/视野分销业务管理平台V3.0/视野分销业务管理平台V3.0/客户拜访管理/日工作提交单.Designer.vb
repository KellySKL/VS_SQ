<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 日工作提交单
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(日工作提交单))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox_审核 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_保存 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_作废 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_退出 = New System.Windows.Forms.ToolStripButton()
        Me.lbl_标题 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Datagridview1 = New DatagridviewEx.DatagridviewEx()
        Me.单号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.客户名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.工作事项 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Combo_拜访日期 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_输入日期 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textbox_输入员 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.TextBox_其他费用 = New System.Windows.Forms.TextBox()
        Me.TextBox_餐饮费 = New System.Windows.Forms.TextBox()
        Me.TextBox_招待费 = New System.Windows.Forms.TextBox()
        Me.TextBox_开车补贴 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_住宿费 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_打车费 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_公交费 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RicherTextBox_Note = New RicherTextBox.RicherTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tool_审核 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox_审核, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.PictureBox_审核)
        Me.Panel8.Controls.Add(Me.ToolStrip1)
        Me.Panel8.Controls.Add(Me.lbl_标题)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1155, 67)
        Me.Panel8.TabIndex = 61
        '
        'PictureBox_审核
        '
        Me.PictureBox_审核.Image = CType(resources.GetObject("PictureBox_审核.Image"), System.Drawing.Image)
        Me.PictureBox_审核.Location = New System.Drawing.Point(148, 3)
        Me.PictureBox_审核.Name = "PictureBox_审核"
        Me.PictureBox_审核.Size = New System.Drawing.Size(115, 37)
        Me.PictureBox_审核.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_审核.TabIndex = 3
        Me.PictureBox_审核.TabStop = False
        Me.PictureBox_审核.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_保存, Me.ToolStrip_作废, Me.Tool_审核, Me.ToolStripButton1, Me.ToolStrip_退出})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 42)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1155, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_保存
        '
        Me.Tool_保存.Image = CType(resources.GetObject("Tool_保存.Image"), System.Drawing.Image)
        Me.Tool_保存.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_保存.Name = "Tool_保存"
        Me.Tool_保存.Size = New System.Drawing.Size(76, 22)
        Me.Tool_保存.Text = "保存...(&S)"
        '
        'ToolStrip_作废
        '
        Me.ToolStrip_作废.Enabled = False
        Me.ToolStrip_作废.Image = CType(resources.GetObject("ToolStrip_作废.Image"), System.Drawing.Image)
        Me.ToolStrip_作废.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_作废.Name = "ToolStrip_作废"
        Me.ToolStrip_作废.Size = New System.Drawing.Size(76, 22)
        Me.ToolStrip_作废.Text = "作废...(&Z)"
        '
        'ToolStrip_退出
        '
        Me.ToolStrip_退出.Image = CType(resources.GetObject("ToolStrip_退出.Image"), System.Drawing.Image)
        Me.ToolStrip_退出.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_退出.Name = "ToolStrip_退出"
        Me.ToolStrip_退出.Size = New System.Drawing.Size(67, 22)
        Me.ToolStrip_退出.Text = "退出(&S)"
        '
        'lbl_标题
        '
        Me.lbl_标题.AutoSize = True
        Me.lbl_标题.BackColor = System.Drawing.Color.Transparent
        Me.lbl_标题.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_标题.ForeColor = System.Drawing.Color.White
        Me.lbl_标题.Location = New System.Drawing.Point(12, 9)
        Me.lbl_标题.Name = "lbl_标题"
        Me.lbl_标题.Size = New System.Drawing.Size(135, 19)
        Me.lbl_标题.TabIndex = 1
        Me.lbl_标题.Text = "日工作提交单"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 67)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Datagridview1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel9)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_其他费用)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_餐饮费)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_招待费)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_开车补贴)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_住宿费)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_打车费)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_公交费)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RicherTextBox_Note)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1155, 482)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 62
        '
        'Datagridview1
        '
        Me.Datagridview1.AllowUserToAddRows = False
        Me.Datagridview1.AllowUserToDeleteRows = False
        Me.Datagridview1.AllowUserToOrderColumns = True
        Me.Datagridview1.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        Me.Datagridview1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Datagridview1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.单号, Me.客户名称, Me.工作事项})
        Me.Datagridview1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Datagridview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridview1.GridColor = System.Drawing.Color.LightSteelBlue
        Me.Datagridview1.Location = New System.Drawing.Point(0, 38)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.ReadOnly = True
        Me.Datagridview1.RowHeadersVisible = False
        Me.Datagridview1.RowTemplate.Height = 23
        Me.Datagridview1.RowTemplate.ReadOnly = True
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.ShowEditingIcon = False
        Me.Datagridview1.Size = New System.Drawing.Size(1155, 213)
        Me.Datagridview1.TabIndex = 69
        Me.Datagridview1.当前用户名 = Nothing
        Me.Datagridview1.管理列的对应表名称 = "clientservice_VisitBill"
        Me.Datagridview1.管理列的控件库名称 = "日工作提交单"
        '
        '单号
        '
        Me.单号.DataPropertyName = "code"
        Me.单号.HeaderText = "单号"
        Me.单号.Name = "单号"
        Me.单号.ReadOnly = True
        '
        '客户名称
        '
        Me.客户名称.DataPropertyName = "client"
        Me.客户名称.HeaderText = "客户名称"
        Me.客户名称.Name = "客户名称"
        Me.客户名称.ReadOnly = True
        '
        '工作事项
        '
        Me.工作事项.DataPropertyName = "notepre"
        Me.工作事项.HeaderText = "工作事项"
        Me.工作事项.Name = "工作事项"
        Me.工作事项.ReadOnly = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.Combo_拜访日期)
        Me.Panel9.Controls.Add(Me.TextBox_输入日期)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.textbox_输入员)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.label4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1155, 38)
        Me.Panel9.TabIndex = 63
        '
        'Combo_拜访日期
        '
        Me.Combo_拜访日期.Location = New System.Drawing.Point(70, 9)
        Me.Combo_拜访日期.Name = "Combo_拜访日期"
        Me.Combo_拜访日期.Size = New System.Drawing.Size(110, 21)
        Me.Combo_拜访日期.TabIndex = 3
        '
        'TextBox_输入日期
        '
        Me.TextBox_输入日期.Location = New System.Drawing.Point(459, 6)
        Me.TextBox_输入日期.Name = "TextBox_输入日期"
        Me.TextBox_输入日期.ReadOnly = True
        Me.TextBox_输入日期.Size = New System.Drawing.Size(150, 21)
        Me.TextBox_输入日期.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(399, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "输入日期："
        '
        'textbox_输入员
        '
        Me.textbox_输入员.Location = New System.Drawing.Point(231, 6)
        Me.textbox_输入员.Name = "textbox_输入员"
        Me.textbox_输入员.ReadOnly = True
        Me.textbox_输入员.Size = New System.Drawing.Size(150, 21)
        Me.textbox_输入员.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(186, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "输入员："
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Enabled = False
        Me.label4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(12, 13)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 12)
        Me.label4.TabIndex = 64
        Me.label4.Text = "拜访日期："
        '
        'TextBox_其他费用
        '
        Me.TextBox_其他费用.Location = New System.Drawing.Point(823, 188)
        Me.TextBox_其他费用.Name = "TextBox_其他费用"
        Me.TextBox_其他费用.Size = New System.Drawing.Size(290, 21)
        Me.TextBox_其他费用.TabIndex = 72
        '
        'TextBox_餐饮费
        '
        Me.TextBox_餐饮费.Location = New System.Drawing.Point(823, 165)
        Me.TextBox_餐饮费.Name = "TextBox_餐饮费"
        Me.TextBox_餐饮费.Size = New System.Drawing.Size(290, 21)
        Me.TextBox_餐饮费.TabIndex = 72
        '
        'TextBox_招待费
        '
        Me.TextBox_招待费.Location = New System.Drawing.Point(823, 142)
        Me.TextBox_招待费.Name = "TextBox_招待费"
        Me.TextBox_招待费.Size = New System.Drawing.Size(290, 21)
        Me.TextBox_招待费.TabIndex = 72
        '
        'TextBox_开车补贴
        '
        Me.TextBox_开车补贴.Location = New System.Drawing.Point(823, 119)
        Me.TextBox_开车补贴.Name = "TextBox_开车补贴"
        Me.TextBox_开车补贴.Size = New System.Drawing.Size(290, 21)
        Me.TextBox_开车补贴.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(763, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "其他费用："
        '
        'TextBox_住宿费
        '
        Me.TextBox_住宿费.Location = New System.Drawing.Point(823, 95)
        Me.TextBox_住宿费.Name = "TextBox_住宿费"
        Me.TextBox_住宿费.Size = New System.Drawing.Size(290, 21)
        Me.TextBox_住宿费.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(763, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "餐饮费："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(775, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "招待费："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(764, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "开车补贴："
        '
        'TextBox_打车费
        '
        Me.TextBox_打车费.Location = New System.Drawing.Point(823, 72)
        Me.TextBox_打车费.Name = "TextBox_打车费"
        Me.TextBox_打车费.Size = New System.Drawing.Size(290, 21)
        Me.TextBox_打车费.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(775, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "住宿费："
        '
        'TextBox_公交费
        '
        Me.TextBox_公交费.Location = New System.Drawing.Point(823, 49)
        Me.TextBox_公交费.Name = "TextBox_公交费"
        Me.TextBox_公交费.Size = New System.Drawing.Size(290, 21)
        Me.TextBox_公交费.TabIndex = 73
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(764, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 12)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "打车费："
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(764, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "公交费："
        '
        'RicherTextBox_Note
        '
        Me.RicherTextBox_Note.AlignCenterVisible = True
        Me.RicherTextBox_Note.AlignLeftVisible = True
        Me.RicherTextBox_Note.AlignRightVisible = True
        Me.RicherTextBox_Note.BoldVisible = True
        Me.RicherTextBox_Note.BulletsVisible = True
        Me.RicherTextBox_Note.ChooseFontVisible = True
        Me.RicherTextBox_Note.FontColorVisible = True
        Me.RicherTextBox_Note.FontFamilyVisible = True
        Me.RicherTextBox_Note.FontSizeVisible = True
        Me.RicherTextBox_Note.GroupAlignmentVisible = True
        Me.RicherTextBox_Note.GroupBoldUnderlineItalicVisible = True
        Me.RicherTextBox_Note.GroupFontColorVisible = True
        Me.RicherTextBox_Note.GroupFontNameAndSizeVisible = True
        Me.RicherTextBox_Note.GroupIndentationAndBulletsVisible = True
        Me.RicherTextBox_Note.GroupInsertVisible = False
        Me.RicherTextBox_Note.GroupSaveAndLoadVisible = True
        Me.RicherTextBox_Note.GroupZoomVisible = False
        Me.RicherTextBox_Note.INDENT = 10
        Me.RicherTextBox_Note.IndentVisible = True
        Me.RicherTextBox_Note.InsertPictureVisible = True
        Me.RicherTextBox_Note.ItalicVisible = True
        Me.RicherTextBox_Note.LoadVisible = True
        Me.RicherTextBox_Note.Location = New System.Drawing.Point(3, 27)
        Me.RicherTextBox_Note.Name = "RicherTextBox_Note"
        Me.RicherTextBox_Note.OutdentVisible = True
        Me.RicherTextBox_Note.Rtf = "{\rtf1\ansi\ansicpg936\deff0\deflang1033\deflangfe2052{\fonttbl{\f0\fnil\fcharset" & _
            "204 Microsoft Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang2052\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RicherTextBox_Note.SaveVisible = True
        Me.RicherTextBox_Note.SeparatorAlignVisible = True
        Me.RicherTextBox_Note.SeparatorBoldUnderlineItalicVisible = True
        Me.RicherTextBox_Note.SeparatorFontColorVisible = True
        Me.RicherTextBox_Note.SeparatorFontVisible = True
        Me.RicherTextBox_Note.SeparatorIndentAndBulletsVisible = True
        Me.RicherTextBox_Note.SeparatorInsertVisible = False
        Me.RicherTextBox_Note.SeparatorSaveLoadVisible = True
        Me.RicherTextBox_Note.Size = New System.Drawing.Size(752, 148)
        Me.RicherTextBox_Note.TabIndex = 68
        Me.RicherTextBox_Note.ToolStripVisible = True
        Me.RicherTextBox_Note.UnderlineVisible = True
        Me.RicherTextBox_Note.WordWrapVisible = True
        Me.RicherTextBox_Note.ZoomFactorTextVisible = False
        Me.RicherTextBox_Note.ZoomInVisible = False
        Me.RicherTextBox_Note.ZoomOutVisible = False
        Me.RicherTextBox_Note.修改flag = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "工作总结： "
        '
        'Tool_审核
        '
        Me.Tool_审核.Image = CType(resources.GetObject("Tool_审核.Image"), System.Drawing.Image)
        Me.Tool_审核.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_审核.Name = "Tool_审核"
        Me.Tool_审核.Size = New System.Drawing.Size(61, 22)
        Me.Tool_审核.Text = "审核..."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "反审核..."
        '
        '日工作提交单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 549)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "日工作提交单"
        Me.Text = "日工作提交单"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox_审核, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_保存 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip_退出 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_标题 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Combo_拜访日期 As System.Windows.Forms.DateTimePicker
    Friend WithEvents textbox_输入员 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents Datagridview1 As DatagridviewEx.DatagridviewEx
    Friend WithEvents ToolStrip_作废 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RicherTextBox_Note As RicherTextBox.RicherTextBox
    Friend WithEvents TextBox_打车费 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_公交费 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox_开车补贴 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_住宿费 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox_审核 As System.Windows.Forms.PictureBox
    Friend WithEvents 单号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 客户名称 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 工作事项 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox_输入日期 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_其他费用 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_餐饮费 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_招待费 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tool_审核 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
