Imports MySql.Data.MySqlClient

Public Class Form3
    Dim con As New MySqlConnection
    Dim com As MySqlCommand

    Private Sub Sign_Up_Click(sender As Object, e As EventArgs) Handles Sign_Up.Click
        con.ConnectionString = "server=localhost;userid=root;password=root;database=explorer"
        con.Open()
        com = New MySqlCommand("SELECT COUNT(account.A_id) FROM `account` WHERE 1", con)
        Dim i As Integer = com.ExecuteScalar()

        com = New MySqlCommand("insert into Shopping_Cart values ('000" & i & "', ' ','0','0');", con)
        com.ExecuteNonQuery()

        Dim query As String = "insert into Account values('Online', '000" & i & "', '" & Username.Text & "' ,'" & email.Text & "',MD5('" & Password.Text & "'),'" & DOB.Text & "','0','0','0','1','0','0','000" & i & "');"

        MessageBox.Show(query)

        Try
            com = New MySqlCommand(query, con)
            com.ExecuteNonQuery()
            MessageBox.Show("Successful")
        Catch ex As Exception
            MessageBox.Show("FAIL")
        End Try

        con.Close()
        Me.Close()
    End Sub
End Class

