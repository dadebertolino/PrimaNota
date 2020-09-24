<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDettaglioRegistrazione
    Inherits BaseLib.DBFormRecord

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
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.XPCTipoRegistrazione = New DevExpress.Xpo.XPCollection(Me.components)
        Me.cmbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCliFor = New DevExpress.XtraEditors.LabelControl()
        Me.XPCConto = New DevExpress.Xpo.XPCollection(Me.components)
        Me.cmbConto = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpPagamento = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpScadenza = New DevExpress.XtraEditors.DateEdit()
        Me.txtDescrizione = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCliFor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValore = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.XPCTipoRegistrazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPCConto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbConto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpPagamento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpPagamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpScadenza.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpScadenza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrizione.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConferma
        '
        Me.btnConferma.Location = New System.Drawing.Point(713, 396)
        Me.btnConferma.TabIndex = 14
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Location = New System.Drawing.Point(632, 396)
        '
        'XPCTipoRegistrazione
        '
        Me.XPCTipoRegistrazione.ObjectType = GetType(PrimaNota.DAL.TipoRegistrazione)
        '
        'cmbTipo
        '
        Me.cmbTipo.Location = New System.Drawing.Point(109, 12)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Spesa", "Spesa", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PercentualeDetrazione", "Percentuale Detrazione", 122, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.cmbTipo.Properties.DataSource = Me.XPCTipoRegistrazione
        Me.cmbTipo.Properties.DisplayMember = "Descrizione"
        Me.cmbTipo.Properties.NullText = "[Selezionare il tipo]"
        Me.cmbTipo.Properties.ValueMember = "This"
        Me.cmbTipo.Size = New System.Drawing.Size(459, 20)
        Me.cmbTipo.TabIndex = 1
        '
        'lblCliFor
        '
        Me.lblCliFor.Location = New System.Drawing.Point(80, 15)
        Me.lblCliFor.Name = "lblCliFor"
        Me.lblCliFor.Size = New System.Drawing.Size(20, 13)
        Me.lblCliFor.TabIndex = 0
        Me.lblCliFor.Text = "Tipo"
        '
        'XPCConto
        '
        Me.XPCConto.ObjectType = GetType(PrimaNota.DAL.Conto)
        '
        'cmbConto
        '
        Me.cmbConto.Location = New System.Drawing.Point(109, 38)
        Me.cmbConto.Name = "cmbConto"
        Me.cmbConto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbConto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbConto.Properties.DataSource = Me.XPCConto
        Me.cmbConto.Properties.DisplayMember = "Descrizione"
        Me.cmbConto.Properties.NullText = "[Selezionare il conto]"
        Me.cmbConto.Properties.ValueMember = "This"
        Me.cmbConto.Size = New System.Drawing.Size(459, 20)
        Me.cmbConto.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(71, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Conto"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Data Pagamento"
        '
        'dtpPagamento
        '
        Me.dtpPagamento.EditValue = Nothing
        Me.dtpPagamento.Location = New System.Drawing.Point(109, 116)
        Me.dtpPagamento.Name = "dtpPagamento"
        Me.dtpPagamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpPagamento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpPagamento.Size = New System.Drawing.Size(143, 20)
        Me.dtpPagamento.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(31, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Data Scadenza"
        '
        'dtpScadenza
        '
        Me.dtpScadenza.EditValue = Nothing
        Me.dtpScadenza.Location = New System.Drawing.Point(109, 90)
        Me.dtpScadenza.Name = "dtpScadenza"
        Me.dtpScadenza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpScadenza.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpScadenza.Size = New System.Drawing.Size(143, 20)
        Me.dtpScadenza.TabIndex = 7
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Location = New System.Drawing.Point(109, 64)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(300, 20)
        Me.txtDescrizione.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(46, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Descrizione"
        '
        'txtCliFor
        '
        Me.txtCliFor.Location = New System.Drawing.Point(109, 142)
        Me.txtCliFor.Name = "txtCliFor"
        Me.txtCliFor.Size = New System.Drawing.Size(300, 20)
        Me.txtCliFor.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(22, 145)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Cliente/Fornitore"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(73, 171)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Valore"
        '
        'txtValore
        '
        Me.txtValore.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValore.Location = New System.Drawing.Point(109, 168)
        Me.txtValore.Name = "txtValore"
        Me.txtValore.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtValore.Properties.DisplayFormat.FormatString = "C2"
        Me.txtValore.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValore.Size = New System.Drawing.Size(80, 20)
        Me.txtValore.TabIndex = 13
        '
        'frmDettaglioRegistrazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtValore)
        Me.Controls.Add(Me.txtCliFor)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtpPagamento)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.dtpScadenza)
        Me.Controls.Add(Me.cmbConto)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.lblCliFor)
        Me.Name = "frmDettaglioRegistrazione"
        Me.Text = "Dettaglio Registrazione"
        Me.Controls.SetChildIndex(Me.btnConferma, 0)
        Me.Controls.SetChildIndex(Me.btnAnnulla, 0)
        Me.Controls.SetChildIndex(Me.lblCliFor, 0)
        Me.Controls.SetChildIndex(Me.cmbTipo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.cmbConto, 0)
        Me.Controls.SetChildIndex(Me.dtpScadenza, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.dtpPagamento, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.txtDescrizione, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.txtCliFor, 0)
        Me.Controls.SetChildIndex(Me.txtValore, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        CType(Me.XPCTipoRegistrazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPCConto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbConto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpPagamento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpPagamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpScadenza.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpScadenza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrizione.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XPCTipoRegistrazione As DevExpress.Xpo.XPCollection
    Friend WithEvents cmbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCliFor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XPCConto As DevExpress.Xpo.XPCollection
    Friend WithEvents cmbConto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpPagamento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpScadenza As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDescrizione As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCliFor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValore As DevExpress.XtraEditors.SpinEdit
End Class
