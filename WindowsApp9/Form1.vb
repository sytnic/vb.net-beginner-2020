Public Class Form1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        ' If чувствительны к регистру.  
        'Можно убрать чувствительность к регистру тем,
        'что в переменную всегда будут попадать преобразованные буквы в верхнем регистре.  
        stCountry = stCountry.ToUpper

        If stCountry = "AUSTRALIA" Then
            MsgBox("G'day mate")
            MsgBox("Good on ya")
            MsgBox("No worries")
        ElseIf stCountry = "FRANCE" Then
            MsgBox("Bonjour")
            MsgBox("Comment allez-vous?")
        ElseIf stCountry = "JAPAN" Then
            MsgBox("Konnichiwa")
            MsgBox("Choushi wa dou desu ka")
        Else
            MsgBox("Hello there")
            MsgBox("I hope, you are well")
        End If

    End Sub
End Class
