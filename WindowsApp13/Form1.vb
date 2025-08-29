Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer
        Dim stOut As String

        ' Цикл будет повторяться 50 раз в обратном порядке, но с шагом выполнения 5
        'For iCount = 50 To 0 Step -5
        '  MsgBox(iCount)
        'Next

        ' Вывести все сообщения в одном окне
        For iCount = 50 To 0 Step -5
            ' Сбор всех данных в одну строку в цикле,
            ' приращение на подобие var.=
            stOut = stOut & iCount & vbNewLine
        Next

        MsgBox(stOut)

    End Sub
End Class
