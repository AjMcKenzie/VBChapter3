Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString = txtDayOfWeek.Text & ", " & txtMonth.Text & ", " & txtDayOfMonth.Text & ", " & txtYear.Text
    End Sub
End Class
