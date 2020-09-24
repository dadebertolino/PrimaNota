<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBFrmParametri
    Inherits DB_BASE

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBFrmParametri))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConferma = New DevExpress.XtraEditors.BaseButton()
        Me.BtnAnnulla = New DevExpress.XtraEditors.BaseButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 392)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 73)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnConferma
        '
        Me.btnConferma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConferma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConferma.Location = New System.Drawing.Point(531, 433)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(75, 23)
        Me.btnConferma.TabIndex = 17
        Me.btnConferma.Text = "Conferma"
        '
        'BtnAnnulla
        '
        Me.BtnAnnulla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnnulla.Location = New System.Drawing.Point(612, 433)
        Me.BtnAnnulla.Name = "BtnAnnulla"
        Me.BtnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnnulla.TabIndex = 16
        Me.BtnAnnulla.Text = "Indietro"
        '
        'DBFrmParametri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 468)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnConferma)
        Me.Controls.Add(Me.BtnAnnulla)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DBFrmParametri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DBFrmParametri"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConferma As DevExpress.XtraEditors.BaseButton
    Friend WithEvents BtnAnnulla As DevExpress.XtraEditors.BaseButton
End Class
