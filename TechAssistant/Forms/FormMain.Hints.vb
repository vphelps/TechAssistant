Imports System.Collections.Generic

Partial Public Class FormMain

    Private ReadOnly _hints As New Dictionary(Of String, String)

    Private Sub InitializeHints()

        _hints(tpSystemInfo.Name) =
        AddGridTips(
            "System Info")

        _hints(tpApplicationInfo.Name) =
        AddGridTips(
            "Application Information" & Environment.NewLine &
            Environment.NewLine &
            "• Displays configuration values from ApplicationInfo.")

        _hints(tpAppOptions.Name) =
        AddGridTips(
            "Application Options" & Environment.NewLine &
            Environment.NewLine &
            "• Displays application option settings stored in the database." & Environment.NewLine &
            "• Compare values between environments when troubleshooting.")

        _hints(tpWebOptions.Name) =
        AddGridTips(
            "Web Options" & Environment.NewLine &
            Environment.NewLine &
            "• Displays web and portal configuration settings.")

        _hints(tpDbTableSizes.Name) =
        AddGridTips(
            "Database Table Sizes" & Environment.NewLine &
            Environment.NewLine &
            "• Shows the size of each table in the CenterEdge database." & Environment.NewLine &
            "• Useful for identifying large tables.")

        _hints(tpSizeByDay.Name) =
        AddGridTips(
            "Database Growth by Day" & Environment.NewLine &
            Environment.NewLine &
            "• Shows the size of the database per day to track size changes." & Environment.NewLine &
            "• Useful for tracking database growth over time.")

        _hints(tpServices.Name) =
            "Advantage/SQL Services" & Environment.NewLine &
            Environment.NewLine &
            "• Shows the status of the Advantage/SQL services." & Environment.NewLine &
            "• Use buttons to Start, Stop, or Restart the services." & Environment.NewLine &
            Environment.NewLine &
            "• Only available when running as an administrator."
        _hints(tpNetworkDiagnostics.Name) =
                "Network Diagnostics" &
                Environment.NewLine &
                Environment.NewLine &
                "• Verify basic network connectivity using Ping." &
                Environment.NewLine &
                "• Verify services are accepting connections using TCP Port Test." &
                Environment.NewLine &
                Environment.NewLine &
                "Common CenterEdge Ports:" &
                Environment.NewLine &
                "• SQL Server: 1433" &
                Environment.NewLine &
                "• License Validation: 15050" &
                Environment.NewLine &
                "• Advantage API: 15059" &
                Environment.NewLine &
                "• Credit Cards: 31420"
        _hints(tpPortProcessMap.Name) =
         AddGridTips(
            "Port Processes" &
            Environment.NewLine &
            Environment.NewLine &
            "• Displays information about processes using specific ports." &
            Environment.NewLine &
            "• Useful for identifying which applications are using certain ports.")
    End Sub
    Private Function AddGridTips(
        text As String) As String

        Return text &
               Environment.NewLine &
               Environment.NewLine &
               "Grid Tips" &
               Environment.NewLine &
               "• Right-click rows for export options." &
               Environment.NewLine &
               "• Copy All for Excel formats the clipboard to paste into spreadsheets."

    End Function
    Private Sub BoldText(
    textToBold As String)

        Dim startIndex As Integer =
            rtbHints.Text.IndexOf(textToBold)

        If startIndex < 0 Then
            Exit Sub
        End If

        rtbHints.Select(
            startIndex,
            textToBold.Length)

        rtbHints.SelectionFont =
            New Font(
                rtbHints.Font,
                FontStyle.Bold)

    End Sub
    Private Sub SetHintText(
    text As String)

        rtbHints.Clear()

        rtbHints.Text = text

        If rtbHints.Lines.Length > 0 Then

            BoldText(
                rtbHints.Lines(0))

        End If

        BoldText(
            "Grid Tips")

        rtbHints.Select(0, 0)

    End Sub
End Class