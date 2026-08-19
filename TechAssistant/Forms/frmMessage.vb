Public Class frmMessage
    Inherits Form

    Public Sub Configure(
    title As String,
    message As String,
    messageType As MessageType,
    buttons As MessageBoxButtons)

        Me.Text = title

        lblMessage.Text = message

        Select Case messageType

            Case MessageType.Information
                picIcon.Image =
                SystemIcons.Information.ToBitmap()

            Case MessageType.Warning
                picIcon.Image =
                SystemIcons.Warning.ToBitmap()

            Case MessageType.Error
                picIcon.Image =
                SystemIcons.Error.ToBitmap()

            Case MessageType.Question
                picIcon.Image =
                SystemIcons.Question.ToBitmap()

        End Select
        ConfigureButtons(buttons)

    End Sub
    Private Sub ConfigureButtons(
    buttons As MessageBoxButtons)

        btnOk.Visible = False
        btnYes.Visible = False
        btnNo.Visible = False
        btnCancel.Visible = False

        Select Case buttons

            Case MessageBoxButtons.OK

                btnOk.Visible = True
                AcceptButton = btnOk

            Case MessageBoxButtons.YesNo

                btnYes.Visible = True
                btnNo.Visible = True

                AcceptButton = btnYes
                CancelButton = btnNo

            Case MessageBoxButtons.OKCancel

                btnOk.Visible = True
                btnCancel.Visible = True

                AcceptButton = btnOk
                CancelButton = btnCancel

        End Select

    End Sub
    Private Sub btnOK_Click(
    sender As Object,
    e As EventArgs) Handles btnOk.Click

        DialogResult = DialogResult.OK

    End Sub

    Private Sub btnYes_Click(
        sender As Object,
        e As EventArgs) Handles btnYes.Click

        DialogResult = DialogResult.Yes

    End Sub

    Private Sub btnNo_Click(
        sender As Object,
        e As EventArgs) Handles btnNo.Click

        DialogResult = DialogResult.No

    End Sub

    Private Sub btnCancel_Click(
        sender As Object,
        e As EventArgs) Handles btnCancel.Click

        DialogResult = DialogResult.Cancel

    End Sub

End Class