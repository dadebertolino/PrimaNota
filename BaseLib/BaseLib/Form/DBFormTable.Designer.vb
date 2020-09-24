<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBFormTable
    Inherits BaseLib.DBFormBase

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBFormTable))
        Me.tsbNavigazione = New System.Windows.Forms.ToolStrip
        Me.tbbGotoFirst = New System.Windows.Forms.ToolStripButton
        Me.tbbGotoPrev = New System.Windows.Forms.ToolStripButton
        Me.tstCurrent = New System.Windows.Forms.ToolStripTextBox
        Me.txlCount = New System.Windows.Forms.ToolStripLabel
        Me.tbbGotoNext = New System.Windows.Forms.ToolStripButton
        Me.tbbGotoLast = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tbbEdit = New System.Windows.Forms.ToolStripButton
        Me.tbbNew = New System.Windows.Forms.ToolStripButton
        Me.tbbDelete = New System.Windows.Forms.ToolStripButton
        Me.tbbSave = New System.Windows.Forms.ToolStripButton
        Me.tbbBack = New System.Windows.Forms.ToolStripButton
        Me.tbbStampa = New System.Windows.Forms.ToolStripButton
        Me.btnCancel = New DevExpress.XtraEditors.BaseButton
        Me.btnOk = New DevExpress.XtraEditors.BaseButton
        Me.btnDeleteRecord = New DevExpress.XtraEditors.BaseButton
        Me.btnNewRecord = New DevExpress.XtraEditors.BaseButton
        Me.lbsNavigazione = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAnnulla = New DevExpress.XtraEditors.BaseButton
        Me.btnConferma = New DevExpress.XtraEditors.BaseButton
        Me.FormContainer = New System.Windows.Forms.SplitContainer
        Me.tsbNavigazione.SuspendLayout()
        CType(Me.lbsNavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbNavigazione
        '
        Me.tsbNavigazione.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbGotoFirst, Me.tbbGotoPrev, Me.tstCurrent, Me.txlCount, Me.tbbGotoNext, Me.tbbGotoLast, Me.ToolStripSeparator3, Me.tbbEdit, Me.tbbNew, Me.tbbDelete, Me.tbbSave, Me.tbbBack, Me.tbbStampa})
        Me.tsbNavigazione.Location = New System.Drawing.Point(0, 0)
        Me.tsbNavigazione.Name = "tsbNavigazione"
        Me.tsbNavigazione.Size = New System.Drawing.Size(757, 25)
        Me.tsbNavigazione.TabIndex = 6
        Me.tsbNavigazione.Text = "tsbNavigazione"
        '
        'tbbGotoFirst
        '
        Me.tbbGotoFirst.AutoSize = False
        Me.tbbGotoFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbGotoFirst.Image = CType(resources.GetObject("tbbGotoFirst.Image"), System.Drawing.Image)
        Me.tbbGotoFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbGotoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbGotoFirst.Name = "tbbGotoFirst"
        Me.tbbGotoFirst.Size = New System.Drawing.Size(23, 22)
        Me.tbbGotoFirst.Text = "ToolStripButton1"
        '
        'tbbGotoPrev
        '
        Me.tbbGotoPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbGotoPrev.Image = CType(resources.GetObject("tbbGotoPrev.Image"), System.Drawing.Image)
        Me.tbbGotoPrev.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbGotoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbGotoPrev.Name = "tbbGotoPrev"
        Me.tbbGotoPrev.Size = New System.Drawing.Size(23, 22)
        Me.tbbGotoPrev.Text = "ToolStripButton1"
        '
        'tstCurrent
        '
        Me.tstCurrent.AccessibleName = "Position"
        Me.tstCurrent.AutoSize = False
        Me.tstCurrent.Name = "tstCurrent"
        Me.tstCurrent.Size = New System.Drawing.Size(50, 21)
        Me.tstCurrent.Text = "0"
        Me.tstCurrent.ToolTipText = "Current position"
        '
        'txlCount
        '
        Me.txlCount.Name = "txlCount"
        Me.txlCount.Size = New System.Drawing.Size(35, 22)
        Me.txlCount.Text = "of {0}"
        Me.txlCount.ToolTipText = "Total number of items"
        '
        'tbbGotoNext
        '
        Me.tbbGotoNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbGotoNext.Image = CType(resources.GetObject("tbbGotoNext.Image"), System.Drawing.Image)
        Me.tbbGotoNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbGotoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbGotoNext.Name = "tbbGotoNext"
        Me.tbbGotoNext.Size = New System.Drawing.Size(23, 22)
        Me.tbbGotoNext.Text = "ToolStripButton1"
        '
        'tbbGotoLast
        '
        Me.tbbGotoLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbGotoLast.Image = CType(resources.GetObject("tbbGotoLast.Image"), System.Drawing.Image)
        Me.tbbGotoLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbGotoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbGotoLast.Name = "tbbGotoLast"
        Me.tbbGotoLast.Size = New System.Drawing.Size(23, 22)
        Me.tbbGotoLast.Text = "tbbGotoLast"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbbEdit
        '
        Me.tbbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbEdit.Image = CType(resources.GetObject("tbbEdit.Image"), System.Drawing.Image)
        Me.tbbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbEdit.Name = "tbbEdit"
        Me.tbbEdit.Size = New System.Drawing.Size(23, 22)
        Me.tbbEdit.Text = "ToolStripButton2"
        '
        'tbbNew
        '
        Me.tbbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbNew.Image = CType(resources.GetObject("tbbNew.Image"), System.Drawing.Image)
        Me.tbbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbNew.Name = "tbbNew"
        Me.tbbNew.Size = New System.Drawing.Size(23, 22)
        Me.tbbNew.Text = "ToolStripButton1"
        '
        'tbbDelete
        '
        Me.tbbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbDelete.Image = CType(resources.GetObject("tbbDelete.Image"), System.Drawing.Image)
        Me.tbbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbDelete.Name = "tbbDelete"
        Me.tbbDelete.Size = New System.Drawing.Size(23, 22)
        Me.tbbDelete.Text = "ToolStripButton1"
        '
        'tbbSave
        '
        Me.tbbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbSave.Image = CType(resources.GetObject("tbbSave.Image"), System.Drawing.Image)
        Me.tbbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbSave.Name = "tbbSave"
        Me.tbbSave.Size = New System.Drawing.Size(23, 22)
        Me.tbbSave.Text = "ToolStripButton1"
        '
        'tbbBack
        '
        Me.tbbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbBack.Image = CType(resources.GetObject("tbbBack.Image"), System.Drawing.Image)
        Me.tbbBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbBack.Name = "tbbBack"
        Me.tbbBack.Size = New System.Drawing.Size(23, 22)
        Me.tbbBack.Text = "ToolStripButton1"
        '
        'tbbStampa
        '
        Me.tbbStampa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbStampa.Image = CType(resources.GetObject("tbbStampa.Image"), System.Drawing.Image)
        Me.tbbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbStampa.Name = "tbbStampa"
        Me.tbbStampa.Size = New System.Drawing.Size(23, 22)
        Me.tbbStampa.Text = "ToolStripButton1"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(670, 505)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Annulla"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOk.Location = New System.Drawing.Point(590, 505)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDeleteRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDeleteRecord.Location = New System.Drawing.Point(429, 505)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteRecord.TabIndex = 10
        Me.btnDeleteRecord.Text = "Cancella"
        '
        'btnNewRecord
        '
        Me.btnNewRecord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNewRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNewRecord.Location = New System.Drawing.Point(509, 505)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnNewRecord.TabIndex = 9
        Me.btnNewRecord.Text = "Nuovo"
        '
        'lbsNavigazione
        '
        '
        'btnAnnulla
        '
        Me.btnAnnulla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAnnulla.Location = New System.Drawing.Point(670, 505)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 12
        Me.btnAnnulla.Text = "Annulla"
        '
        'btnConferma
        '
        Me.btnConferma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConferma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConferma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConferma.Location = New System.Drawing.Point(590, 505)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(75, 23)
        Me.btnConferma.TabIndex = 11
        Me.btnConferma.Text = "Ok"
        '
        'FormContainer
        '
        Me.FormContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormContainer.Location = New System.Drawing.Point(0, 28)
        Me.FormContainer.Name = "FormContainer"
        Me.FormContainer.Size = New System.Drawing.Size(757, 471)
        Me.FormContainer.SplitterDistance = 252
        Me.FormContainer.TabIndex = 13
        '
        'DBFormTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(757, 556)
        Me.Controls.Add(Me.FormContainer)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnConferma)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnNewRecord)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.tsbNavigazione)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "DBFormTable"
        Me.Controls.SetChildIndex(Me.tsbNavigazione, 0)
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnNewRecord, 0)
        Me.Controls.SetChildIndex(Me.btnDeleteRecord, 0)
        Me.Controls.SetChildIndex(Me.btnConferma, 0)
        Me.Controls.SetChildIndex(Me.btnAnnulla, 0)
        Me.Controls.SetChildIndex(Me.FormContainer, 0)
        Me.tsbNavigazione.ResumeLayout(False)
        Me.tsbNavigazione.PerformLayout()
        CType(Me.lbsNavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbbGotoFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbbGotoPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstCurrent As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txlCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tbbGotoNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbbGotoLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbbEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbbBack As System.Windows.Forms.ToolStripButton
    Public WithEvents btnCancel As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnOk As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnDeleteRecord As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnNewRecord As DevExpress.XtraEditors.BaseButton
    Protected WithEvents tsbNavigazione As System.Windows.Forms.ToolStrip
    Public WithEvents lbsNavigazione As System.Windows.Forms.BindingSource
    Public WithEvents btnAnnulla As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnConferma As DevExpress.XtraEditors.BaseButton
    Public WithEvents FormContainer As System.Windows.Forms.SplitContainer
    Public WithEvents tbbNew As System.Windows.Forms.ToolStripButton
    Public WithEvents tbbDelete As System.Windows.Forms.ToolStripButton
    Public WithEvents tbbStampa As System.Windows.Forms.ToolStripButton

End Class
