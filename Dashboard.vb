Imports System.Windows.Forms
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UpdateGreetingAndTime()

        ' Load default form (Residents)
        LoadFormIntoPanel(New frmresidents())

        ' ✅ Set button access based on role
        SetButtonAccess()
    End Sub

    ' ===============================
    ' TIME + GREETING
    ' ===============================
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

    ' ===============================
    ' LOAD FORM INTO PANEL
    ' ===============================
    Private Sub LoadFormIntoPanel(form As Form)
        PanelMain.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        PanelMain.Controls.Add(form)
        form.Show()
    End Sub

    ' ===============================
    ' DASHBOARD BUTTONS
    ' ===============================
    Private Sub btnresidents_Click(sender As Object, e As EventArgs) Handles btnresidents.Click
        LoadFormIntoPanel(New frmresidents())
    End Sub

    Private Sub btncomplaints_Click(sender As Object, e As EventArgs) Handles btncomplaints.Click
        LoadFormIntoPanel(New frmcomplaints())
    End Sub

    Private Sub btnincidents_Click(sender As Object, e As EventArgs) Handles btnincidents.Click
        LoadFormIntoPanel(New frmincident())
    End Sub

    Private Sub btnblotter_Click(sender As Object, e As EventArgs) Handles btnblotter.Click
        LoadFormIntoPanel(New frmblotter())
    End Sub

    Private Sub btncertifications_Click(sender As Object, e As EventArgs) Handles btncertifications.Click
        LoadFormIntoPanel(New frmcertificates())
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        LoadFormIntoPanel(New RequestForm())
    End Sub

    Private Sub btnpayment_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        LoadFormIntoPanel(New Payment())
    End Sub

    Private Sub btnsummary_Click(sender As Object, e As EventArgs) Handles btnsummary.Click
        LoadFormIntoPanel(New frmSummary())
    End Sub

    Private Sub btnofficials_Click(sender As Object, e As EventArgs) Handles btnofficials.Click
        LoadFormIntoPanel(New frmOfficials())
    End Sub

    Private Sub btnusers_Click(sender As Object, e As EventArgs) Handles btnusers.Click
        LoadFormIntoPanel(New frmUsers())
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Form1.ResetLoginForm()
            Form1.Show()
        End If
    End Sub

    ' ===============================
    ' ROLE-BASED BUTTON ACCESS (Fixed for DB roles)
    ' ===============================
    Private Sub SetButtonAccess()
        Dim role As String = Connection.LoggedInRole.Trim().ToLower()

        Select Case role
            Case "admin"
                EnableAllButtons(True)

            Case "barangay official"
                btnresidents.Enabled = True
                btncomplaints.Enabled = False
                btnincidents.Enabled = False
                btnblotter.Enabled = False
                btncertifications.Enabled = False
                btnRequest.Enabled = False
                btnpayment.Enabled = False
                btnsummary.Enabled = True
                btnofficials.Enabled = False
                btnusers.Enabled = False
                btnlogout.Enabled = True

            Case "staff"
                btnresidents.Enabled = True
                btncomplaints.Enabled = True
                btnincidents.Enabled = True
                btnblotter.Enabled = True
                btncertifications.Enabled = True
                btnRequest.Enabled = True
                btnpayment.Enabled = True
                btnsummary.Enabled = False
                btnofficials.Enabled = False
                btnusers.Enabled = False
                btnlogout.Enabled = True

            Case Else
                EnableAllButtons(False)
                btnlogout.Enabled = True
        End Select
    End Sub

    Private Sub EnableAllButtons(status As Boolean)
        btnresidents.Enabled = status
        btncomplaints.Enabled = status
        btnincidents.Enabled = status
        btnblotter.Enabled = status
        btncertifications.Enabled = status
        btnRequest.Enabled = status
        btnpayment.Enabled = status
        btnsummary.Enabled = status
        btnofficials.Enabled = status
        btnusers.Enabled = status
        btnlogout.Enabled = True
    End Sub
End Class
