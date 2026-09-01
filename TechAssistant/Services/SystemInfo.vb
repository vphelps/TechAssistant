Imports System.Data
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Diagnostics

Public NotInheritable Class SystemInfo


    Private Sub New()
    End Sub

#Region "Computer Information"

    Public Shared Function GetComputerName() As String

        Return Environment.MachineName

    End Function

    Public Shared Function GetUserName() As String

        Return Environment.UserName

    End Function

    Public Shared Function GetDomainName() As String

        Return Environment.UserDomainName

    End Function

    Public Shared Function GetOsDescription() As String

        Return RuntimeInformation.OSDescription

    End Function

    Public Shared Function GetArchitecture() As String

        Return If(
            Environment.Is64BitOperatingSystem,
            "64-Bit",
            "32-Bit")

    End Function

    Public Shared Function GetSystemUptime() As String

        Dim uptime As TimeSpan =
            TimeSpan.FromMilliseconds(
                Environment.TickCount64)

        Return $"{uptime.Days} Days {uptime.Hours} Hours {uptime.Minutes} Minutes"

    End Function

#End Region

#Region "Hardware Information"

    Public Shared Function GetInstalledRamGB() As String

        Try

            Dim totalBytes As ULong = 0

            Using searcher As New ManagementObjectSearcher(
                "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem")

                For Each obj As ManagementObject In searcher.Get()

                    totalBytes =
                        Convert.ToUInt64(
                            obj("TotalPhysicalMemory"))

                Next

            End Using

            Dim totalGb =
                totalBytes / 1024D / 1024D / 1024D

            Return $"{Math.Round(totalGb, 2)} GB"

        Catch

            Return "Unknown"

        End Try

    End Function

    Public Shared Function GetSystemDriveFreeSpace() As String

        Try

            Dim drive As New DriveInfo("C")

            Dim freeGb =
                drive.AvailableFreeSpace / 1024D / 1024D / 1024D

            Dim totalGb =
                drive.TotalSize / 1024D / 1024D / 1024D

            Return $"{freeGb:N0} GB Free of {totalGb:N0} GB"

        Catch

            Return "Unknown"

        End Try

    End Function

#End Region

#Region "Network Information"

    Public Shared Function GetIPv4Addresses() As String

        Try

            Dim addresses As New List(Of String)

            For Each ip In Dns.GetHostAddresses(
                Dns.GetHostName())

                If ip.AddressFamily =
                    AddressFamily.InterNetwork Then

                    addresses.Add(ip.ToString())

                End If

            Next

            Return String.Join(", ", addresses)

        Catch

            Return "Unknown"

        End Try

    End Function

#End Region

#Region "Application Information"

    Public Shared Function GetApplicationVersion() As String

        Return Application.ProductVersion

    End Function

    Public Shared Function GetRuntimeVersion() As String

        Return RuntimeInformation.FrameworkDescription

    End Function

#End Region

#Region "Database Information"

    Public Shared Function GetDatabaseServer() As String

        Try

            Dim settings =
                ConfigurationLoader.LoadSettings()

            Return settings.Server

        Catch

            Return "Unknown"

        End Try

    End Function

    Public Shared Function GetDatabaseName() As String

        Try

            Dim settings =
                ConfigurationLoader.LoadSettings()

            Return settings.Database

        Catch

            Return "Unknown"

        End Try

    End Function

    Public Shared Function GetDatabaseConnectionStatus() As String

        Try

            Using cn = DatabaseService.CreateConnection()

                cn.Open()

                Return "Connected"

            End Using

        Catch

            Return "Disconnected"

        End Try

    End Function

#End Region

#Region "DataTable Builder"

    Public Shared Function BuildSystemInfoTable() As DataTable

        Dim dt As New DataTable

        dt.Columns.Add("Property")
        dt.Columns.Add("Value")

        ' Computer
        dt.Rows.Add("=== Computer ===", "")
        dt.Rows.Add("Computer Name", GetComputerName())
        dt.Rows.Add("User Name", GetUserName())
        dt.Rows.Add("Domain", GetDomainName())
        dt.Rows.Add("Operating System", GetOsDescription())
        dt.Rows.Add("Architecture", GetArchitecture())
        dt.Rows.Add("System Uptime", GetSystemUptime())

        ' Hardware
        dt.Rows.Add("=== Hardware ===", "")
        dt.Rows.Add("Installed RAM", GetInstalledRamGB())
        dt.Rows.Add("System Drive Free Space", GetSystemDriveFreeSpace())

        ' Network
        dt.Rows.Add("=== Network ===", "")
        dt.Rows.Add("IPv4 Addresses", GetIPv4Addresses())

        ' Database
        dt.Rows.Add("=== Database ===", "")
        dt.Rows.Add("Database Server", GetDatabaseServer())
        dt.Rows.Add("Database Name", GetDatabaseName())
        dt.Rows.Add("Database Status", GetDatabaseConnectionStatus())

        'Advantage 
        Dim advInfo = GetAdvantageInfo()
        dt.Rows.Add("=== Advantage ===", "")
        Dim verTemp As String = $"{ advInfo.Version} / {advInfo.Architecture}"
        dt.Rows.Add("Advantage Version/Architecture", verTemp)
        dt.Rows.Add(".NET Runtime", GetRuntimeVersion())
        Return dt

    End Function
#End Region
    Public Shared Function AdvExeCheck(executable As String) As AdvantageInfo.AppInstallState

        Dim fileExistsX86 As Boolean = File.Exists($"{AppPaths.CEPath86}{executable}.exe")
        Dim fileExistsX64 As Boolean = File.Exists($"{AppPaths.CEPath64}{executable}.exe")

        If fileExistsX64 Then Return AdvantageInfo.AppInstallState.InstalledX64
        If fileExistsX86 Then Return AdvantageInfo.AppInstallState.InstalledX86

        Return AdvantageInfo.AppInstallState.NotInstalled

    End Function
    Public Shared Function GetAdvantageDllPath() As String

        Dim x64Dll As String = Path.Combine(AppPaths.CEPath64, "AdvCommon.dll")
        Dim x86Dll As String = Path.Combine(AppPaths.CEPath86, "AdvCommon.dll")

        If File.Exists(x64Dll) Then Return x64Dll
        If File.Exists(x86Dll) Then Return x86Dll

        Return Nothing

    End Function

    Public Shared Function GetAdvantageInfo() As AdvantageInfo

        Dim result As New AdvantageInfo

        Try

            Dim dllPath = GetAdvantageDllPath()

            If String.IsNullOrEmpty(dllPath) Then

                result.Installed = False
                result.Version = "Advantage Not Installed"
                result.Architecture = "Not Installed"

                Return result

            End If

            Dim vi = FileVersionInfo.GetVersionInfo(dllPath)

            result.Installed = True

            result.Version = $"{vi.FileMajorPart}.{vi.FileMinorPart}.{vi.FileBuildPart}.{vi.FilePrivatePart}"
            result.Architecture = If(dllPath.StartsWith(AppPaths.CEPath64, StringComparison.OrdinalIgnoreCase), "x64", "x86")

            Return result

        Catch

            result.Installed = False
            result.Version = "Unknown"
            result.Architecture = "Unknown"

            Return result

        End Try

    End Function
    Public Shared Function GetWindowsFriendlyName() As String
        Try
            Dim searcher As New ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem")
            For Each os As ManagementObject In searcher.Get()
                If os("Caption") IsNot Nothing Then
                    Return os("Caption").ToString().Trim()
                End If
            Next
        Catch ex As Exception
            ' Fallback to built-in Environment version
            Return Environment.OSVersion.ToString()
        End Try

        Return Environment.OSVersion.ToString()
    End Function

End Class