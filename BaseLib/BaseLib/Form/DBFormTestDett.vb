Public Class DBFormTestDett
    Public Event DBLoad()
    Public Event DBCaricaEtichetteLingua()
    Public Event DBCaricaAltriDati()
    Public Event DBFineLoad()
    Public Event DBSalvaDati()
    Public Event DBCaricaDatiTestDett(ByRef Cancel As Boolean, DaIndagine As Boolean)
    Public Event DBPulisciCampiDati()
    Public Event DBPulisciCampiChiave()

    Private lDBStato As DBStato
    Private WithEvents lDataRow As DataRow
    Private WithEvents lDataRowRisultatoIndagine As DataRow
    Public ReadOnly Property DataRowRisultatoIndagine As DataRow
        Get
            Return lDataRowRisultatoIndagine
        End Get
    End Property

    Public frmIndagine As Object

    Protected Overridable Function DBAspetto() As Boolean
        If Me.lDBStato = BaseLib.DBStato.Start Then
            Return False
        End If
        If Me.DBStato = BaseLib.DBStato.Inserimento Then
            Me.bsiFase.Caption = "Inserimento"
        ElseIf Me.DBStato = BaseLib.DBStato.Chiave Then
            Me.bsiFase.Caption = "Chiave"
        ElseIf Me.DBStato = BaseLib.DBStato.Modifica Then
            Me.bsiFase.Caption = "Variazione"
        End If
        Me.btnModifica.Text = "Modifica"
        Me.btnIndietro.Text = "Indietro"
        Me.btnNewRecord.Text = "Nuovo"
        Me.btnConferma.Text = "Conferma"
        Me.btnAnnulla.Text = "Annulla"
        Me.btnDeleteRecord.Text = "Cancella"
        Me.btnCarica.Text = "Carica"
        Me.btnIndagine.Text = "Indagine"
        If Me.DBStato = BaseLib.DBStato.Chiave Then
            Me.btnModifica.Visible = True
            Me.btnIndietro.Visible = True
            Me.btnDeleteRecord.Visible = False
            Me.btnConferma.Visible = False
            Me.btnAnnulla.Visible = False
            Me.FormContainer.Panel1.Enabled = True
            Me.FormContainer.Panel2.Enabled = False
        Else
            Me.btnModifica.Visible = False
            Me.btnIndietro.Visible = False
            Me.btnConferma.Visible = True
            Me.btnAnnulla.Visible = True
            If Me.DBStato = BaseLib.DBStato.Modifica Then
                Me.btnDeleteRecord.Visible = True
            Else
                Me.btnDeleteRecord.Visible = False
            End If
            Me.FormContainer.Panel1.Enabled = False
            Me.FormContainer.Panel2.Enabled = True
        End If
        Return True
    End Function

    Public Property DBStato() As DBStato
        Get
            Return Me.lDBStato
        End Get
        Set(ByVal value As DBStato)
            Me.lDBStato = value
            Me.DBAspetto()
        End Set
    End Property



    Private Sub DBFormBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Me.DBStato = BaseLib.DBStato.Chiave Then
            Dim res As MsgBoxResult
            res = BaseLib.Msg.QuestionYesNoCancel("Salvare le modifiche prima di uscire?")
            If res = MsgBoxResult.Cancel Then
                e.Cancel = True
                Exit Sub
            ElseIf res = MsgBoxResult.Yes Then
                If Me.SalvaDati = False Then
                    e.Cancel = True
                    Exit Sub
                End If
            ElseIf res = MsgBoxResult.No Then

            End If
        End If
    End Sub

    Public Event DBDaRecordAVideoKey()
    Public Event DBDaRecordAVideoData()
    Public Event DBDaVideoARecord()
    Public Event DBRecordInit(e As System.ComponentModel.CancelEventArgs)

    Private Sub DBFormBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SplashScreenManager1.ShowWaitForm()
        Me.SplashScreenManager1.SetWaitFormDescription("Carico dati in corso")
        Me.SplashScreenManager1.SetWaitFormCaption(Me.Text)
        Me.lDBStato = BaseLib.DBStato.Start
        RaiseEvent DBLoad()
        RaiseEvent DBCaricaEtichetteLingua()
        RaiseEvent DBCaricaAltriDati()
        If Me.DesignMode = False Then
            Me.DBStato = BaseLib.DBStato.Chiave
        End If
        RaiseEvent DBFineLoad()
        RaiseEvent DBPulisciCampiChiave()
        RaiseEvent DBPulisciCampiDati()
        Me.SplashScreenManager1.CloseWaitForm()
    End Sub

    Protected Overridable Function DBControlliCancella() As Boolean
        Return True
    End Function

    Protected Overridable Function DBControlliSalva() As Boolean
        Return True
    End Function

    Public Event DBCancellaRecord()

    Private Sub btnDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRecord.Click
        If Me.DBControlliCancella = False Then
            Exit Sub
        End If
        Dim res As MsgBoxResult
        res = BaseLib.Msg.QuestionYesNo("Cancellare il record selezionato?")
        If res = MsgBoxResult.Yes Then
            Me.SplashScreenManager1.ShowWaitForm()
            Me.SplashScreenManager1.SetWaitFormDescription("Cancellazione dati in corso")
            Me.SplashScreenManager1.SetWaitFormCaption(Me.Text)
            RaiseEvent DBCancellaRecord()
            Me.DBStato = BaseLib.DBStato.Chiave
            Me.lbsNavigazione.Position = 0
            RaiseEvent DBPulisciCampiChiave()
            RaiseEvent DBPulisciCampiDati()
            Me.SplashScreenManager1.CloseWaitForm()
        End If
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Dim DataSet As DataSet
        Dim DataTable As DataTable
        Dim ev As New System.ComponentModel.CancelEventArgs
        ev.Cancel = False
        DataSet = TryCast(Me.lbsNavigazione.DataSource, DataSet)
        If Not DataSet Is Nothing Then
            DataTable = DataSet.Tables(Me.lbsNavigazione.DataMember)
            If Not DataTable Is Nothing Then
                Me.DataRow = DataTable.NewRow
                Try
                    RaiseEvent DBPulisciCampiChiave()
                    RaiseEvent DBPulisciCampiDati()
                    RaiseEvent DBRecordInit(ev)
                    If ev.Cancel = False Then
                        RaiseEvent DBDaRecordAVideoKey()
                        RaiseEvent DBDaRecordAVideoData()
                        DataTable.Rows.Add(DataRow)
                        Me.DBStato = BaseLib.DBStato.Inserimento
                    End If
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Function SalvaDati() As Boolean
        If Me.DBControlliSalva = False Then
            Return False
        End If
        Me.SplashScreenManager1.ShowWaitForm()
        Me.SplashScreenManager1.SetWaitFormDescription("Salvataggio dati in corso")
        Me.SplashScreenManager1.SetWaitFormCaption(Me.Text)
        RaiseEvent DBDaVideoARecord()
        RaiseEvent DBSalvaDati()
        Me.SplashScreenManager1.CloseWaitForm()
        Return True
    End Function

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
        If Me.SalvaDati = True Then
            Me.DBStato = BaseLib.DBStato.Chiave
            RaiseEvent DBPulisciCampiChiave()
            RaiseEvent DBPulisciCampiDati()
        End If
    End Sub

    Public Event DBRollBackModifiche()
    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        RaiseEvent DBRollBackModifiche()
        Me.DBStato = BaseLib.DBStato.Chiave
        RaiseEvent DBPulisciCampiChiave()
        RaiseEvent DBPulisciCampiDati()
    End Sub

    Private Sub btnModifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        If Not Me.DataRow Is Nothing Then
            If Not Me.lbsNavigazione.Count = 0 Then
                Me.DBStato = BaseLib.DBStato.Modifica
            End If
        End If
    End Sub
    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Il DataRow")> Protected Property DataRow() As DataRow
        Get
            Return Me.lDataRow
        End Get
        Set(ByVal value As DataRow)
            Me.lDataRow = value
        End Set
    End Property

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIndietro.Click
        Me.Close()
    End Sub

    Private Sub btnIndagine_Click(sender As System.Object, e As System.EventArgs) Handles btnIndagine.Click
        If Me.frmIndagine Is Nothing Then
            Exit Sub
        End If
        Dim frmIndagineCasted As dbFormIndagine = TryCast(Me.frmIndagine, dbFormIndagine)
        Me.lDataRowRisultatoIndagine = Nothing
        Dim Annulla As Boolean = False
        If Not frmIndagineCasted Is Nothing Then
            If frmIndagineCasted.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Me.lDataRowRisultatoIndagine = frmIndagineCasted.DataRow
                    RaiseEvent DBPulisciCampiChiave()
                    RaiseEvent DBPulisciCampiDati()
                    RaiseEvent DBCaricaDatiTestDett(Annulla, True)
                    If Annulla = False Then
                        RaiseEvent DBDaRecordAVideoKey()
                        RaiseEvent DBDaRecordAVideoData()
                    Else
                        BaseLib.Msg.ErrorContinue("Impossibile ritrovare il record richiesto")
                    End If
                Catch ex As Exception

                End Try

            End If
        End If
    End Sub

    Private Sub btnCarica_Click(sender As System.Object, e As System.EventArgs) Handles btnCarica.Click
        Me.DataRow = Nothing
        Dim Annulla As Boolean = False
        RaiseEvent DBPulisciCampiDati()
        RaiseEvent DBCaricaDatiTestDett(Annulla, False)
        If Annulla = False Then
            Me.lbsNavigazione.MoveFirst()
            RaiseEvent DBDaRecordAVideoData()
        Else
            BaseLib.Msg.ErrorContinue("Impossibile ritrovare il record richiesto")
            RaiseEvent DBPulisciCampiChiave()
        End If
    End Sub

    Private Sub lbsNavigazione_CurrentChanged(sender As Object, e As System.EventArgs) Handles lbsNavigazione.CurrentChanged
        Dim DataRowView As DataRowView
        DataRowView = TryCast(Me.lbsNavigazione.Current, DataRowView)
        If Not DataRowView Is Nothing Then
            Me.lDataRow = DataRowView.Row
            'If Me.DBStato = BaseLib.DBStato.Chiave Then
            '    RaiseEvent DBDaRecordAVideo()
            'End If
        End If
    End Sub
End Class