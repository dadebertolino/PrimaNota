Imports DevExpress.XtraSplashScreen

Public Class DBFormTableDB
    Private WithEvents lDataGridView As DataGridView
    Private WithEvents lDataSet As DataSet
    Private WithEvents lDataRow As DataRow
    Private lConsentiStampa As Boolean

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
        Me.tbbGotoFirst.ToolTipText = "Vai al primo record"
        Me.tbbGotoPrev.ToolTipText = "Vai al record precedente"
        Me.tbbGotoNext.ToolTipText = "Vai al record successivo"
        Me.tbbGotoLast.ToolTipText = "Vai all'ultimo record"
        Me.tbbEdit.ToolTipText = "Modifica il record corrente"
        Me.tbbNew.ToolTipText = "Nuovo record"
        Me.tbbDelete.ToolTipText = "Cancella il record corrente"
        Me.tbbSave.ToolTipText = "Salva le modifiche al record corrente"
        Me.tbbBack.ToolTipText = "Indietro"
        Me.tbbStampa.ToolTipText = "Stampa"
        Me.btnOk.Text = "Modifica"
        Me.btnCancel.Text = "Indietro"
        Me.btnNewRecord.Text = "Nuovo"
        Me.btnConferma.Text = "Conferma"
        Me.btnAnnulla.Text = "Annulla"
        Me.btnDeleteRecord.Text = "Cancella"
        Me.tbbStampa.Visible = Me.DBConsentiStampa
        If Me.DBStato = BaseLib.DBStato.Chiave Then
            Me.btnOk.Visible = True
            Me.btnCancel.Visible = True
            Me.btnDeleteRecord.Visible = False
            Me.btnNewRecord.Visible = True
            Me.btnConferma.Visible = False
            Me.btnAnnulla.Visible = False
            Me.tbbGotoFirst.Visible = True
            Me.tbbGotoPrev.Visible = True
            Me.tbbGotoNext.Visible = True
            Me.tbbGotoLast.Visible = True
            Me.tbbEdit.Visible = True
            Me.tbbNew.Visible = True
            Me.tbbDelete.Visible = False
            Me.tbbSave.Visible = False
            Me.tbbBack.Visible = False
            Me.tstCurrent.Enabled = True
            Me.FormContainer.Panel1.Enabled = True
            Me.FormContainer.Panel2.Enabled = False
        Else
            Me.btnOk.Visible = False
            Me.btnCancel.Visible = False
            Me.btnNewRecord.Visible = False
            Me.btnConferma.Visible = True
            Me.btnAnnulla.Visible = True
            Me.tbbGotoFirst.Visible = False
            Me.tbbGotoPrev.Visible = False
            Me.tbbGotoNext.Visible = False
            Me.tbbGotoLast.Visible = False
            Me.tbbEdit.Visible = False
            Me.tbbNew.Visible = False
            Me.tbbSave.Visible = True
            Me.tbbBack.Visible = True
            Me.tstCurrent.Enabled = False
            If Me.DBStato = BaseLib.DBStato.Modifica Then
                Me.btnDeleteRecord.Visible = True
                Me.tbbDelete.Visible = True
            Else
                Me.btnDeleteRecord.Visible = False
                Me.tbbDelete.Visible = False
            End If
            Me.FormContainer.Panel1.Enabled = False
            Me.FormContainer.Panel2.Enabled = True
        End If
        'If Not Me.DBDatagridview Is Nothing Then
        Me.txlCount.Text = "/" & Me.lbsNavigazione.Count
        'End If
        Return True
    End Function

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Il DataGridView")> Public Property DBDatagridview() As DataGridView
        Get
            Return Me.lDataGridView
        End Get
        Set(ByVal value As DataGridView)
            Me.lDataGridView = value
        End Set
    End Property

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Il DataSet")> Protected Property DataSet() As DataSet
        Get
            Return Me.lDataSet
        End Get
        Set(ByVal value As DataSet)
            Me.lDataSet = value
        End Set
    End Property

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Gestisci la stampa")> Protected Property DBConsentiStampa() As Boolean
        Get
            Return Me.lConsentiStampa
        End Get
        Set(ByVal value As Boolean)
            Me.lConsentiStampa = value
        End Set
    End Property

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Il DataRow")> Protected Property DataRow() As DataRow
        Get
            Return Me.lDataRow
        End Get
        Set(ByVal value As DataRow)
            Me.lDataRow = value
        End Set
    End Property

#Region "Navigazione sulla Toolbar"

    Private Sub tbbGotoFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbGotoFirst.Click
        Me.lbsNavigazione.MoveFirst()
        Me.DBAspetto()
    End Sub

    Private Sub tbbGotoPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbGotoPrev.Click
        Me.lbsNavigazione.MovePrevious()
        Me.DBAspetto()
    End Sub

    Private Sub tbbGotoNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbGotoNext.Click
        Me.lbsNavigazione.MoveNext()
        Me.DBAspetto()
    End Sub


    Private Sub tbbGotoLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbGotoLast.Click
        Me.lbsNavigazione.MoveLast()
        Me.DBAspetto()
    End Sub
#End Region

    Public Event DBLoad()
    Public Event DBCaricaEtichetteLingua()
    Public Event DBCaricaAltriDati()
    'Public Event DBFineLoad()
    Public Event DBSalvaDati()
    Public Event DBCaricaDatiTabella()
    Private lDBStato As DBStato

    Public Property DBStato() As DBStato
        Get
            Return Me.lDBStato
        End Get
        Set(ByVal value As DBStato)
            Me.lDBStato = value
            Me.DBAspetto()
        End Set
    End Property

    Private Sub DBFormTable_DBEventoRinfrescaCorrente() Handles Me.DBEventoRinfrescaCorrente
        Me.tstCurrent.Text = Me.lbsNavigazione.Position + 1
        If Me.lbsNavigazione.Position <= 0 Then
            Me.tbbGotoFirst.Enabled = False
            Me.tbbGotoPrev.Enabled = False
        Else
            Me.tbbGotoFirst.Enabled = True
            Me.tbbGotoPrev.Enabled = True
        End If
        If Me.lbsNavigazione.Position = Me.lbsNavigazione.Count - 1 Then
            Me.tbbGotoNext.Enabled = False
            Me.tbbGotoLast.Enabled = False
        Else
            Me.tbbGotoNext.Enabled = True
            Me.tbbGotoLast.Enabled = True
        End If
        Dim DataRowView As DataRowView
        DataRowView = TryCast(Me.lbsNavigazione.Current, DataRowView)
        If Not DataRowView Is Nothing Then
            Me.lDataRow = DataRowView.Row
            If Me.DBStato = BaseLib.DBStato.Chiave Then
                RaiseEvent DBDaRecordAVideo()
            End If
        End If
    End Sub
    Public Event DBCustomActions()

    Private Sub DBFormBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SplashScreenManager1.ShowWaitForm()
        Me.SplashScreenManager1.SetWaitFormDescription("Carico dati in corso")
        Me.SplashScreenManager1.SetWaitFormCaption(Me.Text)
        Me.lDBStato = BaseLib.DBStato.Start
        RaiseEvent DBLoad()
        RaiseEvent DBCaricaEtichetteLingua()
        RaiseEvent DBCaricaAltriDati()
        RaiseEvent DBCaricaDatiTabella()
        If Me.DesignMode = False Then
            Me.DBStato = BaseLib.DBStato.Chiave
        End If
        'RaiseEvent DBFineLoad()
        RaiseEvent DBUpdateDataGridView()
        RaiseEvent DBEventoRinfrescaCorrente()
        RaiseEvent DBCustomActions()
        Me.SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Sub DBFormBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Me.DBStato = BaseLib.DBStato.Chiave Then
            Dim res As MsgBoxResult
            res = BaseLib.Msg.QuestionYesNo("Salvare le modifiche prima di uscire?")
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
        'If Me.DBStato = BaseLib.DBStato.Chiave Then
        RaiseEvent DBSalvaDati()
        'End If
    End Sub
    Public Event DBDaRecordAVideo()
    Public Event DBDaVideoARecord()

    Private Event DBEventoRinfrescaCorrente()


    Private Sub lbsNavigazione_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbsNavigazione.PositionChanged
        RaiseEvent DBEventoRinfrescaCorrente()
    End Sub

    Protected Overridable Function DBControlliSalva() As Boolean
        Return True
    End Function

    Private Sub tstCurrent_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstCurrent.Leave
        Dim Temp As Integer = Me.lbsNavigazione.Position
        Dim I As Integer
        Try
            I = CType(Me.tstCurrent.Text, Integer)
            If I < 1 Then I = 1
            If I > Me.lbsNavigazione.Count Then
                I = Me.lbsNavigazione.Count
            End If
        Catch ex As Exception
            I = Temp
            Me.tstCurrent.Text = Temp
        End Try
        Me.lbsNavigazione.Position = I - 1
    End Sub

    Protected Overridable Function DBControlliCancella() As Boolean
        Return True
    End Function

    Public Event DBCancellaRecordFigli()
    Private Sub btnDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRecord.Click, tbbDelete.Click
        If Me.DBControlliCancella = False Then
            Exit Sub
        End If
        Dim res As MsgBoxResult
        res = BaseLib.Msg.QuestionYesNo("Cancellare il record selezionato?")
        If res = MsgBoxResult.Yes Then
            Me.SplashScreenManager1.ShowWaitForm()
            Me.SplashScreenManager1.SetWaitFormDescription("Cancellazione dati in corso")
            Me.SplashScreenManager1.SetWaitFormCaption(Me.Text)
            RaiseEvent DBCancellaRecordFigli()
            Me.DataRow.Delete()
            RaiseEvent DBSalvaDati()
            Me.DBStato = BaseLib.DBStato.Chiave
            Me.lbsNavigazione.Position = 0
            RaiseEvent DBEventoRinfrescaCorrente()
            Me.SplashScreenManager1.CloseWaitForm()
        End If
    End Sub

    Public Event DBRecordInit()
    Public Event DBUpdateDataGridView()

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click, tbbNew.Click
        Dim DataSet As DataSet
        Dim DataTable As DataTable
        DataSet = TryCast(Me.lbsNavigazione.DataSource, DataSet)
        If Not DataSet Is Nothing Then
            DataTable = DataSet.Tables(Me.lbsNavigazione.DataMember)
            If Not DataTable Is Nothing Then
                Me.DataRow = DataTable.NewRow
                Try
                    RaiseEvent DBRecordInit()
                    RaiseEvent DBDaRecordAVideo()
                    DataTable.Rows.Add(DataRow)
                    Me.DBStato = BaseLib.DBStato.Inserimento
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
        'If Me.DBStato = BaseLib.DBStato.Inserimento Then
        '    Dim DataSet As DataSet
        '    Dim DataTable As DataTable
        '    DataSet = TryCast(Me.lbsNavigazione.DataSource, DataSet)
        '    If Not DataSet Is Nothing Then
        '        DataTable = DataSet.Tables(Me.lbsNavigazione.DataMember)
        '        If Not DataTable Is Nothing Then
        '            DataTable.Rows.Add(Me.DataRow)
        '            Me.lbsNavigazione.Position = Me.lbsNavigazione.Position + 1
        '        End If
        '    End If
        'End If
        RaiseEvent DBSalvaDati()
        RaiseEvent DBUpdateDataGridView()
        Me.SplashScreenManager1.CloseWaitForm()
        Return True
    End Function

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click, tbbSave.Click
        If Me.SalvaDati = True Then
            Me.DBStato = BaseLib.DBStato.Chiave
            If Not Me.DataRow Is Nothing Then
                RaiseEvent DBEventoRinfrescaCorrente()
            End If
        End If
    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click, tbbBack.Click
        Me.DBStato = BaseLib.DBStato.Chiave
        If Not Me.DataRow Is Nothing Then
            RaiseEvent DBDaRecordAVideo()
        End If
        RaiseEvent DBCaricaDatiTabella()
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click, tbbEdit.Click
        If Not Me.DataRow Is Nothing Then
            If Not Me.lbsNavigazione.Count = 0 Then
                Me.DBStato = BaseLib.DBStato.Modifica
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
