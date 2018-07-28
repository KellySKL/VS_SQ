<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 售后服务维修物料库
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DatagridviewEx2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.取值ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重载物料信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改物料数量ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.删除当前物料ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DatagridviewEx2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 48)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Location = New System.Drawing.Point(214, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "自动生成领料计划单"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 56)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(0)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "领料人"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "计划领料物料清单"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DatagridviewEx2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(636, 293)
        Me.Panel3.TabIndex = 2
        '
        'DatagridviewEx2
        '
        Me.DatagridviewEx2.AllowUserToAddRows = False
        Me.DatagridviewEx2.AllowUserToDeleteRows = False
        Me.DatagridviewEx2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatagridviewEx2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridviewEx2.ColumnHeadersHeight = 20
        Me.DatagridviewEx2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DatagridviewEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatagridviewEx2.Location = New System.Drawing.Point(0, 0)
        Me.DatagridviewEx2.Name = "DatagridviewEx2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridviewEx2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridviewEx2.RowHeadersVisible = False
        Me.DatagridviewEx2.RowTemplate.Height = 23
        Me.DatagridviewEx2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridviewEx2.Size = New System.Drawing.Size(636, 293)
        Me.DatagridviewEx2.TabIndex = 36
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.取值ToolStripMenuItem, Me.重载物料信息ToolStripMenuItem, Me.修改物料数量ToolStripMenuItem, Me.删除当前物料ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 92)
        '
        '取值ToolStripMenuItem
        '
        Me.取值ToolStripMenuItem.Name = "取值ToolStripMenuItem"
        Me.取值ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.取值ToolStripMenuItem.Text = "取值"
        '
        '重载物料信息ToolStripMenuItem
        '
        Me.重载物料信息ToolStripMenuItem.Name = "重载物料信息ToolStripMenuItem"
        Me.重载物料信息ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.重载物料信息ToolStripMenuItem.Text = "重载物料信息"
        '
        '修改物料数量ToolStripMenuItem
        '
        Me.修改物料数量ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.修改物料数量ToolStripMenuItem.Name = "修改物料数量ToolStripMenuItem"
        Me.修改物料数量ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.修改物料数量ToolStripMenuItem.Text = "修改物料数量"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 23)
        Me.ToolStripMenuItem2.Text = "0"
        '
        '删除当前物料ToolStripMenuItem
        '
        Me.删除当前物料ToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.删除当前物料ToolStripMenuItem.Name = "删除当前物料ToolStripMenuItem"
        Me.删除当前物料ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.删除当前物料ToolStripMenuItem.Text = "删除当前物料"
        '
        '售后服务维修物料库
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(636, 397)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "售后服务维修物料库"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DatagridviewEx2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DatagridviewEx2 As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 取值ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改物料数量ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents 重载物料信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除当前物料ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
