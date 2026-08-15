Imports System.ComponentModel
Imports Microsoft.Data.SqlClient

Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GridContextMenuHelper.Attach(dgvSystemInfo)
        GridContextMenuHelper.Attach(dgvApplicationInfo)
        GridContextMenuHelper.Attach(dgvAppOptions)
        GridContextMenuHelper.Attach(dgvWebOptions)
        GridContextMenuHelper.Attach(dgvTableSizes)
        GridContextMenuHelper.Attach(dgvGrowthByDay)

        ApplicationState.Options = OptionsManager.Load()
        Me.StartPosition = FormStartPosition.Manual
        Me.Left = ApplicationState.Options.WindowLeft
        Me.Top = ApplicationState.Options.WindowTop
        Me.Width = ApplicationState.Options.WindowWidth
        Me.Height = ApplicationState.Options.WindowHeight
        Me.WindowState = ApplicationState.Options.WindowState
        Me.Text = ApplicationState.Options.WindowTitle

    End Sub
    Private Sub FormMain_FormClosing(
    sender As Object,
    e As FormClosingEventArgs) _
    Handles Me.FormClosing

        If Me.WindowState = FormWindowState.Normal Then
            ApplicationState.Options.WindowLeft = Me.Left
            ApplicationState.Options.WindowTop = Me.Top
            ApplicationState.Options.WindowWidth = Me.Width
            ApplicationState.Options.WindowHeight = Me.Height
        End If

        ApplicationState.Options.WindowState = Me.WindowState
        ApplicationState.Save()

    End Sub

    Private Sub btnTestConnection_Click(
        sender As Object,
        e As EventArgs) Handles btnTestConnection.Click

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


    Private Sub btnTestUpdate_Click(
    sender As Object,
    e As EventArgs) Handles btnTestUpdate.Click

        Try

            Dim sql As String =
            "UPDATE AppOptions
             SET OptionValue = CONVERT(VARCHAR(24), DATEADD(DAY, 1, GETDATE()), 120) + 'Z'
             WHERE OptionName = 'AdminUnlockedUntil'"

            Dim rowsAffected As Integer =
            DatabaseService.ExecuteNonQuery(sql)

            MessageBox.Show(
            $"{rowsAffected} row(s) updated.",
            "Update Successful")
            btnTest1.PerformClick()

        Catch ex As Exception

            MessageBox.Show(
            ex.Message,
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

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
    Private Sub dgvSystemInfo_DataBindingComplete(
    sender As Object,
    e As DataGridViewBindingCompleteEventArgs) _
    Handles dgvSystemInfo.DataBindingComplete

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


    Private Sub tpSystemInfo_Enter(
    sender As Object,
    e As EventArgs) Handles tpSystemInfo.Enter

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
        MessageHelper.ShowError(
    "Unable to connect to the database.")
    End Sub

    Private Sub btnTest4_Click(sender As Object, e As EventArgs) Handles btnTest4.Click

        ApplicationState.Options.LastDatabaseServer =
    "MYSERVER"

        OptionsManager.Save(
            ApplicationState.Options)
    End Sub


End Class
