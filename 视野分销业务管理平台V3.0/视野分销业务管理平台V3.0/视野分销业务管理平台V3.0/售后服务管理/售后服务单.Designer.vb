<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 售后服务单
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(售后服务单))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_标题 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_保存 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Tool_业务类型录入 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_作废 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_退出 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RicherTextBox_Note = New RicherTextBox.RicherTextBox()
        Me.lbl_对方名称 = New System.Windows.Forms.Label()
        Me.textbox_客户名称 = New System.Windows.Forms.TextBox()
        Me.lbl_日期 = New System.Windows.Forms.Label()
        Me.日期 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_单号 = New System.Windows.Forms.TextBox()
        Me.lbl_联系人 = New System.Windows.Forms.Label()
        Me.txt_联系人 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_地址 = New System.Windows.Forms.TextBox()
        Me.button_获得客户名称 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textbox_输入员 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.服务类型 = New System.Windows.Forms.ComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TextBox_保修到期 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.历史消息 = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel_消息输入管理 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.便条 = New System.Windows.Forms.TextBox()
        Me.用户名 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.附件管理 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_产品编号 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_上门方式 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_故障类别 = New System.Windows.Forms.TextBox()
        Me.附件菜单 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开附件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DatagridviewEx1 = New DatagridviewEx.DatagridviewEx()
        Me.Panel8.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_消息输入管理.SuspendLayout()
        Me.附件菜单.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 501)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(592, 22)
        Me.StatusStrip1.TabIndex = 65
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_标题
        '
        Me.lbl_标题.AutoSize = True
        Me.lbl_标题.BackColor = System.Drawing.Color.Transparent
        Me.lbl_标题.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_标题.ForeColor = System.Drawing.Color.White
        Me.lbl_标题.Location = New System.Drawing.Point(12, 9)
        Me.lbl_标题.Name = "lbl_标题"
        Me.lbl_标题.Size = New System.Drawing.Size(114, 19)
        Me.lbl_标题.TabIndex = 1
        Me.lbl_标题.Text = "售后服务单"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.ToolStrip1)
        Me.Panel8.Controls.Add(Me.lbl_标题)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(592, 67)
        Me.Panel8.TabIndex = 60
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_保存, Me.ToolStripLabel1, Me.Tool_业务类型录入, Me.ToolStrip_作废, Me.ToolStrip_退出})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 42)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(592, 25)
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel1.Text = "客户问答"
        '
        'Tool_业务类型录入
        '
        Me.Tool_业务类型录入.Image = CType(resources.GetObject("Tool_业务类型录入.Image"), System.Drawing.Image)
        Me.Tool_业务类型录入.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_业务类型录入.Name = "Tool_业务类型录入"
        Me.Tool_业务类型录入.Size = New System.Drawing.Size(116, 22)
        Me.Tool_业务类型录入.Text = "服务类型录入(&B)"
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
        Me.ToolStrip_退出.Text = "退出(&T)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RicherTextBox_Note)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 361)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 140)
        Me.Panel1.TabIndex = 63
        '
        'RicherTextBox_Note
        '
        Me.RicherTextBox_Note.AlignCenterVisible = True
        Me.RicherTextBox_Note.AlignLeftVisible = True
        Me.RicherTextBox_Note.AlignRightVisible = True
        Me.RicherTextBox_Note.BoldVisible = True
        Me.RicherTextBox_Note.BulletsVisible = False
        Me.RicherTextBox_Note.ChooseFontVisible = True
        Me.RicherTextBox_Note.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RicherTextBox_Note.FontColorVisible = True
        Me.RicherTextBox_Note.FontFamilyVisible = True
        Me.RicherTextBox_Note.FontSizeVisible = True
        Me.RicherTextBox_Note.GroupAlignmentVisible = True
        Me.RicherTextBox_Note.GroupBoldUnderlineItalicVisible = True
        Me.RicherTextBox_Note.GroupFontColorVisible = True
        Me.RicherTextBox_Note.GroupFontNameAndSizeVisible = True
        Me.RicherTextBox_Note.GroupIndentationAndBulletsVisible = False
        Me.RicherTextBox_Note.GroupInsertVisible = False
        Me.RicherTextBox_Note.GroupSaveAndLoadVisible = True
        Me.RicherTextBox_Note.GroupZoomVisible = False
        Me.RicherTextBox_Note.INDENT = 10
        Me.RicherTextBox_Note.IndentVisible = True
        Me.RicherTextBox_Note.InsertPictureVisible = False
        Me.RicherTextBox_Note.ItalicVisible = True
        Me.RicherTextBox_Note.LoadVisible = True
        Me.RicherTextBox_Note.Location = New System.Drawing.Point(0, 3)
        Me.RicherTextBox_Note.Name = "RicherTextBox_Note"
        Me.RicherTextBox_Note.OutdentVisible = False
        Me.RicherTextBox_Note.Rtf = "{\rtf1\ansi\ansicpg936\deff0\deflang1033\deflangfe2052{\fonttbl{\f0\fnil\fcharset" &
    "204 Microsoft Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang2052\f0\fs18\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RicherTextBox_Note.SaveVisible = True
        Me.RicherTextBox_Note.SeparatorAlignVisible = True
        Me.RicherTextBox_Note.SeparatorBoldUnderlineItalicVisible = True
        Me.RicherTextBox_Note.SeparatorFontColorVisible = True
        Me.RicherTextBox_Note.SeparatorFontVisible = True
        Me.RicherTextBox_Note.SeparatorIndentAndBulletsVisible = False
        Me.RicherTextBox_Note.SeparatorInsertVisible = False
        Me.RicherTextBox_Note.SeparatorSaveLoadVisible = True
        Me.RicherTextBox_Note.Size = New System.Drawing.Size(592, 137)
        Me.RicherTextBox_Note.TabIndex = 64
        Me.RicherTextBox_Note.ToolStripVisible = True
        Me.RicherTextBox_Note.UnderlineVisible = True
        Me.RicherTextBox_Note.WordWrapVisible = True
        Me.RicherTextBox_Note.ZoomFactorTextVisible = False
        Me.RicherTextBox_Note.ZoomInVisible = False
        Me.RicherTextBox_Note.ZoomOutVisible = False
        Me.RicherTextBox_Note.修改flag = False
        '
        'lbl_对方名称
        '
        Me.lbl_对方名称.AutoSize = True
        Me.lbl_对方名称.Location = New System.Drawing.Point(14, 15)
        Me.lbl_对方名称.Name = "lbl_对方名称"
        Me.lbl_对方名称.Size = New System.Drawing.Size(65, 12)
        Me.lbl_对方名称.TabIndex = 55
        Me.lbl_对方名称.Text = "单位名称："
        '
        'textbox_客户名称
        '
        Me.textbox_客户名称.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox_客户名称.Location = New System.Drawing.Point(76, 11)
        Me.textbox_客户名称.Name = "textbox_客户名称"
        Me.textbox_客户名称.ReadOnly = True
        Me.textbox_客户名称.Size = New System.Drawing.Size(207, 21)
        Me.textbox_客户名称.TabIndex = 67
        '
        'lbl_日期
        '
        Me.lbl_日期.AutoSize = True
        Me.lbl_日期.ForeColor = System.Drawing.Color.Black
        Me.lbl_日期.Location = New System.Drawing.Point(931, 251)
        Me.lbl_日期.Name = "lbl_日期"
        Me.lbl_日期.Size = New System.Drawing.Size(65, 12)
        Me.lbl_日期.TabIndex = 57
        Me.lbl_日期.Text = "录单日期："
        Me.lbl_日期.Visible = False
        '
        '日期
        '
        Me.日期.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.日期.Enabled = False
        Me.日期.Location = New System.Drawing.Point(1001, 277)
        Me.日期.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.日期.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.日期.Name = "日期"
        Me.日期.Size = New System.Drawing.Size(70, 21)
        Me.日期.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(289, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "单号："
        '
        'txt_单号
        '
        Me.txt_单号.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_单号.Location = New System.Drawing.Point(326, 13)
        Me.txt_单号.Name = "txt_单号"
        Me.txt_单号.ReadOnly = True
        Me.txt_单号.Size = New System.Drawing.Size(233, 21)
        Me.txt_单号.TabIndex = 61
        '
        'lbl_联系人
        '
        Me.lbl_联系人.AutoSize = True
        Me.lbl_联系人.Location = New System.Drawing.Point(29, 74)
        Me.lbl_联系人.Name = "lbl_联系人"
        Me.lbl_联系人.Size = New System.Drawing.Size(53, 12)
        Me.lbl_联系人.TabIndex = 63
        Me.lbl_联系人.Text = "联系人："
        '
        'txt_联系人
        '
        Me.txt_联系人.Location = New System.Drawing.Point(76, 69)
        Me.txt_联系人.Name = "txt_联系人"
        Me.txt_联系人.ReadOnly = True
        Me.txt_联系人.Size = New System.Drawing.Size(86, 21)
        Me.txt_联系人.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1065, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "地址："
        Me.Label6.Visible = False
        '
        'txt_地址
        '
        Me.txt_地址.Location = New System.Drawing.Point(1112, 242)
        Me.txt_地址.Name = "txt_地址"
        Me.txt_地址.ReadOnly = True
        Me.txt_地址.Size = New System.Drawing.Size(131, 21)
        Me.txt_地址.TabIndex = 65
        Me.txt_地址.Visible = False
        '
        'button_获得客户名称
        '
        Me.button_获得客户名称.Location = New System.Drawing.Point(260, 13)
        Me.button_获得客户名称.Name = "button_获得客户名称"
        Me.button_获得客户名称.Size = New System.Drawing.Size(21, 17)
        Me.button_获得客户名称.TabIndex = 56
        Me.button_获得客户名称.Text = "…"
        Me.button_获得客户名称.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1142, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "输入员："
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(944, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "服务类型："
        Me.Label2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(168, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "电话："
        '
        'textbox_输入员
        '
        Me.textbox_输入员.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox_输入员.Location = New System.Drawing.Point(1201, 291)
        Me.textbox_输入员.Name = "textbox_输入员"
        Me.textbox_输入员.ReadOnly = True
        Me.textbox_输入员.Size = New System.Drawing.Size(86, 21)
        Me.textbox_输入员.TabIndex = 68
        Me.textbox_输入员.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(206, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(79, 21)
        Me.TextBox1.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "机床编码："
        '
        '服务类型
        '
        Me.服务类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.服务类型.FormattingEnabled = True
        Me.服务类型.Location = New System.Drawing.Point(1035, 211)
        Me.服务类型.Name = "服务类型"
        Me.服务类型.Size = New System.Drawing.Size(96, 20)
        Me.服务类型.TabIndex = 74
        Me.服务类型.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.TextBox_保修到期)
        Me.Panel9.Controls.Add(Me.TextBox4)
        Me.Panel9.Controls.Add(Me.历史消息)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.Button3)
        Me.Panel9.Controls.Add(Me.TextBox2)
        Me.Panel9.Controls.Add(Me.Panel2)
        Me.Panel9.Controls.Add(Me.Label12)
        Me.Panel9.Controls.Add(Me.TextBox3)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.txt_产品编号)
        Me.Panel9.Controls.Add(Me.ComboBox_上门方式)
        Me.Panel9.Controls.Add(Me.服务类型)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.TextBox1)
        Me.Panel9.Controls.Add(Me.textbox_输入员)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.button_获得客户名称)
        Me.Panel9.Controls.Add(Me.txt_地址)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.txt_联系人)
        Me.Panel9.Controls.Add(Me.lbl_联系人)
        Me.Panel9.Controls.Add(Me.TextBox_故障类别)
        Me.Panel9.Controls.Add(Me.txt_单号)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.日期)
        Me.Panel9.Controls.Add(Me.lbl_日期)
        Me.Panel9.Controls.Add(Me.textbox_客户名称)
        Me.Panel9.Controls.Add(Me.lbl_对方名称)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 67)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(592, 158)
        Me.Panel9.TabIndex = 62
        '
        'TextBox_保修到期
        '
        Me.TextBox_保修到期.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_保修到期.Location = New System.Drawing.Point(326, 37)
        Me.TextBox_保修到期.Name = "TextBox_保修到期"
        Me.TextBox_保修到期.ReadOnly = True
        Me.TextBox_保修到期.Size = New System.Drawing.Size(233, 21)
        Me.TextBox_保修到期.TabIndex = 68
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(473, 67)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(86, 21)
        Me.TextBox4.TabIndex = 84
        '
        '历史消息
        '
        Me.历史消息.BackColor = System.Drawing.Color.GhostWhite
        Me.历史消息.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.历史消息.CausesValidation = False
        Me.历史消息.ForeColor = System.Drawing.Color.Blue
        Me.历史消息.Location = New System.Drawing.Point(889, 206)
        Me.历史消息.Name = "历史消息"
        Me.历史消息.ReadOnly = True
        Me.历史消息.Size = New System.Drawing.Size(45, 73)
        Me.历史消息.TabIndex = 63
        Me.历史消息.Text = ""
        Me.历史消息.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(437, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "职位："
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(466, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 25)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "客户问答"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.Location = New System.Drawing.Point(350, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 21)
        Me.TextBox2.TabIndex = 81
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel_消息输入管理)
        Me.Panel2.Controls.Add(Me.附件管理)
        Me.Panel2.Location = New System.Drawing.Point(837, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(47, 66)
        Me.Panel2.TabIndex = 66
        Me.Panel2.Visible = False
        '
        'Panel_消息输入管理
        '
        Me.Panel_消息输入管理.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_消息输入管理.Controls.Add(Me.LinkLabel1)
        Me.Panel_消息输入管理.Controls.Add(Me.便条)
        Me.Panel_消息输入管理.Controls.Add(Me.用户名)
        Me.Panel_消息输入管理.Controls.Add(Me.Label5)
        Me.Panel_消息输入管理.Controls.Add(Me.Label7)
        Me.Panel_消息输入管理.Controls.Add(Me.Button1)
        Me.Panel_消息输入管理.Location = New System.Drawing.Point(0, 70)
        Me.Panel_消息输入管理.Name = "Panel_消息输入管理"
        Me.Panel_消息输入管理.Size = New System.Drawing.Size(100, 40)
        Me.Panel_消息输入管理.TabIndex = 62
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(143, 13)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "(设自动)"
        '
        '便条
        '
        Me.便条.Location = New System.Drawing.Point(230, 8)
        Me.便条.Name = "便条"
        Me.便条.Size = New System.Drawing.Size(333, 21)
        Me.便条.TabIndex = 16
        '
        '用户名
        '
        Me.用户名.DropDownHeight = 606
        Me.用户名.DropDownWidth = 600
        Me.用户名.FormattingEnabled = True
        Me.用户名.IntegralHeight = False
        Me.用户名.ItemHeight = 12
        Me.用户名.Location = New System.Drawing.Point(52, 9)
        Me.用户名.Name = "用户名"
        Me.用户名.Size = New System.Drawing.Size(91, 20)
        Me.用户名.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(196, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "便条："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "发送给："
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "发送"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '附件管理
        '
        Me.附件管理.AutoScroll = True
        Me.附件管理.AutoScrollMargin = New System.Drawing.Size(750, 50)
        Me.附件管理.BackColor = System.Drawing.Color.WhiteSmoke
        Me.附件管理.Dock = System.Windows.Forms.DockStyle.Top
        Me.附件管理.Location = New System.Drawing.Point(0, 0)
        Me.附件管理.Margin = New System.Windows.Forms.Padding(0)
        Me.附件管理.Name = "附件管理"
        Me.附件管理.Size = New System.Drawing.Size(47, 10)
        Me.附件管理.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(291, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "电话："
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(350, 67)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(82, 21)
        Me.TextBox3.TabIndex = 79
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(291, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "报修人："
        '
        'txt_产品编号
        '
        Me.txt_产品编号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_产品编号.FormattingEnabled = True
        Me.txt_产品编号.Location = New System.Drawing.Point(76, 37)
        Me.txt_产品编号.Name = "txt_产品编号"
        Me.txt_产品编号.Size = New System.Drawing.Size(207, 20)
        Me.txt_产品编号.TabIndex = 75
        '
        'ComboBox_上门方式
        '
        Me.ComboBox_上门方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_上门方式.FormattingEnabled = True
        Me.ComboBox_上门方式.Items.AddRange(New Object() {"上门服务", "电话服务"})
        Me.ComboBox_上门方式.Location = New System.Drawing.Point(77, 96)
        Me.ComboBox_上门方式.Name = "ComboBox_上门方式"
        Me.ComboBox_上门方式.Size = New System.Drawing.Size(207, 20)
        Me.ComboBox_上门方式.TabIndex = 74
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(289, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "质保："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "方式："
        '
        'TextBox_故障类别
        '
        Me.TextBox_故障类别.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_故障类别.Location = New System.Drawing.Point(837, 248)
        Me.TextBox_故障类别.Name = "TextBox_故障类别"
        Me.TextBox_故障类别.ReadOnly = True
        Me.TextBox_故障类别.Size = New System.Drawing.Size(51, 21)
        Me.TextBox_故障类别.TabIndex = 61
        Me.TextBox_故障类别.Visible = False
        '
        '附件菜单
        '
        Me.附件菜单.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开附件ToolStripMenuItem})
        Me.附件菜单.Name = "附件菜单"
        Me.附件菜单.Size = New System.Drawing.Size(134, 26)
        '
        '打开附件ToolStripMenuItem
        '
        Me.打开附件ToolStripMenuItem.Name = "打开附件ToolStripMenuItem"
        Me.打开附件ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.打开附件ToolStripMenuItem.Text = "打开附件..."
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DatagridviewEx1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 225)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 136)
        Me.Panel3.TabIndex = 66
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
        Me.DatagridviewEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewEx1.GridColor = System.Drawing.Color.Silver
        Me.DatagridviewEx1.Location = New System.Drawing.Point(0, 0)
        Me.DatagridviewEx1.Name = "DatagridviewEx1"
        Me.DatagridviewEx1.ReadOnly = True
        Me.DatagridviewEx1.RowHeadersVisible = False
        Me.DatagridviewEx1.RowHeadersWidth = 20
        Me.DatagridviewEx1.RowTemplate.Height = 23
        Me.DatagridviewEx1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridviewEx1.Size = New System.Drawing.Size(592, 136)
        Me.DatagridviewEx1.TabIndex = 84
        Me.DatagridviewEx1.当前用户名 = Nothing
        Me.DatagridviewEx1.管理列的对应表名称 = ""
        Me.DatagridviewEx1.管理列的控件库名称 = "历史维修记录"
        '
        '售后服务单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 523)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "售后服务单"
        Me.Text = "售后服务单"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_消息输入管理.ResumeLayout(False)
        Me.Panel_消息输入管理.PerformLayout()
        Me.附件菜单.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_标题 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_保存 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_业务类型录入 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip_作废 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip_退出 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RicherTextBox_Note As RicherTextBox.RicherTextBox
    Friend WithEvents lbl_对方名称 As System.Windows.Forms.Label
    Friend WithEvents textbox_客户名称 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_日期 As System.Windows.Forms.Label
    Friend WithEvents 日期 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_单号 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_联系人 As System.Windows.Forms.Label
    Friend WithEvents txt_联系人 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_地址 As System.Windows.Forms.TextBox
    Private WithEvents button_获得客户名称 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textbox_输入员 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents 服务类型 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents 历史消息 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel_消息输入管理 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents 便条 As System.Windows.Forms.TextBox
    Friend WithEvents 用户名 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents 附件菜单 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 打开附件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 附件管理 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_产品编号 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_故障类别 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_上门方式 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_保修到期 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DatagridviewEx1 As DatagridviewEx.DatagridviewEx
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
