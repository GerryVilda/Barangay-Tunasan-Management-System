Imports MySql.Data.MySqlClient

Public Class frmComplaints

    '=== Load Event ===
    Private Sub frmComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()
        LoadComplaints()
        LoadResolvedComplaints()

        ' Restrict complaint date to today or past
        dtpComplaintDate.MaxDate = Date.Today
        dtpComplaintDate.Enabled = False ' <-- Make it read-only

        ' Fill status combobox
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Resolved")
        cmbStatus.SelectedIndex = 0

        ' Make ID textboxes readonly
        txtComplaintID.ReadOnly = True
        txtResidentID.ReadOnly = True

        ' DataGridView settings
        dgvComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvComplaints.MultiSelect = False
        dgvResolved.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResolved.MultiSelect = False

        ' Initially disable blotter button if nothing is selected
        btnBlotter.Enabled = False
    End Sub

    '=== Load Pending Complaints ===
    Private Sub LoadComplaints()
        Try
            Call koneksyon()
            Dim query As String = "SELECT Complaint_ID, Complainant_ID, Complainant_Name, Respondent_ID, Respondent_Name, Complaint_Subject, Complaint_Details, Location, Incident_Description, Complaint_Date, Status, Action_Taken FROM complaints WHERE Status = 'Pending'"
            Dim adapter As New MySqlDataAdapter(query, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvComplaints.DataSource = dt

            dgvComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvComplaints.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvComplaints.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgvComplaints.ScrollBars = ScrollBars.Both

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Load Resolved Complaints ===
    Private Sub LoadResolvedComplaints()
        Try
            Call koneksyon()
            Dim query As String = "SELECT Complaint_ID, Complainant_ID, Complainant_Name, Respondent_ID, Respondent_Name, Complaint_Subject, Complaint_Details, Location, Incident_Description, Complaint_Date, Status, Action_Taken FROM complaints WHERE Status = 'Resolved'"
            Dim adapter As New MySqlDataAdapter(query, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvResolved.DataSource = dt

            dgvResolved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvResolved.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvResolved.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvResolved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgvResolved.ScrollBars = ScrollBars.Both

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Get Resident ID by Name ===
    Private Function GetResidentIDByName(name As String) As Integer?
        Try
            Call koneksyon()
            Dim query As String = "SELECT Resident_ID FROM residents WHERE CONCAT(First_Name, ' ', Last_Name) = @name LIMIT 1"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@name", name)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    '=== Add New Complaint ===
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Call koneksyon()
            Dim query As String = "INSERT INTO complaints (Complainant_ID, Complainant_Name, Respondent_ID, Respondent_Name, Complaint_Subject, Complaint_Details, Location, Incident_Description, Complaint_Date, Status, Action_Taken) " &
                                  "VALUES (@cid, @cname, @rid, @rname, @subject, @details, @location, @incident_desc, @date, 'Pending', @action)"
            Dim cmd As New MySqlCommand(query, cn)

            ' Complainant
            Dim complainantID As Integer? = GetResidentIDByName(txtcomplaintname.Text)
            If complainantID.HasValue Then
                cmd.Parameters.AddWithValue("@cid", complainantID.Value)
            Else
                MessageBox.Show("Invalid complainant name. Please select a valid resident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@cname", txtcomplaintname.Text)

            ' Respondent (optional)
            Dim respondentID As Integer? = Nothing
            If Not String.IsNullOrWhiteSpace(txtrespondentname.Text) Then
                respondentID = GetResidentIDByName(txtrespondentname.Text)
                If respondentID.HasValue Then
                    cmd.Parameters.AddWithValue("@rid", respondentID.Value)
                    cmd.Parameters.AddWithValue("@rname", txtrespondentname.Text)
                Else
                    MessageBox.Show("Invalid respondent name. Please select a valid resident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                cmd.Parameters.AddWithValue("@rid", DBNull.Value)
                cmd.Parameters.AddWithValue("@rname", DBNull.Value)
            End If

            ' Other fields
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@details", txtDetails.Text)
            cmd.Parameters.AddWithValue("@location", txtLocation.Text)
            cmd.Parameters.AddWithValue("@incident_desc", txtIncidentDescription.Text)
            cmd.Parameters.AddWithValue("@date", dtpComplaintDate.Value)
            cmd.Parameters.AddWithValue("@action", txtActionTaken.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Complaint successfully recorded.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadComplaints()
            ClearInputs()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Mark Complaint as Resolved ===
    Private Sub btnResolved_Click(sender As Object, e As EventArgs) Handles btnResolved.Click
        Try
            If dgvComplaints.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a complaint to mark as resolved.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim complaintID As Integer = dgvComplaints.SelectedRows(0).Cells("Complaint_ID").Value
            Call koneksyon()

            Dim query As String = "UPDATE complaints SET Status='Resolved', Action_Taken=@action WHERE Complaint_ID=@id"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@id", complaintID)
            cmd.Parameters.AddWithValue("@action", txtActionTaken.Text.Trim())
            cmd.ExecuteNonQuery()

            MessageBox.Show("Complaint marked as resolved.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadComplaints()
            LoadResolvedComplaints()
            ClearInputs()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Check if selected complaint is resolved ===
    Private Function IsSelectedComplaintResolved() As Boolean
        If dgvComplaints.SelectedRows.Count > 0 Then
            Dim status = dgvComplaints.SelectedRows(0).Cells("Status").Value
            If status IsNot Nothing AndAlso status.ToString() = "Resolved" Then
                Return True
            End If
        End If
        Return False
    End Function

    '=== File Complaint to Blotter ===
    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Try
            If dgvComplaints.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a complaint to file as blotter.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If IsSelectedComplaintResolved() Then
                MessageBox.Show("Resolved complaints cannot be filed to the blotter.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim row As DataGridViewRow = dgvComplaints.SelectedRows(0)
            Call koneksyon()

            Dim query As String = "INSERT INTO blotter_reports (Complaint_ID, Complainant_ID, Respondent_ID, Incident_Type, Incident_Date, Location, Details, Status, Remarks, Created_At) " &
                                  "VALUES (@complaintid, @cid, @rid, @type, @date, @location, @details, 'Pending', '', NOW())"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@complaintid", row.Cells("Complaint_ID").Value)
            cmd.Parameters.AddWithValue("@cid", row.Cells("Complainant_ID").Value)
            cmd.Parameters.AddWithValue("@rid", If(row.Cells("Respondent_ID").Value IsNot Nothing, row.Cells("Respondent_ID").Value, DBNull.Value))
            cmd.Parameters.AddWithValue("@type", row.Cells("Complaint_Subject").Value)
            cmd.Parameters.AddWithValue("@date", row.Cells("Complaint_Date").Value)
            cmd.Parameters.AddWithValue("@location", row.Cells("Location").Value)
            cmd.Parameters.AddWithValue("@details", row.Cells("Incident_Description").Value)
            cmd.ExecuteNonQuery()

            ' Remove from pending complaints
            Dim deleteQuery As String = "DELETE FROM complaints WHERE Complaint_ID=@id"
            Dim deleteCmd As New MySqlCommand(deleteQuery, cn)
            deleteCmd.Parameters.AddWithValue("@id", row.Cells("Complaint_ID").Value)
            deleteCmd.ExecuteNonQuery()

            MessageBox.Show("Complaint successfully filed to Blotter.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadComplaints()
            LoadResolvedComplaints()
            ClearInputs()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Fill textboxes when a row is clicked ===
    Private Sub dgvComplaints_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComplaints.CellClick
        If e.RowIndex >= 0 Then
            FillTextboxes(dgvComplaints.Rows(e.RowIndex))

            ' Disable blotter button if resolved
            btnBlotter.Enabled = Not IsSelectedComplaintResolved()
            btnupdate.Enabled = Not IsSelectedComplaintResolved()
        End If
    End Sub

    Private Sub dgvResolved_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResolved.CellClick
        If e.RowIndex >= 0 Then
            FillTextboxes(dgvResolved.Rows(e.RowIndex))

            ' Always disable blotter button for resolved complaints
            btnBlotter.Enabled = False
            btnupdate.Enabled = False
        End If
    End Sub

    '=== Fill textboxes safely ===
    Private Sub FillTextboxes(row As DataGridViewRow)
        Dim SafeValue As Func(Of String, String) = Function(columnName)
                                                       If row.DataGridView.Columns.Contains(columnName) Then
                                                           Dim cellValue = row.Cells(columnName).Value
                                                           If cellValue IsNot Nothing Then
                                                               Return cellValue.ToString()
                                                           End If
                                                       End If
                                                       Return ""
                                                   End Function

        txtComplaintID.Text = SafeValue("Complaint_ID")
        txtcomplaintname.Text = SafeValue("Complainant_Name")
        txtResidentID.Text = SafeValue("Respondent_ID")
        txtrespondentname.Text = SafeValue("Respondent_Name")
        txtSubject.Text = SafeValue("Complaint_Subject")
        txtDetails.Text = SafeValue("Complaint_Details")
        txtLocation.Text = SafeValue("Location")
        txtIncidentDescription.Text = SafeValue("Incident_Description")
        txtActionTaken.Text = SafeValue("Action_Taken")

        Dim statusText = SafeValue("Status")
        If Not String.IsNullOrEmpty(statusText) AndAlso cmbStatus.Items.Contains(statusText) Then
            cmbStatus.SelectedItem = statusText
        Else
            cmbStatus.SelectedIndex = 0
        End If

        Dim dateText = SafeValue("Complaint_Date")
        Dim dt As Date
        If Date.TryParse(dateText, dt) Then
            dtpComplaintDate.Value = dt
        Else
            dtpComplaintDate.Value = Date.Today
        End If
    End Sub

    '=== Clear inputs ===
    Private Sub ClearInputs()
        txtComplaintID.Clear()
        txtcomplaintname.Clear()
        txtResidentID.Clear()
        txtrespondentname.Clear()
        txtSubject.Clear()
        txtDetails.Clear()
        txtLocation.Clear()
        txtIncidentDescription.Clear()
        txtActionTaken.Clear()
        cmbStatus.SelectedIndex = 0
        dtpComplaintDate.Value = Date.Today
        btnBlotter.Enabled = False
    End Sub

    '=== Update Complaint ===
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtComplaintID.Text) Then
                MessageBox.Show("Please select a complaint to update.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Call koneksyon()

            Dim query As String = "UPDATE complaints SET " &
                                  "Complainant_ID=@cid, Complainant_Name=@cname, " &
                                  "Respondent_ID=@rid, Respondent_Name=@rname, " &
                                  "Complaint_Subject=@subject, Complaint_Details=@details, " &
                                  "Location=@location, Incident_Description=@incident_desc, " &
                                  "Complaint_Date=@date, Status=@status, Action_Taken=@action " &
                                  "WHERE Complaint_ID=@id"

            Dim cmd As New MySqlCommand(query, cn)

            Dim complainantID As Integer? = GetResidentIDByName(txtcomplaintname.Text)
            If complainantID.HasValue Then
                cmd.Parameters.AddWithValue("@cid", complainantID.Value)
            Else
                MessageBox.Show("Invalid complainant name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@cname", txtcomplaintname.Text)

            Dim respondentID As Integer? = Nothing
            If Not String.IsNullOrWhiteSpace(txtrespondentname.Text) Then
                respondentID = GetResidentIDByName(txtrespondentname.Text)
                If respondentID.HasValue Then
                    cmd.Parameters.AddWithValue("@rid", respondentID.Value)
                    cmd.Parameters.AddWithValue("@rname", txtrespondentname.Text)
                Else
                    MessageBox.Show("Invalid respondent name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                cmd.Parameters.AddWithValue("@rid", DBNull.Value)
                cmd.Parameters.AddWithValue("@rname", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@details", txtDetails.Text)
            cmd.Parameters.AddWithValue("@location", txtLocation.Text)
            cmd.Parameters.AddWithValue("@incident_desc", txtIncidentDescription.Text)
            cmd.Parameters.AddWithValue("@date", dtpComplaintDate.Value)
            cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@action", txtActionTaken.Text)
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtComplaintID.Text))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Complaint successfully updated.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadComplaints()
            LoadResolvedComplaints()
            ClearInputs()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpComplaintDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpComplaintDate.ValueChanged
        ' Read-only, no action needed
    End Sub
End Class
