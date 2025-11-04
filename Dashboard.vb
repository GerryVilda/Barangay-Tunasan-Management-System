Imports System.Windows.Forms
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UpdateGreetingAndTime()
        ' Load default form (e.g., Residents)
        LoadFormIntoPanel(New frmResidents())
    End Sub

    ' ✅ Time + Greeting
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateGreetingAndTime()
    End Sub

    Private Sub UpdateGreetingAndTime()
        lbldate.Text = Date.Now.ToString("dddd, MMM dd, yyyy")
        lbltime.Text = Date.Now.ToString("hh:mm:ss tt")

        Dim hour As Integer = Date.Now.Hour
        If hour >= 5 And hour < 12 Then
            lblgreet.Text = "Good Morning"
        ElseIf hour >= 12 And hour < 18 Then
            lblgreet.Text = "Good Afternoon"
        Else
            lblgreet.Text = "Good Evening"
        End If
    End Sub

    ' ✅ Function to load forms into the main panel
    Private Sub LoadFormIntoPanel(form As Form)
        PanelMain.Controls.Clear() ' Remove current form
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        PanelMain.Controls.Add(form)
        form.Show()
    End Sub

    ' ==============================
    ' DASHBOARD BUTTONS
    ' ==============================

    ' 👨‍👩‍👧‍👦 Residents
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnresidents.Click
        LoadFormIntoPanel(New frmresidents)
    End Sub

    ' 💬 Complaints
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncomplaints.Click
        LoadFormIntoPanel(New frmComplaints())
    End Sub

    ' 🧾 Blotter
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnincidents.Click
        LoadFormIntoPanel(New frmincident())
    End Sub

    ' ⚠️ Incident Reports
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnblotter.Click
        LoadFormIntoPanel(New frmblotter())
    End Sub

    ' 👴 Senior Records
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btncertifications.Click
        LoadFormIntoPanel(New frmcertificates())
    End Sub

    ' 📍 Sitio Problems
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnsummary.Click
        LoadFormIntoPanel(New frmSummary())
    End Sub

    ' 📊 Reports Summary
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnsito.Click
        LoadFormIntoPanel(New frmSitio())
    End Sub

    ' 🧑‍💼 Officials
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnofficials.Click
        LoadFormIntoPanel(New frmOfficials())
    End Sub

    ' 🔑 Users
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnusers.Click
        LoadFormIntoPanel(New frmUsers())
    End Sub

    ' 🚪 Logout / Exit
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' ✅ Close the dashboard
            Me.Hide()

            ' ✅ Reset login form (Form1)
            Form1.ResetLoginForm()
            Form1.Show()
        End If
    End Sub
End Class