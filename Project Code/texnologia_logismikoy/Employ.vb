Public Class Employ



    Private Sub button_employ_view_Click(sender As Object, e As EventArgs) Handles button_employ_view.Click

        If (datepicker_employ_from.Value > datepicker_employ_to.Value) Then
            MsgBox("epile3te 3ana hmerhnies")
        End If

    End Sub
End Class