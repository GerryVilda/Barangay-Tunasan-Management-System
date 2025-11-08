Imports MySql.Data.MySqlClient

Public Class frmBlotter

    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()
        ' Your existing load logic
    End Sub

    Private Sub btnSaveBlotter_Click(sender As Object, e As EventArgs) Handles btnsaveblotter.Click
        Try
            Call koneksyon()
            Dim query As String = "INSERT INTO blotter_reports (Complainant_ID, Respondent_ID, Incident_Type, Incident_Date, Location, Details, Status, Remarks) VALUES (@comp, @resp, @type, @date, @loc, @details, @status, @remarks)"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@comp", txtcomplaint.Text)
            cmd.Parameters.AddWithValue("@resp", txtrespondent.Text)
            cmd.Parameters.AddWithValue("@type", cmbincident.Text)
            cmd.Parameters.AddWithValue("@date", dtpincidentdate.Value)
            cmd.Parameters.AddWithValue("@loc", cmbLocation.Text)
            cmd.Parameters.AddWithValue("@details", txtdetails.Text)
            cmd.Parameters.AddWithValue("@status", "Ongoing")
            cmd.Parameters.AddWithValue("@remarks", "")
            cmd.ExecuteNonQuery()

            MessageBox.Show("Blotter record successfully saved.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateBlotter_Click(sender As Object, e As EventArgs) Handles btnupdateblotter.Click
        Try
            Call koneksyon()
            Dim query As String = "UPDATE blotter_reports SET Status=@status, Remarks=@remarks WHERE Blotter_ID=@id"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@status", cmbstatus.Text)
            cmd.Parameters.AddWithValue("@remarks", txtremarks.Text)
            cmd.Parameters.AddWithValue("@id", txtblotterid.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Blotter record updated successfully.", "Barangay Tunasan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class