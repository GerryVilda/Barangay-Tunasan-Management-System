Imports System.Windows.Forms
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UpdateGreetingAndTime()

        ' Load default form (Residents)
        LoadFormIntoPanel(New frmresidents())

        ' Set button access and layout
        SetButtonAccess()

        ' Set current logged-in user label
        UpdateLoggedInUser()
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
        If hour >= 5 AndAlso hour < 12 Then
            lblgreet.Text = "Good Morning"
        ElseIf hour >= 12 AndAlso hour < 18 Then
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
    ' DASHBOARD BUTTONS EVENTS
    ' ===============================
    Private Sub btnresidents_Click(sender As Object, e As EventArgs) Handles btnresidents.Click
        LoadFormIntoPanel(New frmresidents())
    End Sub

    Private Sub btncomplaints_Click(sender As Object, e As EventArgs) Handles btncomplaints.Click
        LoadFormIntoPanel(New frmcomplaints())
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
    ' ROLE-BASED BUTTON VISIBILITY AND SPACING
    ' ===============================
    Private Sub SetButtonAccess()
        Dim role As String = Connection.LoggedInRole.Trim().ToLower()

        ' List all buttons in the order they should appear
        Dim allButtons As New List(Of Button) From {
            btnresidents, btncomplaints, btnblotter,
            btncertifications, btnRequest, btnpayment, btnsummary,
            btnofficials, btnusers, btnlogout
        }

        ' First hide all (except logout)
        For Each btn In allButtons
            btn.Visible = False
        Next
        btnlogout.Visible = True ' logout always visible

        ' Make buttons visible based on role
        Select Case role
            Case "admin"
                btnresidents.Visible = True
                btncomplaints.Visible = True
                btnblotter.Visible = True
                btncertifications.Visible = True
                btnRequest.Visible = True
                btnpayment.Visible = True
                btnsummary.Visible = True
                btnofficials.Visible = True
                btnusers.Visible = True

            Case "barangay official"
                btnresidents.Visible = True
                btnsummary.Visible = True

            Case "staff"
                btnresidents.Visible = True
                btncomplaints.Visible = True
                btnblotter.Visible = True
                btncertifications.Visible = True
                btnRequest.Visible = True
                btnpayment.Visible = True

            Case Else
                ' maybe minimal or default
                btnresidents.Visible = True
        End Select

        ' Dynamically reposition visible buttons vertically
        Dim sidebar As Panel = Panel1   ' Use the panel that holds the logo + buttons
        Dim topPosition As Integer = PictureBox1.Bottom + 20
        topPosition = Math.Max(topPosition, lblgreet.Bottom + 10)
        topPosition = Math.Max(topPosition, lbldate.Bottom + 5)
        topPosition = Math.Max(topPosition, lbltime.Bottom + 5)

        Dim spacing As Integer = 10 ' space between buttons
        Dim leftMargin As Integer = 5
        Dim rightMargin As Integer = 5

        For Each btn In allButtons
            If btn.Visible Then
                btn.Top = topPosition
                btn.Left = leftMargin
                btn.Width = sidebar.ClientSize.Width - (leftMargin + rightMargin)
                btn.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                topPosition += btn.Height + spacing
            End If
        Next
    End Sub

    ' ===============================
    ' SET LOGGED-IN USER LABEL
    ' ===============================
    ' ===============================
    ' SET LOGGED-IN USER LABEL
    ' ===============================
    Private Sub UpdateLoggedInUser()
        ' Make sure you set these values at login
        Dim name As String = Connection.LoggedInUser
        Dim role As String = Connection.LoggedInRole

        If String.IsNullOrEmpty(name) Then
            lblfullname.Text = "Welcome, Guest"
            Return
        End If

        ' Capitalize the first letter of each word in role
        Dim displayRole As String = If(String.IsNullOrEmpty(role), "User", System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(role.ToLower()))

        ' Optional: Replace internal role strings with nicer display
        Select Case role.Trim().ToLower()
            Case "barangay official"
                displayRole = "Barangay Official"
            Case "admin"
                displayRole = "Administrator"
            Case "staff"
                displayRole = "Staff"
            Case Else
                displayRole = displayRole ' use as-is
        End Select

        lblfullname.Text = $"Welcome, {name} ({displayRole})"
    End Sub


    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint
        ' Optional custom painting
    End Sub

    Private Sub lblfullname_Click(sender As Object, e As EventArgs) Handles lblfullname.Click
        ' Optional click event
    End Sub
End Class
