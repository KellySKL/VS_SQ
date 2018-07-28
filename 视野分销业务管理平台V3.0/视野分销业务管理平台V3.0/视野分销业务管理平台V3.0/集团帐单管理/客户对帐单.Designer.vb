<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 客户对帐单
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(客户对帐单))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HeadTxt = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_业务员业绩调整 = New System.Windows.Forms.ToolStripLabel()
        Me.Tool_主管权限定义 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_运费输入 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_业绩划分 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.日期选择 = New System.Windows.Forms.Panel()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_业务主管 = New System.Windows.Forms.ComboBox()
        Me.刷新 = New System.Windows.Forms.Button()
        Me.TextBox_搜索 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolS_框选合计 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New SyERP20.Datagridview列管理Ex()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.日期选择.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.HeadTxt)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1050, 44)
        Me.Panel8.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("黑体", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(200, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(657, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "期末余额=期初余额+(本期销售+本期业绩调整)-(本期收款本期收款调整+本期收款调整)+帐务调整"
        '
        'HeadTxt
        '
        Me.HeadTxt.AutoSize = True
        Me.HeadTxt.BackColor = System.Drawing.Color.Transparent
        Me.HeadTxt.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HeadTxt.ForeColor = System.Drawing.Color.White
        Me.HeadTxt.Location = New System.Drawing.Point(17, 11)
        Me.HeadTxt.Name = "HeadTxt"
        Me.HeadTxt.Size = New System.Drawing.Size(177, 19)
        Me.HeadTxt.TabIndex = 1
        Me.HeadTxt.Text = "销售结算对帐管理"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.ToolStrip1)
        Me.Panel9.Controls.Add(Me.日期选择)
        Me.Panel9.Controls.Add(Me.ComboBox_业务主管)
        Me.Panel9.Controls.Add(Me.刷新)
        Me.Panel9.Controls.Add(Me.TextBox_搜索)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 44)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1050, 65)
        Me.Panel9.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(702, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 12)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = " "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_业务员业绩调整, Me.Tool_主管权限定义, Me.Tool_运费输入, Me.Tool_业绩划分, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1050, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_业务员业绩调整
        '
        Me.Tool_业务员业绩调整.Image = CType(resources.GetObject("Tool_业务员业绩调整.Image"), System.Drawing.Image)
        Me.Tool_业务员业绩调整.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_业务员业绩调整.Name = "Tool_业务员业绩调整"
        Me.Tool_业务员业绩调整.Size = New System.Drawing.Size(117, 22)
        Me.Tool_业务员业绩调整.Text = "业务员业绩调整..."
        '
        'Tool_主管权限定义
        '
        Me.Tool_主管权限定义.Image = CType(resources.GetObject("Tool_主管权限定义.Image"), System.Drawing.Image)
        Me.Tool_主管权限定义.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_主管权限定义.Name = "Tool_主管权限定义"
        Me.Tool_主管权限定义.Size = New System.Drawing.Size(109, 22)
        Me.Tool_主管权限定义.Text = "主管权限定义..."
        '
        'Tool_运费输入
        '
        Me.Tool_运费输入.Image = CType(resources.GetObject("Tool_运费输入.Image"), System.Drawing.Image)
        Me.Tool_运费输入.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_运费输入.Name = "Tool_运费输入"
        Me.Tool_运费输入.Size = New System.Drawing.Size(85, 22)
        Me.Tool_运费输入.Text = "运费输入..."
        '
        'Tool_业绩划分
        '
        Me.Tool_业绩划分.Image = CType(resources.GetObject("Tool_业绩划分.Image"), System.Drawing.Image)
        Me.Tool_业绩划分.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_业绩划分.Name = "Tool_业绩划分"
        Me.Tool_业绩划分.Size = New System.Drawing.Size(85, 22)
        Me.Tool_业绩划分.Text = "业绩划分..."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripButton1.Text = "帐务调整..."
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripButton2.Text = "导出EXCEL"
        '
        '日期选择
        '
        Me.日期选择.BackColor = System.Drawing.Color.Lavender
        Me.日期选择.Controls.Add(Me.date2)
        Me.日期选择.Controls.Add(Me.Button2)
        Me.日期选择.Controls.Add(Me.date1)
        Me.日期选择.Controls.Add(Me.Label3)
        Me.日期选择.Location = New System.Drawing.Point(206, 31)
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
        'ComboBox_业务主管
        '
        Me.ComboBox_业务主管.FormattingEnabled = True
        Me.ComboBox_业务主管.Location = New System.Drawing.Point(62, 34)
        Me.ComboBox_业务主管.Name = "ComboBox_业务主管"
        Me.ComboBox_业务主管.Size = New System.Drawing.Size(138, 20)
        Me.ComboBox_业务主管.TabIndex = 32
        '
        '刷新
        '
        Me.刷新.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.刷新.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.刷新.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.刷新.Location = New System.Drawing.Point(624, 29)
        Me.刷新.Name = "刷新"
        Me.刷新.Size = New System.Drawing.Size(72, 27)
        Me.刷新.TabIndex = 31
        Me.刷新.Text = "立即搜索"
        Me.刷新.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.刷新.UseVisualStyleBackColor = True
        '
        'TextBox_搜索
        '
        Me.TextBox_搜索.Location = New System.Drawing.Point(525, 33)
        Me.TextBox_搜索.Name = "TextBox_搜索"
        Me.TextBox_搜索.Size = New System.Drawing.Size(95, 21)
        Me.TextBox_搜索.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "业务主管："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(485, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "搜索："
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolS_框选合计})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1050, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel1.Text = "框选合计："
        '
        'ToolS_框选合计
        '
        Me.ToolS_框选合计.Name = "ToolS_框选合计"
        Me.ToolS_框选合计.Size = New System.Drawing.Size(15, 17)
        Me.ToolS_框选合计.Text = "0"
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1050, 424)
        Me.DataGridView1.TabIndex = 9
        Me.DataGridView1.管理列的对应表名称 = Nothing
        Me.DataGridView1.管理列的控件库名称 = "分销业务管理平台_客户业绩"
        '
        '客户对帐单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "客户对帐单"
        Me.Size = New System.Drawing.Size(1050, 555)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.日期选择.ResumeLayout(False)
        Me.日期选择.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents HeadTxt As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents 刷新 As System.Windows.Forms.Button
    Friend WithEvents TextBox_搜索 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_业务主管 As System.Windows.Forms.ComboBox
    Friend WithEvents 日期选择 As System.Windows.Forms.Panel
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_业务员业绩调整 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Tool_主管权限定义 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_业绩划分 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_运费输入 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolS_框选合计 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridView1 As SyERP20.Datagridview列管理Ex
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
