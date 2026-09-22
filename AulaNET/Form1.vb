
Imports Microsoft.Data.SqlClient
Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmMain has loaded successfully.")
    End Sub

    Private Sub btnClickMe_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        Dim FirstName As String = "John"
        Dim LastName As String

        MsgBox("Hello, " & FirstName & "!")
        MessageBox.Show("Hello, " & FirstName & "!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Console.WriteLine("frmMain has loaded successfully.")
        btnClickMe.Text = "Clicked!"
    End Sub

    Private Sub btnVariaveis_Click(sender As Object, e As EventArgs) Handles btnVariaveis.Click

    End Sub

    Private Sub btnSqlServer_Click(sender As Object, e As EventArgs) Handles btnSqlServer.Click
        Dim connectionString As String =
            "Server=localhost,1433;" &
            "Database=master;" &
            "User Id=sa;" &
            "Password=Sql@12345678;" &
            "TrustServerCertificate=True;"

        Using connection As New SqlConnection(connectionString)

            Try

                connection.Open()

                MessageBox.Show("Conectado ao SQL Server com sucesso!")

            Catch ex As Exception

                MessageBox.Show("Erro: " & ex.Message)

            End Try

        End Using
    End Sub
End Class
