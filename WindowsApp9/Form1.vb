Public Class Form1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        ' If чувствительны к регистру.  
        'Можно убрать чувствительность к регистру тем,
        'что в переменную всегда будут попадать преобразованные буквы в верхнем регистре.
        '
        'stCountry = stCountry.ToUpper

        'Вариант - не перезаписывать введённую пользователем переменную,
        'т.к. она может понадобиться далее в коде,
        'а преобразовывать её только для If тестов. 

        If stCountry.ToUpper = "AUSTRALIA" Then
            ' частное преобразование
            MsgBox("G'day mate")
            MsgBox("Good on ya")
            MsgBox("No worries")
        ElseIf stCountry.ToUpper = "FRANCE" Then
            ' частное преобразование
            MsgBox("Bonjour")
            MsgBox("Comment allez-vous?")
        ElseIf stCountry.ToUpper = "JAPAN" Then
            ' частное преобразование
            MsgBox("Konnichiwa")
            MsgBox("Choushi wa dou desu ka")
        Else
            MsgBox("Hello there")
            MsgBox("I hope, you are well")
        End If

        MsgBox("You entered " & stCountry)
        ' изначально введённая пользователем переменная

    End Sub
End Class
