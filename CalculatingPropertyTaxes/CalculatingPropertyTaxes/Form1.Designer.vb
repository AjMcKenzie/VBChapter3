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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAssessmentValue = New System.Windows.Forms.Label()
        Me.lblPropertyTax = New System.Windows.Forms.Label()
        Me.txtActualProperty = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actual Property Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Assessment and Tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Assessment Value:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Property tax:"
        '
        'lblAssessmentValue
        '
        Me.lblAssessmentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAssessmentValue.Location = New System.Drawing.Point(264, 39)
        Me.lblAssessmentValue.Name = "lblAssessmentValue"
        Me.lblAssessmentValue.Size = New System.Drawing.Size(99, 13)
        Me.lblAssessmentValue.TabIndex = 4
        Me.lblAssessmentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPropertyTax
        '
        Me.lblPropertyTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPropertyTax.Location = New System.Drawing.Point(264, 81)
        Me.lblPropertyTax.Name = "lblPropertyTax"
        Me.lblPropertyTax.Size = New System.Drawing.Size(99, 13)
        Me.lblPropertyTax.TabIndex = 5
        Me.lblPropertyTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtActualProperty
        '
        Me.txtActualProperty.Location = New System.Drawing.Point(15, 31)
        Me.txtActualProperty.Name = "txtActualProperty"
        Me.txtActualProperty.Size = New System.Drawing.Size(100, 20)
        Me.txtActualProperty.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 119)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(152, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(307, 119)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(12, 160)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(370, 19)
        Me.lblError.TabIndex = 10
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 181)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtActualProperty)
        Me.Controls.Add(Me.lblPropertyTax)
        Me.Controls.Add(Me.lblAssessmentValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Property Taxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAssessmentValue As System.Windows.Forms.Label
    Friend WithEvents lblPropertyTax As System.Windows.Forms.Label
    Friend WithEvents txtActualProperty As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class
