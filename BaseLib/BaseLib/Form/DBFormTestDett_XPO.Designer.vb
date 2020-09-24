<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBFormTestDett_XPO
    Inherits BaseLib.DBFormBase

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAnnulla = New DevExpress.XtraEditors.BaseButton()
        Me.btnConferma = New DevExpress.XtraEditors.BaseButton()
        Me.btnDeleteRecord = New DevExpress.XtraEditors.BaseButton()
        Me.btnNewRecord = New DevExpress.XtraEditors.BaseButton()
        Me.btnIndietro = New DevExpress.XtraEditors.BaseButton()
        Me.btnModifica = New DevExpress.XtraEditors.BaseButton()
        Me.FormContainer = New System.Windows.Forms.SplitContainer()
        Me.btnIndagine = New DevExpress.XtraEditors.BaseButton()
        Me.btnCarica = New DevExpress.XtraEditors.BaseButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.BaseLib.WaitForm1), True, True)
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormContainer.Panel1.SuspendLayout()
        Me.FormContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnnulla
        '
        Me.btnAnnulla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAnnulla.Location = New System.Drawing.Point(670, 502)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 21
        Me.btnAnnulla.Text = "Annulla"
        '
        'btnConferma
        '
        Me.btnConferma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConferma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConferma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConferma.Location = New System.Drawing.Point(590, 502)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(75, 23)
        Me.btnConferma.TabIndex = 20
        Me.btnConferma.Text = "Ok"
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDeleteRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDeleteRecord.Location = New System.Drawing.Point(509, 502)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteRecord.TabIndex = 19
        Me.btnDeleteRecord.Text = "Cancella"
        '
        'btnNewRecord
        '
        Me.btnNewRecord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNewRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNewRecord.Location = New System.Drawing.Point(508, 216)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnNewRecord.TabIndex = 18
        Me.btnNewRecord.Text = "Nuovo"
        '
        'btnIndietro
        '
        Me.btnIndietro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIndietro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIndietro.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIndietro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnIndietro.Location = New System.Drawing.Point(670, 502)
        Me.btnIndietro.Name = "btnIndietro"
        Me.btnIndietro.Size = New System.Drawing.Size(75, 23)
        Me.btnIndietro.TabIndex = 17
        Me.btnIndietro.Text = "Annulla"
        '
        'btnModifica
        '
        Me.btnModifica.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifica.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnModifica.Location = New System.Drawing.Point(590, 502)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(75, 23)
        Me.btnModifica.TabIndex = 16
        Me.btnModifica.Text = "Ok"
        '
        'FormContainer
        '
        Me.FormContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormContainer.Location = New System.Drawing.Point(0, 3)
        Me.FormContainer.Name = "FormContainer"
        Me.FormContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'FormContainer.Panel1
        '
        Me.FormContainer.Panel1.Controls.Add(Me.btnIndagine)
        Me.FormContainer.Panel1.Controls.Add(Me.btnCarica)
        Me.FormContainer.Panel1.Controls.Add(Me.btnNewRecord)
        Me.FormContainer.Size = New System.Drawing.Size(757, 450)
        Me.FormContainer.SplitterDistance = 252
        Me.FormContainer.TabIndex = 22
        '
        'btnIndagine
        '
        Me.btnIndagine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIndagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIndagine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnIndagine.Location = New System.Drawing.Point(670, 216)
        Me.btnIndagine.Name = "btnIndagine"
        Me.btnIndagine.Size = New System.Drawing.Size(75, 23)
        Me.btnIndagine.TabIndex = 20
        Me.btnIndagine.Text = "Indagine"
        '
        'btnCarica
        '
        Me.btnCarica.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCarica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCarica.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCarica.Location = New System.Drawing.Point(589, 216)
        Me.btnCarica.Name = "btnCarica"
        Me.btnCarica.Size = New System.Drawing.Size(75, 23)
        Me.btnCarica.TabIndex = 19
        Me.btnCarica.Text = "Carica"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 459)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 66)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'DBFormTestDett_XPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 556)
        Me.Controls.Add(Me.FormContainer)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnConferma)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnIndietro)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "DBFormTestDett_XPO"
        Me.Text = "DBFormTestDett"
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnModifica, 0)
        Me.Controls.SetChildIndex(Me.btnIndietro, 0)
        Me.Controls.SetChildIndex(Me.btnDeleteRecord, 0)
        Me.Controls.SetChildIndex(Me.btnConferma, 0)
        Me.Controls.SetChildIndex(Me.btnAnnulla, 0)
        Me.Controls.SetChildIndex(Me.FormContainer, 0)
        Me.FormContainer.Panel1.ResumeLayout(False)
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents btnAnnulla As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnConferma As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnDeleteRecord As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnNewRecord As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnIndietro As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnModifica As DevExpress.XtraEditors.BaseButton
    Public WithEvents FormContainer As System.Windows.Forms.SplitContainer
    Public WithEvents btnIndagine As DevExpress.XtraEditors.BaseButton
    Public WithEvents btnCarica As DevExpress.XtraEditors.BaseButton
    Private WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
