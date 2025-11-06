Imports MySql.Data.MySqlClient

Public Class payment



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate fields
        If txtResidentname.Text = "" Or cmbPaymentType.Text = "" Or txtAmount.Text = "" Or cmbStatus.Text = "" Or cmbProcessedBy.Text = "" Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Get resident_id from typed name
            Dim residentId As Integer
            Dim cmdResident As New MySqlCommand("SELECT Resident_ID FROM residents WHERE CONCAT(First_Name,' ',Last_Name)=@name", cn)
            cmdResident.Parameters.AddWithValue("@name", txtResidentname.Text.Trim())

            cn.Open()
            Dim result = cmdResident.ExecuteScalar()
            If result Is Nothing Then
                MessageBox.Show("Resident not found! Please check the name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cn.Close()
                Exit Sub
            End If
            residentId = CInt(result)
            cn.Close()

            ' Insert payment
            Dim cmdPayment As New MySqlCommand("INSERT INTO payments (resident_id, amount, purpose, payment_date, status, receipt_no, processed_by) VALUES (@resId, @amt, @purpose, @date, @status, @receipt, @processed)", cn)
            cmdPayment.Parameters.AddWithValue("@resId", residentId)
            cmdPayment.Parameters.AddWithValue("@amt", txtAmount.Text)
            cmdPayment.Parameters.AddWithValue("@purpose", cmbPaymentType.Text)
            cmdPayment.Parameters.AddWithValue("@date", dtpDate.Value.ToString("yyyy-MM-dd"))
            cmdPayment.Parameters.AddWithValue("@status", cmbStatus.Text)
            cmdPayment.Parameters.AddWithValue("@receipt", txtReceiptNo.Text)
            cmdPayment.Parameters.AddWithValue("@processed", cmbProcessedBy.Text)

            cn.Open()
            cmdPayment.ExecuteNonQuery()
            cn.Close()

            ' Insert into certifications if Paid
            If cmbStatus.Text = "Paid" Then
                Dim cmdCert As New MySqlCommand("INSERT INTO certifications (resident_id, type, issued_by, issue_date, remarks) VALUES (@resId, @type, @issuedBy, @issueDate, @remarks)", cn)
                cmdCert.Parameters.AddWithValue("@resId", residentId)
                cmdCert.Parameters.AddWithValue("@type", cmbPaymentType.Text)
                cmdCert.Parameters.AddWithValue("@issuedBy", cmbProcessedBy.Text)
                cmdCert.Parameters.AddWithValue("@issueDate", DateTime.Now.ToString("yyyy-MM-dd"))
                cmdCert.Parameters.AddWithValue("@remarks", "Issued after payment")
                cn.Open()
                cmdCert.ExecuteNonQuery()
                cn.Close()
            End If

            MessageBox.Show("Payment successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show("Error saving payment: " & ex.Message)
            cn.Close()
        End Try
    End Sub

End Class