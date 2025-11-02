Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class frmSummary

    ' ==========================================================
    '  FORM LOAD
    ' ==========================================================
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSitios()
        LoadReportSummary() ' Load all existing summaries into the DataGridView
    End Sub

    ' ==========================================================
    '  LOAD SITIOS DIRECTLY FROM RESIDENTS TABLE
    ' ==========================================================
    Private Sub LoadSitios()
        Try
            Call koneksyon()
            cmd = New MySqlCommand("SELECT DISTINCT Sitio FROM residents WHERE Sitio IS NOT NULL AND Sitio <> '' ORDER BY Sitio;", cn)
            dr = cmd.ExecuteReader()

            cmbSitio.Items.Clear()
            While dr.Read()
                cmbSitio.Items.Add(dr("Sitio").ToString())
            End While
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading sitios: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ==========================================================
    '  GENERATE SUMMARY BASED ON RESIDENTS TABLE
    '  AND UPDATE/INSERT INTO reports_summary TABLE
    ' ==========================================================
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cmbSitio.Text = "" Then
            MessageBox.Show("Please select a sitio first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If String.IsNullOrEmpty(LoggedInUser) Then
            MessageBox.Show("No logged-in user found. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Call koneksyon()

            ' Get live residents summary
            Dim query As String =
                "SELECT COUNT(*) AS total_residents, " &
                "SUM(Gender = 'Male') AS male_count, " &
                "SUM(Gender = 'Female') AS female_count, " &
                "SUM(Age <= 13) AS childhood_count, " &
                "SUM(Age BETWEEN 14 AND 59) AS adulthood_count, " &
                "SUM(Age >= 60) AS senior_count " &
                "FROM residents WHERE Sitio = @sitio;"

            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@sitio", cmbSitio.Text)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                lblSitioName.Text = cmbSitio.Text
                lblTotalResidents.Text = dr("total_residents").ToString()
                lblMale.Text = dr("male_count").ToString()
                lblFemale.Text = dr("female_count").ToString()
                lblChildhood.Text = dr("childhood_count").ToString()
                lblAdulthood.Text = dr("adulthood_count").ToString()
                lblSenior.Text = dr("senior_count").ToString()
                lblHouseholds.Text = "N/A"
            Else
                ResetLabels()
            End If
            dr.Close()

            ' =====================================
            '  SAVE/UPDATE SUMMARY IN DATABASE
            ' =====================================
            Dim totalResidents As Integer = Integer.Parse(lblTotalResidents.Text)
            Dim maleCount As Integer = Integer.Parse(lblMale.Text)
            Dim femaleCount As Integer = Integer.Parse(lblFemale.Text)
            Dim childhoodCount As Integer = Integer.Parse(lblChildhood.Text)
            Dim adulthoodCount As Integer = Integer.Parse(lblAdulthood.Text)
            Dim seniorCount As Integer = Integer.Parse(lblSenior.Text)
            Dim user As String = LoggedInUser

            ' Use current month as default date range
            Dim fromDate As Date = New Date(Date.Now.Year, Date.Now.Month, 1)
            Dim toDate As Date = fromDate.AddMonths(1).AddDays(-1)

            ' Check if record exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM reports_summary WHERE sitio_name = @sitio AND report_from = @fromDate AND report_to = @toDate"
            cmd = New MySqlCommand(checkQuery, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@sitio", cmbSitio.Text)
            cmd.Parameters.AddWithValue("@fromDate", fromDate)
            cmd.Parameters.AddWithValue("@toDate", toDate)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                ' Update existing
                Dim updateQuery As String =
                    "UPDATE reports_summary SET total_residents=@totalResidents, male_count=@male, female_count=@female, " &
                    "childhood_count=@childhood, adulthood_count=@adulthood, senior_count=@senior, generated_by=@user, generated_at=NOW() " &
                    "WHERE sitio_name=@sitio AND report_from=@fromDate AND report_to=@toDate"
                cmd = New MySqlCommand(updateQuery, cn)
            Else
                ' Insert new
                Dim insertQuery As String =
                    "INSERT INTO reports_summary (sitio_name, total_residents, male_count, female_count, childhood_count, adulthood_count, senior_count, report_from, report_to, generated_by, generated_at) " &
                    "VALUES (@sitio, @totalResidents, @male, @female, @childhood, @adulthood, @senior, @fromDate, @toDate, @user, NOW())"
                cmd = New MySqlCommand(insertQuery, cn)
            End If

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@sitio", cmbSitio.Text)
            cmd.Parameters.AddWithValue("@totalResidents", totalResidents)
            cmd.Parameters.AddWithValue("@male", maleCount)
            cmd.Parameters.AddWithValue("@female", femaleCount)
            cmd.Parameters.AddWithValue("@childhood", childhoodCount)
            cmd.Parameters.AddWithValue("@adulthood", adulthoodCount)
            cmd.Parameters.AddWithValue("@senior", seniorCount)
            cmd.Parameters.AddWithValue("@fromDate", fromDate)
            cmd.Parameters.AddWithValue("@toDate", toDate)
            cmd.Parameters.AddWithValue("@user", user)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Report generated and summary saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView
            LoadReportSummary()

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ==========================================================
    '  RESET LABELS
    ' ==========================================================
    Private Sub ResetLabels()
        lblSitioName.Text = "0"
        lblTotalResidents.Text = "0"
        lblHouseholds.Text = "0"
        lblMale.Text = "0"
        lblFemale.Text = "0"
        lblChildhood.Text = "0"
        lblAdulthood.Text = "0"
        lblSenior.Text = "0"
    End Sub

    ' ==========================================================
    '  LOAD REPORT SUMMARY INTO DATAGRIDVIEW
    ' ==========================================================
    Private Sub LoadReportSummary(Optional fromDate As Date? = Nothing, Optional toDate As Date? = Nothing)
        Try
            Call koneksyon()
            Dim query As String = "SELECT sitio_name AS Sitio, total_residents AS TotalResidents, male_count AS Male, female_count AS Female, " &
                                  "childhood_count AS Children, adulthood_count AS Adults, senior_count AS Seniors, report_from AS FromDate, report_to AS ToDate, generated_by AS GeneratedBy, generated_at AS GeneratedAt " &
                                  "FROM reports_summary "

            ' Filter by date if parameters are passed
            If fromDate.HasValue AndAlso toDate.HasValue Then
                query &= "WHERE report_from <= @toDate AND report_to >= @fromDate "
            End If

            query &= "ORDER BY report_from DESC;"

            Dim cmdAdapter As New MySqlCommand(query, cn)
            If fromDate.HasValue AndAlso toDate.HasValue Then
                cmdAdapter.Parameters.AddWithValue("@fromDate", fromDate.Value)
                cmdAdapter.Parameters.AddWithValue("@toDate", toDate.Value)
            End If

            Dim adapter As New MySqlDataAdapter(cmdAdapter)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dtgreportssummary.DataSource = dt
            dtgreportssummary.AutoResizeColumns()

        Catch ex As Exception
            MessageBox.Show("Error loading report summary: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ==========================================================
    '  FILTER BUTTON CLICK
    ' ==========================================================
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        ' Assuming you have DateTimePickers: dtpFrom, dtpTo
        Dim fromDate As Date = dtpfrom.Value.Date
        Dim toDate As Date = dtpto.Value.Date
        LoadReportSummary(fromDate, toDate)
    End Sub

    ' ==========================================================
    '  EXPORT TO PDF
    ' ==========================================================
    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        If dtgreportssummary.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            ' Ask user where to save the PDF
            Using sfd As New SaveFileDialog()
                sfd.Filter = "PDF files (*.pdf)|*.pdf"
                sfd.FileName = "ReportSummary_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"

                If sfd.ShowDialog() <> DialogResult.OK Then Return

                ' Create the PDF document
                Dim pdfDoc As New Document(PageSize.A4, 10, 10, 20, 20)
                PdfWriter.GetInstance(pdfDoc, New FileStream(sfd.FileName, FileMode.Create))
                pdfDoc.Open()

                ' Add a title
                Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.BOLD)
                Dim title As New Paragraph("Report Summary", titleFont) With {
                    .Alignment = Element.ALIGN_CENTER,
                    .SpacingAfter = 15
                }
                pdfDoc.Add(title)

                ' Add summary labels at the top
                Dim summaryFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 12, iTextSharp.text.Font.NORMAL)
                Dim summaryTextStr As String =
                    $"Sitio: {lblSitioName.Text}" & vbCrLf &
                    $"Total Residents: {lblTotalResidents.Text}" & vbCrLf &
                    $"Households: {lblHouseholds.Text}" & vbCrLf &
                    $"Male: {lblMale.Text}, Female: {lblFemale.Text}" & vbCrLf &
                    $"Children: {lblChildhood.Text}, Adults: {lblAdulthood.Text}, Seniors: {lblSenior.Text}" & vbCrLf &
                    $"Generated By: {LoggedInUser}" & vbCrLf &
                    $"Generated On: {DateTime.Now:MM/dd/yyyy HH:mm}"

                Dim summaryPara As New Paragraph(summaryTextStr, summaryFont) With {
                    .SpacingAfter = 10
                }
                pdfDoc.Add(summaryPara)

                ' Add a separator line
                pdfDoc.Add(New Paragraph(" "))

                ' Create PDF table with same columns as DataGridView
                Dim pdfTable As New PdfPTable(dtgreportssummary.Columns.Count) With {
                    .WidthPercentage = 100
                }

                ' Add headers
                For Each column As DataGridViewColumn In dtgreportssummary.Columns
                    Dim cell As New PdfPCell(New Phrase(column.HeaderText)) With {
                        .BackgroundColor = BaseColor.LIGHT_GRAY
                    }
                    pdfTable.AddCell(cell)
                Next

                ' Add data rows
                For Each row As DataGridViewRow In dtgreportssummary.Rows
                    If row.IsNewRow Then Continue For
                    For Each cell As DataGridViewCell In row.Cells
                        pdfTable.AddCell(If(cell.Value?.ToString(), ""))
                    Next
                Next

                pdfDoc.Add(pdfTable)
                pdfDoc.Close()
            End Using

            MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
