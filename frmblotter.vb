Imports MySql.Data.MySqlClient

Public Class frmblotter

    Private Sub frmblotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Load blotter records on form load
        LoadBlotters()

        ' ✅ Restrict incident date (no future blotters)
        txtincidentdate.MaxDate = DateTime.Today
        txtincidentdate.MinDate = New Date(2000, 1, 1)

        ' ✅ Make DataGridView read-only
        dgvblotters.ReadOnly = True

        ' ✅ Auto-size columns and rows based on content
        dgvblotters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvblotters.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvblotters.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    ' ===== LOAD BLOTTERR RECORDS =====
    Private Sub LoadBlotters()
        Try
            koneksyon()
            da = New MySqlDataAdapter("SELECT * FROM blotter_reports", cn)
            dt = New DataTable
            da.Fill(dt)
            dgvblotters.DataSource = dt

            ' ✅ Adjust columns automatically after loading data
            dgvblotters.AutoResizeColumns()
            dgvblotters.AutoResizeRows()
        Catch ex As Exception
            MessageBox.Show("Error loading blotters: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ===== SAVE BLOTTERR =====
    Private Sub btnsaveblotter_Click(sender As Object, e As EventArgs) Handles btnsaveblotter.Click
        ' ✅ Validate that no future date is selected
        If txtincidentdate.Value.Date > DateTime.Today Then
            MessageBox.Show("⚠️ Incident date cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            koneksyon()
            cmd = New MySqlCommand("INSERT INTO blotter_reports (Complainant_ID, Respondent_ID, Incident_Type, Incident_Date, Location, Details, Status, Remarks)
                                    VALUES (@complainant, @respondent, @type, @date, @location, @details, @status, @remarks)", cn)
            cmd.Parameters.AddWithValue("@complainant", txtcomplaint.Text)
            cmd.Parameters.AddWithValue("@respondent", txtrespondent.Text)
            cmd.Parameters.AddWithValue("@type", txtincidentype.Text)
            cmd.Parameters.AddWithValue("@date", txtincidentdate.Value)
            cmd.Parameters.AddWithValue("@location", txtlocation.Text)
            cmd.Parameters.AddWithValue("@details", txtdetails.Text)
            cmd.Parameters.AddWithValue("@status", cbostatus.Text)
            cmd.Parameters.AddWithValue("@remarks", txtremarks.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("✅ Blotter record saved successfully!")
            LoadBlotters()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error saving blotter: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ===== UPDATE BLOTTERR =====
    Private Sub btnupdateblotter_Click(sender As Object, e As EventArgs) Handles btnupdateblotter.Click
        If txtblotterid.Text = "" Then
            MessageBox.Show("Select a record to update.")
            Exit Sub
        End If

        ' ✅ Validate that no future date is selected
        If txtincidentdate.Value.Date > DateTime.Today Then
            MessageBox.Show("⚠️ Incident date cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            koneksyon()
            cmd = New MySqlCommand("UPDATE blotter_reports SET Complainant_ID=@complainant, Respondent_ID=@respondent, Incident_Type=@type, Incident_Date=@date,
                                    Location=@location, Details=@details, Status=@status, Remarks=@remarks WHERE Blotter_ID=@id", cn)
            cmd.Parameters.AddWithValue("@complainant", txtcomplaint.Text)
            cmd.Parameters.AddWithValue("@respondent", txtrespondent.Text)
            cmd.Parameters.AddWithValue("@type", txtincidentype.Text)
            cmd.Parameters.AddWithValue("@date", txtincidentdate.Value)
            cmd.Parameters.AddWithValue("@location", txtlocation.Text)
            cmd.Parameters.AddWithValue("@details", txtdetails.Text)
            cmd.Parameters.AddWithValue("@status", cbostatus.Text)
            cmd.Parameters.AddWithValue("@remarks", txtremarks.Text)
            cmd.Parameters.AddWithValue("@id", txtblotterid.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("✅ Blotter record updated successfully!")
            LoadBlotters()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating blotter: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ===== SELECT FROM DATAGRIDVIEW =====
    Private Sub dgvblotters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvblotters.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvblotters.Rows(e.RowIndex)
            txtblotterid.Text = row.Cells("Blotter_ID").Value.ToString()
            txtcomplaint.Text = row.Cells("Complainant_ID").Value.ToString()
            txtrespondent.Text = row.Cells("Respondent_ID").Value.ToString()
            txtincidentype.Text = row.Cells("Incident_Type").Value.ToString()

            ' ✅ Ensure date value is valid before assigning
            If Not IsDBNull(row.Cells("Incident_Date").Value) Then
                txtincidentdate.Value = Convert.ToDateTime(row.Cells("Incident_Date").Value)
            Else
                txtincidentdate.Value = DateTime.Today
            End If

            txtlocation.Text = row.Cells("Location").Value.ToString()
            txtdetails.Text = row.Cells("Details").Value.ToString()
            cbostatus.Text = row.Cells("Status").Value.ToString()
            txtremarks.Text = row.Cells("Remarks").Value.ToString()
        End If
    End Sub

    ' ===== CLEAR INPUT FIELDS =====
    Private Sub ClearFields()
        txtblotterid.Clear()
        txtcomplaint.Clear()
        txtrespondent.Clear()
        txtincidentype.Clear()
        txtlocation.Clear()
        txtdetails.Clear()
        txtremarks.Clear()
        cbostatus.SelectedIndex = -1
        txtincidentdate.Value = Date.Today
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub dgvblotters_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvblotters.CellContentClick
    End Sub

End Class
