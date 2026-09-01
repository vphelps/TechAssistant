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

    ' Strongly-typed Risk Level Enum property
    Public ReadOnly Property CurrentRiskLevel As RiskLevel
        Get
            If Not DatabaseSizeGB.HasValue Then
                Return RiskLevel.Unknown
            End If

            Select Case DatabaseSizeGB.Value
                Case >= 10D
                    Return RiskLevel.High
                Case >= 4D
                    Return RiskLevel.RequiresReview
                Case Else
                    Return RiskLevel.Low
            End Select
        End Get
    End Property

    ' Calculated Risk Level Description driven by CurrentRiskLevel
    Public ReadOnly Property RiskLevelDescription As String
        Get
            Select Case CurrentRiskLevel
                Case RiskLevel.High
                    Return "High Risk (> 10 GB): Escalate to Advanced Support Tech & Development"
                Case RiskLevel.RequiresReview
                    Return "Requires Review (4–10 GB): Escalate to Advanced Support Tech"
                Case RiskLevel.Low
                    Return "Low Risk (< 4 GB): Ready for scheduling"
                Case Else
                    Return "Unable to retrieve database size."
            End Select
        End Get
    End Property

    ' Background color for UI indicators/labels based on risk tier
    Public ReadOnly Property RiskBackColor As Color
        Get
            Select Case CurrentRiskLevel
                Case RiskLevel.High
                    Return Color.MistyRose            ' Soft red highlight
                Case RiskLevel.RequiresReview
                    Return Color.LightGoldenrodYellow ' Soft yellow highlight
                Case RiskLevel.Low
                    Return Color.LightGreen           ' Soft green highlight
                Case Else
                    Return Color.LightGray            ' Default neutral highlight
            End Select
        End Get
    End Property

    ' Foreground text color optimized for contrast against RiskBackColor
    Public ReadOnly Property RiskForeColor As Color
        Get
            Select Case CurrentRiskLevel
                Case RiskLevel.High
                    Return Color.DarkRed
                Case RiskLevel.RequiresReview
                    Return Color.DarkGoldenrod
                Case RiskLevel.Low
                    Return Color.DarkGreen
                Case Else
                    Return Color.Black
            End Select
        End Get
    End Property

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
            'Dim sqlVerResult As Object = DatabaseService.ExecuteScalar("SELECT @@VERSION")
            If sqlVerResult IsNot Nothing AndAlso Not Convert.IsDBNull(sqlVerResult) Then
                model.SqlVersion = sqlVerResult.ToString()
            End If

            ' Database Data File Size (Rows only for SQL Express 10 GB limit check)
            Dim sizeSql As String = "SELECT CAST(SUM(CAST(size AS bigint)) * 8.0 / 1024 / 1024 AS DECIMAL(10, 2)) FROM sys.database_files WHERE type_desc = 'ROWS'"
            Dim sizeResult As Object = DatabaseService.ExecuteScalar(sizeSql)

            If sizeResult IsNot Nothing AndAlso Not Convert.IsDBNull(sizeResult) Then
                model.DatabaseSizeGB = Convert.ToDecimal(sizeResult)
            End If

            Dim tableSize As String = Queries.GetLargestDbTableSize
            Dim tableSizeResult As Object = DatabaseService.ExecuteScalar(tableSize)
            If tableSizeResult IsNot Nothing AndAlso Not Convert.IsDBNull(tableSizeResult) Then
                model.LargestTableSizeKB = Convert.ToDecimal(tableSizeResult)
            End If
        Catch ex As Exception
            ' If database access fails, default values remain "Unknown" / Nothing
        End Try

        Return model
    End Function
End Class