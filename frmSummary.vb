Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSummary

    ' === Form Load ===
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksyon()

            ' Set all DTPs to Month/Year only and prevent future dates
            SetDTPMonthYear(Me)

            ' Bring layout to front
            TableLayoutPanel1.BringToFront()

            ' Load Sitio dropdown
            LoadSitioComboBox()

            ' Build quadrants
            BuildQuadrant(0, 0, Label5, dtppayment, cbopayments, btnPaymentRefresh, chartpaymentrevenue)
            BuildQuadrant(0, 1, Label12, dtpResidentInfo, cboresident, btnResidentRefresh, chartresidentinfo)
            BuildQuadrant(1, 0, Label2, dtpCertificates, cbocertificaterequest, btnCertificateRefresh, chartcertificationsrequest)
            BuildQuadrant(1, 1, Label22, dtpComplaints, cbocomplaints, btnComplaintRefresh, chartcomplaintincident)

            ' Load all charts initially
            LoadPaymentChart()
            LoadResidentChart()
            LoadComplaintChart()
            LoadCertificationChart()

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

    ' === Build Quadrant ===
    Private Sub BuildQuadrant(row As Integer, col As Integer, title As Label, dtp As DateTimePicker, combo As ComboBox, refreshBtn As Button, chart As Chart)
        If TableLayoutPanel1.Controls.Contains(chart) Then TableLayoutPanel1.Controls.Remove(chart)

        Dim container As New TableLayoutPanel() With {.Dock = DockStyle.Fill, .RowCount = 3, .ColumnCount = 1, .Padding = New Padding(8)}
        container.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        container.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        container.RowStyles.Add(New RowStyle(SizeType.Percent, 100))

        title.Margin = New Padding(0, 0, 0, 4)
        title.AutoSize = True
        title.Dock = DockStyle.Top

        Dim filters As New FlowLayoutPanel() With {.Dock = DockStyle.Top, .AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .WrapContents = False, .Margin = New Padding(0, 0, 0, 6)}

        If dtp IsNot Nothing Then
            dtp.Width = Math.Max(280, dtp.Width)
            dtp.Margin = New Padding(0, 0, 8, 0)
            filters.Controls.Add(dtp)
        End If
        If combo IsNot Nothing Then
            combo.Width = Math.Max(180, combo.Width)
            combo.Margin = New Padding(0, 0, 8, 0)
            filters.Controls.Add(combo)
        End If
        If refreshBtn IsNot Nothing Then
            refreshBtn.Margin = New Padding(0)
            filters.Controls.Add(refreshBtn)
        End If

        chart.Dock = DockStyle.Fill
        chart.Margin = New Padding(0)

        container.Controls.Add(title, 0, 0)
        container.Controls.Add(filters, 0, 1)
        container.Controls.Add(chart, 0, 2)

        TableLayoutPanel1.Controls.Add(container, col, row)
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

    ' === Load Payment Chart (monthly) ===
    Private Sub LoadPaymentChart()
        Try
            chartpaymentrevenue.Series.Clear()
            chartpaymentrevenue.Titles.Clear()
            chartpaymentrevenue.Legends.Clear()

            Dim month As Integer = dtppayment.Value.Month
            Dim year As Integer = dtppayment.Value.Year

            Dim query As String = "SELECT Certificate_Type, SUM(Amount) AS TotalAmount FROM payment WHERE MONTH(Date)=@month AND YEAR(Date)=@year GROUP BY Certificate_Type"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@month", month)
                cmd.Parameters.AddWithValue("@year", year)

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
                        series.Points.AddXY(row("Certificate_Type").ToString(), Convert.ToDecimal(row("TotalAmount")))
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
    Private Sub LoadComplaintChart()
        Try
            chartcomplaintincident.Series.Clear()
            chartcomplaintincident.Titles.Clear()
            chartcomplaintincident.Legends.Clear()

            Dim month As Integer = dtpComplaints.Value.Month
            Dim year As Integer = dtpComplaints.Value.Year

            Dim query As String = "SELECT Status, COUNT(*) AS Total FROM complaints WHERE MONTH(Complaint_Date)=@month AND YEAR(Complaint_Date)=@year GROUP BY Status"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@month", month)
                cmd.Parameters.AddWithValue("@year", year)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartcomplaintincident.Titles.Add("No complaints for this month.")
                        Exit Sub
                    End If

                    Dim series As New Series("Complaints") With {.ChartType = SeriesChartType.Column, .Color = Color.FromArgb(231, 76, 60)}
                    series.IsValueShownAsLabel = True
                    series.LabelForeColor = Color.Black

                    For Each row As DataRow In table.Rows
                        series.Points.AddXY(row("Status").ToString(), Convert.ToInt32(row("Total")))
                    Next

                    chartcomplaintincident.Series.Add(series)
                    SetupChartAppearance(chartcomplaintincident)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading complaint chart: " & ex.Message)
        End Try
    End Sub

    ' === Load Certification Chart (monthly) ===
    Private Sub LoadCertificationChart()
        Try
            chartcertificationsrequest.Series.Clear()
            chartcertificationsrequest.Titles.Clear()
            chartcertificationsrequest.Legends.Clear()

            Dim month As Integer = dtpCertificates.Value.Month
            Dim year As Integer = dtpCertificates.Value.Year

            Dim query As String = "SELECT Request_Type, COUNT(*) AS Total FROM request_form WHERE MONTH(Date_Requested)=@month AND YEAR(Date_Requested)=@year GROUP BY Request_Type"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@month", month)
                cmd.Parameters.AddWithValue("@year", year)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartcertificationsrequest.Titles.Add("No certifications for this month.")
                        Exit Sub
                    End If

                    Dim series As New Series("Certificates") With {.ChartType = SeriesChartType.Column, .Color = Color.FromArgb(155, 89, 182)}
                    series.IsValueShownAsLabel = True
                    series.LabelForeColor = Color.Black

                    For Each row As DataRow In table.Rows
                        series.Points.AddXY(row("Request_Type").ToString(), Convert.ToInt32(row("Total")))
                    Next

                    chartcertificationsrequest.Series.Add(series)
                    SetupChartAppearance(chartcertificationsrequest)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading certification chart: " & ex.Message)
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

    Private Sub btnCertificateRefresh_Click(sender As Object, e As EventArgs) Handles btnCertificateRefresh.Click
        LoadCertificationChart()
    End Sub

    ' === ComboBox selection ===
    Private Sub cboresident_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboresident.SelectedIndexChanged
        LoadResidentChart()
    End Sub

End Class
