Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim progressValue As Integer = 0
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    ' Reset login form
    Public Sub ResetLoginForm()
        tmrlogin.Stop()
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub

    ' Form load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False

        ' Make Label2 clickable like a hyperlink
        Label2.Cursor = Cursors.Hand
        Label2.ForeColor = Color.Blue
        Label2.Font = New Font(Label2.Font, FontStyle.Underline)
    End Sub

    ' Login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please enter username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Open database connection
            Call Connection.koneksyon()

            ' Check if user exists and get current attempts and status
            Dim sqlCheck As String = "SELECT ID, Fullname, Role, Attempts, Status, Password FROM users WHERE username=@user"
            cmd = New MySqlCommand(sqlCheck, Connection.cn)
            cmd.Parameters.AddWithValue("@user", txtusername.Text)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim userID As Integer = Convert.ToInt32(dr("ID"))
                Dim fullname As String = dr("Fullname").ToString()
                Dim role As String = dr("Role").ToString()
                Dim attempts As Integer = Convert.ToInt32(dr("Attempts"))
                Dim status As String = dr("Status").ToString()
                Dim correctPassword As String = dr("Password").ToString()

                dr.Close() ' Close reader before updating

                ' Check if account is deactivated
                If status.ToLower() = "deactivated" Then
                    MessageBox.Show("This account is deactivated. Please contact administrator.", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Check password
                If txtpassword.Text = correctPassword Then
                    ' Successful login
                    Connection.LoggedInUser = fullname
                    Connection.LoggedInRole = role

                    ' Reset attempts to 3 if it is less than 3
                    If attempts < 3 Then
                        Dim sqlResetAttempts As String = "UPDATE users SET Attempts=3 WHERE ID=@id"
                        cmd = New MySqlCommand(sqlResetAttempts, Connection.cn)
                        cmd.Parameters.AddWithValue("@id", userID)
                        cmd.ExecuteNonQuery()
                    End If

                    ProgressBar1.Visible = True
                    progressValue = 0
                    tmrlogin.Start()
                Else
                    ' Wrong password
                    attempts -= 1
                    Dim newStatus As String = If(attempts <= 0, "Deactivated", status)

                    ' Update attempts and possibly status in DB
                    Dim sqlUpdate As String = "UPDATE users SET Attempts=@attempts, Status=@status WHERE ID=@id"
                    cmd = New MySqlCommand(sqlUpdate, Connection.cn)
                    cmd.Parameters.AddWithValue("@attempts", attempts)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@id", userID)
                    cmd.ExecuteNonQuery()

                    If attempts <= 0 Then
                        MessageBox.Show("Wrong password. Your account is now deactivated.", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Wrong password. Attempts remaining: " & attempts, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    ResetLoginForm()
                End If

            Else
                MessageBox.Show("Invalid username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ResetLoginForm()
            End If

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            If Connection.cn IsNot Nothing AndAlso Connection.cn.State = ConnectionState.Open Then Connection.cn.Close()
        End Try
    End Sub

    ' Timer tick for progress bar
    Private Sub tmrlogin_Tick(sender As Object, e As EventArgs) Handles tmrlogin.Tick
        progressValue += 5
        ProgressBar1.Value = progressValue

        If progressValue >= 100 Then
            tmrlogin.Stop()
            MessageBox.Show("Welcome " & Connection.LoggedInUser & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open dashboard
            Dim dash As New Dashboard()
            dash.Show()
            Me.Hide()
        End If
    End Sub

    ' Label2 click to close form
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
