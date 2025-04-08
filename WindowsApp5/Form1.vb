Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String

        stFirstName = txtFirstName.Text   'Это значение берётся из текстового поля с названием txtFirstName
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        MsgBox("hello " & stFirstName & " " & stLastName & " you are a " & stGender)
    End Sub
End Class
