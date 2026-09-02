Imports System.ComponentModel
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Management
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports Microsoft.Data.SqlClient
Imports System.Threading.Tasks

Public Class FormMain
    Private _savedServiceSelections As New List(Of String)
    Private _serviceOperationInProgress As Boolean
    Private _currentServiceOperation As String = String.Empty
    Private _currentServiceIndex As Integer
    Private _totalServiceOperations As Integer
    Private _upgradeModel As UpgradeCheckModel = Nothing
    Private _cloudSettings As CloudAppSettings

    Private Sub UpdateHelpText()

        Dim tabName As String

        Select Case tcFormMain.SelectedTab.Name
            Case tpDbInfo.Name
                tabName = tcDbInfo.SelectedTab.Name
            Case tpDbAnalytics.Name
                tabName = tcDbAnalytics.SelectedTab.Name
            Case Else
                tabName = tcFormMain.SelectedTab.Name
        End Select

        If _hints.ContainsKey(tabName) Then
            SetHintText(_hints(tabName))
        Else
            rtbHints.Clear()
        End If

    End Sub
    Private Sub RemoveFutureFeatures()

    End Sub

    Private Async Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strTemp As String = Nothing

        ApplicationState.RunningAsAdmin = SecurityHelper.IsRunningElevated()

        GridContextMenuHelper.Attach(dgvSystemInfo)
        GridContextMenuHelper.Attach(dgvApplicationInfo)
        GridContextMenuHelper.Attach(dgvAppOptions)
        GridContextMenuHelper.Attach(dgvWebOptions)
        GridContextMenuHelper.Attach(dgvTableSizes)
        GridContextMenuHelper.Attach(dgvGrowthByDay)
        GridContextMenuHelper.Attach(dgvPortProcesses)

        InitializeIcons()
        InitializeHints()
        InitializeUtilityButtons()
        UpdateHelpText()
        LoadPortDefinitions()

        ApplicationState.Options = OptionsManager.Load()
        InitialLoad()

        LoadServices()
        tcFormMain.SelectedTab = tpUpgradeCheck
        Dim currentUser As String = Environment.UserName
        'If Not String.Equals(currentUser, "vphelps") Then
        '    tcFormMain.TabPages.Remove(tpDbInfo)
        '    tcFormMain.TabPages.Remove(tpServices)
        '    tcFormMain.TabPages.Remove(tpDbAnalytics)
        '    tcFormMain.TabPages.Remove(tpOptions)
        '    flpTest.Visible = False
        '    flpFormButtonsTop.Visible = False
        '    flpAppButtons.Visible = False
        '    btnAdminUnlock.Visible = False

        'End If
        tbPingHost.Text = SystemInfo.GetDatabaseServer
        tbTcpHost.Text = SystemInfo.GetDatabaseServer
        tbTest1.Text = $"This computer:  {Environment.MachineName} | Server:  {SystemInfo.GetDatabaseServer} | Database: {SystemInfo.GetDatabaseName}"
        _cloudSettings = Await CloudAppSettings.FetchLatestAsync()


        TextBox1.BackColor = ColorTranslator.FromHtml(_cloudSettings.StatusErrorBackColorHex)
        TextBox1.ForeColor = ColorTranslator.FromHtml(_cloudSettings.StatusErrorForeColorHex)
    End Sub
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.WindowState = FormWindowState.Normal Then
            ApplicationState.Options.WindowLeft = Me.Left
            ApplicationState.Options.WindowTop = Me.Top
            ApplicationState.Options.WindowWidth = Me.Width
            ApplicationState.Options.WindowHeight = Me.Height
        End If
        ApplicationState.Options.WindowTitle = tbWindowTitle.Text

        ApplicationState.Options.WindowState = Me.WindowState
        ApplicationState.Save()

    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click

        Try
            'Dim sql As String = "SELECT DB_NAME() AS DatabaseName;"
            Dim sql As String = "SELECT @@VERSION"

            Dim result = DatabaseService.ExecuteScalar(sql)
            MessageBox.Show(result.ToString)


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub


    Private Sub btnTestUpdate_Click(sender As Object, e As EventArgs) Handles btnTestUpdate.Click

    End Sub

    Private Sub btnTestConnect_Click(sender As Object, e As EventArgs) Handles btnTestConnect.Click
        If Not DatabaseService.TestConnection() Then
            MessageBox.Show(
            "Failed to connect to the database.",
            "Connection Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Else
            MessageBox.Show(
            "Successfully connected to the database.",
            "Connection Successful",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub tpDbInfo_Enter(sender As Object, e As EventArgs) Handles tpDbInfo.Enter

        'Load AppOptions table into DataGridView
        Try
            Dim dt As DataTable = DatabaseService.GetDataTable(Queries.GetAppOptionsTable)

            dgvAppOptions.DataSource = dt

        Catch ex As Exception
            MessageBox.Show($"Error loading App Options:{Environment.NewLine}{ex.Message}")

        End Try

        'Load ApplicationInfo table into DataGridView
        Try
            Dim dt As DataTable = DatabaseService.GetDataTable(Queries.GetApplicationInfoTable)

            Dim displayTable As DataTable =
            DataTableHelper.PivotSingleRowToList(dt)

            dgvApplicationInfo.DataSource = displayTable
        Catch ex As Exception
            MessageBox.Show($"Error loading Application Info:{Environment.NewLine}{ex.Message}")
        End Try

        'Load WebOptions table into DataGridView
        Try
            Dim dt As DataTable = DatabaseService.GetDataTable(Queries.GetWebOptionsTable)

            dgvWebOptions.DataSource = dt

        Catch ex As Exception
            MessageBox.Show($"Error loading Web Options:{Environment.NewLine}{ex.Message}")
        End Try

    End Sub
    Private Sub tpDbAnalytics_Enter(sender As Object, e As EventArgs) Handles tpDbAnalytics.Enter
        'Load Database Tables by Size query into DataGridView
        Try
            Dim dt As DataTable = DatabaseService.GetDataTable(Queries.GetDbTableSizes)

            dgvTableSizes.DataSource = dt

        Catch ex As Exception
            MessageBox.Show($"Error loading Database Table Sizes:{Environment.NewLine}{ex.Message}")
        End Try
        'Load Database Growth by Day query into DataGridView
        Try
            Dim dt As DataTable = DatabaseService.GetDataTable(Queries.GetDbGrowthByDay)

            dgvGrowthByDay.DataSource = dt

        Catch ex As Exception
            MessageBox.Show($"Error loading Database Growth by Day:{Environment.NewLine}{ex.Message}")
        End Try
    End Sub
    Private Sub dgvSystemInfo_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSystemInfo.DataBindingComplete

        For Each row As DataGridViewRow In dgvSystemInfo.Rows

            Dim propertyValue As String =
            Convert.ToString(
                row.Cells("Property").Value)

            If propertyValue.StartsWith("===") Then

                row.DefaultCellStyle.Font =
                New Font(
                    "Segoe UI",
                    9.0F,
                    FontStyle.Bold)

                row.DefaultCellStyle.BackColor = Color.LightSteelBlue

                row.DefaultCellStyle.ForeColor = Color.DarkBlue

            End If

        Next

    End Sub
    Private Sub dgvServices_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvServices.DataBindingComplete

        FormatServiceGrid()

    End Sub

    Private Sub tpSystemInfo_Enter(sender As Object, e As EventArgs) Handles tpSystemInfo.Enter

        dgvSystemInfo.DataSource =
        SystemInfo.BuildSystemInfoTable()

    End Sub

    Private Sub LoadUpgradeCheckData()
        ' Fetch only if not already loaded (prevents unnecessary re-querying)
        If _upgradeModel Is Nothing Then
            _upgradeModel = UpgradeCheckModel.LoadFromSystem()
        End If

        ' Bind the cached model data to the UI
        DisplayUpgradeCheckInfo(_upgradeModel)
    End Sub

    ''' <summary>
    ''' Updates UI elements on tpUpgradeCheck using the model data and cloud settings.
    ''' </summary>
    Private Sub DisplayUpgradeCheckInfo(model As UpgradeCheckModel)
        ' 1. Basic Info
        tbLocation.Text = model.LocationName
        tbSqlVersion.Text = model.SqlVersion
        tbOsVersion.Text = model.FullOsDisplay

        ' 2. Safely handle DatabaseSizeGB
        If model.DatabaseSizeGB.HasValue Then
            tbDatabaseSize.Text = $"{model.DatabaseSizeGB.Value:N2} GB"
        Else
            tbDatabaseSize.Text = "Unknown"
        End If

        ' 3. Dynamic Risk Level Info driven by Cloud Settings
        ' (_cloudSettings is the form-level instance loaded during FormMain_Load)
        tbRiskLevel.Text = model.GetRiskDescription(_cloudSettings)
        tbRiskLevel.ForeColor = model.GetRiskForeColor(_cloudSettings)
        tbRiskLevel.BackColor = model.GetRiskBackColor(_cloudSettings)

        ' Optional: Also apply the risk background color directly to the DB size field for visual emphasis
        tbDatabaseSize.BackColor = model.GetRiskBackColor(_cloudSettings)

        ' 4. Safe Table & Combined Size Calculations
        If model.LargestTableSizeKB.HasValue AndAlso model.DatabaseSizeGB.HasValue Then
            ' Extract values safely using .Value
            Dim tableSizeKB As Decimal = model.LargestTableSizeKB.Value
            Dim tableSizeGB As Decimal = tableSizeKB / 1048576D
            Dim dbSizeGB As Decimal = model.DatabaseSizeGB.Value

            Dim sizeAdded As Decimal = tableSizeGB + dbSizeGB
            Dim sizeRounded As Decimal = Math.Round(sizeAdded, 2)

            tbTest1.Text = $"DB size({dbSizeGB:N2} GB) plus largest table({tableSizeGB:N2} GB) added = {sizeRounded:N2} GB"
        Else
            ' Fallback text when either value fails to load from SQL
            tbTest1.Text = "Unable to calculate total size (Database or Table size missing)."
        End If
    End Sub

    Private Sub btnTest1_Click(sender As Object, e As EventArgs) Handles btnTest1.Click

    End Sub

    Private Sub btnTest2_Click(sender As Object, e As EventArgs) Handles btnTest2.Click

    End Sub

    Private Sub btnTest3_Click(sender As Object, e As EventArgs) Handles btnTest3.Click

    End Sub

    Private Sub btnTest4_Click(sender As Object, e As EventArgs) Handles btnTest4.Click
        Dim fileTemp As String = System.IO.Path.GetDirectoryName(SystemInfo.GetAdvantageDllPath)
        fileTemp = System.IO.Path.Combine(fileTemp, "AdvUpgrade.exe")
        MessageHelper.ShowInfo(
        fileTemp)

        Dim startinfo As ProcessStartInfo = New ProcessStartInfo(fileTemp)
        startinfo.Arguments = ""
        startinfo.FileName = fileTemp

        Process.Start(startinfo)

        'If cbAdvUpgradeNoBackup.Checked Then temp += AdvUpgradeConstants.NoBackup + " "
        'If cbAdvUpgradeQuiet.Checked Then temp += AdvUpgradeConstants.Quiet + " "
        'If cbAdvUpgradeNoSetup.Checked Then temp += AdvUpgradeConstants.NoSetup
        'startinfo.Arguments = temp

    End Sub

    Private Sub tcFormMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcFormMain.SelectedIndexChanged, tcDbInfo.SelectedIndexChanged, tcDbAnalytics.SelectedIndexChanged

        UpdateHelpText()

        If tcFormMain.SelectedTab Is tpServices Then
            tmrServices.Start()
        Else
            tmrServices.Stop()
        End If



    End Sub

    Private Sub btnAdvManager_Click(sender As Object, e As EventArgs) Handles btnAdvManager.Click, btnPos.Click, btnAdvGroups.Click, btnAdvRedeem.Click, btnKioskSetup.Click, btnAdvKiosk.Click, btnAdvReportEditor.Click
        Dim caller = DirectCast(sender, Button)
        Dim executable = caller.Name.Replace("btn", "")


        Dim fileTemp = IO.Path.GetDirectoryName(SystemInfo.GetAdvantageDllPath)
        fileTemp = IO.Path.Combine(fileTemp, executable)
        executable = fileTemp & ".exe"

        If Not System.IO.File.Exists(executable) Then
            Return
        End If

        Dim startinfo As ProcessStartInfo = New ProcessStartInfo(executable)
        startinfo.Arguments = ""
        startinfo.FileName = executable

        'Process.Start(startinfo)
    End Sub

    Private Sub btnTaskManager_Click(sender As Object, e As EventArgs) Handles btnTaskManager.Click, btnCalculator.Click, btnServices.Click, btnEventViewer.Click, btnAppWiz.Click, btnDevices.Click
        Dim caller = DirectCast(sender, Button)

        Select Case caller.Name
            Case "btnTaskManager"
                Process.Start("C:\Windows\System32\taskmgr.exe")
            Case "btnCalculator"
                Process.Start("C:\Windows\System32\calc.exe")
            Case "btnServices"
                Process.Start(New ProcessStartInfo("services.msc") With {.UseShellExecute = True})
            Case "btnEventViewer"
                Process.Start(New ProcessStartInfo("eventvwr.msc") With {.UseShellExecute = True})
            Case "btnAppWiz"
                Process.Start(New ProcessStartInfo("appwiz.cpl") With {.UseShellExecute = True})
            Case "btnDevices"
                Process.Start(New ProcessStartInfo("control.exe", "/name Microsoft.DevicesAndPrinters") With {.UseShellExecute = True})
        End Select

    End Sub

    Private Sub btnAdminUnlock_Click(sender As Object, e As EventArgs) Handles btnAdminUnlock.Click
        Try

            Dim sql As String =
            "UPDATE AppOptions
             SET OptionValue = CONVERT(VARCHAR(24), DATEADD(DAY, 1, GETDATE()), 120) + 'Z'
             WHERE OptionName = 'AdminUnlockedUntil'"

            Dim rowsAffected As Integer =
            DatabaseService.ExecuteNonQuery(sql)

        Catch ex As Exception

            MessageBox.Show(
            ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try


    End Sub
    Private Sub tmrServices_Tick(sender As Object, e As EventArgs) Handles tmrServices.Tick

        If Not _serviceOperationInProgress Then Exit Sub
        LoadServices()
        dgvServices.ClearSelection()
        dgvServices.CurrentCell = Nothing
        lblServiceStatus.Text = $"Processing ({_currentServiceIndex} of {_totalServiceOperations}): {_currentServiceOperation}"

    End Sub


    Private Sub btnServicesRefresh_Click(sender As Object, e As EventArgs) Handles btnServicesRefresh.Click
        Dim selectedServices = GetSelectedServiceNames()
        LoadServices()
        RestoreSelectedServices(selectedServices)
    End Sub

    Private Async Sub btnServiceRestart_Click(sender As Object, e As EventArgs) Handles btnServiceRestart.Click

        Dim services = GetSelectedServiceNames()

        If services.Count = 0 Then Exit Sub

        Dim message As String =
        "Restart the following services?" &
        Environment.NewLine &
        Environment.NewLine &
        String.Join(
            Environment.NewLine,
            services)

        If MessageHelper.ShowQuestion(message) <> DialogResult.Yes Then
            Exit Sub
        End If

        Await PerformServiceOperation(services, AddressOf ServiceHelper.RestartService, "Restart")

    End Sub
    Private Async Sub btnServiceStart_Click(sender As Object, e As EventArgs) Handles btnServiceStart.Click

        Dim services = GetSelectedServiceNames()

        If services.Count = 0 Then Exit Sub

        Dim message As String =
        "Start the following services?" &
        Environment.NewLine &
        Environment.NewLine &
        String.Join(
            Environment.NewLine,
            services)

        If MessageHelper.ShowQuestion(message) <> DialogResult.Yes Then
            Exit Sub
        End If

        Await PerformServiceOperation(services, AddressOf ServiceHelper.StartService, "Start")

    End Sub

    Private Async Sub btnServiceStop_Click(sender As Object, e As EventArgs) Handles btnServiceStop.Click

        Dim services = GetSelectedServiceNames()

        If services.Count = 0 Then Exit Sub

        Dim message As String =
        "Stop the following services?" &
        Environment.NewLine &
        Environment.NewLine &
        String.Join(
            Environment.NewLine,
            services)

        If MessageHelper.ShowQuestion(message) <> DialogResult.Yes Then

            Exit Sub

        End If

        Await PerformServiceOperation(services, AddressOf ServiceHelper.StopService, "Stop")

    End Sub

    Private Async Sub btnPing_Click(
    sender As Object,
    e As EventArgs) Handles btnPing.Click

        Dim host As String =
        tbPingHost.Text.Trim()

        rtbPingResults.Clear()

        If String.IsNullOrWhiteSpace(host) Then

            rtbPingResults.Text =
            "Host is required."

            Exit Sub

        End If

        Try

            Dim totalTime As Long = 0
            Dim successCount As Integer = 0

            For i As Integer = 1 To CInt(nudPingCount.Value)

                Dim reply =
                Await PingHostAsync(host)

                If reply.Status =
                IPStatus.Success Then

                    successCount += 1
                    totalTime += reply.RoundtripTime

                    rtbPingResults.AppendText(
                    $"Reply {i}: {reply.Address}" &
                    Environment.NewLine)

                    rtbPingResults.AppendText(
                    $"Time: {reply.RoundtripTime} ms" &
                    Environment.NewLine)

                Else

                    rtbPingResults.AppendText(
                    $"Reply {i}: {reply.Status}" &
                    Environment.NewLine)

                End If

                rtbPingResults.AppendText(
                Environment.NewLine)

            Next

            If successCount > 0 Then

                rtbPingResults.AppendText(
                $"Average: {totalTime / successCount} ms")

            End If

        Catch ex As Exception

            rtbPingResults.Text =
            ex.Message

        End Try

    End Sub
    Private Async Sub btnTcpTest_Click(
    sender As Object,
    e As EventArgs) Handles btnTcpTest.Click

        Dim host As String =
            tbTcpHost.Text.Trim()

        Dim port As Integer =
            CInt(nudTcpPort.Value)

        rtbTcpResults.Clear()

        Try

            Dim stopwatch As New Stopwatch()

            Using client As New TcpClient()

                stopwatch.Start()

                Await client.ConnectAsync(
                    host,
                    port)

                stopwatch.Stop()

                rtbTcpResults.AppendText(
                    "Connection Successful" &
                    Environment.NewLine &
                    Environment.NewLine)

                rtbTcpResults.AppendText(
                    $"Host: {host}" &
                    Environment.NewLine)

                rtbTcpResults.AppendText(
                    $"Port: {port}" &
                    Environment.NewLine)

                rtbTcpResults.AppendText(
                    $"Connection Time: {stopwatch.ElapsedMilliseconds} ms")

            End Using

        Catch ex As SocketException

            rtbTcpResults.Text =
                "Connection Failed" &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message

        Catch ex As Exception

            rtbTcpResults.Text =
                ex.Message

        End Try

    End Sub
    Private Sub cboPortPresets_SelectedIndexChanged(
    sender As Object,
    e As EventArgs) Handles cbPortPresets.SelectedIndexChanged

        Select Case cbPortPresets.Text

            Case "SQL Server (1433)"
                nudTcpPort.Value = 1433

            Case "Advantage API Service (15059)"
                nudTcpPort.Value = 15059

            Case "Credit Cards (31420)"
                nudTcpPort.Value = 31420

        End Select

    End Sub

    Private Async Sub btnValidateCenterEdgePorts_Click(
    sender As Object,
    e As EventArgs) _
    Handles btnValidateCenterEdgePorts.Click

        Dim host As String =
        tbTcpHost.Text.Trim()

        btnValidateCenterEdgePorts.Enabled = False

        Try

            Dim portsToTest =
    GetSelectedPorts()

            If portsToTest.Count = 0 Then
                MessageHelper.ShowInfo(
        "Select at least one port.")

                Exit Sub

            End If
            Dim tasks =
    portsToTest.Select(
        Function(port)

            Return TestPortAsync(
                host,
                port)

        End Function)

            Dim results =
    Await Task.WhenAll(tasks)

            BindPortResults(
            results)
            Dim openCount =
    results.Count(
        Function(r) r.IsOpen)

            Dim closedCount =
                results.Count(
                    Function(r) Not r.IsOpen)

            lblPortsOpen.Text =
                $"Open: {openCount}"

            lblPortsClosed.Text =
                $"Closed: {closedCount}"
        Finally

            btnValidateCenterEdgePorts.Enabled = True

        End Try

    End Sub

    Private Sub btnPortsSelectAll_Click(
    sender As Object,
    e As EventArgs) _
    Handles btnPortsSelectAll.Click

        For i As Integer = 0 To clbPorts.Items.Count - 1

            clbPorts.SetItemChecked(
                i,
                True)

        Next

    End Sub
    Private Sub btnPortsClearAll_Click(
    sender As Object,
    e As EventArgs) _
    Handles btnPortsClearAll.Click

        For i As Integer = 0 To clbPorts.Items.Count - 1

            clbPorts.SetItemChecked(
                i,
                False)

        Next

    End Sub
    Private Sub btnPortsCore_Click(
    sender As Object,
    e As EventArgs) _
    Handles btnPortsCore.Click

        btnPortsClearAll_Click(
        Nothing,
        EventArgs.Empty)

        CheckPort(1433)
        CheckPort(15050)
        CheckPort(15051)
        CheckPort(15059)

    End Sub


    Private Sub tpPortProcessMap_Enter(
    sender As Object,
    e As EventArgs) _
    Handles tpPortProcessMap.Enter

        LoadPortProcesses()

    End Sub
    Private Sub btnPortProcessRefresh_Click(
    sender As Object,
    e As EventArgs) Handles btnRefreshPortProcesses.Click

        LoadPortProcesses()

    End Sub
    Private Sub chkCenterEdgePortsOnly_CheckedChanged(
    sender As Object,
    e As EventArgs) _
    Handles chkCenterEdgePortsOnly.CheckedChanged

        LoadPortProcesses()

    End Sub

    Private Async Sub btnHttpTest_Click(
    sender As Object,
    e As EventArgs) _
    Handles btnHttpTest.Click

        Await TestHttpUrl()

    End Sub

    Private Async Sub btnUpgradeCheck_Click(sender As Object, e As EventArgs) Handles btnUpgradeCheck.Click
        Try
            ' 1. Give visual feedback while fetching online settings & database stats
            btnUpgradeCheck.Enabled = False
            Me.Cursor = Cursors.WaitCursor

            ' 2. Always force a fresh fetch from the cloud on every click
            _cloudSettings = Await CloudAppSettings.FetchLatestAsync()

            ' 3. Re-initialize hints/tooltips to immediately reflect newly fetched cloud thresholds
            InitializeHints(_cloudSettings)
            UpdateHelpText()

            ' 4. Force a fresh database query (bypass any cached _upgradeModel instance)
            _upgradeModel = UpgradeCheckModel.LoadFromSystem()

            ' 5. Update UI with the new model metrics and fresh cloud risk thresholds
            DisplayUpgradeCheckInfo(_upgradeModel)

        Catch ex As Exception
            MessageBox.Show($"Error running upgrade check:{Environment.NewLine}{ex.Message}",
                        "Upgrade Check Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        Finally
            ' Restore button state and cursor
            btnUpgradeCheck.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnExportText_Click(sender As Object, e As EventArgs) Handles btnExportText.Click
        ' Ensure model data is available
        If _upgradeModel Is Nothing Then
            MessageBox.Show("No upgrade check data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Configure SaveFileDialog
        Using saveFileDialog As New SaveFileDialog
            ' Generate a clean, default filename with location and date
            Dim sanitizedLocation = String.Join("_", _upgradeModel.LocationName.Split(Path.GetInvalidFileNameChars))
            saveFileDialog.FileName = $"UpgradeCheck_{sanitizedLocation}_{Date.Now:yyyyMMdd}.txt"
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            saveFileDialog.Title = "Export Upgrade Check Data"

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                Try
                    ' Generate content and write file
                    Dim reportContent = _upgradeModel.ToTextReport(_cloudSettings)
                    File.WriteAllText(saveFileDialog.FileName, reportContent)

                    MessageBox.Show("Upgrade check report exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Failed to export report: {ex.Message}", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Async Sub btnCopyToClipboard_Click(sender As Object, e As EventArgs) Handles btnCopyToClipboard.Click
        ' 1. Guard check for model data
        If _upgradeModel Is Nothing Then
            MessageBox.Show("No upgrade check data available to copy.", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' 2. Generate report text and copy to Windows Clipboard
            Dim reportText As String = _upgradeModel.ToClipboardString(_cloudSettings)
            Clipboard.SetText(reportText)

            ' 3. Provide temporary visual feedback on the button
            Dim btn As Button = DirectCast(sender, Button)
            Dim originalText As String = btn.Text

            btn.Text = "Copied!"
            btn.Enabled = False ' Prevents rapid double-clicking during delay

            ' Wait for 2000 milliseconds (2 seconds) asynchronously
            Await Task.Delay(2000)

            ' Restore original state
            btn.Text = originalText
            btn.Enabled = True

        Catch ex As Exception
            MessageBox.Show($"Failed to copy to clipboard: {ex.Message}", "Copy Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
