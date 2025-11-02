Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class frmSummary

    ' Connection String (edit this based on your DB settings)
    Dim connStr As String = "server=localhost;userid=root;password=;database=tunasan_management_db;"
    Dim cn As New MySqlConnection(connStr)

    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSitios()
    End Sub

    Private Sub LoadSitios()
        Try
            cn.Open()
            Dim cmd As New MySqlCommand("SELECT DISTINCT sitio_name FROM reports_summary", cn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            cmbSitio.Items.Clear()
            While reader.Read()
                cmbSitio.Items.Add(reader("sitio_name").ToString())
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading sitios: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cmbSitio.Text = "" Then
            MessageBox.Show("Please select a sitio first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            cn.Open()

            Dim query As String =
                "SELECT sitio_name, " &
                "SUM(total_residents) AS total_residents, " &
                "SUM(households) AS households, " &
                "SUM(male_count) AS male_count, " &
                "SUM(female_count) AS female_count, " &
                "SUM(childhood_count) AS childhood_count, " &
                "SUM(adulthood_count) AS adulthood_count, " &
                "SUM(senior_count) AS senior_count " &
                "FROM reports_summary " &
                "WHERE sitio_name = @sitio " &
                "AND report_from >= @fromDate " &
                "AND report_to <= @toDate " &
                "GROUP BY sitio_name"

            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@sitio", cmbSitio.Text)
            cmd.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date)
            cmd.Parameters.AddWithValue("@toDate", dtpTo.Value.Date)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                lblSitioName.Text = reader("sitio_name").ToString()
                lblTotalResidents.Text = reader("total_residents").ToString()
                lblHouseholds.Text = reader("households").ToString()

                lblMale.Text = reader("male_count").ToString()
                lblFemale.Text = reader("female_count").ToString()

                lblChildhood.Text = reader("childhood_count").ToString()
                lblAdulthood.Text = reader("adulthood_count").ToString()
                lblSenior.Text = reader("senior_count").ToString()
            Else
                lblSitioName.Text = "0"
                lblTotalResidents.Text = "0"
                lblHouseholds.Text = "0"
                lblMale.Text = "0"
                lblFemale.Text = "0"
                lblChildhood.Text = "0"
                lblAdulthood.Text = "0"
                lblSenior.Text = "0"
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

End Class