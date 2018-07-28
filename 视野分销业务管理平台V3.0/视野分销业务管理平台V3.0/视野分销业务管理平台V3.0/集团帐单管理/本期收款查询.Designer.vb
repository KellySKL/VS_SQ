<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 本期收款查询
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
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.DataGridView1 = New SyERP20.Datagridview列管理Ex()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.导出.SuspendLayout()
        Me.日期选择.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.Controls.Add(Me.HeadTxt)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(889, 44)
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
        Me.HeadTxt.Text = "本期收款查询"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.导出)
        Me.Panel9.Controls.Add(Me.日期选择)
        Me.Panel9.Controls.Add(Me.刷新)
        Me.Panel9.Controls.Add(Me.TextBox1)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 44)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(889, 39)
        Me.Panel9.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(610, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = " "
        '
        '导出
        '
        Me.导出.BackColor = System.Drawing.Color.Transparent
        Me.导出.Dock = System.Windows.Forms.DockStyle.None
        Me.导出.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toexcel})
        Me.导出.Location = New System.Drawing.Point(505, 6)
        Me.导出.Name = "导出"
        Me.导出.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.导出.Size = New System.Drawing.Size(89, 25)
        Me.导出.TabIndex = 63
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
        Me.DataGridView1.Size = New System.Drawing.Size(889, 421)
        Me.DataGridView1.TabIndex = 8
        Me.DataGridView1.管理列的对应表名称 = Nothing
        Me.DataGridView1.管理列的控件库名称 = "分销业务管理平台_本期收款查询"
        '
        '本期收款查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 504)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "本期收款查询"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.导出.ResumeLayout(False)
        Me.导出.PerformLayout()
        Me.日期选择.ResumeLayout(False)
        Me.日期选择.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents 导出 As System.Windows.Forms.ToolStrip
    Friend WithEvents toexcel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents 按格式导出excelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
