Imports MySql.Data.MySqlClient

Public Class frmUsers

    '========================
    ' FORM LOAD
    '========================
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    '========================
    ' LOAD USERS INTO DATAGRIDVIEW
    '========================
    Private Sub LoadUsers()
        Try
            koneksyon()
            Dim query As String = "SELECT ID, Fullname, Username, Password, Role FROM users"
            da = New MySqlDataAdapter(query, cn)
            dt = New DataTable()
            da.Fill(dt)
            dgvusersaccounts.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    '========================
    ' CLEAR TEXTBOXES
    '========================
    Private Sub ClearFields()
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    '========================
    ' FILL TEXTBOXES WHEN CLICKING DATAGRIDVIEW - FIXED!
    '========================
    Private Sub dgvusersaccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusersaccounts.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvusersaccounts.Rows(e.RowIndex)

                ' Check if cells have values before accessing them
                If row.Cells("Fullname").Value IsNot Nothing Then
                    txtFullName.Text = row.Cells("Fullname").Value.ToString()
                End If

                If row.Cells("Username").Value IsNot Nothing Then
                    txtUsername.Text = row.Cells("Username").Value.ToString()
                End If

                If row.Cells("Password").Value IsNot Nothing Then
                    txtPassword.Text = row.Cells("Password").Value.ToString()
                End If

                If row.Cells("Role").Value IsNot Nothing Then
                    cmbRole.Text = row.Cells("Role").Value.ToString()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting user: " & ex.Message)
        End Try
    End Sub

    '========================
    ' SAVE NEW USER
    '========================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtFullName.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
                MessageBox.Show("Please fill all fields!")
                Exit Sub
            End If

            koneksyon()
            Dim query As String = "INSERT INTO users (Fullname, Username, Password, Role) VALUES (@fullname, @username, @password, @role)"
            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@fullname", txtFullName.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@role", cmbRole.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("User saved successfully!")
            LoadUsers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message)
        End Try
    End Sub

    '========================
    ' UPDATE EXISTING USER
    '========================
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If txtFullName.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
                MessageBox.Show("Please fill all fields!")
                Exit Sub
            End If

            ' Make sure a row is selected
            If dgvusersaccounts.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a user to update!")
                Exit Sub
            End If

            koneksyon()
            Dim query As String = "UPDATE users SET Fullname=@fullname, Username=@username, Password=@password, Role=@role WHERE ID=@id"
            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@fullname", txtFullName.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@role", cmbRole.Text)
            cmd.Parameters.AddWithValue("@id", dgvusersaccounts.CurrentRow.Cells("ID").Value)
            cmd.ExecuteNonQuery()

            MessageBox.Show("User updated successfully!")
            LoadUsers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub

End Class