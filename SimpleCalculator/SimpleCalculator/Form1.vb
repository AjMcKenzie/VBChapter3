Public Class Form1

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim dblResult As Double

        lblOperation.Text = " + "

        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim dblResult As Double

        lblOperation.Text = " - "

        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        Dim dblResult As Double

        lblOperation.Text = " * "

        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim dblResult As Double

        lblOperation.Text = " / "

        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExponant_Click(sender As Object, e As EventArgs) Handles btnExponant.Click
        Dim dblResult As Double

        lblOperation.Text = " ^ "

        dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMOD_Click(sender As Object, e As EventArgs) Handles btnMOD.Click
        Dim intResult As Integer

        lblOperation.Text = "MOD "

        intResult = CDbl(txtNumber1.Text) Mod CDbl(txtNumber2.Text)

        lblResult.Text = CStr(intResult)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblResult.Text = String.Empty
        lblOperation.Text = String.Empty

        txtNumber1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
