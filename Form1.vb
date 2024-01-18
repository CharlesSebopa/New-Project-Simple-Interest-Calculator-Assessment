Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PrincipalAmount As Decimal
        Dim RateofInterest As Decimal
        Dim NumberofYears As Decimal
        Dim SimpleInterest As Decimal = 0

        PrincipalAmount = Val(TextBox1.Text)
        RateofInterest = Val(TextBox2.Text)
        NumberofYears = Val(TextBox3.Text)

        SimpleInterest = (PrincipalAmount * RateofInterest * NumberofYears) / 100
        Label6.Text = SimpleInterest.ToString()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label6.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
