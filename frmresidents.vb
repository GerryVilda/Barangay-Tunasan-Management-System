Imports MySql.Data.MySqlClient

Public Class frmresidents
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        LoadResidents()
    End Sub


    Private Sub LoadResidents()
        Call koneksyon()
        Dim sql As String = "SELECT resident_id, fullname, age, gender, address FROM residents"
        Dim da As New MySqlDataAdapter(sql, cn)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
End Class