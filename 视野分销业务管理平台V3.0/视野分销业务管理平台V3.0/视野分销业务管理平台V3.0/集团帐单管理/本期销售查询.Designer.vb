<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 本期销售查询
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.HeadTxt = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox_包括期初 = New System.Windows.Forms.CheckBox()
        Me.导出 = New System.Windows.Forms.ToolStrip()
        Me.toexcel = New System.Windows.Forms.ToolStripSplitButton()
        Me.按格式导出excelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.日期选择 = New System.Windows.Forms.Panel()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.刷新 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New SyERP20.Datagridview列管理Ex()
        Me.Datagridview列管理Ex1 = New SyERP20.Datagridview列管理Ex()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.导出.SuspendLayout()
        Me.日期选择.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datagridview列管理Ex1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.Controls.Add(Me.HeadTxt)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(889, 38)
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
        Me.HeadTxt.Text = "本期销售查询"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.CheckBox_包括期初)
        Me.Panel9.Controls.Add(Me.导出)
        Me.Panel9.Controls.Add(Me.日期选择)
        Me.Panel9.Controls.Add(Me.刷新)
        Me.Panel9.Controls.Add(Me.TextBox1)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 38)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(889, 39)
        Me.Panel9.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(696, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = " "
        '
        'CheckBox_包括期初
        '
        Me.CheckBox_包括期初.AutoSize = True
        Me.CheckBox_包括期初.Location = New System.Drawing.Point(618, 10)
        Me.CheckBox_包括期初.Name = "CheckBox_包括期初"
        Me.CheckBox_包括期初.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_包括期初.TabIndex = 63
        Me.CheckBox_包括期初.Text = "包括期初"
        Me.CheckBox_包括期初.UseVisualStyleBackColor = True
        '
        '导出
        '
        Me.导出.BackColor = System.Drawing.Color.Transparent
        Me.导出.Dock = System.Windows.Forms.DockStyle.None
        Me.导出.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toexcel})
        Me.导出.Location = New System.Drawing.Point(515, 3)
        Me.导出.Name = "导出"
        Me.导出.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.导出.Size = New System.Drawing.Size(89, 25)
        Me.导出.TabIndex = 62
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 77)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Datagridview列管理Ex1)
        Me.SplitContainer1.Size = New System.Drawing.Size(889, 572)
        Me.SplitContainer1.SplitterDistance = 402
        Me.SplitContainer1.TabIndex = 8
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
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
        Me.DataGridView1.Size = New System.Drawing.Size(889, 402)
        Me.DataGridView1.TabIndex = 9
        Me.DataGridView1.管理列的对应表名称 = Nothing
        Me.DataGridView1.管理列的控件库名称 = "分销业务管理平台_本期销售查询"
        '
        'Datagridview列管理Ex1
        '
        Me.Datagridview列管理Ex1.AllowUserToAddRows = False
        Me.Datagridview列管理Ex1.AllowUserToDeleteRows = False
        Me.Datagridview列管理Ex1.AllowUserToOrderColumns = True
        Me.Datagridview列管理Ex1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Datagridview列管理Ex1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Datagridview列管理Ex1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Datagridview列管理Ex1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagridview列管理Ex1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Datagridview列管理Ex1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Datagridview列管理Ex1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview列管理Ex1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Datagridview列管理Ex1.ColumnHeadersHeight = 25
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview列管理Ex1.DefaultCellStyle = DataGridViewCellStyle7
        Me.Datagridview列管理Ex1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridview列管理Ex1.EnableHeadersVisualStyles = False
        Me.Datagridview列管理Ex1.Location = New System.Drawing.Point(0, 0)
        Me.Datagridview列管理Ex1.MultiSelect = False
        Me.Datagridview列管理Ex1.Name = "Datagridview列管理Ex1"
        Me.Datagridview列管理Ex1.ReadOnly = True
        Me.Datagridview列管理Ex1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagridview列管理Ex1.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview列管理Ex1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Datagridview列管理Ex1.RowTemplate.Height = 30
        Me.Datagridview列管理Ex1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview列管理Ex1.Size = New System.Drawing.Size(889, 166)
        Me.Datagridview列管理Ex1.TabIndex = 9
        Me.Datagridview列管理Ex1.管理列的对应表名称 = Nothing
        Me.Datagridview列管理Ex1.管理列的控件库名称 = "分销业务管理平台_本期销售查询"
        '
        '本期销售查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 649)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "本期销售查询"
        Me.Text = "本期销售查询"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.导出.ResumeLayout(False)
        Me.导出.PerformLayout()
        Me.日期选择.ResumeLayout(False)
        Me.日期选择.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datagridview列管理Ex1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents 导出 As System.Windows.Forms.ToolStrip
    Friend WithEvents toexcel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents 按格式导出excelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox_包括期初 As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As SyERP20.Datagridview列管理Ex
    Friend WithEvents Datagridview列管理Ex1 As SyERP20.Datagridview列管理Ex
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
