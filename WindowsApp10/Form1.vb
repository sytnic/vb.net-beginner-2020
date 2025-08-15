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

        'If iScore < 0 Or iScore > 100 Then
        '   MsgBox("That is not a valid score. Enter a number between 0 and 100")
        'ElseIf iScore >= 50 Then
        '   MsgBox("pass")
        'ElseIf iScore < 50 Then
        '   MsgBox("fail")
        'End If

        If Not (iScore >= 0 And iScore <= 100) Then
            MsgBox("That is not a valid score. Enter a number between 0 and 100")
        ElseIf iScore <= 20 Then
            MsgBox("GRADE F")
        ElseIf iScore > 20 And iScore <= 30 Then
            MsgBox("GRADE E")
        ElseIf iScore > 30 And iScore <= 40 Then
            MsgBox("GRADE D")
        ElseIf iScore > 40 And iScore <= 50 Then
            MsgBox("GRADE C")
        ElseIf iScore > 50 And iScore <= 70 Then
            MsgBox("GRADE B")
        Else
            MsgBox("GRADE A")
        End If

        MsgBox("all done")

    End Sub
End Class
