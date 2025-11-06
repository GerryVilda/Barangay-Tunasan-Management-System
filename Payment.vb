Imports MySql.Data.MySqlClient

Public Class Payment

    '-----------------------------'
    '   FORM LOAD
    '-----------------------------'
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()

        ' Auto-generate Receipt Number
        GenerateReceiptNumber()

        ' Populate Certificate Type
        cmbpaymentType.Items.AddRange(New String() {
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
        })
    End Sub


    '-----------------------------'
    '   AUTO-FILL AMOUNT & NOTES
    '-----------------------------'
    Private Sub cmbpaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpaymentType.SelectedIndexChanged
        Select Case cmbpaymentType.Text
            Case "Barangay Clearance (Personal Use)"
                txtAmount.Text = "50"
                lblFeeRange.Text = "₱20 – ₱100"
                lblNotes.Text = "Free for first-jobseekers."

            Case "Barangay Clearance (Business)"
                txtAmount.Text = "500"
                lblFeeRange.Text = "₱200 – ₱1,000+"
                lblNotes.Text = "Depends on business size and location."

            Case "Residency Certificate"
                txtAmount.Text = "50"
                lblFeeRange.Text = "₱20 – ₱100"
                lblNotes.Text = "Standard fee in many barangays."

            Case "Indigency Certificate"
                txtAmount.Text = "100"
                lblFeeRange.Text = "₱100"
                lblNotes.Text = "May vary depending on barangay."

            Case "Community Tax Certificate / Cedula"
                txtAmount.Text = "5"
                lblFeeRange.Text = "₱5 basic + additional tax"
                lblNotes.Text = "Depends on income or property."

            Case "Barangay Business Clearance"
                txtAmount.Text = "500"
                lblFeeRange.Text = "₱200 – ₱1,000+"
                lblNotes.Text = "Part of business clearance process."

            Case "Good Moral Certificate"
                txtAmount.Text = "0"
                lblFeeRange.Text = "₱0 – ₱50"
                lblNotes.Text = "Often free or minimal fee."

            Case "Senior Citizen / PWD Certificate"
                txtAmount.Text = "0"
                lblFeeRange.Text = "Free"
                lblNotes.Text = "Usually free or minimal fee."

            Case "Solo Parent Certificate"
                txtAmount.Text = "0"
                lblFeeRange.Text = "₱0 – ₱50"
                lblNotes.Text = "Often free or low-cost."

            Case "Certificate of Occupancy / Lot Clearance"
                txtAmount.Text = "1000"
                lblFeeRange.Text = "₱500 – ₱2,000+"
                lblNotes.Text = "May require inspection."

            Case "Certificate of Barangay Employment"
                txtAmount.Text = "50"
                lblFeeRange.Text = "₱20 – ₱100"
                lblNotes.Text = "Depends on barangay policy."

            Case Else
                txtAmount.Clear()
                lblFeeRange.Text = ""
                lblNotes.Text = ""
        End Select
    End Sub


    '-----------------------------'
    '   GENERATE RECEIPT NUMBER
    '-----------------------------'
    Private Sub GenerateReceiptNumber()
        Try
            ' Format: RCPT-YYYYMMDD-XXXX
            Dim today As String = DateTime.Now.ToString("yyyyMMdd")

            ' Get next count for today
            Dim cmdCount As New MySqlCommand("SELECT COUNT(*) FROM payments WHERE DATE(payment_date) = CURDATE()", cn)
            cn.Open()
            Dim countToday As Integer = Convert.ToInt32(cmdCount.ExecuteScalar()) + 1
            cn.Close()

            txtReceiptNo.Text = $"RCPT-{today}-{countToday.ToString("0000")}"
        Catch ex As Exception
            MessageBox.Show("Error generating receipt number: " & ex.Message)
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    '-----------------------------'
    '   BTN PAID (SAVE + CERTIFICATE)
    '-----------------------------'
    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        If String.IsNullOrWhiteSpace(txtResidentname.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSitio.Text) OrElse
           String.IsNullOrWhiteSpace(cmbpaymentType.Text) OrElse
           String.IsNullOrWhiteSpace(txtAmount.Text) OrElse
           String.IsNullOrWhiteSpace(cmbProcessedby.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim residentId As Integer

            ' Get Resident_ID from residents table
            Using cmdResident As New MySqlCommand("SELECT Resident_ID FROM residents WHERE CONCAT(First_Name,' ',Last_Name)=@name", cn)
                cmdResident.Parameters.AddWithValue("@name", txtResidentname.Text.Trim())
                cn.Open()
                Dim result = cmdResident.ExecuteScalar()
                cn.Close()

                If result Is Nothing Then
                    MessageBox.Show("Resident not found! Please check the name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                residentId = CInt(result)
            End Using

            ' Insert Payment record
            Dim paymentId As Integer
            Using cmdPayment As New MySqlCommand("INSERT INTO payments (resident_id, amount, purpose, payment_date, status, receipt_no, processed_by) 
                                                  VALUES (@resId, @amt, @purpose, @date, 'Paid', @receipt, @processed);
                                                  SELECT LAST_INSERT_ID();", cn)
                cmdPayment.Parameters.AddWithValue("@resId", residentId)
                cmdPayment.Parameters.AddWithValue("@amt", txtAmount.Text)
                cmdPayment.Parameters.AddWithValue("@purpose", cmbpaymentType.Text)
                cmdPayment.Parameters.AddWithValue("@date", dtpDate.Value.ToString("yyyy-MM-dd"))
                cmdPayment.Parameters.AddWithValue("@receipt", txtReceiptNo.Text)
                cmdPayment.Parameters.AddWithValue("@processed", cmbProcessedby.Text)
                cn.Open()
                paymentId = Convert.ToInt32(cmdPayment.ExecuteScalar())
                cn.Close()
            End Using

            ' Display the generated Payment ID
            txtPaymentID.Text = paymentId.ToString()

            ' Insert Certificate record automatically
            Using cmdCert As New MySqlCommand("INSERT INTO certifications (resident_id, type, issued_by, issue_date, remarks) 
                                               VALUES (@resId, @type, @issuedBy, @issueDate, @remarks)", cn)
                cmdCert.Parameters.AddWithValue("@resId", residentId)
                cmdCert.Parameters.AddWithValue("@type", cmbpaymentType.Text)
                cmdCert.Parameters.AddWithValue("@issuedBy", cmbProcessedby.Text)
                cmdCert.Parameters.AddWithValue("@issueDate", DateTime.Now.ToString("yyyy-MM-dd"))
                cmdCert.Parameters.AddWithValue("@remarks", "Certificate issued upon payment.")
                cn.Open()
                cmdCert.ExecuteNonQuery()
                cn.Close()
            End Using

            MessageBox.Show("Payment and certificate saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Generate new receipt for next transaction
            GenerateReceiptNumber()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    '-----------------------------'
    '   BTN UPDATE
    '-----------------------------'
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPaymentID.Text = "" Then
            MessageBox.Show("Enter Payment ID to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using cmdUpdate As New MySqlCommand("UPDATE payments 
                                                 SET amount=@amt, purpose=@purpose, payment_date=@date, 
                                                     receipt_no=@receipt, processed_by=@processed 
                                                 WHERE payment_id=@id", cn)
                cmdUpdate.Parameters.AddWithValue("@amt", txtAmount.Text)
                cmdUpdate.Parameters.AddWithValue("@purpose", cmbpaymentType.Text)
                cmdUpdate.Parameters.AddWithValue("@date", dtpDate.Value.ToString("yyyy-MM-dd"))
                cmdUpdate.Parameters.AddWithValue("@receipt", txtReceiptNo.Text)
                cmdUpdate.Parameters.AddWithValue("@processed", cmbProcessedby.Text)
                cmdUpdate.Parameters.AddWithValue("@id", txtPaymentID.Text)

                cn.Open()
                cmdUpdate.ExecuteNonQuery()
                cn.Close()
            End Using

            MessageBox.Show("Payment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message)
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    '-----------------------------'
    '   CLEAR FORM
    '-----------------------------'
    Private Sub ClearFields()
        txtPaymentID.Clear()
        txtResidentname.Clear()
        cmbSitio.SelectedIndex = -1
        cmbpaymentType.SelectedIndex = -1
        txtAmount.Clear()
        lblFeeRange.Text = ""
        lblNotes.Text = ""
        cmbProcessedby.SelectedIndex = -1
    End Sub

End Class