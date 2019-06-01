<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wrongsignup
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
        Me.button_wrongsignup_ok = New System.Windows.Forms.Button()
        Me.listbox_wrongsignup = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'button_wrongsignup_ok
        '
        Me.button_wrongsignup_ok.Location = New System.Drawing.Point(154, 161)
        Me.button_wrongsignup_ok.Name = "button_wrongsignup_ok"
        Me.button_wrongsignup_ok.Size = New System.Drawing.Size(449, 41)
        Me.button_wrongsignup_ok.TabIndex = 0
        Me.button_wrongsignup_ok.Text = "OK"
        Me.button_wrongsignup_ok.UseVisualStyleBackColor = True
        '
        'listbox_wrongsignup
        '
        Me.listbox_wrongsignup.FormattingEnabled = True
        Me.listbox_wrongsignup.ItemHeight = 16
        Me.listbox_wrongsignup.Items.AddRange(New Object() {"Something wrong ", "1)email exist", "2)password wrong"})
        Me.listbox_wrongsignup.Location = New System.Drawing.Point(154, 39)
        Me.listbox_wrongsignup.Name = "listbox_wrongsignup"
        Me.listbox_wrongsignup.Size = New System.Drawing.Size(449, 116)
        Me.listbox_wrongsignup.TabIndex = 1
        '
        'Wrongsignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 243)
        Me.Controls.Add(Me.listbox_wrongsignup)
        Me.Controls.Add(Me.button_wrongsignup_ok)
        Me.Name = "Wrongsignup"
        Me.Text = "Wrongsignup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_wrongsignup_ok As Button
    Friend WithEvents listbox_wrongsignup As ListBox
End Class
