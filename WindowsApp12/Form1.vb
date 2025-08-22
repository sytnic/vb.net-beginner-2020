Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim iTemperature As Integer
        ' присвоение и преобразование типа в integer
        iTemperature = CInt(txtTemperature.Text)

        Dim iWindSpeed As Integer
        iWindSpeed = 30

        'If может проверить несколько переменных за раз

        'If iTemperature <= 0 And iWindSpeed > 20 Then
        '    MsgBox("That will feel really cold")
        'End If

        'Case проверяет только одну переменную за раз
        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("Water will freeze")
                MsgBox("and you can go skating")
            Case Is < 0
                MsgBox("Sub zero")
                'If можно вкладывать в конструкцию Case
                If iWindSpeed > 20 Then
                    MsgBox("That will feel really cold")
                End If
            Case 1 To 10    '1 и 10 включительно
                MsgBox("Cold")
            Case 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select

    End Sub
End Class
