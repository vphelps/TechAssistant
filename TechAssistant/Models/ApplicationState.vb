Public NotInheritable Class ApplicationState

    Private Sub New()
    End Sub

    Public Shared Property Options As AppOptions

    Public Shared Property RunningAsAdmin As Boolean = False


    Public Shared Sub Save()

        OptionsManager.Save(
            Options)

    End Sub
End Class