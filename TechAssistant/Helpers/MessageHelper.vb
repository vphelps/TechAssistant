Public Module MessageHelper

    Private Function ShowMessage(
        message As String,
        title As String,
        messageType As MessageType,
        Optional buttons As MessageBoxButtons =
            MessageBoxButtons.OK) As DialogResult

        Using frm As New frmMessage

            frm.Configure(
                title,
                message,
                messageType,
                buttons)

            Return frm.ShowDialog()

        End Using

    End Function

    Public Sub ShowInfo(
        message As String,
        Optional title As String = "Information")

        ShowMessage(
            message,
            title,
            MessageType.Information)

    End Sub

    Public Sub ShowWarning(
        message As String,
        Optional title As String = "Warning")

        ShowMessage(
            message,
            title,
            MessageType.Warning)

    End Sub

    Public Sub ShowError(
        message As String,
        Optional title As String = "Error")

        ShowMessage(
            message,
            title,
            MessageType.Error)

    End Sub

    Public Function ShowQuestion(
        message As String,
        Optional title As String = "Question") As DialogResult

        Return ShowMessage(
            message,
            title,
            MessageType.Question,
            MessageBoxButtons.YesNo)

    End Function

End Module