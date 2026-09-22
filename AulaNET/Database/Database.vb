Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class Database

    Private Shared ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("MeuBanco").ConnectionString

    Public Shared Function GetConnection() As SqlConnection

        Return New SqlConnection(connectionString)

    End Function

End Class