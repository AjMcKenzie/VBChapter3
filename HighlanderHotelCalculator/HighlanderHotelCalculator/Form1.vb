Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        Try
            'Calculate and display the room charges
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNighltyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            'Calculate and display the additional charges
            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            'Calculate and display the subtotal
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            'Calculate and display the tax
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            'Calculate and display the total
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")
        Catch
            'Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear room info
        txtNights.Clear()
        txtNighltyCharge.Clear()

        'Clear additional charges
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        'Clear the decTotal
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        'Get today's date and current time
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")

        'change focus to txtNights
        txtNights.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
