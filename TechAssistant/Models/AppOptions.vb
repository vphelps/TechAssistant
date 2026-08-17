Imports System.Windows.Forms

Public Class AppOptions

    ' -------------------------------------------------
    ' Application
    ' -------------------------------------------------

    Public Property WindowTitle As String = "TechAssistant"

    ' -------------------------------------------------
    ' Main Window
    ' -------------------------------------------------

    Public Property RememberWindowSize As Boolean = True
    Public Property WindowLeft As Integer
    Public Property WindowTop As Integer
    Public Property WindowWidth As Integer = 1200
    Public Property WindowHeight As Integer = 700
    Public Property WindowState As FormWindowState = FormWindowState.Normal

    ' -------------------------------------------------
    ' Database
    ' -------------------------------------------------
    Public Property LastDatabaseServer As String = String.Empty

    ' -------------------------------------------------
    ' Export
    ' -------------------------------------------------
    Public Property PreferredExportFormat As ExportFormatType = ExportFormatType.Excel

    Public Enum ExportFormatType
        Excel = 0
        Csv = 1
    End Enum

End Class