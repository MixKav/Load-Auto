Imports System.IO
Public Class Menu

    Dim emailuser1 As String = "maroulis@gmail.com"
    Dim passworduser1 As String = "12345"
    Private Sub button_menu_rent_Click(sender As Object, e As EventArgs) Handles button_menu_rent.Click
        Rent.Show()
        'He_is_user2("a", "b")
        He_is_user("rent")
    End Sub

    Private Sub button_menu_buy_Click(sender As Object, e As EventArgs)
        He_is_user("buy")
    End Sub

    Private Sub button_menu_employ_Click(sender As Object, e As EventArgs) Handles button_menu_employ.Click
        He_is_user("employ")
    End Sub

    Private Sub button_menu_signup_Click(sender As Object, e As EventArgs) Handles button_menu_signup.Click
        Signup.Show()
    End Sub

    Private Sub button_menu_proprietor_Click(sender As Object, e As EventArgs) Handles button_menu_proprietor.Click
        He_is_user("proprietor")

    End Sub

    Private Sub He_is_user(ByVal select1 As String)
        Dim count As Integer
        Dim obj As StreamReader
        obj = New StreamReader("D:\codes.txt")
        Do Until obj.ReadLine Is Nothing
            count = count + 1      ' posa line yparxoun sto txt
        Loop
        obj.Close()
        Dim good As Integer = 0
        Dim count2 As Integer = 0
        Dim line As String = ("|")
        'Dim stra As String() = Nothing
        Using reader As StreamReader = New StreamReader("D:\codes.txt", True)
            Dim stra(8) As String
            Do Until count2 = count - 1
                line = reader.ReadLine
                stra = line.Split("|")
                If stra(0) = text_menu_email.Text Or text_menu_email.Text = emailuser1 Then
                    good = 1
                    If stra(3) = text_menu_password.Text Or text_menu_password.Text = passworduser1 Then
                        good = 2
                        If select1 = "rent" Then
                            Rent.Show()
                        ElseIf select1 = "employ" Or stra(4) = "employ" Then ' kanonika and
                            Employ.Show()
                        ElseIf select1 = "proprietor" Or stra(4) = "proprietor" Then ' kanonika and
                            Proprietor.Show()
                        End If

                        'Exit Do ' xreiazete gia to split teleutaia loop diabazei keno apo to txt (readline)

                    End If


                End If
                'stra = Nothing
                'Array.Clear(myArray,0,myArray.Length)
                count = count - 1
            Loop
            If good = 0 Then
                MsgBox("to email den yparxei shmioyrhstee logargiasmo")
            ElseIf good = 1 Then
                MsgBox("o kwdikos einai la8os")

            End If
            Console.Read()
        End Using
        'den kanw clear 

    End Sub


    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
