<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadFile
    Inherits DevExpress.XtraEditors.XtraForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUploadFile))
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.lcInfoOperazione = New DevExpress.XtraEditors.LabelControl()
        Me.lcProgresso = New DevExpress.XtraEditors.LabelControl()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(12, 55)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(352, 39)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'lcInfoOperazione
        '
        Me.lcInfoOperazione.Location = New System.Drawing.Point(125, 12)
        Me.lcInfoOperazione.Name = "lcInfoOperazione"
        Me.lcInfoOperazione.Size = New System.Drawing.Size(111, 13)
        Me.lcInfoOperazione.TabIndex = 1
        Me.lcInfoOperazione.Text = "Upload dei dati in corso"
        '
        'lcProgresso
        '
        Me.lcProgresso.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lcProgresso.Location = New System.Drawing.Point(12, 31)
        Me.lcProgresso.Name = "lcProgresso"
        Me.lcProgresso.Size = New System.Drawing.Size(352, 18)
        Me.lcProgresso.TabIndex = 2
        '
        'frmUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 106)
        Me.ControlBox = False
        Me.Controls.Add(Me.lcProgresso)
        Me.Controls.Add(Me.lcInfoOperazione)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload a MyShop Customer Portal"
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents lcInfoOperazione As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcProgresso As DevExpress.XtraEditors.LabelControl
End Class
