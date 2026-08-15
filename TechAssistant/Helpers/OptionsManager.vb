Imports System.IO
Imports System.Text.Json

Public NotInheritable Class OptionsManager

    Private Sub New()
    End Sub

    Private Shared ReadOnly OptionsFilePath As String =
        Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData),
            "TechAssistant",
            "options.json")

    Public Shared Function Load() As AppOptions

        Try

            If Not File.Exists(
                OptionsFilePath) Then

                Return New AppOptions()

            End If

            Dim json As String =
                File.ReadAllText(
                    OptionsFilePath)

            Dim options =
                JsonSerializer.Deserialize(
                    Of AppOptions)(json)

            Return If(
                options,
                New AppOptions())

        Catch

            Return New AppOptions()

        End Try

    End Function

    Public Shared Sub Save(
        options As AppOptions)

        Dim folder As String =
            Path.GetDirectoryName(
                OptionsFilePath)

        Directory.CreateDirectory(
            folder)

        Dim json As String =
            JsonSerializer.Serialize(
                options,
                New JsonSerializerOptions With {
                    .WriteIndented = True
                })

        File.WriteAllText(
            OptionsFilePath,
            json)

    End Sub

End Class