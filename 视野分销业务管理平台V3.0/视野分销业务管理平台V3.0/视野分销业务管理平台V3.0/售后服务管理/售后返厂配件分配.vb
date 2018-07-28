Public Class 售后返厂配件分配
    Private Cwxdd As String '单号
    Private Cwgs As String '公司
    Private Cwwl As String '物料
    Private upId As String '
    Private Faform As New Object
    Private base As New 售后服务单作业完成时描述Base



    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal wxDD As String, ByVal wxGS As String, ByVal wxWL As String, ByVal wxId As String, ByVal fmm As Object)
        InitializeComponent()
        Cwxdd = wxDD
        Cwgs = wxGS
        Cwwl = wxWL
        upId = wxId
        Faform = fmm
        ToolStripStatusLabel2.Text = wxDD
        Label2.Text = wxGS
        Label1.Text = wxWL
        ShowDialog()
    End Sub

    Private Sub 售后返厂配件分配_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = "售后返厂配件分配器"
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Dim cName As String = ""
        If RadioButton2.Checked = True Then base.updata内部维修人(upId, "采购部", Me.TextBox1.Text) : cName = "采购部"
        If RadioButton3.Checked = True Then base.updata内部维修人(upId, "生产部", Me.TextBox1.Text) : cName = "生产部"
        Faform.getName(cName, Me.TextBox1.Text)
        Me.Close()
    End Sub
End Class