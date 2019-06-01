<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proprietor
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
        Me.button_proprietor_income = New System.Windows.Forms.Button()
        Me.label_proprietor_income_datefrom = New System.Windows.Forms.Label()
        Me.button_proprietor_expenses = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.label_proprietor_income_dateto = New System.Windows.Forms.Label()
        Me.checkbox_proprietor_expenses = New System.Windows.Forms.CheckedListBox()
        Me.checkbox_proprietor_income = New System.Windows.Forms.CheckedListBox()
        Me.label_proprietor_expenses_datefrom = New System.Windows.Forms.Label()
        Me.label_proprietor_expenses_dateto = New System.Windows.Forms.Label()
        Me.label_proprietor_income_rent_search = New System.Windows.Forms.Label()
        Me.text_proprietor_income_rent_search = New System.Windows.Forms.TextBox()
        Me.checkbox_proprietor_income_cars = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'button_proprietor_income
        '
        Me.button_proprietor_income.Location = New System.Drawing.Point(36, 379)
        Me.button_proprietor_income.Name = "button_proprietor_income"
        Me.button_proprietor_income.Size = New System.Drawing.Size(316, 67)
        Me.button_proprietor_income.TabIndex = 0
        Me.button_proprietor_income.Text = "Income"
        Me.button_proprietor_income.UseVisualStyleBackColor = True
        '
        'label_proprietor_income_datefrom
        '
        Me.label_proprietor_income_datefrom.AutoSize = True
        Me.label_proprietor_income_datefrom.Location = New System.Drawing.Point(33, 33)
        Me.label_proprietor_income_datefrom.Name = "label_proprietor_income_datefrom"
        Me.label_proprietor_income_datefrom.Size = New System.Drawing.Size(44, 17)
        Me.label_proprietor_income_datefrom.TabIndex = 1
        Me.label_proprietor_income_datefrom.Text = "From:"
        '
        'button_proprietor_expenses
        '
        Me.button_proprietor_expenses.Location = New System.Drawing.Point(425, 379)
        Me.button_proprietor_expenses.Name = "button_proprietor_expenses"
        Me.button_proprietor_expenses.Size = New System.Drawing.Size(316, 67)
        Me.button_proprietor_expenses.TabIndex = 2
        Me.button_proprietor_expenses.Text = "Expenses"
        Me.button_proprietor_expenses.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(90, 73)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 4
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(479, 33)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker3.TabIndex = 5
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(479, 73)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker4.TabIndex = 6
        '
        'label_proprietor_income_dateto
        '
        Me.label_proprietor_income_dateto.AutoSize = True
        Me.label_proprietor_income_dateto.Location = New System.Drawing.Point(33, 73)
        Me.label_proprietor_income_dateto.Name = "label_proprietor_income_dateto"
        Me.label_proprietor_income_dateto.Size = New System.Drawing.Size(29, 17)
        Me.label_proprietor_income_dateto.TabIndex = 7
        Me.label_proprietor_income_dateto.Text = "To:"
        '
        'checkbox_proprietor_expenses
        '
        Me.checkbox_proprietor_expenses.BackColor = System.Drawing.SystemColors.Window
        Me.checkbox_proprietor_expenses.CheckOnClick = True
        Me.checkbox_proprietor_expenses.FormattingEnabled = True
        Me.checkbox_proprietor_expenses.Items.AddRange(New Object() {"Electricity", "Water" & Global.Microsoft.VisualBasic.ChrW(9), "Taxes", "Service" & Global.Microsoft.VisualBasic.ChrW(9), "Security" & Global.Microsoft.VisualBasic.ChrW(9), "Rent building", "Car insurance", "New car purchase" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.checkbox_proprietor_expenses.Location = New System.Drawing.Point(425, 122)
        Me.checkbox_proprietor_expenses.Name = "checkbox_proprietor_expenses"
        Me.checkbox_proprietor_expenses.Size = New System.Drawing.Size(316, 208)
        Me.checkbox_proprietor_expenses.TabIndex = 10
        '
        'checkbox_proprietor_income
        '
        Me.checkbox_proprietor_income.CheckOnClick = True
        Me.checkbox_proprietor_income.FormattingEnabled = True
        Me.checkbox_proprietor_income.Items.AddRange(New Object() {"Buy", "Rent" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.checkbox_proprietor_income.Location = New System.Drawing.Point(36, 122)
        Me.checkbox_proprietor_income.Name = "checkbox_proprietor_income"
        Me.checkbox_proprietor_income.Size = New System.Drawing.Size(316, 38)
        Me.checkbox_proprietor_income.TabIndex = 11
        '
        'label_proprietor_expenses_datefrom
        '
        Me.label_proprietor_expenses_datefrom.AutoSize = True
        Me.label_proprietor_expenses_datefrom.Location = New System.Drawing.Point(422, 33)
        Me.label_proprietor_expenses_datefrom.Name = "label_proprietor_expenses_datefrom"
        Me.label_proprietor_expenses_datefrom.Size = New System.Drawing.Size(44, 17)
        Me.label_proprietor_expenses_datefrom.TabIndex = 12
        Me.label_proprietor_expenses_datefrom.Text = "From:"
        '
        'label_proprietor_expenses_dateto
        '
        Me.label_proprietor_expenses_dateto.AutoSize = True
        Me.label_proprietor_expenses_dateto.Location = New System.Drawing.Point(422, 73)
        Me.label_proprietor_expenses_dateto.Name = "label_proprietor_expenses_dateto"
        Me.label_proprietor_expenses_dateto.Size = New System.Drawing.Size(29, 17)
        Me.label_proprietor_expenses_dateto.TabIndex = 13
        Me.label_proprietor_expenses_dateto.Text = "To:"
        '
        'label_proprietor_income_rent_search
        '
        Me.label_proprietor_income_rent_search.AutoSize = True
        Me.label_proprietor_income_rent_search.Location = New System.Drawing.Point(33, 351)
        Me.label_proprietor_income_rent_search.Name = "label_proprietor_income_rent_search"
        Me.label_proprietor_income_rent_search.Size = New System.Drawing.Size(57, 17)
        Me.label_proprietor_income_rent_search.TabIndex = 14
        Me.label_proprietor_income_rent_search.Text = "Search:"
        '
        'text_proprietor_income_rent_search
        '
        Me.text_proprietor_income_rent_search.Location = New System.Drawing.Point(138, 351)
        Me.text_proprietor_income_rent_search.Name = "text_proprietor_income_rent_search"
        Me.text_proprietor_income_rent_search.Size = New System.Drawing.Size(214, 22)
        Me.text_proprietor_income_rent_search.TabIndex = 15
        '
        'checkbox_proprietor_income_cars
        '
        Me.checkbox_proprietor_income_cars.CheckOnClick = True
        Me.checkbox_proprietor_income_cars.FormattingEnabled = True
        Me.checkbox_proprietor_income_cars.Items.AddRange(New Object() {"Car1" & Global.Microsoft.VisualBasic.ChrW(9), "car2 " & Global.Microsoft.VisualBasic.ChrW(9), "car3 //code input with txt"})
        Me.checkbox_proprietor_income_cars.Location = New System.Drawing.Point(36, 173)
        Me.checkbox_proprietor_income_cars.Name = "checkbox_proprietor_income_cars"
        Me.checkbox_proprietor_income_cars.Size = New System.Drawing.Size(316, 157)
        Me.checkbox_proprietor_income_cars.TabIndex = 16
        '
        'Proprietor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 540)
        Me.Controls.Add(Me.checkbox_proprietor_income_cars)
        Me.Controls.Add(Me.text_proprietor_income_rent_search)
        Me.Controls.Add(Me.label_proprietor_income_rent_search)
        Me.Controls.Add(Me.label_proprietor_expenses_dateto)
        Me.Controls.Add(Me.label_proprietor_expenses_datefrom)
        Me.Controls.Add(Me.checkbox_proprietor_income)
        Me.Controls.Add(Me.checkbox_proprietor_expenses)
        Me.Controls.Add(Me.label_proprietor_income_dateto)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.button_proprietor_expenses)
        Me.Controls.Add(Me.label_proprietor_income_datefrom)
        Me.Controls.Add(Me.button_proprietor_income)
        Me.Name = "Proprietor"
        Me.Text = "Proprietor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_proprietor_income As Button
    Friend WithEvents label_proprietor_income_datefrom As Label
    Friend WithEvents button_proprietor_expenses As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents label_proprietor_income_dateto As Label
    Friend WithEvents checkbox_proprietor_expenses As CheckedListBox
    Friend WithEvents checkbox_proprietor_income As CheckedListBox
    Friend WithEvents label_proprietor_expenses_datefrom As Label
    Friend WithEvents label_proprietor_expenses_dateto As Label
    Friend WithEvents label_proprietor_income_rent_search As Label
    Friend WithEvents text_proprietor_income_rent_search As TextBox
    Friend WithEvents checkbox_proprietor_income_cars As CheckedListBox
End Class
