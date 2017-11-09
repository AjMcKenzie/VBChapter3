Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal
        Dim intPayPeriods As Integer
        Dim decSalary As Decimal
        lblStatus.Text = String.Empty

        Try
            decAnnualSalary = CDec(txtAnnualSalary.Text)
            intPayPeriods = CInt(txtPayPeriods.Text)

            decSalary = decAnnualSalary / intPayPeriods

            lblStatus.Text = decSalary.ToString("c")
        Catch
            lblStatus.Text = "Error: Be sure to enter nonzero " & "numeric values"
        End Try
    End Sub
End Class
