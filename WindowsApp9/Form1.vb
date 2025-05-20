Public Class Form1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        ' Однострочный if
        'If stCountry = "Australia" Then MsgBox("G'day mate")

        ' Многострочный if
        If stCountry = "Australia" Then
            MsgBox("G'day mate")
            MsgBox("Good on ya")
            MsgBox("No worries")
        ElseIf stCountry = "France" Then
            MsgBox("Bonjour")
            MsgBox("Comment allez-vous?")
        ElseIf stCountry = "Japan" Then
            MsgBox("Konnichiwa")
            MsgBox("Choushi wa dou desu ka")
        Else
            MsgBox("Hello there")
            MsgBox("I hope, you are well")
        End If

    End Sub
End Class
