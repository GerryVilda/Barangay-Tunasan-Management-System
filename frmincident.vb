Imports MySql.Data.MySqlClient

Public Class frmincident

    Private Sub frmincident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load initial data
        LoadStatusOptions()
        LoadIncidentCounts()
        LoadIncidents()
    End Sub

    'Fill the Status ComboBoxes
    Private Sub LoadStatusOptions()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Resolved")
        cmbStatus.SelectedIndex = 0

        cmbFilterStatus.Items.Clear()
        cmbFilterStatus.Items.Add("All")
        cmbFilterStatus.Items.Add("Pending")
        cmbFilterStatus.Items.Add("Resolved")
        cmbFilterStatus.SelectedIndex = 0
    End Sub

    'Load all incidents
    Private Sub LoadIncidents(Optional filterStatus As String = "All")
        Try
            Dim query As String = "SELECT * FROM incident_reports"
            If filterStatus <> "All" Then
                query &= " WHERE LOWER(status) = @status"
            End If
            query &= " ORDER BY id ASC"

            Dim cmd As New MySqlCommand(query, cn)
            If filterStatus <> "All" Then
                cmd.Parameters.AddWithValue("@status", filterStatus.ToLower())
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvIncidents.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading incidents: " & ex.Message)
        End Try
    End Sub

    'Load counts (Pending / Resolved / Total)
    Private Sub LoadIncidentCounts()
        Try
            Dim cmdPending As New MySqlCommand("SELECT COUNT(*) FROM incident_reports WHERE LOWER(status)='pending'", cn)
            Dim cmdResolved As New MySqlCommand("SELECT COUNT(*) FROM incident_reports WHERE LOWER(status)='resolved'", cn)
            Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM incident_reports", cn)

            lblPending.Text = cmdPending.ExecuteScalar().ToString()
            lblResolved.Text = cmdResolved.ExecuteScalar().ToString()
            lblTotal.Text = cmdTotal.ExecuteScalar().ToString()
        Catch ex As Exception
            MessageBox.Show("Error loading counts: " & ex.Message)
        End Try
    End Sub

    'Save New Incident
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtComplainant.Text.Trim() = "" Or txtRespondent.Text.Trim() = "" Or txtIncidentType.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim query As String = "INSERT INTO incident_reports (complainant, respondent, incident_type, incident_date, status, action_taken) VALUES (@complainant, @respondent, @type, @date, @status, @action)"
            Dim cmd As New MySqlCommand(query, cn)

            cmd.Parameters.AddWithValue("@complainant", txtComplainant.Text)
            cmd.Parameters.AddWithValue("@respondent", txtRespondent.Text)
            cmd.Parameters.AddWithValue("@type", txtIncidentType.Text)
            cmd.Parameters.AddWithValue("@date", dtpIncidents.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            MessageBox.Show("Incident successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadIncidentCounts()
            LoadIncidents()

        Catch ex As Exception
            MessageBox.Show("Error saving incident: " & ex.Message)
            cn.Close()
        End Try
    End Sub

    'Edit Incident
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim query As String = "UPDATE incident_reports SET complainant=@complainant, respondent=@respondent, incident_type=@type, incident_date=@date, status=@status, action_taken=@action WHERE incident_id=@id"
            Dim cmd As New MySqlCommand(query, cn)

            cmd.Parameters.AddWithValue("@complainant", txtComplainant.Text)
            cmd.Parameters.AddWithValue("@respondent", txtRespondent.Text)
            cmd.Parameters.AddWithValue("@type", txtIncidentType.Text)
            cmd.Parameters.AddWithValue("@date", dtpIncidents.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            MessageBox.Show("Incident updated successfully!")
            LoadIncidentCounts()
            LoadIncidents()
        Catch ex As Exception
            MessageBox.Show("Error updating: " & ex.Message)
            cn.Close()
        End Try
    End Sub

    'Delete Incident
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM incidents WHERE incident_id=@id"
                Dim cmd As New MySqlCommand(query, cn)

                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

                MessageBox.Show("Incident deleted successfully.")
                ClearFields()
                LoadIncidentCounts()
                LoadIncidents()
            Catch ex As Exception
                MessageBox.Show("Error deleting: " & ex.Message)
                cn.Close()
            End Try
        End If
    End Sub

    'Search Button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim query As String = "SELECT * FROM incident_reports WHERE complainant LIKE @search OR respondent LIKE @search OR incident_type LIKE @search"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvIncidents.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    'Refresh Button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadIncidentCounts()
        LoadIncidents()
        ClearFields()
    End Sub

    'Filter by Status
    Private Sub cmbFilterStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterStatus.SelectedIndexChanged
        LoadIncidents(cmbFilterStatus.Text)
    End Sub

    'Clear Inputs
    Private Sub ClearFields()
        txtComplainant.Clear()
        txtRespondent.Clear()
        txtIncidentType.Clear()
        cmbStatus.SelectedIndex = 0
        dtpIncidents.Value = DateTime.Now
    End Sub

    'Cancel Button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
