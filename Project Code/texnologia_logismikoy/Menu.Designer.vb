<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label_menu_email = New System.Windows.Forms.Label()
        Me.button_menu_rent = New System.Windows.Forms.Button()
        Me.label_menu_password = New System.Windows.Forms.Label()
        Me.text_menu_email = New System.Windows.Forms.TextBox()
        Me.text_menu_password = New System.Windows.Forms.TextBox()
        Me.button_menu_signup = New System.Windows.Forms.Button()
        Me.button_menu_employ = New System.Windows.Forms.Button()
        Me.button_menu_proprietor = New System.Windows.Forms.Button()
        Me.text_menu_newsletter = New System.Windows.Forms.TextBox()
        Me.label_menu_newsletter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label_menu_email
        '
        Me.label_menu_email.AutoSize = True
        Me.label_menu_email.Location = New System.Drawing.Point(383, 199)
        Me.label_menu_email.Name = "label_menu_email"
        Me.label_menu_email.Size = New System.Drawing.Size(51, 17)
        Me.label_menu_email.TabIndex = 0
        Me.label_menu_email.Text = "E-mail:"
        '
        'button_menu_rent
        '
        Me.button_menu_rent.Location = New System.Drawing.Point(76, 66)
        Me.button_menu_rent.Name = "button_menu_rent"
        Me.button_menu_rent.Size = New System.Drawing.Size(265, 125)
        Me.button_menu_rent.TabIndex = 1
        Me.button_menu_rent.Text = "RENT AND BUY"
        Me.button_menu_rent.UseVisualStyleBackColor = True
        '
        'label_menu_password
        '
        Me.label_menu_password.AutoSize = True
        Me.label_menu_password.Location = New System.Drawing.Point(383, 255)
        Me.label_menu_password.Name = "label_menu_password"
        Me.label_menu_password.Size = New System.Drawing.Size(73, 17)
        Me.label_menu_password.TabIndex = 2
        Me.label_menu_password.Text = "Password:"
        '
        'text_menu_email
        '
        Me.text_menu_email.Location = New System.Drawing.Point(386, 219)
        Me.text_menu_email.Name = "text_menu_email"
        Me.text_menu_email.Size = New System.Drawing.Size(240, 22)
        Me.text_menu_email.TabIndex = 3
        Me.text_menu_email.Text = "user@mailbox.com"
        '
        'text_menu_password
        '
        Me.text_menu_password.Location = New System.Drawing.Point(386, 275)
        Me.text_menu_password.Name = "text_menu_password"
        Me.text_menu_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_menu_password.Size = New System.Drawing.Size(240, 22)
        Me.text_menu_password.TabIndex = 4
        Me.text_menu_password.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'button_menu_signup
        '
        Me.button_menu_signup.Location = New System.Drawing.Point(376, 308)
        Me.button_menu_signup.Name = "button_menu_signup"
        Me.button_menu_signup.Size = New System.Drawing.Size(265, 57)
        Me.button_menu_signup.TabIndex = 5
        Me.button_menu_signup.Text = "SIGN UP"
        Me.button_menu_signup.UseVisualStyleBackColor = True
        '
        'button_menu_employ
        '
        Me.button_menu_employ.Location = New System.Drawing.Point(76, 199)
        Me.button_menu_employ.Name = "button_menu_employ"
        Me.button_menu_employ.Size = New System.Drawing.Size(265, 98)
        Me.button_menu_employ.TabIndex = 8
        Me.button_menu_employ.Text = "EMPLOY"
        Me.button_menu_employ.UseVisualStyleBackColor = True
        '
        'button_menu_proprietor
        '
        Me.button_menu_proprietor.Location = New System.Drawing.Point(76, 308)
        Me.button_menu_proprietor.Name = "button_menu_proprietor"
        Me.button_menu_proprietor.Size = New System.Drawing.Size(265, 105)
        Me.button_menu_proprietor.TabIndex = 9
        Me.button_menu_proprietor.Text = "PROPRIETOR"
        Me.button_menu_proprietor.UseVisualStyleBackColor = True
        '
        'text_menu_newsletter
        '
        Me.text_menu_newsletter.Location = New System.Drawing.Point(76, 466)
        Me.text_menu_newsletter.Name = "text_menu_newsletter"
        Me.text_menu_newsletter.Size = New System.Drawing.Size(240, 22)
        Me.text_menu_newsletter.TabIndex = 10
        Me.text_menu_newsletter.Text = "user@mailbox.com"
        '
        'label_menu_newsletter
        '
        Me.label_menu_newsletter.AutoSize = True
        Me.label_menu_newsletter.Location = New System.Drawing.Point(73, 436)
        Me.label_menu_newsletter.Name = "label_menu_newsletter"
        Me.label_menu_newsletter.Size = New System.Drawing.Size(78, 17)
        Me.label_menu_newsletter.TabIndex = 11
        Me.label_menu_newsletter.Text = "Newsletter:"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 541)
        Me.Controls.Add(Me.label_menu_newsletter)
        Me.Controls.Add(Me.text_menu_newsletter)
        Me.Controls.Add(Me.button_menu_proprietor)
        Me.Controls.Add(Me.button_menu_employ)
        Me.Controls.Add(Me.button_menu_signup)
        Me.Controls.Add(Me.text_menu_password)
        Me.Controls.Add(Me.text_menu_email)
        Me.Controls.Add(Me.label_menu_password)
        Me.Controls.Add(Me.button_menu_rent)
        Me.Controls.Add(Me.label_menu_email)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_menu_email As Label
    Friend WithEvents button_menu_rent As Button
    Friend WithEvents label_menu_password As Label
    Friend WithEvents text_menu_email As TextBox
    Friend WithEvents text_menu_password As TextBox
    Friend WithEvents button_menu_signup As Button
    Friend WithEvents button_menu_employ As Button
    Friend WithEvents button_menu_proprietor As Button
    Friend WithEvents text_menu_newsletter As TextBox
    Friend WithEvents label_menu_newsletter As Label
End Class
