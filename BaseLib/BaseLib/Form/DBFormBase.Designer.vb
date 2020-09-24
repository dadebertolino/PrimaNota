<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBFormBase
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrStatoPulsanti = New System.Timers.Timer()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bsiFase = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiDataBase = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiBlockMaiusc = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiBlockNum = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.tmrStatoPulsanti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrStatoPulsanti
        '
        Me.tmrStatoPulsanti.Enabled = True
        Me.tmrStatoPulsanti.Interval = 250.0R
        Me.tmrStatoPulsanti.SynchronizingObject = Me
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bsiFase, Me.bsiDataBase, Me.bsiBlockNum, Me.bsiBlockMaiusc})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bsiFase), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiDataBase), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiBlockMaiusc), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiBlockNum)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'bsiFase
        '
        Me.bsiFase.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.bsiFase.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.bsiFase.Id = 0
        Me.bsiFase.Name = "bsiFase"
        Me.bsiFase.TextAlignment = System.Drawing.StringAlignment.Near
        Me.bsiFase.Width = 100
        '
        'bsiDataBase
        '
        Me.bsiDataBase.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.bsiDataBase.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.bsiDataBase.Id = 1
        Me.bsiDataBase.Name = "bsiDataBase"
        Me.bsiDataBase.TextAlignment = System.Drawing.StringAlignment.Near
        Me.bsiDataBase.Width = 32
        '
        'bsiBlockMaiusc
        '
        Me.bsiBlockMaiusc.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.bsiBlockMaiusc.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.bsiBlockMaiusc.Caption = "bsiBlockMaiusc"
        Me.bsiBlockMaiusc.Id = 3
        Me.bsiBlockMaiusc.Name = "bsiBlockMaiusc"
        Me.bsiBlockMaiusc.TextAlignment = System.Drawing.StringAlignment.Near
        Me.bsiBlockMaiusc.Width = 60
        '
        'bsiBlockNum
        '
        Me.bsiBlockNum.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.bsiBlockNum.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.bsiBlockNum.Caption = "bsiBlockNum"
        Me.bsiBlockNum.Id = 2
        Me.bsiBlockNum.Name = "bsiBlockNum"
        Me.bsiBlockNum.TextAlignment = System.Drawing.StringAlignment.Near
        Me.bsiBlockNum.Width = 60
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(757, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 531)
        Me.barDockControlBottom.Size = New System.Drawing.Size(757, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 531)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(757, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 531)
        '
        'DBFormBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 556)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.Name = "DBFormBase"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tmrStatoPulsanti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrStatoPulsanti As System.Timers.Timer
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bsiFase As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiDataBase As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiBlockMaiusc As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiBlockNum As DevExpress.XtraBars.BarStaticItem

End Class
