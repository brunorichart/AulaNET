Imports Microsoft.Data.SqlClient

Public Class frmForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim StrName As String = txtName.Text
        Dim StrEmail As String = txtEmail.Text
        Dim StrPhone As String = txtPhone.Text


        ' MessageBox.Show("Nome: " & StrName & vbCrLf &
        ' "Email: " & StrEmail & vbCrLf &
        ' "Telefone: " & StrPhone, "Informações do Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Validação aqui
        If StrName = "" AndAlso StrEmail = "" AndAlso StrPhone = "" Then
            MessageBox.Show("Por favor, preencha todos os campos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sql As String = "INSERT INTO dbo.Cadastro (name, email, phone)" &
            "VALUES (@name, @email, @phone)"

        Using conexao As SqlConnection = Database.GetConnection()

            Using comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add("@name", SqlDbType.VarChar).Value = StrName
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = StrEmail
                comando.Parameters.Add("@phone", SqlDbType.VarChar).Value = StrPhone

                Try

                    conexao.Open()

                    comando.ExecuteNonQuery()

                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception

                    MessageBox.Show("Erro ao cadastrar: " & ex.Message)

                End Try

            End Using

        End Using
    End Sub
End Class