Imports MySql.Data.MySqlClient

Public Class RequestForm

    ' === Load Event ===
    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Safe date initialization
            dtpDate.MinDate = New DateTime(2000, 1, 1)
            dtpDate.MaxDate = Date.Today
            dtpDate.Value = Date.Today
            dtpDate.Enabled = False

            ' Load certificate types
            LoadCertificateTypes()

            ' Load residents for autocomplete
            LoadResidentAutoComplete()

        Catch ex As Exception
            MessageBox.Show("Error initializing form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' === Load Certificate Types ===
    Private Sub LoadCertificateTypes()
        cmbcertificateType.Items.Clear()
        cmbcertificateType.Items.Add("Barangay Clearance (Personal)")
        cmbcertificateType.Items.Add("Barangay Clearance (Business)")
        cmbcertificateType.Items.Add("Barangay Clearance (First Job)")
        cmbcertificateType.Items.Add("Residency Certificate")
        cmbcertificateType.Items.Add("Indigency Certificate")
        cmbcertificateType.Items.Add("Good Moral Certificate")
        cmbcertificateType.Items.Add("Community Tax Certificate (Cedula)")
        cmbcertificateType.Items.Add("Senior Citizen/PWD Certificate")
        cmbcertificateType.Items.Add("Solo Parent Certificate")
        cmbcertificateType.Items.Add("Certificate of Occupancy / Lot Clearance")
        cmbcertificateType.Items.Add("Certificate of Barangay Employment")
    End Sub

    ' === Auto-Fill Fee Based on Type ===
    Private Sub cmbCertificateType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcertificateType.SelectedIndexChanged
        Dim selectedType As String = cmbcertificateType.Text
        Select Case selectedType
            Case "Barangay Clearance (Personal)"
                txtfee.Text = "50"
            Case "Barangay Clearance (Business)"
                txtfee.Text = "500"
            Case "Barangay Clearance (First Job)"
                txtfee.Text = "0"  ' Free for first-time
            Case "Residency Certificate"
                txtfee.Text = "50"
            Case "Indigency Certificate"
                txtfee.Text = "100"
            Case "Good Moral Certificate"
                txtfee.Text = "25"
            Case "Community Tax Certificate (Cedula)"
                txtfee.Text = "10"
            Case "Senior Citizen/PWD Certificate"
                txtfee.Text = "0"
            Case "Solo Parent Certificate"
                txtfee.Text = "0"
            Case "Certificate of Occupancy / Lot Clearance"
                txtfee.Text = "150"
            Case "Certificate of Barangay Employment"
                txtfee.Text = "50"
            Case Else
                txtfee.Text = ""
        End Select
    End Sub

    ' === Load Residents Autocomplete ===
    Private Sub LoadResidentAutoComplete()
        Try
            koneksyon()
            Dim query As String = "SELECT CONCAT(First_Name,' ',Last_Name) AS FullName FROM residents"
            cmd = New MySqlCommand(query, cn)
            Dim reader = cmd.ExecuteReader()
            Dim names As New AutoCompleteStringCollection()
            While reader.Read()
                names.Add(reader("FullName").ToString())
            End While
            reader.Close()

            txtresidentname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtresidentname.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtresidentname.AutoCompleteCustomSource = names

        Catch ex As Exception
            MessageBox.Show("Error loading residents: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' === Get Resident_ID from Name ===
    Private Function GetResidentID(fullName As String) As Integer
        Try
            Dim parts() As String = fullName.Trim().Split(" "c)
            If parts.Length < 2 Then Return 0
            Dim firstName As String = parts(0)
            Dim lastName As String = String.Join(" ", parts.Skip(1))

            koneksyon()
            Dim query As String = "SELECT Resident_ID FROM residents WHERE First_Name=@First AND Last_Name=@Last LIMIT 1"
            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@First", firstName)
            cmd.Parameters.AddWithValue("@Last", lastName)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then Return Convert.ToInt32(result)
            Return 0
        Catch ex As Exception
            MessageBox.Show("Error fetching resident ID: " & ex.Message)
            Return 0
        Finally
            cn.Close()
        End Try
    End Function

    ' === Submit Request ===
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtresidentname.Text.Trim() = "" Or cmbcertificateType.Text.Trim() = "" Or txtPurpose.Text.Trim() = "" Then
            MessageBox.Show("Please complete all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim residentID As Integer = GetResidentID(txtresidentname.Text.Trim())
        If residentID = 0 Then
            MessageBox.Show("Resident not found. Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Define limits / expiration rules
        Dim certificateRules As New Dictionary(Of String, Integer?) From {
            {"Barangay Clearance (Personal)", 6},
            {"Barangay Clearance (Business)", 6},
            {"Barangay Clearance (First Job)", Nothing}, ' First-time only
            {"Residency Certificate", 6},
            {"Indigency Certificate", 6},
            {"Good Moral Certificate", Nothing},
            {"Community Tax Certificate (Cedula)", Nothing}
        }

        Try
            koneksyon()

            ' First-time job seeker logic
            If cmbcertificateType.Text = "Barangay Clearance (First Job)" Then
                Dim checkQuery As String =
                    "SELECT COUNT(*) FROM request_form WHERE Resident_ID=@Resident_ID AND Request_Type='Barangay Clearance (First Job)'"
                cmd = New MySqlCommand(checkQuery, cn)
                cmd.Parameters.AddWithValue("@Resident_ID", residentID)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("First Job Clearance is only free for first-time applicants.", "Request Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            ' Expiring certificate validation
            If certificateRules.ContainsKey(cmbcertificateType.Text) AndAlso certificateRules(cmbcertificateType.Text).HasValue Then
                Dim months As Integer = certificateRules(cmbcertificateType.Text).Value
                Dim checkQuery As String =
                    "SELECT COUNT(*) FROM request_form " &
                    "WHERE Resident_ID=@Resident_ID AND Request_Type=@Request_Type " &
                    "AND Date_Requested >= DATE_SUB(CURDATE(), INTERVAL @Months MONTH)"
                cmd = New MySqlCommand(checkQuery, cn)
                cmd.Parameters.AddWithValue("@Resident_ID", residentID)
                cmd.Parameters.AddWithValue("@Request_Type", cmbcertificateType.Text)
                cmd.Parameters.AddWithValue("@Months", months)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show($"You have already requested this certificate in the past {months} month(s). Please wait until it expires.", "Request Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            ' Insert request
            Dim insertQuery As String =
                "INSERT INTO request_form (Resident_ID, Request_Type, Purpose, Date_Requested, Status) " &
                "VALUES (@Resident_ID, @Request_Type, @Purpose, @Date_Requested, 'Pending')"
            cmd = New MySqlCommand(insertQuery, cn)
            cmd.Parameters.AddWithValue("@Resident_ID", residentID)
            cmd.Parameters.AddWithValue("@Request_Type", cmbcertificateType.Text)
            cmd.Parameters.AddWithValue("@Purpose", txtPurpose.Text)
            cmd.Parameters.AddWithValue("@Date_Requested", Date.Today)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Certificate request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields
            txtresidentname.Clear()
            cmbcertificateType.SelectedIndex = -1
            txtPurpose.Clear()
            txtfee.Clear()

        Catch ex As Exception
            MessageBox.Show("Error submitting request: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

End Class
