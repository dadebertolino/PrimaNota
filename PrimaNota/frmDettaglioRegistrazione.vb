Public Class frmDettaglioRegistrazione
    Public Registrazione As PrimaNota.DAL.Registrazione

    Private Sub frmDettaglioRegistrazione_DBCaricaDati() Handles Me.DBCaricaDati
        Me.cmbConto.EditValue = Registrazione.Conto
        Me.cmbTipo.EditValue = Registrazione.Tipo
        Me.txtDescrizione.Text = Registrazione.Descrizione
        If Registrazione.Tipo Is Nothing Then
            Me.txtValore.EditValue = 0
        Else
            If Registrazione.Tipo.Spesa = True Then
                Me.txtValore.EditValue = Registrazione.Uscite
            Else
                Me.txtValore.EditValue = Registrazione.Entrate
            End If
        End If

        Me.dtpPagamento.EditValue = Registrazione.DataPagamento
        Me.dtpScadenza.EditValue = Registrazione.DataScadenza
        Me.txtDescrizione.Text = Registrazione.ModalitaPagamento
    End Sub

    Private Sub frmDettaglioRegistrazione_DBSalvaDati() Handles Me.DBSalvaDati
        Registrazione.Conto = Me.cmbConto.EditValue
        Registrazione.Tipo = Me.cmbTipo.EditValue
        Registrazione.Descrizione = Me.txtDescrizione.Text
        If Registrazione.Tipo.Spesa = True Then
            Registrazione.Uscite = CDec(Me.txtValore.EditValue)
            Registrazione.Entrate = 0
            Registrazione.ValoreAmmortamento = Registrazione.Uscite * Registrazione.Tipo.PercentualeDetrazione / 100
        Else
            Registrazione.Uscite = 0
            Registrazione.Entrate = CDec(Me.txtValore.EditValue)
            Registrazione.ValoreAmmortamento = 0
        End If
        Registrazione.DataPagamento = CDate(Me.dtpPagamento.EditValue)
        Registrazione.DataScadenza = CDate(Me.dtpScadenza.EditValue)
        Registrazione.ModalitaPagamento = Me.txtDescrizione.Text
        Registrazione.Save()
    End Sub
    Public Overrides Function DBControlli() As Boolean
        If Me.cmbTipo.EditValue Is Nothing Then
            BaseLib.Msg.ErrorContinue("Selezionare il tipo")
            Return False
        ElseIf Me.cmbTipo.EditValue Is System.DBNull.Value Then
            BaseLib.Msg.ErrorContinue("Selezionare il tipo")
                Return False

            End If
            Return MyBase.DBControlli()
    End Function
End Class