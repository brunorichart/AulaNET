Public Class frmForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim StrName As String = txtName.Text
        Dim StrEmail As String = txtEmail.Text
        Dim StrPhone As String = txtPhone.Text


        MessageBox.Show("Nome: " & StrName & vbCrLf &
                        "Email: " & StrEmail & vbCrLf &
                        "Telefone: " & StrPhone, "Informações do Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class