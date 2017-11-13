Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAverageScore As Decimal

        Try
            decAverageScore = (txtScore1.Text) + (txtScore2.Text) + (txtScore3.Text) + (txtScore4.Text) + (txtScore5.Text)
            lblAverage.Text = decAverageScore.ToString
        Catch

        End Try

    End Sub
End Class
