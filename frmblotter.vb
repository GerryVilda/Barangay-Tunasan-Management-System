Imports MySql.Data.MySqlClient

Public Class frmBlotter

    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make read-only fields
        txtblotterid.ReadOnly = True
        txtcomplaint.ReadOnly = True
        txtrespondent.ReadOnly = True
        dtpcreatedat.Enabled = False

        ' Populate ComboBoxes (optional, can match complaint subjects)
        cmbincident.Items.Clear()
        cmbincident.Items.Add("Theft")
        cmbincident.Items.Add("Assault")
        cmbincident.Items.Add("Vandalism")
        cmbincident.Items.Add("Others")

        cmbLocation.Items.Clear()
        cmbLocation.Items.Add("Barangay Hall")
        cmbLocation.Items.Add("Market")
        cmbLocation.Items.Add("Street")
        cmbLocation.Items.Add("Others")

        cmbstatus.Items.Clear()
        cmbstatus.Items.Add("Pending")
        cmbstatus.Items.Add("Resolved")
        cmbstatus.Items.Add("Closed")

        LoadBlotter()

        dgvblotters.ReadOnly = True
        dgvblotters.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvblotters.MultiSelect = False
    End Sub

    ' Load all blotter entries into DataGridView
    Private Sub LoadBlotter()
        Try
            Call koneksyon()
            Dim query As String = "SELECT Blotter_ID, Complaint_ID, Complainant_ID, Respondent_ID, Incident_Type, Incident_Date, Location, Details, Status, Remarks, Created_At FROM blotter_reports"
            Dim adapter As New MySqlDataAdapter(query, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvblotters.DataSource = dt

            dgvblotters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvblotters.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvblotters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            For Each col As DataGridViewColumn In dgvblotters.Columns
                col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading blotter: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' Fill controls when a DGV row is clicked
    Private Sub dgvblotters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvblotters.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvblotters.Rows(e.RowIndex)

            txtblotterid.Text = row.Cells("Blotter_ID").Value.ToString()
            txtcomplaint.Text = row.Cells("Complainant_ID").Value.ToString()
            txtrespondent.Text = If(row.Cells("Respondent_ID").Value IsNot DBNull.Value, row.Cells("Respondent_ID").Value.ToString(), "")
            dtpcreatedat.Value = Convert.ToDateTime(row.Cells("Created_At").Value)

            cmbincident.Text = If(row.Cells("Incident_Type").Value IsNot DBNull.Value, row.Cells("Incident_Type").Value.ToString(), "")
            dtpincidentdate.Value = Convert.ToDateTime(row.Cells("Incident_Date").Value)
            cmbLocation.Text = If(row.Cells("Location").Value IsNot DBNull.Value, row.Cells("Location").Value.ToString(), "")
            txtdetails.Text = If(row.Cells("Details").Value IsNot DBNull.Value, row.Cells("Details").Value.ToString(), "")
            cmbstatus.Text = If(row.Cells("Status").Value IsNot DBNull.Value, row.Cells("Status").Value.ToString(), "")
            txtremarks.Text = If(row.Cells("Remarks").Value IsNot DBNull.Value, row.Cells("Remarks").Value.ToString(), "")
        End If
    End Sub

    ' Update selected blotter record
    Private Sub btnupdateblotter_Click(sender As Object, e As EventArgs) Handles btnupdateblotter.Click
        Try
            If String.IsNullOrWhiteSpace(txtblotterid.Text) Then
                MessageBox.Show("Please select a blotter record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Call koneksyon()
            Dim query As String = "UPDATE blotter_reports SET Incident_Type=@type, Incident_Date=@date, Location=@location, Details=@details, Status=@status, Remarks=@remarks WHERE Blotter_ID=@id"
            Dim cmd As New MySqlCommand(query, cn)

            cmd.Parameters.AddWithValue("@type", If(String.IsNullOrWhiteSpace(cmbincident.Text), DBNull.Value, cmbincident.Text))
            cmd.Parameters.AddWithValue("@date", dtpincidentdate.Value)
            cmd.Parameters.AddWithValue("@location", If(String.IsNullOrWhiteSpace(cmbLocation.Text), DBNull.Value, cmbLocation.Text))
            cmd.Parameters.AddWithValue("@details", txtdetails.Text)
            cmd.Parameters.AddWithValue("@status", cmbstatus.Text)
            cmd.Parameters.AddWithValue("@remarks", txtremarks.Text)
            cmd.Parameters.AddWithValue("@id", txtblotterid.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Blotter record updated successfully.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadBlotter() ' Refresh DGV
        Catch ex As Exception
            MessageBox.Show("Error updating blotter: " & ex.Message)
        End Try
    End Sub
End Class
