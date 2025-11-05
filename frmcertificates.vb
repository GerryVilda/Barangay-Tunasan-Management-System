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

        ' --- Setup DataGridView ---
        dgvcertifications.DataSource = dt
        dgvcertifications.ReadOnly = True
        dgvcertifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcertifications.MultiSelect = False
        dgvcertifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvcertifications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

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

        ' --- Check for Barangay Clearance restrictions ---
        If txtcertificatetype.Text = "Barangay Clearance" Then
            ' Check if resident has a blotter
            If HasBlotterReport(residentID) Then
                MessageBox.Show("Resident has an active blotter report and cannot request a Barangay Clearance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' Check if 6 months have passed since last clearance
            If Not CanRequestAgain(residentID, "Barangay Clearance") Then
                MessageBox.Show("Resident can only request a Barangay Clearance once every 6 months.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
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

    ' --- Check if resident has an active blotter report ---
    Private Function HasBlotterReport(residentID As Integer) As Boolean
        Dim hasBlotter As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim query As String = "SELECT COUNT(*) FROM blotters WHERE resident_id=@resident_id AND status='Active'"
            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@resident_id", residentID)
                Dim result = cmd.ExecuteScalar()
                If Convert.ToInt32(result) > 0 Then hasBlotter = True
            End Using
        Catch
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        Return hasBlotter
    End Function

    ' --- Check 6-month restriction ---
    Private Function CanRequestAgain(residentID As Integer, certType As String) As Boolean
        Dim canRequest As Boolean = True
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim query As String = "SELECT issue_date FROM certifications WHERE resident_id=@resident_id AND type=@type ORDER BY issue_date DESC LIMIT 1"
            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@resident_id", residentID)
                cmd.Parameters.AddWithValue("@type", certType)
                Dim lastIssue = cmd.ExecuteScalar()
                If lastIssue IsNot Nothing Then
                    Dim lastDate As DateTime = Convert.ToDateTime(lastIssue)
                    If DateTime.Now < lastDate.AddMonths(6) Then
                        canRequest = False
                    End If
                End If
            End Using
        Catch
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        Return canRequest
    End Function

    ' --- Generate PDF Certificate ---
    ' --- Generate PDF Certificate (Landscape with Logo and Signature Line) ---
    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        If dgvcertifications.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a certificate first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = dgvcertifications.SelectedRows(0)
        Dim residentName As String = row.Cells("resident_name").Value.ToString()
        Dim certType As String = row.Cells("cert_type").Value.ToString()
        Dim issuedBy As String = row.Cells("issued_by_name").Value.ToString()
        Dim issueDate As DateTime = Convert.ToDateTime(row.Cells("issue_date").Value)
        Dim remarks As String = row.Cells("remarks").Value.ToString()

        ' --- PDF generation ---
        Dim doc As New Document(PageSize.LETTER.Rotate(), 50, 50, 50, 50) ' Landscape orientation
        Try
            Using saveFile As New SaveFileDialog()
                saveFile.Filter = "PDF Files|*.pdf"
                saveFile.FileName = certType.Replace(" ", "_") & "_" & residentName.Replace(" ", "_") & ".pdf"
                If saveFile.ShowDialog() = DialogResult.OK Then
                    Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFile.FileName, FileMode.Create))
                    doc.Open()

                    ' Fonts
                    Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 20, iTextSharp.text.Font.BOLD)
                    Dim subTitleFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.BOLD)
                    Dim bodyFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 12, iTextSharp.text.Font.NORMAL)

                    ' --- Logo ---
                    Try
                        ' Change path to your logo image file
                        Dim logoPath As String = "C:\Users\Gerry Vilda\Downloads\374261351_690019176364048_2445723814474494763_n-removebg-preview.png"
                        If File.Exists(logoPath) Then
                            Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(logoPath)
                            logo.ScaleToFit(100, 100) ' Adjust logo size
                            logo.Alignment = Element.ALIGN_LEFT
                            doc.Add(logo)
                        End If
                    Catch exLogo As Exception
                        MessageBox.Show("Logo could not be loaded: " & exLogo.Message)
                    End Try

                    ' --- Header ---
                    Dim header As New Paragraph("Republic of the Philippines", bodyFont)
                    header.Alignment = Element.ALIGN_CENTER
                    doc.Add(header)

                    Dim brgyHeader As New Paragraph("Barangay Tunasan", bodyFont)
                    brgyHeader.Alignment = Element.ALIGN_CENTER
                    doc.Add(brgyHeader)

                    Dim title As New Paragraph("OFFICIAL CERTIFICATE", titleFont)
                    title.Alignment = Element.ALIGN_CENTER
                    title.SpacingBefore = 20
                    title.SpacingAfter = 20
                    doc.Add(title)

                    ' --- Body ---
                    Dim bodyText As String = $"This is to certify that {residentName} has requested and been issued a {certType}." &
                                             $" This certificate is issued for official purposes and is valid as of {issueDate:MMMM dd, yyyy}." &
                                             $"{If(remarks <> "", Environment.NewLine & "Remarks: " & remarks, "")}"

                    Dim bodyPara As New Paragraph(bodyText, bodyFont)
                    bodyPara.Alignment = Element.ALIGN_JUSTIFIED
                    bodyPara.SpacingBefore = 20
                    bodyPara.SpacingAfter = 40
                    doc.Add(bodyPara)

                    ' --- Signature line ---
                    Dim sigLine As New Paragraph("______________________________", bodyFont)
                    sigLine.Alignment = Element.ALIGN_RIGHT
                    doc.Add(sigLine)

                    Dim sigName As New Paragraph($"Issued By: {issuedBy}", subTitleFont)
                    sigName.Alignment = Element.ALIGN_RIGHT
                    doc.Add(sigName)

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
