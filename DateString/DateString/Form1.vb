﻿Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString.Text = txtDayOfWeek.Text & ", " & txtMonth.Text & " " & txtDayOfMonth.Text & ", " & txtYear.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayOfWeek.Clear()
        txtMonth.Clear()
        txtDayOfMonth.Clear()
        txtYear.Clear()
        lblDateString.Text = String.Empty

        txtMonth.Focus()
    End Sub
End Class
