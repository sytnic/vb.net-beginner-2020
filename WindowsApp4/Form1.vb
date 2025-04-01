Public Class Form1
    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColour = "red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2020#  ' Это 2 ноября, американский формат

        ' MsgBox("the car is " & stMake & " " & stModel & " " &
        '   iDoors & " " & stColour & " " & bTaxed & " " &
        '   iEngineSize & " " & decPrice & " " & dtDateRegistered)

        MsgBox("the car is " & stMake & vbNewLine & stModel & vbNewLine &
            iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine &
            iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)
    End Sub
End Class
