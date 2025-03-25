Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("course")
        MsgBox("programming")
        MsgBox("VB.NET")
        MsgBox("the")
        MsgBox("to")
        MsgBox("welcome")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Kevin"
        stLastName = "Drumm"

        MsgBox("hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

        stFirstName = "Murvin"
        stLastName = "Drake"

        MsgBox("hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

    End Sub
End Class
