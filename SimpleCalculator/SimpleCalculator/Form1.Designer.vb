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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnExponant = New System.Windows.Forms.Button()
        Me.btnMOD = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operation:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Result"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(83, 221)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(138, 26)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(85, 22)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 5
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(85, 88)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 6
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(81, 126)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(43, 29)
        Me.btnPlus.TabIndex = 7
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(130, 126)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(43, 29)
        Me.btnMinus.TabIndex = 8
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(179, 126)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(43, 29)
        Me.btnTimes.TabIndex = 9
        Me.btnTimes.Text = "x"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(81, 173)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(43, 29)
        Me.btnDivide.TabIndex = 10
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnExponant
        '
        Me.btnExponant.Location = New System.Drawing.Point(130, 173)
        Me.btnExponant.Name = "btnExponant"
        Me.btnExponant.Size = New System.Drawing.Size(43, 29)
        Me.btnExponant.TabIndex = 11
        Me.btnExponant.Text = "^"
        Me.btnExponant.UseVisualStyleBackColor = True
        '
        'btnMOD
        '
        Me.btnMOD.Location = New System.Drawing.Point(179, 173)
        Me.btnMOD.Name = "btnMOD"
        Me.btnMOD.Size = New System.Drawing.Size(43, 29)
        Me.btnMOD.TabIndex = 12
        Me.btnMOD.Text = "MOD"
        Me.btnMOD.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(22, 266)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(162, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.Location = New System.Drawing.Point(126, 55)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(0, 20)
        Me.lblOperation.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 300)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMOD)
        Me.Controls.Add(Me.btnExponant)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnTimes As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnExponant As System.Windows.Forms.Button
    Friend WithEvents btnMOD As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblOperation As System.Windows.Forms.Label

End Class
