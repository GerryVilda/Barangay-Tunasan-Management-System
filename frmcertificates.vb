Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmcertificates

    Private Sub FrmCertificates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()

        ' Certificate Types
        Dim certificateTypes() As String = {
        "Barangay Clearance (Personal Use)",
        "Barangay Clearance (Business)",
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

        ' Populate ComboBoxes
        CboCertificatesSearchBy.Items.Clear()
        CboCertificatesSearchBy.Items.AddRange(certificateTypes)
        CboCertificatesSearchBy.SelectedIndex = 0

        cmbcertificatetype.Items.Clear()
        cmbcertificatetype.Items.AddRange(certificateTypes)
        cmbcertificatetype.Text = certificateTypes(0)

        txtID.Clear()
        txtresidentId.Clear()
        txtissuedby.Clear()
        txtremarks.Clear()
        dtpissueddate.Value = Date.Today

        LoadCertifications()
    End Sub

    ' --- Load Certifications ---
    Private Sub LoadCertifications(Optional filterType As String = "")
        Dim dt As New DataTable()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            Dim query As String = "SELECT c.id, c.resident_id, " &
                                  "COALESCE(c.type,'') AS cert_type, " &
                                  "COALESCE(o.Full_name,'') AS issued_by_name, " &
                                  "COALESCE(c.issue_date,'1900-01-01') AS issue_date, " &
                                  "COALESCE(c.remarks,'') AS remarks " &
                                  "FROM certifications c " &
                                  "INNER JOIN officials o ON c.issued_by = o.Official_ID"

            If filterType <> "" Then query &= " WHERE c.type=@type"

            Using cmd As New MySqlCommand(query, cn)
                If filterType <> "" Then cmd.Parameters.AddWithValue("@type", filterType)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading certifications: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        dgvcertifications.DataSource = dt
        dgvcertifications.ReadOnly = True
        dgvcertifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcertifications.MultiSelect = False
        dgvcertifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvcertifications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        If dgvcertifications.Rows.Count > 0 Then dgvcertifications.ClearSelection()
    End Sub

    Private Sub CboCertificatesSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCertificatesSearchBy.SelectedIndexChanged
        LoadCertifications(CboCertificatesSearchBy.Text)
    End Sub

    Private Sub dgvcertifications_SelectionChanged(sender As Object, e As EventArgs) Handles dgvcertifications.SelectionChanged
        If dgvcertifications.SelectedRows.Count = 0 Then
            txtID.Clear()
            txtresidentId.Clear()
            cmbcertificatetype.Text = CboCertificatesSearchBy.Text
            txtissuedby.Clear()
            txtremarks.Clear()
            dtpissueddate.Value = Date.Today
            Return
        End If

        Dim row As DataGridViewRow = dgvcertifications.SelectedRows(0)
        txtID.Text = row.Cells("id").Value.ToString()
        txtresidentId.Text = row.Cells("resident_id").Value.ToString()
        cmbcertificatetype.Text = row.Cells("cert_type").Value.ToString()
        txtissuedby.Text = row.Cells("issued_by_name").Value.ToString()
        Try
            dtpissueddate.Value = Convert.ToDateTime(row.Cells("issue_date").Value)
        Catch
            dtpissueddate.Value = Date.Today
        End Try
        txtremarks.Text = row.Cells("remarks").Value.ToString()
    End Sub

    ' --- Check if Resident has Paid ---
    Private Function HasCompletedPayment(residentID As Integer) As Boolean
        Dim isPaid As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim query As String = "SELECT COUNT(*) FROM payment WHERE Resident_ID=@residentID AND PaymentStatus='Paid'"
            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@residentID", residentID)
                Dim result = Convert.ToInt32(cmd.ExecuteScalar())
                If result > 0 Then isPaid = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking payment: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        Return isPaid
    End Function

    ' --- Generate PDF Certificate ---
    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        If dgvcertifications.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a certificate first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = dgvcertifications.SelectedRows(0)
        Dim certType As String = row.Cells("cert_type").Value.ToString()
        Dim issuedBy As String = row.Cells("issued_by_name").Value.ToString()
        Dim issueDate As DateTime = Convert.ToDateTime(row.Cells("issue_date").Value)
        Dim remarks As String = row.Cells("remarks").Value.ToString()
        Dim residentID As Integer = Convert.ToInt32(row.Cells("resident_id").Value)

        ' --- PAYMENT VALIDATION ---
        If Not HasCompletedPayment(residentID) Then
            MessageBox.Show("⚠️ The resident must proceed to PAYMENT first before generating a certificate PDF.", "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Generate PDF ---
        Dim doc As New Document(PageSize.LETTER.Rotate(), 50, 50, 50, 50)
        Try
            Using saveFile As New SaveFileDialog()
                saveFile.Filter = "PDF Files|*.pdf"
                saveFile.FileName = certType.Replace(" ", "_") & "_Resident_" & residentID & ".pdf"
                If saveFile.ShowDialog() = DialogResult.OK Then
                    Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFile.FileName, FileMode.Create))
                    doc.Open()

                    Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 20, iTextSharp.text.Font.BOLD)
                    Dim subTitleFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.BOLD)
                    Dim bodyFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 12, iTextSharp.text.Font.NORMAL)

                    ' Add Barangay Logo
                    Try
                        Dim logoPath As String = "C:\Users\Public\Pictures\barangay_logo.png"
                        If File.Exists(logoPath) Then
                            Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(logoPath)
                            logo.ScaleToFit(100, 100)
                            logo.Alignment = Element.ALIGN_LEFT
                            doc.Add(logo)
                        End If
                    Catch
                    End Try

                    doc.Add(New Paragraph("Republic of the Philippines", bodyFont) With {.Alignment = Element.ALIGN_CENTER})
                    doc.Add(New Paragraph("Barangay Tunasan", bodyFont) With {.Alignment = Element.ALIGN_CENTER})
                    doc.Add(New Paragraph(certType.ToUpper(), titleFont) With {.Alignment = Element.ALIGN_CENTER, .SpacingBefore = 20, .SpacingAfter = 20})

                    Dim bodyText As String =
                        $"This is to certify that Resident ID {residentID} has been issued a {certType}. " &
                        $"This certificate is valid as of {issueDate:MMMM dd, yyyy}. " &
                        $"{If(remarks <> "", Environment.NewLine & "Remarks: " & remarks, "")}"

                    doc.Add(New Paragraph(bodyText, bodyFont) With {.Alignment = Element.ALIGN_JUSTIFIED, .SpacingBefore = 20, .SpacingAfter = 40})
                    doc.Add(New Paragraph("______________________________", bodyFont) With {.Alignment = Element.ALIGN_RIGHT})
                    doc.Add(New Paragraph($"Issued By: {issuedBy}", bodyFont) With {.Alignment = Element.ALIGN_RIGHT})

                    MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message)
        Finally
            doc.Close()
        End Try
    End Sub

End Class