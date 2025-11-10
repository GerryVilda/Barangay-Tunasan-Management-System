Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSummary

    ' === Form Load ===
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksyon()

            ' Load Sitio dropdown
            LoadSitioComboBox()

            ' Load data into charts
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

    ' === Load Sitio ComboBox ===
    Private Sub LoadSitioComboBox()
        cboresident.Items.Clear()
        cboresident.Items.Add("All Sitios") ' Default option to show all

        ' Add all sitios
        cboresident.Items.Add("Camella Homes III")
        cboresident.Items.Add("Lake Shore Subdivision")
        cboresident.Items.Add("Lindenwood Residences")
        cboresident.Items.Add("Midland II Subdivision")
        cboresident.Items.Add("Parkhomes Subdivision")
        cboresident.Items.Add("Planas")
        cboresident.Items.Add("Sto. Niño Village")
        cboresident.Items.Add("Susana Heights Subdivision")
        cboresident.Items.Add("Villa Carolina I")
        cboresident.Items.Add("Villa Carolina II")

        cboresident.SelectedIndex = 0 ' Select "All Sitios" by default
    End Sub

    ' === Load Payment Revenue Chart ===
    Private Sub LoadPaymentChart()
        Try
            chartpaymentrevenue.Series.Clear()
            chartpaymentrevenue.Titles.Clear()

            Dim query As String = "
                SELECT Certificate_Type, SUM(Amount) AS TotalAmount 
                FROM payment 
                WHERE DATE(Date) = @selectedDate
                GROUP BY Certificate_Type
            "

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@selectedDate", dtppayment.Value.Date)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartpaymentrevenue.Titles.Add("No data available for this date.")
                        Exit Sub
                    End If

                    Dim series As New Series("Payments") With {
                        .ChartType = SeriesChartType.Column,
                        .IsValueShownAsLabel = True,
                        .Color = Color.FromArgb(52, 152, 219)
                    }
                    series("PointWidth") = "0.4"

                    For Each row As DataRow In table.Rows
                        series.Points.AddXY(row("Certificate_Type").ToString(), Convert.ToDouble(row("TotalAmount")))
                    Next

                    chartpaymentrevenue.Series.Add(series)
                    SetupChartAppearance(chartpaymentrevenue)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading payment chart: " & ex.Message)
        End Try
    End Sub

    ' === Load Resident Info Chart ===
    Private Sub LoadResidentChart()
        Try
            chartresidentinfo.Series.Clear()
            chartresidentinfo.Titles.Clear()

            Dim query As String = ""
            Dim selectedSitio As String = If(cboresident.SelectedItem IsNot Nothing, cboresident.SelectedItem.ToString(), "All Sitios")

            ' Build query based on selection
            If selectedSitio = "All Sitios" Then
                ' Show count per sitio
                query = "
                    SELECT Sitio, COUNT(*) AS ResidentCount 
                    FROM residents 
                    GROUP BY Sitio
                    ORDER BY Sitio
                "
            Else
                ' Show detailed count for specific sitio
                query = "
                    SELECT 
                        CASE 
                            WHEN Gender = 'Male' THEN 'Male'
                            WHEN Gender = 'Female' THEN 'Female'
                            ELSE 'Others'
                        END AS Category,
                        COUNT(*) AS ResidentCount 
                    FROM residents 
                    WHERE Sitio = @sitio
                    GROUP BY Category
                "
            End If

            Using cmd As New MySqlCommand(query, cn)
                If selectedSitio <> "All Sitios" Then
                    cmd.Parameters.AddWithValue("@sitio", selectedSitio)
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartresidentinfo.Titles.Add("No resident data available.")
                        Exit Sub
                    End If

                    ' Set title based on selection
                    If selectedSitio = "All Sitios" Then
                        chartresidentinfo.Titles.Add("Residents per Sitio")
                    Else
                        chartresidentinfo.Titles.Add($"Residents in {selectedSitio}")
                    End If

                    Dim series As New Series("Residents") With {
                        .ChartType = SeriesChartType.Column,
                        .IsValueShownAsLabel = True,
                        .Color = Color.FromArgb(46, 204, 113)
                    }

                    For Each row As DataRow In table.Rows
                        Dim xValue As String = If(selectedSitio = "All Sitios", row("Sitio").ToString(), row("Category").ToString())
                        series.Points.AddXY(xValue, Convert.ToInt32(row("ResidentCount")))
                    Next

                    chartresidentinfo.Series.Add(series)
                    SetupChartAppearance(chartresidentinfo)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading resident chart: " & ex.Message)
        End Try
    End Sub

    ' === Load Complaints Chart ===
    Private Sub LoadComplaintChart()
        Try
            chartcomplaintincident.Series.Clear()
            chartcomplaintincident.Titles.Clear()

            Dim query As String = "
                SELECT Status, COUNT(*) AS Total 
                FROM complaints 
                WHERE DATE(Complaint_Date) = @selectedDate
                GROUP BY Status
            "

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@selectedDate", dtpComplaints.Value.Date)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartcomplaintincident.Titles.Add("No complaints for this date.")
                        Exit Sub
                    End If

                    Dim series As New Series("Complaints") With {
                        .ChartType = SeriesChartType.Column,
                        .IsValueShownAsLabel = True,
                        .Color = Color.FromArgb(231, 76, 60)
                    }

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

    ' === Load Certification Requests Chart ===
    Private Sub LoadCertificationChart()
        Try
            chartcertificationsrequest.Series.Clear()
            chartcertificationsrequest.Titles.Clear()

            Dim query As String = "
                SELECT Request_Type, COUNT(*) AS Total 
                FROM request_form 
                WHERE DATE(Date_Requested) = @selectedDate
                GROUP BY Request_Type
            "

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@selectedDate", dtpCertificates.Value.Date)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        chartcertificationsrequest.Titles.Add("No certifications for this date.")
                        Exit Sub
                    End If

                    Dim series As New Series("Certificates") With {
                        .ChartType = SeriesChartType.Column,
                        .IsValueShownAsLabel = True,
                        .Color = Color.FromArgb(155, 89, 182)
                    }

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

    ' === Common Chart Appearance ===
    Private Sub SetupChartAppearance(chart As Chart)
        With chart.ChartAreas(0)
            .BackColor = Color.White
            .AxisX.LabelStyle.Angle = -45
            .AxisX.Interval = 1
            .AxisX.MajorGrid.LineColor = Color.LightGray
            .AxisY.MajorGrid.LineColor = Color.LightGray
            .AxisX.LabelStyle.Font = New Font("Segoe UI", 8, FontStyle.Regular)
            .AxisY.LabelStyle.Font = New Font("Segoe UI", 8, FontStyle.Regular)
            .InnerPlotPosition.Auto = False
            .InnerPlotPosition.Width = 90
            .InnerPlotPosition.Height = 80
            .InnerPlotPosition.X = 5
            .InnerPlotPosition.Y = 5
        End With
    End Sub

    ' === Individual Refresh Buttons ===
    Private Sub btnPaymentRefresh_Click(sender As Object, e As EventArgs) Handles btnPaymentRefresh.Click
        LoadPaymentChart()
    End Sub

    Private Sub btnResidentRefresh_Click(sender As Object, e As EventArgs) Handles btnResidentRefresh.Click
        LoadResidentChart()
    End Sub

    Private Sub btnComplaintRefresh_Click(sender As Object, e As EventArgs) Handles btnComplaintRefresh.Click
        LoadComplaintChart()
    End Sub

    Private Sub btnCertificateRefresh_Click(sender As Object, e As EventArgs) Handles btnCertificateRefresh.Click
        LoadCertificationChart()
    End Sub

    ' === ComboBox Selection Changed ===
    Private Sub cboresident_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboresident.SelectedIndexChanged
        LoadResidentChart() ' Automatically reload chart when sitio changes
    End Sub

    ' === Unused Event Handlers (can be removed) ===
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub chartresidentinfo_Click(sender As Object, e As EventArgs) Handles chartresidentinfo.Click
    End Sub

End Class