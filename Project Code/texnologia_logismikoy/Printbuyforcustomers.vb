Public Class Printbuyforcustomers
    Private Sub button_printbuyforcustomers_ok_Click(sender As Object, e As EventArgs) Handles button_printbuyforcustomers_ok.Click
        Me.printform_printformbuyforcustomers.PrintAction = Printing.PrintAction.PrintToPreview
        Me.printform_printformbuyforcustomers.Print()
    End Sub
End Class