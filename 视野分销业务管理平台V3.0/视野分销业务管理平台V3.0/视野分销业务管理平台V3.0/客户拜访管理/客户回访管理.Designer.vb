<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 客户回访管理
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(客户回访管理))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel_正在执行 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DatagridviewEx回访预警 = New DatagridviewEx.DatagridviewEx()
        Me.立即拜访 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CheckBox_所有客户 = New System.Windows.Forms.CheckBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.but_查询 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_天数 = New System.Windows.Forms.ComboBox()
        Me.关键字 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.but_左侧显示 = New System.Windows.Forms.ToolStripButton()
        Me.but_导出EXCEL = New System.Windows.Forms.ToolStripButton()
        Me.Tool_编辑预警天数 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_标题 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel_正在执行.SuspendLayout()
        CType(Me.DatagridviewEx回访预警, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_正在执行)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DatagridviewEx回访预警)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CheckBox_所有客户)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer1.Size = New System.Drawing.Size(969, 484)
        Me.SplitContainer1.SplitterDistance = 69
        Me.SplitContainer1.TabIndex = 64
        '
        'Panel_正在执行
        '
        Me.Panel_正在执行.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel_正在执行.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_正在执行.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_正在执行.Controls.Add(Me.Label5)
        Me.Panel_正在执行.Location = New System.Drawing.Point(3, 132)
        Me.Panel_正在执行.Name = "Panel_正在执行"
        Me.Panel_正在执行.Size = New System.Drawing.Size(234, 41)
        Me.Panel_正在执行.TabIndex = 66
        Me.Panel_正在执行.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "正在读取数据,请等待..."
        '
        'DatagridviewEx回访预警
        '
        Me.DatagridviewEx回访预警.AllowUserToAddRows = False
        Me.DatagridviewEx回访预警.AllowUserToDeleteRows = False
        Me.DatagridviewEx回访预警.AllowUserToOrderColumns = True
        Me.DatagridviewEx回访预警.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridviewEx回访预警.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridviewEx回访预警.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridviewEx回访预警.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.立即拜访})
        Me.DatagridviewEx回访预警.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewEx回访预警.Location = New System.Drawing.Point(0, 105)
        Me.DatagridviewEx回访预警.Name = "DatagridviewEx回访预警"
        Me.DatagridviewEx回访预警.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridviewEx回访预警.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridviewEx回访预警.RowHeadersWidth = 10
        Me.DatagridviewEx回访预警.RowTemplate.Height = 23
        Me.DatagridviewEx回访预警.Size = New System.Drawing.Size(969, 379)
        Me.DatagridviewEx回访预警.TabIndex = 65
        Me.DatagridviewEx回访预警.当前用户名 = Nothing
        Me.DatagridviewEx回访预警.管理列的对应表名称 = "clientservice_VisitBill"
        Me.DatagridviewEx回访预警.管理列的控件库名称 = "客户回访预警管理"
        '
        '立即拜访
        '
        Me.立即拜访.HeaderText = "立即拜访"
        Me.立即拜访.Image = Global.视野分销业务管理平台V3._0.My.Resources.Resources._new
        Me.立即拜访.Name = "立即拜访"
        Me.立即拜访.ReadOnly = True
        Me.立即拜访.Width = 50
        '
        'CheckBox_所有客户
        '
        Me.CheckBox_所有客户.AutoSize = True
        Me.CheckBox_所有客户.Location = New System.Drawing.Point(321, 51)
        Me.CheckBox_所有客户.Name = "CheckBox_所有客户"
        Me.CheckBox_所有客户.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_所有客户.TabIndex = 66
        Me.CheckBox_所有客户.Text = "所有客户"
        Me.CheckBox_所有客户.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.CheckBox1)
        Me.Panel9.Controls.Add(Me.but_查询)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.ComboBox_天数)
        Me.Panel9.Controls.Add(Me.关键字)
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(969, 32)
        Me.Panel9.TabIndex = 63
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(430, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "定位当前用户"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'but_查询
        '
        Me.but_查询.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.but_查询.Location = New System.Drawing.Point(342, 3)
        Me.but_查询.Name = "but_查询"
        Me.but_查询.Size = New System.Drawing.Size(74, 25)
        Me.but_查询.TabIndex = 56
        Me.but_查询.Text = "查询(C)"
        Me.but_查询.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.but_查询.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "预警天数："
        '
        'ComboBox_天数
        '
        Me.ComboBox_天数.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_天数.FormattingEnabled = True
        Me.ComboBox_天数.Location = New System.Drawing.Point(249, 6)
        Me.ComboBox_天数.Name = "ComboBox_天数"
        Me.ComboBox_天数.Size = New System.Drawing.Size(77, 20)
        Me.ComboBox_天数.TabIndex = 64
        '
        '关键字
        '
        Me.关键字.Location = New System.Drawing.Point(39, 5)
        Me.关键字.Name = "关键字"
        Me.关键字.Size = New System.Drawing.Size(133, 21)
        Me.关键字.TabIndex = 53
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "搜索："
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.but_左侧显示, Me.but_导出EXCEL, Me.Tool_编辑预警天数, Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 48)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(969, 25)
        Me.ToolStrip2.TabIndex = 62
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'but_左侧显示
        '
        Me.but_左侧显示.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.but_左侧显示.Name = "but_左侧显示"
        Me.but_左侧显示.Size = New System.Drawing.Size(60, 22)
        Me.but_左侧显示.Text = "左侧显示"
        '
        'but_导出EXCEL
        '
        Me.but_导出EXCEL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.but_导出EXCEL.Name = "but_导出EXCEL"
        Me.but_导出EXCEL.Size = New System.Drawing.Size(74, 22)
        Me.but_导出EXCEL.Text = "导出Excel..."
        '
        'Tool_编辑预警天数
        '
        Me.Tool_编辑预警天数.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_编辑预警天数.Name = "Tool_编辑预警天数"
        Me.Tool_编辑预警天数.Size = New System.Drawing.Size(84, 22)
        Me.Tool_编辑预警天数.Text = "编辑预警天数"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel1.Text = "回访天数校准"
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
        Me.Panel8.Size = New System.Drawing.Size(969, 48)
        Me.Panel8.TabIndex = 61
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(566, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 48)
        Me.Panel1.TabIndex = 2
        '
        'lbl_标题
        '
        Me.lbl_标题.AutoSize = True
        Me.lbl_标题.BackColor = System.Drawing.Color.Transparent
        Me.lbl_标题.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_标题.ForeColor = System.Drawing.Color.White
        Me.lbl_标题.Location = New System.Drawing.Point(12, 15)
        Me.lbl_标题.Name = "lbl_标题"
        Me.lbl_标题.Size = New System.Drawing.Size(177, 19)
        Me.lbl_标题.TabIndex = 1
        Me.lbl_标题.Text = "客户回访预警管理"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(969, 22)
        Me.StatusStrip1.TabIndex = 63
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "选择"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        '客户回访管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "客户回访管理"
        Me.Size = New System.Drawing.Size(969, 506)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel_正在执行.ResumeLayout(False)
        Me.Panel_正在执行.PerformLayout()
        CType(Me.DatagridviewEx回访预警, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel_正在执行 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents but_查询 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_天数 As System.Windows.Forms.ComboBox
    Friend WithEvents 关键字 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents but_左侧显示 As System.Windows.Forms.ToolStripButton
    Friend WithEvents but_导出EXCEL As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_编辑预警天数 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_标题 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_所有客户 As System.Windows.Forms.CheckBox
    Friend WithEvents DatagridviewEx回访预警 As DatagridviewEx.DatagridviewEx
    Friend WithEvents 立即拜访 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
