Public Class Form1
    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click

        ' Output each item in a separate message box one after another
        ' Вывод всех чисел по очереди

        ' ai - a массив, i числовой
        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            MsgBox(aiData(i))
        Next

    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click

        ' Output all of the items in the same message box on separate lines
        ' Вывод всех чисел за раз

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim stOut As String

        For i = 0 To 4
            ' Здесь в итерациях происходит конкатенация предыдущей строки с новой,
            ' своего рода output=.output (php).
            stOut = stOut & aiData(i) & vbNewLine
        Next

        ' Вывести весь результат за раз
        MsgBox(stOut)

    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

        ' Add up all of the items then output the total in a message box
        ' Сумма всех чисел

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        MsgBox("The total is " & iTotal)

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

        ' Calculate the average of the items then output it in a message box
        ' Среднее всех чисел

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        MsgBox("The average is " & iTotal / 5)

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

        ' Add up the items greater than 20 then output the result in a message box
        ' Сложить все элементы больше 20

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            If aiData(i) > 20 Then
                iTotal = iTotal + aiData(i)
            End If
        Next

        MsgBox("The total of the items bigger than 20 is " & iTotal)

    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

        ' Find the largest item then output it in a message box
        ' Найти наибольшее значение в массиве

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iMax As Integer

        iMax = 0

        ' На каждой итерации сравниваем значение iMax с текущим из массива,
        ' и если из массива больше,
        ' то присваиваем его к iMax
        For i = 0 To 4
            If aiData(i) > iMax Then
                iMax = aiData(i)
            End If
        Next

        MsgBox("The largest item is " & iMax)

    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click

        ' Find the smallest item then output it in a message box
        ' Найти наименьшее значение в массиве

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iMin As Integer

        iMin = 10000

        ' На каждой итерации сравниваем значение iMin с текущим из массива,
        ' и если из массива меньше,
        ' то присваиваем его к iMin
        For i = 0 To 4
            If aiData(i) < iMin Then
                iMin = aiData(i)
            End If
        Next

        MsgBox("The smallest item is " & iMin)

    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

        ' Replace each item in the array with a new value that is twice as big then output the new values
        ' Вывести за раз все числа массива, каждое из которых помножено на 2

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        ' Удваиваем все значения массива
        For i = 0 To 4
            aiData(i) = aiData(i) * 2
        Next


        Dim stOut As String

        ' Выводим все значения за раз
        For i = 0 To 4
            stOut = stOut & aiData(i) & vbNewLine
        Next

        MsgBox(stOut)

    End Sub

End Class
