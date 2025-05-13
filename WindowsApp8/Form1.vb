Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Decimal
        Dim decTotalCost As Decimal

        decPrice = 5
        iQuantity = 10
        decDiscount = 2

        decTotalCost = (decPrice - decDiscount) * iQuantity

        'Вычисляется согласно порядку математических действий:
        'BODMAS, BO(DM)(AS) - Brackets Order Division Multiplication Addition Subtraction

        MsgBox(decTotalCost)

    End Sub
End Class
