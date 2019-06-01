Public Class Printrentforcustomer
    Public Property datereceipt As String
    Public Property datereturn As String
    Public Property dateborn As String
    Public Property firstname As String
    Public Property lastname As String
    Public Property fathername As String



    Private Sub label_printdaterentforcustomer_receipt_Click(sender As Object, e As EventArgs) Handles label_printdaterentforcustomer_receipt.Click


    End Sub

    Private Sub Printdaterentforcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_printdaterentforcustomer_receipt.Text = datereceipt
        label_printdaterentforcustomer_datereturn.Text = datereturn
        label_printdaterentforcustomer_firstname.Text = firstname
        label_printdaterentforcustomer_lastname.Text = lastname
        label_printdaterentforcustomer_fathername.Text = firstname
        label_printdaterentforcustomer_dateborn.Text = dateborn
    End Sub

    Private Sub button_printdaterentforcustomer_ok_Click(sender As Object, e As EventArgs) Handles button_printdaterentforcustomer_ok.Click
        Me.printform_printdaterentforcustomer.PrintAction = Printing.PrintAction.PrintToPreview
        Me.printform_printdaterentforcustomer.Print()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class