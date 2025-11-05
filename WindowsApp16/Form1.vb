Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim stAge As String
        Dim iAge As Integer

        ' Пока stAge не будет преобразовано в число,
        ' цикл будет вызыватья вновь.
        ' Другие вариации:
        ' Do While IsNumeric(stAge) <> True
        ' Do While Not IsNumeric(stAge)

        ' IsNumeric проверяет, можно ли будет преобразовать в число
        Do While IsNumeric(stAge) = False
            ' InputBox всегда считывает строку, даже если она введена в поле ввода как число
            stAge = InputBox("Please enter your age in years")
        Loop

        ' Преобразовать в целое число
        ' Явное Преобразование типов
        iAge = CInt(stAge)

        MsgBox("Hello, you are " & iAge)


    End Sub
End Class
