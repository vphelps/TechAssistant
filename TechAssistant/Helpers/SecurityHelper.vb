Imports System.Security.Principal

Public Class SecurityHelper

    Public Shared Function IsRunningElevated() As Boolean

        Dim identity As WindowsIdentity =
            WindowsIdentity.GetCurrent()

        Dim principal As New WindowsPrincipal(
            identity)

        Return principal.IsInRole(
            WindowsBuiltInRole.Administrator)

    End Function

End Class