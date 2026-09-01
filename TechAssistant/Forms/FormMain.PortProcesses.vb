Imports System.Diagnostics

Partial Public Class FormMain
    Private Sub LoadPortProcesses()

        Dim results =
            PortProcessHelper.GetListeningPorts()
        For Each item In results

            item.Description =
        GetPortDescription(item.Port)

        Next

        If chkCenterEdgePortsOnly.Checked Then

            results =
                results.
                    Where(Function(p)
                              Return _knownPorts.Contains(
                                  p.Port)
                          End Function).
                    ToList()

        End If

        dgvPortProcesses.DataSource =
            results

        FormatPortProcessesGrid()

    End Sub
    Private Function GetPortDescription(
    port As Integer) As String

        Dim match =
        _centerEdgePorts.
            FirstOrDefault(
                Function(p)
                    Return p.Port = port
                End Function)

        If match Is Nothing Then

            Return "Unknown"

        End If

        Return match.Description

    End Function

    Private Sub FormatPortProcessesGrid()

        If dgvPortProcesses.Columns.Contains("Address") Then

            dgvPortProcesses.Columns("Address").Visible =
            False

        End If

        If dgvPortProcesses.Columns.Contains("Protocol") Then

            dgvPortProcesses.Columns("Protocol").Visible =
            False

        End If

        If dgvPortProcesses.Columns.Contains("State") Then

            dgvPortProcesses.Columns("State").Visible =
            False

        End If

        For Each row As DataGridViewRow In
        dgvPortProcesses.Rows

            If row.IsNewRow Then Continue For

            Dim port As Integer =
            Convert.ToInt32(
                row.Cells("Port").Value)

            If _knownPorts.Contains(port) Then

                row.DefaultCellStyle.BackColor =
                Color.LightBlue

            End If

        Next

    End Sub

End Class