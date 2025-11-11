Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class frmSummary

    ' === Form Load ===
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksyon()

            ' Set all DTPs to Month/Year only and prevent future dates
            SetDTPMonthYear(Me)

            ' Load Sitio dropdown
            LoadSitioComboBox()

            ' Load Certificate dropdown
            LoadCertificateComboBox()

            ' Load all charts initially
            LoadPaymentChart()
            LoadResidentChart()
            LoadComplaintChart()

        Catch ex As Exception
            MessageBox.Show("Error loading summary: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' === Set all DTPs to Month/Year, max today ===
    Private Sub SetDTPMonthYear(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is DateTimePicker Then
                Dim dtp As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                dtp.Format = DateTimePickerFormat.Custom
                dtp.CustomFormat = "MMMM yyyy"
                dtp.ShowUpDown = True
                dtp.MaxDate = DateTime.Today
            End If

            If ctrl.HasChildren Then
                SetDTPMonthYear(ctrl)
            End If
        Next
    End Sub

    ' === Load Sitio ComboBox ===
    Private Sub LoadSitioComboBox()
        cboresident.Items.Clear()
        cboresident.Items.Add("All Sitios")

        Dim query As String = "SELECT DISTINCT Sitio FROM residents ORDER BY Sitio"
        Using cmd As New MySqlCommand(query, cn)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cboresident.Items.Add(reader("Sitio").ToString())
                End While
            End Using
        End Using

        cboresident.SelectedIndex = 0
    End Sub

    ' === Load Certificate ComboBox ===
    Private Sub LoadCertificateComboBox()
        cboCertificate.Items.Clear()
        cboCertificate.Items.Add("All Certificates")

        ' Add all your certificates
        Dim certificates As String() = {
            "Barangay Clearance (Personal Use)",
            "Barangay Clearance (Business)",
            "Barangay Clearance (First Job)",
            "Residency Certificate",
            "Indigency Certificate",
            "Community Tax Certificate / Cedula",
            "Barangay Business Clearance",
            "Good Moral Certificate",
            "Senior Citizen / PWD Certificate",
            "Solo Parent Certificate",
            "Certificate of Occupancy / Lot Clearance",
            "Certificate of Barangay Employment"
        }

        cboCertificate.Items.AddRange(certificates)
        cboCertificate.SelectedIndex = 0
    End Sub

    ' === Load Resident Chart ===
    Private Sub LoadResidentChart()
        Try
            chartresidentinfo.Series.Clear()
            chartresidentinfo.Titles.Clear()
            chartresidentinfo.Legends.Clear()

            Dim selectedSitio As String = If(cboresident.SelectedItem IsNot Nothing, cboresident.SelectedItem.ToString(), "All Sitios")
            Dim selectedMonth As Integer = dtpResidentInfo.Value.Month
            Dim selectedYear As Integer = dtpResidentInfo.Value.Year

            Dim query As String
            If selectedSitio = "All Sitios" Then
                query = "SELECT 'All Sitios' AS Sitio, COUNT(*) AS ResidentCount FROM residents WHERE MONTH(Date_Registered)=@month AND YEAR(Date_Registered)=@year"
            Else
                query = "SELECT Sitio, COUNT(*) AS ResidentCount FROM residents WHERE Sitio=@sitio AND MONTH(Date_Registered)=@month AND YEAR(Date_Registered)=@year GROUP BY Sitio"
            End If

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@month", selectedMonth)
                cmd.Parameters.AddWithValue("@year", selectedYear)
                If selectedSitio <> "All Sitios" Then cmd.Parameters.AddWithValue("@sitio", selectedSitio)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartresidentinfo.Titles.Add("No data for this month.")
                        Exit Sub
                    End If

                    Dim series As New Series("Residents") With {.ChartType = SeriesChartType.Column, .Color = Color.FromArgb(46, 204, 113)}
                    series.IsValueShownAsLabel = True
                    series.LabelForeColor = Color.Black

                    For Each row As DataRow In table.Rows
                        series.Points.AddXY(row("Sitio").ToString(), Convert.ToInt32(row("ResidentCount")))
                    Next

                    chartresidentinfo.Series.Add(series)
                    SetupChartAppearance(chartresidentinfo)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading resident chart: " & ex.Message)
        End Try
    End Sub

    ' === Load Payment Chart ===
    Private Sub LoadPaymentChart()
        Try
            chartpaymentrevenue.Series.Clear()
            chartpaymentrevenue.Titles.Clear()
            chartpaymentrevenue.Legends.Clear()

            Dim month As Integer = dtppayment.Value.Month
            Dim year As Integer = dtppayment.Value.Year
            Dim selectedCert As String = If(cboCertificate.SelectedItem IsNot Nothing, cboCertificate.SelectedItem.ToString(), "All Certificates")

            Dim query As String
            If selectedCert = "All Certificates" Then
                query = "SELECT 'All Certificates' AS Certificate_Type, SUM(Amount) AS TotalAmount FROM payment WHERE MONTH(Date)=@month AND YEAR(Date)=@year"
            Else
                query = "SELECT Certificate_Type, SUM(Amount) AS TotalAmount FROM payment WHERE Certificate_Type=@cert AND MONTH(Date)=@month AND YEAR(Date)=@year GROUP BY Certificate_Type"
            End If

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@month", month)
                cmd.Parameters.AddWithValue("@year", year)
                If selectedCert <> "All Certificates" Then cmd.Parameters.AddWithValue("@cert", selectedCert)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartpaymentrevenue.Titles.Add("No payments for this month.")
                        Exit Sub
                    End If

                    Dim series As New Series("Payments") With {.ChartType = SeriesChartType.Column, .Color = Color.FromArgb(52, 152, 219)}
                    series.IsValueShownAsLabel = True
                    series.LabelForeColor = Color.Black

                    For Each row As DataRow In table.Rows
                        Dim amount As Decimal = Convert.ToDecimal(row("TotalAmount"))
                        series.Points.AddXY(row("Certificate_Type").ToString(), amount)
                        series.Points(series.Points.Count - 1).Label = "₱" & amount.ToString("N2") ' Format as currency
                    Next


                    chartpaymentrevenue.Series.Add(series)
                    SetupChartAppearance(chartpaymentrevenue)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payment chart: " & ex.Message)
        End Try
    End Sub

    ' === Load Complaint Chart (monthly) ===
    ' === Load Complaint Chart (monthly, filterable by Sitio) ===
    ' === Load total complaints & blotters chart (monthly) ===
    Private Sub LoadComplaintChart()
        Try
            chartcomplaintincident.Series.Clear()
            chartcomplaintincident.Titles.Clear()
            chartcomplaintincident.Legends.Clear()

            Dim selectedMonth As Integer = dtpComplaints.Value.Month
            Dim selectedYear As Integer = dtpComplaints.Value.Year

            Dim query As String = "
            SELECT COUNT(*) AS TotalCount
            FROM (
                SELECT Complaint_ID AS ID, Complaint_Date AS Date_Entry FROM complaints
                UNION ALL
                SELECT Blotter_ID AS ID, Incident_Date AS Date_Entry FROM blotter_reports
            ) AS combined
            WHERE MONTH(Date_Entry)=@month AND YEAR(Date_Entry)=@year"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@month", selectedMonth)
                cmd.Parameters.AddWithValue("@year", selectedYear)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 OrElse table.Rows(0)("TotalCount") Is DBNull.Value Then
                        chartcomplaintincident.Titles.Add("No complaints or blotters for this month.")
                        Exit Sub
                    End If

                    Dim total As Integer = Convert.ToInt32(table.Rows(0)("TotalCount"))
                    Dim series As New Series("Total") With {
                    .ChartType = SeriesChartType.Column,
                    .Color = Color.FromArgb(231, 76, 60)
                }
                    series.Points.AddXY("Total", total)
                    series.IsValueShownAsLabel = True
                    series.LabelForeColor = Color.Black

                    chartcomplaintincident.Series.Add(series)
                    SetupChartAppearance(chartcomplaintincident)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading complaint chart: " & ex.Message)
        End Try
    End Sub



    ' === Chart Appearance Helper ===
    Private Sub SetupChartAppearance(chart As Chart)
        If chart.ChartAreas.Count = 0 Then chart.ChartAreas.Add(New ChartArea())
        chart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        chart.ChartAreas(0).AxisY.MajorGrid.Enabled = False
        chart.ChartAreas(0).BackColor = Color.White
        chart.BackColor = Color.WhiteSmoke
        chart.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Segoe UI", 9)
        chart.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Segoe UI", 9)
    End Sub

    ' === Refresh Buttons ===
    Private Sub btnResidentRefresh_Click(sender As Object, e As EventArgs) Handles btnResidentRefresh.Click
        LoadResidentChart()
    End Sub

    Private Sub btnPaymentRefresh_Click(sender As Object, e As EventArgs) Handles btnPaymentRefresh.Click
        LoadPaymentChart()
    End Sub

    Private Sub btnComplaintRefresh_Click(sender As Object, e As EventArgs) Handles btnComplaintRefresh.Click
        LoadComplaintChart()
    End Sub

    ' === ComboBox selection changes ===
    Private Sub cboresident_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboresident.SelectedIndexChanged
        LoadResidentChart()
    End Sub

    Private Sub cboCertificate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCertificate.SelectedIndexChanged
        LoadPaymentChart()
    End Sub

    Private Sub chartcomplaintincident_Click(sender As Object, e As EventArgs) Handles chartcomplaintincident.Click

    End Sub
End Class
