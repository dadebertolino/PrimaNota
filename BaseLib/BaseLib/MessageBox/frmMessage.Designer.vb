Namespace Messaging
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MessageForm
        Inherits DevExpress.XtraEditors.XtraForm

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageForm))
            Me.tmTimeOut = New System.Windows.Forms.Timer(Me.components)
            Me.tmShowObjects = New System.Windows.Forms.Timer(Me.components)
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.cmdButton3 = New DevExpress.XtraEditors.BaseButton()
            Me.cmdButton2 = New DevExpress.XtraEditors.BaseButton()
            Me.cmdButton1 = New DevExpress.XtraEditors.BaseButton()
            Me.pnlBody = New DevExpress.XtraEditors.PanelControl()
            Me.txtMessage = New System.Windows.Forms.RichTextBox()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.pnlBody, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBody.SuspendLayout()
            Me.SuspendLayout()
            '
            'tmTimeOut
            '
            Me.tmTimeOut.Interval = 1000
            '
            'tmShowObjects
            '
            '
            'GroupControl1
            '
            Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupControl1.AppearanceCaption.Options.UseFont = True
            Me.GroupControl1.Controls.Add(Me.cmdButton3)
            Me.GroupControl1.Controls.Add(Me.cmdButton2)
            Me.GroupControl1.Controls.Add(Me.cmdButton1)
            Me.GroupControl1.Controls.Add(Me.pnlBody)
            Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(334, 162)
            Me.GroupControl1.TabIndex = 0
            Me.GroupControl1.Text = "GroupControl1"
            '
            'cmdButton3
            '
            Me.cmdButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdButton3.Appearance.Options.UseFont = True
            Me.cmdButton3.Location = New System.Drawing.Point(226, 127)
            Me.cmdButton3.Name = "cmdButton3"
            Me.cmdButton3.Size = New System.Drawing.Size(81, 23)
            Me.cmdButton3.TabIndex = 8
            Me.cmdButton3.Text = "Button3"
            Me.cmdButton3.Visible = False
            '
            'cmdButton2
            '
            Me.cmdButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdButton2.Appearance.Options.UseFont = True
            Me.cmdButton2.Location = New System.Drawing.Point(135, 127)
            Me.cmdButton2.Name = "cmdButton2"
            Me.cmdButton2.Size = New System.Drawing.Size(81, 23)
            Me.cmdButton2.TabIndex = 7
            Me.cmdButton2.Text = "Button2"
            Me.cmdButton2.Visible = False
            '
            'cmdButton1
            '
            Me.cmdButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cmdButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdButton1.Appearance.Options.UseFont = True
            Me.cmdButton1.Location = New System.Drawing.Point(44, 127)
            Me.cmdButton1.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
            Me.cmdButton1.Name = "cmdButton1"
            Me.cmdButton1.Size = New System.Drawing.Size(81, 23)
            Me.cmdButton1.TabIndex = 6
            Me.cmdButton1.Text = "Button1"
            Me.cmdButton1.Visible = False
            '
            'pnlBody
            '
            Me.pnlBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlBody.Controls.Add(Me.txtMessage)
            Me.pnlBody.Location = New System.Drawing.Point(0, 31)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Size = New System.Drawing.Size(334, 88)
            Me.pnlBody.TabIndex = 5
            '
            'txtMessage
            '
            Me.txtMessage.BackColor = System.Drawing.Color.White
            Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtMessage.HideSelection = False
            Me.txtMessage.Location = New System.Drawing.Point(2, 2)
            Me.txtMessage.Name = "txtMessage"
            Me.txtMessage.ReadOnly = True
            Me.txtMessage.Size = New System.Drawing.Size(330, 84)
            Me.txtMessage.TabIndex = 0
            Me.txtMessage.TabStop = False
            Me.txtMessage.Text = "Here is some text..."
            '
            'MessageForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(334, 162)
            Me.Controls.Add(Me.GroupControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MessageForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "frmMessage"
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            CType(Me.pnlBody, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBody.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tmTimeOut As System.Windows.Forms.Timer
        Friend WithEvents tmShowObjects As System.Windows.Forms.Timer
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents cmdButton3 As DevExpress.XtraEditors.BaseButton
        Friend WithEvents cmdButton2 As DevExpress.XtraEditors.BaseButton
        Friend WithEvents cmdButton1 As DevExpress.XtraEditors.BaseButton
        Friend WithEvents pnlBody As DevExpress.XtraEditors.PanelControl
        Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    End Class
End Namespace
