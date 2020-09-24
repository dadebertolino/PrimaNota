<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConto
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
        Me.xpcConti = New DevExpress.Xpo.XPCollection(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescrizione = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.lbsNavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormContainer.Panel1.SuspendLayout()
        Me.FormContainer.Panel2.SuspendLayout()
        Me.FormContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpcConti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrizione.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbsNavigazione.DataSource = Me.xpcConti
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
        Me.FormContainer.Panel2.Controls.Add(Me.txtDescrizione)
        Me.FormContainer.Panel2.Controls.Add(Me.LabelControl1)
        Me.FormContainer.Size = New System.Drawing.Size(800, 504)
        Me.FormContainer.SplitterDistance = 266
        Me.FormContainer.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 538)
        '
        'xpcConti
        '
        Me.xpcConti.ObjectType = GetType(PrimaNota.DAL.Conto)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Descrizione"
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Location = New System.Drawing.Point(89, 12)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(300, 20)
        Me.txtDescrizione.TabIndex = 1
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colDescrizione})
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
        '
        'colDescrizione
        '
        Me.colDescrizione.FieldName = "Descrizione"
        Me.colDescrizione.Name = "colDescrizione"
        Me.colDescrizione.OptionsColumn.AllowEdit = False
        Me.colDescrizione.OptionsColumn.AllowFocus = False
        Me.colDescrizione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescrizione.OptionsColumn.ReadOnly = True
        Me.colDescrizione.OptionsColumn.TabStop = False
        Me.colDescrizione.Visible = True
        Me.colDescrizione.VisibleIndex = 0
        '
        'frmConto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 624)
        Me.Name = "frmConto"
        Me.Text = "Gestione Conti"
        Me.xpcCollection = Me.xpcConti
        CType(Me.lbsNavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.Panel1.ResumeLayout(False)
        Me.FormContainer.Panel2.ResumeLayout(False)
        Me.FormContainer.Panel2.PerformLayout()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpcConti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrizione.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xpcConti As DevExpress.Xpo.XPCollection
    Friend WithEvents txtDescrizione As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescrizione As DevExpress.XtraGrid.Columns.GridColumn
End Class
