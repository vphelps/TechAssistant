Imports System.Net.Http
Imports System.Diagnostics

Partial Public Class FormMain
    Private Async Function TestHttpUrl() _
    As Task

        Dim url As String =
            tbHttpUrl.Text.Trim()

        rtbHttpResults.Clear()

        If String.IsNullOrWhiteSpace(url) Then

            rtbHttpResults.Text =
                "URL is required."

            Return

        End If

        Try

            Using client As New HttpClient()

                client.Timeout =
                    TimeSpan.FromSeconds(10)

                Dim stopwatch As New Stopwatch()

                stopwatch.Start()

                Dim response =
                    Await client.GetAsync(url)

                stopwatch.Stop()

                DisplayResponse(
                    response,
                    stopwatch.ElapsedMilliseconds)

            End Using

        Catch ex As Exception

            rtbHttpResults.Text =
                ex.Message

        End Try

    End Function
    Private Sub DisplayResponse(
    response As HttpResponseMessage,
    responseTime As Long)

        rtbHttpResults.Clear()

        Dim statusCode As Integer =
    CInt(response.StatusCode)

        If statusCode >= 200 AndAlso
   statusCode < 300 Then

            rtbHttpResults.SelectionColor =
        Color.DarkGreen

        ElseIf statusCode >= 400 Then

            rtbHttpResults.SelectionColor =
        Color.DarkRed

        Else

            rtbHttpResults.SelectionColor =
        Color.DarkOrange

        End If

        rtbHttpResults.AppendText(
    $"Status: {statusCode} {response.ReasonPhrase}" &
    Environment.NewLine)

        rtbHttpResults.SelectionColor =
    Color.Black


        rtbHttpResults.AppendText(
            $"Response Time: {responseTime} ms" &
            Environment.NewLine)

        rtbHttpResults.AppendText(
            Environment.NewLine)

        If chkShowResponseHeaders.Checked Then

            rtbHttpResults.AppendText(
                "Headers" &
                Environment.NewLine)

            rtbHttpResults.AppendText(
                "------------------------" &
                Environment.NewLine)

            For Each header In response.Headers

                rtbHttpResults.AppendText(
                    $"{header.Key}: " &
                    $"{String.Join(", ", header.Value)}" &
                    Environment.NewLine)

            Next

        End If

    End Sub

End Class
