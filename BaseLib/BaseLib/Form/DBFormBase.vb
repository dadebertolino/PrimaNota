Public Class DBFormBase

    Private Sub tmrStatoPulsanti_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles tmrStatoPulsanti.Elapsed
        If My.Computer.Keyboard.CapsLock Then
            Me.bsiBlockMaiusc.Caption = "CapsLock"
        Else
            Me.bsiBlockMaiusc.Caption = ""
        End If
        If My.Computer.Keyboard.NumLock Then
            Me.bsiBlockNum.Caption = "NumLock"
        Else
            Me.bsiBlockNum.Caption = ""
        End If
    End Sub

End Class

Public Enum DBStato As Integer
    Start = 0
    Chiave = 1
    Modifica = 2
    Inserimento = 3
End Enum
