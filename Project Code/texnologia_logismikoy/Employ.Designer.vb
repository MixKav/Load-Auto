<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employ
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
        Me.button_employ_view = New System.Windows.Forms.Button()
        Me.label_employ_from = New System.Windows.Forms.Label()
        Me.datepicker_employ_from = New System.Windows.Forms.DateTimePicker()
        Me.datepicker_employ_to = New System.Windows.Forms.DateTimePicker()
        Me.label_employ_to = New System.Windows.Forms.Label()
        Me.button_employ_invoice = New System.Windows.Forms.Button()
        Me.button_employ_viewrentals = New System.Windows.Forms.Button()
        Me.button_employs_bought = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_employ_view
        '
        Me.button_employ_view.Location = New System.Drawing.Point(43, 150)
        Me.button_employ_view.Name = "button_employ_view"
        Me.button_employ_view.Size = New System.Drawing.Size(200, 23)
        Me.button_employ_view.TabIndex = 0
        Me.button_employ_view.Text = "INCOME"
        Me.button_employ_view.UseVisualStyleBackColor = True
        '
        'label_employ_from
        '
        Me.label_employ_from.AutoSize = True
        Me.label_employ_from.Location = New System.Drawing.Point(40, 38)
        Me.label_employ_from.Name = "label_employ_from"
        Me.label_employ_from.Size = New System.Drawing.Size(44, 17)
        Me.label_employ_from.TabIndex = 1
        Me.label_employ_from.Text = "From:"
        '
        'datepicker_employ_from
        '
        Me.datepicker_employ_from.Location = New System.Drawing.Point(43, 58)
        Me.datepicker_employ_from.Name = "datepicker_employ_from"
        Me.datepicker_employ_from.Size = New System.Drawing.Size(200, 22)
        Me.datepicker_employ_from.TabIndex = 2
        '
        'datepicker_employ_to
        '
        Me.datepicker_employ_to.Location = New System.Drawing.Point(43, 103)
        Me.datepicker_employ_to.Name = "datepicker_employ_to"
        Me.datepicker_employ_to.Size = New System.Drawing.Size(200, 22)
        Me.datepicker_employ_to.TabIndex = 3
        '
        'label_employ_to
        '
        Me.label_employ_to.AutoSize = True
        Me.label_employ_to.Location = New System.Drawing.Point(40, 83)
        Me.label_employ_to.Name = "label_employ_to"
        Me.label_employ_to.Size = New System.Drawing.Size(29, 17)
        Me.label_employ_to.TabIndex = 4
        Me.label_employ_to.Text = "To:"
        '
        'button_employ_invoice
        '
        Me.button_employ_invoice.Location = New System.Drawing.Point(43, 229)
        Me.button_employ_invoice.Name = "button_employ_invoice"
        Me.button_employ_invoice.Size = New System.Drawing.Size(200, 30)
        Me.button_employ_invoice.TabIndex = 5
        Me.button_employ_invoice.Text = "Invoice"
        Me.button_employ_invoice.UseVisualStyleBackColor = True
        '
        'button_employ_viewrentals
        '
        Me.button_employ_viewrentals.Location = New System.Drawing.Point(43, 291)
        Me.button_employ_viewrentals.Name = "button_employ_viewrentals"
        Me.button_employ_viewrentals.Size = New System.Drawing.Size(200, 28)
        Me.button_employ_viewrentals.TabIndex = 6
        Me.button_employ_viewrentals.Text = "VIEW RENTALS"
        Me.button_employ_viewrentals.UseVisualStyleBackColor = True
        '
        'button_employs_bought
        '
        Me.button_employs_bought.Location = New System.Drawing.Point(43, 361)
        Me.button_employs_bought.Name = "button_employs_bought"
        Me.button_employs_bought.Size = New System.Drawing.Size(200, 28)
        Me.button_employs_bought.TabIndex = 7
        Me.button_employs_bought.Text = "VIEW BOUGHT"
        Me.button_employs_bought.UseVisualStyleBackColor = True
        '
        'Employ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 552)
        Me.Controls.Add(Me.button_employs_bought)
        Me.Controls.Add(Me.button_employ_viewrentals)
        Me.Controls.Add(Me.button_employ_invoice)
        Me.Controls.Add(Me.label_employ_to)
        Me.Controls.Add(Me.datepicker_employ_to)
        Me.Controls.Add(Me.datepicker_employ_from)
        Me.Controls.Add(Me.label_employ_from)
        Me.Controls.Add(Me.button_employ_view)
        Me.Name = "Employ"
        Me.Text = "Employ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_employ_view As Button
    Friend WithEvents label_employ_from As Label
    Friend WithEvents datepicker_employ_from As DateTimePicker
    Friend WithEvents datepicker_employ_to As DateTimePicker
    Friend WithEvents label_employ_to As Label
    Friend WithEvents button_employ_invoice As Button
    Friend WithEvents button_employ_viewrentals As Button
    Friend WithEvents button_employs_bought As Button
End Class
