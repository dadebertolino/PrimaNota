<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DB_DIALOG_PARAMETRISTAMPA
    Inherits DB_DIALOG

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
        Me.btnEsci = New DevExpress.XtraEditors.BaseButton()
        Me.btnStampa = New DevExpress.XtraEditors.BaseButton()
        Me.SuspendLayout()
        '
        'btnEsci
        '
        Me.btnEsci.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEsci.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEsci.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEsci.Location = New System.Drawing.Point(205, 116)
        Me.btnEsci.Name = "btnEsci"
        Me.btnEsci.Size = New System.Drawing.Size(75, 23)
        Me.btnEsci.TabIndex = 1
        Me.btnEsci.Text = "Esci"
        '
        'btnStampa
        '
        Me.btnStampa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnStampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStampa.Location = New System.Drawing.Point(12, 116)
        Me.btnStampa.Name = "btnStampa"
        Me.btnStampa.Size = New System.Drawing.Size(75, 23)
        Me.btnStampa.TabIndex = 0
        Me.btnStampa.Text = "Stampa"
        '
        'DB_DIALOG_PARAMETRISTAMPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(292, 151)
        Me.Controls.Add(Me.btnEsci)
        Me.Controls.Add(Me.btnStampa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DB_DIALOG_PARAMETRISTAMPA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnStampa As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnEsci As DevExpress.XtraEditors.BaseButton
End Class
