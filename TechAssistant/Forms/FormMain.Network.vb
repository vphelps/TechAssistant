Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Diagnostics

Partial Public Class FormMain
    Private ReadOnly _centerEdgePorts As New List(Of PortTestDefinition) From
    {
        New PortTestDefinition With {.Host = String.Empty, .Port = 80, .Description = "Signage Media"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 1433, .Description = "SQL Server"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15050, .Description = "License Validation"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15051, .Description = "License File Request"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15054, .Description = "Fingerprint Service"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15055, .Description = "Signage/Qubica/Alvarado"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15056, .Description = "External Sales Interface"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15057, .Description = "LaunchDarkly"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15059, .Description = "Advantage API"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 15060, .Description = "Stage/Web 2"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 31420, .Description = "Credit Cards"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 58008, .Description = "Embed Interface"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 9000, .Description = "NetEPay"},
        New PortTestDefinition With {.Host = String.Empty, .Port = 9100, .Description = "Mercury Gift Cards"},
        New PortTestDefinition With {.Host = "relay-us-east-1.centeredgeonline.com", .Port = 50511, .Description = "Relay Service"}
    }
    Private ReadOnly _knownPorts As Integer() = {
    80,
    1433,
    15050,
    15051,
    15054,
    15055,
    15056,
    15057,
    15059,
    15060,
    31420,
    58008,
    9000,
    9100
}

    Private Sub LoadPortDefinitions()

        clbPorts.Items.Clear()

        For Each port In _centerEdgePorts

            clbPorts.Items.Add(
            $"{port.Description} ({port.Port})",
            False)

        Next

        CheckPort(1433)
        CheckPort(15050)
        CheckPort(15051)
        CheckPort(15054)
        CheckPort(15056)
        CheckPort(15059)

    End Sub
    Private Sub CheckPort(
    portNumber As Integer)

        For i As Integer = 0 To _centerEdgePorts.Count - 1

            If _centerEdgePorts(i).Port =
                portNumber Then

                clbPorts.SetItemChecked(
                i,
                True)

            End If

        Next

    End Sub
    Private Function GetSelectedPorts() _
    As List(Of PortTestDefinition)

        Dim results As New List(Of PortTestDefinition)

        For Each checkedItem In
        clbPorts.CheckedItems

            Dim displayText As String =
            checkedItem.ToString()

            Dim port =
            _centerEdgePorts.
                First(
                    Function(p)

                        Return displayText =
                            $"{p.Description} ({p.Port})"

                    End Function)

            results.Add(port)

        Next

        Return results

    End Function

    Private Async Function PingHostAsync(
    host As String) As Task(Of PingReply)

        Using ping As New Ping()

            Return Await ping.SendPingAsync(
                host,
                3000)

        End Using

    End Function

    Private Async Function TestPortAsync(
    host As String,
    definition As PortTestDefinition) _
    As Task(Of PortTestResult)

        Dim stopwatch As New Stopwatch()

        Dim actualHost As String =
        If(
            String.IsNullOrWhiteSpace(
                definition.Host),
            host,
            definition.Host)

        Try

            Using client As New TcpClient()

                stopwatch.Start()

                Await client.ConnectAsync(
                actualHost,
                definition.Port)

                stopwatch.Stop()

                Return New PortTestResult With {
                .Host = actualHost,
                .Port = definition.Port,
                .Description = definition.Description,
                .IsOpen = True,
                .ResponseTimeMs = stopwatch.ElapsedMilliseconds
            }

            End Using

        Catch ex As Exception

            stopwatch.Stop()

            Return New PortTestResult With {
            .Host = actualHost,
            .Port = definition.Port,
            .Description = definition.Description,
            .IsOpen = False,
            .ErrorMessage = ex.Message
        }

        End Try

    End Function

    Private Sub BindPortResults(
    results As IEnumerable(Of PortTestResult))

        Dim dt As New DataTable()

        dt.Columns.Add("Host")
        dt.Columns.Add("Port")
        dt.Columns.Add("Description")
        dt.Columns.Add("Status")
        dt.Columns.Add("Response Time")

        For Each result In results.
            OrderBy(Function(r) r.Port)

            dt.Rows.Add(
                result.Host,
                result.Port,
                result.Description,
                If(
                    result.IsOpen,
                    "Open",
                    "Closed"),
                If(
                    result.IsOpen,
                    result.ResponseTimeMs & " ms",
                    String.Empty))

        Next

        dgvPortValidation.DataSource = dt

        FormatPortGrid()

    End Sub
    Private Sub FormatPortGrid()

        For Each row As DataGridViewRow In
            dgvPortValidation.Rows

            If row.IsNewRow Then Continue For

            Dim status As String =
                Convert.ToString(
                    row.Cells("Status").Value)

            Select Case status

                Case "Open"

                    row.Cells("Status").
                        Style.BackColor =
                        Color.LightGreen

                Case "Closed"

                    row.Cells("Status").
                        Style.BackColor =
                        Color.LightCoral

            End Select

        Next

    End Sub

End Class