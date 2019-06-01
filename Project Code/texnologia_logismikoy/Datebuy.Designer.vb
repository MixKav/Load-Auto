<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datebuy
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.button_datebuy_ok = New System.Windows.Forms.Button()
        Me.list_datebuy_finish = New System.Windows.Forms.ListBox()
        Me.button_datebuy_find = New System.Windows.Forms.Button()
        Me.datepicker_datebuy_born = New System.Windows.Forms.DateTimePicker()
        Me.text_datebuy_fathername = New System.Windows.Forms.TextBox()
        Me.label_datebuy_born = New System.Windows.Forms.Label()
        Me.label_datebuy_fathername = New System.Windows.Forms.Label()
        Me.label_datebuy_searchfrom = New System.Windows.Forms.Label()
        Me.text_datebuy_lastname = New System.Windows.Forms.TextBox()
        Me.list_datebuy_availability = New System.Windows.Forms.ListBox()
        Me.label_datebuy_lastname = New System.Windows.Forms.Label()
        Me.datepicker_daterent_receipt = New System.Windows.Forms.DateTimePicker()
        Me.text_datebuy_firstname = New System.Windows.Forms.TextBox()
        Me.label_datebuy_firstname = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.text_datebuy_cvv = New System.Windows.Forms.TextBox()
        Me.text_datebuy_cardexpiry = New System.Windows.Forms.TextBox()
        Me.text_datebuy_cardname = New System.Windows.Forms.TextBox()
        Me.text_datebuy_cardnumber = New System.Windows.Forms.TextBox()
        Me.label_datebuy_cvv = New System.Windows.Forms.Label()
        Me.label_datebuy_cardexpiry = New System.Windows.Forms.Label()
        Me.label_datebuy_cardname = New System.Windows.Forms.Label()
        Me.label_datebuy_cardnumber = New System.Windows.Forms.Label()
        Me.butoon_datebuy_print = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.button_datebuy_ok)
        Me.Panel1.Controls.Add(Me.list_datebuy_finish)
        Me.Panel1.Controls.Add(Me.button_datebuy_find)
        Me.Panel1.Controls.Add(Me.datepicker_datebuy_born)
        Me.Panel1.Controls.Add(Me.text_datebuy_fathername)
        Me.Panel1.Controls.Add(Me.label_datebuy_born)
        Me.Panel1.Controls.Add(Me.label_datebuy_fathername)
        Me.Panel1.Controls.Add(Me.label_datebuy_searchfrom)
        Me.Panel1.Controls.Add(Me.text_datebuy_lastname)
        Me.Panel1.Controls.Add(Me.list_datebuy_availability)
        Me.Panel1.Controls.Add(Me.label_datebuy_lastname)
        Me.Panel1.Controls.Add(Me.datepicker_daterent_receipt)
        Me.Panel1.Controls.Add(Me.text_datebuy_firstname)
        Me.Panel1.Controls.Add(Me.label_datebuy_firstname)
        Me.Panel1.Location = New System.Drawing.Point(20, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 349)
        Me.Panel1.TabIndex = 30
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
        'button_datebuy_ok
        '
        Me.button_datebuy_ok.Location = New System.Drawing.Point(367, 235)
        Me.button_datebuy_ok.Name = "button_datebuy_ok"
        Me.button_datebuy_ok.Size = New System.Drawing.Size(272, 32)
        Me.button_datebuy_ok.TabIndex = 7
        Me.button_datebuy_ok.Text = "OK"
        Me.button_datebuy_ok.UseVisualStyleBackColor = True
        '
        'list_datebuy_finish
        '
        Me.list_datebuy_finish.FormattingEnabled = True
        Me.list_datebuy_finish.ItemHeight = 16
        Me.list_datebuy_finish.Items.AddRange(New Object() {"Τhe reservation was made.", "Please unpack the pdf below, which should be with you at the time of picking up t" &
                "he car.", "//Something went wrong"})
        Me.list_datebuy_finish.Location = New System.Drawing.Point(368, 273)
        Me.list_datebuy_finish.Name = "list_datebuy_finish"
        Me.list_datebuy_finish.Size = New System.Drawing.Size(537, 52)
        Me.list_datebuy_finish.TabIndex = 7
        '
        'button_datebuy_find
        '
        Me.button_datebuy_find.Location = New System.Drawing.Point(29, 114)
        Me.button_datebuy_find.Name = "button_datebuy_find"
        Me.button_datebuy_find.Size = New System.Drawing.Size(272, 32)
        Me.button_datebuy_find.TabIndex = 5
        Me.button_datebuy_find.Text = "Find:"
        Me.button_datebuy_find.UseVisualStyleBackColor = True
        '
        'datepicker_datebuy_born
        '
        Me.datepicker_datebuy_born.Location = New System.Drawing.Point(368, 181)
        Me.datepicker_datebuy_born.Name = "datepicker_datebuy_born"
        Me.datepicker_datebuy_born.Size = New System.Drawing.Size(200, 22)
        Me.datepicker_datebuy_born.TabIndex = 17
        '
        'text_datebuy_fathername
        '
        Me.text_datebuy_fathername.Location = New System.Drawing.Point(367, 136)
        Me.text_datebuy_fathername.Name = "text_datebuy_fathername"
        Me.text_datebuy_fathername.Size = New System.Drawing.Size(170, 22)
        Me.text_datebuy_fathername.TabIndex = 16
        '
        'label_datebuy_born
        '
        Me.label_datebuy_born.AutoSize = True
        Me.label_datebuy_born.Location = New System.Drawing.Point(365, 161)
        Me.label_datebuy_born.Name = "label_datebuy_born"
        Me.label_datebuy_born.Size = New System.Drawing.Size(91, 17)
        Me.label_datebuy_born.TabIndex = 14
        Me.label_datebuy_born.Text = "Date of Birth:"
        '
        'label_datebuy_fathername
        '
        Me.label_datebuy_fathername.AutoSize = True
        Me.label_datebuy_fathername.Location = New System.Drawing.Point(365, 116)
        Me.label_datebuy_fathername.Name = "label_datebuy_fathername"
        Me.label_datebuy_fathername.Size = New System.Drawing.Size(104, 17)
        Me.label_datebuy_fathername.TabIndex = 13
        Me.label_datebuy_fathername.Text = "Father's Name:"
        '
        'label_datebuy_searchfrom
        '
        Me.label_datebuy_searchfrom.AutoSize = True
        Me.label_datebuy_searchfrom.Location = New System.Drawing.Point(26, 21)
        Me.label_datebuy_searchfrom.Name = "label_datebuy_searchfrom"
        Me.label_datebuy_searchfrom.Size = New System.Drawing.Size(89, 17)
        Me.label_datebuy_searchfrom.TabIndex = 3
        Me.label_datebuy_searchfrom.Text = "Search date:"
        '
        'text_datebuy_lastname
        '
        Me.text_datebuy_lastname.Location = New System.Drawing.Point(368, 91)
        Me.text_datebuy_lastname.Name = "text_datebuy_lastname"
        Me.text_datebuy_lastname.Size = New System.Drawing.Size(169, 22)
        Me.text_datebuy_lastname.TabIndex = 12
        '
        'list_datebuy_availability
        '
        Me.list_datebuy_availability.FormattingEnabled = True
        Me.list_datebuy_availability.ItemHeight = 16
        Me.list_datebuy_availability.Items.AddRange(New Object() {"available/unavailable", "Cost is: ", "$"})
        Me.list_datebuy_availability.Location = New System.Drawing.Point(29, 152)
        Me.list_datebuy_availability.Name = "list_datebuy_availability"
        Me.list_datebuy_availability.Size = New System.Drawing.Size(272, 52)
        Me.list_datebuy_availability.TabIndex = 2
        '
        'label_datebuy_lastname
        '
        Me.label_datebuy_lastname.AutoSize = True
        Me.label_datebuy_lastname.Location = New System.Drawing.Point(364, 71)
        Me.label_datebuy_lastname.Name = "label_datebuy_lastname"
        Me.label_datebuy_lastname.Size = New System.Drawing.Size(80, 17)
        Me.label_datebuy_lastname.TabIndex = 11
        Me.label_datebuy_lastname.Text = "Last Name:"
        '
        'datepicker_daterent_receipt
        '
        Me.datepicker_daterent_receipt.Location = New System.Drawing.Point(29, 41)
        Me.datepicker_daterent_receipt.Name = "datepicker_daterent_receipt"
        Me.datepicker_daterent_receipt.Size = New System.Drawing.Size(272, 22)
        Me.datepicker_daterent_receipt.TabIndex = 0
        '
        'text_datebuy_firstname
        '
        Me.text_datebuy_firstname.Location = New System.Drawing.Point(367, 46)
        Me.text_datebuy_firstname.Name = "text_datebuy_firstname"
        Me.text_datebuy_firstname.Size = New System.Drawing.Size(170, 22)
        Me.text_datebuy_firstname.TabIndex = 10
        '
        'label_datebuy_firstname
        '
        Me.label_datebuy_firstname.AutoSize = True
        Me.label_datebuy_firstname.Location = New System.Drawing.Point(364, 26)
        Me.label_datebuy_firstname.Name = "label_datebuy_firstname"
        Me.label_datebuy_firstname.Size = New System.Drawing.Size(80, 17)
        Me.label_datebuy_firstname.TabIndex = 9
        Me.label_datebuy_firstname.Text = "First Name:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.text_datebuy_cvv)
        Me.Panel2.Controls.Add(Me.text_datebuy_cardexpiry)
        Me.Panel2.Controls.Add(Me.text_datebuy_cardname)
        Me.Panel2.Controls.Add(Me.text_datebuy_cardnumber)
        Me.Panel2.Controls.Add(Me.label_datebuy_cvv)
        Me.Panel2.Controls.Add(Me.label_datebuy_cardexpiry)
        Me.Panel2.Controls.Add(Me.label_datebuy_cardname)
        Me.Panel2.Controls.Add(Me.label_datebuy_cardnumber)
        Me.Panel2.Location = New System.Drawing.Point(954, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 211)
        Me.Panel2.TabIndex = 29
        '
        'text_datebuy_cvv
        '
        Me.text_datebuy_cvv.Location = New System.Drawing.Point(23, 169)
        Me.text_datebuy_cvv.Name = "text_datebuy_cvv"
        Me.text_datebuy_cvv.Size = New System.Drawing.Size(170, 22)
        Me.text_datebuy_cvv.TabIndex = 24
        '
        'text_datebuy_cardexpiry
        '
        Me.text_datebuy_cardexpiry.Location = New System.Drawing.Point(23, 118)
        Me.text_datebuy_cardexpiry.Name = "text_datebuy_cardexpiry"
        Me.text_datebuy_cardexpiry.Size = New System.Drawing.Size(170, 22)
        Me.text_datebuy_cardexpiry.TabIndex = 23
        '
        'text_datebuy_cardname
        '
        Me.text_datebuy_cardname.Location = New System.Drawing.Point(23, 73)
        Me.text_datebuy_cardname.Name = "text_datebuy_cardname"
        Me.text_datebuy_cardname.Size = New System.Drawing.Size(170, 22)
        Me.text_datebuy_cardname.TabIndex = 22
        '
        'text_datebuy_cardnumber
        '
        Me.text_datebuy_cardnumber.Location = New System.Drawing.Point(23, 28)
        Me.text_datebuy_cardnumber.Name = "text_datebuy_cardnumber"
        Me.text_datebuy_cardnumber.Size = New System.Drawing.Size(170, 22)
        Me.text_datebuy_cardnumber.TabIndex = 21
        '
        'label_datebuy_cvv
        '
        Me.label_datebuy_cvv.AutoSize = True
        Me.label_datebuy_cvv.Location = New System.Drawing.Point(21, 146)
        Me.label_datebuy_cvv.Name = "label_datebuy_cvv"
        Me.label_datebuy_cvv.Size = New System.Drawing.Size(39, 17)
        Me.label_datebuy_cvv.TabIndex = 20
        Me.label_datebuy_cvv.Text = "CVV:"
        '
        'label_datebuy_cardexpiry
        '
        Me.label_datebuy_cardexpiry.AutoSize = True
        Me.label_datebuy_cardexpiry.Location = New System.Drawing.Point(21, 98)
        Me.label_datebuy_cardexpiry.Name = "label_datebuy_cardexpiry"
        Me.label_datebuy_cardexpiry.Size = New System.Drawing.Size(84, 17)
        Me.label_datebuy_cardexpiry.TabIndex = 19
        Me.label_datebuy_cardexpiry.Text = "Card Expiry:"
        '
        'label_datebuy_cardname
        '
        Me.label_datebuy_cardname.AutoSize = True
        Me.label_datebuy_cardname.Location = New System.Drawing.Point(21, 53)
        Me.label_datebuy_cardname.Name = "label_datebuy_cardname"
        Me.label_datebuy_cardname.Size = New System.Drawing.Size(129, 17)
        Me.label_datebuy_cardname.TabIndex = 18
        Me.label_datebuy_cardname.Text = "Card Holder Name:"
        '
        'label_datebuy_cardnumber
        '
        Me.label_datebuy_cardnumber.AutoSize = True
        Me.label_datebuy_cardnumber.Location = New System.Drawing.Point(20, 8)
        Me.label_datebuy_cardnumber.Name = "label_datebuy_cardnumber"
        Me.label_datebuy_cardnumber.Size = New System.Drawing.Size(96, 17)
        Me.label_datebuy_cardnumber.TabIndex = 15
        Me.label_datebuy_cardnumber.Text = "Card Number:"
        '
        'butoon_datebuy_print
        '
        Me.butoon_datebuy_print.Location = New System.Drawing.Point(20, 434)
        Me.butoon_datebuy_print.Name = "butoon_datebuy_print"
        Me.butoon_datebuy_print.Size = New System.Drawing.Size(272, 32)
        Me.butoon_datebuy_print.TabIndex = 28
        Me.butoon_datebuy_print.Text = "PRINT"
        Me.butoon_datebuy_print.UseVisualStyleBackColor = True
        '
        'Datebuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 799)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.butoon_datebuy_print)
        Me.Name = "Datebuy"
        Me.Text = "Datebuy"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents button_datebuy_ok As Button
    Friend WithEvents list_datebuy_finish As ListBox
    Friend WithEvents button_datebuy_find As Button
    Friend WithEvents datepicker_datebuy_born As DateTimePicker
    Friend WithEvents text_datebuy_fathername As TextBox
    Friend WithEvents label_datebuy_born As Label
    Friend WithEvents label_datebuy_fathername As Label
    Friend WithEvents label_datebuy_searchfrom As Label
    Friend WithEvents text_datebuy_lastname As TextBox
    Friend WithEvents list_datebuy_availability As ListBox
    Friend WithEvents label_datebuy_lastname As Label
    Friend WithEvents datepicker_daterent_receipt As DateTimePicker
    Friend WithEvents text_datebuy_firstname As TextBox
    Friend WithEvents label_datebuy_firstname As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents text_datebuy_cvv As TextBox
    Friend WithEvents text_datebuy_cardexpiry As TextBox
    Friend WithEvents text_datebuy_cardname As TextBox
    Friend WithEvents text_datebuy_cardnumber As TextBox
    Friend WithEvents label_datebuy_cvv As Label
    Friend WithEvents label_datebuy_cardexpiry As Label
    Friend WithEvents label_datebuy_cardname As Label
    Friend WithEvents label_datebuy_cardnumber As Label
    Friend WithEvents butoon_datebuy_print As Button
End Class
