Public Class AdvantageInfo

    Public Property Version As String
    Public Property Architecture As String
    Public Property Installed As Boolean
    Public Enum AppInstallState

        NotInstalled = 0
        InstalledX86 = 1
        InstalledX64 = 2

    End Enum
End Class