<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBAbout
    Inherits DevExpress.XtraEditors.XtraForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBAbout))
        Me.OKButton = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBoxDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelCompanyName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelVersion = New DevExpress.XtraEditors.LabelControl()
        Me.LabelProductName = New DevExpress.XtraEditors.LabelControl()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCopyright = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRegistra = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TextBoxDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(401, 349)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDescription.EditValue = resources.GetString("TextBoxDescription.EditValue")
        Me.TextBoxDescription.Location = New System.Drawing.Point(14, 87)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Properties.ReadOnly = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(447, 104)
        Me.TextBoxDescription.TabIndex = 0
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.UseOptimizedRendering = True
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCompanyName.Location = New System.Drawing.Point(14, 63)
        Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(64, 13)
        Me.LabelCompanyName.TabIndex = 0
        Me.LabelCompanyName.Text = "Nome società"
        '
        'LabelVersion
        '
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(14, 21)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(41, 13)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Versione"
        '
        'LabelProductName
        '
        Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductName.Location = New System.Drawing.Point(14, 0)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(72, 13)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Nome prodotto"
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.724138!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.27586!))
        Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(12, 141)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 5
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(464, 194)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LabelCopyright
        '
        Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCopyright.Location = New System.Drawing.Point(14, 42)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(47, 13)
        Me.LabelCopyright.TabIndex = 1
        Me.LabelCopyright.Text = "Copyright"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(103, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 123)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnRegistra
        '
        Me.btnRegistra.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegistra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistra.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRegistra.Location = New System.Drawing.Point(320, 349)
        Me.btnRegistra.Name = "btnRegistra"
        Me.btnRegistra.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistra.TabIndex = 3
        Me.btnRegistra.Text = "&Registra"
        '
        'DBAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(487, 384)
        Me.Controls.Add(Me.btnRegistra)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DBAbout"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About..."
        CType(Me.TextBoxDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OKButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBoxDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelCompanyName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelProductName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelCopyright As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRegistra As DevExpress.XtraEditors.SimpleButton

End Class
