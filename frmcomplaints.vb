Imports MySql.Data.MySqlClient

Public Class frmComplaints

    '=== Load Event ===
    Private Sub frmComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()
        LoadComplaints()
        LoadResolvedComplaints()

        ' Restrict complaint date to today or past
        dtpComplaintDate.MaxDate = Date.Today

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
    End Sub

    '=== Load Pending Complaints ===
    Private Sub LoadComplaints()
        Try
            Call koneksyon()
            Dim query As String = "SELECT Complaint_ID, Complainant_ID, Complainant_Name, Respondent_ID, Respondent_Name, Complaint_Subject, Complaint_Details, Complaint_Date, Status, Action_Taken FROM complaints WHERE Status = 'Pending'"
            Dim adapter As New MySqlDataAdapter(query, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvComplaints.DataSource = dt

            ' Adjust DataGridView to show all text
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
            Dim query As String = "SELECT Complaint_ID, Complainant_ID, Complainant_Name, Respondent_ID, Respondent_Name, Complaint_Subject, Complaint_Details, Complaint_Date, Status, Action_Taken FROM complaints WHERE Status = 'Resolved'"
            Dim adapter As New MySqlDataAdapter(query, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvResolved.DataSource = dt

            ' Adjust DataGridView to show all text
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
            Dim query As String = "INSERT INTO complaints (Complainant_ID, Complainant_Name, Respondent_ID, Respondent_Name, Complaint_Subject, Complaint_Details, Complaint_Date, Status, Action_Taken) " &
                                  "VALUES (@cid, @cname, @rid, @rname, @subject, @details, @date, 'Pending', @action)"
            Dim cmd As New MySqlCommand(query, cn)

            ' Complainant
            Dim complainantID As Integer? = GetResidentIDByName(txtcomplaintname.Text)
            If complainantID.HasValue Then
                cmd.Parameters.AddWithValue("@cid", complainantID.Value)
                txtComplaintID.Text = complainantID.Value
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
                    txtResidentID.Text = respondentID.Value
                Else
                    MessageBox.Show("Invalid respondent name. Please select a valid resident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                cmd.Parameters.AddWithValue("@rid", DBNull.Value)
                cmd.Parameters.AddWithValue("@rname", DBNull.Value)
                txtResidentID.Clear()
            End If

            ' Other fields
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@details", txtDetails.Text)
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== File Complaint to Blotter ===
    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Try
            If dgvComplaints.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a complaint to file as blotter.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim row As DataGridViewRow = dgvComplaints.SelectedRows(0)

            Dim location As String = InputBox("Enter the location of the incident:", "Incident Location")
            If String.IsNullOrWhiteSpace(location) Then
                MessageBox.Show("Location is required to file a blotter case.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Call koneksyon()
            Dim query As String = "INSERT INTO blotter_reports (Complainant_ID, Respondent_ID, Incident_Type, Incident_Date, Location, Details, Status, Remarks, Created_At) " &
                                  "VALUES (@cid, @rid, @type, @date, @location, @details, 'Pending', '', NOW())"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@cid", row.Cells("Complainant_ID").Value)
            cmd.Parameters.AddWithValue("@rid", If(row.Cells("Respondent_ID").Value IsNot Nothing, row.Cells("Respondent_ID").Value, DBNull.Value))
            cmd.Parameters.AddWithValue("@type", row.Cells("Complaint_Subject").Value)
            cmd.Parameters.AddWithValue("@date", row.Cells("Complaint_Date").Value)
            cmd.Parameters.AddWithValue("@location", location)
            cmd.Parameters.AddWithValue("@details", row.Cells("Complaint_Details").Value)
            cmd.ExecuteNonQuery()

            ' Remove from pending complaints
            Dim deleteQuery As String = "DELETE FROM complaints WHERE Complaint_ID=@id"
            Dim deleteCmd As New MySqlCommand(deleteQuery, cn)
            deleteCmd.Parameters.AddWithValue("@id", row.Cells("Complaint_ID").Value)
            deleteCmd.ExecuteNonQuery()

            MessageBox.Show("Complaint successfully filed to Blotter.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadComplaints()
            LoadResolvedComplaints()

            ' Open Blotter form
            Dim blotterForm As New frmblotter
            blotterForm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Fill textboxes when a row is clicked ===
    Private Sub dgvComplaints_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComplaints.CellClick
        If e.RowIndex >= 0 Then FillTextboxes(dgvComplaints.Rows(e.RowIndex))
    End Sub

    Private Sub dgvResolved_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResolved.CellClick
        If e.RowIndex >= 0 Then FillTextboxes(dgvResolved.Rows(e.RowIndex))
    End Sub

    '=== Helper to fill textboxes ===
    Private Sub FillTextboxes(row As DataGridViewRow)
        txtComplaintID.Text = If(row.Cells("Complainant_ID").Value IsNot Nothing, row.Cells("Complainant_ID").Value.ToString(), "")
        txtcomplaintname.Text = If(row.Cells("Complainant_Name").Value IsNot Nothing, row.Cells("Complainant_Name").Value.ToString(), "")
        txtResidentID.Text = If(row.Cells("Respondent_ID").Value IsNot Nothing, row.Cells("Respondent_ID").Value.ToString(), "")
        txtrespondentname.Text = If(row.Cells("Respondent_Name").Value IsNot Nothing, row.Cells("Respondent_Name").Value.ToString(), "")
        txtSubject.Text = If(row.Cells("Complaint_Subject").Value IsNot Nothing, row.Cells("Complaint_Subject").Value.ToString(), "")
        txtDetails.Text = If(row.Cells("Complaint_Details").Value IsNot Nothing, row.Cells("Complaint_Details").Value.ToString(), "")
        txtActionTaken.Text = If(row.Cells("Action_Taken").Value IsNot Nothing, row.Cells("Action_Taken").Value.ToString(), "")

        ' Status combobox
        If row.Cells("Status").Value IsNot Nothing Then
            cmbStatus.SelectedItem = row.Cells("Status").Value.ToString()
        Else
            cmbStatus.SelectedIndex = 0
        End If

        If row.Cells("Complaint_Date").Value IsNot Nothing Then
            dtpComplaintDate.Value = Convert.ToDateTime(row.Cells("Complaint_Date").Value)
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
        txtActionTaken.Clear()
        cmbStatus.SelectedIndex = 0
        dtpComplaintDate.Value = Date.Today
    End Sub

End Class
