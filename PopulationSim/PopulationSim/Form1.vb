Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim population As Double = 7000
        Dim curentyear As Integer = 2012

        Do Until population <= 6
            curentyear = curentyear - 50
            population = population / 2


        Loop
        MessageBox.Show("The year is" & curentyear)


    End Sub
End Class
