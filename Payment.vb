Imports MySql.Data.MySqlClient

Public Class Payment

    ' Current logged-in user (set this dynamically at login)
    Private currentUser As String = "Admin" ' Replace dynamically if needed

    '======================
    ' FORM LOAD
    '======================
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set date to current date and make read-only
        dtpDate.Value = Date.Now
        dtpDate.Enabled = False

        LoadPendingRequests()
        LoadCertificateTypes()
        LoadStatusOptions()
        LoadTransactionHistory() ' Load history on form load
    End Sub

    '======================
    ' LOAD PENDING REQUESTS WITH FEE
    '======================
    Private Sub LoadPendingRequests()
        Try
            koneksyon()
            Dim query As String = "
                SELECT 
                    r.Request_ID, 
                    r.Resident_ID, 
                    CONCAT(res.First_Name,' ',res.Last_Name) AS Resident_Name, 
                    res.Sitio, 
                    r.Request_Type, 
                    r.Purpose, 
                    r.Date_Requested, 
                    r.Status,
                    f.Amount AS Fee
                FROM request_form r
                JOIN residents res ON r.Resident_ID = res.Resident_ID
                LEFT JOIN fees f ON r.Request_Type = f.Certificate_Type
                WHERE r.Status = 'Pending'
            "
            da = New MySqlDataAdapter(query, cn)
            dt = New DataTable()
            da.Fill(dt)
            dtgforpayments.DataSource = dt

            ' Safely select first row
            If dt.Rows.Count > 0 AndAlso dtgforpayments.Rows.Count > 0 Then
                dtgforpayments.ClearSelection()
                dtgforpayments.Rows(0).Selected = True
                dtgforpayments_CellClick(Me, New DataGridViewCellEventArgs(0, 0))
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading pending requests: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    '======================
    ' LOAD CERTIFICATE TYPES
    '======================
    Private Sub LoadCertificateTypes()
        Try
            koneksyon()
            Dim query As String = "SELECT Certificate_Type FROM fees"
            cmd = New MySqlCommand(query, cn)
            dr = cmd.ExecuteReader()
            cmbcertificateType.Items.Clear()
            While dr.Read()
                Dim cert As Object = dr("Certificate_Type")
                If cert IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(cert.ToString()) Then
                    cmbcertificateType.Items.Add(cert.ToString())
                End If
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading certificate types: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    '======================
    ' LOAD STATUS OPTIONS
    '======================
    Private Sub LoadStatusOptions()
        cbostatus.Items.Clear()
        cbostatus.Items.Add("Pending")
        cbostatus.Items.Add("Paid")
        cbostatus.Items.Add("Cancelled")
        cbostatus.SelectedIndex = 0
    End Sub

    '======================
    ' DATA GRID ROW CLICK
    '======================
    Private Sub dtgforpayments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgforpayments.CellClick
        If e.RowIndex >= 0 AndAlso dtgforpayments.Rows.Count > 0 Then
            Dim row As DataGridViewRow = dtgforpayments.Rows(e.RowIndex)
            txtrequestid.Text = If(row.Cells("Request_ID").Value?.ToString(), "")
            txtResidentid.Text = If(row.Cells("Resident_ID").Value?.ToString(), "")
            txtresidentname.Text = If(row.Cells("Resident_Name").Value?.ToString(), "")
            cmbSitio.Text = If(row.Cells("Sitio").Value?.ToString(), "")
            cmbcertificateType.Text = If(row.Cells("Request_Type").Value?.ToString(), "")
            txtpurpose.Text = If(row.Cells("Purpose").Value?.ToString(), "")
            cbostatus.Text = If(row.Cells("Status").Value?.ToString(), "Pending")

            ' Auto-fill fee from join or fallback to fees table
            If row.Cells("Fee").Value IsNot DBNull.Value AndAlso row.Cells("Fee").Value IsNot Nothing Then
                txtfee.Text = row.Cells("Fee").Value.ToString()
                txtAmount.Text = row.Cells("Fee").Value.ToString()
            ElseIf Not String.IsNullOrEmpty(cmbcertificateType.Text) Then
                LoadFee(cmbcertificateType.Text)
            Else
                txtfee.Clear()
                txtAmount.Clear()
            End If
        End If
    End Sub

    '======================
    ' CERTIFICATE TYPE CHANGED
    '======================
    Private Sub cmbcertificateType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcertificateType.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cmbcertificateType.Text) Then
            LoadFee(cmbcertificateType.Text)
        End If
    End Sub

    '======================
    ' LOAD FEE FROM FEES TABLE
    '======================
    Private Sub LoadFee(certificateType As String)
        Try
            koneksyon()
            Dim query As String = "SELECT Amount FROM fees WHERE Certificate_Type = @Certificate_Type LIMIT 1"
            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@Certificate_Type", certificateType)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                txtfee.Text = result.ToString()
                txtAmount.Text = result.ToString()
            Else
                txtfee.Clear()
                txtAmount.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading fee: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    '======================
    ' PROCESS PAYMENT
    '======================
    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        If String.IsNullOrWhiteSpace(txtResidentid.Text) OrElse
           String.IsNullOrWhiteSpace(cmbcertificateType.Text) OrElse
           String.IsNullOrWhiteSpace(txtfee.Text) Then
            MessageBox.Show("Please select a request and ensure all fields are filled.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            koneksyon()

            ' Insert payment
            Dim insertPayment As String = "
                INSERT INTO payment (Resident_ID, Sitio, Certificate_Type, Fee_Range, Amount, Date, Receipt_Number, Processed_By)
                VALUES (@Resident_ID, @Sitio, @Certificate_Type, @Fee_Range, @Amount, @Date, @Receipt_Number, @Processed_By)"
            cmd = New MySqlCommand(insertPayment, cn)
            cmd.Parameters.AddWithValue("@Resident_ID", txtResidentid.Text)
            cmd.Parameters.AddWithValue("@Sitio", cmbSitio.Text)
            cmd.Parameters.AddWithValue("@Certificate_Type", cmbcertificateType.Text)
            cmd.Parameters.AddWithValue("@Fee_Range", txtfee.Text)
            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text)
            cmd.Parameters.AddWithValue("@Date", Date.Now)
            cmd.Parameters.AddWithValue("@Receipt_Number", GenerateReceiptNumber())
            cmd.Parameters.AddWithValue("@Processed_By", currentUser)
            cmd.ExecuteNonQuery()

            ' Update request status
            Dim updateRequest As String = "UPDATE request_form SET Status = 'Paid' WHERE Request_ID = @Request_ID"
            cmd = New MySqlCommand(updateRequest, cn)
            cmd.Parameters.AddWithValue("@Request_ID", txtrequestid.Text)
            cmd.ExecuteNonQuery()

            ' Insert certification record
            Dim insertCert As String = "
                INSERT INTO certifications (Resident_Name, Type, Issued_By, Issued_Date, Remarks)
                VALUES (@Resident_Name, @Type, @Issued_By, @Issued_Date, @Remarks)"
            cmd = New MySqlCommand(insertCert, cn)
            cmd.Parameters.AddWithValue("@Resident_Name", txtresidentname.Text)
            cmd.Parameters.AddWithValue("@Type", cmbcertificateType.Text)
            cmd.Parameters.AddWithValue("@Issued_By", currentUser)
            cmd.Parameters.AddWithValue("@Issued_Date", Date.Now)
            cmd.Parameters.AddWithValue("@Remarks", "Paid & ready for printing")
            cmd.ExecuteNonQuery()

            MessageBox.Show("Payment completed! Certificate is ready for printing.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearFields()
            LoadPendingRequests()
            LoadTransactionHistory() ' Refresh history after payment

        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    '======================
    ' CLEAR ALL INPUTS
    '======================
    Private Sub ClearFields()
        txtrequestid.Clear()
        txtResidentid.Clear()
        txtresidentname.Clear()
        cmbSitio.SelectedIndex = -1
        cmbcertificateType.SelectedIndex = -1
        txtpurpose.Clear()
        cbostatus.SelectedIndex = 0
        txtfee.Clear()
        txtAmount.Clear()
        dtpDate.Value = Date.Now
    End Sub

    '======================
    ' GENERATE RECEIPT NUMBER
    '======================
    Private Function GenerateReceiptNumber() As String
        Return "RCPT-" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    '======================
    ' LOAD TRANSACTION HISTORY
    '======================
    Private Sub LoadTransactionHistory()
        Try
            koneksyon()
            Dim query As String = "
            SELECT 
            p.Payment_ID,
            p.Resident_ID,
            CONCAT(res.First_Name, ' ', res.Last_Name) AS Resident_Name,
            p.Sitio,
            p.Certificate_Type,
            p.Fee_Range,
            p.Amount,
            p.Date AS Payment_Date,
            p.Receipt_Number,
            p.Processed_By
            FROM payment p
            JOIN residents res ON p.Resident_ID = res.Resident_ID
            ORDER BY p.Date DESC


        "
            da = New MySqlDataAdapter(query, cn)
            dt = New DataTable()
            da.Fill(dt)
            dgvtransactions_history.DataSource = dt

            ' Make DataGridView read-only
            dgvtransactions_history.ReadOnly = True

            ' Format columns nicely
            dgvtransactions_history.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvtransactions_history.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvtransactions_history.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvtransactions_history.MultiSelect = False

        Catch ex As Exception
            MessageBox.Show("Error loading transaction history: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    Private Sub dgvtransactions_history_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtransactions_history.CellContentClick
        ' Optional: Handle clicks if needed
    End Sub

End Class
