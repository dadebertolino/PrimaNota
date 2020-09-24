<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpgrade
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUnlock = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHardwareKey = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.txtUnlock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHardwareKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnlock
        '
        Me.txtUnlock.Location = New System.Drawing.Point(83, 114)
        Me.txtUnlock.Name = "txtUnlock"
        Me.txtUnlock.Size = New System.Drawing.Size(493, 96)
        Me.txtUnlock.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 116)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Unlock Code"
        '
        'txtHardwareKey
        '
        Me.txtHardwareKey.Location = New System.Drawing.Point(83, 12)
        Me.txtHardwareKey.Name = "txtHardwareKey"
        Me.txtHardwareKey.Properties.ReadOnly = True
        Me.txtHardwareKey.Size = New System.Drawing.Size(493, 96)
        Me.txtHardwareKey.TabIndex = 8
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Hardware Key"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(501, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Unlock"
        '
        'frmUpgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 250)
        Me.Controls.Add(Me.txtUnlock)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtHardwareKey)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUpgrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upgrade"
        CType(Me.txtUnlock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHardwareKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUnlock As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHardwareKey As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
