Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text >= 2000000 Then
            TextBox4.Text = "Diskon 20%"
        ElseIf TextBox3.Text >= 1000000 Then
            TextBox4.Text = "Diskon 10%"
        Else
            TextBox4.Text = "Tidak Ada Diskon"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text = "Diskon 10%" Then
            TextBox5.Text = Val(TextBox3.Text) * 10 / 100
        ElseIf TextBox4.Text = "Diskon 20%" Then
            TextBox5.Text = Val(TextBox3.Text) * 20 / 100
        Else
            TextBox5.Text = "0"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox6.Text = Val(TextBox3.Text) - Val(TextBox5.Text)
    End Sub
End Class
