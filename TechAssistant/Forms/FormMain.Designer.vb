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
        tpOptions = New TabPage()
        gbTechAssistOptions = New GroupBox()
        tbWindowTitle = New TextBox()
        lblWindowTitle = New Label()
        tpNetworkDiagnostics = New TabPage()
        tcNetworkDiagnostics = New TabControl()
        tpPing = New TabPage()
        rtbPingResults = New RichTextBox()
        btnPing = New Button()
        nudPingCount = New NumericUpDown()
        lblPingCount = New Label()
        tbPingHost = New TextBox()
        lblPingHost = New Label()
        tpTcpPortTest = New TabPage()
        btnPortsCore = New Button()
        btnPortsClearAll = New Button()
        btnPortsSelectAll = New Button()
        clbPorts = New CheckedListBox()
        lblPortsClosed = New Label()
        lblPortsOpen = New Label()
        btnValidateCenterEdgePorts = New Button()
        dgvPortValidation = New DataGridView()
        cbPortPresets = New ComboBox()
        rtbTcpResults = New RichTextBox()
        btnTcpTest = New Button()
        nudTcpPort = New NumericUpDown()
        tbTcpHost = New TextBox()
        tpPortProcessMap = New TabPage()
        dgvPortProcesses = New DataGridView()
        btnRefreshPortProcesses = New Button()
        chkCenterEdgePortsOnly = New CheckBox()
        tpHttpValidation = New TabPage()
        chkShowResponseHeaders = New CheckBox()
        rtbHttpResults = New RichTextBox()
        btnHttpTest = New Button()
        lblHttpUrl = New Label()
        tbHttpUrl = New TextBox()
        tpUpgradeCheck = New TabPage()
        btnCopyToClipboard = New Button()
        btnExportText = New Button()
        TextBox1 = New TextBox()
        btnUpgradeCheck = New Button()
        tlpUpgradeCheck = New TableLayoutPanel()
        lblLocation = New Label()
        tbRiskLevel = New TextBox()
        tbLocation = New TextBox()
        tbDatabaseSize = New TextBox()
        lblRiskLevel = New Label()
        tbOsVersion = New TextBox()
        lblSqlVersion = New Label()
        tbSqlVersion = New TextBox()
        lblOsVersion = New Label()
        lblDatabaseSize = New Label()
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
        btnAppWiz = New Button()
        btnDevices = New Button()
        scFormMainTopRight = New SplitContainer()
        flpFormButtonsTop = New FlowLayoutPanel()
        rtbHints = New RichTextBox()
        flpAppButtons = New FlowLayoutPanel()
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
        tpServices.SuspendLayout()
        gbServices.SuspendLayout()
        tlpServices.SuspendLayout()
        flpServicesButtons.SuspendLayout()
        CType(dgvServices, ComponentModel.ISupportInitialize).BeginInit()
        tpOptions.SuspendLayout()
        gbTechAssistOptions.SuspendLayout()
        tpNetworkDiagnostics.SuspendLayout()
        tcNetworkDiagnostics.SuspendLayout()
        tpPing.SuspendLayout()
        CType(nudPingCount, ComponentModel.ISupportInitialize).BeginInit()
        tpTcpPortTest.SuspendLayout()
        CType(dgvPortValidation, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTcpPort, ComponentModel.ISupportInitialize).BeginInit()
        tpPortProcessMap.SuspendLayout()
        CType(dgvPortProcesses, ComponentModel.ISupportInitialize).BeginInit()
        tpHttpValidation.SuspendLayout()
        tpUpgradeCheck.SuspendLayout()
        tlpUpgradeCheck.SuspendLayout()
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
        btnTestUpdate.Location = New Point(131, 3)
        btnTestUpdate.Name = "btnTestUpdate"
        btnTestUpdate.Size = New Size(122, 23)
        btnTestUpdate.TabIndex = 4
        btnTestUpdate.Text = "Test Update"
        btnTestUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnTestConnect
        ' 
        btnTestConnect.Location = New Point(3, 32)
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
        tcFormMain.Controls.Add(tpNetworkDiagnostics)
        tcFormMain.Controls.Add(tpUpgradeCheck)
        tcFormMain.Dock = DockStyle.Fill
        tcFormMain.Location = New Point(3, 3)
        tcFormMain.Name = "tcFormMain"
        tcFormMain.SelectedIndex = 0
        tcFormMain.Size = New Size(883, 548)
        tcFormMain.TabIndex = 6
        ' 
        ' tpSystemInfo
        ' 
        tpSystemInfo.BackColor = SystemColors.ControlDark
        tpSystemInfo.Controls.Add(dgvSystemInfo)
        tpSystemInfo.Location = New Point(4, 24)
        tpSystemInfo.Name = "tpSystemInfo"
        tpSystemInfo.Padding = New Padding(3)
        tpSystemInfo.Size = New Size(875, 520)
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
        dgvSystemInfo.Size = New Size(869, 514)
        dgvSystemInfo.TabIndex = 2
        ' 
        ' tpDbInfo
        ' 
        tpDbInfo.Controls.Add(tcDbInfo)
        tpDbInfo.Location = New Point(4, 24)
        tpDbInfo.Name = "tpDbInfo"
        tpDbInfo.Padding = New Padding(3)
        tpDbInfo.Size = New Size(875, 520)
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
        tcDbInfo.Size = New Size(869, 514)
        tcDbInfo.TabIndex = 1
        ' 
        ' tpApplicationInfo
        ' 
        tpApplicationInfo.BackColor = SystemColors.ControlDark
        tpApplicationInfo.Controls.Add(dgvApplicationInfo)
        tpApplicationInfo.Location = New Point(4, 24)
        tpApplicationInfo.Name = "tpApplicationInfo"
        tpApplicationInfo.Padding = New Padding(3)
        tpApplicationInfo.Size = New Size(861, 486)
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
        dgvApplicationInfo.Size = New Size(855, 480)
        dgvApplicationInfo.TabIndex = 0
        ' 
        ' tpAppOptions
        ' 
        tpAppOptions.Controls.Add(dgvAppOptions)
        tpAppOptions.Location = New Point(4, 24)
        tpAppOptions.Name = "tpAppOptions"
        tpAppOptions.Padding = New Padding(3)
        tpAppOptions.Size = New Size(861, 486)
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
        dgvAppOptions.Size = New Size(855, 480)
        dgvAppOptions.TabIndex = 0
        ' 
        ' tpWebOptions
        ' 
        tpWebOptions.Controls.Add(dgvWebOptions)
        tpWebOptions.Location = New Point(4, 24)
        tpWebOptions.Name = "tpWebOptions"
        tpWebOptions.Padding = New Padding(3)
        tpWebOptions.Size = New Size(861, 486)
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
        dgvWebOptions.Size = New Size(855, 480)
        dgvWebOptions.TabIndex = 1
        ' 
        ' tpDbAnalytics
        ' 
        tpDbAnalytics.BackColor = SystemColors.ControlDark
        tpDbAnalytics.Controls.Add(tcDbAnalytics)
        tpDbAnalytics.Location = New Point(4, 24)
        tpDbAnalytics.Name = "tpDbAnalytics"
        tpDbAnalytics.Padding = New Padding(3)
        tpDbAnalytics.Size = New Size(875, 520)
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
        tcDbAnalytics.Size = New Size(869, 514)
        tcDbAnalytics.TabIndex = 0
        ' 
        ' tpDbTableSizes
        ' 
        tpDbTableSizes.Controls.Add(dgvTableSizes)
        tpDbTableSizes.Location = New Point(4, 24)
        tpDbTableSizes.Name = "tpDbTableSizes"
        tpDbTableSizes.Padding = New Padding(3)
        tpDbTableSizes.Size = New Size(861, 486)
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
        dgvTableSizes.Size = New Size(855, 480)
        dgvTableSizes.TabIndex = 0
        ' 
        ' tpSizeByDay
        ' 
        tpSizeByDay.Controls.Add(dgvGrowthByDay)
        tpSizeByDay.Location = New Point(4, 24)
        tpSizeByDay.Name = "tpSizeByDay"
        tpSizeByDay.Padding = New Padding(3)
        tpSizeByDay.Size = New Size(861, 486)
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
        dgvGrowthByDay.Size = New Size(855, 480)
        dgvGrowthByDay.TabIndex = 0
        ' 
        ' tpServices
        ' 
        tpServices.Controls.Add(gbServices)
        tpServices.Location = New Point(4, 24)
        tpServices.Name = "tpServices"
        tpServices.Padding = New Padding(3)
        tpServices.Size = New Size(875, 520)
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
        ' tpOptions
        ' 
        tpOptions.BackColor = SystemColors.ControlDark
        tpOptions.Controls.Add(gbTechAssistOptions)
        tpOptions.Location = New Point(4, 24)
        tpOptions.Name = "tpOptions"
        tpOptions.Size = New Size(875, 520)
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
        ' tpNetworkDiagnostics
        ' 
        tpNetworkDiagnostics.Controls.Add(tcNetworkDiagnostics)
        tpNetworkDiagnostics.Location = New Point(4, 24)
        tpNetworkDiagnostics.Name = "tpNetworkDiagnostics"
        tpNetworkDiagnostics.Padding = New Padding(3)
        tpNetworkDiagnostics.Size = New Size(875, 520)
        tpNetworkDiagnostics.TabIndex = 5
        tpNetworkDiagnostics.Text = "Network Diagnostics"
        tpNetworkDiagnostics.UseVisualStyleBackColor = True
        ' 
        ' tcNetworkDiagnostics
        ' 
        tcNetworkDiagnostics.Controls.Add(tpPing)
        tcNetworkDiagnostics.Controls.Add(tpTcpPortTest)
        tcNetworkDiagnostics.Controls.Add(tpPortProcessMap)
        tcNetworkDiagnostics.Controls.Add(tpHttpValidation)
        tcNetworkDiagnostics.Dock = DockStyle.Fill
        tcNetworkDiagnostics.Location = New Point(3, 3)
        tcNetworkDiagnostics.Name = "tcNetworkDiagnostics"
        tcNetworkDiagnostics.SelectedIndex = 0
        tcNetworkDiagnostics.Size = New Size(869, 514)
        tcNetworkDiagnostics.TabIndex = 0
        ' 
        ' tpPing
        ' 
        tpPing.Controls.Add(rtbPingResults)
        tpPing.Controls.Add(btnPing)
        tpPing.Controls.Add(nudPingCount)
        tpPing.Controls.Add(lblPingCount)
        tpPing.Controls.Add(tbPingHost)
        tpPing.Controls.Add(lblPingHost)
        tpPing.Location = New Point(4, 24)
        tpPing.Name = "tpPing"
        tpPing.Padding = New Padding(3)
        tpPing.Size = New Size(861, 486)
        tpPing.TabIndex = 0
        tpPing.Text = "Ping"
        tpPing.UseVisualStyleBackColor = True
        ' 
        ' rtbPingResults
        ' 
        rtbPingResults.Location = New Point(296, 124)
        rtbPingResults.Name = "rtbPingResults"
        rtbPingResults.ReadOnly = True
        rtbPingResults.Size = New Size(278, 96)
        rtbPingResults.TabIndex = 5
        rtbPingResults.Text = ""
        ' 
        ' btnPing
        ' 
        btnPing.Location = New Point(135, 176)
        btnPing.Name = "btnPing"
        btnPing.Size = New Size(75, 23)
        btnPing.TabIndex = 4
        btnPing.Text = "Ping"
        btnPing.UseVisualStyleBackColor = True
        ' 
        ' nudPingCount
        ' 
        nudPingCount.Location = New Point(84, 113)
        nudPingCount.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        nudPingCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudPingCount.Name = "nudPingCount"
        nudPingCount.Size = New Size(120, 23)
        nudPingCount.TabIndex = 3
        nudPingCount.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ' 
        ' lblPingCount
        ' 
        lblPingCount.AutoSize = True
        lblPingCount.Location = New Point(22, 103)
        lblPingCount.Name = "lblPingCount"
        lblPingCount.Size = New Size(40, 15)
        lblPingCount.TabIndex = 2
        lblPingCount.Text = "Count"
        ' 
        ' tbPingHost
        ' 
        tbPingHost.Location = New Point(84, 55)
        tbPingHost.Name = "tbPingHost"
        tbPingHost.Size = New Size(100, 23)
        tbPingHost.TabIndex = 1
        tbPingHost.Text = "localhost"
        ' 
        ' lblPingHost
        ' 
        lblPingHost.AutoSize = True
        lblPingHost.Location = New Point(28, 55)
        lblPingHost.Name = "lblPingHost"
        lblPingHost.Size = New Size(32, 15)
        lblPingHost.TabIndex = 0
        lblPingHost.Text = "Host"
        ' 
        ' tpTcpPortTest
        ' 
        tpTcpPortTest.Controls.Add(btnPortsCore)
        tpTcpPortTest.Controls.Add(btnPortsClearAll)
        tpTcpPortTest.Controls.Add(btnPortsSelectAll)
        tpTcpPortTest.Controls.Add(clbPorts)
        tpTcpPortTest.Controls.Add(lblPortsClosed)
        tpTcpPortTest.Controls.Add(lblPortsOpen)
        tpTcpPortTest.Controls.Add(btnValidateCenterEdgePorts)
        tpTcpPortTest.Controls.Add(dgvPortValidation)
        tpTcpPortTest.Controls.Add(cbPortPresets)
        tpTcpPortTest.Controls.Add(rtbTcpResults)
        tpTcpPortTest.Controls.Add(btnTcpTest)
        tpTcpPortTest.Controls.Add(nudTcpPort)
        tpTcpPortTest.Controls.Add(tbTcpHost)
        tpTcpPortTest.Location = New Point(4, 24)
        tpTcpPortTest.Name = "tpTcpPortTest"
        tpTcpPortTest.Padding = New Padding(3)
        tpTcpPortTest.Size = New Size(861, 486)
        tpTcpPortTest.TabIndex = 1
        tpTcpPortTest.Text = "Tcp"
        tpTcpPortTest.UseVisualStyleBackColor = True
        ' 
        ' btnPortsCore
        ' 
        btnPortsCore.Location = New Point(610, 322)
        btnPortsCore.Name = "btnPortsCore"
        btnPortsCore.Size = New Size(75, 23)
        btnPortsCore.TabIndex = 12
        btnPortsCore.Text = "Core Ports"
        btnPortsCore.UseVisualStyleBackColor = True
        ' 
        ' btnPortsClearAll
        ' 
        btnPortsClearAll.Location = New Point(605, 288)
        btnPortsClearAll.Name = "btnPortsClearAll"
        btnPortsClearAll.Size = New Size(75, 23)
        btnPortsClearAll.TabIndex = 11
        btnPortsClearAll.Text = "Clear All"
        btnPortsClearAll.UseVisualStyleBackColor = True
        ' 
        ' btnPortsSelectAll
        ' 
        btnPortsSelectAll.Location = New Point(602, 253)
        btnPortsSelectAll.Name = "btnPortsSelectAll"
        btnPortsSelectAll.Size = New Size(75, 23)
        btnPortsSelectAll.TabIndex = 10
        btnPortsSelectAll.Text = "Select All"
        btnPortsSelectAll.UseVisualStyleBackColor = True
        ' 
        ' clbPorts
        ' 
        clbPorts.CheckOnClick = True
        clbPorts.FormattingEnabled = True
        clbPorts.Location = New Point(223, 236)
        clbPorts.Name = "clbPorts"
        clbPorts.Size = New Size(306, 166)
        clbPorts.TabIndex = 9
        ' 
        ' lblPortsClosed
        ' 
        lblPortsClosed.AutoSize = True
        lblPortsClosed.Location = New Point(129, 461)
        lblPortsClosed.Name = "lblPortsClosed"
        lblPortsClosed.Size = New Size(41, 15)
        lblPortsClosed.TabIndex = 8
        lblPortsClosed.Text = "Label2"
        ' 
        ' lblPortsOpen
        ' 
        lblPortsOpen.AutoSize = True
        lblPortsOpen.Location = New Point(120, 441)
        lblPortsOpen.Name = "lblPortsOpen"
        lblPortsOpen.Size = New Size(41, 15)
        lblPortsOpen.TabIndex = 7
        lblPortsOpen.Text = "Label1"
        ' 
        ' btnValidateCenterEdgePorts
        ' 
        btnValidateCenterEdgePorts.Location = New Point(642, 441)
        btnValidateCenterEdgePorts.Name = "btnValidateCenterEdgePorts"
        btnValidateCenterEdgePorts.Size = New Size(104, 23)
        btnValidateCenterEdgePorts.TabIndex = 6
        btnValidateCenterEdgePorts.Text = "CE Port Tests"
        btnValidateCenterEdgePorts.UseVisualStyleBackColor = True
        ' 
        ' dgvPortValidation
        ' 
        dgvPortValidation.AllowUserToAddRows = False
        dgvPortValidation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPortValidation.Location = New Point(223, 3)
        dgvPortValidation.Name = "dgvPortValidation"
        dgvPortValidation.ReadOnly = True
        dgvPortValidation.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPortValidation.Size = New Size(457, 227)
        dgvPortValidation.TabIndex = 5
        ' 
        ' cbPortPresets
        ' 
        cbPortPresets.FormattingEnabled = True
        cbPortPresets.Items.AddRange(New Object() {"SQL Server (1433)", "License Validation (15050)", "License File Request (15051)", "Fingerprint Service (15054)", "Signage Service (15055)", "Embed Interface (15056)", "LaunchDarkly (15057)", "Advantage API Service (15059)", "Stage/Web 2 (15060)", "Credit Cards (31420)", "Embed Shared Server (58008)", "NetEPay (9000)", "Mercury Gift Cards (9100)"})
        cbPortPresets.Location = New Point(3, 64)
        cbPortPresets.Name = "cbPortPresets"
        cbPortPresets.Size = New Size(201, 23)
        cbPortPresets.TabIndex = 4
        ' 
        ' rtbTcpResults
        ' 
        rtbTcpResults.Location = New Point(6, 93)
        rtbTcpResults.Name = "rtbTcpResults"
        rtbTcpResults.ReadOnly = True
        rtbTcpResults.Size = New Size(190, 243)
        rtbTcpResults.TabIndex = 3
        rtbTcpResults.Text = ""
        ' 
        ' btnTcpTest
        ' 
        btnTcpTest.Location = New Point(138, 6)
        btnTcpTest.Name = "btnTcpTest"
        btnTcpTest.Size = New Size(75, 23)
        btnTcpTest.TabIndex = 2
        btnTcpTest.Text = "Test Port"
        btnTcpTest.UseVisualStyleBackColor = True
        ' 
        ' nudTcpPort
        ' 
        nudTcpPort.Location = New Point(3, 35)
        nudTcpPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        nudTcpPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudTcpPort.Name = "nudTcpPort"
        nudTcpPort.Size = New Size(120, 23)
        nudTcpPort.TabIndex = 1
        nudTcpPort.Value = New Decimal(New Integer() {1433, 0, 0, 0})
        ' 
        ' tbTcpHost
        ' 
        tbTcpHost.Location = New Point(6, 6)
        tbTcpHost.Name = "tbTcpHost"
        tbTcpHost.Size = New Size(100, 23)
        tbTcpHost.TabIndex = 0
        tbTcpHost.Text = "localhost"
        ' 
        ' tpPortProcessMap
        ' 
        tpPortProcessMap.Controls.Add(dgvPortProcesses)
        tpPortProcessMap.Controls.Add(btnRefreshPortProcesses)
        tpPortProcessMap.Controls.Add(chkCenterEdgePortsOnly)
        tpPortProcessMap.Location = New Point(4, 24)
        tpPortProcessMap.Name = "tpPortProcessMap"
        tpPortProcessMap.Padding = New Padding(3)
        tpPortProcessMap.Size = New Size(861, 486)
        tpPortProcessMap.TabIndex = 3
        tpPortProcessMap.Text = "Port To Process Mapping"
        tpPortProcessMap.UseVisualStyleBackColor = True
        ' 
        ' dgvPortProcesses
        ' 
        dgvPortProcesses.AllowUserToAddRows = False
        dgvPortProcesses.AllowUserToDeleteRows = False
        dgvPortProcesses.AllowUserToResizeRows = False
        dgvPortProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvPortProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPortProcesses.Location = New Point(3, 10)
        dgvPortProcesses.Name = "dgvPortProcesses"
        dgvPortProcesses.Size = New Size(751, 375)
        dgvPortProcesses.TabIndex = 1
        ' 
        ' btnRefreshPortProcesses
        ' 
        btnRefreshPortProcesses.Location = New Point(679, 461)
        btnRefreshPortProcesses.Name = "btnRefreshPortProcesses"
        btnRefreshPortProcesses.Size = New Size(75, 23)
        btnRefreshPortProcesses.TabIndex = 0
        btnRefreshPortProcesses.Text = "Refresh"
        btnRefreshPortProcesses.UseVisualStyleBackColor = True
        ' 
        ' chkCenterEdgePortsOnly
        ' 
        chkCenterEdgePortsOnly.AutoSize = True
        chkCenterEdgePortsOnly.Checked = True
        chkCenterEdgePortsOnly.CheckState = CheckState.Checked
        chkCenterEdgePortsOnly.Location = New Point(254, 436)
        chkCenterEdgePortsOnly.Name = "chkCenterEdgePortsOnly"
        chkCenterEdgePortsOnly.Size = New Size(217, 19)
        chkCenterEdgePortsOnly.TabIndex = 2
        chkCenterEdgePortsOnly.Text = "Show Known CenterEdge Ports Only"
        chkCenterEdgePortsOnly.UseVisualStyleBackColor = True
        ' 
        ' tpHttpValidation
        ' 
        tpHttpValidation.Controls.Add(chkShowResponseHeaders)
        tpHttpValidation.Controls.Add(rtbHttpResults)
        tpHttpValidation.Controls.Add(btnHttpTest)
        tpHttpValidation.Controls.Add(lblHttpUrl)
        tpHttpValidation.Controls.Add(tbHttpUrl)
        tpHttpValidation.Location = New Point(4, 24)
        tpHttpValidation.Name = "tpHttpValidation"
        tpHttpValidation.Padding = New Padding(3)
        tpHttpValidation.Size = New Size(861, 486)
        tpHttpValidation.TabIndex = 4
        tpHttpValidation.Text = "HTTP / HTTPS Validation"
        tpHttpValidation.UseVisualStyleBackColor = True
        ' 
        ' chkShowResponseHeaders
        ' 
        chkShowResponseHeaders.AutoSize = True
        chkShowResponseHeaders.Checked = True
        chkShowResponseHeaders.CheckState = CheckState.Checked
        chkShowResponseHeaders.Location = New Point(387, 446)
        chkShowResponseHeaders.Name = "chkShowResponseHeaders"
        chkShowResponseHeaders.Size = New Size(154, 19)
        chkShowResponseHeaders.TabIndex = 4
        chkShowResponseHeaders.Text = "Show Response Headers"
        chkShowResponseHeaders.UseVisualStyleBackColor = True
        ' 
        ' rtbHttpResults
        ' 
        rtbHttpResults.Location = New Point(35, 88)
        rtbHttpResults.Name = "rtbHttpResults"
        rtbHttpResults.ReadOnly = True
        rtbHttpResults.Size = New Size(530, 281)
        rtbHttpResults.TabIndex = 3
        rtbHttpResults.Text = ""
        rtbHttpResults.WordWrap = False
        ' 
        ' btnHttpTest
        ' 
        btnHttpTest.Location = New Point(527, 42)
        btnHttpTest.Name = "btnHttpTest"
        btnHttpTest.Size = New Size(75, 23)
        btnHttpTest.TabIndex = 2
        btnHttpTest.Text = "Test URL"
        btnHttpTest.UseVisualStyleBackColor = True
        ' 
        ' lblHttpUrl
        ' 
        lblHttpUrl.AutoSize = True
        lblHttpUrl.Location = New Point(6, 28)
        lblHttpUrl.Name = "lblHttpUrl"
        lblHttpUrl.Size = New Size(31, 15)
        lblHttpUrl.TabIndex = 1
        lblHttpUrl.Text = "URL:"
        ' 
        ' tbHttpUrl
        ' 
        tbHttpUrl.Location = New Point(43, 25)
        tbHttpUrl.Name = "tbHttpUrl"
        tbHttpUrl.Size = New Size(362, 23)
        tbHttpUrl.TabIndex = 0
        tbHttpUrl.Text = "relay-us-east-1.centeredgeonline.com"
        ' 
        ' tpUpgradeCheck
        ' 
        tpUpgradeCheck.Controls.Add(btnCopyToClipboard)
        tpUpgradeCheck.Controls.Add(btnExportText)
        tpUpgradeCheck.Controls.Add(TextBox1)
        tpUpgradeCheck.Controls.Add(btnUpgradeCheck)
        tpUpgradeCheck.Controls.Add(tlpUpgradeCheck)
        tpUpgradeCheck.Location = New Point(4, 24)
        tpUpgradeCheck.Name = "tpUpgradeCheck"
        tpUpgradeCheck.Padding = New Padding(3)
        tpUpgradeCheck.Size = New Size(875, 520)
        tpUpgradeCheck.TabIndex = 6
        tpUpgradeCheck.Text = "Upgrade Check"
        tpUpgradeCheck.UseVisualStyleBackColor = True
        ' 
        ' btnCopyToClipboard
        ' 
        btnCopyToClipboard.Location = New Point(215, 412)
        btnCopyToClipboard.Name = "btnCopyToClipboard"
        btnCopyToClipboard.Size = New Size(123, 23)
        btnCopyToClipboard.TabIndex = 13
        btnCopyToClipboard.Text = "Copy to Clipboard"
        btnCopyToClipboard.UseVisualStyleBackColor = True
        ' 
        ' btnExportText
        ' 
        btnExportText.Location = New Point(215, 370)
        btnExportText.Name = "btnExportText"
        btnExportText.Size = New Size(75, 23)
        btnExportText.TabIndex = 13
        btnExportText.Text = "Export"
        btnExportText.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(148, 222)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(469, 23)
        TextBox1.TabIndex = 12
        TextBox1.Text = "TextBox1"
        ' 
        ' btnUpgradeCheck
        ' 
        btnUpgradeCheck.Location = New Point(215, 331)
        btnUpgradeCheck.Name = "btnUpgradeCheck"
        btnUpgradeCheck.Size = New Size(102, 23)
        btnUpgradeCheck.TabIndex = 11
        btnUpgradeCheck.Text = "Update Check"
        btnUpgradeCheck.UseVisualStyleBackColor = True
        ' 
        ' tlpUpgradeCheck
        ' 
        tlpUpgradeCheck.ColumnCount = 2
        tlpUpgradeCheck.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.4666672F))
        tlpUpgradeCheck.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80.53333F))
        tlpUpgradeCheck.Controls.Add(lblLocation, 0, 0)
        tlpUpgradeCheck.Controls.Add(tbRiskLevel, 1, 4)
        tlpUpgradeCheck.Controls.Add(tbLocation, 1, 0)
        tlpUpgradeCheck.Controls.Add(tbDatabaseSize, 1, 3)
        tlpUpgradeCheck.Controls.Add(lblRiskLevel, 0, 4)
        tlpUpgradeCheck.Controls.Add(tbOsVersion, 1, 2)
        tlpUpgradeCheck.Controls.Add(lblSqlVersion, 0, 1)
        tlpUpgradeCheck.Controls.Add(tbSqlVersion, 1, 1)
        tlpUpgradeCheck.Controls.Add(lblOsVersion, 0, 2)
        tlpUpgradeCheck.Controls.Add(lblDatabaseSize, 0, 3)
        tlpUpgradeCheck.Location = New Point(6, 6)
        tlpUpgradeCheck.Name = "tlpUpgradeCheck"
        tlpUpgradeCheck.RowCount = 6
        tlpUpgradeCheck.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tlpUpgradeCheck.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tlpUpgradeCheck.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tlpUpgradeCheck.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tlpUpgradeCheck.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tlpUpgradeCheck.RowStyles.Add(New RowStyle())
        tlpUpgradeCheck.Size = New Size(750, 164)
        tlpUpgradeCheck.TabIndex = 10
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Dock = DockStyle.Fill
        lblLocation.Location = New Point(3, 0)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(140, 30)
        lblLocation.TabIndex = 0
        lblLocation.Text = "Location:  "
        lblLocation.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbRiskLevel
        ' 
        tbRiskLevel.Dock = DockStyle.Fill
        tbRiskLevel.Location = New Point(149, 123)
        tbRiskLevel.Name = "tbRiskLevel"
        tbRiskLevel.Size = New Size(598, 23)
        tbRiskLevel.TabIndex = 9
        ' 
        ' tbLocation
        ' 
        tbLocation.Dock = DockStyle.Fill
        tbLocation.Location = New Point(149, 3)
        tbLocation.Name = "tbLocation"
        tbLocation.Size = New Size(598, 23)
        tbLocation.TabIndex = 1
        ' 
        ' tbDatabaseSize
        ' 
        tbDatabaseSize.Dock = DockStyle.Fill
        tbDatabaseSize.Location = New Point(149, 93)
        tbDatabaseSize.Name = "tbDatabaseSize"
        tbDatabaseSize.Size = New Size(598, 23)
        tbDatabaseSize.TabIndex = 7
        ' 
        ' lblRiskLevel
        ' 
        lblRiskLevel.AutoSize = True
        lblRiskLevel.Dock = DockStyle.Fill
        lblRiskLevel.Location = New Point(3, 120)
        lblRiskLevel.Name = "lblRiskLevel"
        lblRiskLevel.Size = New Size(140, 30)
        lblRiskLevel.TabIndex = 8
        lblRiskLevel.Text = "Risk:  "
        lblRiskLevel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbOsVersion
        ' 
        tbOsVersion.Dock = DockStyle.Fill
        tbOsVersion.Location = New Point(149, 63)
        tbOsVersion.Name = "tbOsVersion"
        tbOsVersion.Size = New Size(598, 23)
        tbOsVersion.TabIndex = 5
        ' 
        ' lblSqlVersion
        ' 
        lblSqlVersion.AutoSize = True
        lblSqlVersion.Dock = DockStyle.Fill
        lblSqlVersion.Location = New Point(3, 30)
        lblSqlVersion.Name = "lblSqlVersion"
        lblSqlVersion.Size = New Size(140, 30)
        lblSqlVersion.TabIndex = 2
        lblSqlVersion.Text = "SQL Version:  "
        lblSqlVersion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbSqlVersion
        ' 
        tbSqlVersion.Dock = DockStyle.Fill
        tbSqlVersion.Location = New Point(149, 33)
        tbSqlVersion.Name = "tbSqlVersion"
        tbSqlVersion.Size = New Size(598, 23)
        tbSqlVersion.TabIndex = 3
        ' 
        ' lblOsVersion
        ' 
        lblOsVersion.AutoSize = True
        lblOsVersion.Dock = DockStyle.Fill
        lblOsVersion.Location = New Point(3, 60)
        lblOsVersion.Name = "lblOsVersion"
        lblOsVersion.Size = New Size(140, 30)
        lblOsVersion.TabIndex = 4
        lblOsVersion.Text = "Windows Version: "
        lblOsVersion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDatabaseSize
        ' 
        lblDatabaseSize.AutoSize = True
        lblDatabaseSize.Dock = DockStyle.Fill
        lblDatabaseSize.Location = New Point(3, 90)
        lblDatabaseSize.Name = "lblDatabaseSize"
        lblDatabaseSize.Size = New Size(140, 30)
        lblDatabaseSize.TabIndex = 6
        lblDatabaseSize.Text = "Database Size:  "
        lblDatabaseSize.TextAlign = ContentAlignment.MiddleLeft
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
        tlpFormMain.RowStyles.Add(New RowStyle(SizeType.Percent, 83.81241F))
        tlpFormMain.RowStyles.Add(New RowStyle(SizeType.Percent, 16.1875954F))
        tlpFormMain.Size = New Size(1329, 661)
        tlpFormMain.TabIndex = 7
        ' 
        ' flpFormButtonsBottom
        ' 
        flpFormButtonsBottom.Controls.Add(btnCancel)
        flpFormButtonsBottom.Controls.Add(btnAdminUnlock)
        flpFormButtonsBottom.Dock = DockStyle.Bottom
        flpFormButtonsBottom.Location = New Point(892, 561)
        flpFormButtonsBottom.Name = "flpFormButtonsBottom"
        flpFormButtonsBottom.Size = New Size(273, 97)
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
        flpTest.Dock = DockStyle.Fill
        flpTest.Location = New Point(3, 557)
        flpTest.Name = "flpTest"
        flpTest.Size = New Size(883, 101)
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
        flpAdvButtons.Size = New Size(359, 56)
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
        flpUtilityButtons.Controls.Add(btnAppWiz)
        flpUtilityButtons.Controls.Add(btnDevices)
        flpUtilityButtons.Location = New Point(368, 32)
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
        ' btnAppWiz
        ' 
        btnAppWiz.Location = New Point(195, 3)
        btnAppWiz.Name = "btnAppWiz"
        btnAppWiz.Size = New Size(42, 42)
        btnAppWiz.TabIndex = 18
        btnAppWiz.UseVisualStyleBackColor = True
        ' 
        ' btnDevices
        ' 
        btnDevices.Location = New Point(243, 3)
        btnDevices.Name = "btnDevices"
        btnDevices.Size = New Size(42, 42)
        btnDevices.TabIndex = 19
        btnDevices.UseVisualStyleBackColor = True
        ' 
        ' scFormMainTopRight
        ' 
        scFormMainTopRight.Dock = DockStyle.Fill
        scFormMainTopRight.Location = New Point(892, 3)
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
        scFormMainTopRight.Size = New Size(273, 548)
        scFormMainTopRight.SplitterDistance = 334
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
        flpFormButtonsTop.Size = New Size(273, 334)
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
        rtbHints.Size = New Size(273, 210)
        rtbHints.TabIndex = 0
        rtbHints.Text = ""
        ' 
        ' flpAppButtons
        ' 
        flpAppButtons.Dock = DockStyle.Fill
        flpAppButtons.Location = New Point(1171, 3)
        flpAppButtons.Name = "flpAppButtons"
        tlpFormMain.SetRowSpan(flpAppButtons, 2)
        flpAppButtons.Size = New Size(155, 655)
        flpAppButtons.TabIndex = 11
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
        ClientSize = New Size(1329, 661)
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
        tpServices.ResumeLayout(False)
        gbServices.ResumeLayout(False)
        tlpServices.ResumeLayout(False)
        tlpServices.PerformLayout()
        flpServicesButtons.ResumeLayout(False)
        CType(dgvServices, ComponentModel.ISupportInitialize).EndInit()
        tpOptions.ResumeLayout(False)
        gbTechAssistOptions.ResumeLayout(False)
        gbTechAssistOptions.PerformLayout()
        tpNetworkDiagnostics.ResumeLayout(False)
        tcNetworkDiagnostics.ResumeLayout(False)
        tpPing.ResumeLayout(False)
        tpPing.PerformLayout()
        CType(nudPingCount, ComponentModel.ISupportInitialize).EndInit()
        tpTcpPortTest.ResumeLayout(False)
        tpTcpPortTest.PerformLayout()
        CType(dgvPortValidation, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTcpPort, ComponentModel.ISupportInitialize).EndInit()
        tpPortProcessMap.ResumeLayout(False)
        tpPortProcessMap.PerformLayout()
        CType(dgvPortProcesses, ComponentModel.ISupportInitialize).EndInit()
        tpHttpValidation.ResumeLayout(False)
        tpHttpValidation.PerformLayout()
        tpUpgradeCheck.ResumeLayout(False)
        tpUpgradeCheck.PerformLayout()
        tlpUpgradeCheck.ResumeLayout(False)
        tlpUpgradeCheck.PerformLayout()
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
    Friend WithEvents tmrServices As Timer
    Friend WithEvents lblServiceStatus As Label
    Friend WithEvents pbServices As ProgressBar
    Friend WithEvents tlpServices As TableLayoutPanel
    Friend WithEvents flpServicesButtons As FlowLayoutPanel
    Friend WithEvents btnAppWiz As Button
    Friend WithEvents btnDevices As Button
    Friend WithEvents tpNetworkDiagnostics As TabPage
    Friend WithEvents tcNetworkDiagnostics As TabControl
    Friend WithEvents tpPing As TabPage
    Friend WithEvents rtbPingResults As RichTextBox
    Friend WithEvents btnPing As Button
    Friend WithEvents nudPingCount As NumericUpDown
    Friend WithEvents lblPingCount As Label
    Friend WithEvents tbPingHost As TextBox
    Friend WithEvents lblPingHost As Label
    Friend WithEvents tpTcpPortTest As TabPage
    Friend WithEvents rtbTcpResults As RichTextBox
    Friend WithEvents btnTcpTest As Button
    Friend WithEvents nudTcpPort As NumericUpDown
    Friend WithEvents tbTcpHost As TextBox
    Friend WithEvents cbPortPresets As ComboBox
    Friend WithEvents dgvPortValidation As DataGridView
    Friend WithEvents btnValidateCenterEdgePorts As Button
    Friend WithEvents lblPortsOpen As Label
    Friend WithEvents lblPortsClosed As Label
    Friend WithEvents clbPorts As CheckedListBox
    Friend WithEvents btnPortsClearAll As Button
    Friend WithEvents btnPortsSelectAll As Button
    Friend WithEvents btnPortsCore As Button
    Friend WithEvents chkCenterEdgePortsOnly As CheckBox
    Friend WithEvents tpPortProcessMap As TabPage
    Friend WithEvents dgvPortProcesses As DataGridView
    Friend WithEvents btnRefreshPortProcesses As Button
    Friend WithEvents tpHttpValidation As TabPage
    Friend WithEvents btnHttpTest As Button
    Friend WithEvents lblHttpUrl As Label
    Friend WithEvents tbHttpUrl As TextBox
    Friend WithEvents chkShowResponseHeaders As CheckBox
    Friend WithEvents rtbHttpResults As RichTextBox
    Friend WithEvents tpUpgradeCheck As TabPage
    Friend WithEvents tbLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents tbSqlVersion As TextBox
    Friend WithEvents lblSqlVersion As Label
    Friend WithEvents tbOsVersion As TextBox
    Friend WithEvents lblOsVersion As Label
    Friend WithEvents tbDatabaseSize As TextBox
    Friend WithEvents lblDatabaseSize As Label
    Friend WithEvents lblRiskLevel As Label
    Friend WithEvents tbRiskLevel As TextBox
    Friend WithEvents tlpUpgradeCheck As TableLayoutPanel
    Friend WithEvents btnUpgradeCheck As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnExportText As Button
    Friend WithEvents btnCopyToClipboard As Button

End Class
