Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decTotalCost As Decimal

        decPrice = 5
        iQuantity = 10

        decTotalCost = decPrice * iQuantity

        MsgBox(decTotalCost)

    End Sub
End Class
