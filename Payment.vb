Imports MySql.Data.MySqlClient

Public Class payment

    '==========================================
    ' FORM LOAD
    '==========================================
    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()

        ' Match certificate types (Purpose)
        cmbType.Items.AddRange(New String() {
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

        ' Who processed it
        cmbProcessed.Items.AddRange(New String() {"Admin", "Treasurer", "Secretary"})

        ' Payment Status
        cmbStatus.Items.AddRange(New String() {"Paid", "Unpaid"})

        ' Default date, time, user
        dtpDate.Value = Date.Now
        lblcreatedat.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        lblupdatedby.Text = Environment.UserName

        ' Auto-generate receipt number
        txtReceiptNo.Text = GenerateReceiptNumber()
        txtReceiptNo.ReadOnly = True
    End Sub


    '==========================================
    ' AUTO-GENERATE RECEIPT NUMBER
    ' Format: RCT-YYYYMMDD-0001 (reset daily)
    '==========================================
    Private Function GenerateReceiptNumber() As String
        Dim receiptNo As String = ""
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            Dim query As String = "SELECT COUNT(*) FROM payment WHERE DATE(PaymentDate) = CURDATE()"
            Using cmd As New MySqlCommand(query, cn)
                Dim countToday As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Dim serial As String = (countToday + 1).ToString("D4")
                receiptNo = "RCT-" & Date.Now.ToString("yyyyMMdd") & "-" & serial
            End Using

        Catch ex As Exception
            MessageBox.Show("Error generating receipt number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        Return receiptNo
    End Function


    '==========================================
    ' SAVE BUTTON - INSERT TO DATABASE
    '==========================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtResidentname.Text = "" Or cmbType.Text = "" Or txtAmount.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Please fill out all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            Dim query As String = "
                INSERT INTO payment
                (Resident_ID, Amount, PaymentDate, PaymentStatus, ReceiptNumber, Purpose, ProcessedBy, CreatedAt, UpdatedBy)
                VALUES
                (@Resident_ID, @Amount, @PaymentDate, @PaymentStatus, @ReceiptNumber, @Purpose, @ProcessedBy, @CreatedAt, @UpdatedBy)
            "

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@Resident_ID", txtResidentname.Text)
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text)
                cmd.Parameters.AddWithValue("@PaymentDate", dtpDate.Value)
                cmd.Parameters.AddWithValue("@PaymentStatus", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@ReceiptNumber", txtReceiptNo.Text)
                cmd.Parameters.AddWithValue("@Purpose", cmbType.Text)
                cmd.Parameters.AddWithValue("@ProcessedBy", cmbProcessed.Text)
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now)
                cmd.Parameters.AddWithValue("@UpdatedBy", lblupdatedby.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Payment successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh for next entry
            txtReceiptNo.Text = GenerateReceiptNumber()
            txtAmount.Clear()
            cmbType.SelectedIndex = -1
            cmbStatus.SelectedIndex = -1
            cmbProcessed.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error saving payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    '==========================================
    ' UPDATE BUTTON - UPDATE CERTIFICATE STATUS
    '==========================================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtResidentname.Text = "" Then
            MessageBox.Show("Please enter a Resident ID to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            ' Update the related certificate record in frmCertificates.vb table
            Dim query As String = "
                UPDATE certifications
                SET remarks = 'Payment Completed',
                    PaymentStatus = 'Paid',
                    updated_at = NOW()
                WHERE resident_id = @Resident_ID
            "

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@Resident_ID", txtResidentname.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Certificate successfully updated after payment.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error updating certificate: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

End Class