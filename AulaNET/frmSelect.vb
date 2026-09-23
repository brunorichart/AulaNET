Public Class frmSelect
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lbSelected.Items.Add(lbSelect.SelectedItem)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If lbSelected.SelectedItem IsNot Nothing Then
            lbSelected.Items.Remove(lbSelected.SelectedItem)
        End If
    End Sub
End Class