Imports MySql.Data.MySqlClient

Public Class frmOfficials
    Private Sub frmOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOfficials()
    End Sub

    Private Sub LoadOfficials()
        Try
            koneksyon()

            ' 🔹 Punong Barangay
            cmd = New MySqlCommand("SELECT Full_Name FROM officials WHERE Position = 'Punong Barangay' LIMIT 1", cn)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                pb1.Text = dr("Full_Name").ToString()
            Else
                pb1.Text = "N/A"
            End If
            dr.Close()

            ' 🔹 Barangay Secretary
            cmd = New MySqlCommand("SELECT Full_Name FROM officials WHERE Position = 'Barangay Secretary' LIMIT 1", cn)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                bs1.Text = dr("Full_Name").ToString()
            Else
                bs1.Text = "N/A"
            End If
            dr.Close()

            ' 🔹 Sangguniang Barangay Members
            cmd = New MySqlCommand("SELECT Full_Name FROM officials WHERE Position = 'Sangguniang Barangay Member' ORDER BY Official_ID ASC LIMIT 7", cn)
            dr = cmd.ExecuteReader()

            ' Assuming you have 6 labels for members: sbm2 → sbm7
            Dim memberLabels As Label() = {sbm1, sbm2, sbm3, sbm4, sbm5, sbm6, sbm7}
            Dim index As Integer = 0

            While dr.Read() AndAlso index < memberLabels.Length
                memberLabels(index).Text = dr("Full_Name").ToString()
                index += 1
            End While
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading officials: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub
End Class
