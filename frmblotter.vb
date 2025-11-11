Imports MySql.Data.MySqlClient

Public Class frmBlotter

    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' === Read-only fields ===
        txtblotterid.ReadOnly = True
        txtcomplaint.ReadOnly = True
        txtrespondent.ReadOnly = True
        dtpcreatedat.Enabled = False

        ' === Populate ComboBoxes ===
        cmbincident.Items.Clear()
        cmbincident.Items.AddRange(New String() {"Theft", "Assault", "Vandalism", "Accident", "Others"})

        cmbstatus.Items.Clear()
        cmbstatus.Items.AddRange(New String() {"Pending", "Resolved"})

        ' === Load Blotter Records ===
        LoadBlotter()

        ' === DGV Config ===
        dgvblotters.ReadOnly = True
        dgvblotters.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvblotters.MultiSelect = False
    End Sub

    ' === Load Blotter Data ===
    Private Sub LoadBlotter()
        Try
            koneksyon()
            Dim query As String = "
                SELECT 
                    Blotter_ID, 
                    Complaint_ID, 
                    Complainant_ID, 
                    Respondent_ID, 
                    Incident_Type, 
                    Incident_Date, 
                    Location, 
                    Details, 
                    Status, 
                    Remarks, 
                    Created_At 
                FROM blotter_reports"
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
            MessageBox.Show("Error loading blotter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    ' === DGV Cell Click Event ===
    Private Sub dgvblotters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvblotters.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvblotters.Rows(e.RowIndex)

                ' Helper Function
                Dim SafeVal As Func(Of String, String) =
                    Function(col) If(row.Cells(col).Value IsNot DBNull.Value, row.Cells(col).Value.ToString(), "")

                txtblotterid.Text = SafeVal("Blotter_ID")
                txtcomplaint.Text = SafeVal("Complainant_ID")
                txtrespondent.Text = SafeVal("Respondent_ID")

                ' ComboBoxes and Texts
                cmbincident.Text = SafeVal("Incident_Type")
                txtlocation.Text = SafeVal("Location")
                txtdetails.Text = SafeVal("Details")
                cmbstatus.Text = SafeVal("Status")
                txtremarks.Text = SafeVal("Remarks")

                ' Dates
                If row.Cells("Incident_Date").Value IsNot DBNull.Value Then
                    dtpincidentdate.Value = Convert.ToDateTime(row.Cells("Incident_Date").Value)
                Else
                    dtpincidentdate.Value = Date.Today
                End If

                If row.Cells("Created_At").Value IsNot DBNull.Value Then
                    dtpcreatedat.Value = Convert.ToDateTime(row.Cells("Created_At").Value)
                Else
                    dtpcreatedat.Value = Date.Today
                End If

            Catch ex As Exception
                MessageBox.Show("Error filling fields: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' === Update Blotter ===
    Private Sub btnupdateblotter_Click(sender As Object, e As EventArgs) Handles btnupdateblotter.Click
        Try
            If String.IsNullOrWhiteSpace(txtblotterid.Text) Then
                MessageBox.Show("Please select a blotter record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            koneksyon()
            Dim query = "
                UPDATE blotter_reports 
                SET 
                    Incident_Type=@type, 
                    Incident_Date=@date, 
                    Location=@location, 
                    Details=@details, 
                    Status=@status, 
                    Remarks=@remarks 
                WHERE Blotter_ID=@id"
            Dim cmd As New MySqlCommand(query, cn)

            cmd.Parameters.AddWithValue("@type", If(String.IsNullOrWhiteSpace(cmbincident.Text), DBNull.Value, cmbincident.Text))
            cmd.Parameters.AddWithValue("@date", dtpincidentdate.Value)
            cmd.Parameters.AddWithValue("@location", txtlocation.Text)
            cmd.Parameters.AddWithValue("@details", txtdetails.Text)
            cmd.Parameters.AddWithValue("@status", cmbstatus.Text)
            cmd.Parameters.AddWithValue("@remarks", txtremarks.Text)
            cmd.Parameters.AddWithValue("@id", txtblotterid.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Blotter record updated successfully.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBlotter()

        Catch ex As Exception
            MessageBox.Show("Error updating blotter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub txtlocation_TextChanged(sender As Object, e As EventArgs) Handles txtlocation.TextChanged

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            ' Check if a blotter record is selected
            If String.IsNullOrWhiteSpace(txtblotterid.Text) Then
                MessageBox.Show("Please select a blotter record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to delete this blotter record?" & vbCrLf & "Blotter ID: " & txtblotterid.Text,
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                koneksyon()
                Dim query As String = "DELETE FROM blotter_reports WHERE Blotter_ID=@id"
                Dim cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", txtblotterid.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Blotter record deleted successfully.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear all fields after deletion
                txtblotterid.Clear()
                txtcomplaint.Clear()
                txtrespondent.Clear()
                cmbincident.SelectedIndex = -1
                txtlocation.Clear()
                txtdetails.Clear()
                cmbstatus.SelectedIndex = -1
                txtremarks.Clear()
                dtpincidentdate.Value = Date.Today
                dtpcreatedat.Value = Date.Today

                ' Reload the blotter list
                LoadBlotter()
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting blotter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub
End Class
