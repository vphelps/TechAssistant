Imports System.Drawing

''' <summary>
''' Represents the calculated risk tier based on database size thresholds.
''' </summary>
Public Enum RiskLevel
    Unknown
    Low
    RequiresReview
    High
End Enum

Public Class UpgradeCheckModel
    Public Property LocationName As String = "Unknown"
    Public Property SqlVersion As String = "Unknown"
    Public Property OsVersionFriendly As String = "Unknown"
    Public Property OsBuildNumber As String = "Unknown"
    Public Property DatabaseSizeGB As Decimal? = Nothing
    Public Property LargestTableSizeKB As Decimal? = Nothing

    ' Combined OS Display String
    Public ReadOnly Property FullOsDisplay As String
        Get
            Return $"{OsVersionFriendly} (Build Number {OsBuildNumber})"
        End Get
    End Property

    ''' <summary>
    ''' Evaluates the strongly-typed RiskLevel dynamically based on cloud CloudAppSettings thresholds.
    ''' </summary>
    Public Function GetRiskLevel(settings As CloudAppSettings) As RiskLevel
        If Not DatabaseSizeGB.HasValue Then
            Return RiskLevel.Unknown
        End If

        ' Default to standard fallback thresholds if settings fails to pass
        Dim warningThreshold As Decimal = If(settings IsNot Nothing, settings.DbSizeWarningThresholdGB, 4D)
        Dim criticalThreshold As Decimal = If(settings IsNot Nothing, settings.DbSizeCriticalThresholdGB, 10D)

        Select Case DatabaseSizeGB.Value
            Case >= criticalThreshold
                Return RiskLevel.High
            Case >= warningThreshold
                Return RiskLevel.RequiresReview
            Case Else
                Return RiskLevel.Low
        End Select
    End Function

    ''' <summary>
    ''' Returns the formatted risk level description driven by cloud AppSettings thresholds.
    ''' </summary>
    Public Function GetRiskDescription(settings As CloudAppSettings) As String
        Dim warningThreshold As Decimal = If(settings IsNot Nothing, settings.DbSizeWarningThresholdGB, 4D)
        Dim criticalThreshold As Decimal = If(settings IsNot Nothing, settings.DbSizeCriticalThresholdGB, 10D)

        ' Format thresholds using '0.##' to cleanly display decimals (e.g., 4.5) while dropping unnecessary zeroes (e.g., 4)
        Dim warningStr As String = warningThreshold.ToString("0.##")
        Dim criticalStr As String = criticalThreshold.ToString("0.##")

        Select Case GetRiskLevel(settings)
            Case RiskLevel.High
                Return $"High Risk (> {criticalStr} GB): Escalate to Advanced Support Tech & Development"
            Case RiskLevel.RequiresReview
                Return $"Requires Review ({warningStr}–{criticalStr} GB): Escalate to Advanced Support Tech"
            Case RiskLevel.Low
                Return $"Low Risk (< {warningStr} GB): Ready for scheduling"
            Case Else
                Return "Unable to retrieve database size."
        End Select
    End Function

    ''' <summary>
    ''' Returns the UI background color corresponding to the calculated risk level.
    ''' </summary>
    Public Function GetRiskBackColor(settings As CloudAppSettings) As Color
        Select Case GetRiskLevel(settings)
            Case RiskLevel.High
                Return If(settings IsNot Nothing, settings.CriticalRiskBackColor, Color.MistyRose)
            Case RiskLevel.RequiresReview
                Return If(settings IsNot Nothing, settings.WarningRiskBackColor, Color.LightGoldenrodYellow)
            Case RiskLevel.Low
                Return If(settings IsNot Nothing, settings.LowRiskBackColor, Color.LightGreen)
            Case Else
                Return Color.LightGray
        End Select
    End Function

    ''' <summary>
    ''' Returns the UI text foreground color optimized for readability against RiskBackColor.
    ''' </summary>
    Public Function GetRiskForeColor(settings As CloudAppSettings) As Color
        Select Case GetRiskLevel(settings)
            Case RiskLevel.High
                Return Color.DarkRed
            Case RiskLevel.RequiresReview
                Return Color.DarkGoldenrod
            Case RiskLevel.Low
                Return Color.DarkGreen
            Case Else
                Return Color.Black
        End Select
    End Function

    ''' <summary>
    ''' Fetches system information and database size, returning a populated model instance.
    ''' </summary>
    Public Shared Function LoadFromSystem() As UpgradeCheckModel
        Dim model As New UpgradeCheckModel()

        ' 1. Fetch OS Details
        Dim os As OperatingSystem = Environment.OSVersion
        model.OsBuildNumber = os.Version.Build.ToString()
        model.OsVersionFriendly = SystemInfo.GetWindowsFriendlyName()

        ' 2. Fetch Database & Location Info
        Try
            ' Location Name
            Dim locResult As Object = DatabaseService.ExecuteScalar("SELECT LocName FROM ApplicationInfo")
            If locResult IsNot Nothing AndAlso Not Convert.IsDBNull(locResult) Then
                model.LocationName = locResult.ToString()
            End If

            ' SQL Server Version
            Dim sqlVerResult As Object = DatabaseService.ExecuteScalar("SELECT LEFT(@@VERSION, CHARINDEX(' (', @@VERSION) - 1) + ' ' + CAST(SERVERPROPERTY('ProductLevel') AS VARCHAR) + ' ' + CAST(SERVERPROPERTY('Edition') AS VARCHAR)")
            If sqlVerResult IsNot Nothing AndAlso Not Convert.IsDBNull(sqlVerResult) Then
                model.SqlVersion = sqlVerResult.ToString()
            End If

            ' Database Data File Size (Rows only for SQL Express 10 GB limit check)
            Dim sizeSql As String = "SELECT CAST(SUM(CAST(size AS bigint)) * 8.0 / 1024 / 1024 AS DECIMAL(10, 2)) FROM sys.database_files WHERE type_desc = 'ROWS'"
            Dim sizeResult As Object = DatabaseService.ExecuteScalar(sizeSql)

            If sizeResult IsNot Nothing AndAlso Not Convert.IsDBNull(sizeResult) Then
                model.DatabaseSizeGB = Convert.ToDecimal(sizeResult)
            End If

            ' Largest Table Size
            Dim tableSize As String = Queries.GetLargestDbTableSize
            Dim tableSizeResult As Object = DatabaseService.ExecuteScalar(tableSize)
            If tableSizeResult IsNot Nothing AndAlso Not Convert.IsDBNull(tableSizeResult) Then
                model.LargestTableSizeKB = Convert.ToDecimal(tableSizeResult)
            End If

        Catch ex As Exception
            ' Temporarily pop up the actual SQL error message so you can see what failed in the EXE
            MessageBox.Show($"Database Connection Error: {ex.Message}{Environment.NewLine}{ex.StackTrace}",
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            ' Default fallback values remain "Unknown" / Nothing
        End Try

        Return model
    End Function
    ''' <summary>
    ''' Formats the model data into a structured text report.
    ''' </summary>
    Public Function ToTextReport(settings As CloudAppSettings) As String
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("==================================================")
        sb.AppendLine("           UPGRADE CHECK REPORT                   ")
        sb.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}")
        sb.AppendLine("==================================================")
        sb.AppendLine()
        sb.AppendLine($"Location Name:  {LocationName}")
        sb.AppendLine($"OS Version:     {FullOsDisplay}")
        sb.AppendLine($"SQL Version:    {SqlVersion}")
        sb.AppendLine()
        sb.AppendLine("--------------------------------------------------")
        sb.AppendLine("DATABASE & RISK SUMMARY")
        sb.AppendLine("--------------------------------------------------")

        If DatabaseSizeGB.HasValue Then
            sb.AppendLine($"Database Size:  {DatabaseSizeGB.Value:N2} GB")
        Else
            sb.AppendLine("Database Size:  Unknown")
        End If

        sb.AppendLine($"Risk Assessment: {GetRiskDescription(settings)}")
        sb.AppendLine()

        sb.AppendLine("--------------------------------------------------")
        sb.AppendLine("SIZE CALCULATIONS")
        sb.AppendLine("--------------------------------------------------")

        If LargestTableSizeKB.HasValue AndAlso DatabaseSizeGB.HasValue Then
            Dim tableSizeGB As Decimal = LargestTableSizeKB.Value / 1048576D
            Dim dbSizeGB As Decimal = DatabaseSizeGB.Value
            Dim sizeRounded As Decimal = Math.Round(tableSizeGB + dbSizeGB, 2)

            sb.AppendLine($"Largest Table:  {tableSizeGB:N2} GB ({LargestTableSizeKB.Value:N0} KB)")
            sb.AppendLine($"Total Combined: DB size ({dbSizeGB:N2} GB) + largest table ({tableSizeGB:N2} GB) = {sizeRounded:N2} GB")
        Else
            sb.AppendLine("Unable to calculate total size (Database or Table size missing).")
        End If

        sb.AppendLine()
        sb.AppendLine("==================================================")

        Return sb.ToString()
    End Function
    ''' <summary>
    ''' Formats the model data into a clean, concise string suitable for pasting into chats, emails, or tickets.
    ''' </summary>
    Public Function ToClipboardString(settings As CloudAppSettings) As String
        ' Reuses the same formatted string generated for text export
        Return ToTextReport(settings)
    End Function

End Class