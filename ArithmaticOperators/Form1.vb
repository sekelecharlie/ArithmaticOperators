Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iNumber3 As Decimal

        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        'For addition
        iNumber3 = iNumber1 + iNumber2
        MsgBox(iNumber1 & " + " & iNumber2 & " = " & iNumber3)

        'For subtraction
        iNumber3 = iNumber1 - iNumber2
        MsgBox(iNumber1 & " - " & iNumber2 & " = " & iNumber3)

        'For multiplication
        iNumber3 = iNumber1 * iNumber2
        MsgBox(iNumber1 & " * " & iNumber2 & " = " & iNumber3)

        'For Division
        iNumber3 = iNumber1 / iNumber2
        MsgBox(iNumber1 & " / " & iNumber2 & " = " & iNumber3)

        'THE FOLLOWING ARE NOT SO POPULAR

        'For Power
        iNumber3 = iNumber1 ^ iNumber2
        MsgBox(iNumber1 & " To the power of " & iNumber2 & " = " & iNumber3)

        'For DIV (Interger Division)
        iNumber3 = iNumber1 \ iNumber2
        MsgBox(iNumber1 & " \ " & iNumber2 & " = " & iNumber3)


    End Sub


End Class
