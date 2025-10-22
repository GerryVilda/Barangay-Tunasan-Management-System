Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmCertificates

    Private Sub FrmCertificates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- Initialize Database Connection ---
        Call koneksyon()

        ' Populate ComboBox with certificate types
        CboCertificatesSearchBy.Items.Clear()
        CboCertificatesSearchBy.Items.AddRange(New String() {
            "Barangay Clearance",
            "Residency Certificate",
            "Indigency Certificate",
            "Good Moral Certificate",
            "Barangay Business Clearance",
            "Senior Citizen/PWD Certificate",
            "Community Tax Certificate / Cedula",
            "Solo Parent Certificate",
            "Certificate of Occupancy / Lot Clearance",
            "Certificate of Barangay Employment"
        })
        CboCertificatesSearchBy.SelectedIndex = 0

        ' Load DataGridView
        LoadCertifications()
    End Sub

    ' --- Load Certifications ---
    Private Sub LoadCertifications(Optional filterType As String = "")
        Dim dt As New DataTable()
        Try
            cn.Open()

            Dim query As String = "SELECT c.id, c.resident_id, " &
                                  "CONCAT(r.First_Name, ' ', r.Last_Name) AS resident_name, " &
                                  "COALESCE(c.type,'') AS type, " &
                                  "COALESCE(o.Full_name,'') AS issued_by_name, " &
                                  "COALESCE(c.issue_date,'1900-01-01') AS issue_date, " &
                                  "COALESCE(c.remarks,'') AS remarks " &
                                  "FROM certifications c " &
                                  "INNER JOIN residents r ON c.resident_id = r.Resident_ID " &
                                  "INNER JOIN officials o ON c.issued_by = o.Official_ID"

            If filterType <> "" Then
                query &= " WHERE c.type=@type"
            End If

            Using cmd As New MySqlCommand(query, cn)
                If filterType <> "" Then cmd.Parameters.AddWithValue("@type", filterType)

                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

        Catch ex As Exception
            ' Optional: log the exception somewhere for debugging
        Finally
            cn.Close()
        End Try

        ' Bind DataGridView safely outside Try/Catch
        dgvcertifications.DataSource = dt
        dgvcertifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvcertifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcertifications.MultiSelect = False
    End Sub

    ' --- ComboBox Filter ---
    Private Sub CboCertificatesSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCertificatesSearchBy.SelectedIndexChanged
        LoadCertifications(CboCertificatesSearchBy.Text)
    End Sub

    ' --- Generate PDF ---
    Private Sub BtnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        If dgvcertifications.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a certificate first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = dgvcertifications.SelectedRows(0)
        Dim residentName As String = If(row.Cells("resident_name").Value, "").ToString()
        Dim certType As String = If(row.Cells("type").Value, "").ToString()
        Dim issuedBy As String = If(row.Cells("issued_by_name").Value, "").ToString()
        Dim issueDate As String = ""
        Try
            issueDate = Convert.ToDateTime(row.Cells("issue_date").Value).ToString("MMMM dd, yyyy")
        Catch
            issueDate = "N/A"
        End Try
        Dim remarks As String = If(row.Cells("remarks").Value, "").ToString()

        ' Ask where to save PDF
        Dim sfd As New SaveFileDialog() With {
            .Filter = "PDF files (*.pdf)|*.pdf",
            .FileName = residentName.Replace(" ", "_") & "_" & certType.Replace(" ", "_") & ".pdf"
        }

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document(PageSize.A4, 50, 50, 50, 50)
                PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                ' --- Header with logo ---
                Dim headerTable As New PdfPTable(2) With {.WidthPercentage = 100}
                headerTable.SetWidths(New Single() {1.0F, 3.0F})

                ' Logo path (update with your path)
                Dim logoPath As String = "C:\Users\Gerry Vilda\Downloads\tunasanlogo.jpg"
                If File.Exists(logoPath) Then
                    Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(logoPath)
                    logo.ScaleToFit(80, 80)
                    Dim logoCell As New PdfPCell(logo) With {.Border = Rectangle.NO_BORDER, .HorizontalAlignment = Element.ALIGN_LEFT}
                    headerTable.AddCell(logoCell)
                Else
                    ' Empty cell if logo missing
                    headerTable.AddCell(New PdfPCell(New Phrase("")) With {.Border = Rectangle.NO_BORDER})
                End If

                ' Header Text
                Dim headerText As New Phrase("BARANGAY CERTIFICATE" & vbCrLf & "Barangay Tunasan, Muntinlupa City", FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.BOLD))
                Dim textCell As New PdfPCell(headerText) With {.Border = Rectangle.NO_BORDER, .VerticalAlignment = Element.ALIGN_MIDDLE}
                headerTable.AddCell(textCell)

                doc.Add(headerTable)
                doc.Add(New Paragraph(" "))

                ' --- Body ---
                Dim bodyFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 12, iTextSharp.text.Font.NORMAL)
                Dim nameFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.BOLD)

                doc.Add(New Paragraph("This is to certify that", bodyFont))
                doc.Add(New Paragraph(residentName, nameFont))
                doc.Add(New Paragraph("has been issued a " & certType & " on " & issueDate & ".", bodyFont))
                doc.Add(New Paragraph("Remarks: " & remarks, bodyFont))
                doc.Add(New Paragraph(" "))

                ' --- Issuer ---
                doc.Add(New Paragraph("Issued By:", bodyFont))
                doc.Add(New Paragraph(issuedBy, nameFont))

                doc.Close()
                MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error generating PDF: " & ex.Message)
            End Try
        End If
    End Sub

End Class
