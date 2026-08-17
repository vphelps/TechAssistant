Partial Public Class FormMain

    Private Enum ToolCategory

        Advantage

        Windows

    End Enum

    Private Class ToolButtonDefinition

        Public Property Button As Button

        Public Property FilePath As String

        Public Property ToolTip As String

        Public Property Category As ToolCategory

    End Class

    Private Sub InitializeIcons()

        Dim buttons As New List(Of ToolButtonDefinition) From {
        New ToolButtonDefinition With {
            .Button = btnAdvManager,
            .FilePath = GetAdvantagePath("AdvManager.exe"),
            .ToolTip = "Advantage Manager",
            .Category = ToolCategory.Advantage
        },
        New ToolButtonDefinition With {
            .Button = btnPos,
            .FilePath = GetAdvantagePath("Pos.exe"),
            .ToolTip = "Point of Sale",
            .Category = ToolCategory.Advantage
        },
        New ToolButtonDefinition With {
            .Button = btnAdvGroups,
            .FilePath = GetAdvantagePath("AdvGroups.exe"),
            .ToolTip = "Advantage Groups",
            .Category = ToolCategory.Advantage
        },
        New ToolButtonDefinition With {
            .Button = btnAdvRedeem,
            .FilePath = GetAdvantagePath("AdvRedeem.exe"),
            .ToolTip = "Advantage Redemption",
            .Category = ToolCategory.Advantage
        },
        New ToolButtonDefinition With {
            .Button = btnAdvKiosk,
            .FilePath = GetAdvantagePath("AdvKiosk.exe"),
            .ToolTip = "Advantage Kiosk",
            .Category = ToolCategory.Advantage
        },
        New ToolButtonDefinition With {
            .Button = btnKioskSetup,
            .FilePath = GetAdvantagePath("AdvKioskSetup.exe"),
            .ToolTip = "Kiosk Setup",
            .Category = ToolCategory.Advantage
        },
        New ToolButtonDefinition With {
            .Button = btnAdvReportEditor,
            .FilePath = GetAdvantagePath("AdvReportEditor.exe"),
            .ToolTip = "Advantage Report Editor",
                .Category = ToolCategory.Advantage
        }
    }

        For Each item In buttons

            SetButtonIcon(item)

        Next

        InitializeUtilityButtons()

    End Sub

    Private Sub InitializeUtilityButtons()

        Dim buttons As New List(Of ToolButtonDefinition) From {
        New ToolButtonDefinition With {
            .Button = btnCalculator,
            .FilePath = "C:\Windows\System32\calc.exe",
            .ToolTip = "Launch Calculator",
            .Category = ToolCategory.Windows
        },
        New ToolButtonDefinition With {
            .Button = btnTaskManager,
            .FilePath = "C:\Windows\System32\taskmgr.exe",
            .ToolTip = "Launch Task Manager",
            .Category = ToolCategory.Windows
        },
        New ToolButtonDefinition With {
            .Button = btnServices,
            .FilePath = "C:\Windows\System32\mmc.exe",
            .ToolTip = "Open Windows Services",
            .Category = ToolCategory.Windows
        },
        New ToolButtonDefinition With {
            .Button = btnEventViewer,
            .FilePath = "C:\Windows\System32\eventvwr.msc",
            .ToolTip = "Open Event Viewer",
            .Category = ToolCategory.Windows
        }
    }

        For Each item In buttons

            SetButtonIcon(item)

        Next

    End Sub
    Private Function GetAdvantagePath(
    exeName As String) As String

        Dim folder As String =
        IO.Path.GetDirectoryName(
            SystemInfo.GetAdvantageDllPath)

        Return IO.Path.Combine(
        folder,
        exeName)

    End Function
    Private Sub SetButtonIcon(
    tool As ToolButtonDefinition)

        Dim toolTip As ToolTip

        Select Case tool.Category

            Case ToolCategory.Advantage

                toolTip =
                ttAdvantageButtons

            Case Else

                toolTip =
                ttUtilityButtons

        End Select

        toolTip.SetToolTip(
        tool.Button,
        tool.ToolTip)

        If Not IO.File.Exists(tool.FilePath) Then
            Exit Sub
        End If

        Using icon As Icon =
        Icon.ExtractAssociatedIcon(tool.FilePath)

            If icon IsNot Nothing Then

                tool.Button.Image =
                icon.ToBitmap()

            End If

        End Using

    End Sub
End Class
