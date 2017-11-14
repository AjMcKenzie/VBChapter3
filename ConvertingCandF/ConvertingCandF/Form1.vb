Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decDegreeF As Decimal

        Try
            lblConverting.Show()
            lblArrow1.Show()
            lblArrow2.Show()
            lblArrow3.Show()

            decDegreeF = (txtCDegreeInput.Text) * 1.8 + 32
            lblConvert.Text = decDegreeF.ToString & "°F"

        Catch
            lblError.Text = "Error: Enter an input"
            lblConverting.Hide()
            lblArrow1.Hide()
            lblArrow2.Hide()
            lblArrow3.Hide()

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCDegreeInput.Clear()
        lblConvert.Text = String.Empty
        lblError.Text = String.Empty
        txtCDegreeInput.Focus()
        lblConverting.Hide()
        lblArrow1.Hide()
        lblArrow2.Hide()
        lblArrow3.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
