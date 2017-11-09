Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotalR As Decimal
        Dim decClassAT As Decimal
        Dim decClassBT As Decimal
        Dim decClassCT As Decimal

        decClassAT = (txtClassA.Text) * 15
        decClassBT = (txtClassB.Text) * 12
        decClassCT = (txtClassC.Text) * 9
        decTotalR = (decClassAT) + (decClassBT) + (decClassCT)

        lblClassA.Text = decClassAT.ToString("c")
        lblClassB.Text = decClassBT.ToString("c")
        lblClassC.Text = decClassCT.ToString("c")

        lblTotalRevenue.Text = decTotalR.ToString("c")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblTotalRevenue.Text = String.Empty

        txtClassA.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
