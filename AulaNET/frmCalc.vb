Public Class frmCalc
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button5.Click, Button6.Click,
        Button7.Click, Button9.Click, Button10.Click, Button11.Click, Button13.Click,
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

    Private Sub Button2_Decimal(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text &= "0."
        ElseIf Not TextBox1.Text.Contains(".") Then
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub Button3_Clear(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = String.Empty
    End Sub

    Private Sub Operators(sender As Object, e As EventArgs) Handles Button4.Click, Button8.Click, Button12.Click, Button16.Click

        TextBox1.Text &= " " & CType(sender, Button).Text
    End Sub

    Private Sub EqualsClick(sender As Object, e As EventArgs) Handles Button17.Click
        Dim expression As String = TextBox1.Text
        Dim result As Object
        Dim table As New DataTable
        result = table.Compute(expression, String.Empty)
        TextBox1.Text = result.ToString
    End Sub
End Class