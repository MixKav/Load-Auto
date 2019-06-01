<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Me.button_signup_ok = New System.Windows.Forms.Button()
        Me.label_signup_firstname = New System.Windows.Forms.Label()
        Me.text_signup_firstname = New System.Windows.Forms.TextBox()
        Me.label_signup_lastname = New System.Windows.Forms.Label()
        Me.label_signup_email = New System.Windows.Forms.Label()
        Me.label_sigup_password = New System.Windows.Forms.Label()
        Me.label_sigup_confirmpassword = New System.Windows.Forms.Label()
        Me.text_signup_lastname = New System.Windows.Forms.TextBox()
        Me.text_signup_email = New System.Windows.Forms.TextBox()
        Me.text_signup_password = New System.Windows.Forms.TextBox()
        Me.text_signup_confirmpassword = New System.Windows.Forms.TextBox()
        Me.checkbox_signup_robot = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'button_signup_ok
        '
        Me.button_signup_ok.Location = New System.Drawing.Point(388, 355)
        Me.button_signup_ok.Name = "button_signup_ok"
        Me.button_signup_ok.Size = New System.Drawing.Size(169, 25)
        Me.button_signup_ok.TabIndex = 0
        Me.button_signup_ok.Text = "OK"
        Me.button_signup_ok.UseVisualStyleBackColor = True
        '
        'label_signup_firstname
        '
        Me.label_signup_firstname.AutoSize = True
        Me.label_signup_firstname.Location = New System.Drawing.Point(90, 124)
        Me.label_signup_firstname.Name = "label_signup_firstname"
        Me.label_signup_firstname.Size = New System.Drawing.Size(78, 17)
        Me.label_signup_firstname.TabIndex = 1
        Me.label_signup_firstname.Text = "First name:"
        '
        'text_signup_firstname
        '
        Me.text_signup_firstname.Location = New System.Drawing.Point(93, 155)
        Me.text_signup_firstname.Name = "text_signup_firstname"
        Me.text_signup_firstname.Size = New System.Drawing.Size(170, 22)
        Me.text_signup_firstname.TabIndex = 2
        '
        'label_signup_lastname
        '
        Me.label_signup_lastname.AutoSize = True
        Me.label_signup_lastname.Location = New System.Drawing.Point(385, 124)
        Me.label_signup_lastname.Name = "label_signup_lastname"
        Me.label_signup_lastname.Size = New System.Drawing.Size(78, 17)
        Me.label_signup_lastname.TabIndex = 3
        Me.label_signup_lastname.Text = "Last name:"
        '
        'label_signup_email
        '
        Me.label_signup_email.AutoSize = True
        Me.label_signup_email.Location = New System.Drawing.Point(91, 193)
        Me.label_signup_email.Name = "label_signup_email"
        Me.label_signup_email.Size = New System.Drawing.Size(51, 17)
        Me.label_signup_email.TabIndex = 4
        Me.label_signup_email.Text = "E-mail:"
        '
        'label_sigup_password
        '
        Me.label_sigup_password.AutoSize = True
        Me.label_sigup_password.Location = New System.Drawing.Point(385, 193)
        Me.label_sigup_password.Name = "label_sigup_password"
        Me.label_sigup_password.Size = New System.Drawing.Size(73, 17)
        Me.label_sigup_password.TabIndex = 5
        Me.label_sigup_password.Text = "Password:"
        '
        'label_sigup_confirmpassword
        '
        Me.label_sigup_confirmpassword.AutoSize = True
        Me.label_sigup_confirmpassword.Location = New System.Drawing.Point(385, 271)
        Me.label_sigup_confirmpassword.Name = "label_sigup_confirmpassword"
        Me.label_sigup_confirmpassword.Size = New System.Drawing.Size(125, 17)
        Me.label_sigup_confirmpassword.TabIndex = 6
        Me.label_sigup_confirmpassword.Text = "Confirm Password:"
        '
        'text_signup_lastname
        '
        Me.text_signup_lastname.Location = New System.Drawing.Point(388, 155)
        Me.text_signup_lastname.Name = "text_signup_lastname"
        Me.text_signup_lastname.Size = New System.Drawing.Size(169, 22)
        Me.text_signup_lastname.TabIndex = 8
        '
        'text_signup_email
        '
        Me.text_signup_email.Location = New System.Drawing.Point(93, 224)
        Me.text_signup_email.Name = "text_signup_email"
        Me.text_signup_email.Size = New System.Drawing.Size(170, 22)
        Me.text_signup_email.TabIndex = 9
        '
        'text_signup_password
        '
        Me.text_signup_password.Location = New System.Drawing.Point(388, 224)
        Me.text_signup_password.Name = "text_signup_password"
        Me.text_signup_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_signup_password.Size = New System.Drawing.Size(169, 22)
        Me.text_signup_password.TabIndex = 10
        '
        'text_signup_confirmpassword
        '
        Me.text_signup_confirmpassword.Location = New System.Drawing.Point(388, 307)
        Me.text_signup_confirmpassword.Name = "text_signup_confirmpassword"
        Me.text_signup_confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_signup_confirmpassword.Size = New System.Drawing.Size(169, 22)
        Me.text_signup_confirmpassword.TabIndex = 11
        '
        'checkbox_signup_robot
        '
        Me.checkbox_signup_robot.AutoSize = True
        Me.checkbox_signup_robot.Location = New System.Drawing.Point(94, 355)
        Me.checkbox_signup_robot.Name = "checkbox_signup_robot"
        Me.checkbox_signup_robot.Size = New System.Drawing.Size(129, 21)
        Me.checkbox_signup_robot.TabIndex = 12
        Me.checkbox_signup_robot.Text = "I am not a robot"
        Me.checkbox_signup_robot.UseVisualStyleBackColor = True
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 547)
        Me.Controls.Add(Me.checkbox_signup_robot)
        Me.Controls.Add(Me.text_signup_confirmpassword)
        Me.Controls.Add(Me.text_signup_password)
        Me.Controls.Add(Me.text_signup_email)
        Me.Controls.Add(Me.text_signup_lastname)
        Me.Controls.Add(Me.label_sigup_confirmpassword)
        Me.Controls.Add(Me.label_sigup_password)
        Me.Controls.Add(Me.label_signup_email)
        Me.Controls.Add(Me.label_signup_lastname)
        Me.Controls.Add(Me.text_signup_firstname)
        Me.Controls.Add(Me.label_signup_firstname)
        Me.Controls.Add(Me.button_signup_ok)
        Me.Name = "Signup"
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_signup_ok As Button
    Friend WithEvents label_signup_firstname As Label
    Friend WithEvents text_signup_firstname As TextBox
    Friend WithEvents label_signup_lastname As Label
    Friend WithEvents label_signup_email As Label
    Friend WithEvents label_sigup_password As Label
    Friend WithEvents label_sigup_confirmpassword As Label
    Friend WithEvents text_signup_lastname As TextBox
    Friend WithEvents text_signup_email As TextBox
    Friend WithEvents text_signup_password As TextBox
    Friend WithEvents text_signup_confirmpassword As TextBox
    Friend WithEvents checkbox_signup_robot As CheckBox
End Class
