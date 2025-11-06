Imports MySql.Data.MySqlClient

Module Connection
    Public LoggedInUser As String
    Public LoggedInRole As String
    Public cn As New MySqlConnection("server=localhost;user=root;password=;database=tunasan_records_management_db")
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable

    Public Sub koneksyon()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub
End Module
