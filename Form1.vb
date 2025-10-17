Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MessageBox.Show("Logging you in, please wait...", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Threading.Thread.Sleep(2000)
        MessageBox.Show("Login successful!", "Welcome")
    End Sub

End Class
