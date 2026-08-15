Imports Microsoft.Data.SqlClient

Public Class DatabaseService
    Private Shared _connectionString As String
    Private Const ApplicationName As String = "TechAssistant"


    Public Shared Function TestConnection() As Boolean

        Try
            Using cn = CreateConnection()
                cn.Open()
                Return True
            End Using
        Catch
            Return False
        End Try

    End Function
    Public Shared Function CreateConnection() As SqlConnection

        If String.IsNullOrEmpty(_connectionString) Then

            Dim settings = ConfigurationLoader.LoadSettings()

            Dim csb As New SqlConnectionStringBuilder()

            csb.DataSource = settings.Server
            csb.InitialCatalog = settings.Database

            If settings.IntegratedSecurity Then
                csb.IntegratedSecurity = True
            Else
                csb.UserID = settings.UserID
                csb.Password = settings.Password
            End If

            csb.Encrypt = False
            csb.TrustServerCertificate = True
            csb.ApplicationName = ApplicationName

            _connectionString = csb.ConnectionString
        End If

        Return New SqlConnection(_connectionString)

    End Function
    Public Shared Function ExecuteScalar(sql As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Object

        Using cn = CreateConnection()
            cn.Open()
            Using cmd = BuildCommand(sql, cn, parameters)

                Dim result As Object = cmd.ExecuteScalar()
                If result Is Nothing OrElse result Is DBNull.Value Then
                    Return Nothing
                End If
                Return result

            End Using

        End Using

    End Function
    Public Shared Function GetDataTable(sql As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable

        Dim dt As New DataTable

        Using cn = CreateConnection()
            cn.Open()
            Using cmd = BuildCommand(sql, cn, parameters)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using

        End Using

        Return dt

    End Function

    Public Shared Function ExecuteNonQuery(sql As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Integer

        Using cn = CreateConnection()

            cn.Open()

            Using cmd = BuildCommand(sql, cn, parameters)
                Return cmd.ExecuteNonQuery()
            End Using

        End Using

    End Function
    Private Shared Function BuildCommand(sql As String, cn As SqlConnection, Optional parameters As Dictionary(Of String, Object) = Nothing) As SqlCommand
        Dim cmd As New SqlCommand(sql, cn)

        cmd.CommandTimeout = 60


        If String.IsNullOrWhiteSpace(sql) Then
            Throw New ArgumentException("SQL statement cannot be empty.", NameOf(sql))
        End If


        If parameters IsNot Nothing Then
            For Each param As KeyValuePair(Of String, Object) In parameters

                cmd.Parameters.AddWithValue(param.Key, If(param.Value Is Nothing, DBNull.Value, param.Value))

            Next
        End If

        Return cmd

    End Function

End Class