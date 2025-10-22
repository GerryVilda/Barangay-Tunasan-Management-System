Imports MySql.Data.MySqlClient

Public Class frmblotter

    Private Sub frmblotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBlotters()
    End Sub

    ' ===== LOAD BLOTTERR RECORDS =====
    Private Sub LoadBlotters()
        Try
            koneksyon()
            da = New MySqlDataAdapter("SELECT * FROM blotter_reports", cn)
            dt = New DataTable
            da.Fill(dt)
            dgvblotters.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading blotters: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ===== SAVE BLOTTERR =====
    Private Sub btnsaveblotter_Click(sender As Object, e As EventArgs) Handles btnsaveblotter.Click
        Try
            koneksyon()
            cmd = New MySqlCommand("INSERT INTO blotter (Complainant_ID, Respondent_ID, Incident_Type, Incident_Date, Location, Details, Status, Remarks)
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

    ' ===== DELETE BLOTTERR =====
    Private Sub btndeleteblotter_Click(sender As Object, e As EventArgs) Handles btndeleteblotter.Click
        If txtblotterid.Text = "" Then
            MessageBox.Show("Select a record to delete.")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                koneksyon()
                cmd = New MySqlCommand("DELETE FROM blotter_reports WHERE Blotter_ID=@id", cn)
                cmd.Parameters.AddWithValue("@id", txtblotterid.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("🗑 Blotter record deleted.")
                LoadBlotters()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting blotter: " & ex.Message)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    ' ===== SELECT FROM DATAGRIDVIEW =====
    Private Sub dgvblotters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvblotters.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvblotters.Rows(e.RowIndex)
            txtblotterid.Text = row.Cells("Blotter_ID").Value.ToString()
            txtcomplaint.Text = row.Cells("Complainant_ID").Value.ToString()
            txtrespondent.Text = row.Cells("Respondent_ID").Value.ToString()
            txtincidentype.Text = row.Cells("Incident_Type").Value.ToString()
            txtincidentdate.Value = Convert.ToDateTime(row.Cells("Incident_Date").Value)
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
        txtincidentdate.Value = Date.Now
    End Sub

End Class
