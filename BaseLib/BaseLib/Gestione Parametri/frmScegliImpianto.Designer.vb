<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScegliImpianto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScegliImpianto))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnConferma = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.DsElencoImpianti = New BaseLib.dsElencoImpianti()
        Me.DsElencoImpiantiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsElencoImpianti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsElencoImpiantiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(103, 23)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Installazione"
        '
        'btnConferma
        '
        Me.btnConferma.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConferma.Appearance.Options.UseFont = True
        Me.btnConferma.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnConferma.Location = New System.Drawing.Point(12, 59)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(384, 67)
        Me.btnConferma.TabIndex = 2
        Me.btnConferma.Text = "Conferma"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(121, 12)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", 200, "Nome Negozio")})
        Me.LookUpEdit1.Properties.DataSource = Me.DsElencoImpiantiBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "Nome"
        Me.LookUpEdit1.Properties.ValueMember = "ID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(275, 30)
        Me.LookUpEdit1.TabIndex = 3
        '
        'DsElencoImpianti
        '
        Me.DsElencoImpianti.DataSetName = "dsElencoImpianti"
        Me.DsElencoImpianti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsElencoImpiantiBindingSource
        '
        Me.DsElencoImpiantiBindingSource.DataMember = "ElencoImpianti"
        Me.DsElencoImpiantiBindingSource.DataSource = Me.DsElencoImpianti
        '
        'frmScegliImpianto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 142)
        Me.ControlBox = False
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Me.btnConferma)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScegliImpianto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scelta Installazione"
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsElencoImpianti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsElencoImpiantiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnConferma As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsElencoImpiantiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsElencoImpianti As BaseLib.dsElencoImpianti
End Class
