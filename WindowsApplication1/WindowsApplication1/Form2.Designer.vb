<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class player
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.inventory = New System.Windows.Forms.Button()
        Me.store = New System.Windows.Forms.Button()
        Me.shop_cart = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.ListBox()
        Me.Log_off = New System.Windows.Forms.Button()
        Me.add_cart = New System.Windows.Forms.Button()
        Me.choice_lable = New System.Windows.Forms.Label()
        Me.name_lable = New System.Windows.Forms.Label()
        Me.friendBox = New System.Windows.Forms.ListBox()
        Me.search_button = New System.Windows.Forms.Button()
        Me.Info_button = New System.Windows.Forms.Button()
        Me.prof_but = New System.Windows.Forms.Button()
        Me.down_butt = New System.Windows.Forms.Button()
        Me.delP_butt = New System.Windows.Forms.Button()
        Me.show_butt = New System.Windows.Forms.Button()
        Me.com_butt = New System.Windows.Forms.Button()
        Me.delP_but = New System.Windows.Forms.Button()
        Me.delStore_but = New System.Windows.Forms.Button()
        Me.act_butt = New System.Windows.Forms.Button()
        Me.addLable = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'inventory
        '
        Me.inventory.Location = New System.Drawing.Point(12, 115)
        Me.inventory.Name = "inventory"
        Me.inventory.Size = New System.Drawing.Size(106, 23)
        Me.inventory.TabIndex = 0
        Me.inventory.Text = "INVENTORY"
        Me.inventory.UseVisualStyleBackColor = True
        '
        'store
        '
        Me.store.Location = New System.Drawing.Point(12, 144)
        Me.store.Name = "store"
        Me.store.Size = New System.Drawing.Size(106, 23)
        Me.store.TabIndex = 2
        Me.store.Text = "STORE"
        Me.store.UseVisualStyleBackColor = True
        '
        'shop_cart
        '
        Me.shop_cart.Location = New System.Drawing.Point(12, 173)
        Me.shop_cart.Name = "shop_cart"
        Me.shop_cart.Size = New System.Drawing.Size(106, 23)
        Me.shop_cart.TabIndex = 3
        Me.shop_cart.Text = "SHOPPING CART"
        Me.shop_cart.UseVisualStyleBackColor = True
        '
        'list
        '
        Me.list.FormattingEnabled = True
        Me.list.Location = New System.Drawing.Point(124, 86)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(229, 199)
        Me.list.TabIndex = 6
        '
        'Log_off
        '
        Me.Log_off.Location = New System.Drawing.Point(370, 8)
        Me.Log_off.Name = "Log_off"
        Me.Log_off.Size = New System.Drawing.Size(75, 23)
        Me.Log_off.TabIndex = 8
        Me.Log_off.Text = "Log off"
        Me.Log_off.UseVisualStyleBackColor = True
        '
        'add_cart
        '
        Me.add_cart.Location = New System.Drawing.Point(359, 83)
        Me.add_cart.Name = "add_cart"
        Me.add_cart.Size = New System.Drawing.Size(84, 38)
        Me.add_cart.TabIndex = 0
        Me.add_cart.Text = "Add to Cart"
        Me.add_cart.UseVisualStyleBackColor = True
        Me.add_cart.Visible = False
        '
        'choice_lable
        '
        Me.choice_lable.AutoSize = True
        Me.choice_lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choice_lable.Location = New System.Drawing.Point(118, 52)
        Me.choice_lable.Name = "choice_lable"
        Me.choice_lable.Size = New System.Drawing.Size(95, 31)
        Me.choice_lable.TabIndex = 9
        Me.choice_lable.Text = "Label1"
        '
        'name_lable
        '
        Me.name_lable.AutoSize = True
        Me.name_lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_lable.Location = New System.Drawing.Point(12, 12)
        Me.name_lable.Name = "name_lable"
        Me.name_lable.Size = New System.Drawing.Size(77, 26)
        Me.name_lable.TabIndex = 10
        Me.name_lable.Text = "Label1"
        '
        'friendBox
        '
        Me.friendBox.FormattingEnabled = True
        Me.friendBox.Location = New System.Drawing.Point(451, 2)
        Me.friendBox.Name = "friendBox"
        Me.friendBox.Size = New System.Drawing.Size(111, 290)
        Me.friendBox.TabIndex = 11
        '
        'search_button
        '
        Me.search_button.Location = New System.Drawing.Point(360, 243)
        Me.search_button.Name = "search_button"
        Me.search_button.Size = New System.Drawing.Size(86, 42)
        Me.search_button.TabIndex = 12
        Me.search_button.Text = "Add Player"
        Me.search_button.UseVisualStyleBackColor = True
        '
        'Info_button
        '
        Me.Info_button.Location = New System.Drawing.Point(359, 83)
        Me.Info_button.Name = "Info_button"
        Me.Info_button.Size = New System.Drawing.Size(86, 38)
        Me.Info_button.TabIndex = 13
        Me.Info_button.Text = "Get Info"
        Me.Info_button.UseVisualStyleBackColor = True
        Me.Info_button.Visible = False
        '
        'prof_but
        '
        Me.prof_but.Location = New System.Drawing.Point(12, 86)
        Me.prof_but.Name = "prof_but"
        Me.prof_but.Size = New System.Drawing.Size(106, 23)
        Me.prof_but.TabIndex = 14
        Me.prof_but.Text = "PROFILE"
        Me.prof_but.UseVisualStyleBackColor = True
        '
        'down_butt
        '
        Me.down_butt.Location = New System.Drawing.Point(361, 83)
        Me.down_butt.Name = "down_butt"
        Me.down_butt.Size = New System.Drawing.Size(85, 37)
        Me.down_butt.TabIndex = 15
        Me.down_butt.Text = "Download"
        Me.down_butt.UseVisualStyleBackColor = True
        Me.down_butt.Visible = False
        '
        'delP_butt
        '
        Me.delP_butt.Location = New System.Drawing.Point(361, 37)
        Me.delP_butt.Name = "delP_butt"
        Me.delP_butt.Size = New System.Drawing.Size(84, 43)
        Me.delP_butt.TabIndex = 17
        Me.delP_butt.Text = "DELETE PLAYER"
        Me.delP_butt.UseVisualStyleBackColor = True
        Me.delP_butt.Visible = False
        '
        'show_butt
        '
        Me.show_butt.Location = New System.Drawing.Point(12, 232)
        Me.show_butt.Name = "show_butt"
        Me.show_butt.Size = New System.Drawing.Size(106, 23)
        Me.show_butt.TabIndex = 18
        Me.show_butt.Text = "SHOW PLAYERS"
        Me.show_butt.UseVisualStyleBackColor = True
        Me.show_butt.Visible = False
        '
        'com_butt
        '
        Me.com_butt.Location = New System.Drawing.Point(12, 203)
        Me.com_butt.Name = "com_butt"
        Me.com_butt.Size = New System.Drawing.Size(106, 23)
        Me.com_butt.TabIndex = 20
        Me.com_butt.Text = "COMMUNITY"
        Me.com_butt.UseVisualStyleBackColor = True
        '
        'delP_but
        '
        Me.delP_but.Location = New System.Drawing.Point(360, 127)
        Me.delP_but.Name = "delP_but"
        Me.delP_but.Size = New System.Drawing.Size(82, 35)
        Me.delP_but.TabIndex = 22
        Me.delP_but.Text = "DELETE"
        Me.delP_but.UseVisualStyleBackColor = True
        Me.delP_but.Visible = False
        '
        'delStore_but
        '
        Me.delStore_but.Location = New System.Drawing.Point(359, 127)
        Me.delStore_but.Name = "delStore_but"
        Me.delStore_but.Size = New System.Drawing.Size(82, 35)
        Me.delStore_but.TabIndex = 23
        Me.delStore_but.Text = "DELETE"
        Me.delStore_but.UseVisualStyleBackColor = True
        Me.delStore_but.Visible = False
        '
        'act_butt
        '
        Me.act_butt.Location = New System.Drawing.Point(360, 85)
        Me.act_butt.Name = "act_butt"
        Me.act_butt.Size = New System.Drawing.Size(85, 37)
        Me.act_butt.TabIndex = 24
        Me.act_butt.TabStop = False
        Me.act_butt.Text = "SUBSCRIBE"
        Me.act_butt.UseVisualStyleBackColor = True
        Me.act_butt.Visible = False
        '
        'addLable
        '
        Me.addLable.Location = New System.Drawing.Point(361, 217)
        Me.addLable.Name = "addLable"
        Me.addLable.Size = New System.Drawing.Size(81, 20)
        Me.addLable.TabIndex = 25
        Me.addLable.Text = "Friend name"
        '
        'player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 292)
        Me.Controls.Add(Me.addLable)
        Me.Controls.Add(Me.act_butt)
        Me.Controls.Add(Me.delStore_but)
        Me.Controls.Add(Me.delP_but)
        Me.Controls.Add(Me.com_butt)
        Me.Controls.Add(Me.show_butt)
        Me.Controls.Add(Me.delP_butt)
        Me.Controls.Add(Me.down_butt)
        Me.Controls.Add(Me.prof_but)
        Me.Controls.Add(Me.Info_button)
        Me.Controls.Add(Me.search_button)
        Me.Controls.Add(Me.friendBox)
        Me.Controls.Add(Me.name_lable)
        Me.Controls.Add(Me.choice_lable)
        Me.Controls.Add(Me.add_cart)
        Me.Controls.Add(Me.Log_off)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.shop_cart)
        Me.Controls.Add(Me.store)
        Me.Controls.Add(Me.inventory)
        Me.Name = "player"
        Me.Text = "ACCOUNT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inventory As System.Windows.Forms.Button
    Friend WithEvents store As System.Windows.Forms.Button
    Friend WithEvents shop_cart As System.Windows.Forms.Button
    Friend WithEvents list As System.Windows.Forms.ListBox
    Friend WithEvents Log_off As System.Windows.Forms.Button
    Friend WithEvents add_cart As System.Windows.Forms.Button
    Friend WithEvents choice_lable As System.Windows.Forms.Label
    Friend WithEvents name_lable As System.Windows.Forms.Label
    Friend WithEvents friendBox As System.Windows.Forms.ListBox
    Friend WithEvents search_button As System.Windows.Forms.Button
    Friend WithEvents Info_button As System.Windows.Forms.Button
    Friend WithEvents prof_but As System.Windows.Forms.Button
    Friend WithEvents down_butt As System.Windows.Forms.Button
    Friend WithEvents delP_butt As System.Windows.Forms.Button
    Friend WithEvents show_butt As System.Windows.Forms.Button
    Friend WithEvents com_butt As System.Windows.Forms.Button
    Friend WithEvents delP_but As System.Windows.Forms.Button
    Friend WithEvents delStore_but As System.Windows.Forms.Button
    Friend WithEvents act_butt As System.Windows.Forms.Button
    Friend WithEvents addLable As System.Windows.Forms.TextBox
End Class
