'*******************************************
'公共代码区域 由梁晓东设计 2013-10-8
'*******************************************
Imports SyERP.DAL
Module Bus_DataBus

    Public Bus_CurrentUser_Username As String = ""
    Public Bus_CurrentUser_Fullname As String = ""
    Public Bus_CurrentUser_Code As String = ""
    Public Bus_CurrentUser_GroupName As String = ""
    Public Bus_CurrentUser_GroupCode As String = ""
    Public Bus_CurrentUser_当前机台号 As String = ""
    Public Bus_CurrentUser_CompnayName As String = ""
    Public bus_CurrentUser_mastername As String = ""
    Public Bus_SystemSetup_当前版本号 As String

    Public Pri_临时存放执行时间戳 As Integer
    Public 不可自动登录 As Boolean




    Public Pri_免除编程分配环节 As Boolean = False
    Public Pri_免除编程审核环节 As Boolean = False
    Public Pri_免除检验环节 As Boolean = False
    Public Pri_关闭设备维修管理 As Boolean = False
    Public Pri_关闭设备保养管理 As Boolean = False
    Public Pri_加工时免除密码功能 As Boolean = False
    Public Pri_免除待分配零件管理环节 As Boolean = False
    Public Pri_免除开始加工环节 As Boolean = False

    Sub New()
    End Sub

    Public Sub SystemIniFromDB()
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            '系统参数
            Try
                Dim dt4 As New DataTable
                dt4 = db.GetDataSetBySQL("SELECT code,note,[value] from systemsetup ").Tables(0).Copy
                For i As Integer = 0 To dt4.Rows.Count - 1
                    If dt4.Rows(i)("note") = "免除编程分配环节" Then
                        Pri_免除编程分配环节 = dt4.Rows(i)("value") = "1"
                    End If
                    If dt4.Rows(i)("note") = "免除编程审核环节" Then
                        Pri_免除编程审核环节 = dt4.Rows(i)("value") = "1"
                    End If
                    If dt4.Rows(i)("note") = "免除检验环节" Then
                        Pri_免除检验环节 = dt4.Rows(i)("value") = "1"
                    End If
                    If dt4.Rows(i)("note") = "关闭设备维修管理" Then
                        Pri_关闭设备维修管理 = dt4.Rows(i)("value") = "1"
                    End If
                    If dt4.Rows(i)("note") = "关闭设备保养管理" Then
                        Pri_关闭设备保养管理 = dt4.Rows(i)("value") = "1"
                    End If
                    If dt4.Rows(i)("note") = "加工时免除密码功能" Then
                        Pri_加工时免除密码功能 = dt4.Rows(i)("value") = "1"
                    End If
                    If dt4.Rows(i)("note") = "公司名称" Then
                        Bus_CurrentUser_CompnayName = dt4.Rows(i)("value")
                    End If
                    If dt4.Rows(i)("note") = "免除待分配零件管理环节" Then
                        Pri_免除待分配零件管理环节 = dt4.Rows(i)("value") = "1"
                    End If
                    If dt4.Rows(i)("note") = "免除开始加工环节" Then
                        Pri_免除开始加工环节 = dt4.Rows(i)("value") = "1"
                    End If
                Next
            Catch ex As Exception
                Dim er As New SyERP20.ErrorForm("网络连接故障，环境设置出错，请检查网络！联系电话：0577-62721120", ex)
                er.StartPosition = FormStartPosition.CenterScreen
                er.ShowDialog()
            End Try
            db.Dispose() : End Using
    End Sub

    Sub 升级()
        Try
            Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
                db.GetNoneBySQL("IF OBJECT_ID ('clientservice_Billtype', 'U') IS NULL  CREATE TABLE [dbo].[clientservice_Billtype]([id] [int] IDENTITY(1,1) NOT NULL,[单据名称] [varchar](250) NULL,[业务类型] [varchar](250) NULL,[备注] [varchar](250) NULL,CONSTRAINT [PK_clientservice_Billtype] PRIMARY KEY  CLUSTERED 	( [id]	)  ON [PRIMARY]) ON [PRIMARY]")
                db.GetNoneBySQL("IF OBJECT_ID ('clientservice_BilltypeChildtype', 'U') IS NULL  CREATE TABLE [dbo].[clientservice_BilltypeChildtype]([id] [int] IDENTITY(1,1) NOT NULL,[单据名称] [varchar](250) NULL,[业务类型] [varchar](250) NULL,[子业务类型] [varchar](250) NULL,[备注] [varchar](250) NULL,CONSTRAINT [PK_clientservice_BilltypeChildtype] PRIMARY KEY  CLUSTERED 	( [id]	)  ON [PRIMARY]) ON [PRIMARY]")
                db.Dispose()
            End Using

        Catch ex As Exception
        End Try
    End Sub
    '***************************************************
    '用于主窗口的加TabControl页
    '***************************************************
    Public Sub AddPages(ByVal TabControlHeadText As String, ByVal Tabcontrol As TabControl, ByVal PageControl As Object)

        PageControl.width = Tabcontrol.Width - 4
        PageControl.height = Tabcontrol.Height - 30
        '先查找有无存在此tabpages
        Dim flag As Boolean = False
        For Each a As TabPage In Tabcontrol.TabPages
            If a.Text = TabControlHeadText Then '存在了，则
                a.Controls.Clear()
                a.Controls.Add(PageControl) '重新加载
                Tabcontrol.SelectTab(a) '为当前
                flag = True  '不需要加了
                Exit For
            End If
        Next
        If flag = False Then
            Dim b As New TabPage
            b.Text = TabControlHeadText
            PageControl.dock = DockStyle.Fill
            b.Controls.Add(PageControl)
            Tabcontrol.TabPages.Add(b)
            Tabcontrol.SelectTab(b)
        End If
        Tabcontrol.Dock = DockStyle.Fill
        Tabcontrol.Location = New Point(-300, 0)
    End Sub

    '******************************************************************   
    ' 函数名： IsInstanceRunning   
    ' 功  能： 判断工程是否已运行, 单线程运行
    ' 返回值： true   已运行     false   未运行   
    '******************************************************************   
    Public Function IsInstanceRunning() As Boolean
        Dim current As Process = System.Diagnostics.Process.GetCurrentProcess()
        Dim processes As Process() = System.Diagnostics.Process.GetProcessesByName(current.ProcessName)
        'Loop   through   the   running   processes   in   with   the   same   name     
        Dim p As Process
        For Each p In processes
            'Ignore   the   current   process     
            If p.Id <> current.Id Then
                'Make   sure   that   the   process   is   running   from   the   exe   file.     
                If System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("/", "\") = current.MainModule.FileName Then
                    'Return   the   other   process   instance.     
                    Return True
                End If
            End If
        Next
        'No   other   instance   was   found,   return   null.     
        Return False
    End Function   'RunningInstance 
    '***************************************************
    '功能：用于获得Bus_CurrentUser_Code
    '***************************************************
    Public Function getBus_获得滚动字() As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilderWithChuDangDang.ConnectionString)
            t = db.GetStrBySQL("select value from systemsetup where note='滚动字'")
        End Using
        Return t
    End Function
    '***************************************************
    '功能：用于获得Bus_CurrentUser_Code
    '***************************************************
    Public Function getBus_CurrentUser_Code() As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            t = db.GetStrBySQL("select code from puku where userpu='" & Bus_CurrentUser_Username & "'")
        End Using
        Return t
    End Function
    '***************************************************
    '功能：用于获得Bus_CurrentUser_GroupCode
    '***************************************************
    Public Function getBus_CurrentUser_GroupCode() As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            t = db.GetStrBySQL("select code from Groupku where groupname=(select top 1 dept from puku where userpu='" & Bus_CurrentUser_Username & "')")
        End Using
        Return t
    End Function
    '***************************************************
    '功能：用于获得Bus_CurrentUser_Fullname
    '***************************************************
    Public Function getBus_CurrentUser_Fullname() As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            t = db.GetStrBySQL("select turename from puku where userpu='" & Bus_CurrentUser_Username & "'")
        End Using
        Return t
    End Function
    '***************************************************
    '功能：用于获得Bus_CurrentUser_Fullname
    '***************************************************
    Public Function getbus_CurrentUser_mastername() As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            t = db.GetStrBySQL("select mastername from puku where userpu='" & Bus_CurrentUser_Username & "'")
        End Using
        Return t
    End Function




    '***************************************************
    '功能：用于获得Bus_CurrentUser_deptName
    '***************************************************
    Public Function getBus_CurrentUser_deptName() As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            t = db.GetStrBySQL("select dept from puku where userpu='" & Bus_CurrentUser_Username & "'")
        End Using
        Return t
    End Function
    Public Function BuildFrmTo获得服务器时间() As DateTime
        Dim dt As DataTable
        Dim nt As DateTime = Now
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = db.GetDataSetBySQL("select getdate()").Tables(0)
            db.Dispose()
        End Using
        If dt.Rows.Count >= 1 Then nt = dt.Rows(0)(0)
        Return nt
    End Function

    Function 是否为最高优先级(ByVal DataGridView22 As DataGridView) As Boolean
        Dim 已选最小优先级 As Integer = 0
        Dim 未选最大优先级 As Integer
        For i As Integer = 0 To DataGridView22.Rows.Count - 1
            If DataGridView22.Rows(i).Cells("选择").Value = True Then
                If IIf(IsNumeric(DataGridView22.Rows(i).Cells("优先级").Value), DataGridView22.Rows(i).Cells("优先级").Value, 99) < 已选最小优先级 Or 已选最小优先级 = 0 Then
                    已选最小优先级 = IIf(IsNumeric(DataGridView22.Rows(i).Cells("优先级").Value), DataGridView22.Rows(i).Cells("优先级").Value, 99)
                End If
            Else
                If IIf(IsNumeric(DataGridView22.Rows(i).Cells("优先级").Value), DataGridView22.Rows(i).Cells("优先级").Value, 99) > 未选最大优先级 Then
                    未选最大优先级 = IIf(IsNumeric(DataGridView22.Rows(i).Cells("优先级").Value), DataGridView22.Rows(i).Cells("优先级").Value, 99)
                End If
            End If
        Next
        If 已选最小优先级 > 未选最大优先级 And 未选最大优先级 > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    '***************************************************
    '功能：用于获得Bus_CurrentUser_deptName
    '***************************************************
    Public Function 机台号心跳() As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            t = db.GetStrBySQL("update Heart set maxvalue='" & Bus_CurrentUser_当前机台号 & "' where name='" & Bus_CurrentUser_Fullname & "'")
        End Using
        Return t
    End Function

    Public Function 获得机台号的当前用户名(ByVal 机台号 As String) As String
        Dim t As String = ""
        Using db As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            t = db.GetStrBySQL("select name from Heart where maxvalue='" & 机台号 & "'")
        End Using
        Return t
    End Function
    Function Get首页index() As String
        Dim 首页定义号 As String = ""
        Dim XmlRead1 As New Xml.XmlTextReader(Application.StartupPath & "\INDEX.xml") '电话系统设置.xml
        Do While XmlRead1.Read
            If XmlRead1.NodeType = Xml.XmlNodeType.Element Then
                If XmlRead1.Name = "INDEX" Then
                    XmlRead1.Read()
                    首页定义号 = XmlRead1.Value  '
                End If

              
            End If
        Loop
        Return 首页定义号
    End Function




    Public Sub getName(ByVal isNames As String)

        Dim action As String = isNames



        If action = "市场客户维护" Then
            Dim t As New SyERP20.SelectFormBase
            Dim where As String = ""
            ' where = " and AREANAME in (select '='+AREANAME+'|' from areaku where guserdef1 like '%" & Bus_CurrentUser_Fullname & "%' or guserdef1 like '%" & bus_CurrentUser_mastername & "%')"
            where = "and code in (select a.code from clientservice_kfku a , AreaKu b where charindex('" & Bus_CurrentUser_Fullname & "',b.Guserdef1)>0 and charindex('='+b.AREANAME+'|',a.AREANAME )>0)  "
            t.ShowEditForm("ClientService_kfku", where, Nothing)
        ElseIf action = "公司客户维护" Then
            Dim t As New SyERP20.SelectFormBase
            Dim where As String = ""
            where = " and AREANAME in (select  '='+AREANAME+'|'  from areaku where guserdef1 like '%" & Bus_CurrentUser_Fullname & "%' or guserdef1 like '%" & bus_CurrentUser_mastername & "%')"
            t.ShowEditForm("kfku", where, Nothing)
        ElseIf action = "客户地区维护" Then
            Dim a As New SyERP20.地区分级编辑
            a.ShowDialog()
        ElseIf action = "客户拜访记录单编制" Then
            Dim t As New 业务拜访记录单
            t.ShowDialog()
        ElseIf action = "客户拜访记录单历史查询" Then
            Dim t As New 业务拜访记录单历史查询
            AddPages("客户拜访记录单历史查询", MainFrmGood.TabControl1, t)
        ElseIf action = "客户回访预警管理" Then
            Dim t As New 客户回访管理
            AddPages("客户回访预警管理", MainFrmGood.TabControl1, t)
        ElseIf action = "日工作提交单" Then
            Dim t As New 日工作提交单
            t.ShowDialog()
        ElseIf action = "日工作提交单历史查询" Then
            Dim t As New 日工作提交单历史查询
            AddPages("日工作提交单查询", MainFrmGood.TabControl1, t)
        ElseIf action = "销售员往来明细表" Then
            Dim t As New 客户对帐单
            AddPages("销售员往来明细表", MainFrmGood.TabControl1, t)
        ElseIf action = "售后服务单编制" Then
            Dim t As New 售后服务单
            t.ShowDialog()
        ElseIf action = "售后服务单历史查询..." Then
            Dim t As New 售后服务单历史查询
            AddPages("售后服务单历史查询", MainFrmGood.TabControl1, t)
        ElseIf action = "售后服务单分配..." Then
            Dim t As New 售后服务单分配
            AddPages("售后服务单分配", MainFrmGood.TabControl1, t)
        ElseIf action = "售后服务单作业" Then
            Dim t As New 售后服务单作业管理
            AddPages("售后服务单作业", MainFrmGood.TabControl1, t)
        ElseIf action = "客户汇总查询" Then
            '本计算重新做权限判断，想到合并，就算了
            If Bus_CurrentUser_Fullname = "lxd" Or Bus_CurrentUser_Fullname = "admin" Or Bus_CurrentUser_Fullname = "王娅丽" Or Bus_CurrentUser_Fullname = "郑昌仁" Or Bus_CurrentUser_Fullname = "虞中强" Then
                Dim t As New 新建客户查询
                t.ShowDialog()
            Else
                MessageBox.Show("您无权使用本功能")
            End If
        End If


    End Sub








    Public Sub openExe()
        Dim openName As String
        Dim _exe As Array = Environment.GetCommandLineArgs()
        'Dim _exe(4) As String
        '_exe(0) = " "
        '_exe(1) = "lxd"
        '_exe(2) = "lxd"
        '_exe(3) = "售后服务单作业"

        If _exe.Length >= 1 Then
            Dim nfrm As New Object
            '==============================
            ' 不知道验证什么。。。
            Dim tt As New SyERP.DAL.SqlStr
            tt.ReadSqlServerPath()
            If SqlStr.TestMaiConn() = False Then
                SyERP.DAL.SqlStr.ConnStringBuilderWithMaiDangDang = SyERP.DAL.SqlStr.ConnStringBuilderWithChuDangDang
                Dim T4 As New SyERP20.接口程序说明Base()
                T4.set连接串chuTOmai()
            End If
            '==============================

            Bus_CurrentUser_Username = _exe(1)

            '==============================
            '连接主应用连接(以下共3行代码)
            Dim t2 As New SyERP20.接口程序说明Base
            t2.外部应用程序初始化用()
            t2.IniSales()
            SystemIniFromDB()

            Bus_CurrentUser_Fullname = getBus_CurrentUser_Fullname()
            Bus_CurrentUser_Code = getBus_CurrentUser_Code()
            Bus_CurrentUser_GroupName = getBus_CurrentUser_deptName()
            Bus_CurrentUser_GroupCode = getBus_CurrentUser_GroupCode()
            bus_CurrentUser_mastername = getbus_CurrentUser_mastername()
            If Bus_CurrentUser_Fullname = "" Then
                Dim err As New SyERP20.ErrorForm("没有用户验证！无法直接启动程序！", Nothing)
                err.ShowDialog()
                End
            End If
            t2.setuser(Bus_CurrentUser_Code, Bus_CurrentUser_Username, Bus_CurrentUser_Fullname, Bus_CurrentUser_GroupName)
            t2.外部应用程序初始化用()
            t2.IniSales()
            '结束通用块,以上代码请不要随意修改；梁晓东
            '不改不行，衔接不起来...
            '升级()
            '==============================
            openName = _exe(3)
            Call getName(openName)

        Else
            MessageBox.Show("打开失败，请与管理员联系", "提醒")
            End
        End If

    End Sub













End Module
