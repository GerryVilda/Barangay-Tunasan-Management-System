Imports MySql.Data.MySqlClient

Public Class frmresidents

    Private Sub frmresidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResidents()
    End Sub

    ' ✅ Load all residents into DataGridView
    Private Sub LoadResidents()
        Try
            Call koneksyon()
            Dim sql As String = "SELECT * FROM residents"
            Dim da As New MySqlDataAdapter(sql, cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error loading residents: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ Add new resident
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            Call koneksyon()
            Dim sql As String = "INSERT INTO residents (First_Name, Last_Name, Age, Gender, Birthdate, Sitio, Status)
                                 VALUES (@First_Name, @Last_Name, @Age, @Gender, @Birthdate, @Sitio, @Status)"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@First_Name", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Last_Name", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Age", txtage.Text)
            cmd.Parameters.AddWithValue("@Gender", cbogender.Text)
            cmd.Parameters.AddWithValue("@Birthdate", dtpbirthdate.Value)
            cmd.Parameters.AddWithValue("@Sitio", txtsitio.Text)
            cmd.Parameters.AddWithValue("@Status", cbostatus.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Resident added successfully!")
            ClearFields()
            LoadResidents()
        Catch ex As Exception
            MessageBox.Show("Error adding resident: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ Update resident
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If txtresidentid.Text = "" Then
                MessageBox.Show("Please select a resident to update.")
                Exit Sub
            End If

            Call koneksyon()
            Dim sql As String = "UPDATE residents SET First_Name=@First_Name, Last_Name=@Last_Name, Age=@Age, Gender=@Gender, Birthdate=@Birthdate, Sitio=@Sitio, Status=@Status WHERE Resident_ID=@Resident_ID"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@First_Name", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Last_Name", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Age", txtage.Text)
            cmd.Parameters.AddWithValue("@Gender", cbogender.Text)
            cmd.Parameters.AddWithValue("@Birthdate", dtpbirthdate.Value)
            cmd.Parameters.AddWithValue("@Sitio", txtsitio.Text)
            cmd.Parameters.AddWithValue("@Status", cbostatus.Text)
            cmd.Parameters.AddWithValue("@Resident_ID", txtresidentid.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Resident updated successfully!")
            ClearFields()
            LoadResidents()
        Catch ex As Exception
            MessageBox.Show("Error updating resident: " & ex.Message)
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
                Call koneksyon()
                Dim sql As String = "DELETE FROM residents WHERE Resident_ID=@Resident_ID"
                Dim cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Resident_ID", txtresidentid.Text)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Resident deleted successfully!")
                ClearFields()
                LoadResidents()
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting resident: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ Search by ID or Name
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            Call koneksyon()
            Dim sql As String = "SELECT Resident_ID, First_Name, Last_Name, Age, Gender, Birthdate, Sitio, Status 
                                 FROM residents 
                                 WHERE Resident_ID LIKE @search OR First_Name LIKE @search OR Last_Name LIKE @search"
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' ✅ When clicking a row in DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtresidentid.Text = row.Cells("Resident_ID").Value.ToString()
            txtfirstname.Text = row.Cells("First_Name").Value.ToString()
            txtlastname.Text = row.Cells("Last_Name").Value.ToString()
            txtage.Text = row.Cells("Age").Value.ToString()
            cbogender.Text = row.Cells("Gender").Value.ToString()
            txtsitio.Text = row.Cells("Sitio").Value.ToString()
            cbostatus.Text = row.Cells("Status").Value.ToString()

            ' ✅ Fix for empty/null Birthdate
            If Not IsDBNull(row.Cells("Birthdate").Value) Then
                dtpbirthdate.Value = Convert.ToDateTime(row.Cells("Birthdate").Value)
            Else
                dtpbirthdate.Value = DateTime.Now
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
        txtsitio.Clear()
        cbostatus.SelectedIndex = -1
        dtpbirthdate.Value = DateTime.Now
    End Sub

    ' ✅ Auto compute age based on selected birthdate
    Private Sub dtpbirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpbirthdate.ValueChanged
        Dim birthdate As DateTime = dtpbirthdate.Value
        Dim age As Integer = CalculateAge(birthdate)
        txtage.Text = age.ToString()
    End Sub

    ' ✅ Calculate age based on birthdate
    Private Function CalculateAge(birthdate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthdate.Year
        If (birthdate > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

End Class
