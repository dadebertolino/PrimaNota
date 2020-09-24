<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrimaNota
    Inherits BaseLib.DB_DIALOG

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gcPrimaNota = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.XPC_Registrazioni = New DevExpress.Xpo.XPCollection(Me.components)
        Me.gvDettaglio = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataScadenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataPagamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClienteFornitore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUscite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModalitaPagamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValoreAmmortamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCarica = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.btnModifica = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStampa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChiudi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancella = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuova = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcPrimaNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPC_Registrazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcPrimaNota
        '
        Me.gcPrimaNota.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPrimaNota.DataSource = Me.BindingSource1
        Me.gcPrimaNota.Location = New System.Drawing.Point(12, 36)
        Me.gcPrimaNota.MainView = Me.gvDettaglio
        Me.gcPrimaNota.Name = "gcPrimaNota"
        Me.gcPrimaNota.Size = New System.Drawing.Size(958, 543)
        Me.gcPrimaNota.TabIndex = 40
        Me.gcPrimaNota.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDettaglio})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.XPC_Registrazioni
        '
        'XPC_Registrazioni
        '
        Me.XPC_Registrazioni.ObjectType = GetType(PrimaNota.DAL.Registrazione)
        '
        'gvDettaglio
        '
        Me.gvDettaglio.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colDataScadenza, Me.colDataPagamento, Me.colDescrizione, Me.GridColumn1, Me.GridColumn3, Me.colClienteFornitore, Me.colEntrate, Me.colUscite, Me.colModalitaPagamento, Me.colValoreAmmortamento})
        Me.gvDettaglio.GridControl = Me.gcPrimaNota
        Me.gvDettaglio.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Entrate", Me.colEntrate, "C2"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Uscite", Me.colUscite, "C2")})
        Me.gvDettaglio.Name = "gvDettaglio"
        Me.gvDettaglio.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDettaglio.OptionsView.EnableAppearanceOddRow = True
        Me.gvDettaglio.OptionsView.ShowDetailButtons = False
        Me.gvDettaglio.OptionsView.ShowFooter = True
        Me.gvDettaglio.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colDataScadenza
        '
        Me.colDataScadenza.FieldName = "DataScadenza"
        Me.colDataScadenza.Name = "colDataScadenza"
        Me.colDataScadenza.OptionsColumn.AllowEdit = False
        Me.colDataScadenza.OptionsColumn.AllowFocus = False
        Me.colDataScadenza.OptionsColumn.ReadOnly = True
        Me.colDataScadenza.OptionsColumn.TabStop = False
        Me.colDataScadenza.Visible = True
        Me.colDataScadenza.VisibleIndex = 0
        '
        'colDataPagamento
        '
        Me.colDataPagamento.FieldName = "DataPagamento"
        Me.colDataPagamento.Name = "colDataPagamento"
        Me.colDataPagamento.OptionsColumn.AllowEdit = False
        Me.colDataPagamento.OptionsColumn.AllowFocus = False
        Me.colDataPagamento.OptionsColumn.ReadOnly = True
        Me.colDataPagamento.OptionsColumn.TabStop = False
        Me.colDataPagamento.Visible = True
        Me.colDataPagamento.VisibleIndex = 1
        '
        'colDescrizione
        '
        Me.colDescrizione.FieldName = "Descrizione"
        Me.colDescrizione.Name = "colDescrizione"
        Me.colDescrizione.OptionsColumn.AllowEdit = False
        Me.colDescrizione.OptionsColumn.AllowFocus = False
        Me.colDescrizione.OptionsColumn.ReadOnly = True
        Me.colDescrizione.OptionsColumn.TabStop = False
        Me.colDescrizione.Visible = True
        Me.colDescrizione.VisibleIndex = 2
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tipo Mov."
        Me.GridColumn1.FieldName = "Tipo.Descrizione"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsColumn.TabStop = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Conto"
        Me.GridColumn3.FieldName = "Conto.Descrizione"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsColumn.TabStop = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'colClienteFornitore
        '
        Me.colClienteFornitore.FieldName = "ClienteFornitore"
        Me.colClienteFornitore.Name = "colClienteFornitore"
        Me.colClienteFornitore.OptionsColumn.AllowEdit = False
        Me.colClienteFornitore.OptionsColumn.AllowFocus = False
        Me.colClienteFornitore.OptionsColumn.ReadOnly = True
        Me.colClienteFornitore.OptionsColumn.TabStop = False
        Me.colClienteFornitore.Visible = True
        Me.colClienteFornitore.VisibleIndex = 5
        '
        'colEntrate
        '
        Me.colEntrate.DisplayFormat.FormatString = "C2"
        Me.colEntrate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEntrate.FieldName = "Entrate"
        Me.colEntrate.Name = "colEntrate"
        Me.colEntrate.OptionsColumn.AllowEdit = False
        Me.colEntrate.OptionsColumn.AllowFocus = False
        Me.colEntrate.OptionsColumn.ReadOnly = True
        Me.colEntrate.OptionsColumn.TabStop = False
        Me.colEntrate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Entrate", "€ {0:N2}")})
        Me.colEntrate.Visible = True
        Me.colEntrate.VisibleIndex = 6
        '
        'colUscite
        '
        Me.colUscite.DisplayFormat.FormatString = "C2"
        Me.colUscite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUscite.FieldName = "Uscite"
        Me.colUscite.Name = "colUscite"
        Me.colUscite.OptionsColumn.AllowEdit = False
        Me.colUscite.OptionsColumn.AllowFocus = False
        Me.colUscite.OptionsColumn.ReadOnly = True
        Me.colUscite.OptionsColumn.TabStop = False
        Me.colUscite.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Uscite", "€ {0:N2}")})
        Me.colUscite.Visible = True
        Me.colUscite.VisibleIndex = 7
        '
        'colModalitaPagamento
        '
        Me.colModalitaPagamento.FieldName = "ModalitaPagamento"
        Me.colModalitaPagamento.Name = "colModalitaPagamento"
        Me.colModalitaPagamento.OptionsColumn.AllowEdit = False
        Me.colModalitaPagamento.OptionsColumn.AllowFocus = False
        Me.colModalitaPagamento.OptionsColumn.ReadOnly = True
        Me.colModalitaPagamento.OptionsColumn.TabStop = False
        Me.colModalitaPagamento.Visible = True
        Me.colModalitaPagamento.VisibleIndex = 9
        '
        'colValoreAmmortamento
        '
        Me.colValoreAmmortamento.DisplayFormat.FormatString = "C2"
        Me.colValoreAmmortamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValoreAmmortamento.FieldName = "ValoreAmmortamento"
        Me.colValoreAmmortamento.Name = "colValoreAmmortamento"
        Me.colValoreAmmortamento.OptionsColumn.AllowEdit = False
        Me.colValoreAmmortamento.OptionsColumn.AllowFocus = False
        Me.colValoreAmmortamento.OptionsColumn.ReadOnly = True
        Me.colValoreAmmortamento.OptionsColumn.TabStop = False
        Me.colValoreAmmortamento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValoreAmmortamento", "€ {0:N2}")})
        Me.colValoreAmmortamento.Visible = True
        Me.colValoreAmmortamento.VisibleIndex = 8
        '
        'btnCarica
        '
        Me.btnCarica.Location = New System.Drawing.Point(422, 7)
        Me.btnCarica.Name = "btnCarica"
        Me.btnCarica.Size = New System.Drawing.Size(75, 23)
        Me.btnCarica.TabIndex = 41
        Me.btnCarica.Text = "Carica"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(67, 9)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(143, 20)
        Me.DateEdit1.TabIndex = 42
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 43
        Me.LabelControl1.Text = "Dalla Data"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(224, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Alla Data"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(273, 9)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(143, 20)
        Me.DateEdit2.TabIndex = 44
        '
        'btnModifica
        '
        Me.btnModifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifica.Location = New System.Drawing.Point(733, 595)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(75, 23)
        Me.btnModifica.TabIndex = 48
        Me.btnModifica.Text = "Modifica"
        '
        'btnStampa
        '
        Me.btnStampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStampa.Location = New System.Drawing.Point(895, 595)
        Me.btnStampa.Name = "btnStampa"
        Me.btnStampa.Size = New System.Drawing.Size(75, 23)
        Me.btnStampa.TabIndex = 47
        Me.btnStampa.Text = "Stampa"
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnChiudi.Location = New System.Drawing.Point(12, 595)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(75, 23)
        Me.btnChiudi.TabIndex = 46
        Me.btnChiudi.Text = "Chiudi"
        '
        'btnCancella
        '
        Me.btnCancella.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancella.Location = New System.Drawing.Point(814, 595)
        Me.btnCancella.Name = "btnCancella"
        Me.btnCancella.Size = New System.Drawing.Size(75, 23)
        Me.btnCancella.TabIndex = 49
        Me.btnCancella.Text = "Cancella"
        '
        'btnNuova
        '
        Me.btnNuova.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuova.Location = New System.Drawing.Point(652, 595)
        Me.btnNuova.Name = "btnNuova"
        Me.btnNuova.Size = New System.Drawing.Size(75, 23)
        Me.btnNuova.TabIndex = 50
        Me.btnNuova.Text = "Nuovo"
        '
        'frmPrimaNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 630)
        Me.Controls.Add(Me.btnNuova)
        Me.Controls.Add(Me.btnCancella)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.btnStampa)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.DateEdit2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.btnCarica)
        Me.Controls.Add(Me.gcPrimaNota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrimaNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prima Nota"
        CType(Me.gcPrimaNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPC_Registrazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gcPrimaNota As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDettaglio As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCarica As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnModifica As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStampa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChiudi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancella As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuova As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents XPC_Registrazioni As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataScadenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClienteFornitore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUscite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModalitaPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValoreAmmortamento As DevExpress.XtraGrid.Columns.GridColumn
End Class
