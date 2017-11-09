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
        Me.txtGallonsOfGas = New System.Windows.Forms.TextBox()
        Me.txtDrivenOnFullTank = New System.Windows.Forms.TextBox()
        Me.lblMilesPerGallonTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons of gas the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "car can hold:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can be driven on a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "full tank:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Miles per Gallon:"
        '
        'txtGallonsOfGas
        '
        Me.txtGallonsOfGas.Location = New System.Drawing.Point(122, 36)
        Me.txtGallonsOfGas.Name = "txtGallonsOfGas"
        Me.txtGallonsOfGas.Size = New System.Drawing.Size(91, 20)
        Me.txtGallonsOfGas.TabIndex = 1
        '
        'txtDrivenOnFullTank
        '
        Me.txtDrivenOnFullTank.Location = New System.Drawing.Point(124, 78)
        Me.txtDrivenOnFullTank.Name = "txtDrivenOnFullTank"
        Me.txtDrivenOnFullTank.Size = New System.Drawing.Size(100, 20)
        Me.txtDrivenOnFullTank.TabIndex = 2
        '
        'lblMilesPerGallonTotal
        '
        Me.lblMilesPerGallonTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMilesPerGallonTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMilesPerGallonTotal.Location = New System.Drawing.Point(124, 140)
        Me.lblMilesPerGallonTotal.Name = "lblMilesPerGallonTotal"
        Me.lblMilesPerGallonTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblMilesPerGallonTotal.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(29, 199)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(64, 44)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate MPG"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(124, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 44)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 271)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMilesPerGallonTotal)
        Me.Controls.Add(Me.txtDrivenOnFullTank)
        Me.Controls.Add(Me.txtGallonsOfGas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGallonsOfGas As System.Windows.Forms.TextBox
    Friend WithEvents txtDrivenOnFullTank As System.Windows.Forms.TextBox
    Friend WithEvents lblMilesPerGallonTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
