Partial Public Class FormMain
    Private Sub InitialLoad()
        Me.StartPosition = FormStartPosition.Manual
        Me.Left = ApplicationState.Options.WindowLeft
        Me.Top = ApplicationState.Options.WindowTop
        Me.Width = ApplicationState.Options.WindowWidth
        Me.Height = ApplicationState.Options.WindowHeight
        Me.WindowState = ApplicationState.Options.WindowState
        Me.Text = ApplicationState.Options.WindowTitle

        tbWindowTitle.Text = ApplicationState.Options.WindowTitle

        btnServiceRestart.Enabled = ApplicationState.RunningAsAdmin
        btnServiceStart.Enabled = ApplicationState.RunningAsAdmin
        btnServiceStop.Enabled = ApplicationState.RunningAsAdmin


    End Sub
End Class
