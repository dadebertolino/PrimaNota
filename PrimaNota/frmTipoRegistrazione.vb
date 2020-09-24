Public Class frmTipoRegistrazione
    Public Const GridviewTipoRegistrazioneLayout As String = "GridviewTipoRegistrazione.xml"
    Private Sub frmTipoRegistrazione_DBDaVideoARecord() Handles Me.DBDaVideoARecord
        Dim TipoRegistrazione As PrimaNota.DAL.TipoRegistrazione
        TipoRegistrazione = Me.xpoObject
        TipoRegistrazione.Descrizione = Me.txtDescrizione.Text
        TipoRegistrazione.Spesa = Me.chkSpesa.Checked
        TipoRegistrazione.PercentualeDetrazione = CDec(Me.txtPercDetrazione.EditValue)

    End Sub

    Private Sub frmTipoRegistrazione_DBDaRecordAVideo() Handles Me.DBDaRecordAVideo
        Dim TipoRegistrazione As PrimaNota.DAL.TipoRegistrazione
        TipoRegistrazione = Me.xpoObject
        Me.txtDescrizione.Text = TipoRegistrazione.Descrizione
        Me.chkSpesa.Checked = TipoRegistrazione.Spesa
        Me.txtPercDetrazione.EditValue = TipoRegistrazione.PercentualeDetrazione
    End Sub

    Private Sub frmTipoRegistrazione_DBRecordInit() Handles Me.DBRecordInit
        Dim TipoRegistrazione As PrimaNota.DAL.TipoRegistrazione
        TipoRegistrazione = Me.xpoObject
        TipoRegistrazione.Descrizione = ""
        TipoRegistrazione.Spesa = True
        TipoRegistrazione.PercentualeDetrazione = 0
    End Sub

    Protected Overrides Function DBControlliSalva() As Boolean
        If Me.txtDescrizione.Text = "" Then
            BaseLib.Msg.ErrorContinue("Inserire la descrizione del conto")
            Me.txtDescrizione.Focus()
            Return False
        End If
        Return MyBase.DBControlliSalva
    End Function

    Private Sub frmTipoRegistrazione_DBLoad() Handles Me.DBLoad
        Dim fi As New IO.FileInfo(GridviewTipoRegistrazioneLayout)
        If fi.Exists = True Then
            Me.GridView1.RestoreLayoutFromXml(GridviewTipoRegistrazioneLayout)
        End If
        Me.DBConsentiStampa = False
    End Sub

    Private Sub frmTipoRegistrazione_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.GridView1.SaveLayoutToXml(GridviewTipoRegistrazioneLayout)

    End Sub
End Class