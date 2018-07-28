<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 售后领料单分配唯一码
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatagridviewEx1 = New DatagridviewEx.DatagridviewEx()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.DatagridviewEx2 = New DatagridviewEx.DatagridviewEx()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridviewEx2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 37)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "新配件处理"
        '
        'DatagridviewEx1
        '
        Me.DatagridviewEx1.AllowUserToAddRows = False
        Me.DatagridviewEx1.AllowUserToDeleteRows = False
        Me.DatagridviewEx1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        Me.DatagridviewEx1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridviewEx1.BackgroundColor = System.Drawing.Color.White
        Me.DatagridviewEx1.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.DatagridviewEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DatagridviewEx1.GridColor = System.Drawing.Color.Silver
        Me.DatagridviewEx1.Location = New System.Drawing.Point(0, 37)
        Me.DatagridviewEx1.Name = "DatagridviewEx1"
        Me.DatagridviewEx1.RowHeadersVisible = False
        Me.DatagridviewEx1.RowHeadersWidth = 20
        Me.DatagridviewEx1.RowTemplate.Height = 23
        Me.DatagridviewEx1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DatagridviewEx1.Size = New System.Drawing.Size(800, 202)
        Me.DatagridviewEx1.TabIndex = 90
        Me.DatagridviewEx1.当前用户名 = Nothing
        Me.DatagridviewEx1.管理列的对应表名称 = ""
        Me.DatagridviewEx1.管理列的控件库名称 = "售后计划单"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Lavender
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 239)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(800, 24)
        Me.Splitter1.TabIndex = 91
        Me.Splitter1.TabStop = False
        '
        'DatagridviewEx2
        '
        Me.DatagridviewEx2.AllowUserToAddRows = False
        Me.DatagridviewEx2.AllowUserToDeleteRows = False
        Me.DatagridviewEx2.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew
        Me.DatagridviewEx2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridviewEx2.BackgroundColor = System.Drawing.Color.White
        Me.DatagridviewEx2.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.DatagridviewEx2.Location = New System.Drawing.Point(0, 263)
        Me.DatagridviewEx2.Name = "DatagridviewEx2"
        Me.DatagridviewEx2.RowHeadersVisible = False
        Me.DatagridviewEx2.RowHeadersWidth = 20
        Me.DatagridviewEx2.RowTemplate.Height = 23
        Me.DatagridviewEx2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DatagridviewEx2.Size = New System.Drawing.Size(800, 227)
        Me.DatagridviewEx2.TabIndex = 92
        Me.DatagridviewEx2.当前用户名 = Nothing
        Me.DatagridviewEx2.管理列的对应表名称 = ""
        Me.DatagridviewEx2.管理列的控件库名称 = "售后计划单"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 453)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 37)
        Me.Panel2.TabIndex = 93
        '
        '售后领料单分配唯一码
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DatagridviewEx2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.DatagridviewEx1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "售后领料单分配唯一码"
        Me.Text = "售后领料单分配唯一码"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DatagridviewEx1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridviewEx2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DatagridviewEx1 As DatagridviewEx.DatagridviewEx
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents DatagridviewEx2 As DatagridviewEx.DatagridviewEx
    Friend WithEvents Panel2 As Panel
End Class
