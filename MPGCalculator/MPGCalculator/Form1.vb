Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decMilesPerGallonTotal As Decimal

        Try
            decMilesPerGallonTotal = (txtDrivenOnFullTank.Text) / (txtGallonsOfGas.Text)

            lblMilesPerGallonTotal.Text = decMilesPerGallonTotal.ToString("n2")

        Catch
            lblStatus.Text = "Error: Be sure to enter nonzero " & "numeric values"

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDrivenOnFullTank.Clear()
        txtGallonsOfGas.Clear()
        lblMilesPerGallonTotal.Text = String.Empty

        txtGallonsOfGas.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
