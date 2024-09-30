Public Class Form1
    Dim InputCategory As String
    Dim Dec, Bin, Oct As Double
    Dim Hex As String
    Dim t1, t2, t3, t4, t5, t6 As Double
    Dim t7, t8 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxInput.Text = ""
        TextBoxDecimal.Text = ""
        TextBoxBinary.Text = ""
        TextBoxOctal.Text = ""
        TextBoxHexadecimal.Text = ""
        Button0.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        ButtonEnter.Enabled = False
        ButtonDecimal.Enabled = True
        ButtonBinary.Enabled = True
        ButtonOctal.Enabled = True
        ButtonHexadecimal.Enabled = True
        Dec = 0
        Bin = 0
        Oct = 0
        Hex = ""
        t1 = 0
        t2 = 0
        t3 = 0
        t4 = 0
        t5 = 0
        t6 = 0
        t7 = ""
        t8 = ""
    End Sub

    Private Sub ButtonDecimal_Click(sender As Object, e As EventArgs) Handles ButtonDecimal.Click
        ButtonDecimal.Enabled = False
        ButtonBinary.Enabled = False
        ButtonOctal.Enabled = False
        ButtonHexadecimal.Enabled = False
        Button0.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        InputCategory = "Decimal"
    End Sub

    Private Sub ButtonBinary_Click(sender As Object, e As EventArgs) Handles ButtonBinary.Click
        ButtonDecimal.Enabled = False
        ButtonBinary.Enabled = False
        ButtonOctal.Enabled = False
        ButtonHexadecimal.Enabled = False
        Button0.Enabled = True
        Button1.Enabled = True
        InputCategory = "Binary"
    End Sub

    Private Sub ButtonOctal_Click(sender As Object, e As EventArgs) Handles ButtonOctal.Click
        ButtonDecimal.Enabled = False
        ButtonBinary.Enabled = False
        ButtonOctal.Enabled = False
        ButtonHexadecimal.Enabled = False
        Button0.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        InputCategory = "Octal"
    End Sub

    Private Sub ButtonHexadecimal_Click(sender As Object, e As EventArgs) Handles ButtonHexadecimal.Click
        ButtonDecimal.Enabled = False
        ButtonBinary.Enabled = False
        ButtonOctal.Enabled = False
        ButtonHexadecimal.Enabled = False
        Button0.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        ButtonA.Enabled = True
        ButtonB.Enabled = True
        ButtonC.Enabled = True
        ButtonD.Enabled = True
        ButtonE.Enabled = True
        ButtonF.Enabled = True
        InputCategory = "Hexadecimal"
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxInput.Text = ""
        TextBoxDecimal.Text = ""
        TextBoxBinary.Text = ""
        TextBoxOctal.Text = ""
        TextBoxHexadecimal.Text = ""
        Button0.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        ButtonEnter.Enabled = False
        ButtonDecimal.Enabled = True
        ButtonBinary.Enabled = True
        ButtonOctal.Enabled = True
        ButtonHexadecimal.Enabled = True
        Dec = 0
        Bin = 0
        Oct = 0
        Hex = ""
        t1 = 0
        t2 = 0
        t3 = 0
        t4 = 0
        t5 = 0
        t6 = 0
        t7 = ""
        t8 = ""
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Button0.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        ButtonEnter.Enabled = False
        Select Case InputCategory
            Case "Decimal"
                Dec = TextBoxInput.Text
                t1 = Dec
                While (t1 > 0)
                    t2 = t1 Mod 2
                    t3 = t3 + t2 * (10 ^ t4)
                    t4 = t4 + 1
                    t1 = t1 \ 2
                End While
                Bin = t3
                While (t3 > 0)
                    t1 = t3 Mod 1000
                    Select Case t1
                        Case 0
                            t2 = 0
                        Case 1
                            t2 = 1
                        Case 10
                            t2 = 2
                        Case 11
                            t2 = 3
                        Case 100
                            t2 = 4
                        Case 101
                            t2 = 5
                        Case 110
                            t2 = 6
                        Case 111
                            t2 = 7
                    End Select
                    t5 = t5 + t2 * (10 ^ t6)
                    t6 = t6 + 1
                    t3 = t3 \ 1000
                End While
                Oct = t5
                t1 = Bin
                While (t1 > 0)
                    t2 = t1 Mod 10000
                    Select Case t2
                        Case 0
                            t7 = "0"
                        Case 1
                            t7 = "1"
                        Case 10
                            t7 = "2"
                        Case 11
                            t7 = "3"
                        Case 100
                            t7 = "4"
                        Case 101
                            t7 = "5"
                        Case 110
                            t7 = "6"
                        Case 111
                            t7 = "7"
                        Case 1000
                            t7 = "8"
                        Case 1001
                            t7 = "9"
                        Case 1010
                            t7 = "A"
                        Case 1011
                            t7 = "B"
                        Case 1100
                            t7 = "C"
                        Case 1101
                            t7 = "D"
                        Case 1110
                            t7 = "E"
                        Case 1111
                            t7 = "F"
                    End Select
                    t8 = t7 + t8
                    t1 = t1 \ 10000
                End While
                Hex = t8
            Case "Binary"
                Bin = TextBoxInput.Text
                t1 = Bin
                While (t1 > 0)
                    t2 = t1 Mod 10
                    t3 = t3 + t2 * (2 ^ t4)
                    t4 = t4 + 1
                    t1 = t1 \ 10
                End While
                Dec = t3
                t3 = Bin
                While (t3 > 0)
                    t4 = t3 Mod 1000
                    Select Case t4
                        Case 0
                            t2 = 0
                        Case 1
                            t2 = 1
                        Case 10
                            t2 = 2
                        Case 11
                            t2 = 3
                        Case 100
                            t2 = 4
                        Case 101
                            t2 = 5
                        Case 110
                            t2 = 6
                        Case 111
                            t2 = 7
                    End Select
                    t1 = t1 + t2 * (10 ^ t5)
                    t5 = t5 + 1
                    t3 = t3 \ 1000
                End While
                Oct = t1
                t6 = Bin
                While (t6 > 0)
                    t3 = t6 Mod 10000
                    Select Case t3
                        Case 0
                            t8 = "0"
                        Case 1
                            t8 = "1"
                        Case 10
                            t8 = "2"
                        Case 11
                            t8 = "3"
                        Case 100
                            t8 = "4"
                        Case 101
                            t8 = "5"
                        Case 110
                            t8 = "6"
                        Case 111
                            t8 = "7"
                        Case 1000
                            t8 = "8"
                        Case 1001
                            t8 = "9"
                        Case 1010
                            t8 = "A"
                        Case 1011
                            t8 = "B"
                        Case 1100
                            t8 = "C"
                        Case 1101
                            t8 = "D"
                        Case 1110
                            t8 = "E"
                        Case 1111
                            t8 = "F"
                    End Select
                    t7 = t8 + t7
                    t6 = t6 \ 10000
                End While
                Hex = t7
            Case "Octal"
                Oct = TextBoxInput.Text
                t1 = Oct
                While (t1 > 0)
                    t2 = t1 Mod 10
                    Select Case t2
                        Case 0
                            t3 = 0
                        Case 1
                            t3 = 1
                        Case 2
                            t3 = 10
                        Case 3
                            t3 = 11
                        Case 4
                            t3 = 100
                        Case 5
                            t3 = 101
                        Case 6
                            t3 = 110
                        Case 7
                            t3 = 111
                    End Select
                    t5 = t5 + t2 * (8 ^ t4)
                    t6 = t6 + t3 * (1000 ^ t4)
                    t4 = t4 + 1
                    t1 = t1 \ 10
                End While
                Dec = t5
                Bin = t6
                While (t6 > 0)
                    t1 = t6 Mod 10000
                    Select Case t1
                        Case 0
                            t8 = "0"
                        Case 1
                            t8 = "1"
                        Case 10
                            t8 = "2"
                        Case 11
                            t8 = "3"
                        Case 100
                            t8 = "4"
                        Case 101
                            t8 = "5"
                        Case 110
                            t8 = "6"
                        Case 111
                            t8 = "7"
                        Case 1000
                            t8 = "8"
                        Case 1001
                            t8 = "9"
                        Case 1010
                            t8 = "A"
                        Case 1011
                            t8 = "B"
                        Case 1100
                            t8 = "C"
                        Case 1101
                            t8 = "D"
                        Case 1110
                            t8 = "E"
                        Case 1111
                            t8 = "F"
                    End Select
                    t7 = t8 + t7
                    t6 = t6 \ 10000
                End While
                Hex = t7
            Case "Hexadecimal"
                Hex = TextBoxInput.Text
                t7 = Hex
                For t1 = Len(t7) To 1 Step -1
                    t8 = Mid(t7, t1, 1)
                    Select Case t8
                        Case "0"
                            t2 = 0
                            t3 = 0
                        Case "1"
                            t2 = 1
                            t3 = 1
                        Case "2"
                            t2 = 2
                            t3 = 10
                        Case "3"
                            t2 = 3
                            t3 = 11
                        Case "4"
                            t2 = 4
                            t3 = 100
                        Case "5"
                            t2 = 5
                            t3 = 101
                        Case "6"
                            t2 = 6
                            t3 = 110
                        Case "7"
                            t2 = 7
                            t3 = 111
                        Case "8"
                            t2 = 8
                            t3 = 1000
                        Case "9"
                            t2 = 9
                            t3 = 1001
                        Case "A"
                            t2 = 10
                            t3 = 1010
                        Case "B"
                            t2 = 11
                            t3 = 1011
                        Case "C"
                            t2 = 12
                            t3 = 1100
                        Case "D"
                            t2 = 13
                            t3 = 1101
                        Case "E"
                            t2 = 14
                            t3 = 1110
                        Case "F"
                            t2 = 15
                            t3 = 1111
                    End Select
                    t5 = t5 + t2 * (16 ^ t4)
                    t6 = t6 + t3 * (10000 ^ t4)
                    t4 = t4 + 1
                Next
                Dec = t5
                Bin = t6
                t4 = t1
                While (t6 > 0)
                    t2 = t6 Mod 1000
                    Select Case t2
                        Case 0
                            t3 = 0
                        Case 1
                            t3 = 1
                        Case 10
                            t3 = 2
                        Case 11
                            t3 = 3
                        Case 100
                            t3 = 4
                        Case 101
                            t3 = 5
                        Case 110
                            t3 = 6
                        Case 111
                            t3 = 7
                    End Select
                    t1 = t1 + t3 * (10 ^ t4)
                    t4 = t4 + 1
                    t6 = t6 \ 1000
                End While
                Oct = t1
        End Select
        TextBoxDecimal.Text = Dec
        TextBoxBinary.Text = Bin
        TextBoxOctal.Text = Oct
        TextBoxHexadecimal.Text = Hex
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBoxInput.Text = TextBoxInput.Text + "0"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxInput.Text = TextBoxInput.Text + "1"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxInput.Text = TextBoxInput.Text + "2"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxInput.Text = TextBoxInput.Text + "3"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBoxInput.Text = TextBoxInput.Text + "4"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBoxInput.Text = TextBoxInput.Text + "5"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBoxInput.Text = TextBoxInput.Text + "6"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBoxInput.Text = TextBoxInput.Text + "7"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBoxInput.Text = TextBoxInput.Text + "8"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBoxInput.Text = TextBoxInput.Text + "9"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        TextBoxInput.Text = TextBoxInput.Text + "A"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click
        TextBoxInput.Text = TextBoxInput.Text + "B"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        TextBoxInput.Text = TextBoxInput.Text + "C"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click
        TextBoxInput.Text = TextBoxInput.Text + "D"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub ButtonE_Click(sender As Object, e As EventArgs) Handles ButtonE.Click
        TextBoxInput.Text = TextBoxInput.Text + "E"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub ButtonF_Click(sender As Object, e As EventArgs) Handles ButtonF.Click
        TextBoxInput.Text = TextBoxInput.Text + "F"
        ButtonEnter.Enabled = True
    End Sub

    Private Sub ButtonAbout_Click(sender As Object, e As EventArgs) Handles ButtonAbout.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
