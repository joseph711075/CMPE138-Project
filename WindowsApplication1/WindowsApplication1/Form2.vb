Imports MySql.Data.MySqlClient

Public Class player
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=Thuvi1995;database=explorer")
    Dim Uname As String
    Dim id As String
    Dim email As String
    Dim bod As String
    Dim nGame As Integer
    Dim nFriend As Integer
    Dim nDevel As Integer
    Dim pos As Integer
    Dim shpCart As String
    Dim nGameShop As Integer


    Private Sub inventory_Click(sender As Object, e As EventArgs) Handles inventory.Click
        act_butt.Visible = False
        choice_lable.Text = "Game Inventory"
        down_butt.Visible = False
        delP_but.Visible = True
        Info_button.Visible = True
        add_cart.Visible = False
        delStore_but.Visible = False
        list.Items.Clear()
        'Check number of Games
        If nGame = 0 Then
            list.Items.Add("No Games")
        Else
            Dim query As String = "Select g_name from Play where a_name = '" & Form1.Username.Text & "'"

            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            list.Items.Clear()
            While (reader.Read())
                list.Items.Add(reader(0))
            End While

            reader.Close()
        End If





    End Sub


    Private Sub store_Click(sender As Object, e As EventArgs) Handles store.Click
        act_butt.Visible = False
        choice_lable.Text = "Store"
        add_cart.Visible = True
        delP_but.Visible = False
        Info_button.Visible = False
        down_butt.Visible = False
        delStore_but.Visible = False
        Dim query As String = "select G_name from Game"

        Dim command As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        list.Items.Clear()
        While (reader.Read())
            list.Items.Add(reader(0))
        End While
        reader.Close()
    End Sub

    Private Sub shop_cart_Click(sender As Object, e As EventArgs) Handles shop_cart.Click
        act_butt.Visible = False
        choice_lable.Text = "Shopping Cart"
        down_butt.Visible = True
        delP_but.Visible = False
        Info_button.Visible = False
        add_cart.Visible = False
        delStore_but.Visible = True
        list.Items.Clear()
        If nGameShop = 0 Then
            list.Items.Add("NO GAME")
        Else
            Dim query As String = "select g_name from Store where s_id = '" & shpCart & "'"

            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            list.Items.Clear()
            While (reader.Read())
                list.Items.Add(reader(0))
            End While
            reader.Close()

        End If

    End Sub

    Private Sub player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()

        'INITIALIZATION

        'store username
        Dim query As String = "Select A_name from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        Dim command As MySqlCommand = New MySqlCommand(query, connection)
        Uname = command.ExecuteScalar()

        'store userid
        query = "Select A_id from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        id = command.ExecuteScalar()

        'store number of game
        query = "Select nPlay from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        nGame = command.ExecuteScalar()

        'store bod
        query = "Select birth_date from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        bod = command.ExecuteScalar()

        'store email
        query = "Select email from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        email = command.ExecuteScalar()

        'store number of Friend
        query = "Select nFriend from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        nFriend = command.ExecuteScalar()

        'store number of develop
        query = "Select nDevel from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        nDevel = command.ExecuteScalar()

        'store position
        query = "Select dflag from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        pos = command.ExecuteScalar()

        If pos = 0 Then
            query = "Select cflag from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
            command = New MySqlCommand(query, connection)
            pos = command.ExecuteScalar()
            If pos = 1 Then
                pos = 2
            End If
        End If

        'store shopping cart
        query = "Select s_id from account where A_name = '" & Form1.Username.Text & "' AND password = MD5('" & Form1.Password.Text & "')"
        command = New MySqlCommand(query, connection)
        shpCart = command.ExecuteScalar()

        'store number in cart
        query = "Select nGame from Shopping_Cart where S_id = '" & shpCart & "'"
        command = New MySqlCommand(query, connection)
        nGameShop = command.ExecuteScalar()

        'Check Friends
        If nFriend = 0 Then
            friendBox.Items.Add("NO FRIENDS")
        Else
            query = "Select A_name from account, Be_friend where account.A_name = Be_friend.f2_name AND Be_friend.f1_name = '" & Form1.Username.Text & "'"
            command = New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim i As Integer = 0
            While (reader.Read())
                friendBox.Items.Add(reader(0))
            End While

            reader.Close()
        End If

        'Check number of Games
        If nGame = 0 Then
            list.Items.Add("No Games")
        Else

        End If



        'Layout
        Dim a As String = "Hello, " & Form1.Username.Text
        name_lable.Text = a.ToString
        choice_lable.Text = "Inventory"
        delP_but.Visible = True
        If (pos = 2) Then
            show_butt.Visible = True

            delP_butt.Visible = True

        ElseIf (pos = 1) Then
            show_butt.Visible = False

            delP_butt.Visible = False

        End If



    End Sub

    Private Sub Log_off_Click(sender As Object, e As EventArgs) Handles Log_off.Click
        Me.Close()
        Form1.wrong_lable.Visible = False
        Form1.Username.Clear()
        Form1.Password.Clear()
        Form1.Show()
    End Sub

    Private Sub add_cart_Click(sender As Object, e As EventArgs) Handles add_cart.Click

        Dim query As String = "insert into Store values('" & shpCart & "' , '" & list.SelectedItem.ToString & "')"
        Dim command As New MySqlCommand(query, connection)
        command.ExecuteNonQuery()


        query = "update shopping_cart set nGame = nGame + 1 where S_id = '" & shpCart & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
        MessageBox.Show("Add success!")
        nGameShop = nGameShop + 1

    End Sub

    Private Sub down_butt_Click(sender As Object, e As EventArgs) Handles down_butt.Click
        'Insert game 
        Dim game As String = list.SelectedItem.ToString
        Dim query As String = "insert into Play values('0', '" & list.SelectedItem.ToString & "' , '" & Uname & "')"
        Dim command As New MySqlCommand(query, connection)
        command.ExecuteNonQuery()


        query = "delete from Store where g_name = '" & game & "' and s_id = '" & shpCart & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()

        'update Shopping cart
        query = "update shopping_cart set nGame = nGame - 1 where S_id = '" & shpCart & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
        nGameShop = nGameShop + 1

        'update account
        query = "update account set nPlay = nPlay + 1 where A_id = '" & id & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
        nGame = nGame + 1

        list.Items.Remove(game)

    End Sub

    Private Sub delete_but_Click(sender As Object, e As EventArgs) Handles delP_but.Click
        'select game
        Dim game As String = list.SelectedItem.ToString
        Dim command As New MySqlCommand

        'delete game from inventory
        Dim query As String = "delete from Play where g_name = '" & game & "' and a_name = '" & Uname & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()


        'update account
        query = "update account set nPlay = nPlay - 1 where A_id = '" & id & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
        nGame = nGame - 1

        list.Items.Remove(game)
    End Sub

    Private Sub delStore_but_Click(sender As Object, e As EventArgs) Handles delStore_but.Click
        Dim game As String = list.SelectedItem.ToString
        Dim command As New MySqlCommand

        'delete game from inventory
        Dim query As String = "delete from Store where g_name = '" & game & "' and s_id = '" & shpCart & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()


        'update account
        query = "update Shopping_Cart set nGame = nGame - 1 where S_id = '" & shpCart & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
        nGameShop = nGameShop - 1

        list.Items.Remove(game)
    End Sub

    Private Sub com_butt_Click(sender As Object, e As EventArgs) Handles com_butt.Click
        act_butt.Visible = True
        choice_lable.Text = "Community"
        add_cart.Visible = False
        delP_but.Visible = False
        Info_button.Visible = False
        down_butt.Visible = False
        delStore_but.Visible = False
        Dim query As String = "Select C_name from community"

        Dim command As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        list.Items.Clear()
        While (reader.Read())
            list.Items.Add(reader(0))
        End While
        reader.Close()


    End Sub

    Private Sub act_butt_Click(sender As Object, e As EventArgs) Handles act_butt.Click
        Dim game As String = list.SelectedItem.ToString
        Dim query As String = "insert into Interact values('" & list.SelectedItem.ToString & "' , '" & Uname & "')"
        Dim command As New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
    End Sub

    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click
        Dim query As String = "insert into Be_friend values('" & Uname & "' , '" & addLable.Text & "')"
        Dim command As New MySqlCommand(query, connection)
        command.ExecuteNonQuery()

        query = "update account set nFriend = nFriend + 1 where A_id = '" & id & "'"
        command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()

        If nFriend = 0 Then
            friendBox.Items.RemoveAt(0)
        End If

        nFriend = nFriend + 1

        friendBox.Items.Add(addLable.Text)
    End Sub

    Private Sub prof_but_Click(sender As Object, e As EventArgs) Handles prof_but.Click
        Dim value As String = "ID: " & id & Environment.NewLine + _
                                 "NAME: " & Uname & Environment.NewLine + _
                                  "EMAIL: " & email & Environment.NewLine + _
                                   "BIRTH DAY: " & bod & Environment.NewLine

        MessageBox.Show(value)
    End Sub

    Private Sub show_butt_Click(sender As Object, e As EventArgs) Handles show_butt.Click
        act_butt.Visible = False
        choice_lable.Text = "Community"
        add_cart.Visible = False
        delP_but.Visible = False
        Info_button.Visible = True
        down_butt.Visible = False
        delStore_but.Visible = False
        Dim query As String = "Select A_name from Account"

        Dim command As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        list.Items.Clear()
        While (reader.Read())
            list.Items.Add(reader(0))
        End While
        reader.Close()
    End Sub

    Private Sub Info_button_Click(sender As Object, e As EventArgs) Handles Info_button.Click



        Dim infoID As String
        Dim infoname As String
        Dim infoEmail As String
        Dim infoBOD As String

        Dim query As String = "Select A_id from account where A_name = '" & list.SelectedItem & "'"
        Dim command As MySqlCommand = New MySqlCommand(query, connection)
        infoID = command.ExecuteScalar()

        query = "Select A_name from account where A_name = '" & list.SelectedItem & "'"
        command = New MySqlCommand(query, connection)
        infoname = command.ExecuteScalar()

        'store bod
        query = "Select birth_date from account where A_name = '" & list.SelectedItem & "'"
        command = New MySqlCommand(query, connection)
        infoBOD = command.ExecuteScalar()

        'store email
        query = "Select email from account where A_name = '" & list.SelectedItem & "'"
        command = New MySqlCommand(query, connection)
        infoEmail = command.ExecuteScalar()


        Dim value As String = "ID: " & infoID & Environment.NewLine + _
                         "NAME: " & infoname & Environment.NewLine + _
                          "EMAIL: " & infoEmail & Environment.NewLine + _
                           "BIRTH DAY: " & infoBOD & Environment.NewLine

        MessageBox.Show(value)
    End Sub

    Private Sub delP_butt_Click(sender As Object, e As EventArgs) Handles delP_butt.Click

        Dim s_id As String
        Dim query As String
        Dim Command As MySqlCommand

        query = "Select s_id from account where A_name = '" & list.SelectedItem & "'"
        Command = New MySqlCommand(query, connection)
        s_id = Command.ExecuteScalar()

        query = "delete from Shopping_Cart where S_id = '" & s_id & "'"
        Command = New MySqlCommand(query, connection)
        Command.ExecuteNonQuery()

        'store email
        
        list.Items.Remove(list.SelectedItem)

    End Sub

End Class