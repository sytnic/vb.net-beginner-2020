Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        ' Объявление двумерного массива (массива с вложенными массивами).
        ' a - array,  st - string,
        ' 4 - количество индексов у каждого вложенного массива, начиная с 0
        ' 5 - количество вложенных массивов, начиная с 0
        Dim astPeople(4, 5) As String

        ' Присвоение значений массивам

        ' В отличие от других языков
        ' при присвоении и выведении на экран
        ' сначала идёт внутренний индекс массива, а потом номер вложенного массива

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Gandhi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"

        ' Выведение массива

        MsgBox(astPeople(4, 3))  ' Scientist
        MsgBox(astPeople(3, 1))  ' New Zealand

        ' Выведение массива с помощью переменных

        Dim x As Integer
        Dim y As Integer

        x = 3
        y = 2

        MsgBox(astPeople(x, y))  ' British

        ' Выведение массива с помощью цикла

        For x = 0 To 4
            MsgBox(astPeople(x, 0))  ' Выведение всего вложенного массива строки 0
        Next

        For y = 0 To 5
            MsgBox(astPeople(1, y))  ' Выведение индекса 2 каждого массива
        Next

    End Sub
End Class
