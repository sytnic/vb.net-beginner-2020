Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer

        ' Если при приведении к числу, всё хорошо, то продолжаем присвоение.
        ' IsNumeric не преобразует в число, а спрашивает, можно ли преобразовать в число.
        If IsNumeric(txtExamScore.Text) = True Then
            ' и дополнительно вводим приведение типа,
            ' преобразовать в целое число,
            ' т.к. по умолчанию из поля ввода даже цифры приходят как текст
            iScore = CInt(txtExamScore.Text)
        Else
            ' Иначе остановим программу
            MsgBox("You must enter a number")
            Exit Sub
        End If

        If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not a valid score. Enter a number between 0 and 100")
        ElseIf iScore >= 50 Then
            MsgBox("pass")
        ElseIf iScore < 50 Then
            MsgBox("fail")
        End If

        MsgBox("all done")

    End Sub
End Class
