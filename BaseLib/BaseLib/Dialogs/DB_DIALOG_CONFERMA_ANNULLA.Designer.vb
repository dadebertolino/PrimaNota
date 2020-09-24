<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DB_DIALOG_CONFERMA_ANNULLA
    Inherits BaseLib.DB_DIALOG

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
        Me.btnConferma = New DevExpress.XtraEditors.BaseButton()
        Me.btnAnnulla = New DevExpress.XtraEditors.BaseButton()
        Me.SuspendLayout()
        '
        'btnConferma
        '
        Me.btnConferma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConferma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConferma.Location = New System.Drawing.Point(12, 61)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(75, 23)
        Me.btnConferma.TabIndex = 0
        Me.btnConferma.Text = "Conferma"
        '
        'btnAnnulla
        '
        Me.btnAnnulla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulla.Location = New System.Drawing.Point(205, 61)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 1
        Me.btnAnnulla.Text = "Annulla"
        '
        'DB_DIALOG_CONFERMA_ANNULLA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(292, 96)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnConferma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DB_DIALOG_CONFERMA_ANNULLA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB_DIALOG_CONFERMA_ANNULLA"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnConferma As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnAnnulla As DevExpress.XtraEditors.BaseButton

End Class
