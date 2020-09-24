Public Class frmEndlessProgress
    Implements IEndlessProgressCallBack

    Private initEvent As System.Threading.ManualResetEvent = New System.Threading.ManualResetEvent(False)
    Private abortEvent As System.Threading.ManualResetEvent = New System.Threading.ManualResetEvent(False)
    Private requiresClose As Boolean = True

    Public Delegate Sub SetTextInvoker(ByVal text As String)
    Public Delegate Sub SetTitleInvoker(ByVal text As String)

    Public Sub Begin() Implements IEndlessProgressCallBack.Begin
        initEvent.WaitOne()
        Invoke(New MethodInvoker(AddressOf DoBegin))
    End Sub

    Public Sub Quit() Implements IEndlessProgressCallBack.Quit
        Invoke(New MethodInvoker(AddressOf DoQuit))
    End Sub

    Public ReadOnly Property IsAborting() As Boolean Implements IEndlessProgressCallBack.IsAborting
        Get
            Return abortEvent.WaitOne(0, False)
        End Get
    End Property


    Public Sub SetText(ByVal text As String) Implements IEndlessProgressCallBack.SetText
        Invoke(New SetTextInvoker(AddressOf DoSetText), New Object() {text})
    End Sub

    Public Sub SetTitle(ByVal text As String) Implements IEndlessProgressCallBack.SetTitle
        Invoke(New SetTitleInvoker(AddressOf DoSetTitle), New Object() {text})
    End Sub

    Private Sub DoBegin()
        Me.ControlBox = True
    End Sub

    Private Sub DoQuit()
        Try
            Me.ProgressControl2.AutoProgress = False
            If Me.IsDisposed = False Then
                If Me.Disposing = False Then
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DoSetText(ByVal text As String)
        Me.lblText.Text = text
    End Sub

    Private Sub DoSetTitle(ByVal text As String)
        Me.Text = text
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        Me.ControlBox = False
        Me.ProgressControl2.AutoProgress = True
        Me.initEvent.Set()
    End Sub

    Private Sub AbortWork()
        Me.abortEvent.Set()
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        requiresClose = False
        Me.ProgressControl2.AutoProgress = False
        Me.abortEvent.Set()
        MyBase.OnClosing(e)
    End Sub
End Class