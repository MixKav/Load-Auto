Public Class Daterent
    Dim date1 As String
    Dim date2 As String
    Dim date3 As String
    Dim bank As Integer = 0
    Private Sub button_daterent_find_Click(sender As Object, e As EventArgs) Handles button_daterent_find.Click
        Dim day As Integer
        MsgBox("dia8eshmo")
        list_daterent_availability.Items.Clear()
        list_daterent_availability.Items.Add("to kostos einai day*10")

    End Sub

    Private Sub button_daterent_ok_Click(sender As Object, e As EventArgs) Handles button_daterent_ok.Click
        If text_daterent_cardnumber.TextLength <> 16 Then
            If text_daterent_cvv.TextLength <> 3 Then
                If bank = 2 Then
                    Me.Close()
                Else
                    MsgBox("ta stoixeia kartas einai la8os")
                    bank = bank + 1
                End If
            End If
        End If
    End Sub

    Private Sub butoon_daterent_print_Click(sender As Object, e As EventArgs) Handles butoon_daterent_print.Click
        'datepicker_daterent_receipt.Format = DateTimePickerFormat.Custom
        'datepicker_daterent_receipt = "dd/MM/yyyy";

        date1 = Format(datepicker_daterent_receipt.Value, "dd/MM/yyyy")
        date2 = Format(datepicker_daterent_rerurn.Value, "dd/MM/yyyy")
        date3 = Format(datepicker_daterent_born.Value, "dd/MM/yyyy")

        Dim print As New Printrentforcustomer
        print.datereceipt = date1
        print.datereturn = date2
        print.dateborn = date3
        print.firstname = text_daterent_firstname.Text
        print.lastname = text_daterent_lastname.Text
        print.fathername = text_daterent_fathername.Text
        If CheckBox1.Checked = True Then
            print.Show()
        Else
            MsgBox("den eiste katoxos diplwmatos")
        End If

        'Me.Hide()
        'Me.printform_daterent.PrintAction = Printing.PrintAction.PrintToPreview
        'Me.printform_daterent.Print()
    End Sub

    Private Sub Daterent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class