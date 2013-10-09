Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim number As Integer = 1
        Dim sqrt As Integer
        Do While number <= 10
            sqrt = (number) ^ 2
            lstResult.Items.Add(sqrt)
            number = number + 1
        Loop


    End Sub
End Class
