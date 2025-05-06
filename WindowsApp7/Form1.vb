Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblNumber1 As Double
        Dim dblNumber2 As Double

        Dim dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        dblResult = dblNumber1 + dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 - dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 * dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 / dblNumber2
        MsgBox(dblResult)

        dblResult = dblNumber1 ^ dblNumber2  'возведение в степень
        MsgBox(dblResult)

        dblResult = dblNumber1 \ dblNumber2  'целочисленное деление
        MsgBox(dblResult)

        dblResult = dblNumber1 Mod dblNumber2  'остаток от деления
        MsgBox(dblResult)

    End Sub
End Class
