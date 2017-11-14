Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAverageScore, dectotal As Decimal

        Try
            dectotal = CDec(txtScore1.Text) + CDec(txtScore2.Text) + CDec(txtScore3.Text) + CDec(txtScore4.Text) + CDec(txtScore5.Text)
            decAverageScore = dectotal / 5
            lblAverage.Text = decAverageScore.ToString("n2")
        Catch
            lblError.Text = "Enter numaric values into all input."
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        txtScore4.Clear()
        txtScore5.Clear()
        lblAverage.Text = String.Empty
        lblError.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
