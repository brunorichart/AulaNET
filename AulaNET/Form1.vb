
Imports System.Xml
Imports Microsoft.Data
Imports Microsoft.Data.SqlClient
Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmMain has loaded successfully.")
    End Sub

    Private Sub btnClickMe_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        Dim FirstName As String = "John"
        ' Dim LastName As String
        ' Dim StrBrand As String
        ' Dim IntAge As Integer = 30
        ' Dim DoublePrice As Double = 19.99
        ' Dim BoolIsActive As Boolean = True
        ' Dim DateOfBirth As Date = New Date(1990, 1, 1)
        ' Dim DecimalAmount As Decimal = 100.5D


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
            "Database=meubanco;" &
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

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim connectionString As String =
            "Server=localhost,1433;" &
            "Database=meubanco;" &
            "User Id=sa;" &
            "Password=Sql@12345678;" &
            "TrustServerCertificate=True;"

        Dim sql As String = "INSERT INTO dbo.Pedidos" &
            "(ativo, data_cadastro, data_atualizacao) VALUES (@ativo, @dt_cad, NULL);"


        Using conexao As New SqlConnection(connectionString)

            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@ativo", SqlDbType.Bit).Value = 1
                comando.Parameters.Add("@dt_cad", SqlDbType.DateTime).Value = DateTime.Now

                Try

                    conexao.Open()
                    comando.ExecuteNonQuery()

                    MessageBox.Show("Pedido cadastrado com sucesso!")

                Catch ex As Exception

                    MessageBox.Show("Erro ao cadastrar: " & ex.Message)

                End Try

            End Using

        End Using
    End Sub
End Class
