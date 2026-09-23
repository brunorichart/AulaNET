Public Class frmCalc
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button5.Click, Button6.Click,
        Button7.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click,
        Button14.Click, Button15.Click

        Dim button As Button = CType(sender, Button)
        TextBox1.Text &= button.Text

        ' 5,6,7,9,10,11,13,14,15

    End Sub

    Private Sub Button1_Zero(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub
End Class