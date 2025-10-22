Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class frmSummary

    Private Sub LoadResidentsByGender()
        Try
            Call koneksyon()

            Dim query As String = "SELECT gender, COUNT(*) AS total FROM residents GROUP BY gender"
            Dim cmd As New MySqlCommand(query, cn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Clear previous chart data
            Chart1.Series.Clear()
            Chart1.Titles.Clear()
            Chart1.ChartAreas.Clear()

            ' Setup chart area
            Dim area As New ChartArea()
            area.AxisX.Title = "Gender"
            area.AxisY.Title = "Number of Residents"
            area.AxisX.Interval = 1
            Chart1.ChartAreas.Add(area)

            ' Create series for Male and Female
            Dim seriesMale As New Series("Male")
            seriesMale.ChartType = SeriesChartType.Column
            seriesMale.Color = Color.Blue
            seriesMale.IsValueShownAsLabel = True
            seriesMale("PointWidth") = "0.4"
            Chart1.Series.Add(seriesMale)

            Dim seriesFemale As New Series("Female")
            seriesFemale.ChartType = SeriesChartType.Column
            seriesFemale.Color = Color.Pink
            seriesFemale.IsValueShownAsLabel = True
            seriesFemale("PointWidth") = "0.4"
            Chart1.Series.Add(seriesFemale)

            ' Add data points
            While dr.Read()
                Dim gender As String = dr("gender").ToString().Trim()
                Dim total As Integer = Convert.ToInt32(dr("total"))

                If gender = "Male" Then
                    seriesMale.Points.AddXY("Male", total)
                    seriesFemale.Points.AddXY("Male", 0) ' keep alignment
                ElseIf gender = "Female" Then
                    seriesFemale.Points.AddXY("Female", total)
                    seriesMale.Points.AddXY("Female", 0) ' keep alignment
                End If
            End While

            ' Chart title
            Chart1.Titles.Add("Residents by Gender")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub


End Class
