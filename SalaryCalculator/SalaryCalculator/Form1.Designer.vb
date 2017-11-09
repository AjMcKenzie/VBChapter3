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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtAnnualSalary = New System.Windows.Forms.TextBox()
        Me.txtPayPeriods = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Annual Salary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pay periods per year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salary per pay period:"
        '
        'lblSalary
        '
        Me.lblSalary.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalary.Location = New System.Drawing.Point(121, 100)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(120, 20)
        Me.lblSalary.TabIndex = 3
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAnnualSalary
        '
        Me.txtAnnualSalary.Location = New System.Drawing.Point(121, 18)
        Me.txtAnnualSalary.Name = "txtAnnualSalary"
        Me.txtAnnualSalary.Size = New System.Drawing.Size(120, 20)
        Me.txtAnnualSalary.TabIndex = 4
        '
        'txtPayPeriods
        '
        Me.txtPayPeriods.Location = New System.Drawing.Point(121, 58)
        Me.txtPayPeriods.Name = "txtPayPeriods"
        Me.txtPayPeriods.Size = New System.Drawing.Size(120, 20)
        Me.txtPayPeriods.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(121, 138)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(0, 174)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(317, 18)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(317, 191)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPayPeriods)
        Me.Controls.Add(Me.txtAnnualSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Salary Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents txtAnnualSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtPayPeriods As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
