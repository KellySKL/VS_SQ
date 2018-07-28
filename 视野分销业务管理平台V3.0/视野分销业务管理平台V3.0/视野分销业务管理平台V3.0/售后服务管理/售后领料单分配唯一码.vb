Public Class 售后领料单分配唯一码
    Private base As New 售后服务单作业完成时描述Base
    Public pT1 As String
    Public pT2 As String
    Public pT3 As String
    Public pT4 As Integer
    Public pT5 As String
    Public KF As String
    Public id As Integer
    '===================
    Private Ac As Action
    Public Sub New(_Ac As Action)
        Ac = _Ac
        InitializeComponent()
    End Sub
    Private Sub 售后领料单分配唯一码_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddSplit()
    End Sub
    Private Sub AddSplit()
        Dim Tc As New Label With {
            .Text = "旧件返厂维修 - [+客户申请维修件]",
            .AutoSize = True,
            .Top = 5,
            .Left = 10,
            .Cursor = Cursors.Hand,
            .BackColor = Color.Transparent,
            .Font = New Font("宋体", 12, FontStyle.Bold),
            .Parent = Splitter1
        }
        AddHandler Tc.Click, AddressOf Tc_Click

    End Sub

    Private Sub Tc_Click(sender As Object, e As EventArgs)
        AddnewFrom()
    End Sub

    Private Sub AddnewFrom()
        Dim F As New Form With {
            .Width = 600,
            .Height = 500
        }


        Dim dg As New DataGridView With {
            .Dock = DockStyle.Fill,
            .Parent = F,
            .ReadOnly = True,
            .RowHeadersVisible = False,
            .BackgroundColor = Color.White,
            .DataSource = base.GEtwulist()
        }
        '头部位置
        Dim P As New Panel With {
            .Height = 40,
            .Dock = DockStyle.Top,
            .Parent = F
        }
        '文本框
        Dim T As New TextBox With {
            .Left = 10,
            .Top = 10,
            .Height = 25,
            .Width = 200,
            .Parent = P
        }

        AddHandler T.TextChanged, AddressOf T_TextChanged


        F.ShowDialog()

    End Sub

    Private Sub T_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class