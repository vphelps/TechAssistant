Imports System.Diagnostics
Imports System.Text.RegularExpressions

Public Class PortProcessHelper

    Public Shared Function GetListeningPorts() _
        As List(Of PortProcessInfo)

        Dim results As New List(Of PortProcessInfo)

        Dim psi As New ProcessStartInfo()

        psi.FileName = "netstat.exe"
        psi.Arguments = "-ano"

        psi.UseShellExecute = False
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = True

        Using proc As Process = Process.Start(psi)

            Dim output As String =
                proc.StandardOutput.ReadToEnd()

            proc.WaitForExit()

            ParseNetStatOutput(
                output,
                results)

        End Using

        Return results.
            OrderBy(Function(p) p.Port).
            ToList()

    End Function

    Private Shared Sub ParseNetStatOutput(
        netstatOutput As String,
        results As List(Of PortProcessInfo))

        Dim lines =
            netstatOutput.Split(
                {Environment.NewLine},
                StringSplitOptions.RemoveEmptyEntries)

        For Each line In lines

            Dim trimmed =
                line.Trim()

            If Not trimmed.StartsWith("TCP") Then
                Continue For
            End If

            Dim parts =
                Regex.Split(
                    trimmed,
                    "\s+")

            If parts.Length < 5 Then
                Continue For
            End If

            Dim localAddress As String =
                parts(1)

            Dim state As String =
                parts(3)

            Dim pidText As String =
                parts(4)

            If state <> "LISTENING" Then
                Continue For
            End If

            Dim port As Integer

            If Not TryGetPort(
                localAddress,
                port) Then

                Continue For

            End If

            Dim pid As Integer

            If Not Integer.TryParse(
                pidText,
                pid) Then

                Continue For

            End If

            Dim processName As String =
                GetProcessName(pid)

            results.Add(
                New PortProcessInfo With {
                    .Protocol = "TCP",
                    .Address = localAddress,
                    .Port = port,
                    .State = state,
                    .ProcessId = pid,
                    .ProcessName = processName
                })

        Next

    End Sub

    Private Shared Function TryGetPort(
        localAddress As String,
        ByRef port As Integer) As Boolean

        Dim lastColon As Integer =
            localAddress.LastIndexOf(":"c)

        If lastColon < 0 Then
            Return False
        End If

        Return Integer.TryParse(
            localAddress.Substring(lastColon + 1),
            port)

    End Function

    Private Shared Function GetProcessName(
        pid As Integer) As String

        Try

            Dim p =
                Process.GetProcessById(pid)

            Return p.ProcessName

        Catch

            Return "(Unknown)"

        End Try

    End Function

End Class