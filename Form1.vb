Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim progressValue As Integer = 0
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Public Sub ResetLoginForm()
        tmrlogin.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please enter username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Open database connection
            Call Connection.koneksyon()

            Dim sql As String = "SELECT fullname, role FROM users WHERE username=@user AND password=@pass"
            cmd = New MySqlCommand(sql, Connection.cn)
            cmd.Parameters.AddWithValue("@user", txtusername.Text)
            cmd.Parameters.AddWithValue("@pass", txtpassword.Text)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' ✅ Assign to global variables
                Connection.LoggedInUser = dr("fullname").ToString()
                Connection.LoggedInRole = dr("role").ToString()

                ProgressBar1.Visible = True
                progressValue = 0
                tmrlogin.Start()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            If Connection.cn IsNot Nothing AndAlso Connection.cn.State = ConnectionState.Open Then Connection.cn.Close()
        End Try
    End Sub

    Private Sub tmrlogin_Tick(sender As Object, e As EventArgs) Handles tmrlogin.Tick
        progressValue += 5
        ProgressBar1.Value = progressValue

        If progressValue >= 100 Then
            tmrlogin.Stop()
            MessageBox.Show("Welcome " & Connection.LoggedInUser & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ✅ Properly create a new dashboard instance
            Dim dash As New Dashboard()
            dash.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class
