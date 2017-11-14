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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCDegreeInput = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblArrow1 = New System.Windows.Forms.Label()
        Me.lblConverting = New System.Windows.Forms.Label()
        Me.lblArrow2 = New System.Windows.Forms.Label()
        Me.lblArrow3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(12, 178)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(157, 178)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(309, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtCDegreeInput
        '
        Me.txtCDegreeInput.Location = New System.Drawing.Point(6, 68)
        Me.txtCDegreeInput.Name = "txtCDegreeInput"
        Me.txtCDegreeInput.Size = New System.Drawing.Size(110, 20)
        Me.txtCDegreeInput.TabIndex = 6
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(12, 208)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(372, 19)
        Me.lblError.TabIndex = 7
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArrow3)
        Me.GroupBox1.Controls.Add(Me.lblArrow2)
        Me.GroupBox1.Controls.Add(Me.lblConverting)
        Me.GroupBox1.Controls.Add(Me.lblArrow1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCDegreeInput)
        Me.GroupBox1.Controls.Add(Me.lblConvert)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 125)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversion:"
        '
        'lblConvert
        '
        Me.lblConvert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConvert.Location = New System.Drawing.Point(192, 71)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(128, 17)
        Me.lblConvert.TabIndex = 6
        Me.lblConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Celsius"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fahrenheit"
        '
        'lblArrow1
        '
        Me.lblArrow1.AutoSize = True
        Me.lblArrow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrow1.Location = New System.Drawing.Point(122, 71)
        Me.lblArrow1.Name = "lblArrow1"
        Me.lblArrow1.Size = New System.Drawing.Size(24, 16)
        Me.lblArrow1.TabIndex = 9
        Me.lblArrow1.Text = "→"
        Me.lblArrow1.Visible = False
        '
        'lblConverting
        '
        Me.lblConverting.AutoSize = True
        Me.lblConverting.Location = New System.Drawing.Point(128, 56)
        Me.lblConverting.Name = "lblConverting"
        Me.lblConverting.Size = New System.Drawing.Size(58, 13)
        Me.lblConverting.TabIndex = 10
        Me.lblConverting.Text = "Converting"
        Me.lblConverting.Visible = False
        '
        'lblArrow2
        '
        Me.lblArrow2.AutoSize = True
        Me.lblArrow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrow2.Location = New System.Drawing.Point(141, 71)
        Me.lblArrow2.Name = "lblArrow2"
        Me.lblArrow2.Size = New System.Drawing.Size(24, 16)
        Me.lblArrow2.TabIndex = 11
        Me.lblArrow2.Text = "→"
        Me.lblArrow2.Visible = False
        '
        'lblArrow3
        '
        Me.lblArrow3.AutoSize = True
        Me.lblArrow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrow3.Location = New System.Drawing.Point(162, 72)
        Me.lblArrow3.Name = "lblArrow3"
        Me.lblArrow3.Size = New System.Drawing.Size(24, 16)
        Me.lblArrow3.TabIndex = 11
        Me.lblArrow3.Text = "→"
        Me.lblArrow3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 245)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtCDegreeInput As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArrow1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblConvert As System.Windows.Forms.Label
    Friend WithEvents lblConverting As System.Windows.Forms.Label
    Friend WithEvents lblArrow3 As System.Windows.Forms.Label
    Friend WithEvents lblArrow2 As System.Windows.Forms.Label

End Class
