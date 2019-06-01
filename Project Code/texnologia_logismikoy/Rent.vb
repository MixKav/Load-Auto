Imports System.IO
Public Class Rent
    Dim enablecar() As String = Nothing
    Private Sub button_rent_rentnow_Click(sender As Object, e As EventArgs) Handles button_rent_rentnow.Click
        Dim clobal As Integer
        clobal = Convert.ToDecimal(TextBox9.Text)
        If (clobal < 110000) Then
            MsgBox("den einai pros enooikiash")
        Else
            Daterent.Show()
        End If

    End Sub
    Private Sub button_rent_buynow_Click(sender As Object, e As EventArgs) Handles button_rent_buynow.Click
        'If (enablecar(0) = "no") Then
        'MsgBox("den einai dia8eshmo")
        'Else
        Datebuy.Show()
        ' End If
    End Sub

    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count As Integer
        Dim obj As StreamReader
        obj = New StreamReader("D:\cars.txt")

        Do Until obj.ReadLine Is Nothing
            count = count + 1      ' posa line yparxoun sto txt
        Loop
        obj.Close()

        Dim count2 As Integer = 0
        Dim line As String
        Dim strcars() As String = Nothing


        Using reader As StreamReader = New StreamReader("D:\cars.txt", True)
            line = reader.ReadLine
            Do Until count2 = count
                line = reader.ReadLine
                strcars = line.Split("|")
                If count2 = 0 Then
                    TextBox1.Text = strcars(1)
                    TextBox2.Text = strcars(2)
                    TextBox3.Text = strcars(3)
                    TextBox4.Text = strcars(4)
                    TextBox5.Text = strcars(5)
                    TextBox6.Text = strcars(6)
                    TextBox7.Text = strcars(7)
                    TextBox8.Text = strcars(8)
                    TextBox9.Text = strcars(12)
                    'TextBox19.Text = strcars(12)
                    'enablecar(count2) = strcars(13)

                ElseIf count2 = 1 Then
                    TextBox10.Text = strcars(1)
                    TextBox11.Text = strcars(2)
                    TextBox12.Text = strcars(3)
                    TextBox13.Text = strcars(4)
                    TextBox14.Text = strcars(5)
                    TextBox15.Text = strcars(6)
                    TextBox16.Text = strcars(7)
                    TextBox17.Text = strcars(8)
                    TextBox18.Text = strcars(9)
                    MsgBox("ok")
                    'TextBox20.Text = strcars(12)
                    'enablecar(count2) = strcars(13)


                End If
                count2 = count2 + 1
                strcars = Nothing



                Exit Do ' xreiazete gia to split teleutaia loop diabazei keno apo to txt (readline)


                'Array.Clear(myArray,0,myArray.Length)
            Loop

        End Using
        Console.Read() 'den kanw clear 





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (enablecar(1) = "no") Then
            MsgBox("den einai dia8eshmo")
        Else
            Daterent.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clobal As Integer
        clobal = Convert.ToInt32(TextBox18.Text)
        If (clobal < 110000) Then
            MsgBox("den einai pros enooikiash")
        Else
            Datebuy.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class