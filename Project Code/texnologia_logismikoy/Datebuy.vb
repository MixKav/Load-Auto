Public Class Datebuy
    Dim bank As Integer = 0
    Private Sub label_datebuy_searchfrom_Click(sender As Object, e As EventArgs) Handles label_datebuy_searchfrom.Click

    End Sub

    Private Sub button_datebuy_ok_Click(sender As Object, e As EventArgs) Handles button_datebuy_ok.Click

        If text_datebuy_cardnumber.TextLength <> 16 Then
            If text_datebuy_cvv.TextLength <> 3 Then
                MsgBox("ta stoixeia kartas einai la8os")
                bank = bank + 1
            End If
        End If

    End Sub

    Private Sub Datebuy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bank = 0
    End Sub

    Private Sub button_datebuy_find_Click(sender As Object, e As EventArgs) Handles button_datebuy_find.Click
        MsgBox("mporei na ginei h paralabh")
    End Sub
End Class