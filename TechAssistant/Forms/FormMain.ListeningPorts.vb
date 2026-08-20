Imports System.Net
Imports System.Net.NetworkInformation

Partial Public Class FormMain
    Private Function GetListeningPorts() _
    As DataTable

        Dim dt As New DataTable

        dt.Columns.Add("Port")
        dt.Columns.Add("Address")

        Dim listeners =
            IPGlobalProperties.
                GetIPGlobalProperties().
                GetActiveTcpListeners()

        For Each listener In listeners.
            OrderBy(Function(l) l.Port)
            If chkCenterEdgePortsOnly.Checked Then

                If Not _knownPorts.Contains(
        listener.Port) Then

                    Continue For

                End If

            End If
            dt.Rows.Add(
                listener.Port,
                listener.Address.ToString())

        Next

        Return dt

    End Function



End Class