Imports MySql.Data.MySqlClient

Public Class frmOfficials
    Private Sub frmOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOfficials()
    End Sub

    Private Sub LoadOfficials()
        Try
            koneksyon()
            Dim query As String = "SELECT official_id, full_name, position, term_start, term_end FROM officials ORDER BY position"
            cmd = New MySqlCommand(query, cn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error loading officials: " & ex.Message)
        End Try
    End Sub
End Class
