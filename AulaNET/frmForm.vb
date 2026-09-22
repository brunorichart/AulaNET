Imports Microsoft.Data.SqlClient

Public Class frmForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim StrName As String = txtName.Text
        Dim StrEmail As String = txtEmail.Text
        Dim StrPhone As String = txtPhone.Text


        MessageBox.Show("Nome: " & StrName & vbCrLf &
                        "Email: " & StrEmail & vbCrLf &
                        "Telefone: " & StrPhone, "Informações do Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Using conexao As SqlConnection = Database.GetConnection()

            Try

                conexao.Open()

                MessageBox.Show("Conectado com sucesso!")

            Catch ex As Exception

                MessageBox.Show("Erro: " & ex.Message)

            End Try

        End Using
    End Sub
End Class