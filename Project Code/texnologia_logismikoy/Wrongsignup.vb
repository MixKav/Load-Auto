Public Class Wrongsignup


    Private Sub listbox_wrongsignup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listbox_wrongsignup.SelectedIndexChanged
        listbox_wrongsignup.Items.Add("this email exist")
    End Sub

    Private Sub button_wrongsignup_ok_Click(sender As Object, e As EventArgs) Handles button_wrongsignup_ok.Click
        Me.Close()
    End Sub
End Class
