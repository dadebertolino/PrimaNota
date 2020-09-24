<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTipoRegistrazione
    Inherits BaseLib.DBFormTableDB_XPO

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
        Me.xpcTipoRegistrazione = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpesa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentualeDetrazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescrizione = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.chkSpesa = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPercDetrazione = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.lbsNavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormContainer.Panel1.SuspendLayout()
        Me.FormContainer.Panel2.SuspendLayout()
        Me.FormContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpcTipoRegistrazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrizione.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSpesa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercDetrazione.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(713, 565)
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(633, 565)
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Location = New System.Drawing.Point(472, 565)
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Location = New System.Drawing.Point(552, 565)
        '
        'lbsNavigazione
        '
        Me.lbsNavigazione.DataSource = Me.xpcTipoRegistrazione
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Location = New System.Drawing.Point(713, 565)
        '
        'btnConferma
        '
        Me.btnConferma.Location = New System.Drawing.Point(633, 565)
        '
        'FormContainer
        '
        '
        'FormContainer.Panel1
        '
        Me.FormContainer.Panel1.Controls.Add(Me.GridControl1)
        '
        'FormContainer.Panel2
        '
        Me.FormContainer.Panel2.Controls.Add(Me.LabelControl12)
        Me.FormContainer.Panel2.Controls.Add(Me.txtPercDetrazione)
        Me.FormContainer.Panel2.Controls.Add(Me.chkSpesa)
        Me.FormContainer.Panel2.Controls.Add(Me.txtDescrizione)
        Me.FormContainer.Panel2.Controls.Add(Me.LabelControl2)
        Me.FormContainer.Size = New System.Drawing.Size(800, 504)
        Me.FormContainer.SplitterDistance = 266
        Me.FormContainer.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 538)
        '
        'xpcTipoRegistrazione
        '
        Me.xpcTipoRegistrazione.ObjectType = GetType(PrimaNota.DAL.TipoRegistrazione)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.lbsNavigazione
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(266, 504)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colDescrizione, Me.colSpesa, Me.colPercentualeDetrazione})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        Me.colOid.OptionsColumn.ShowInCustomizationForm = False
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
        Me.colDescrizione.VisibleIndex = 0
        '
        'colSpesa
        '
        Me.colSpesa.FieldName = "Spesa"
        Me.colSpesa.Name = "colSpesa"
        Me.colSpesa.OptionsColumn.AllowEdit = False
        Me.colSpesa.OptionsColumn.AllowFocus = False
        Me.colSpesa.OptionsColumn.ReadOnly = True
        Me.colSpesa.OptionsColumn.TabStop = False
        Me.colSpesa.Visible = True
        Me.colSpesa.VisibleIndex = 1
        '
        'colPercentualeDetrazione
        '
        Me.colPercentualeDetrazione.FieldName = "PercentualeDetrazione"
        Me.colPercentualeDetrazione.Name = "colPercentualeDetrazione"
        Me.colPercentualeDetrazione.OptionsColumn.AllowEdit = False
        Me.colPercentualeDetrazione.OptionsColumn.AllowFocus = False
        Me.colPercentualeDetrazione.OptionsColumn.ReadOnly = True
        Me.colPercentualeDetrazione.OptionsColumn.TabStop = False
        Me.colPercentualeDetrazione.Visible = True
        Me.colPercentualeDetrazione.VisibleIndex = 2
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Location = New System.Drawing.Point(111, 18)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(300, 20)
        Me.txtDescrizione.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(31, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Descrizione"
        '
        'chkSpesa
        '
        Me.chkSpesa.Location = New System.Drawing.Point(53, 44)
        Me.chkSpesa.Name = "chkSpesa"
        Me.chkSpesa.Properties.Caption = "Spesa"
        Me.chkSpesa.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSpesa.Size = New System.Drawing.Size(75, 19)
        Me.chkSpesa.TabIndex = 3
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(5, 72)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = "Perc. Detrazione"
        '
        'txtPercDetrazione
        '
        Me.txtPercDetrazione.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPercDetrazione.Location = New System.Drawing.Point(111, 69)
        Me.txtPercDetrazione.Name = "txtPercDetrazione"
        Me.txtPercDetrazione.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPercDetrazione.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPercDetrazione.Properties.Mask.EditMask = "n"
        Me.txtPercDetrazione.Properties.MaxValue = New Decimal(New Integer() {150, 0, 0, 0})
        Me.txtPercDetrazione.Size = New System.Drawing.Size(100, 20)
        Me.txtPercDetrazione.TabIndex = 11
        '
        'frmTipoRegistrazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 624)
        Me.Name = "frmTipoRegistrazione"
        Me.Text = "Gestione Tipi Registrazione"
        Me.xpcCollection = Me.xpcTipoRegistrazione
        CType(Me.lbsNavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.Panel1.ResumeLayout(False)
        Me.FormContainer.Panel2.ResumeLayout(False)
        Me.FormContainer.Panel2.PerformLayout()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpcTipoRegistrazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrizione.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSpesa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercDetrazione.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xpcTipoRegistrazione As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescrizione As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSpesa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentualeDetrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSpesa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPercDetrazione As DevExpress.XtraEditors.SpinEdit
End Class
