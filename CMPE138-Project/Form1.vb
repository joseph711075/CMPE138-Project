Imports MySql.Data.MySqlClient

Public Class Form1

    Dim con As New MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        con.ConnectionString = "server=localhost;uid=root;pwd=root;database=company2;SslMode=none;"

        Try
            con.Open()
            MsgBox("sucess")
            con.Close()

        Catch ex As Exception
            MsgBox("FAIL")
        End Try

    End Sub
End Class
