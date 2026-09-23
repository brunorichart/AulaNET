Public Class frmSelect
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lbSelected.Items.Add(lbSelect.SelectedItem)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If lbSelected.SelectedItem IsNot Nothing Then
            lbSelected.Items.Remove(lbSelected.SelectedItem)
        End If
    End Sub

    REM Esse também é um comentário, mas com a palavra reservada REM
    Private Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim v1 As Integer = 10
        Dim v2 As Integer = 5
        Dim Result As Integer

        Result = v1 + v2
        lblSoma.Text = "Resultado: " & Result.ToString()

    End Sub
End Class