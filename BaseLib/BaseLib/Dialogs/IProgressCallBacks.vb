Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Public Interface IProgressCallBack
    Sub Begin(ByVal minimum As Integer, ByVal maximum As Integer)
    Sub Begin()
    Sub SetRange(ByVal minimum As Integer, ByVal maximum As Integer)
    Sub SetText(ByVal text As String)
    Sub StepTo(ByVal val As Integer)
    Sub Increment(ByVal val As Integer)
    ReadOnly Property IsAborting() As Boolean
    Sub Quit()
    Sub PerformStep()
End Interface

Public Interface IEndlessProgressCallBack
    Sub Begin()
    Sub SetText(ByVal text As String)
    Sub SetTitle(ByVal text As String)
    ReadOnly Property IsAborting() As Boolean
    Sub Quit()
End Interface




Public Class ProgressWindow
    Inherits DB_DIALOG
    Implements IProgressCallBack

    Private label As DevExpress.XtraEditors.LabelControl

    Private Shared CanClose As Boolean

    ''' <summary> 
    ''' Required designer variable. 
    ''' </summary> 
    Private components As System.ComponentModel.Container = Nothing

    Public Delegate Sub SetTextInvoker(ByVal text As String)
    Public Delegate Sub IncrementInvoker(ByVal val As Integer)
    Public Delegate Sub StepToInvoker(ByVal val As Integer)
    Public Delegate Sub PerformStepInvoker()
    Public Delegate Sub RangeInvoker(ByVal minimum As Integer, ByVal maximum As Integer)

    Private titleRoot As String = ""
    Private initEvent As New System.Threading.ManualResetEvent(False)
    Private abortEvent As New System.Threading.ManualResetEvent(False)
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Private requiresClose As Boolean = True

    Public Sub New()
        ' 
        ' Required for Windows Form Designer support 
        ' 
        InitializeComponent()
    End Sub

#Region "Implementation of IProgressCallback"
    ''' <summary> 
    ''' Call this method from the worker thread to initialize 
    ''' the progress meter. 
    ''' </summary> 
    ''' <param name="minimum">The minimum value in the progress range (e.g. 0)</param> 
    ''' <param name="maximum">The maximum value in the progress range (e.g. 100)</param> 
    Public Sub Begin(ByVal minimum As Integer, ByVal maximum As Integer) Implements IProgressCallBack.Begin
        CanClose = False
        initEvent.WaitOne()
        Invoke(New RangeInvoker(AddressOf DoBegin), New Object() {minimum, maximum})
    End Sub

    ''' <summary> 
    ''' Call this method from the worker thread to initialize 
    ''' the progress callback, without setting the range 
    ''' </summary> 
    Public Sub Begin() Implements IProgressCallBack.Begin
        initEvent.WaitOne()
        Invoke(New MethodInvoker(AddressOf DoBegin))
    End Sub

    ''' <summary> 
    ''' Call this method from the worker thread to reset the range in the progress callback 
    ''' </summary> 
    ''' <param name="minimum">The minimum value in the progress range (e.g. 0)</param> 
    ''' <param name="maximum">The maximum value in the progress range (e.g. 100)</param> 
    ''' <remarks>You must have called one of the Begin() methods prior to this call.</remarks> 
    Public Sub SetRange(ByVal minimum As Integer, ByVal maximum As Integer) Implements IProgressCallBack.SetRange
        initEvent.WaitOne()
        Invoke(New RangeInvoker(AddressOf DoSetRange), New Object() {minimum, maximum})
    End Sub

    ''' <summary> 
    ''' Call this method from the worker thread to update the progress text. 
    ''' </summary> 
    ''' <param name="text">The progress text to display</param> 
    Public Sub SetText(ByVal text As String) Implements IProgressCallBack.SetText
        Invoke(New SetTextInvoker(AddressOf DoSetText), New Object() {text})
    End Sub

    ''' <summary> 
    ''' Call this method from the worker thread to increase the progress counter by a specified value. 
    ''' </summary> 
    ''' <param name="val">The amount by which to increment the progress indicator</param> 
    Public Sub Increment(ByVal val As Integer) Implements IProgressCallBack.Increment
        Invoke(New IncrementInvoker(AddressOf DoIncrement), New Object() {val})
    End Sub

    ''' <summary> 
    ''' Call this method from the worker thread to step the progress meter to a particular value. 
    ''' </summary> 
    ''' <param name="val"></param> 
    Public Sub StepTo(ByVal val As Integer) Implements IProgressCallBack.StepTo
        Invoke(New StepToInvoker(AddressOf DoStepTo), New Object() {val})
    End Sub


    ''' <summary> 
    ''' If this property is true, then you should abort work 
    ''' </summary> 
    Public ReadOnly Property IsAborting() As Boolean Implements IProgressCallBack.IsAborting
        Get
            Return abortEvent.WaitOne(0, False)
        End Get
    End Property

    ''' <summary> 
    ''' Call this method from the worker thread to finalize the progress meter 
    ''' </summary> 
    Public Sub [End]() Implements IProgressCallBack.Quit
        CanClose = True
        If requiresClose Then
            Invoke(New MethodInvoker(AddressOf DoEnd))
        End If
    End Sub
#End Region

#Region "Implementation members invoked on the owner thread"
    Private Sub DoSetText(ByVal text As String)
        label.Text = text
    End Sub

    Private Sub DoIncrement(ByVal val As Integer)
        ProgressBarControl1.Increment(val)
        UpdateStatusText()
    End Sub

    Private Sub DoPerformStep()
        ProgressBarControl1.Increment(1)
        UpdateStatusText()
    End Sub

    Private Sub DoStepTo(ByVal val As Integer)
        ProgressBarControl1.EditValue = val
        UpdateStatusText()
    End Sub

    Private Sub DoBegin(ByVal minimum As Integer, ByVal maximum As Integer)
        DoBegin()
        DoSetRange(minimum, maximum)
    End Sub

    Private Sub DoBegin()
        ControlBox = True
    End Sub

    Private Sub DoSetRange(ByVal minimum As Integer, ByVal maximum As Integer)
        ProgressBarControl1.Properties.Minimum = minimum
        ProgressBarControl1.Properties.Maximum = maximum
        ProgressBarControl1.EditValue = minimum
        titleRoot = Text
    End Sub

    Private Sub DoEnd()
        Close()
    End Sub
#End Region

#Region "Overrides"
    ''' <summary> 
    ''' Handles the form load, and sets an event to ensure that 
    ''' intialization is synchronized with the appearance of the form. 
    ''' </summary> 
    ''' <param name="e"></param> 
    Protected Overloads Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        'me.ControlBox = False
        initEvent.[Set]()
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used. 
    ''' </summary> 
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ''' <summary> 
    ''' Handler for 'Close' clicking 
    ''' </summary> 
    ''' <param name="e"></param> 
    Protected Overloads Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        If CanClose = False Then
            e.Cancel = True
            Exit Sub
        End If
        requiresClose = False
        AbortWork()
        MyBase.OnClosing(e)
    End Sub
#End Region

#Region "Implementation Utilities"
    ''' <summary> 
    ''' Utility function that formats and updates the title bar text 
    ''' </summary> 
    Private Sub UpdateStatusText()
        Text = titleRoot
    End Sub

    ''' <summary> 
    ''' Utility function to terminate the thread 
    ''' </summary> 
    Private Sub AbortWork()
        abortEvent.[Set]()
    End Sub
#End Region

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor. 
    ''' </summary> 
    Private Sub InitializeComponent()
        Me.label = New DevExpress.XtraEditors.LabelControl
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label.Location = New System.Drawing.Point(8, 9)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(99, 13)
        Me.label.TabIndex = 0
        Me.label.Text = "Starting operation..."
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(12, 59)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(266, 25)
        Me.ProgressBarControl1.TabIndex = 2
        '
        'ProgressWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(290, 96)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ProgressWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProgressWindow"
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub PerformStep() Implements IProgressCallBack.PerformStep
        Invoke(New PerformStepInvoker(AddressOf DoPerformStep))
    End Sub

End Class



