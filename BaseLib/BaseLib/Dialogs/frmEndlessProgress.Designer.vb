<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndlessProgress
    Inherits DB_DIALOG

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndlessProgress))
        Me.lblText = New DevExpress.XtraEditors.LabelControl
        Me.ProgressControl2 = New BaseLib.ProgressControl
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(12, 9)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(268, 55)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Label1"
        '
        'ProgressControl2
        '
        Me.ProgressControl2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.ProgressControl2.IndicatorColor = System.Drawing.Color.SteelBlue
        Me.ProgressControl2.Location = New System.Drawing.Point(2, 67)
        Me.ProgressControl2.Name = "ProgressControl2"
        Me.ProgressControl2.Position = 0
        Me.ProgressControl2.Size = New System.Drawing.Size(289, 24)
        Me.ProgressControl2.TabIndex = 2
        '
        'frmEndlessProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 99)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressControl2)
        Me.Controls.Add(Me.lblText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEndlessProgress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgressControl2 As BaseLib.ProgressControl
End Class
