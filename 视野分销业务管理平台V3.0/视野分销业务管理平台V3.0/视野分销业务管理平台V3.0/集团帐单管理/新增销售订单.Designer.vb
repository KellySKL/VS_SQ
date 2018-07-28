<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 新增销售订单
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(新增销售订单))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_标题 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Tool_保存 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_删行 = New System.Windows.Forms.ToolStripButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TextBox_业务员 = New System.Windows.Forms.TextBox()
        Me.TextBox_客户 = New System.Windows.Forms.TextBox()
        Me.Com_业务类型 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Date结束日期 = New System.Windows.Forms.DateTimePicker()
        Me.Date开始日期 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.关闭 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DatagridviewEx1 = New DatagridviewEx.DatagridviewEx()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.Panel1)
        Me.Panel8.Controls.Add(Me.lbl_标题)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(631, 48)
        Me.Panel8.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(228, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 48)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "视野软件—专注电气细分行业制造信息化"
        '
        'lbl_标题
        '
        Me.lbl_标题.AutoSize = True
        Me.lbl_标题.BackColor = System.Drawing.Color.Transparent
        Me.lbl_标题.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_标题.ForeColor = System.Drawing.Color.White
        Me.lbl_标题.Location = New System.Drawing.Point(12, 15)
        Me.lbl_标题.Name = "lbl_标题"
        Me.lbl_标题.Size = New System.Drawing.Size(135, 19)
        Me.lbl_标题.TabIndex = 1
        Me.lbl_标题.Text = "北元账务调整"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_保存, Me.Tool_删行})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 48)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(631, 25)
        Me.ToolStrip2.TabIndex = 58
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Tool_保存
        '
        Me.Tool_保存.Image = CType(resources.GetObject("Tool_保存.Image"), System.Drawing.Image)
        Me.Tool_保存.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_保存.Name = "Tool_保存"
        Me.Tool_保存.Size = New System.Drawing.Size(52, 22)
        Me.Tool_保存.Text = "保存"
        '
        'Tool_删行
        '
        Me.Tool_删行.Image = CType(resources.GetObject("Tool_删行.Image"), System.Drawing.Image)
        Me.Tool_删行.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_删行.Name = "Tool_删行"
        Me.Tool_删行.Size = New System.Drawing.Size(52, 22)
        Me.Tool_删行.Text = "删行"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.TextBox_业务员)
        Me.Panel9.Controls.Add(Me.TextBox_客户)
        Me.Panel9.Controls.Add(Me.Com_业务类型)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Controls.Add(Me.Date结束日期)
        Me.Panel9.Controls.Add(Me.Date开始日期)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.Label22)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(631, 73)
        Me.Panel9.TabIndex = 59
        '
        'TextBox_业务员
        '
        Me.TextBox_业务员.Location = New System.Drawing.Point(436, 12)
        Me.TextBox_业务员.Name = "TextBox_业务员"
        Me.TextBox_业务员.Size = New System.Drawing.Size(85, 21)
        Me.TextBox_业务员.TabIndex = 70
        '
        'TextBox_客户
        '
        Me.TextBox_客户.Location = New System.Drawing.Point(224, 12)
        Me.TextBox_客户.Name = "TextBox_客户"
        Me.TextBox_客户.Size = New System.Drawing.Size(161, 21)
        Me.TextBox_客户.TabIndex = 69
        '
        'Com_业务类型
        '
        Me.Com_业务类型.FormattingEnabled = True
        Me.Com_业务类型.ItemHeight = 12
        Me.Com_业务类型.Items.AddRange(New Object() {"销售调整", "收款调整", "账务调整"})
        Me.Com_业务类型.Location = New System.Drawing.Point(67, 13)
        Me.Com_业务类型.Name = "Com_业务类型"
        Me.Com_业务类型.Size = New System.Drawing.Size(93, 20)
        Me.Com_业务类型.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "业务类型："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "业务员："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "客户名称："
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(1013, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 10)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Date结束日期
        '
        Me.Date结束日期.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Date结束日期.Location = New System.Drawing.Point(243, 42)
        Me.Date结束日期.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.Date结束日期.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.Date结束日期.Name = "Date结束日期"
        Me.Date结束日期.Size = New System.Drawing.Size(107, 21)
        Me.Date结束日期.TabIndex = 14
        '
        'Date开始日期
        '
        Me.Date开始日期.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Date开始日期.Location = New System.Drawing.Point(67, 42)
        Me.Date开始日期.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.Date开始日期.MinDate = New Date(1899, 12, 31, 0, 0, 0, 0)
        Me.Date开始日期.Name = "Date开始日期"
        Me.Date开始日期.Size = New System.Drawing.Size(107, 21)
        Me.Date开始日期.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "开始日期："
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(180, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 12)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "结束日期："
        '
        '关闭
        '
        Me.关闭.DataPropertyName = "关闭"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "关闭"
        Me.关闭.DefaultCellStyle = DataGridViewCellStyle1
        Me.关闭.HeaderText = "关闭"
        Me.关闭.Name = "关闭"
        Me.关闭.ReadOnly = True
        Me.关闭.Width = 40
        '
        'DatagridviewEx1
        '
        Me.DatagridviewEx1.AllowUserToOrderColumns = True
        Me.DatagridviewEx1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DatagridviewEx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridviewEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewEx1.GridColor = System.Drawing.SystemColors.HotTrack
        Me.DatagridviewEx1.Location = New System.Drawing.Point(0, 146)
        Me.DatagridviewEx1.Name = "DatagridviewEx1"
        Me.DatagridviewEx1.RowHeadersVisible = False
        Me.DatagridviewEx1.RowTemplate.Height = 23
        Me.DatagridviewEx1.Size = New System.Drawing.Size(631, 340)
        Me.DatagridviewEx1.TabIndex = 61
        Me.DatagridviewEx1.当前用户名 = Nothing
        Me.DatagridviewEx1.管理列的对应表名称 = "wailiaiku"
        Me.DatagridviewEx1.管理列的控件库名称 = "新增销售订单"
        '
        '新增销售订单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 486)
        Me.Controls.Add(Me.DatagridviewEx1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "新增销售订单"
        Me.Text = "账务调整"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_标题 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_保存 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Date结束日期 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date开始日期 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents 关闭 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DatagridviewEx1 As DatagridviewEx.DatagridviewEx
    Friend WithEvents Com_业务类型 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tool_删行 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox_业务员 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_客户 As System.Windows.Forms.TextBox

End Class
