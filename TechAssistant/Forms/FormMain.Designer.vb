<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnTestConnection = New Button()
        btnCancel = New Button()
        btnTest1 = New Button()
        btnTestUpdate = New Button()
        btnTestConnect = New Button()
        tcFormMain = New TabControl()
        tpSystemInfo = New TabPage()
        dgvSystemInfo = New DataGridView()
        tpDbInfo = New TabPage()
        tcDbInfo = New TabControl()
        tpApplicationInfo = New TabPage()
        dgvApplicationInfo = New DataGridView()
        tpAppOptions = New TabPage()
        dgvAppOptions = New DataGridView()
        tpWebOptions = New TabPage()
        dgvWebOptions = New DataGridView()
        tpDbAnalytics = New TabPage()
        tcDbAnalytics = New TabControl()
        tpDbTableSizes = New TabPage()
        dgvTableSizes = New DataGridView()
        tpSizeByDay = New TabPage()
        dgvGrowthByDay = New DataGridView()
        tpOptions = New TabPage()
        gbTechAssistOptions = New GroupBox()
        tbWindowTitle = New TextBox()
        lblWindowTitle = New Label()
        tpServices = New TabPage()
        gbServices = New GroupBox()
        tlpServices = New TableLayoutPanel()
        flpServicesButtons = New FlowLayoutPanel()
        btnServicesRefresh = New Button()
        btnServiceStart = New Button()
        btnServiceStop = New Button()
        btnServiceRestart = New Button()
        dgvServices = New DataGridView()
        pbServices = New ProgressBar()
        lblServiceStatus = New Label()
        tlpFormMain = New TableLayoutPanel()
        flpFormButtonsBottom = New FlowLayoutPanel()
        btnAdminUnlock = New Button()
        flpTest = New FlowLayoutPanel()
        btnTest2 = New Button()
        btnTest3 = New Button()
        btnTest4 = New Button()
        tbTest1 = New TextBox()
        flpAdvButtons = New FlowLayoutPanel()
        btnAdvManager = New Button()
        btnPos = New Button()
        btnAdvGroups = New Button()
        btnAdvRedeem = New Button()
        btnKioskSetup = New Button()
        btnAdvKiosk = New Button()
        btnAdvReportEditor = New Button()
        flpUtilityButtons = New FlowLayoutPanel()
        btnTaskManager = New Button()
        btnCalculator = New Button()
        btnServices = New Button()
        btnEventViewer = New Button()
        scFormMainTopRight = New SplitContainer()
        flpFormButtonsTop = New FlowLayoutPanel()
        rtbHints = New RichTextBox()
        flpAppButtons = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        ttAdvantageButtons = New ToolTip(components)
        ttUtilityButtons = New ToolTip(components)
        tmrServices = New Timer(components)
        tcFormMain.SuspendLayout()
        tpSystemInfo.SuspendLayout()
        CType(dgvSystemInfo, ComponentModel.ISupportInitialize).BeginInit()
        tpDbInfo.SuspendLayout()
        tcDbInfo.SuspendLayout()
        tpApplicationInfo.SuspendLayout()
        CType(dgvApplicationInfo, ComponentModel.ISupportInitialize).BeginInit()
        tpAppOptions.SuspendLayout()
        CType(dgvAppOptions, ComponentModel.ISupportInitialize).BeginInit()
        tpWebOptions.SuspendLayout()
        CType(dgvWebOptions, ComponentModel.ISupportInitialize).BeginInit()
        tpDbAnalytics.SuspendLayout()
        tcDbAnalytics.SuspendLayout()
        tpDbTableSizes.SuspendLayout()
        CType(dgvTableSizes, ComponentModel.ISupportInitialize).BeginInit()
        tpSizeByDay.SuspendLayout()
        CType(dgvGrowthByDay, ComponentModel.ISupportInitialize).BeginInit()
        tpOptions.SuspendLayout()
        gbTechAssistOptions.SuspendLayout()
        tpServices.SuspendLayout()
        gbServices.SuspendLayout()
        tlpServices.SuspendLayout()
        flpServicesButtons.SuspendLayout()
        CType(dgvServices, ComponentModel.ISupportInitialize).BeginInit()
        tlpFormMain.SuspendLayout()
        flpFormButtonsBottom.SuspendLayout()
        flpTest.SuspendLayout()
        flpAdvButtons.SuspendLayout()
        flpUtilityButtons.SuspendLayout()
        CType(scFormMainTopRight, ComponentModel.ISupportInitialize).BeginInit()
        scFormMainTopRight.Panel1.SuspendLayout()
        scFormMainTopRight.Panel2.SuspendLayout()
        scFormMainTopRight.SuspendLayout()
        flpFormButtonsTop.SuspendLayout()
        flpAppButtons.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTestConnection
        ' 
        btnTestConnection.Location = New Point(3, 3)
        btnTestConnection.Name = "btnTestConnection"
        btnTestConnection.Size = New Size(122, 23)
        btnTestConnection.TabIndex = 0
        btnTestConnection.Text = "Test Database"
        btnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(3, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnTest1
        ' 
        btnTest1.Location = New Point(3, 3)
        btnTest1.Name = "btnTest1"
        btnTest1.Size = New Size(75, 23)
        btnTest1.TabIndex = 3
        btnTest1.Text = "Test1"
        btnTest1.UseVisualStyleBackColor = True
        ' 
        ' btnTestUpdate
        ' 
        btnTestUpdate.Location = New Point(3, 32)
        btnTestUpdate.Name = "btnTestUpdate"
        btnTestUpdate.Size = New Size(122, 23)
        btnTestUpdate.TabIndex = 4
        btnTestUpdate.Text = "Test Update"
        btnTestUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnTestConnect
        ' 
        btnTestConnect.Location = New Point(3, 61)
        btnTestConnect.Name = "btnTestConnect"
        btnTestConnect.Size = New Size(122, 23)
        btnTestConnect.TabIndex = 5
        btnTestConnect.Text = "TestConnect"
        btnTestConnect.UseVisualStyleBackColor = True
        ' 
        ' tcFormMain
        ' 
        tcFormMain.Controls.Add(tpSystemInfo)
        tcFormMain.Controls.Add(tpDbInfo)
        tcFormMain.Controls.Add(tpDbAnalytics)
        tcFormMain.Controls.Add(tpServices)
        tcFormMain.Controls.Add(tpOptions)
        tcFormMain.Dock = DockStyle.Fill
        tcFormMain.Location = New Point(3, 3)
        tcFormMain.Name = "tcFormMain"
        tcFormMain.SelectedIndex = 0
        tcFormMain.Size = New Size(807, 552)
        tcFormMain.TabIndex = 6
        ' 
        ' tpSystemInfo
        ' 
        tpSystemInfo.BackColor = SystemColors.ControlDark
        tpSystemInfo.Controls.Add(dgvSystemInfo)
        tpSystemInfo.Location = New Point(4, 24)
        tpSystemInfo.Name = "tpSystemInfo"
        tpSystemInfo.Padding = New Padding(3)
        tpSystemInfo.Size = New Size(799, 524)
        tpSystemInfo.TabIndex = 0
        tpSystemInfo.Text = "System Info"
        ' 
        ' dgvSystemInfo
        ' 
        dgvSystemInfo.AllowUserToAddRows = False
        dgvSystemInfo.AllowUserToDeleteRows = False
        dgvSystemInfo.AllowUserToResizeRows = False
        dgvSystemInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvSystemInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSystemInfo.Dock = DockStyle.Fill
        dgvSystemInfo.Location = New Point(3, 3)
        dgvSystemInfo.MultiSelect = False
        dgvSystemInfo.Name = "dgvSystemInfo"
        dgvSystemInfo.ReadOnly = True
        dgvSystemInfo.RowHeadersVisible = False
        dgvSystemInfo.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvSystemInfo.Size = New Size(793, 518)
        dgvSystemInfo.TabIndex = 2
        ' 
        ' tpDbInfo
        ' 
        tpDbInfo.Controls.Add(tcDbInfo)
        tpDbInfo.Location = New Point(4, 24)
        tpDbInfo.Name = "tpDbInfo"
        tpDbInfo.Padding = New Padding(3)
        tpDbInfo.Size = New Size(799, 524)
        tpDbInfo.TabIndex = 1
        tpDbInfo.Text = "CE Db Info"
        ' 
        ' tcDbInfo
        ' 
        tcDbInfo.Controls.Add(tpApplicationInfo)
        tcDbInfo.Controls.Add(tpAppOptions)
        tcDbInfo.Controls.Add(tpWebOptions)
        tcDbInfo.Dock = DockStyle.Fill
        tcDbInfo.Location = New Point(3, 3)
        tcDbInfo.Multiline = True
        tcDbInfo.Name = "tcDbInfo"
        tcDbInfo.SelectedIndex = 0
        tcDbInfo.Size = New Size(793, 518)
        tcDbInfo.TabIndex = 1
        ' 
        ' tpApplicationInfo
        ' 
        tpApplicationInfo.BackColor = SystemColors.ControlDark
        tpApplicationInfo.Controls.Add(dgvApplicationInfo)
        tpApplicationInfo.Location = New Point(4, 24)
        tpApplicationInfo.Name = "tpApplicationInfo"
        tpApplicationInfo.Padding = New Padding(3)
        tpApplicationInfo.Size = New Size(785, 490)
        tpApplicationInfo.TabIndex = 0
        tpApplicationInfo.Text = "ApplicationInfo"
        ' 
        ' dgvApplicationInfo
        ' 
        dgvApplicationInfo.AllowUserToAddRows = False
        dgvApplicationInfo.AllowUserToDeleteRows = False
        dgvApplicationInfo.AllowUserToResizeRows = False
        dgvApplicationInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvApplicationInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApplicationInfo.Dock = DockStyle.Fill
        dgvApplicationInfo.Location = New Point(3, 3)
        dgvApplicationInfo.MultiSelect = False
        dgvApplicationInfo.Name = "dgvApplicationInfo"
        dgvApplicationInfo.ReadOnly = True
        dgvApplicationInfo.RowHeadersVisible = False
        dgvApplicationInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApplicationInfo.Size = New Size(779, 484)
        dgvApplicationInfo.TabIndex = 0
        ' 
        ' tpAppOptions
        ' 
        tpAppOptions.Controls.Add(dgvAppOptions)
        tpAppOptions.Location = New Point(4, 24)
        tpAppOptions.Name = "tpAppOptions"
        tpAppOptions.Padding = New Padding(3)
        tpAppOptions.Size = New Size(785, 490)
        tpAppOptions.TabIndex = 1
        tpAppOptions.Text = "AppOptions"
        ' 
        ' dgvAppOptions
        ' 
        dgvAppOptions.AllowUserToAddRows = False
        dgvAppOptions.AllowUserToDeleteRows = False
        dgvAppOptions.AllowUserToResizeRows = False
        dgvAppOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvAppOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAppOptions.Dock = DockStyle.Fill
        dgvAppOptions.Location = New Point(3, 3)
        dgvAppOptions.MultiSelect = False
        dgvAppOptions.Name = "dgvAppOptions"
        dgvAppOptions.ReadOnly = True
        dgvAppOptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAppOptions.Size = New Size(779, 484)
        dgvAppOptions.TabIndex = 0
        ' 
        ' tpWebOptions
        ' 
        tpWebOptions.Controls.Add(dgvWebOptions)
        tpWebOptions.Location = New Point(4, 24)
        tpWebOptions.Name = "tpWebOptions"
        tpWebOptions.Padding = New Padding(3)
        tpWebOptions.Size = New Size(785, 490)
        tpWebOptions.TabIndex = 2
        tpWebOptions.Text = "WebOptions"
        ' 
        ' dgvWebOptions
        ' 
        dgvWebOptions.AllowUserToAddRows = False
        dgvWebOptions.AllowUserToDeleteRows = False
        dgvWebOptions.AllowUserToResizeRows = False
        dgvWebOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvWebOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvWebOptions.Dock = DockStyle.Fill
        dgvWebOptions.Location = New Point(3, 3)
        dgvWebOptions.MultiSelect = False
        dgvWebOptions.Name = "dgvWebOptions"
        dgvWebOptions.ReadOnly = True
        dgvWebOptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvWebOptions.Size = New Size(779, 484)
        dgvWebOptions.TabIndex = 1
        ' 
        ' tpDbAnalytics
        ' 
        tpDbAnalytics.BackColor = SystemColors.ControlDark
        tpDbAnalytics.Controls.Add(tcDbAnalytics)
        tpDbAnalytics.Location = New Point(4, 24)
        tpDbAnalytics.Name = "tpDbAnalytics"
        tpDbAnalytics.Padding = New Padding(3)
        tpDbAnalytics.Size = New Size(799, 524)
        tpDbAnalytics.TabIndex = 2
        tpDbAnalytics.Text = "Database Analytics"
        ' 
        ' tcDbAnalytics
        ' 
        tcDbAnalytics.Controls.Add(tpDbTableSizes)
        tcDbAnalytics.Controls.Add(tpSizeByDay)
        tcDbAnalytics.Dock = DockStyle.Fill
        tcDbAnalytics.Location = New Point(3, 3)
        tcDbAnalytics.Name = "tcDbAnalytics"
        tcDbAnalytics.SelectedIndex = 0
        tcDbAnalytics.Size = New Size(793, 518)
        tcDbAnalytics.TabIndex = 0
        ' 
        ' tpDbTableSizes
        ' 
        tpDbTableSizes.Controls.Add(dgvTableSizes)
        tpDbTableSizes.Location = New Point(4, 24)
        tpDbTableSizes.Name = "tpDbTableSizes"
        tpDbTableSizes.Padding = New Padding(3)
        tpDbTableSizes.Size = New Size(785, 490)
        tpDbTableSizes.TabIndex = 1
        tpDbTableSizes.Text = "Tables Sizes"
        tpDbTableSizes.UseVisualStyleBackColor = True
        ' 
        ' dgvTableSizes
        ' 
        dgvTableSizes.AllowUserToResizeRows = False
        dgvTableSizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSizes.Dock = DockStyle.Fill
        dgvTableSizes.Location = New Point(3, 3)
        dgvTableSizes.Name = "dgvTableSizes"
        dgvTableSizes.Size = New Size(779, 484)
        dgvTableSizes.TabIndex = 0
        ' 
        ' tpSizeByDay
        ' 
        tpSizeByDay.Controls.Add(dgvGrowthByDay)
        tpSizeByDay.Location = New Point(4, 24)
        tpSizeByDay.Name = "tpSizeByDay"
        tpSizeByDay.Padding = New Padding(3)
        tpSizeByDay.Size = New Size(785, 490)
        tpSizeByDay.TabIndex = 0
        tpSizeByDay.Text = "Growth by Day"
        tpSizeByDay.UseVisualStyleBackColor = True
        ' 
        ' dgvGrowthByDay
        ' 
        dgvGrowthByDay.AllowUserToResizeRows = False
        dgvGrowthByDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGrowthByDay.Dock = DockStyle.Fill
        dgvGrowthByDay.Location = New Point(3, 3)
        dgvGrowthByDay.Name = "dgvGrowthByDay"
        dgvGrowthByDay.Size = New Size(779, 484)
        dgvGrowthByDay.TabIndex = 0
        ' 
        ' tpOptions
        ' 
        tpOptions.BackColor = SystemColors.ControlDark
        tpOptions.Controls.Add(gbTechAssistOptions)
        tpOptions.Location = New Point(4, 24)
        tpOptions.Name = "tpOptions"
        tpOptions.Size = New Size(799, 524)
        tpOptions.TabIndex = 3
        tpOptions.Text = "Options"
        ' 
        ' gbTechAssistOptions
        ' 
        gbTechAssistOptions.BackColor = SystemColors.Control
        gbTechAssistOptions.Controls.Add(tbWindowTitle)
        gbTechAssistOptions.Controls.Add(lblWindowTitle)
        gbTechAssistOptions.Location = New Point(5, 8)
        gbTechAssistOptions.Name = "gbTechAssistOptions"
        gbTechAssistOptions.Size = New Size(723, 193)
        gbTechAssistOptions.TabIndex = 0
        gbTechAssistOptions.TabStop = False
        gbTechAssistOptions.Text = "Tech Assistant Options"
        ' 
        ' tbWindowTitle
        ' 
        tbWindowTitle.Location = New Point(116, 21)
        tbWindowTitle.Name = "tbWindowTitle"
        tbWindowTitle.Size = New Size(273, 23)
        tbWindowTitle.TabIndex = 1
        tbWindowTitle.Text = "tbWindowTitle"
        ' 
        ' lblWindowTitle
        ' 
        lblWindowTitle.AutoSize = True
        lblWindowTitle.Location = New Point(23, 24)
        lblWindowTitle.Name = "lblWindowTitle"
        lblWindowTitle.Size = New Size(86, 15)
        lblWindowTitle.TabIndex = 0
        lblWindowTitle.Text = "Window Title:  "
        ' 
        ' tpServices
        ' 
        tpServices.Controls.Add(gbServices)
        tpServices.Location = New Point(4, 24)
        tpServices.Name = "tpServices"
        tpServices.Padding = New Padding(3)
        tpServices.Size = New Size(799, 524)
        tpServices.TabIndex = 4
        tpServices.Text = "Services"
        tpServices.UseVisualStyleBackColor = True
        ' 
        ' gbServices
        ' 
        gbServices.Controls.Add(tlpServices)
        gbServices.Location = New Point(6, 27)
        gbServices.Name = "gbServices"
        gbServices.Size = New Size(515, 384)
        gbServices.TabIndex = 1
        gbServices.TabStop = False
        gbServices.Text = "Services Controls"
        ' 
        ' tlpServices
        ' 
        tlpServices.ColumnCount = 3
        tlpServices.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpServices.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 252F))
        tlpServices.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 88F))
        tlpServices.Controls.Add(flpServicesButtons, 2, 0)
        tlpServices.Controls.Add(dgvServices, 0, 0)
        tlpServices.Controls.Add(pbServices, 1, 1)
        tlpServices.Controls.Add(lblServiceStatus, 0, 1)
        tlpServices.Dock = DockStyle.Fill
        tlpServices.Location = New Point(3, 19)
        tlpServices.Name = "tlpServices"
        tlpServices.RowCount = 2
        tlpServices.RowStyles.Add(New RowStyle(SizeType.Percent, 90.88398F))
        tlpServices.RowStyles.Add(New RowStyle(SizeType.Percent, 9.116022F))
        tlpServices.Size = New Size(509, 362)
        tlpServices.TabIndex = 0
        ' 
        ' flpServicesButtons
        ' 
        flpServicesButtons.Controls.Add(btnServicesRefresh)
        flpServicesButtons.Controls.Add(btnServiceStart)
        flpServicesButtons.Controls.Add(btnServiceStop)
        flpServicesButtons.Controls.Add(btnServiceRestart)
        flpServicesButtons.Dock = DockStyle.Top
        flpServicesButtons.FlowDirection = FlowDirection.TopDown
        flpServicesButtons.Location = New Point(424, 3)
        flpServicesButtons.Name = "flpServicesButtons"
        flpServicesButtons.Size = New Size(82, 124)
        flpServicesButtons.TabIndex = 6
        ' 
        ' btnServicesRefresh
        ' 
        btnServicesRefresh.Location = New Point(3, 3)
        btnServicesRefresh.Name = "btnServicesRefresh"
        btnServicesRefresh.Size = New Size(75, 23)
        btnServicesRefresh.TabIndex = 2
        btnServicesRefresh.Text = "Refresh"
        btnServicesRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnServiceStart
        ' 
        btnServiceStart.Location = New Point(3, 32)
        btnServiceStart.Name = "btnServiceStart"
        btnServiceStart.Size = New Size(75, 23)
        btnServiceStart.TabIndex = 3
        btnServiceStart.Text = "Start"
        btnServiceStart.UseVisualStyleBackColor = True
        ' 
        ' btnServiceStop
        ' 
        btnServiceStop.Location = New Point(3, 61)
        btnServiceStop.Name = "btnServiceStop"
        btnServiceStop.Size = New Size(75, 23)
        btnServiceStop.TabIndex = 4
        btnServiceStop.Text = "Stop"
        btnServiceStop.UseVisualStyleBackColor = True
        ' 
        ' btnServiceRestart
        ' 
        btnServiceRestart.Location = New Point(3, 90)
        btnServiceRestart.Name = "btnServiceRestart"
        btnServiceRestart.Size = New Size(75, 23)
        btnServiceRestart.TabIndex = 5
        btnServiceRestart.Text = "Restart"
        btnServiceRestart.UseVisualStyleBackColor = True
        ' 
        ' dgvServices
        ' 
        dgvServices.AllowUserToAddRows = False
        dgvServices.AllowUserToDeleteRows = False
        dgvServices.AllowUserToResizeColumns = False
        dgvServices.AllowUserToResizeRows = False
        dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tlpServices.SetColumnSpan(dgvServices, 2)
        dgvServices.Dock = DockStyle.Fill
        dgvServices.Location = New Point(3, 3)
        dgvServices.Name = "dgvServices"
        dgvServices.ReadOnly = True
        dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvServices.Size = New Size(415, 323)
        dgvServices.TabIndex = 0
        ' 
        ' pbServices
        ' 
        tlpServices.SetColumnSpan(pbServices, 2)
        pbServices.Dock = DockStyle.Fill
        pbServices.Location = New Point(172, 332)
        pbServices.MarqueeAnimationSpeed = 30
        pbServices.Name = "pbServices"
        pbServices.Size = New Size(334, 27)
        pbServices.Style = ProgressBarStyle.Marquee
        pbServices.TabIndex = 6
        pbServices.Visible = False
        ' 
        ' lblServiceStatus
        ' 
        lblServiceStatus.AutoSize = True
        lblServiceStatus.Dock = DockStyle.Fill
        lblServiceStatus.Location = New Point(3, 329)
        lblServiceStatus.Name = "lblServiceStatus"
        lblServiceStatus.Size = New Size(163, 33)
        lblServiceStatus.TabIndex = 7
        lblServiceStatus.Text = "Label1"
        lblServiceStatus.Visible = False
        ' 
        ' tlpFormMain
        ' 
        tlpFormMain.ColumnCount = 3
        tlpFormMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 76.06232F))
        tlpFormMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.93768F))
        tlpFormMain.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 160F))
        tlpFormMain.Controls.Add(tcFormMain, 0, 0)
        tlpFormMain.Controls.Add(flpFormButtonsBottom, 1, 1)
        tlpFormMain.Controls.Add(flpTest, 0, 1)
        tlpFormMain.Controls.Add(scFormMainTopRight, 1, 0)
        tlpFormMain.Controls.Add(flpAppButtons, 2, 0)
        tlpFormMain.Dock = DockStyle.Fill
        tlpFormMain.Location = New Point(0, 0)
        tlpFormMain.Name = "tlpFormMain"
        tlpFormMain.RowCount = 2
        tlpFormMain.RowStyles.Add(New RowStyle(SizeType.Percent, 84.42822F))
        tlpFormMain.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5717764F))
        tlpFormMain.Size = New Size(1230, 661)
        tlpFormMain.TabIndex = 7
        ' 
        ' flpFormButtonsBottom
        ' 
        flpFormButtonsBottom.Controls.Add(btnCancel)
        flpFormButtonsBottom.Controls.Add(btnAdminUnlock)
        flpFormButtonsBottom.Dock = DockStyle.Bottom
        flpFormButtonsBottom.Location = New Point(816, 561)
        flpFormButtonsBottom.Name = "flpFormButtonsBottom"
        flpFormButtonsBottom.Size = New Size(250, 97)
        flpFormButtonsBottom.TabIndex = 8
        ' 
        ' btnAdminUnlock
        ' 
        btnAdminUnlock.Location = New Point(84, 3)
        btnAdminUnlock.Name = "btnAdminUnlock"
        btnAdminUnlock.Size = New Size(83, 55)
        btnAdminUnlock.TabIndex = 2
        btnAdminUnlock.Text = "Unlock Admin Account"
        btnAdminUnlock.UseVisualStyleBackColor = True
        ' 
        ' flpTest
        ' 
        flpTest.Controls.Add(btnTest1)
        flpTest.Controls.Add(btnTest2)
        flpTest.Controls.Add(btnTest3)
        flpTest.Controls.Add(btnTest4)
        flpTest.Controls.Add(tbTest1)
        flpTest.Controls.Add(flpAdvButtons)
        flpTest.Controls.Add(flpUtilityButtons)
        flpTest.Location = New Point(3, 561)
        flpTest.Name = "flpTest"
        flpTest.Size = New Size(807, 97)
        flpTest.TabIndex = 9
        ' 
        ' btnTest2
        ' 
        btnTest2.Location = New Point(84, 3)
        btnTest2.Name = "btnTest2"
        btnTest2.Size = New Size(75, 23)
        btnTest2.TabIndex = 4
        btnTest2.Text = "Test2"
        btnTest2.UseVisualStyleBackColor = True
        ' 
        ' btnTest3
        ' 
        btnTest3.Location = New Point(165, 3)
        btnTest3.Name = "btnTest3"
        btnTest3.Size = New Size(75, 23)
        btnTest3.TabIndex = 5
        btnTest3.Text = "Test3"
        btnTest3.UseVisualStyleBackColor = True
        ' 
        ' btnTest4
        ' 
        btnTest4.Location = New Point(246, 3)
        btnTest4.Name = "btnTest4"
        btnTest4.Size = New Size(75, 23)
        btnTest4.TabIndex = 6
        btnTest4.Text = "Test4"
        btnTest4.UseVisualStyleBackColor = True
        ' 
        ' tbTest1
        ' 
        tbTest1.Location = New Point(327, 3)
        tbTest1.Name = "tbTest1"
        tbTest1.Size = New Size(469, 23)
        tbTest1.TabIndex = 7
        tbTest1.Text = "tbTest1"
        ' 
        ' flpAdvButtons
        ' 
        flpAdvButtons.BorderStyle = BorderStyle.Fixed3D
        flpAdvButtons.Controls.Add(btnAdvManager)
        flpAdvButtons.Controls.Add(btnPos)
        flpAdvButtons.Controls.Add(btnAdvGroups)
        flpAdvButtons.Controls.Add(btnAdvRedeem)
        flpAdvButtons.Controls.Add(btnKioskSetup)
        flpAdvButtons.Controls.Add(btnAdvKiosk)
        flpAdvButtons.Controls.Add(btnAdvReportEditor)
        flpAdvButtons.Location = New Point(3, 32)
        flpAdvButtons.Name = "flpAdvButtons"
        flpAdvButtons.Size = New Size(436, 56)
        flpAdvButtons.TabIndex = 16
        ' 
        ' btnAdvManager
        ' 
        btnAdvManager.Location = New Point(3, 3)
        btnAdvManager.Name = "btnAdvManager"
        btnAdvManager.Size = New Size(42, 42)
        btnAdvManager.TabIndex = 8
        btnAdvManager.UseVisualStyleBackColor = True
        ' 
        ' btnPos
        ' 
        btnPos.Location = New Point(51, 3)
        btnPos.Name = "btnPos"
        btnPos.Size = New Size(42, 42)
        btnPos.TabIndex = 9
        btnPos.UseVisualStyleBackColor = True
        ' 
        ' btnAdvGroups
        ' 
        btnAdvGroups.Location = New Point(99, 3)
        btnAdvGroups.Name = "btnAdvGroups"
        btnAdvGroups.Size = New Size(42, 42)
        btnAdvGroups.TabIndex = 10
        btnAdvGroups.UseVisualStyleBackColor = True
        ' 
        ' btnAdvRedeem
        ' 
        btnAdvRedeem.Location = New Point(147, 3)
        btnAdvRedeem.Name = "btnAdvRedeem"
        btnAdvRedeem.Size = New Size(42, 42)
        btnAdvRedeem.TabIndex = 11
        btnAdvRedeem.UseVisualStyleBackColor = True
        ' 
        ' btnKioskSetup
        ' 
        btnKioskSetup.Location = New Point(195, 3)
        btnKioskSetup.Name = "btnKioskSetup"
        btnKioskSetup.Size = New Size(42, 42)
        btnKioskSetup.TabIndex = 12
        btnKioskSetup.UseVisualStyleBackColor = True
        ' 
        ' btnAdvKiosk
        ' 
        btnAdvKiosk.Location = New Point(243, 3)
        btnAdvKiosk.Name = "btnAdvKiosk"
        btnAdvKiosk.Size = New Size(42, 42)
        btnAdvKiosk.TabIndex = 13
        btnAdvKiosk.UseVisualStyleBackColor = True
        ' 
        ' btnAdvReportEditor
        ' 
        btnAdvReportEditor.Location = New Point(291, 3)
        btnAdvReportEditor.Name = "btnAdvReportEditor"
        btnAdvReportEditor.Size = New Size(42, 42)
        btnAdvReportEditor.TabIndex = 13
        btnAdvReportEditor.UseVisualStyleBackColor = True
        ' 
        ' flpUtilityButtons
        ' 
        flpUtilityButtons.BorderStyle = BorderStyle.Fixed3D
        flpUtilityButtons.Controls.Add(btnTaskManager)
        flpUtilityButtons.Controls.Add(btnCalculator)
        flpUtilityButtons.Controls.Add(btnServices)
        flpUtilityButtons.Controls.Add(btnEventViewer)
        flpUtilityButtons.Location = New Point(445, 32)
        flpUtilityButtons.Name = "flpUtilityButtons"
        flpUtilityButtons.Size = New Size(351, 56)
        flpUtilityButtons.TabIndex = 15
        ' 
        ' btnTaskManager
        ' 
        btnTaskManager.Location = New Point(3, 3)
        btnTaskManager.Name = "btnTaskManager"
        btnTaskManager.Size = New Size(42, 42)
        btnTaskManager.TabIndex = 15
        btnTaskManager.UseVisualStyleBackColor = True
        ' 
        ' btnCalculator
        ' 
        btnCalculator.Location = New Point(51, 3)
        btnCalculator.Name = "btnCalculator"
        btnCalculator.Size = New Size(42, 42)
        btnCalculator.TabIndex = 14
        btnCalculator.UseVisualStyleBackColor = True
        ' 
        ' btnServices
        ' 
        btnServices.Location = New Point(99, 3)
        btnServices.Name = "btnServices"
        btnServices.Size = New Size(42, 42)
        btnServices.TabIndex = 16
        btnServices.UseVisualStyleBackColor = True
        ' 
        ' btnEventViewer
        ' 
        btnEventViewer.Location = New Point(147, 3)
        btnEventViewer.Name = "btnEventViewer"
        btnEventViewer.Size = New Size(42, 42)
        btnEventViewer.TabIndex = 17
        btnEventViewer.UseVisualStyleBackColor = True
        ' 
        ' scFormMainTopRight
        ' 
        scFormMainTopRight.Dock = DockStyle.Fill
        scFormMainTopRight.Location = New Point(816, 3)
        scFormMainTopRight.Name = "scFormMainTopRight"
        scFormMainTopRight.Orientation = Orientation.Horizontal
        ' 
        ' scFormMainTopRight.Panel1
        ' 
        scFormMainTopRight.Panel1.Controls.Add(flpFormButtonsTop)
        ' 
        ' scFormMainTopRight.Panel2
        ' 
        scFormMainTopRight.Panel2.Controls.Add(rtbHints)
        scFormMainTopRight.Size = New Size(250, 552)
        scFormMainTopRight.SplitterDistance = 337
        scFormMainTopRight.TabIndex = 10
        ' 
        ' flpFormButtonsTop
        ' 
        flpFormButtonsTop.Controls.Add(btnTestConnection)
        flpFormButtonsTop.Controls.Add(btnTestUpdate)
        flpFormButtonsTop.Controls.Add(btnTestConnect)
        flpFormButtonsTop.Dock = DockStyle.Fill
        flpFormButtonsTop.Location = New Point(0, 0)
        flpFormButtonsTop.Name = "flpFormButtonsTop"
        flpFormButtonsTop.Size = New Size(250, 337)
        flpFormButtonsTop.TabIndex = 7
        ' 
        ' rtbHints
        ' 
        rtbHints.BackColor = SystemColors.Info
        rtbHints.BorderStyle = BorderStyle.FixedSingle
        rtbHints.Dock = DockStyle.Fill
        rtbHints.ForeColor = SystemColors.InfoText
        rtbHints.Location = New Point(0, 0)
        rtbHints.Name = "rtbHints"
        rtbHints.ReadOnly = True
        rtbHints.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbHints.Size = New Size(250, 211)
        rtbHints.TabIndex = 0
        rtbHints.Text = ""
        ' 
        ' flpAppButtons
        ' 
        flpAppButtons.Controls.Add(PictureBox1)
        flpAppButtons.Dock = DockStyle.Fill
        flpAppButtons.Location = New Point(1072, 3)
        flpAppButtons.Name = "flpAppButtons"
        tlpFormMain.SetRowSpan(flpAppButtons, 2)
        flpAppButtons.Size = New Size(155, 655)
        flpAppButtons.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ttAdvantageButtons
        ' 
        ttAdvantageButtons.IsBalloon = True
        ttAdvantageButtons.ToolTipIcon = ToolTipIcon.Info
        ttAdvantageButtons.ToolTipTitle = "CenterEdge Advantage"
        ' 
        ' ttUtilityButtons
        ' 
        ttUtilityButtons.IsBalloon = True
        ttUtilityButtons.ToolTipIcon = ToolTipIcon.Info
        ttUtilityButtons.ToolTipTitle = "Windows Utilities"
        ' 
        ' tmrServices
        ' 
        tmrServices.Interval = 1000
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1230, 661)
        Controls.Add(tlpFormMain)
        ForeColor = SystemColors.ControlText
        Name = "FormMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMain"
        tcFormMain.ResumeLayout(False)
        tpSystemInfo.ResumeLayout(False)
        CType(dgvSystemInfo, ComponentModel.ISupportInitialize).EndInit()
        tpDbInfo.ResumeLayout(False)
        tcDbInfo.ResumeLayout(False)
        tpApplicationInfo.ResumeLayout(False)
        CType(dgvApplicationInfo, ComponentModel.ISupportInitialize).EndInit()
        tpAppOptions.ResumeLayout(False)
        CType(dgvAppOptions, ComponentModel.ISupportInitialize).EndInit()
        tpWebOptions.ResumeLayout(False)
        CType(dgvWebOptions, ComponentModel.ISupportInitialize).EndInit()
        tpDbAnalytics.ResumeLayout(False)
        tcDbAnalytics.ResumeLayout(False)
        tpDbTableSizes.ResumeLayout(False)
        CType(dgvTableSizes, ComponentModel.ISupportInitialize).EndInit()
        tpSizeByDay.ResumeLayout(False)
        CType(dgvGrowthByDay, ComponentModel.ISupportInitialize).EndInit()
        tpOptions.ResumeLayout(False)
        gbTechAssistOptions.ResumeLayout(False)
        gbTechAssistOptions.PerformLayout()
        tpServices.ResumeLayout(False)
        gbServices.ResumeLayout(False)
        tlpServices.ResumeLayout(False)
        tlpServices.PerformLayout()
        flpServicesButtons.ResumeLayout(False)
        CType(dgvServices, ComponentModel.ISupportInitialize).EndInit()
        tlpFormMain.ResumeLayout(False)
        flpFormButtonsBottom.ResumeLayout(False)
        flpTest.ResumeLayout(False)
        flpTest.PerformLayout()
        flpAdvButtons.ResumeLayout(False)
        flpUtilityButtons.ResumeLayout(False)
        scFormMainTopRight.Panel1.ResumeLayout(False)
        scFormMainTopRight.Panel2.ResumeLayout(False)
        CType(scFormMainTopRight, ComponentModel.ISupportInitialize).EndInit()
        scFormMainTopRight.ResumeLayout(False)
        flpFormButtonsTop.ResumeLayout(False)
        flpAppButtons.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTestConnection As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTest1 As Button
    Friend WithEvents btnTestUpdate As Button
    Friend WithEvents btnTestConnect As Button
    Friend WithEvents tcFormMain As TabControl
    Friend WithEvents tpSystemInfo As TabPage
    Friend WithEvents tpDbInfo As TabPage
    Friend WithEvents tpDbAnalytics As TabPage
    Friend WithEvents dgvAppOptions As DataGridView
    Friend WithEvents dgvApplicationInfo As DataGridView
    Friend WithEvents tlpFormMain As TableLayoutPanel
    Friend WithEvents flpFormButtonsTop As FlowLayoutPanel
    Friend WithEvents flpFormButtonsBottom As FlowLayoutPanel
    Friend WithEvents tcDbInfo As TabControl
    Friend WithEvents tpApplicationInfo As TabPage
    Friend WithEvents tpAppOptions As TabPage
    Friend WithEvents tpWebOptions As TabPage
    Friend WithEvents dgvWebOptions As DataGridView
    Friend WithEvents dgvSystemInfo As DataGridView
    Friend WithEvents flpTest As FlowLayoutPanel
    Friend WithEvents btnTest2 As Button
    Friend WithEvents btnTest3 As Button
    Friend WithEvents btnTest4 As Button
    Friend WithEvents tcDbAnalytics As TabControl
    Friend WithEvents tpSizeByDay As TabPage
    Friend WithEvents tpDbTableSizes As TabPage
    Friend WithEvents dgvTableSizes As DataGridView
    Friend WithEvents dgvGrowthByDay As DataGridView
    Friend WithEvents tpOptions As TabPage
    Friend WithEvents gbTechAssistOptions As GroupBox
    Friend WithEvents tbWindowTitle As TextBox
    Friend WithEvents lblWindowTitle As Label
    Friend WithEvents scFormMainTopRight As SplitContainer
    Friend WithEvents rtbHints As RichTextBox
    Friend WithEvents tbTest1 As TextBox
    Friend WithEvents btnAdvManager As Button
    Friend WithEvents btnPos As Button
    Friend WithEvents btnAdvGroups As Button
    Friend WithEvents ttAdvantageButtons As ToolTip
    Friend WithEvents btnAdvRedeem As Button
    Friend WithEvents btnKioskSetup As Button
    Friend WithEvents btnAdvKiosk As Button
    Friend WithEvents btnAdvReportEditor As Button
    Friend WithEvents btnCalculator As Button
    Friend WithEvents btnTaskManager As Button
    Friend WithEvents flpUtilityButtons As FlowLayoutPanel
    Friend WithEvents btnServices As Button
    Friend WithEvents btnEventViewer As Button
    Friend WithEvents ttUtilityButtons As ToolTip
    Friend WithEvents flpAdvButtons As FlowLayoutPanel
    Friend WithEvents flpAppButtons As FlowLayoutPanel
    Friend WithEvents btnAdminUnlock As Button
    Friend WithEvents tpServices As TabPage
    Friend WithEvents dgvServices As DataGridView
    Friend WithEvents btnServiceRestart As Button
    Friend WithEvents btnServiceStop As Button
    Friend WithEvents btnServiceStart As Button
    Friend WithEvents btnServicesRefresh As Button
    Friend WithEvents gbServices As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrServices As Timer
    Friend WithEvents lblServiceStatus As Label
    Friend WithEvents pbServices As ProgressBar
    Friend WithEvents tlpServices As TableLayoutPanel
    Friend WithEvents flpServicesButtons As FlowLayoutPanel

End Class
