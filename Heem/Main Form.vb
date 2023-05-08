Imports System.Threading
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Reflection.Emit

Public Class frmMain

    Dim Random As Integer
    Dim Number2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim phrases As New List(Of String)()
        Dim filePath As String = "C:\Users\egibson5977\Documents\HeemTestText.txt"


        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                phrases.Add(line)
            End While
        End Using


        Dim random As New Random()
        Dim index As Integer = random.Next(0, phrases.Count)
        Dim randomPhrase As String = phrases(index)


        TextBox1.Text = randomPhrase

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim word As String = TextBox2.Text
        Dim text As String = TextBox1.Text
        Dim cash As String = Label2.Text


        If text.Contains(word) Then
            Label1.Text = "Yes"
            Label2.Text = cash + word
        Else
            Label1.Text = "No"
        End If


    End Sub
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click


        Timer1.Enabled = True
        Random = Int((Rnd() * 25) + 1)

        btnSpin.Text = Random

        Number2 = 0
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Number2 += 5

        If Number2 = 10 Then
            picWheel.Image = My.Resources.chart1real
        ElseIf Number2 = 20 Then
            picWheel.Image = My.Resources.chart2
        ElseIf Number2 = 30 Then
            picWheel.Image = My.Resources.chart3
        ElseIf Number2 = 40 Then
            picWheel.Image = My.Resources.chart4
        ElseIf Number2 = 50 Then
            picWheel.Image = My.Resources.chart5
        ElseIf Number2 = 60 Then
            picWheel.Image = My.Resources.chart6
        ElseIf Number2 = 70 Then
            picWheel.Image = My.Resources.chart7
        ElseIf Number2 = 80 Then
            picWheel.Image = My.Resources.chart8
        ElseIf Number2 = 90 Then
            picWheel.Image = My.Resources.chart9
        ElseIf Number2 = 100 Then
            picWheel.Image = My.Resources.chart10
        ElseIf Number2 = 110 Then
            picWheel.Image = My.Resources.chart11
        ElseIf Number2 = 120 Then
            picWheel.Image = My.Resources.chart12
        ElseIf Number2 = 130 Then
            picWheel.Image = My.Resources.chart13
        ElseIf Number2 = 140 Then
            picWheel.Image = My.Resources.chart14
        ElseIf Number2 = 150 Then
            picWheel.Image = My.Resources.chart15
        ElseIf Number2 = 160 Then
            picWheel.Image = My.Resources.chart16
        ElseIf Number2 = 170 Then
            picWheel.Image = My.Resources.chart17
        ElseIf Number2 = 180 Then
            picWheel.Image = My.Resources.chart18
        ElseIf Number2 = 190 Then
            picWheel.Image = My.Resources.chart19
        ElseIf Number2 = 200 Then
            picWheel.Image = My.Resources.chart20
        ElseIf Number2 = 210 Then
            picWheel.Image = My.Resources.chart21
        ElseIf Number2 = 220 Then
            picWheel.Image = My.Resources.chart22
        ElseIf Number2 = 230 Then
            picWheel.Image = My.Resources.chart23
        ElseIf Number2 = 240 Then
            picWheel.Image = My.Resources.chart24
        ElseIf Number2 = 250 Then
            picWheel.Image = My.Resources.chart25

            'New
        ElseIf Number2 = 260 Then
            picWheel.Image = My.Resources.chart1real
            If Random = 1 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 270 Then
            picWheel.Image = My.Resources.chart2
            If Random = 2 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 280 Then
            picWheel.Image = My.Resources.chart3
            If Random = 3 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 290 Then
            picWheel.Image = My.Resources.chart4
            If Random = 4 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 300 Then
            picWheel.Image = My.Resources.chart5
            If Random = 5 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 310 Then
            picWheel.Image = My.Resources.chart6
            If Random = 6 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 320 Then
            picWheel.Image = My.Resources.chart7
            If Random = 7 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 330 Then
            picWheel.Image = My.Resources.chart8
            If Random = 8 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 340 Then
            picWheel.Image = My.Resources.chart9
            If Random = 9 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 350 Then
            picWheel.Image = My.Resources.chart10
            If Random = 10 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 360 Then
            picWheel.Image = My.Resources.chart11
            If Random = 11 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 370 Then
            picWheel.Image = My.Resources.chart12
            If Random = 12 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 380 Then
            picWheel.Image = My.Resources.chart13
            If Random = 13 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 390 Then
            picWheel.Image = My.Resources.chart14
            If Random = 14 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 400 Then
            picWheel.Image = My.Resources.chart15
            If Random = 15 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 410 Then
            picWheel.Image = My.Resources.chart16
            If Random = 16 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 420 Then
            picWheel.Image = My.Resources.chart17
            If Random = 17 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 430 Then
            picWheel.Image = My.Resources.chart18
            If Random = 18 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 440 Then
            picWheel.Image = My.Resources.chart19
            If Random = 19 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 450 Then
            picWheel.Image = My.Resources.chart20
            If Random = 20 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 460 Then
            picWheel.Image = My.Resources.chart21
            If Random = 21 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 470 Then
            picWheel.Image = My.Resources.chart22
            If Random = 22 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 480 Then
            picWheel.Image = My.Resources.chart23
            If Random = 23 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 490 Then
            picWheel.Image = My.Resources.chart24
            If Random = 24 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 500 Then
            picWheel.Image = My.Resources.chart25
            If Random = 25 Then
                Timer1.Stop()
            End If
        ElseIf Number2 = 510 Then
            Timer1.Stop()
            btnExit.Text = ("Didnt work")
        End If






    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picWheel.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
