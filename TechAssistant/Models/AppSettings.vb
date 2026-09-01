Imports System.Drawing
Imports System.Net.Http
Imports System.Text.Json

Public Class CloudAppSettings
    Public Property DbSizeWarningThresholdGB As Decimal = 4D
    Public Property DbSizeCriticalThresholdGB As Decimal = 10D

    Public Property ColorLowRiskHex As String = "#90EE90"
    Public Property ColorWarningRiskHex As String = "#FFFACD"
    Public Property ColorCriticalRiskHex As String = "#FFB6C1"

    Public Property TextLowRiskHex As String = "#006400"
    Public Property TextWarningRiskHex As String = "#B8860B"
    Public Property TextCriticalRiskHex As String = "#8B0000"

    Public ReadOnly Property LowRiskBackColor As Color
        Get
            Return ColorTranslator.FromHtml(ColorLowRiskHex)
        End Get
    End Property

    Public ReadOnly Property WarningRiskBackColor As Color
        Get
            Return ColorTranslator.FromHtml(ColorWarningRiskHex)
        End Get
    End Property

    Public ReadOnly Property CriticalRiskBackColor As Color
        Get
            Return ColorTranslator.FromHtml(ColorCriticalRiskHex)
        End Get
    End Property

    ''' <summary>
    ''' Fetches the latest remote configuration JSON over HTTPS.
    ''' </summary>
    Public Shared Async Function FetchLatestAsync() As Task(Of CloudAppSettings)
        Dim rawSettingsUrl As String = "https://raw.githubusercontent.com/vphelps/TechAssistant/main/settings.json"

        Try
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(5)
                client.DefaultRequestHeaders.Add("User-Agent", "TechAssistantApp")

                Dim json As String = Await client.GetStringAsync(rawSettingsUrl)

                Dim options As New JsonSerializerOptions With {
                    .PropertyNameCaseInsensitive = True
                }

                Return JsonSerializer.Deserialize(Of CloudAppSettings)(json, options)
            End Using
        Catch ex As Exception
            Return New CloudAppSettings()
        End Try
    End Function
End Class