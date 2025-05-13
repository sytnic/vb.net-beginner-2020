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

        decTotalCost = ((decPrice - decDiscount) * iQuantity) + decPostage  '33

        'Вычисляется согласно порядку математических действий:
        'BODMAS, BO(DM)(AS) - Brackets Order Division Multiplication Addition Subtraction

        'Please excuse my dear aunt Sally PE(MD)(AS) - Parentheses Exponentiation Multiplication Division Addition Subtraction

        MsgBox(decTotalCost)

        Dim iResult As Integer
        iResult = 10 - 5 + 2  '7
        MsgBox(iResult)

        iResult = 10 + 2 - 5  '7
        MsgBox(iResult)

        iResult = 10 - 2 + 5  '13
        MsgBox(iResult)


        iResult = 10 / 5 * 2  '4
        MsgBox(iResult)

        iResult = 2 * 10 / 5  '4
        MsgBox(iResult)

        iResult = 10 * 5 / 2  '25
        MsgBox(iResult)

    End Sub
End Class
