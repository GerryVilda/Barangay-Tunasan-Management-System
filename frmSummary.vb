Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class frmSummary

    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResidentsByGender()
    End Sub

    Private Sub LoadResidentsByGender()
        Try
            Call koneksyon()

            Dim query As String = "SELECT gender, COUNT(*) AS total FROM residents GROUP BY gender"
            Dim cmd As New MySqlCommand(query, cn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Clear previous data
            Chart1.Series.Clear()
            Chart1.Titles.Clear()
            Chart1.ChartAreas.Clear()

            ' Setup chart area
            Dim area As New ChartArea()
            area.AxisX.Title = "Gender"
            area.AxisY.Title = "Number of Residents"
            area.AxisX.Interval = 1
            Chart1.ChartAreas.Add(area)

            ' Create a single series
            Dim series As New Series("Residents")
            series.ChartType = SeriesChartType.Column
            series.IsValueShownAsLabel = True
            series("PointWidth") = "0.5" ' Prevent overlap
            Chart1.Series.Add(series)

            ' Add data points
            While dr.Read()
                Dim gender As String = dr("gender").ToString().Trim()
                Dim total As Integer = Convert.ToInt32(dr("total"))
                If gender <> "" Then
                    Chart1.Series("Residents").Points.AddXY(gender, total)
                End If
            End While

            ' Title
            Chart1.Titles.Add("Residents by Gender")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

End Class
