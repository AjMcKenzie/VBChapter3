Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAssessmentValue As Decimal
        Dim decPropertyTax As Decimal

        Try
            decAssessmentValue = (txtActualProperty.Text) * 0.6
            decPropertyTax = (decAssessmentValue / 100) * 0.64

            lblAssessmentValue.Text = decAssessmentValue.ToString("c")
            lblPropertyTax.Text = decPropertyTax.ToString("c")
        Catch
            lblError.Text = "Error: Input a numaric value"
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtActualProperty.Clear()
        lblError.Text = String.Empty
        lblAssessmentValue.Text = String.Empty
        lblPropertyTax.Text = String.Empty

        txtActualProperty.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
