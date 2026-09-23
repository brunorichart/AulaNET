Public Class frmCalc
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button1.Click,
        Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click,
        Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click

        Dim button As Button = CType(sender, Button)
        TextBox1.Text &= button.Text

    End Sub
End Class