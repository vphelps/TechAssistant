Imports System.ComponentModel
Imports System.DirectoryServices.ActiveDirectory
Imports Microsoft.Data.SqlClient

Public Class FormMain
    Private _savedServiceSelections As New List(Of String)
    Private _serviceOperationInProgress As Boolean
    Private _currentServiceOperation As String = String.Empty
    Private _currentServiceIndex As Integer
    Private _totalServiceOperations As Integer

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
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strTemp As String = Nothing
        ApplicationState.RunningAsAdmin = SecurityHelper.IsRunningElevated()

        GridContextMenuHelper.Attach(dgvSystemInfo)
        GridContextMenuHelper.Attach(dgvApplicationInfo)
        GridContextMenuHelper.Attach(dgvAppOptions)
        GridContextMenuHelper.Attach(dgvWebOptions)
        GridContextMenuHelper.Attach(dgvTableSizes)
        GridContextMenuHelper.Attach(dgvGrowthByDay)

        InitializeIcons()
        InitializeHints()
        InitializeUtilityButtons()
        UpdateHelpText()

        ApplicationState.Options = OptionsManager.Load()
        InitialLoad()

        LoadServices()

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

    Private Sub btnTest1_Click(sender As Object, e As EventArgs) Handles btnTest1.Click
        MessageHelper.ShowInfo(
    "Database connection successful.")
    End Sub

    Private Sub btnTest2_Click(sender As Object, e As EventArgs) Handles btnTest2.Click
        MessageHelper.ShowWarning(
    "This operation may take several minutes.")
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

        tbTest1.Text = tmrServices.Enabled.ToString

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
        tbTest1.Text = executable

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

End Class
