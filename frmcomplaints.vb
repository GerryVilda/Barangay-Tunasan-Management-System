Imports MySql.Data.MySqlClient

Public Class frmcomplaints

    'Database Connection
    Dim connStr As String = "server=localhost;userid=root;password=;database=tunasan_management_db;"
    Dim conn As New MySqlConnection(connStr)

    Private Sub frmcomplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize Status ComboBox
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Resolved")
        cmbStatus.SelectedIndex = 0 ' Default to Pending

        'Load data
        LoadComplaintCounts()
        LoadComplaints()
    End Sub

    'Load summary counts (case-insensitive)
    Private Sub LoadComplaintCounts()
        Try
            conn.Open()

            Dim cmdPending As New MySqlCommand("SELECT COUNT(*) FROM complaints WHERE LOWER(status)='pending'", conn)
            Dim cmdResolved As New MySqlCommand("SELECT COUNT(*) FROM complaints WHERE LOWER(status)='resolved'", conn)
            Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM complaints", conn)

            lblPendingCount.Text = cmdPending.ExecuteScalar().ToString()
            lblResolvedCount.Text = cmdResolved.ExecuteScalar().ToString()
            lblTotalCount.Text = cmdTotal.ExecuteScalar().ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading complaint counts: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Load all complaints (DataGridView)
    Private Sub LoadComplaints()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM complaints ORDER BY complaint_id DESC"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvComplaints.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading complaints: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Add Complaint
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtResidentID.Text.Trim() = "" Or txtSubject.Text.Trim() = "" Then
            MessageBox.Show("Please fill in required fields.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO complaints (resident_id, complaint_subject, complaint_details, complaint_date, status, action_taken) VALUES (@resident_id, @subject, @details, @date, @status, @action)"
            Dim cmd As New MySqlCommand(query, conn)

            Dim statusValue As String = If(String.IsNullOrWhiteSpace(cmbStatus.Text), "Pending", cmbStatus.Text)

            cmd.Parameters.AddWithValue("@resident_id", txtResidentID.Text)
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@details", txtDetails.Text)
            cmd.Parameters.AddWithValue("@date", dtpComplaintDate.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@status", statusValue)
            cmd.Parameters.AddWithValue("@action", txtActionTaken.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Complaint successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Refresh everything
            ClearFields()
            LoadComplaintCounts()
            LoadComplaints()

        Catch ex As Exception
            MessageBox.Show("Error adding complaint: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Search Complaint
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM complaints WHERE complaint_subject LIKE @search OR complaint_details LIKE @search"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvComplaints.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Clear Fields
    Private Sub ClearFields()
        txtComplaintID.Clear()
        txtResidentID.Clear()
        txtSubject.Clear()
        txtDetails.Clear()
        cmbStatus.SelectedIndex = 0 ' Reset to Pending
        txtActionTaken.Clear()
        dtpComplaintDate.Value = DateTime.Now
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
