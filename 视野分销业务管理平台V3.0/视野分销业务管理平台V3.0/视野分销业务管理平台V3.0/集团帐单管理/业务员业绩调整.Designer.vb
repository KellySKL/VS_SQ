<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 业务员业绩调整
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(业务员业绩调整))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip_退出 = New System.Windows.Forms.ToolStripButton()
        Me.lbl_标题 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Datagridviewex_业务员1 = New SyERP20.Datagridview列管理Ex()
        Me.选择 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_获得业务员1 = New System.Windows.Forms.Button()
        Me.textbox_业务员1 = New System.Windows.Forms.TextBox()
        Me.lbl_对方名称 = New System.Windows.Forms.Label()
        Me.Datagridviewex_业务员2 = New SyERP20.Datagridview列管理Ex()
        Me.选择1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_获得业务员2 = New System.Windows.Forms.Button()
        Me.textbox_业务员2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.刷新 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Datagridviewex_业务员1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Datagridviewex_业务员2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel8.Size = New System.Drawing.Size(985, 67)
        Me.Panel8.TabIndex = 61
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_退出})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 42)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.lbl_标题.Location = New System.Drawing.Point(12, 12)
        Me.lbl_标题.Name = "lbl_标题"
        Me.lbl_标题.Size = New System.Drawing.Size(156, 19)
        Me.lbl_标题.TabIndex = 1
        Me.lbl_标题.Text = "业务员业务调整"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(985, 22)
        Me.StatusStrip1.TabIndex = 62
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 67)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Datagridviewex_业务员1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Datagridviewex_业务员2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(985, 465)
        Me.SplitContainer1.SplitterDistance = 437
        Me.SplitContainer1.TabIndex = 63
        '
        'Datagridviewex_业务员1
        '
        Me.Datagridviewex_业务员1.AllowUserToAddRows = False
        Me.Datagridviewex_业务员1.AllowUserToDeleteRows = False
        Me.Datagridviewex_业务员1.AllowUserToOrderColumns = True
        Me.Datagridviewex_业务员1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Datagridviewex_业务员1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Datagridviewex_业务员1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Datagridviewex_业务员1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagridviewex_业务员1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Datagridviewex_业务员1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Datagridviewex_业务员1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridviewex_业务员1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Datagridviewex_业务员1.ColumnHeadersHeight = 25
        Me.Datagridviewex_业务员1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.选择})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridviewex_业务员1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Datagridviewex_业务员1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridviewex_业务员1.EnableHeadersVisualStyles = False
        Me.Datagridviewex_业务员1.Location = New System.Drawing.Point(0, 29)
        Me.Datagridviewex_业务员1.Name = "Datagridviewex_业务员1"
        Me.Datagridviewex_业务员1.ReadOnly = True
        Me.Datagridviewex_业务员1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagridviewex_业务员1.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridviewex_业务员1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Datagridviewex_业务员1.RowTemplate.Height = 30
        Me.Datagridviewex_业务员1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridviewex_业务员1.Size = New System.Drawing.Size(437, 436)
        Me.Datagridviewex_业务员1.TabIndex = 68
        Me.Datagridviewex_业务员1.管理列的对应表名称 = Nothing
        Me.Datagridviewex_业务员1.管理列的控件库名称 = "分销业务管理平台_业务员调整1"
        '
        '选择
        '
        Me.选择.HeaderText = "选择"
        Me.选择.Name = "选择"
        Me.选择.ReadOnly = True
        Me.选择.Width = 40
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.刷新)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button_获得业务员1)
        Me.Panel1.Controls.Add(Me.textbox_业务员1)
        Me.Panel1.Controls.Add(Me.lbl_对方名称)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 29)
        Me.Panel1.TabIndex = 0
        '
        'Button_获得业务员1
        '
        Me.Button_获得业务员1.Location = New System.Drawing.Point(160, 6)
        Me.Button_获得业务员1.Name = "Button_获得业务员1"
        Me.Button_获得业务员1.Size = New System.Drawing.Size(21, 17)
        Me.Button_获得业务员1.TabIndex = 69
        Me.Button_获得业务员1.Text = "…"
        Me.Button_获得业务员1.UseVisualStyleBackColor = True
        '
        'textbox_业务员1
        '
        Me.textbox_业务员1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox_业务员1.Location = New System.Drawing.Point(55, 4)
        Me.textbox_业务员1.Name = "textbox_业务员1"
        Me.textbox_业务员1.ReadOnly = True
        Me.textbox_业务员1.Size = New System.Drawing.Size(128, 21)
        Me.textbox_业务员1.TabIndex = 70
        '
        'lbl_对方名称
        '
        Me.lbl_对方名称.AutoSize = True
        Me.lbl_对方名称.Location = New System.Drawing.Point(8, 8)
        Me.lbl_对方名称.Name = "lbl_对方名称"
        Me.lbl_对方名称.Size = New System.Drawing.Size(53, 12)
        Me.lbl_对方名称.TabIndex = 68
        Me.lbl_对方名称.Text = "业务员："
        '
        'Datagridviewex_业务员2
        '
        Me.Datagridviewex_业务员2.AllowUserToAddRows = False
        Me.Datagridviewex_业务员2.AllowUserToDeleteRows = False
        Me.Datagridviewex_业务员2.AllowUserToOrderColumns = True
        Me.Datagridviewex_业务员2.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Datagridviewex_业务员2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Datagridviewex_业务员2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Datagridviewex_业务员2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagridviewex_业务员2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Datagridviewex_业务员2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Datagridviewex_业务员2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridviewex_业务员2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Datagridviewex_业务员2.ColumnHeadersHeight = 25
        Me.Datagridviewex_业务员2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.选择1})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridviewex_业务员2.DefaultCellStyle = DataGridViewCellStyle7
        Me.Datagridviewex_业务员2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridviewex_业务员2.EnableHeadersVisualStyles = False
        Me.Datagridviewex_业务员2.Location = New System.Drawing.Point(34, 29)
        Me.Datagridviewex_业务员2.Name = "Datagridviewex_业务员2"
        Me.Datagridviewex_业务员2.ReadOnly = True
        Me.Datagridviewex_业务员2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagridviewex_业务员2.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridviewex_业务员2.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Datagridviewex_业务员2.RowTemplate.Height = 30
        Me.Datagridviewex_业务员2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridviewex_业务员2.Size = New System.Drawing.Size(510, 436)
        Me.Datagridviewex_业务员2.TabIndex = 67
        Me.Datagridviewex_业务员2.管理列的对应表名称 = Nothing
        Me.Datagridviewex_业务员2.管理列的控件库名称 = "分销业务管理平台_业务员调整2"
        '
        '选择1
        '
        Me.选择1.HeaderText = "选择"
        Me.选择1.Name = "选择1"
        Me.选择1.ReadOnly = True
        Me.选择1.Width = 40
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(34, 436)
        Me.Panel3.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 129)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(28, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button_获得业务员2)
        Me.Panel2.Controls.Add(Me.textbox_业务员2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 29)
        Me.Panel2.TabIndex = 1
        '
        'Button_获得业务员2
        '
        Me.Button_获得业务员2.Location = New System.Drawing.Point(263, 6)
        Me.Button_获得业务员2.Name = "Button_获得业务员2"
        Me.Button_获得业务员2.Size = New System.Drawing.Size(21, 17)
        Me.Button_获得业务员2.TabIndex = 72
        Me.Button_获得业务员2.Text = "…"
        Me.Button_获得业务员2.UseVisualStyleBackColor = True
        '
        'textbox_业务员2
        '
        Me.textbox_业务员2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textbox_业务员2.Location = New System.Drawing.Point(79, 4)
        Me.textbox_业务员2.Name = "textbox_业务员2"
        Me.textbox_业务员2.ReadOnly = True
        Me.textbox_业务员2.Size = New System.Drawing.Size(207, 21)
        Me.textbox_业务员2.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "业务员："
        '
        '刷新
        '
        Me.刷新.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.刷新.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.刷新.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.刷新.Location = New System.Drawing.Point(323, 0)
        Me.刷新.Name = "刷新"
        Me.刷新.Size = New System.Drawing.Size(72, 27)
        Me.刷新.TabIndex = 73
        Me.刷新.Text = "立即搜索"
        Me.刷新.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.刷新.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(224, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 21)
        Me.TextBox1.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "搜索："
        '
        '业务员业绩调整
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 554)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "业务员业绩调整"
        Me.Text = "业务员业绩调整"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Datagridviewex_业务员1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Datagridviewex_业务员2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip_退出 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_标题 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Button_获得业务员1 As System.Windows.Forms.Button
    Friend WithEvents textbox_业务员1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_对方名称 As System.Windows.Forms.Label
    Private WithEvents Button_获得业务员2 As System.Windows.Forms.Button
    Friend WithEvents textbox_业务员2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Datagridviewex_业务员2 As SyERP20.Datagridview列管理Ex
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents 选择1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Datagridviewex_业务员1 As SyERP20.Datagridview列管理Ex
    Friend WithEvents 选择 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 刷新 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
