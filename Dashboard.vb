Imports System.Windows.Forms
Imports System.Timers
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UpdateGreetingAndTime()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateGreetingAndTime()
    End Sub

    Private Sub UpdateGreetingAndTime()
        ' 🕒 Show current date and time
        lbldate.Text = Date.Now.ToString("dddd, MMM dd, yyyy")
        lbltime.Text = Date.Now.ToString("hh:mm:ss tt")

        ' 👋 Dynamic greeting based on time
        Dim hour As Integer = Date.Now.Hour
        If hour >= 5 And hour < 12 Then
            lblgreet.Text = "Good Morning"
        ElseIf hour >= 12 And hour < 18 Then
            lblgreet.Text = "Good Afternoon"
        Else
            lblgreet.Text = "Good Evening"
        End If
    End Sub

End Class