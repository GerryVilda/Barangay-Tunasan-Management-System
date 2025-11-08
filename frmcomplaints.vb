Imports MySql.Data.MySqlClient

Public Class frmComplaints

    '=== Load Event ===
    Private Sub frmComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()
        LoadComplaints()
        LoadResolvedComplaints()
    End Sub

    '=== Load Active Complaints ===
    Private Sub LoadComplaints()
        Try
            Call koneksyon()
            Dim query As String = "SELECT complaint_id, resident_id, complaint_subject, complaint_details, complaint_date, status, action_taken FROM complaints WHERE status <> 'Resolved'"
            Dim adapter As New MySqlDataAdapter(query, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvComplaints.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Load Resolved Complaints ===
    Private Sub LoadResolvedComplaints()
        Try
            Call koneksyon()
            Dim query As String = "SELECT complaint_id, resident_id, complaint_subject, complaint_details, complaint_date, status, action_taken FROM complaints WHERE status = 'Resolved'"
            Dim adapter As New MySqlDataAdapter(query, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvResolved.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== Add New Complaint ===
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Call koneksyon()
            Dim query As String = "INSERT INTO complaints (resident_id, complaint_subject, complaint_details, complaint_date, status, action_taken) VALUES (@resident_id, @subject, @details, @date, @status, @action)"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@resident_id", txtResidentID.Text)
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@details", txtDetails.Text)
            cmd.Parameters.AddWithValue("@date", dtpComplaintDate.Value)
            cmd.Parameters.AddWithValue("@status", "Pending")
            cmd.Parameters.AddWithValue("@action", "")
            cmd.ExecuteNonQuery()

            MessageBox.Show("Complaint successfully recorded.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadComplaints()
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

            Dim complaintID As Integer = dgvComplaints.SelectedRows(0).Cells("complaint_id").Value

            Call koneksyon()
            Dim query As String = "UPDATE complaints SET status='Resolved' WHERE complaint_id=@id"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@id", complaintID)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Complaint marked as resolved.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadComplaints()
            LoadResolvedComplaints()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '=== File to Blotter Logic ===
    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Try
            If dgvComplaints.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a complaint to file as blotter.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim ask As DialogResult = MessageBox.Show("Are you sure the complainant wants to file this as a blotter case?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = DialogResult.Yes Then
                MessageBox.Show("Proceed to Blotter Form to officially record the case.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Optional: pass data to frmBlotter
                Dim selectedRow As DataGridViewRow = dgvComplaints.SelectedRows(0)
                frmblotter.txtcomplaint.Text = selectedRow.Cells("resident_id").Value.ToString()
                frmblotter.txtdetails.Text = selectedRow.Cells("complaint_details").Value.ToString()
                frmblotter.Show()
            Else
                MessageBox.Show("Complaint will remain recorded but not blottered.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class