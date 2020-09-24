Public Class DBBarcodeInput
    Inherits DevExpress.XtraEditors.TextEdit
    Public Sub New()
        MyBase.New()
        Me.EnterMoveNextControl = True
        'Me.Multiline = True
        'Me.AcceptsReturn = True
    End Sub

    Public Event RichiestaValidazione(ByVal Barcode As String, ByRef ValidazioneOk As Boolean)
    Public Event ValidazioneOk()
    Public Event ValidazioneCancel()
    Public Event ImpostaEnter()

    Private Sub DBBarcodeInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim Barcode As String
        Dim Validazione As Boolean = True

        If e.KeyCode = Keys.Return Then
            If Me.Text = "" Then
                RaiseEvent ImpostaEnter()
            Else
                e.SuppressKeyPress = True
                Barcode = Me.Text
                RaiseEvent RichiestaValidazione(Barcode, Validazione)
                If Validazione = True Then
                    RaiseEvent ValidazioneOk()
                    Me.Text = ""
                Else
                    'Msg.ErrorContinue("Barcode non riconosciuto")
                    RaiseEvent ValidazioneCancel()
                    Me.Text = ""
                End If
            End If
        ElseIf e.KeyCode = Keys.LineFeed Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class

Public Class DBBarcodeInput2
    Inherits DevExpress.XtraEditors.TextEdit
    Public Sub New()
        MyBase.New()
        Me.EnterMoveNextControl = True
        'Me.Multiline = True
        'Me.AcceptsReturn = True
    End Sub

    Public Event RichiestaValidazione(ByVal Barcode As String, ByRef ValidazioneOk As Boolean)
    Public Event ValidazioneOk()
    Public Event ValidazioneCancel()
    Public Event ImpostaEnter()

    Private Sub DBBarcodeInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim Barcode As String
        Dim Validazione As Boolean = True

        If e.KeyCode = Keys.Return Then
            If Me.Text = "" Then
                RaiseEvent ImpostaEnter()
            Else
                e.SuppressKeyPress = True
                Barcode = Me.Text
                RaiseEvent RichiestaValidazione(Barcode, Validazione)
                If Validazione = True Then
                    RaiseEvent ValidazioneOk()
                    'Dim Se As DBBarcodeInput2 = CType(sender, DBBarcodeInput2)
                    'Dim p As Control
                    'Dim Nxt As Control
                    'p = Se.Parent
                    'Nxt = p.GetNextControl(Se, True)
                    'Nxt.Focus()
                Else
                    'Msg.ErrorContinue("Barcode non riconosciuto")
                    RaiseEvent ValidazioneCancel()
                    Me.Text = ""
                End If
            End If
        ElseIf e.KeyCode = Keys.LineFeed Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class

