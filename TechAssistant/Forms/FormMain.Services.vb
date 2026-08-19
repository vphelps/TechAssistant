Partial Public Class FormMain
    Private Sub LoadServices()

        Dim dt As New DataTable

        dt.Columns.Add("DisplayName")
        dt.Columns.Add("ServiceName")
        dt.Columns.Add("Status")

        For Each svc In ServiceHelper.GetServices()

            svc.Refresh()

            dt.Rows.Add(
        svc.DisplayName,
        svc.ServiceName,
        svc.Status.ToString())

        Next
        dgvServices.DataSource = dt
        dgvServices.Columns("ServiceName").Visible = False

    End Sub
    Private Function GetSelectedServiceName() As String

        If dgvServices.CurrentRow Is Nothing Then
            Return String.Empty
        End If

        Return dgvServices.CurrentRow.Cells("ServiceName").Value.ToString()

    End Function
    Private Function GetSelectedServiceNames() As List(Of String)

        Dim services As New List(Of String)

        For Each row As DataGridViewRow In dgvServices.SelectedRows
            services.Add(row.Cells("ServiceName").Value.ToString())
        Next

        Return services
    End Function

    Private Sub FormatServiceGrid()

        For Each row As DataGridViewRow In dgvServices.Rows

            If row.IsNewRow Then Continue For

            Dim status As String = Convert.ToString(row.Cells("Status").Value)

            Select Case status
                Case "Running"
                    row.Cells("Status").Style.BackColor = Color.LightGreen
                Case "Stopped"
                    row.Cells("Status").Style.BackColor = Color.LightCoral
                Case "Paused"
                    row.Cells("Status").Style.BackColor = Color.Khaki
                Case "StartPending"
                    row.Cells("Status").Style.BackColor = Color.LightBlue
                Case "StopPending"
                    row.Cells("Status").Style.BackColor = Color.Orange
                Case "PausePending"
                    row.Cells("Status").Style.BackColor = Color.Gold
                Case Else
                    row.Cells("Status").Style.BackColor = Color.LightGray
            End Select
        Next
    End Sub
    Private Sub RestoreSelectedServices(serviceNames As IEnumerable(Of String))

        If serviceNames Is Nothing Then Exit Sub


        Dim selectedServices As New HashSet(Of String)(serviceNames, StringComparer.OrdinalIgnoreCase)

        If selectedServices.Count = 0 Then Exit Sub
        dgvServices.ClearSelection()

        For Each row As DataGridViewRow In dgvServices.Rows
            If row.IsNewRow Then Continue For
            Dim serviceName As String = Convert.ToString(row.Cells("ServiceName").Value)
            If selectedServices.Contains(serviceName) Then
                row.Selected = True
            End If
        Next
    End Sub
    Private Async Function PerformServiceOperation(services As List(Of String), operation As Action(Of String), operationName As String) As Task

        _savedServiceSelections = New List(Of String)(services)
        _serviceOperationInProgress = True
        pbServices.Visible = True
        lblServiceStatus.Text = $"{operationName} service(s)..."
        lblServiceStatus.Visible = True
        dgvServices.Enabled = False
        dgvServices.ClearSelection()
        dgvServices.CurrentCell = Nothing

        btnServiceStart.Enabled = False
        btnServiceStop.Enabled = False
        btnServiceRestart.Enabled = False

        tmrServices.Start()
        Dim failedServices As New List(Of String)

        Try
            _totalServiceOperations = services.Count
            _currentServiceIndex = 0
            Await Task.Run(
                Sub()
                    For Each serviceName In services
                        Try
                            _currentServiceIndex += 1
                            _currentServiceOperation = serviceName
                            operation(serviceName)
                        Catch ex As Exception
                            SyncLock failedServices
                                failedServices.Add($"{serviceName}: {ex.Message}")
                            End SyncLock
                        End Try
                    Next
                End Sub)

            If failedServices.Count > 0 Then

                MessageHelper.ShowWarning(
                    String.Join(
                        Environment.NewLine &
                        Environment.NewLine,
                        failedServices),
                    $"Some Services Failed To {operationName}")
            End If

        Catch ex As Exception

            MessageHelper.ShowError(ex.Message, $"Service {operationName} Failed")
        Finally
            _serviceOperationInProgress = False
            tmrServices.Stop()
            LoadServices()
            dgvServices.Enabled = True

            btnServiceStart.Enabled = True
            btnServiceStop.Enabled = True
            btnServiceRestart.Enabled = True

            pbServices.Visible = False
            lblServiceStatus.Visible = False

            RestoreSelectedServices(
                _savedServiceSelections)

        End Try
    End Function
End Class
