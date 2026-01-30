Public Class Form1
    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click

        Dim stTarget As String
        Dim astFruit(9) As String
        Dim bFound As Boolean

        astFruit(0) = "Apple"
        astFruit(1) = "Mango"
        astFruit(2) = "Strawberry"
        astFruit(3) = "Banana"
        astFruit(4) = "Tomato"
        astFruit(5) = "Grape"
        astFruit(6) = "Pear"
        astFruit(7) = "Lemon"
        astFruit(8) = "Melon"
        astFruit(9) = "Fig"

        ' Окно с полем поиска
        stTarget = InputBox("Which fruit are you looking for?")

        Dim i As Integer

        For i = 0 To 9
            ' Варианты приведения к одному регистру
            ' If UCase(astFruit(i)) = UCase(stTarget) Then
            ' If LCase(astFruit(i)) = LCase(stTarget) Then
            If astFruit(i).ToUpper = stTarget.ToUpper Then
                bFound = True
                ' Выйти из цикла полностью, 
                ' как только будет найдено истинное значение
                Exit For
            End If
        Next

        ' Вывести результат поиска на экран
        If bFound = True Then
            MsgBox("found it")
        Else
            MsgBox("not found")
        End If

    End Sub
End Class
