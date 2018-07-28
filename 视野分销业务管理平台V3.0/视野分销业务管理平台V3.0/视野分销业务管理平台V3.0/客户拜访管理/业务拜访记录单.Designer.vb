<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 业务拜访记录单
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(业务拜访记录单))
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_保存 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_反审核 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_作废 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_业务类型录入 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_备注项录入 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_历史记录查询 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_退出 = New System.Windows.Forms.ToolStripButton()
        Me.lbl_标题 = New System.Windows.Forms.Label()
        Me.Panel_修改 = New System.Windows.Forms.Panel()
        Me.Button_隐藏修改 = New System.Windows.Forms.Button()
        Me.Button_修改 = New System.Windows.Forms.Button()
        Me.TextBox_修改客户信息 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DateTimePicker_下次拜访日期 = New System.Windows.Forms.DateTimePicker()
        Me.Combo_拜访日期 = New System.Windows.Forms.DateTimePicker()
        Me.button_获得客户名称 = New System.Windows.Forms.Button()
        Me.GroupBox_客户信息 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox_模具生产人数 = New System.Windows.Forms.TextBox()
        Me.TextBox_辐射范围 = New System.Windows.Forms.TextBox()
        Me.TextBox_现有设备品牌 = New System.Windows.Forms.TextBox()
        Me.TextBox_模具精度要求 = New System.Windows.Forms.TextBox()
        Me.TextBox_客户区域 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox_现有快走丝数 = New System.Windows.Forms.TextBox()
        Me.TextBox_信誉状态 = New System.Windows.Forms.TextBox()
        Me.TextBox_年销售额加工 = New System.Windows.Forms.TextBox()
        Me.TextBox_经营项目 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_客户类型 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox_客户等级 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox_是否外加工 = New System.Windows.Forms.TextBox()
        Me.TextBox_现有设备使用情况 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_地址 = New System.Windows.Forms.TextBox()
        Me.TextBox_现有中走丝数量 = New System.Windows.Forms.TextBox()
        Me.TextBox_设备需求情况 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_联系人职务 = New System.Windows.Forms.TextBox()
        Me.TextBox_联系人电话 = New System.Windows.Forms.TextBox()
        Me.TextBox_联系人 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox_备注项 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_业务类型 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_拜访方式 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_客户类型 = New System.Windows.Forms.ComboBox()
        Me.textbox_输入员 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textbox_客户名称 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RicherTextBox_Note = New RicherTextBox.RicherTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_审核状态 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_日报单号 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox_客户信息描述 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel_修改.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox_客户信息.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.Label28)
        Me.Panel8.Controls.Add(Me.ToolStrip1)
        Me.Panel8.Controls.Add(Me.lbl_标题)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1061, 67)
        Me.Panel8.TabIndex = 60
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_保存, Me.ToolStripButton1, Me.ToolStrip_反审核, Me.ToolStrip_作废, Me.Tool_业务类型录入, Me.ToolStrip_备注项录入, Me.Tool_历史记录查询, Me.ToolStrip_退出})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 42)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1061, 25)
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripButton1.Text = "审核..."
        '
        'ToolStrip_反审核
        '
        Me.ToolStrip_反审核.Image = CType(resources.GetObject("ToolStrip_反审核.Image"), System.Drawing.Image)
        Me.ToolStrip_反审核.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_反审核.Name = "ToolStrip_反审核"
        Me.ToolStrip_反审核.Size = New System.Drawing.Size(73, 22)
        Me.ToolStrip_反审核.Text = "反审核..."
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
        'Tool_业务类型录入
        '
        Me.Tool_业务类型录入.Image = CType(resources.GetObject("Tool_业务类型录入.Image"), System.Drawing.Image)
        Me.Tool_业务类型录入.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_业务类型录入.Name = "Tool_业务类型录入"
        Me.Tool_业务类型录入.Size = New System.Drawing.Size(116, 22)
        Me.Tool_业务类型录入.Text = "业务类型录入(&B)"
        '
        'ToolStrip_备注项录入
        '
        Me.ToolStrip_备注项录入.Image = CType(resources.GetObject("ToolStrip_备注项录入.Image"), System.Drawing.Image)
        Me.ToolStrip_备注项录入.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_备注项录入.Name = "ToolStrip_备注项录入"
        Me.ToolStrip_备注项录入.Size = New System.Drawing.Size(104, 22)
        Me.ToolStrip_备注项录入.Text = "备注项录入(&B)"
        '
        'Tool_历史记录查询
        '
        Me.Tool_历史记录查询.Image = CType(resources.GetObject("Tool_历史记录查询.Image"), System.Drawing.Image)
        Me.Tool_历史记录查询.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_历史记录查询.Name = "Tool_历史记录查询"
        Me.Tool_历史记录查询.Size = New System.Drawing.Size(115, 22)
        Me.Tool_历史记录查询.Text = "历史记录查询(&T)"
        '
        'ToolStrip_退出
        '
        Me.ToolStrip_退出.Image = CType(resources.GetObject("ToolStrip_退出.Image"), System.Drawing.Image)
        Me.ToolStrip_退出.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_退出.Name = "ToolStrip_退出"
        Me.ToolStrip_退出.Size = New System.Drawing.Size(67, 22)
        Me.ToolStrip_退出.Text = "退出(&T)"
        '
        'lbl_标题
        '
        Me.lbl_标题.AutoSize = True
        Me.lbl_标题.BackColor = System.Drawing.Color.Transparent
        Me.lbl_标题.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_标题.ForeColor = System.Drawing.Color.White
        Me.lbl_标题.Location = New System.Drawing.Point(12, 9)
        Me.lbl_标题.Name = "lbl_标题"
        Me.lbl_标题.Size = New System.Drawing.Size(93, 19)
        Me.lbl_标题.TabIndex = 1
        Me.lbl_标题.Text = "业务录入"
        '
        'Panel_修改
        '
        Me.Panel_修改.BackColor = System.Drawing.Color.LightCyan
        Me.Panel_修改.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_修改.Controls.Add(Me.Button_隐藏修改)
        Me.Panel_修改.Controls.Add(Me.Button_修改)
        Me.Panel_修改.Controls.Add(Me.TextBox_修改客户信息)
        Me.Panel_修改.Location = New System.Drawing.Point(243, 57)
        Me.Panel_修改.Name = "Panel_修改"
        Me.Panel_修改.Size = New System.Drawing.Size(574, 48)
        Me.Panel_修改.TabIndex = 70
        Me.Panel_修改.Visible = False
        '
        'Button_隐藏修改
        '
        Me.Button_隐藏修改.Location = New System.Drawing.Point(511, 5)
        Me.Button_隐藏修改.Name = "Button_隐藏修改"
        Me.Button_隐藏修改.Size = New System.Drawing.Size(58, 38)
        Me.Button_隐藏修改.TabIndex = 71
        Me.Button_隐藏修改.Text = "退出"
        Me.Button_隐藏修改.UseVisualStyleBackColor = True
        '
        'Button_修改
        '
        Me.Button_修改.Location = New System.Drawing.Point(449, 5)
        Me.Button_修改.Name = "Button_修改"
        Me.Button_修改.Size = New System.Drawing.Size(58, 38)
        Me.Button_修改.TabIndex = 71
        Me.Button_修改.Text = "保存"
        Me.Button_修改.UseVisualStyleBackColor = True
        '
        'TextBox_修改客户信息
        '
        Me.TextBox_修改客户信息.Location = New System.Drawing.Point(7, 4)
        Me.TextBox_修改客户信息.Multiline = True
        Me.TextBox_修改客户信息.Name = "TextBox_修改客户信息"
        Me.TextBox_修改客户信息.Size = New System.Drawing.Size(438, 37)
        Me.TextBox_修改客户信息.TabIndex = 70
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.DateTimePicker_下次拜访日期)
        Me.Panel9.Controls.Add(Me.Combo_拜访日期)
        Me.Panel9.Controls.Add(Me.button_获得客户名称)
        Me.Panel9.Controls.Add(Me.GroupBox_客户信息)
        Me.Panel9.Controls.Add(Me.ComboBox_备注项)
        Me.Panel9.Controls.Add(Me.ComboBox_业务类型)
        Me.Panel9.Controls.Add(Me.ComboBox_拜访方式)
        Me.Panel9.Controls.Add(Me.ComboBox_客户类型)
        Me.Panel9.Controls.Add(Me.textbox_输入员)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.textbox_客户名称)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Controls.Add(Me.label4)
        Me.Panel9.Controls.Add(Me.label3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 67)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1061, 234)
        Me.Panel9.TabIndex = 62
        '
        'DateTimePicker_下次拜访日期
        '
        Me.DateTimePicker_下次拜访日期.Location = New System.Drawing.Point(875, 43)
        Me.DateTimePicker_下次拜访日期.Name = "DateTimePicker_下次拜访日期"
        Me.DateTimePicker_下次拜访日期.Size = New System.Drawing.Size(150, 21)
        Me.DateTimePicker_下次拜访日期.TabIndex = 3
        '
        'Combo_拜访日期
        '
        Me.Combo_拜访日期.Location = New System.Drawing.Point(587, 12)
        Me.Combo_拜访日期.Name = "Combo_拜访日期"
        Me.Combo_拜访日期.Size = New System.Drawing.Size(176, 21)
        Me.Combo_拜访日期.TabIndex = 3
        '
        'button_获得客户名称
        '
        Me.button_获得客户名称.Location = New System.Drawing.Point(484, 14)
        Me.button_获得客户名称.Name = "button_获得客户名称"
        Me.button_获得客户名称.Size = New System.Drawing.Size(21, 17)
        Me.button_获得客户名称.TabIndex = 55
        Me.button_获得客户名称.Text = "…"
        Me.button_获得客户名称.UseVisualStyleBackColor = True
        '
        'GroupBox_客户信息
        '
        Me.GroupBox_客户信息.Controls.Add(Me.Label24)
        Me.GroupBox_客户信息.Controls.Add(Me.Label8)
        Me.GroupBox_客户信息.Controls.Add(Me.Panel_修改)
        Me.GroupBox_客户信息.Controls.Add(Me.Label25)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_模具生产人数)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_辐射范围)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_现有设备品牌)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_模具精度要求)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_客户区域)
        Me.GroupBox_客户信息.Controls.Add(Me.Label26)
        Me.GroupBox_客户信息.Controls.Add(Me.Label33)
        Me.GroupBox_客户信息.Controls.Add(Me.Label27)
        Me.GroupBox_客户信息.Controls.Add(Me.Label32)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_现有快走丝数)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_信誉状态)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_年销售额加工)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_经营项目)
        Me.GroupBox_客户信息.Controls.Add(Me.Label29)
        Me.GroupBox_客户信息.Controls.Add(Me.Label30)
        Me.GroupBox_客户信息.Controls.Add(Me.Label6)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_客户类型)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox11)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_客户等级)
        Me.GroupBox_客户信息.Controls.Add(Me.Label23)
        Me.GroupBox_客户信息.Controls.Add(Me.Label19)
        Me.GroupBox_客户信息.Controls.Add(Me.Label15)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox14)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_是否外加工)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_现有设备使用情况)
        Me.GroupBox_客户信息.Controls.Add(Me.Label22)
        Me.GroupBox_客户信息.Controls.Add(Me.Label18)
        Me.GroupBox_客户信息.Controls.Add(Me.Label13)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_地址)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_现有中走丝数量)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_设备需求情况)
        Me.GroupBox_客户信息.Controls.Add(Me.Label21)
        Me.GroupBox_客户信息.Controls.Add(Me.Label17)
        Me.GroupBox_客户信息.Controls.Add(Me.Label12)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_联系人职务)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_联系人电话)
        Me.GroupBox_客户信息.Controls.Add(Me.TextBox_联系人)
        Me.GroupBox_客户信息.Controls.Add(Me.Label20)
        Me.GroupBox_客户信息.Controls.Add(Me.Label16)
        Me.GroupBox_客户信息.Controls.Add(Me.Label11)
        Me.GroupBox_客户信息.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox_客户信息.Name = "GroupBox_客户信息"
        Me.GroupBox_客户信息.Size = New System.Drawing.Size(1032, 163)
        Me.GroupBox_客户信息.TabIndex = 71
        Me.GroupBox_客户信息.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(8, 137)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 12)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "现有设备品牌："
        Me.Label24.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 12)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "模具生产人数："
        Me.Label8.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(528, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 12)
        Me.Label25.TabIndex = 82
        Me.Label25.Text = "客户区域："
        '
        'TextBox_模具生产人数
        '
        Me.TextBox_模具生产人数.Location = New System.Drawing.Point(93, 100)
        Me.TextBox_模具生产人数.Name = "TextBox_模具生产人数"
        Me.TextBox_模具生产人数.ReadOnly = True
        Me.TextBox_模具生产人数.Size = New System.Drawing.Size(98, 21)
        Me.TextBox_模具生产人数.TabIndex = 92
        Me.TextBox_模具生产人数.Visible = False
        '
        'TextBox_辐射范围
        '
        Me.TextBox_辐射范围.Location = New System.Drawing.Point(599, 137)
        Me.TextBox_辐射范围.Name = "TextBox_辐射范围"
        Me.TextBox_辐射范围.ReadOnly = True
        Me.TextBox_辐射范围.Size = New System.Drawing.Size(96, 21)
        Me.TextBox_辐射范围.TabIndex = 89
        Me.TextBox_辐射范围.Visible = False
        '
        'TextBox_现有设备品牌
        '
        Me.TextBox_现有设备品牌.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_现有设备品牌.Location = New System.Drawing.Point(93, 131)
        Me.TextBox_现有设备品牌.Name = "TextBox_现有设备品牌"
        Me.TextBox_现有设备品牌.ReadOnly = True
        Me.TextBox_现有设备品牌.Size = New System.Drawing.Size(161, 21)
        Me.TextBox_现有设备品牌.TabIndex = 90
        Me.TextBox_现有设备品牌.Visible = False
        '
        'TextBox_模具精度要求
        '
        Me.TextBox_模具精度要求.Location = New System.Drawing.Point(284, 102)
        Me.TextBox_模具精度要求.Name = "TextBox_模具精度要求"
        Me.TextBox_模具精度要求.ReadOnly = True
        Me.TextBox_模具精度要求.Size = New System.Drawing.Size(133, 21)
        Me.TextBox_模具精度要求.TabIndex = 91
        Me.TextBox_模具精度要求.Visible = False
        '
        'TextBox_客户区域
        '
        Me.TextBox_客户区域.Location = New System.Drawing.Point(599, 20)
        Me.TextBox_客户区域.Name = "TextBox_客户区域"
        Me.TextBox_客户区域.ReadOnly = True
        Me.TextBox_客户区域.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_客户区域.TabIndex = 87
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(528, 86)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 12)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "现有快走丝数："
        Me.Label26.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(528, 140)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 12)
        Me.Label33.TabIndex = 72
        Me.Label33.Text = "辐射范围："
        Me.Label33.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(261, 140)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 12)
        Me.Label27.TabIndex = 73
        Me.Label27.Text = "年销售额加工"
        Me.Label27.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(199, 105)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(89, 12)
        Me.Label32.TabIndex = 76
        Me.Label32.Text = "模具精度要求："
        Me.Label32.Visible = False
        '
        'TextBox_现有快走丝数
        '
        Me.TextBox_现有快走丝数.Location = New System.Drawing.Point(612, 78)
        Me.TextBox_现有快走丝数.Name = "TextBox_现有快走丝数"
        Me.TextBox_现有快走丝数.ReadOnly = True
        Me.TextBox_现有快走丝数.Size = New System.Drawing.Size(74, 21)
        Me.TextBox_现有快走丝数.TabIndex = 93
        Me.TextBox_现有快走丝数.Visible = False
        '
        'TextBox_信誉状态
        '
        Me.TextBox_信誉状态.Location = New System.Drawing.Point(789, 137)
        Me.TextBox_信誉状态.Name = "TextBox_信誉状态"
        Me.TextBox_信誉状态.ReadOnly = True
        Me.TextBox_信誉状态.Size = New System.Drawing.Size(98, 21)
        Me.TextBox_信誉状态.TabIndex = 85
        Me.TextBox_信誉状态.Visible = False
        '
        'TextBox_年销售额加工
        '
        Me.TextBox_年销售额加工.Location = New System.Drawing.Point(340, 135)
        Me.TextBox_年销售额加工.Name = "TextBox_年销售额加工"
        Me.TextBox_年销售额加工.ReadOnly = True
        Me.TextBox_年销售额加工.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_年销售额加工.TabIndex = 84
        Me.TextBox_年销售额加工.Visible = False
        '
        'TextBox_经营项目
        '
        Me.TextBox_经营项目.Location = New System.Drawing.Point(332, 77)
        Me.TextBox_经营项目.Name = "TextBox_经营项目"
        Me.TextBox_经营项目.ReadOnly = True
        Me.TextBox_经营项目.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_经营项目.TabIndex = 86
        Me.TextBox_经营项目.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(261, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 12)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "经营项目："
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(730, 140)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 12)
        Me.Label30.TabIndex = 78
        Me.Label30.Text = "信誉状态"
        Me.Label30.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 12)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "-"
        '
        'TextBox_客户类型
        '
        Me.TextBox_客户类型.Location = New System.Drawing.Point(874, 23)
        Me.TextBox_客户类型.Name = "TextBox_客户类型"
        Me.TextBox_客户类型.ReadOnly = True
        Me.TextBox_客户类型.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_客户类型.TabIndex = 69
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(874, 57)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(171, 21)
        Me.TextBox11.TabIndex = 69
        Me.TextBox11.Visible = False
        '
        'TextBox_客户等级
        '
        Me.TextBox_客户等级.Location = New System.Drawing.Point(330, 17)
        Me.TextBox_客户等级.Name = "TextBox_客户等级"
        Me.TextBox_客户等级.ReadOnly = True
        Me.TextBox_客户等级.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_客户等级.TabIndex = 69
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(803, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 12)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "客户类型："
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(803, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 12)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "客户存档1："
        Me.Label19.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(259, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 12)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "客户等级："
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(599, 51)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(171, 21)
        Me.TextBox14.TabIndex = 69
        '
        'TextBox_是否外加工
        '
        Me.TextBox_是否外加工.Location = New System.Drawing.Point(981, 81)
        Me.TextBox_是否外加工.Name = "TextBox_是否外加工"
        Me.TextBox_是否外加工.ReadOnly = True
        Me.TextBox_是否外加工.Size = New System.Drawing.Size(40, 21)
        Me.TextBox_是否外加工.TabIndex = 69
        Me.TextBox_是否外加工.Visible = False
        '
        'TextBox_现有设备使用情况
        '
        Me.TextBox_现有设备使用情况.Location = New System.Drawing.Point(541, 106)
        Me.TextBox_现有设备使用情况.Name = "TextBox_现有设备使用情况"
        Me.TextBox_现有设备使用情况.ReadOnly = True
        Me.TextBox_现有设备使用情况.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_现有设备使用情况.TabIndex = 69
        Me.TextBox_现有设备使用情况.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(528, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 12)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "客户存档1："
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(905, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 12)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "是否外加工"
        Me.Label18.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(433, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 12)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "现有设备使用情况："
        Me.Label13.Visible = False
        '
        'TextBox_地址
        '
        Me.TextBox_地址.Location = New System.Drawing.Point(80, 71)
        Me.TextBox_地址.Name = "TextBox_地址"
        Me.TextBox_地址.ReadOnly = True
        Me.TextBox_地址.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_地址.TabIndex = 69
        '
        'TextBox_现有中走丝数量
        '
        Me.TextBox_现有中走丝数量.Location = New System.Drawing.Point(805, 83)
        Me.TextBox_现有中走丝数量.Name = "TextBox_现有中走丝数量"
        Me.TextBox_现有中走丝数量.ReadOnly = True
        Me.TextBox_现有中走丝数量.Size = New System.Drawing.Size(94, 21)
        Me.TextBox_现有中走丝数量.TabIndex = 69
        Me.TextBox_现有中走丝数量.Visible = False
        '
        'TextBox_设备需求情况
        '
        Me.TextBox_设备需求情况.Location = New System.Drawing.Point(804, 108)
        Me.TextBox_设备需求情况.Name = "TextBox_设备需求情况"
        Me.TextBox_设备需求情况.ReadOnly = True
        Me.TextBox_设备需求情况.Size = New System.Drawing.Size(182, 21)
        Me.TextBox_设备需求情况.TabIndex = 69
        Me.TextBox_设备需求情况.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(9, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 12)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "地址："
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(707, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 12)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "现有中走丝数量"
        Me.Label17.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(718, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 12)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "设备需求情况："
        Me.Label12.Visible = False
        '
        'TextBox_联系人职务
        '
        Me.TextBox_联系人职务.Location = New System.Drawing.Point(330, 48)
        Me.TextBox_联系人职务.Name = "TextBox_联系人职务"
        Me.TextBox_联系人职务.ReadOnly = True
        Me.TextBox_联系人职务.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_联系人职务.TabIndex = 69
        '
        'TextBox_联系人电话
        '
        Me.TextBox_联系人电话.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_联系人电话.Location = New System.Drawing.Point(80, 45)
        Me.TextBox_联系人电话.Name = "TextBox_联系人电话"
        Me.TextBox_联系人电话.ReadOnly = True
        Me.TextBox_联系人电话.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_联系人电话.TabIndex = 69
        '
        'TextBox_联系人
        '
        Me.TextBox_联系人.Location = New System.Drawing.Point(80, 20)
        Me.TextBox_联系人.Name = "TextBox_联系人"
        Me.TextBox_联系人.ReadOnly = True
        Me.TextBox_联系人.Size = New System.Drawing.Size(171, 21)
        Me.TextBox_联系人.TabIndex = 69
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(259, 51)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 12)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "联系人职务："
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(9, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 12)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "联系人电话："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(9, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "联系人："
        '
        'ComboBox_备注项
        '
        Me.ComboBox_备注项.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_备注项.FormattingEnabled = True
        Me.ComboBox_备注项.Location = New System.Drawing.Point(587, 43)
        Me.ComboBox_备注项.Name = "ComboBox_备注项"
        Me.ComboBox_备注项.Size = New System.Drawing.Size(176, 20)
        Me.ComboBox_备注项.TabIndex = 70
        '
        'ComboBox_业务类型
        '
        Me.ComboBox_业务类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_业务类型.FormattingEnabled = True
        Me.ComboBox_业务类型.Items.AddRange(New Object() {"客户电话回访", "销售业务回访", "售后业务回访", "业务电话回访", "售后电话回访"})
        Me.ComboBox_业务类型.Location = New System.Drawing.Point(323, 44)
        Me.ComboBox_业务类型.Name = "ComboBox_业务类型"
        Me.ComboBox_业务类型.Size = New System.Drawing.Size(182, 20)
        Me.ComboBox_业务类型.TabIndex = 70
        '
        'ComboBox_拜访方式
        '
        Me.ComboBox_拜访方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_拜访方式.FormattingEnabled = True
        Me.ComboBox_拜访方式.Items.AddRange(New Object() {"上门拜访", "电话拜访", "聊天工具", "邮件工具", "其他"})
        Me.ComboBox_拜访方式.Location = New System.Drawing.Point(72, 42)
        Me.ComboBox_拜访方式.Name = "ComboBox_拜访方式"
        Me.ComboBox_拜访方式.Size = New System.Drawing.Size(168, 20)
        Me.ComboBox_拜访方式.TabIndex = 70
        '
        'ComboBox_客户类型
        '
        Me.ComboBox_客户类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_客户类型.FormattingEnabled = True
        Me.ComboBox_客户类型.Location = New System.Drawing.Point(70, 7)
        Me.ComboBox_客户类型.Name = "ComboBox_客户类型"
        Me.ComboBox_客户类型.Size = New System.Drawing.Size(168, 20)
        Me.ComboBox_客户类型.TabIndex = 70
        '
        'textbox_输入员
        '
        Me.textbox_输入员.Location = New System.Drawing.Point(872, 10)
        Me.textbox_输入员.Name = "textbox_输入员"
        Me.textbox_输入员.ReadOnly = True
        Me.textbox_输入员.Size = New System.Drawing.Size(150, 21)
        Me.textbox_输入员.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(540, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "备注项："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(265, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "业务类型："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "拜访方式："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "客户类型："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(827, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "输入员："
        '
        'textbox_客户名称
        '
        Me.textbox_客户名称.Location = New System.Drawing.Point(323, 12)
        Me.textbox_客户名称.Name = "textbox_客户名称"
        Me.textbox_客户名称.ReadOnly = True
        Me.textbox_客户名称.Size = New System.Drawing.Size(184, 21)
        Me.textbox_客户名称.TabIndex = 69
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(791, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 12)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "下次拜访日期："
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(529, 16)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 12)
        Me.label4.TabIndex = 64
        Me.label4.Text = "拜访日期："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(265, 13)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(65, 12)
        Me.label3.TabIndex = 63
        Me.label3.Text = "客户名称："
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RicherTextBox_Note)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 214)
        Me.Panel1.TabIndex = 63
        '
        'RicherTextBox_Note
        '
        Me.RicherTextBox_Note.AlignCenterVisible = True
        Me.RicherTextBox_Note.AlignLeftVisible = True
        Me.RicherTextBox_Note.AlignRightVisible = True
        Me.RicherTextBox_Note.BoldVisible = True
        Me.RicherTextBox_Note.BulletsVisible = True
        Me.RicherTextBox_Note.ChooseFontVisible = True
        Me.RicherTextBox_Note.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.RicherTextBox_Note.Location = New System.Drawing.Point(0, 0)
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
        Me.RicherTextBox_Note.Size = New System.Drawing.Size(1061, 214)
        Me.RicherTextBox_Note.TabIndex = 64
        Me.RicherTextBox_Note.ToolStripVisible = True
        Me.RicherTextBox_Note.UnderlineVisible = True
        Me.RicherTextBox_Note.WordWrapVisible = True
        Me.RicherTextBox_Note.ZoomFactorTextVisible = False
        Me.RicherTextBox_Note.ZoomInVisible = False
        Me.RicherTextBox_Note.ZoomOutVisible = False
        Me.RicherTextBox_Note.修改flag = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Tool_审核状态, Me.ToolStripStatusLabel2, Me.Tool_日报单号})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 591)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1061, 22)
        Me.StatusStrip1.TabIndex = 65
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel1.Text = "审核状态："
        '
        'Tool_审核状态
        '
        Me.Tool_审核状态.Name = "Tool_审核状态"
        Me.Tool_审核状态.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel2.Text = "日报单号："
        '
        'Tool_日报单号
        '
        Me.Tool_日报单号.Name = "Tool_日报单号"
        Me.Tool_日报单号.Size = New System.Drawing.Size(0, 17)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 88)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "客户竞争对手情况说明 ："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TextBox_客户信息描述)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1061, 76)
        Me.Panel2.TabIndex = 74
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(48, 76)
        Me.Panel3.TabIndex = 76
        '
        'TextBox_客户信息描述
        '
        Me.TextBox_客户信息描述.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_客户信息描述.Location = New System.Drawing.Point(54, 6)
        Me.TextBox_客户信息描述.Multiline = True
        Me.TextBox_客户信息描述.Name = "TextBox_客户信息描述"
        Me.TextBox_客户信息描述.ReadOnly = True
        Me.TextBox_客户信息描述.Size = New System.Drawing.Size(1004, 56)
        Me.TextBox_客户信息描述.TabIndex = 69
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(986, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 12)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Label28"
        '
        '业务拜访记录单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 613)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "业务拜访记录单"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "业务拜访记录单"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel_修改.ResumeLayout(False)
        Me.Panel_修改.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.GroupBox_客户信息.ResumeLayout(False)
        Me.GroupBox_客户信息.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lbl_标题 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents textbox_输入员 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textbox_客户名称 As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_客户类型 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RicherTextBox_Note As RicherTextBox.RicherTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_拜访方式 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_备注项 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_业务类型 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox_联系人 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox_客户信息 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_客户等级 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox_是否外加工 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_现有设备使用情况 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox_现有中走丝数量 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_设备需求情况 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox_联系人电话 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox_客户类型 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox_地址 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox_联系人职务 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel_修改 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_修改客户信息 As System.Windows.Forms.TextBox
    Friend WithEvents Button_修改 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_保存 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip_退出 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents button_获得客户名称 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip_备注项录入 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_业务类型录入 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip_作废 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Combo_拜访日期 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_下次拜访日期 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button_隐藏修改 As System.Windows.Forms.Button
    Friend WithEvents Tool_历史记录查询 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox_客户信息描述 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tool_审核状态 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tool_日报单号 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip_反审核 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox_模具生产人数 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_辐射范围 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_现有设备品牌 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_模具精度要求 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_客户区域 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TextBox_现有快走丝数 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_信誉状态 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_年销售额加工 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_经营项目 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
