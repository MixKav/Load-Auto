Imports System.IO
Public Class Signup
    Private Sub button_signup_ok_Click(sender As Object, e As EventArgs) Handles button_signup_ok.Click
        Dim ok As String
        Dim count As Integer
        Dim count2 As Integer
        Dim okemail As Boolean = True
        Dim okpassword As Boolean = True
        Dim line As String


        Dim emailuser1 As String = "maroulis@gmail.com"

        If (allok() = True) Then

            Dim obj As StreamReader
            obj = New StreamReader("D:\codes.txt")
            Do Until obj.ReadLine Is Nothing
                count = count + 1      ' posa line yparxoun sto txt
            Loop

            obj.Close()
            Using reader As StreamReader = New StreamReader("D:\codes.txt", True)
                Do Until count2 = count
                    line = reader.ReadLine
                    'MessageBox.Show(line) ' ti periexei h ka8e grammh sto txt
                    Dim str As String
                    Dim stra() As String
                    Dim i As Integer
                    stra = line.Split("|")
                    If (stra(0) = text_signup_email.Text Or stra(0) = "" Or text_signup_email.Text = emailuser1) Then
                        MsgBox("to email ayto xrhhsimopoieite hdh")
                        okemail = False
                    End If
                    count2 = count2 + 1
                Loop
                Console.ReadLine()

            End Using


            If (text_signup_password.Text <> text_signup_confirmpassword.Text) Then
                MsgBox("3anasymplhrwste ta pedia password")
                okpassword = False
            End If

            If okemail = True And okpassword = True Then
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("D:\codes.txt", True)
                file.WriteLine(text_signup_email.Text + "|" + text_signup_firstname.Text + "|" + text_signup_lastname.Text + "|" + text_signup_password.Text + "|" + "customer")
                file.Close()
            End If 'end gia gracimo sto txt 
        End If 'end h okall 
    End Sub

    Private Function allok()
        Dim ok As Boolean
        ok = False
        If text_signup_firstname.Text <> "" And text_signup_lastname.Text <> "" And text_signup_password.Text <> "" And text_signup_password.Text <> "" And checkbox_signup_robot.Checked = True Then
            ok = True
        End If

        Return ok

    End Function

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'if email.text==e mail MsgBox("to email yparxei hdh")

    End Sub
End Class