Public Class Form1
    Private Sub btnCountUpTask_Click(sender As Object, e As EventArgs) Handles btnCountUpTask.Click

        ' максимальное число счёта
        Dim iMax As Integer
        ' нечетные или четные числа считать
        Dim stoddorEven As String
        ' счётчик в циклах
        Dim x As Integer


        iMax = InputBox("What number do you want to count up to?")
        stoddorEven = InputBox("Do you want odd numbers or even numbers?")

        If stoddorEven = "even" Then
            ' если четное, то считать от 2 по 2
            For x = 2 To iMax Step 2
                MsgBox(x)
            Next
        ElseIf stoddorEven = "odd" Then
            ' если нечетное, то считать от 1 по 2
            For x = 1 To iMax Step 2
                MsgBox(x)
            Next
        End If

    End Sub
End Class
