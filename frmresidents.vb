Imports MySql.Data.MySqlClient

Public Class frmresidents

    Private Sub frmresidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Set valid birthdate range (no future dates)
        dtpbirthdate.MinDate = New Date(1900, 1, 1)
        dtpbirthdate.MaxDate = DateTime.Today

        ' ✅ Make DataGridView read-only and auto-adjust columns
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        ' ✅ Load residents into the grid
        LoadResidents()
    End Sub

    ' ✅ Load all residents into DataGridView
    Private Sub LoadResidents()
        Try
            Call koneksyon()
            Dim sql As String = "SELECT Resident_ID, First_Name, Last_Name, Age, Gender, Birthdate, Sitio, Status, Date_Registered FROM residents ORDER BY Resident_ID DESC"
            Dim da As New MySqlDataAdapter(sql, cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt

            DataGridView1.AutoResizeColumns()
            DataGridView1.AutoResizeRows()
        Catch ex As Exception
            MessageBox.Show("Error loading residents: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ Add new resident
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' 🧩 Validation: Check if any required field is empty
        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtlastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtage.Text) OrElse
           cbogender.SelectedIndex = -1 OrElse
           cbostatus.SelectedIndex = -1 OrElse
           cbositio.SelectedIndex = -1 Then

            MessageBox.Show("⚠️ Please fill out all required fields before adding a resident.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksyon()

            ' 🔎 Check if resident already exists (same first name, last name, and birthdate)
            Dim checkSql As String = "SELECT COUNT(*) FROM residents WHERE First_Name=@First_Name AND Last_Name=@Last_Name AND Birthdate=@Birthdate"
            Dim checkCmd As New MySqlCommand(checkSql, cn)
            checkCmd.Parameters.AddWithValue("@First_Name", txtfirstname.Text)
            checkCmd.Parameters.AddWithValue("@Last_Name", txtlastname.Text)
            checkCmd.Parameters.AddWithValue("@Birthdate", dtpbirthdate.Value)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("⚠️ Resident already exists!", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' ✅ Include Date_Registered with current date automatically
            Dim sql As String = "INSERT INTO residents (First_Name, Last_Name, Age, Gender, Birthdate, Sitio, Status, Date_Registered)
                                 VALUES (@First_Name, @Last_Name, @Age, @Gender, @Birthdate, @Sitio, @Status, CURDATE())"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@First_Name", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Last_Name", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Age", txtage.Text)
            cmd.Parameters.AddWithValue("@Gender", cbogender.Text)
            cmd.Parameters.AddWithValue("@Birthdate", dtpbirthdate.Value)
            cmd.Parameters.AddWithValue("@Sitio", cbositio.Text)
            cmd.Parameters.AddWithValue("@Status", cbostatus.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("✅ Resident added successfully!")
            ClearFields()
            LoadResidents()
        Catch ex As Exception
            MessageBox.Show("❌ Error adding resident: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ Update resident (with password authentication)
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtresidentid.Text = "" Then
            MessageBox.Show("Please select a resident to update.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtlastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtage.Text) OrElse
           cbogender.SelectedIndex = -1 OrElse
           cbostatus.SelectedIndex = -1 OrElse
           cbositio.SelectedIndex = -1 Then

            MessageBox.Show("⚠️ Please fill out all required fields before updating a resident.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 🔐 Ask for password before updating
        Dim passwordForm As New Form()
        Dim lbl As New Label() With {.Text = "Enter Barangay Official Password:", .AutoSize = True, .Top = 10, .Left = 10}
        Dim txtPass As New TextBox() With {.Top = 35, .Left = 10, .Width = 200, .PasswordChar = "*"c}
        Dim btnOk As New Button() With {.Text = "OK", .Top = 70, .Left = 10, .DialogResult = DialogResult.OK}
        passwordForm.Text = "Authentication Required"
        passwordForm.StartPosition = FormStartPosition.CenterScreen
        passwordForm.FormBorderStyle = FormBorderStyle.FixedDialog
        passwordForm.AcceptButton = btnOk
        passwordForm.ClientSize = New Size(230, 110)
        passwordForm.Controls.AddRange({lbl, txtPass, btnOk})

        If passwordForm.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show("Update cancelled. Authentication window closed.")
            Exit Sub
        End If

        If txtPass.Text <> "gerry123" Then
            MessageBox.Show("❌ Incorrect password. Update not authorized.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Call koneksyon()
            Dim sql As String = "UPDATE residents 
                                 SET First_Name=@First_Name, Last_Name=@Last_Name, Age=@Age, Gender=@Gender, Birthdate=@Birthdate, Sitio=@Sitio, Status=@Status 
                                 WHERE Resident_ID=@Resident_ID"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@First_Name", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Last_Name", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Age", txtage.Text)
            cmd.Parameters.AddWithValue("@Gender", cbogender.Text)
            cmd.Parameters.AddWithValue("@Birthdate", dtpbirthdate.Value)
            cmd.Parameters.AddWithValue("@Sitio", cbositio.Text)
            cmd.Parameters.AddWithValue("@Status", cbostatus.Text)
            cmd.Parameters.AddWithValue("@Resident_ID", txtresidentid.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("✅ Resident updated successfully!")
            ClearFields()
            LoadResidents()
        Catch ex As Exception
            MessageBox.Show("❌ Error updating resident: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ Delete resident
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If txtresidentid.Text = "" Then
                MessageBox.Show("Please select a resident to delete.")
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to delete this resident?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim password = InputBox("Enter Barangay Official Password to confirm deletion:", "Authentication Required")

                If password = "" Then
                    MessageBox.Show("Deletion cancelled. Password input was empty.")
                    Exit Sub
                End If

                If password <> "gerry123" Then
                    MessageBox.Show("❌ Incorrect password. Deletion not authorized.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                koneksyon()
                Dim sql = "DELETE FROM residents WHERE Resident_ID=@Resident_ID"
                Dim cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Resident_ID", txtresidentid.Text)
                cmd.ExecuteNonQuery()

                MessageBox.Show("✅ Resident deleted successfully!")
                ClearFields()
                LoadResidents()
            End If

        Catch ex As Exception
            MessageBox.Show("❌ Error deleting resident: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub


    ' ✅ Search by ID or Name
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            Call koneksyon()
            Dim sql As String = "SELECT Resident_ID, First_Name, Last_Name, Age, Gender, Birthdate, Sitio, Status, Date_Registered
                                 FROM residents 
                                 WHERE Resident_ID LIKE @search OR First_Name LIKE @search OR Last_Name LIKE @search"
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.AutoResizeColumns()
            DataGridView1.AutoResizeRows()
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ Populate textboxes when a row is clicked
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtresidentid.Text = row.Cells("Resident_ID").Value.ToString()
            txtfirstname.Text = row.Cells("First_Name").Value.ToString()
            txtlastname.Text = row.Cells("Last_Name").Value.ToString()
            txtage.Text = row.Cells("Age").Value.ToString()
            cbogender.Text = row.Cells("Gender").Value.ToString()
            cbositio.Text = row.Cells("Sitio").Value.ToString()
            cbostatus.Text = row.Cells("Status").Value.ToString()

            If Not IsDBNull(row.Cells("Birthdate").Value) Then
                dtpbirthdate.Value = Convert.ToDateTime(row.Cells("Birthdate").Value)
            Else
                dtpbirthdate.Value = DateTime.Today
            End If
        End If
    End Sub

    ' ✅ Clear all fields
    Private Sub ClearFields()
        txtresidentid.Clear()
        txtfirstname.Clear()
        txtlastname.Clear()
        txtage.Clear()
        cbogender.SelectedIndex = -1
        cbositio.SelectedIndex = -1
        cbostatus.SelectedIndex = -1
        dtpbirthdate.Value = DateTime.Today
    End Sub

    ' ✅ Auto compute age
    Private Sub dtpbirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpbirthdate.ValueChanged
        Dim birthdate As DateTime = dtpbirthdate.Value
        Dim age As Integer = CalculateAge(birthdate)
        txtage.Text = age.ToString()
    End Sub

    ' ✅ Compute age formula
    Private Function CalculateAge(birthdate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthdate.Year
        If (birthdate > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearFields()
        txtsearch.Clear()
        LoadResidents()
        MessageBox.Show("✅ All fields cleared successfully!", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
