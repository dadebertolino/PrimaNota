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
        Me.DbNumericUDEuro1 = New BaseLib.DBNumericUDEuro
        Me.DbTextBoxNumericOnly2 = New BaseLib.DBTextBoxNumericOnly
        Me.DbTextBoxNumericOnly1 = New BaseLib.DBTextBoxNumericOnly
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        CType(Me.DbNumericUDEuro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbNumericUDEuro1
        '
        Me.DbNumericUDEuro1.DecimalPlaces = 2
        Me.DbNumericUDEuro1.Location = New System.Drawing.Point(12, 64)
        Me.DbNumericUDEuro1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.DbNumericUDEuro1.Name = "DbNumericUDEuro1"
        Me.DbNumericUDEuro1.Size = New System.Drawing.Size(100, 20)
        Me.DbNumericUDEuro1.TabIndex = 2
        Me.DbNumericUDEuro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DbTextBoxNumericOnly2
        '
        Me.DbTextBoxNumericOnly2.AllowNull = True
        Me.DbTextBoxNumericOnly2.Location = New System.Drawing.Point(12, 38)
        Me.DbTextBoxNumericOnly2.Name = "DbTextBoxNumericOnly2"
        Me.DbTextBoxNumericOnly2.Size = New System.Drawing.Size(100, 20)
        Me.DbTextBoxNumericOnly2.TabIndex = 1
        Me.DbTextBoxNumericOnly2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DbTextBoxNumericOnly1
        '
        Me.DbTextBoxNumericOnly1.AllowNull = False
        Me.DbTextBoxNumericOnly1.Location = New System.Drawing.Point(12, 12)
        Me.DbTextBoxNumericOnly1.Name = "DbTextBoxNumericOnly1"
        Me.DbTextBoxNumericOnly1.Size = New System.Drawing.Size(100, 20)
        Me.DbTextBoxNumericOnly1.TabIndex = 0
        Me.DbTextBoxNumericOnly1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 145)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DbNumericUDEuro1)
        Me.Controls.Add(Me.DbTextBoxNumericOnly2)
        Me.Controls.Add(Me.DbTextBoxNumericOnly1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DbNumericUDEuro1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbTextBoxNumericOnly1 As BaseLib.DBTextBoxNumericOnly
    Friend WithEvents DbTextBoxNumericOnly2 As BaseLib.DBTextBoxNumericOnly
    Friend WithEvents DbNumericUDEuro1 As BaseLib.DBNumericUDEuro
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
