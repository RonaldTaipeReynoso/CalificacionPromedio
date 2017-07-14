Public Class Form1
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Double
        Dim n1, n2, n3, n4, ef As Double
        Dim co As Color
        Dim situ As String

        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text

        a = n1 * 0.2
        b = n2 * 0.2
        c = n3 * 0.2
        d = n4 * 0.4
        ef = n1 * 0.2 + n2 * 0.2 + n3 * 0.2 + n4 * 0.4

        If ef >= 10.5 Then
            situ = "APROBADO"
            TextBox10.ForeColor = Color.Blue
            co = Color.Blue
        Else
            situ = "DESAPROBADO"
            TextBox10.ForeColor = Color.Red
            co = Color.Red
        End If

        TextBox5.Text = a
        TextBox6.Text = b
        TextBox7.Text = c
        TextBox8.Text = d
        TextBox9.Text = ef
        TextBox9.ForeColor = co
        TextBox10.Text = situ







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
