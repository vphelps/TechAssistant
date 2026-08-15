Public Class AppOptions

    Public Property WindowTitle As String = "TechAssistant"
    Public Property RememberWindowSize As Boolean = True

    Public Property WindowLeft As Integer

    Public Property WindowTop As Integer

    Public Property WindowWidth As Integer = 1200

    Public Property WindowHeight As Integer = 700

    Public Property WindowState As FormWindowState = FormWindowState.Normal
    Public Property LastDatabaseServer As String =
        String.Empty

    Public Property PreferredExportFormat As ExportFormat

    Public Enum ExportFormat

        Excel = 0

        Csv = 1

    End Enum

End Class