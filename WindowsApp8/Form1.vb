Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPrice As Decimal     ' Цена
        Dim iQuantity As Integer    ' Количество
        Dim decDiscount As Decimal  ' Скидка на штуку
        Dim decTotalCost As Decimal ' Общая стоимость
        Dim decPostage As Decimal   ' Стоимость доставки

        decPrice = 5
        iQuantity = 10
        decDiscount = 2
        decPostage = 3

        decTotalCost = ((decPrice - decDiscount) * iQuantity) + decPostage

        'Вычисляется согласно порядку математических действий:
        'BODMAS, BO(DM)(AS) - Brackets Order Division Multiplication Addition Subtraction

        MsgBox(decTotalCost)

    End Sub
End Class
