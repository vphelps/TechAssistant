Imports System.ServiceProcess

Public Class ServiceHelper

    Private Shared ReadOnly _serviceNames As New List(Of String) From {
        "AdvApiServer",
        "AdvCoreService",
        "AdvantageCloudSyncService",
        "AdvCreditService",
        "AdvLicService",
        "AdvSignageService",
        "AdvTurnstileEngine",
        "AdvNotifyService",
        "AdvantageUpgradeService",
        "AdvRelayClient"
    }

    Private Shared ReadOnly _timeout As TimeSpan =
        TimeSpan.FromMinutes(2)

    Public Shared Function GetServices() As List(Of ServiceController)

        Dim services = ServiceController.GetServices()

        Dim result As New List(Of ServiceController)

        For Each service In services

            If _serviceNames.Contains(service.ServiceName, StringComparer.OrdinalIgnoreCase) Then

                result.Add(service)

            ElseIf service.ServiceName.StartsWith(
                "MSSQL",
                StringComparison.OrdinalIgnoreCase) OrElse
                service.ServiceName.StartsWith(
                "SQLAgent",
                StringComparison.OrdinalIgnoreCase) Then

                result.Add(service)

            End If

        Next

        Return result.
            OrderBy(Function(s) s.DisplayName).
            ToList()

    End Function

    Public Shared Sub StartService(serviceName As String)

        Try
            Using svc As New ServiceController(serviceName)
                svc.Refresh()
                Select Case svc.Status
                    Case ServiceControllerStatus.Running
                        Exit Sub
                    Case ServiceControllerStatus.StartPending
                        WaitForServiceStatus(svc, ServiceControllerStatus.Running)
                        Exit Sub
                End Select

                svc.Start()
                WaitForServiceStatus(svc, ServiceControllerStatus.Running)
            End Using

        Catch ex As Exception
            Throw New Exception($"Failed to start service '{serviceName}'.", ex)
        End Try

    End Sub

    Public Shared Sub StopService(
        serviceName As String)

        Try
            Using svc As New ServiceController(serviceName)
                svc.Refresh()
                Select Case svc.Status
                    Case ServiceControllerStatus.Stopped
                        Exit Sub
                    Case ServiceControllerStatus.StopPending
                        WaitForServiceStatus(svc, ServiceControllerStatus.Stopped)
                        Exit Sub
                End Select

                svc.Stop()
                WaitForServiceStatus(svc, ServiceControllerStatus.Stopped)
            End Using

        Catch ex As Exception
            Throw New Exception(
                $"Failed to stop service '{serviceName}'.", ex)
        End Try

    End Sub

    Public Shared Sub RestartService(serviceName As String)

        Try
            Using svc As New ServiceController(serviceName)

                svc.Refresh()

                If svc.Status <> ServiceControllerStatus.Stopped Then
                    svc.Stop()
                    WaitForServiceStatus(svc, ServiceControllerStatus.Stopped)
                End If

                svc.Start()
                WaitForServiceStatus(svc, ServiceControllerStatus.Running)
            End Using

        Catch ex As Exception
            Throw New Exception($"Failed to restart service '{serviceName}'.", ex)
        End Try

    End Sub

    Private Shared Sub WaitForServiceStatus(svc As ServiceController, expectedStatus As ServiceControllerStatus)

        Dim timeoutAt As DateTime = DateTime.Now.Add(_timeout)

        Do
            svc.Refresh()
            If svc.Status = expectedStatus Then
                Exit Sub
            End If

            Threading.Thread.Sleep(1000)

        Loop Until DateTime.Now >= timeoutAt

        Throw New TimeoutException($"Service '{svc.ServiceName}' did not reach status '{expectedStatus}' within {_timeout.TotalMinutes} minutes.")

    End Sub

End Class