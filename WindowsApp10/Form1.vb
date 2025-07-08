Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer
        iScore = txtExamScore.Text

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
