Public Class Form1
    Private Sub btnGo1_Click(sender As Object, e As EventArgs) Handles btnGo1.Click

        Dim iCount As Integer
        ' iCount без присвоения числа 
        ' по умолчанию будет равно нулю

        For iCount = 1 To 5
            MsgBox(" Hello " & iCount)
        Next

    End Sub

    Private Sub btnGo2_Click(sender As Object, e As EventArgs) Handles btnGo2.Click

        Dim iCount As Integer

        Do While iCount < 5
            iCount = iCount + 1
            MsgBox(" Hello " & iCount)
        Loop
        ' Вывод до 5 включительно

        MsgBox("all done")

    End Sub

    Private Sub btnGo3_Click(sender As Object, e As EventArgs) Handles btnGo3.Click

        Dim iCount As Integer

        Do Until iCount = 5
            iCount = iCount + 1
            MsgBox(" Hello " & iCount)
        Loop
        ' Вывод до 5 включительно

        MsgBox("all done")

    End Sub

    Private Sub btnGo4_Click(sender As Object, e As EventArgs) Handles btnGo4.Click

        Dim iCount As Integer

        Do
            iCount = iCount + 1
            MsgBox(" Hello " & iCount)
        Loop Until iCount = 5
        ' Вывод до 5 включительно

        MsgBox("all done")

    End Sub

    Private Sub btnGo5_Click(sender As Object, e As EventArgs) Handles btnGo5.Click

        Dim iCount As Integer

        Do
            iCount = iCount + 1
            MsgBox(" Hello " & iCount)
        Loop While iCount < 5
        ' Вывод до 5 включительно

        MsgBox("all done")

    End Sub
End Class
