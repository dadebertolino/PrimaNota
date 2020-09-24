Imports System.Reflection

Public Class DBFormTestDett_XPO
    Public Event DBLoad()
    Public Event DBCaricaEtichetteLingua()
    Public Event DBCaricaAltriDati()
    Public Event DBFineLoad()
    Public Event DBSalvaDati()
    Public Event DBCaricaDatiTestDett(e As System.ComponentModel.CancelEventArgs, DaIndagine As Boolean)
    Public Event DBPulisciCampiDati()
    Public Event DBPulisciCampiChiave()


    Private WithEvents lxpcCollectionTestata As DevExpress.Xpo.XPCollection
    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("La collection Testata")> Public Property xpcCollectionTestata() As DevExpress.Xpo.XPCollection
        Get
            Return Me.lxpcCollectionTestata
        End Get
        Set(ByVal value As DevExpress.Xpo.XPCollection)
            Me.lxpcCollectionTestata = value
        End Set
    End Property

    Private WithEvents lxpcCollectionDettaglio As DevExpress.Xpo.XPCollection
    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("La collection Dettaglio")> Public Property xpcCollectionDettaglio() As DevExpress.Xpo.XPCollection
        Get
            Return Me.lxpcCollectionDettaglio
        End Get
        Set(ByVal value As DevExpress.Xpo.XPCollection)
            Me.lxpcCollectionDettaglio = value
        End Set
    End Property

    Private WithEvents lxpcCollectionDettaglioCopia As DevExpress.Xpo.XPCollection
    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("La collection Dettaglio Copia")> Public Property xpcCollectionDettaglioCopia() As DevExpress.Xpo.XPCollection
        Get
            Return Me.lxpcCollectionDettaglioCopia
        End Get
        Set(ByVal value As DevExpress.Xpo.XPCollection)
            Me.lxpcCollectionDettaglioCopia = value
        End Set
    End Property

    Private lDBStato As DBStato
    Private WithEvents lxpObjTestata As DevExpress.Xpo.XPObject
    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("L' Oggetto XPO")> Protected Property xpoObjTestata() As DevExpress.Xpo.XPObject
        Get
            Return Me.lxpObjTestata
        End Get
        Set(ByVal value As DevExpress.Xpo.XPObject)
            Me.lxpObjTestata = value
        End Set
    End Property
    Private WithEvents lxpObjTestataRisultatoIndagine As DevExpress.Xpo.XPObject
    Public ReadOnly Property xpoObjTestataRisultatoIndagine As DevExpress.Xpo.XPObject
        Get
            Return lxpObjTestataRisultatoIndagine
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
            Me.xpoObjTestata = Nothing
            Me.xpcCollectionDettaglio.LoadingEnabled = False
            Me.xpcCollectionDettaglio.Reload()
            Me.xpcCollectionDettaglioCopia.LoadingEnabled = False
            Me.xpcCollectionDettaglioCopia.Reload()
            RaiseEvent DBFineLoad()
            RaiseEvent DBPulisciCampiChiave()
            RaiseEvent DBPulisciCampiDati()
        End If

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
        If Me.DBControlliCancella() = False Then
            Exit Sub
        End If
        Dim res As MsgBoxResult
        res = BaseLib.Msg.QuestionYesNo("Cancellare il record selezionato?")
        If res = MsgBoxResult.Yes Then
            Me.SplashScreenManager1.ShowWaitForm()
            Me.SplashScreenManager1.SetWaitFormDescription("Cancellazione dati in corso")
            Me.SplashScreenManager1.SetWaitFormCaption(Me.Text)
            RaiseEvent DBCancellaRecord()
            Me.xpoObjTestata.Delete()
            Me.xpoObjTestata = Nothing
            Me.xpcCollectionDettaglio.LoadingEnabled = False
            Me.xpcCollectionDettaglio.Reload()
            Me.xpcCollectionDettaglioCopia.LoadingEnabled = False
            Me.xpcCollectionDettaglioCopia.Reload()
            Me.DBStato = BaseLib.DBStato.Chiave
            RaiseEvent DBPulisciCampiChiave()
            RaiseEvent DBPulisciCampiDati()
            Me.SplashScreenManager1.CloseWaitForm()
        End If
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        Dim ev As New System.ComponentModel.CancelEventArgs
        ev.Cancel = False
        Try
            Dim DesTipo As String = Me.xpcCollectionTestata.ObjectClassInfo.FullName
            Dim b As Assembly = System.Reflection.Assembly.Load(Me.xpcCollectionTestata.ObjectClassInfo.AssemblyName)
            Me.xpoObjTestata = b.CreateInstance(DesTipo)
            Me.xpcCollectionDettaglio.LoadingEnabled = False
            Me.xpcCollectionDettaglio.Reload()
            Me.xpcCollectionDettaglioCopia.LoadingEnabled = False
            Me.xpcCollectionDettaglioCopia.Reload()
            RaiseEvent DBPulisciCampiChiave()
            RaiseEvent DBPulisciCampiDati()
            RaiseEvent DBRecordInit(ev)
            If ev.Cancel = False Then
                RaiseEvent DBDaRecordAVideoKey()
                RaiseEvent DBDaRecordAVideoData()
                Me.DBStato = BaseLib.DBStato.Inserimento
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function SalvaDati() As Boolean
        If Me.DBControlliSalva() = False Then
            Return False
        End If
        Me.SplashScreenManager1.ShowWaitForm()
        Me.SplashScreenManager1.SetWaitFormDescription("Salvataggio dati in corso")
        Me.SplashScreenManager1.SetWaitFormCaption(Me.Text)
        RaiseEvent DBDaVideoARecord()
        RaiseEvent DBSalvaDati()
        Me.xpoObjTestata.Save()
        Me.SplashScreenManager1.CloseWaitForm()
        Return True
    End Function

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
        If Me.SalvaDati() = True Then
            Me.DBStato = BaseLib.DBStato.Chiave
            Me.xpoObjTestata = Nothing
            Me.xpcCollectionDettaglio.LoadingEnabled = False
            Me.xpcCollectionDettaglio.Reload()
            Me.xpcCollectionDettaglioCopia.LoadingEnabled = False
            Me.xpcCollectionDettaglioCopia.Reload()
            RaiseEvent DBPulisciCampiChiave()
            RaiseEvent DBPulisciCampiDati()
            Me.xpoObjTestata = Nothing
        End If
    End Sub

    Public Event DBRollBackModifiche(e As System.ComponentModel.CancelEventArgs)
    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        Dim ev As New System.ComponentModel.CancelEventArgs
        RaiseEvent DBRollBackModifiche(ev)
        If ev.Cancel = False Then
            For conta As Integer = Me.xpcCollectionDettaglio.Count - 1 To 0 Step -1
                Dim Dettaglio As DevExpress.Xpo.XPObject = Me.xpcCollectionDettaglio(conta)
                Dettaglio.Delete()
            Next
            For conta As Integer = 0 To Me.xpcCollectionDettaglioCopia.Count - 1
                Dim Dettaglio As DevExpress.Xpo.XPObject = Me.xpcCollectionDettaglioCopia(conta)
                Dettaglio.Save()
            Next
            If Me.DBStato = BaseLib.DBStato.Inserimento Then
                Me.xpoObjTestata.Delete()
            End If
            Me.DBStato = BaseLib.DBStato.Chiave
            RaiseEvent DBPulisciCampiChiave()
            RaiseEvent DBPulisciCampiDati()
            Me.xpoObjTestata = Nothing
            Me.xpcCollectionDettaglio.LoadingEnabled = False
            Me.xpcCollectionDettaglio.Reload()
            Me.xpcCollectionDettaglioCopia.LoadingEnabled = False
            Me.xpcCollectionDettaglioCopia.Reload()
        End If
    End Sub

    Private Sub btnModifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        If Not Me.xpoObjTestata Is Nothing Then
            Me.DBStato = BaseLib.DBStato.Modifica
        End If
    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIndietro.Click
        Me.Close()
    End Sub

    Private Sub btnIndagine_Click(sender As System.Object, e As System.EventArgs) Handles btnIndagine.Click
        If Me.frmIndagine Is Nothing Then
            Exit Sub
        End If
        Dim frmIndagineCasted As DBFormIndagineXPO = TryCast(Me.frmIndagine, DBFormIndagineXPO)
        Me.lxpObjTestataRisultatoIndagine = Nothing
        Dim Annulla As New System.ComponentModel.CancelEventArgs()
        If Not frmIndagineCasted Is Nothing Then
            frmIndagineCasted.Session = Me.xpcCollectionTestata.Session
            If frmIndagineCasted.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Me.lxpObjTestataRisultatoIndagine = frmIndagineCasted.xpoObject
                    Me.xpoObjTestata = Nothing
                    Me.xpcCollectionDettaglio.LoadingEnabled = False
                    Me.xpcCollectionDettaglio.Reload()
                    Me.xpcCollectionDettaglioCopia.LoadingEnabled = False
                    Me.xpcCollectionDettaglioCopia.Reload()
                    RaiseEvent DBPulisciCampiChiave()
                    RaiseEvent DBPulisciCampiDati()
                    RaiseEvent DBCaricaDatiTestDett(Annulla, True)
                    If Annulla.Cancel = False Then
                        If Me.xpcCollectionTestata.Count > 0 Then
                            Me.lxpObjTestata = Me.xpcCollectionTestata(0)
                            BaseLib.DBXpoUtil.CopyCollection(Me.xpcCollectionDettaglio, Me.xpcCollectionDettaglioCopia)
                        End If
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
        Me.xpoObjTestata = Nothing
        Me.xpcCollectionDettaglio.LoadingEnabled = False
        Me.xpcCollectionDettaglio.Reload()
        Me.xpcCollectionDettaglioCopia.LoadingEnabled = False
        Me.xpcCollectionDettaglioCopia.Reload()
        Dim Annulla As New System.ComponentModel.CancelEventArgs()
        RaiseEvent DBPulisciCampiDati()
        RaiseEvent DBCaricaDatiTestDett(Annulla, False)
        If Annulla.Cancel = False Then
            If Me.xpcCollectionTestata.Count > 0 Then
                Me.lxpObjTestata = Me.xpcCollectionTestata(0)
                BaseLib.DBXpoUtil.CopyCollection(Me.xpcCollectionDettaglio, Me.xpcCollectionDettaglioCopia)
            End If
            RaiseEvent DBDaRecordAVideoData()
        Else
            BaseLib.Msg.ErrorContinue("Impossibile ritrovare il record richiesto")
            RaiseEvent DBPulisciCampiChiave()
        End If
    End Sub

End Class