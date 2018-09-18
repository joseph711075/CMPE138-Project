<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Sign_in = New System.Windows.Forms.Button()
        Me.Sign_Up = New System.Windows.Forms.Button()
        Me.wrong_lable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(94, 24)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(100, 20)
        Me.Username.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Location = New System.Drawing.Point(30, 52)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(56, 13)
        Me.Lable1.TabIndex = 5
        Me.Lable1.Text = "Password:"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(94, 49)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(100, 20)
        Me.Password.TabIndex = 6
        '
        'Sign_in
        '
        Me.Sign_in.Location = New System.Drawing.Point(13, 92)
        Me.Sign_in.Name = "Sign_in"
        Me.Sign_in.Size = New System.Drawing.Size(75, 23)
        Me.Sign_in.TabIndex = 7
        Me.Sign_in.Text = "Sign In"
        Me.Sign_in.UseVisualStyleBackColor = True
        '
        'Sign_Up
        '
        Me.Sign_Up.Location = New System.Drawing.Point(119, 92)
        Me.Sign_Up.Name = "Sign_Up"
        Me.Sign_Up.Size = New System.Drawing.Size(75, 23)
        Me.Sign_Up.TabIndex = 8
        Me.Sign_Up.Text = "Sign Up"
        Me.Sign_Up.UseVisualStyleBackColor = True
        '
        'wrong_lable
        '
        Me.wrong_lable.AutoSize = True
        Me.wrong_lable.ForeColor = System.Drawing.Color.Red
        Me.wrong_lable.Location = New System.Drawing.Point(43, 72)
        Me.wrong_lable.Name = "wrong_lable"
        Me.wrong_lable.Size = New System.Drawing.Size(151, 13)
        Me.wrong_lable.TabIndex = 9
        Me.wrong_lable.Text = "Wrong username or password!"
        Me.wrong_lable.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 165)
        Me.Controls.Add(Me.wrong_lable)
        Me.Controls.Add(Me.Sign_Up)
        Me.Controls.Add(Me.Sign_in)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.Name = "Form1"
        Me.Text = "Explorer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lable1 As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Sign_in As System.Windows.Forms.Button
    Friend WithEvents Sign_Up As System.Windows.Forms.Button
    Friend WithEvents wrong_lable As System.Windows.Forms.Label

End Class
