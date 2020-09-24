<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dbFormIndagine
    Inherits DB_BASE

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dbFormIndagine))
        Me.bsIndagine = New System.Windows.Forms.BindingSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAnnulla = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConferma = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.bsIndagine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsIndagine
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 438)
        Me.Panel1.TabIndex = 1
        '
        'BtnAnnulla
        '
        Me.BtnAnnulla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnnulla.Location = New System.Drawing.Point(532, 488)
        Me.BtnAnnulla.Name = "BtnAnnulla"
        Me.BtnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnnulla.TabIndex = 2
        Me.BtnAnnulla.Text = "Indietro"
        '
        'btnConferma
        '
        Me.btnConferma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConferma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConferma.Location = New System.Drawing.Point(451, 488)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(75, 23)
        Me.btnConferma.TabIndex = 3
        Me.btnConferma.Text = "Conferma"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 447)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 72)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'dbFormIndagine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 523)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnConferma)
        Me.Controls.Add(Me.BtnAnnulla)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "dbFormIndagine"
        Me.Text = "dbFormIndagine"
        CType(Me.bsIndagine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAnnulla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConferma As DevExpress.XtraEditors.SimpleButton
    Public WithEvents bsIndagine As System.Windows.Forms.BindingSource
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
