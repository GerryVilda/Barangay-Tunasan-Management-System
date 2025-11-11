Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmcertificates

    '========================
    ' LOAD CERTIFICATIONS INTO DATAGRID
    '========================
    Private Sub LoadCertifications()
        Try
            koneksyon()
            Dim query As String = "SELECT ID, Resident_Name, Type, Issued_By, Issued_Date FROM certifications"
            da = New MySqlDataAdapter(query, cn)
            dt = New DataTable()
            da.Fill(dt)
            dgvcertifications.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading certifications: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub frmcertificates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCertifications()
    End Sub

    '========================
    ' WHEN USER CLICKS ON DATAGRID ROW
    '========================
    Private Sub dgvcertifications_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcertifications.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvcertifications.Rows(e.RowIndex)
            txtID.Text = row.Cells("ID").Value.ToString()
            txtresidentname.Text = row.Cells("Resident_Name").Value.ToString()
            txtSearchBy.Text = row.Cells("Type").Value.ToString()
            txtissuedby.Text = row.Cells("Issued_By").Value.ToString()
            txtdate.Text = Convert.ToDateTime(row.Cells("Issued_Date").Value).ToString("yyyy-MM-dd")
        End If
    End Sub

    '========================
    ' GENERATE PDF CERTIFICATE AND REMOVE FROM TABLE
    '========================
    Private Sub btnGeneratecertificate_Click(sender As Object, e As EventArgs) Handles btnGeneratecertificate.Click
        If String.IsNullOrWhiteSpace(txtresidentname.Text) Then
            MessageBox.Show("Please select a certificate from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Choose save location
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "PDF Files (*.pdf)|*.pdf"
            sfd.FileName = $"{txtresidentname.Text}_{txtSearchBy.Text}.pdf"
            If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

            ' Create PDF document
            Dim doc As New Document(PageSize.A4, 50, 50, 50, 50)
            PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
            doc.Open()

            ' Fonts
            Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 24, iTextSharp.text.Font.BOLD)
            Dim subtitleFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD)
            Dim bodyFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.NORMAL)

            ' Add Logo
            Dim logoPath As String = "C:\Users\Gerry Vilda\Downloads\logo.png"
            If File.Exists(logoPath) Then
                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(logoPath)
                logo.Alignment = Element.ALIGN_CENTER
                logo.ScaleAbsolute(100, 100)
                doc.Add(logo)
            End If

            doc.Add(New Paragraph(Environment.NewLine)) ' Space below logo

            ' Title
            Dim title As New Paragraph("OFFICIAL CERTIFICATE", titleFont)
            title.Alignment = Element.ALIGN_CENTER
            doc.Add(title)
            doc.Add(New Paragraph(Environment.NewLine))

            ' Intro text
            Dim intro As New Paragraph("This is to certify that the individual named below has been verified and approved by the Barangay for the issuance of the certificate listed herein.", bodyFont)
            intro.Alignment = Element.ALIGN_CENTER
            doc.Add(intro)
            doc.Add(New Paragraph(Environment.NewLine))

            ' Resident Info
            doc.Add(New Paragraph($"Name: {txtresidentname.Text}", subtitleFont))
            doc.Add(New Paragraph($"Certificate Type: {txtSearchBy.Text}", subtitleFont))
            doc.Add(New Paragraph(Environment.NewLine))

            ' Statement of purpose
            Dim purpose As New Paragraph($"The above-named person is hereby granted this {txtSearchBy.Text} for official purposes as required by law and Barangay regulations.", bodyFont)
            purpose.Alignment = Element.ALIGN_LEFT
            doc.Add(purpose)
            doc.Add(New Paragraph(Environment.NewLine))

            ' Issuer info
            doc.Add(New Paragraph($"Issued By: {txtissuedby.Text}", bodyFont))
            doc.Add(New Paragraph($"Issued Date: {txtdate.Text}", bodyFont))
            doc.Add(New Paragraph(Environment.NewLine & Environment.NewLine))

            ' Closing statement
            Dim closing As New Paragraph("This certificate is valid and recognized by the Barangay Office.", bodyFont)
            closing.Alignment = Element.ALIGN_CENTER
            doc.Add(closing)

            ' Signature line
            doc.Add(New Paragraph(Environment.NewLine & Environment.NewLine))
            doc.Add(New Paragraph("__________________________", bodyFont))
            doc.Add(New Paragraph("Barangay Official", bodyFont))
            doc.Add(New Paragraph(Environment.NewLine))

            doc.Close()

            '========================
            ' DELETE CERTIFICATE FROM DATABASE AFTER GENERATING PDF
            '========================
            Try
                koneksyon()
                Dim deleteQuery As String = "DELETE FROM certifications WHERE ID = @ID"
                cmd = New MySqlCommand(deleteQuery, cn)
                cmd.Parameters.AddWithValue("@ID", txtID.Text)
                cmd.ExecuteNonQuery()

                ' Refresh the DataGridView to remove the deleted certificate
                LoadCertifications()
            Catch ex As Exception
                MessageBox.Show("Error removing certificate from database: " & ex.Message)
            Finally
                cn.Close()
            End Try

            MessageBox.Show($"Certificate generated successfully at: {sfd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating certificate: " & ex.Message)
        End Try
    End Sub

    Private Sub txtissuedby_TextChanged(sender As Object, e As EventArgs) Handles txtissuedby.TextChanged

    End Sub
End Class
