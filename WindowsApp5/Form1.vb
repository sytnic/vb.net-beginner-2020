Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stFirstName As String

        stFirstName = InputBox("please enter your first name")

        MsgBox("hello " & stFirstName)
    End Sub
End Class
