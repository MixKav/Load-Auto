<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Daterent
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
        Me.datepicker_daterent_receipt = New System.Windows.Forms.DateTimePicker()
        Me.datepicker_daterent_rerurn = New System.Windows.Forms.DateTimePicker()
        Me.list_daterent_availability = New System.Windows.Forms.ListBox()
        Me.label_daterent_searchreceipt = New System.Windows.Forms.Label()
        Me.label_daterent_searchreturn = New System.Windows.Forms.Label()
        Me.button_daterent_find = New System.Windows.Forms.Button()
        Me.text_daterent_lastname = New System.Windows.Forms.TextBox()
        Me.label_daterent_lastname = New System.Windows.Forms.Label()
        Me.text_daterent_firstname = New System.Windows.Forms.TextBox()
        Me.label_daterent_firstname = New System.Windows.Forms.Label()
        Me.label_daterent_fathername = New System.Windows.Forms.Label()
        Me.label_daterent_born = New System.Windows.Forms.Label()
        Me.label_daterent_cardnumber = New System.Windows.Forms.Label()
        Me.text_daterent_fathername = New System.Windows.Forms.TextBox()
        Me.datepicker_daterent_born = New System.Windows.Forms.DateTimePicker()
        Me.label_daterent_cardname = New System.Windows.Forms.Label()
        Me.label_daterent_cardexpiry = New System.Windows.Forms.Label()
        Me.label_daterent_cvv = New System.Windows.Forms.Label()
        Me.text_daterent_cardnumber = New System.Windows.Forms.TextBox()
        Me.text_daterent_cardname = New System.Windows.Forms.TextBox()
        Me.text_daterent_cardexpiry = New System.Windows.Forms.TextBox()
        Me.text_daterent_cvv = New System.Windows.Forms.TextBox()
        Me.button_daterent_ok = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.butoon_daterent_print = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datepicker_daterent_receipt
        '
        Me.datepicker_daterent_receipt.Location = New System.Drawing.Point(29, 41)
        Me.datepicker_daterent_receipt.Name = "datepicker_daterent_receipt"
        Me.datepicker_daterent_receipt.Size = New System.Drawing.Size(272, 22)
        Me.datepicker_daterent_receipt.TabIndex = 0
        '
        'datepicker_daterent_rerurn
        '
        Me.datepicker_daterent_rerurn.Location = New System.Drawing.Point(29, 86)
        Me.datepicker_daterent_rerurn.Name = "datepicker_daterent_rerurn"
        Me.datepicker_daterent_rerurn.Size = New System.Drawing.Size(272, 22)
        Me.datepicker_daterent_rerurn.TabIndex = 1
        '
        'list_daterent_availability
        '
        Me.list_daterent_availability.FormattingEnabled = True
        Me.list_daterent_availability.ItemHeight = 16
        Me.list_daterent_availability.Items.AddRange(New Object() {"available/unavailable", "Cost is: day*10= $"})
        Me.list_daterent_availability.Location = New System.Drawing.Point(29, 152)
        Me.list_daterent_availability.Name = "list_daterent_availability"
        Me.list_daterent_availability.Size = New System.Drawing.Size(272, 52)
        Me.list_daterent_availability.TabIndex = 2
        '
        'label_daterent_searchreceipt
        '
        Me.label_daterent_searchreceipt.AutoSize = True
        Me.label_daterent_searchreceipt.Location = New System.Drawing.Point(26, 21)
        Me.label_daterent_searchreceipt.Name = "label_daterent_searchreceipt"
        Me.label_daterent_searchreceipt.Size = New System.Drawing.Size(104, 17)
        Me.label_daterent_searchreceipt.TabIndex = 3
        Me.label_daterent_searchreceipt.Text = "Search receipt:"
        '
        'label_daterent_searchreturn
        '
        Me.label_daterent_searchreturn.AutoSize = True
        Me.label_daterent_searchreturn.Location = New System.Drawing.Point(26, 66)
        Me.label_daterent_searchreturn.Name = "label_daterent_searchreturn"
        Me.label_daterent_searchreturn.Size = New System.Drawing.Size(99, 17)
        Me.label_daterent_searchreturn.TabIndex = 4
        Me.label_daterent_searchreturn.Text = "Search return:"
        '
        'button_daterent_find
        '
        Me.button_daterent_find.Location = New System.Drawing.Point(29, 114)
        Me.button_daterent_find.Name = "button_daterent_find"
        Me.button_daterent_find.Size = New System.Drawing.Size(272, 32)
        Me.button_daterent_find.TabIndex = 5
        Me.button_daterent_find.Text = "Find:"
        Me.button_daterent_find.UseVisualStyleBackColor = True
        '
        'text_daterent_lastname
        '
        Me.text_daterent_lastname.Location = New System.Drawing.Point(368, 91)
        Me.text_daterent_lastname.Name = "text_daterent_lastname"
        Me.text_daterent_lastname.Size = New System.Drawing.Size(169, 22)
        Me.text_daterent_lastname.TabIndex = 12
        '
        'label_daterent_lastname
        '
        Me.label_daterent_lastname.AutoSize = True
        Me.label_daterent_lastname.Location = New System.Drawing.Point(364, 71)
        Me.label_daterent_lastname.Name = "label_daterent_lastname"
        Me.label_daterent_lastname.Size = New System.Drawing.Size(80, 17)
        Me.label_daterent_lastname.TabIndex = 11
        Me.label_daterent_lastname.Text = "Last Name:"
        '
        'text_daterent_firstname
        '
        Me.text_daterent_firstname.Location = New System.Drawing.Point(367, 46)
        Me.text_daterent_firstname.Name = "text_daterent_firstname"
        Me.text_daterent_firstname.Size = New System.Drawing.Size(170, 22)
        Me.text_daterent_firstname.TabIndex = 10
        '
        'label_daterent_firstname
        '
        Me.label_daterent_firstname.AutoSize = True
        Me.label_daterent_firstname.Location = New System.Drawing.Point(364, 26)
        Me.label_daterent_firstname.Name = "label_daterent_firstname"
        Me.label_daterent_firstname.Size = New System.Drawing.Size(80, 17)
        Me.label_daterent_firstname.TabIndex = 9
        Me.label_daterent_firstname.Text = "First Name:"
        '
        'label_daterent_fathername
        '
        Me.label_daterent_fathername.AutoSize = True
        Me.label_daterent_fathername.Location = New System.Drawing.Point(365, 116)
        Me.label_daterent_fathername.Name = "label_daterent_fathername"
        Me.label_daterent_fathername.Size = New System.Drawing.Size(104, 17)
        Me.label_daterent_fathername.TabIndex = 13
        Me.label_daterent_fathername.Text = "Father's Name:"
        '
        'label_daterent_born
        '
        Me.label_daterent_born.AutoSize = True
        Me.label_daterent_born.Location = New System.Drawing.Point(365, 161)
        Me.label_daterent_born.Name = "label_daterent_born"
        Me.label_daterent_born.Size = New System.Drawing.Size(91, 17)
        Me.label_daterent_born.TabIndex = 14
        Me.label_daterent_born.Text = "Date of Birth:"
        '
        'label_daterent_cardnumber
        '
        Me.label_daterent_cardnumber.AutoSize = True
        Me.label_daterent_cardnumber.Location = New System.Drawing.Point(20, 8)
        Me.label_daterent_cardnumber.Name = "label_daterent_cardnumber"
        Me.label_daterent_cardnumber.Size = New System.Drawing.Size(96, 17)
        Me.label_daterent_cardnumber.TabIndex = 15
        Me.label_daterent_cardnumber.Text = "Card Number:"
        '
        'text_daterent_fathername
        '
        Me.text_daterent_fathername.Location = New System.Drawing.Point(367, 136)
        Me.text_daterent_fathername.Name = "text_daterent_fathername"
        Me.text_daterent_fathername.Size = New System.Drawing.Size(170, 22)
        Me.text_daterent_fathername.TabIndex = 16
        '
        'datepicker_daterent_born
        '
        Me.datepicker_daterent_born.Location = New System.Drawing.Point(368, 181)
        Me.datepicker_daterent_born.Name = "datepicker_daterent_born"
        Me.datepicker_daterent_born.Size = New System.Drawing.Size(200, 22)
        Me.datepicker_daterent_born.TabIndex = 17
        '
        'label_daterent_cardname
        '
        Me.label_daterent_cardname.AutoSize = True
        Me.label_daterent_cardname.Location = New System.Drawing.Point(21, 53)
        Me.label_daterent_cardname.Name = "label_daterent_cardname"
        Me.label_daterent_cardname.Size = New System.Drawing.Size(129, 17)
        Me.label_daterent_cardname.TabIndex = 18
        Me.label_daterent_cardname.Text = "Card Holder Name:"
        '
        'label_daterent_cardexpiry
        '
        Me.label_daterent_cardexpiry.AutoSize = True
        Me.label_daterent_cardexpiry.Location = New System.Drawing.Point(21, 98)
        Me.label_daterent_cardexpiry.Name = "label_daterent_cardexpiry"
        Me.label_daterent_cardexpiry.Size = New System.Drawing.Size(84, 17)
        Me.label_daterent_cardexpiry.TabIndex = 19
        Me.label_daterent_cardexpiry.Text = "Card Expiry:"
        '
        'label_daterent_cvv
        '
        Me.label_daterent_cvv.AutoSize = True
        Me.label_daterent_cvv.Location = New System.Drawing.Point(21, 146)
        Me.label_daterent_cvv.Name = "label_daterent_cvv"
        Me.label_daterent_cvv.Size = New System.Drawing.Size(39, 17)
        Me.label_daterent_cvv.TabIndex = 20
        Me.label_daterent_cvv.Text = "CVV:"
        '
        'text_daterent_cardnumber
        '
        Me.text_daterent_cardnumber.Location = New System.Drawing.Point(23, 28)
        Me.text_daterent_cardnumber.Name = "text_daterent_cardnumber"
        Me.text_daterent_cardnumber.Size = New System.Drawing.Size(170, 22)
        Me.text_daterent_cardnumber.TabIndex = 21
        '
        'text_daterent_cardname
        '
        Me.text_daterent_cardname.Location = New System.Drawing.Point(23, 73)
        Me.text_daterent_cardname.Name = "text_daterent_cardname"
        Me.text_daterent_cardname.Size = New System.Drawing.Size(170, 22)
        Me.text_daterent_cardname.TabIndex = 22
        '
        'text_daterent_cardexpiry
        '
        Me.text_daterent_cardexpiry.Location = New System.Drawing.Point(23, 118)
        Me.text_daterent_cardexpiry.Name = "text_daterent_cardexpiry"
        Me.text_daterent_cardexpiry.Size = New System.Drawing.Size(170, 22)
        Me.text_daterent_cardexpiry.TabIndex = 23
        '
        'text_daterent_cvv
        '
        Me.text_daterent_cvv.Location = New System.Drawing.Point(23, 169)
        Me.text_daterent_cvv.Name = "text_daterent_cvv"
        Me.text_daterent_cvv.Size = New System.Drawing.Size(170, 22)
        Me.text_daterent_cvv.TabIndex = 24
        '
        'button_daterent_ok
        '
        Me.button_daterent_ok.Location = New System.Drawing.Point(367, 235)
        Me.button_daterent_ok.Name = "button_daterent_ok"
        Me.button_daterent_ok.Size = New System.Drawing.Size(272, 32)
        Me.button_daterent_ok.TabIndex = 7
        Me.button_daterent_ok.Text = "OK"
        Me.button_daterent_ok.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(368, 208)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(234, 21)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.Text = "I am a holder of a driving license"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'butoon_daterent_print
        '
        Me.butoon_daterent_print.Location = New System.Drawing.Point(27, 384)
        Me.butoon_daterent_print.Name = "butoon_daterent_print"
        Me.butoon_daterent_print.Size = New System.Drawing.Size(272, 32)
        Me.butoon_daterent_print.TabIndex = 8
        Me.butoon_daterent_print.Text = "PRINT"
        Me.butoon_daterent_print.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.text_daterent_cvv)
        Me.Panel2.Controls.Add(Me.text_daterent_cardexpiry)
        Me.Panel2.Controls.Add(Me.text_daterent_cardname)
        Me.Panel2.Controls.Add(Me.text_daterent_cardnumber)
        Me.Panel2.Controls.Add(Me.label_daterent_cvv)
        Me.Panel2.Controls.Add(Me.label_daterent_cardexpiry)
        Me.Panel2.Controls.Add(Me.label_daterent_cardname)
        Me.Panel2.Controls.Add(Me.label_daterent_cardnumber)
        Me.Panel2.Location = New System.Drawing.Point(961, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 211)
        Me.Panel2.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.button_daterent_ok)
        Me.Panel1.Controls.Add(Me.button_daterent_find)
        Me.Panel1.Controls.Add(Me.datepicker_daterent_born)
        Me.Panel1.Controls.Add(Me.text_daterent_fathername)
        Me.Panel1.Controls.Add(Me.label_daterent_searchreturn)
        Me.Panel1.Controls.Add(Me.label_daterent_born)
        Me.Panel1.Controls.Add(Me.label_daterent_fathername)
        Me.Panel1.Controls.Add(Me.label_daterent_searchreceipt)
        Me.Panel1.Controls.Add(Me.text_daterent_lastname)
        Me.Panel1.Controls.Add(Me.list_daterent_availability)
        Me.Panel1.Controls.Add(Me.label_daterent_lastname)
        Me.Panel1.Controls.Add(Me.datepicker_daterent_receipt)
        Me.Panel1.Controls.Add(Me.text_daterent_firstname)
        Me.Panel1.Controls.Add(Me.datepicker_daterent_rerurn)
        Me.Panel1.Controls.Add(Me.label_daterent_firstname)
        Me.Panel1.Location = New System.Drawing.Point(27, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 349)
        Me.Panel1.TabIndex = 27
        '
        'Daterent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 576)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.butoon_daterent_print)
        Me.Name = "Daterent"
        Me.Text = "Daterent"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datepicker_daterent_receipt As DateTimePicker
    Friend WithEvents datepicker_daterent_rerurn As DateTimePicker
    Friend WithEvents list_daterent_availability As ListBox
    Friend WithEvents label_daterent_searchreceipt As Label
    Friend WithEvents label_daterent_searchreturn As Label
    Friend WithEvents button_daterent_find As Button
    Friend WithEvents text_daterent_cvv As TextBox
    Friend WithEvents text_daterent_cardexpiry As TextBox
    Friend WithEvents text_daterent_cardname As TextBox
    Friend WithEvents text_daterent_cardnumber As TextBox
    Friend WithEvents label_daterent_cvv As Label
    Friend WithEvents label_daterent_cardexpiry As Label
    Friend WithEvents label_daterent_cardname As Label
    Friend WithEvents datepicker_daterent_born As DateTimePicker
    Friend WithEvents text_daterent_fathername As TextBox
    Friend WithEvents label_daterent_cardnumber As Label
    Friend WithEvents label_daterent_born As Label
    Friend WithEvents label_daterent_fathername As Label
    Friend WithEvents text_daterent_lastname As TextBox
    Friend WithEvents label_daterent_lastname As Label
    Friend WithEvents text_daterent_firstname As TextBox
    Friend WithEvents label_daterent_firstname As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents button_daterent_ok As Button
    Friend WithEvents butoon_daterent_print As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
