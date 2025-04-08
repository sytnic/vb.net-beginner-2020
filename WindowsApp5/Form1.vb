Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        stOccupation = lstOccupation.SelectedItem  'Это значение берётся из поля списка с названием lstOccupation

        MsgBox("hello " & stFirstName & " " & stLastName & " you are a " & stGender & " " & stOccupation)
    End Sub
End Class
