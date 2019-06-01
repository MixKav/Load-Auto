Public Class Proprietor
    Private Sub text_proprietor_income_rent_search_TextChanged(sender As Object, e As EventArgs) Handles text_proprietor_income_rent_search.TextChanged

    End Sub

    Private Sub Proprietor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub checkbox_proprietor_expenses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles checkbox_proprietor_expenses.SelectedIndexChanged

    End Sub

    Private Sub button_proprietor_income_Click(sender As Object, e As EventArgs) Handles button_proprietor_income.Click

        If (DateTimePicker1.Value > DateTimePicker2.Value) Then
            MsgBox("epile3te 3ana hmerhnies")
        End If

    End Sub
    Private Sub button_proprietor_expenses_Click(sender As Object, e As EventArgs) Handles button_proprietor_expenses.Click

        If (DateTimePicker3.Value > DateTimePicker4.Value) Then
            MsgBox("epile3te 3ana hmerhnies")
        End If

    End Sub
End Class