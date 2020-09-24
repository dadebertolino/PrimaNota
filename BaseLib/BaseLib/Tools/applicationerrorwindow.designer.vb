'============================================================================================
' ? Copyright, 2005-2008 MicroFour, Inc., All rights reserved.
'
' This software and its associated documentation contain valuable trade secrets 
' and proprietary information belonging to MicroFour, Inc.  None of the software
' or its associated documentation may be stored in a retrieval system, copied,
' transmitted, distributed, transcribed or reproduced in any other way or disclosed
' to any third parties without the express written permission of MicroFour, Inc.  
'
' UNDER NO CIRCUMSTANCES SHALL MICROFOUR, INC. BE LIABLE FOR INCIDENTAL, SPECIAL,
' INDIRECT, DIRECT OR CONSEQUENTIAL DAMAGES OR LOSS OF PROFITS, INTERRUPTION OF 
' BUSINESS, OR RELATED EXPENSES WHICH MAY ARISE FROM THE USE OF SOFTWARE OR DOCUMENTATION, 
' INCLUDING BUT NOT LIMITED TO THOSE RESULTING FROM DEFECTS IN SOFTWARE AND/OR DOCUMENTATION,
' OR LOSS OR INACCURACY OF DATA OF ANY KIND.
'--------------------------------------------------------------------------------------------
' ANY USE OF THIS CODE CONSTITUTES ACCEPTANCE OF THE TERMS OF THE COPYRIGHT NOTICE
'--------------------------------------------------------------------------------------------
' DO NOT REMOVE THIS DISCLAIMER
'============================================================================================


Partial Public Class ApplicationErrorWindow
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplicationErrorWindow))
        Me.BaseButton1 = New DevExpress.XtraEditors.BaseButton()
        Me.btnSimpleEmail = New DevExpress.XtraEditors.BaseButton()
        Me.lcTesto = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtError = New DevExpress.XtraEditors.MemoEdit()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseButton1
        '
        Me.BaseButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaseButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaseButton1.Appearance.Image = CType(resources.GetObject("BaseButton1.Appearance.Image"), System.Drawing.Image)
        Me.BaseButton1.Appearance.Options.UseFont = True
        Me.BaseButton1.Appearance.Options.UseImage = True
        Me.BaseButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BaseButton1.Location = New System.Drawing.Point(457, 372)
        Me.BaseButton1.Name = "BaseButton1"
        Me.BaseButton1.Size = New System.Drawing.Size(118, 45)
        Me.BaseButton1.TabIndex = 3
        Me.BaseButton1.Text = "Chiudi"
        '
        'btnSimpleEmail
        '
        Me.btnSimpleEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpleEmail.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpleEmail.Appearance.Image = CType(resources.GetObject("btnSimpleEmail.Appearance.Image"), System.Drawing.Image)
        Me.btnSimpleEmail.Appearance.Options.UseFont = True
        Me.btnSimpleEmail.Appearance.Options.UseImage = True
        Me.btnSimpleEmail.BackgroundImage = CType(resources.GetObject("btnSimpleEmail.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpleEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpleEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSimpleEmail.Location = New System.Drawing.Point(289, 372)
        Me.btnSimpleEmail.Name = "btnSimpleEmail"
        Me.btnSimpleEmail.Size = New System.Drawing.Size(162, 45)
        Me.btnSimpleEmail.TabIndex = 2
        Me.btnSimpleEmail.Text = "Invia mail di segnalazione"
        '
        'lcTesto
        '
        Me.lcTesto.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcTesto.Location = New System.Drawing.Point(70, 12)
        Me.lcTesto.Name = "lcTesto"
        Me.lcTesto.Size = New System.Drawing.Size(127, 25)
        Me.lcTesto.TabIndex = 3
        Me.lcTesto.Text = "LabelControl1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BaseLib.My.Resources.Resources.error_48
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(12, 66)
        Me.txtError.Name = "txtError"
        Me.txtError.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtError.Properties.WordWrap = False
        Me.txtError.Size = New System.Drawing.Size(563, 300)
        Me.txtError.TabIndex = 0
        Me.txtError.UseOptimizedRendering = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "mail2_send.png")
        '
        'ApplicationErrorWindow
        '
        Me.ClientSize = New System.Drawing.Size(593, 434)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.BaseButton1)
        Me.Controls.Add(Me.btnSimpleEmail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lcTesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ApplicationErrorWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lcTesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btnSimpleEmail As DevExpress.XtraEditors.BaseButton
    Private WithEvents BaseButton1 As DevExpress.XtraEditors.BaseButton
    Friend WithEvents txtError As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class

