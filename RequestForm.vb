Imports MySql.Data.MySqlClient

Public Class RequestForm

    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksyon()
        GenerateRequestID()
        txtStatus.Text = "Pending"
        dtpDateRequested.Value = DateTime.Now
    End Sub

    Private Sub GenerateRequestID()
        Try
            Dim cmd As New MySqlCommand("SELECT MAX(Request_ID) FROM request_form", koneksyon)
            Dim result = cmd.ExecuteScalar()
            Dim newID As Integer = If(IsDBNull(result), 1, Convert.ToInt32(result) + 1)
            txtRequestID.Text = "REQ" & newID.ToString("0000")
        Catch ex As Exception
            MessageBox.Show("Error generating Request ID: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validation
            If cmbRequestType.Text = "" Or txtPurpose.Text = "" Then
                MessageBox.Show("Please complete all required fields!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Insert query
            Dim sql As String = "INSERT INTO request_form (Request_Type, Purpose, Date_Requested, Status) 
                                 VALUES (@Request_Type, @Purpose, @Date_Requested, @Status)"
            Dim cmd As New MySqlCommand(sql, koneksyon)
            cmd.Parameters.AddWithValue("@Request_Type", cmbRequestType.Text)
            cmd.Parameters.AddWithValue("@Purpose", txtPurpose.Text)
            cmd.Parameters.AddWithValue("@Date_Requested", dtpDateRequested.Value)
            cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Request successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset form after save
            ClearFields()
            GenerateRequestID()

        Catch ex As Exception
            MessageBox.Show("Error saving request: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        cmbRequestType.Text = ""
        txtPurpose.Clear()
        txtStatus.Text = "Pending"
        dtpDateRequested.Value = DateTime.Now
    End Sub

End Class