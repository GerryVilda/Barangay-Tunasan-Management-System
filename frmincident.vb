Imports MySql.Data.MySqlClient

Public Class frmincident

    Private Sub frmIncident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()
        ' Load or refresh data if needed
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Call koneksyon()
            Dim query As String = "INSERT INTO incident_reports (complainant, respondent, incident_type, incident_date, status, action_taken) VALUES (@complainant, @respondent, @type, @date, @status, @action)"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@complainant", txtComplainant.Text)
            cmd.Parameters.AddWithValue("@respondent", txtRespondent.Text)
            cmd.Parameters.AddWithValue("@type", cmbincident.Text)
            cmd.Parameters.AddWithValue("@date", dtpIncidents.Value)
            cmd.Parameters.AddWithValue("@status", "Pending")
            cmd.Parameters.AddWithValue("@action", "")
            cmd.ExecuteNonQuery()

            MessageBox.Show("Incident report saved successfully.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Call koneksyon()
            Dim query As String = "UPDATE incident_reports SET incident_type=@type, incident_date=@date, status=@status, action_taken=@action WHERE Incident_ID=@id"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@type", cmbincident.Text)
            cmd.Parameters.AddWithValue("@date", dtpIncidents.Value)
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
            cmd.Parameters.AddWithValue("@id", txtincidentid.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Incident record updated successfully.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Call koneksyon()
            Dim query As String = "DELETE FROM incident_reports WHERE Incident_ID=@id"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@id", txtincidentid.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Incident record deleted.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' You can add reload table logic here
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Added connection between Incident → Blotter
    Private Sub btnFileBlotter_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ask As DialogResult = MessageBox.Show("Would you like to file this incident as a blotter record?", "Barangay Tunasan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = DialogResult.Yes Then
            frmblotter.Show()
        End If
    End Sub

End Class