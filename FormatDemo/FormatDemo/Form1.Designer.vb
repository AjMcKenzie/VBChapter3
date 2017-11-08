<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEnterNumber = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.btnFixedPointFormat = New System.Windows.Forms.Button()
        Me.btnExponentialFormat = New System.Windows.Forms.Button()
        Me.btnCurrencyFormat = New System.Windows.Forms.Button()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number or a date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Formatted:"
        '
        'txtEnterNumber
        '
        Me.txtEnterNumber.Location = New System.Drawing.Point(154, 20)
        Me.txtEnterNumber.Name = "txtEnterNumber"
        Me.txtEnterNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterNumber.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(154, 48)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(138, 20)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.btnPercentFormat)
        Me.GroupBox1.Controls.Add(Me.btnCurrencyFormat)
        Me.GroupBox1.Controls.Add(Me.btnExponentialFormat)
        Me.GroupBox1.Controls.Add(Me.btnFixedPointFormat)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 198)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format:"
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(21, 19)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnNumberFormat.TabIndex = 0
        Me.btnNumberFormat.Text = "Number format (n)"
        Me.btnNumberFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'btnFixedPointFormat
        '
        Me.btnFixedPointFormat.Location = New System.Drawing.Point(21, 48)
        Me.btnFixedPointFormat.Name = "btnFixedPointFormat"
        Me.btnFixedPointFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnFixedPointFormat.TabIndex = 1
        Me.btnFixedPointFormat.Text = "Fixed-point Format (f)"
        Me.btnFixedPointFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFixedPointFormat.UseVisualStyleBackColor = True
        '
        'btnExponentialFormat
        '
        Me.btnExponentialFormat.Location = New System.Drawing.Point(21, 77)
        Me.btnExponentialFormat.Name = "btnExponentialFormat"
        Me.btnExponentialFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnExponentialFormat.TabIndex = 2
        Me.btnExponentialFormat.Text = "Exponential format (e)"
        Me.btnExponentialFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExponentialFormat.UseVisualStyleBackColor = True
        '
        'btnCurrencyFormat
        '
        Me.btnCurrencyFormat.Location = New System.Drawing.Point(21, 106)
        Me.btnCurrencyFormat.Name = "btnCurrencyFormat"
        Me.btnCurrencyFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnCurrencyFormat.TabIndex = 3
        Me.btnCurrencyFormat.Text = "Currency format (c)"
        Me.btnCurrencyFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCurrencyFormat.UseVisualStyleBackColor = True
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(21, 135)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(119, 23)
        Me.btnPercentFormat.TabIndex = 4
        Me.btnPercentFormat.Text = "Percent format (p)"
        Me.btnPercentFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(165, 19)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(95, 23)
        Me.btnShortDate.TabIndex = 5
        Me.btnShortDate.Text = "Short date (d)"
        Me.btnShortDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(165, 48)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(95, 23)
        Me.btnLongDate.TabIndex = 6
        Me.btnLongDate.Text = "Long date (D)"
        Me.btnLongDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(165, 77)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(95, 23)
        Me.btnShortTime.TabIndex = 7
        Me.btnShortTime.Text = "Short time (t)"
        Me.btnShortTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(165, 106)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(95, 23)
        Me.btnLongTime.TabIndex = 8
        Me.btnLongTime.Text = "Long time (T)"
        Me.btnLongTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(165, 135)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(95, 23)
        Me.btnFullDateTime.TabIndex = 9
        Me.btnFullDateTime.Text = "Full date/time (F)"
        Me.btnFullDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(35, 169)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 169)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtEnterNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEnterNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyFormat As System.Windows.Forms.Button
    Friend WithEvents btnExponentialFormat As System.Windows.Forms.Button
    Friend WithEvents btnFixedPointFormat As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
