Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmCertificates

    Private Sub FrmCertificates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- Initialize Database Connection ---
        Call koneksyon()

        ' Populate ComboBoxes
        Dim certificateTypes() As String = {
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
        }

        ' Search filter ComboBox
        CboCertificatesSearchBy.Items.Clear()
        CboCertificatesSearchBy.Items.AddRange(certificateTypes)
        CboCertificatesSearchBy.SelectedIndex = 0 ' Default selection

        ' Certificate Type ComboBox
        txtcertificatetype.Items.Clear()
        txtcertificatetype.Items.AddRange(certificateTypes)
        txtcertificatetype.Text = certificateTypes(0) ' Default displayed value

        ' Clear textboxes initially
        txtresident_name.Clear()
        txtissuedby.Clear()
        txtremarks.Clear()

        ' Load DataGridView
        LoadCertifications()
    End Sub

    ' --- Load Certifications ---
    Private Sub LoadCertifications(Optional filterType As String = "")
        Dim dt As New DataTable()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            Dim query As String = "SELECT c.id, c.resident_id, " &
                                  "CONCAT(r.First_Name, ' ', r.Last_Name) AS resident_name, " &
                                  "COALESCE(c.type,'') AS cert_type, " &
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
            MessageBox.Show("Error loading certifications: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        dgvcertifications.DataSource = dt
        dgvcertifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvcertifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcertifications.MultiSelect = False

        ' Ensure no row is selected by default
        If dgvcertifications.Rows.Count > 0 Then
            dgvcertifications.ClearSelection()
        End If

        ' Optional: rename headers
        If dgvcertifications.Columns.Contains("cert_type") Then
            dgvcertifications.Columns("cert_type").HeaderText = "Certificate Type"
        End If
    End Sub

    ' --- ComboBox Filter ---
    Private Sub CboCertificatesSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCertificatesSearchBy.SelectedIndexChanged
        LoadCertifications(CboCertificatesSearchBy.Text)
    End Sub

    ' --- Populate textboxes when a row is selected ---
    Private Sub dgvcertifications_SelectionChanged(sender As Object, e As EventArgs) Handles dgvcertifications.SelectionChanged
        If dgvcertifications.SelectedRows.Count = 0 Then
            txtresident_name.Clear()
            txtcertificatetype.Text = CboCertificatesSearchBy.Text
            txtissuedby.Clear()
            txtremarks.Clear()
            dtpissueddate.Value = Date.Today
            Return
        End If

        Dim row As DataGridViewRow = dgvcertifications.SelectedRows(0)

        txtresident_name.Text = If(row.Cells("resident_name").Value, "").ToString()
        txtcertificatetype.Text = If(row.Cells("cert_type").Value, "").ToString()
        txtissuedby.Text = If(row.Cells("issued_by_name").Value, "").ToString()

        ' Format date safely
        Try
            dtpissueddate.Value = Convert.ToDateTime(row.Cells("issue_date").Value)
        Catch
            dtpissueddate.Value = Date.Today
        End Try

        txtremarks.Text = If(row.Cells("remarks").Value, "").ToString()
    End Sub

    ' --- Add New Certificate ---
    ' --- Add New Certificate ---
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtresident_name.Text = "" Or txtcertificatetype.Text = "" Or txtissuedby.Text = "" Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim residentID As Integer = GetResidentID(txtresident_name.Text)
        Dim officialID As Integer = GetOfficialID(txtissuedby.Text)

        If residentID = 0 Or officialID = 0 Then
            MessageBox.Show("Resident or official not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If cn Is Nothing Then Call koneksyon()
            If cn.State <> ConnectionState.Open Then cn.Open()

            Dim query As String = "INSERT INTO certifications (resident_id, type, issued_by, issue_date, remarks) " &
                              "VALUES (@resident_id, @type, @issued_by, @issue_date, @remarks)"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@resident_id", residentID)
                cmd.Parameters.AddWithValue("@type", txtcertificatetype.Text)
                cmd.Parameters.AddWithValue("@issued_by", officialID)
                cmd.Parameters.AddWithValue("@issue_date", dtpissueddate.Value)
                cmd.Parameters.AddWithValue("@remarks", txtremarks.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Certificate added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCertifications()
        Catch ex As Exception
            MessageBox.Show("Error adding certificate: " & ex.Message)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    ' --- Update Selected Certificate ---
    ' --- Update Selected Certificate ---
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If dgvcertifications.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a certificate to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvcertifications.SelectedRows(0).Cells("id").Value)
        Dim residentID As Integer = GetResidentID(txtresident_name.Text)
        Dim officialID As Integer = GetOfficialID(txtissuedby.Text)

        If residentID = 0 Or officialID = 0 Then
            MessageBox.Show("Resident or official not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If cn Is Nothing Then Call koneksyon()
            If cn.State <> ConnectionState.Open Then cn.Open()

            Dim query As String = "UPDATE certifications SET resident_id=@resident_id, type=@type, issued_by=@issued_by, issue_date=@issue_date, remarks=@remarks WHERE id=@id"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@resident_id", residentID)
                cmd.Parameters.AddWithValue("@type", txtcertificatetype.Text)
                cmd.Parameters.AddWithValue("@issued_by", officialID)
                cmd.Parameters.AddWithValue("@issue_date", dtpissueddate.Value)
                cmd.Parameters.AddWithValue("@remarks", txtremarks.Text)
                cmd.Parameters.AddWithValue("@id", selectedID)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Certificate updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCertifications()
        Catch ex As Exception
            MessageBox.Show("Error updating certificate: " & ex.Message)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    ' --- Delete Selected Certificate ---
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvcertifications.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a certificate to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvcertifications.SelectedRows(0).Cells("id").Value)

        If MessageBox.Show("Are you sure you want to delete this certificate?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                If cn.State = ConnectionState.Closed Then cn.Open()
                Dim query As String = "DELETE FROM certifications WHERE id=@id"

                Using cmd As New MySqlCommand(query, cn)
                    cmd.Parameters.AddWithValue("@id", selectedID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Certificate deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadCertifications()
            Catch ex As Exception
                MessageBox.Show("Error deleting certificate: " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()
            End Try
        End If
    End Sub

    ' --- Helper Functions ---
    Private Function GetResidentID(fullName As String) As Integer
        Dim names() As String = fullName.Split(" "c)
        Dim firstName As String = names(0)
        Dim lastName As String = If(names.Length > 1, names(1), "")
        Dim id As Integer = 0

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim query As String = "SELECT Resident_ID FROM residents WHERE First_Name=@first AND Last_Name=@last LIMIT 1"
            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@first", firstName)
                cmd.Parameters.AddWithValue("@last", lastName)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then id = Convert.ToInt32(result)
            End Using
        Catch
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        Return id
    End Function

    Private Function GetOfficialID(fullName As String) As Integer
        Dim id As Integer = 0
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim query As String = "SELECT Official_ID FROM officials WHERE Full_name=@name LIMIT 1"
            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@name", fullName)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then id = Convert.ToInt32(result)
            End Using
        Catch
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        Return id
    End Function

    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        If dgvcertifications.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a certificate first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = dgvcertifications.SelectedRows(0)
        Dim residentName As String = If(row.Cells("resident_name").Value, "").ToString()
        Dim certType As String = If(row.Cells("cert_type").Value, "").ToString()
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

                ' Logo path
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
