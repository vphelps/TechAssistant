Imports System.Security.Cryptography
Imports System.Text

Public Class ConfigurationLoader

    Private Shared ReadOnly PasswordEntropy As Byte() =
    {
        &H40, &H89, &H2, &H90, &H16, &H60,
        &H5A, &H60, &H7E, &H34, &HA4, &H3E,
        &H61, &H2B, &H35, &H2B, &H36, &HDA,
        &HAC, &HC3, &H92, &HFF, &H7, &HDF
    }

    Public Shared Function LoadSettings() As DatabaseSettings

        Dim ini As New IniFile("C:\PFSCommon\PFSConnect.ini")

        Dim settings As New DatabaseSettings

        settings.Server =
            ini.ReadString("SQL2000", "DataSource")

        settings.Database =
            ini.ReadString("SQL2000", "Catalog")

        settings.UserID =
            ini.ReadString("SQL2000", "UserID")

        settings.IntegratedSecurity =
            ini.ReadInteger("SQL2000", "IntegratedSecurity") = 1

        Dim rawPassword =
            ini.ReadString("SQL2000", "Password")

        Dim encryptionFlag =
            ini.ReadInteger("SQL2000", "PasswordEncryption")

        If encryptionFlag = 1 Then

            settings.Password =
                Encoding.UTF8.GetString(
                    ProtectedData.Unprotect(
                        Convert.FromBase64String(rawPassword),
                        PasswordEntropy,
                        DataProtectionScope.LocalMachine))

        Else

            settings.Password = rawPassword

        End If

        Return settings

    End Function

End Class