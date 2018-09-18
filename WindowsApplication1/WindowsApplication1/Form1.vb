Imports MySql.Data.MySqlClient

Public Class Form1
    Dim con As New MySqlConnection
    Dim com As MySqlCommand
    Dim Uname As String
    Dim id As String
    Dim nGame As Integer
    Dim nFriend As Integer
    Dim nDevel As Integer
    Dim pos As Integer
    Dim shpCart As String

    Private Sub Sign_Up_Click(sender As Object, e As EventArgs) Handles Sign_Up.Click
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=localhost;userid=root;password=Thuvi1995;database=explorer"
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Can't connect to Server")
            Me.Close()
        End Try
    End Sub

    Private Sub Sign_in_Click(sender As Object, e As EventArgs) Handles Sign_in.Click

        'get username
        Dim query As String = "Select * from account where A_name = '" & Username.Text & "' AND password = MD5('" & Password.Text & "')"
        Dim command As New MySqlCommand(query, con)
        Dim i As Integer
        Dim reader As MySqlDataReader = command.ExecuteReader()

        'check login
        While reader.Read()
            i = i + 1
        End While
        reader.Close()

        If (i = 1) Then
            player.Show()
            Me.Hide()
        Else
            wrong_lable.Visible = True
        End If



    End Sub
End Class