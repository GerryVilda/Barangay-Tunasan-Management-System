Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSummary

    ' === Form Load ===
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadPaymentChart()
            LoadResidentChart()
            LoadComplaintChart()
            LoadCertificationChart()
        Catch ex As Exception
            MessageBox.Show("Error loading summary: " & ex.Message)
        End Try
    End Sub

    ' === Load Payment Revenue Chart ===
    Private Sub LoadPaymentChart()
        Try
            If cn.State = ConnectionState.Open Then cn.Close()
            koneksyon()
            cn.Open()

            Dim query As String = "
                SELECT Certificate_Type, SUM(Amount) AS TotalAmount 
                FROM payment 
                WHERE DATE(Date) = @selectedDate
                GROUP BY Certificate_Type
            "

            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@selectedDate", dtppayment.Value.Date)

            Dim reader = cmd.ExecuteReader()

            chartpaymentrevenue.Series.Clear()
            Dim series As New Series("Payments")
            series.ChartType = SeriesChartType.Column
            series("PointWidth") = "0.6"
            series.IsValueShownAsLabel = True
            series.Color = Color.FromArgb(52, 152, 219)

            While reader.Read()
                series.Points.AddXY(reader("Certificate_Type").ToString(), Convert.ToDouble(reader("TotalAmount")))
            End While
            reader.Close()

            chartpaymentrevenue.Series.Add(series)
            SetupChartAppearance(chartpaymentrevenue)

        Catch ex As Exception
            MessageBox.Show("Error loading payment chart: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' === Load Resident Info Chart ===
    Private Sub LoadResidentChart()
        Try
            If cn.State = ConnectionState.Open Then cn.Close()
            koneksyon()
            cn.Open()

            Dim query As String = "
                SELECT Sitio, COUNT(*) AS ResidentCount 
                FROM residents 
                GROUP BY Sitio
            "

            cmd = New MySqlCommand(query, cn)
            Dim reader = cmd.ExecuteReader()

            chartresidentinfo.Series.Clear()
            Dim series As New Series("Residents")
            series.ChartType = SeriesChartType.Column
            series("PointWidth") = "0.6"
            series.IsValueShownAsLabel = True
            series.Color = Color.FromArgb(46, 204, 113)

            While reader.Read()
                series.Points.AddXY(reader("Sitio").ToString(), Convert.ToInt32(reader("ResidentCount")))
            End While
            reader.Close()

            chartresidentinfo.Series.Add(series)
            SetupChartAppearance(chartresidentinfo)

        Catch ex As Exception
            MessageBox.Show("Error loading resident chart: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' === Load Complaints Chart ===
    Private Sub LoadComplaintChart()
        Try
            If cn.State = ConnectionState.Open Then cn.Close()
            koneksyon()
            cn.Open()

            Dim query As String = "
                SELECT Status, COUNT(*) AS Total 
                FROM complaints 
                WHERE DATE(Complaint_Date) = @selectedDate
                GROUP BY Status
            "

            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@selectedDate", dtpComplaints.Value.Date)

            Dim reader = cmd.ExecuteReader()

            chartcomplaintincident.Series.Clear()
            Dim series As New Series("Complaints")
            series.ChartType = SeriesChartType.Column
            series("PointWidth") = "0.6"
            series.IsValueShownAsLabel = True
            series.Color = Color.FromArgb(231, 76, 60)

            While reader.Read()
                series.Points.AddXY(reader("Status").ToString(), Convert.ToInt32(reader("Total")))
            End While
            reader.Close()

            chartcomplaintincident.Series.Add(series)
            SetupChartAppearance(chartcomplaintincident)

        Catch ex As Exception
            MessageBox.Show("Error loading complaint chart: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' === Load Certification Requests Chart ===
    Private Sub LoadCertificationChart()
        Try
            If cn.State = ConnectionState.Open Then cn.Close()
            koneksyon()
            cn.Open()

            Dim query As String = "
                SELECT Request_Type, COUNT(*) AS Total 
                FROM request_form 
                WHERE DATE(Date_Requested) = @selectedDate
                GROUP BY Request_Type
            "

            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@selectedDate", dtpCertificates.Value.Date)

            Dim reader = cmd.ExecuteReader()

            chartcertificationsrequest.Series.Clear()
            Dim series As New Series("Certificates")
            series.ChartType = SeriesChartType.Column
            series("PointWidth") = "0.6"
            series.IsValueShownAsLabel = True
            series.Color = Color.FromArgb(155, 89, 182)

            While reader.Read()
                series.Points.AddXY(reader("Request_Type").ToString(), Convert.ToInt32(reader("Total")))
            End While
            reader.Close()

            chartcertificationsrequest.Series.Add(series)
            SetupChartAppearance(chartcertificationsrequest)

        Catch ex As Exception
            MessageBox.Show("Error loading certification chart: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' === Common Chart Appearance ===
    Private Sub SetupChartAppearance(chart As Chart)
        With chart.ChartAreas(0)
            .AxisX.LabelStyle.Angle = -45
            .AxisX.Interval = 1
            .AxisX.IsMarginVisible = True
            .BackColor = Color.White
            .AxisX.MajorGrid.LineColor = Color.LightGray
            .AxisY.MajorGrid.LineColor = Color.LightGray
        End With
    End Sub

    ' === Refresh Button Clicks ===
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

End Class
