Imports FlexCel.XlsAdapter

Public Class frmMain
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm As New frmPrimaNota
        frm.ShowDialog()
    End Sub

    'Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
    '    Dim sfd As New SaveFileDialog
    '    sfd.FileName = "Esportazione.xlsx"
    '    If sfd.ShowDialog = DialogResult.OK Then
    '        Dim xls As New XlsFile(1, True)
    '        Dim xc As New DevExpress.Xpo.XPCollection(Of PrimaNota.DAL.Fascicoli)
    '        Dim Fascicolo As PrimaNota.DAL.Fascicoli
    '        Dim IndiceRiga As Integer = 2
    '        xls.SetCellValue(1, 1, "N° Fascicolo")
    '        xls.SetCellValue(1, 2, "Nominativo")
    '        xls.SetCellValue(1, 3, "Data Apertura")
    '        xls.SetCellValue(1, 4, "Oggetto")
    '        xls.SetCellValue(1, 5, "Data Chiusura")
    '        xls.SetCellValue(1, 6, "N° Fatt/Ric")
    '        xls.SetCellValue(1, 7, "Data Emissione")
    '        xls.SetCellValue(1, 8, "Importo")
    '        xls.SetCellValue(1, 9, "BC")
    '        xls.SetCellValue(1, 10, "Data Pagamento")
    '        xls.SetCellValue(1, 11, "Spese A Terzi")
    '        xls.SetCellValue(1, 12, "Impegno SP")
    '        xls.SetCellValue(1, 13, "Note")
    '        For Each Fascicolo In xc
    '            xls.SetCellValue(IndiceRiga, 1, Fascicolo.nFascicolo)
    '            xls.SetCellValue(IndiceRiga, 2, Fascicolo.Nominativo)
    '            xls.SetCellValue(IndiceRiga, 3, Fascicolo.DataApertura.ToShortDateString)
    '            xls.SetCellValue(IndiceRiga, 4, Fascicolo.Oggetto)
    '            xls.SetCellValue(IndiceRiga, 5, Fascicolo.DataChiusura.ToShortDateString)
    '            xls.SetCellValue(IndiceRiga, 6, Fascicolo.NFattRic)
    '            xls.SetCellValue(IndiceRiga, 7, Fascicolo.DataEmissione.ToShortDateString)
    '            xls.SetCellValue(IndiceRiga, 8, Fascicolo.Importo)
    '            xls.SetCellValue(IndiceRiga, 9, Fascicolo.BC)
    '            xls.SetCellValue(IndiceRiga, 10, Fascicolo.DataPagamento)
    '            xls.SetCellValue(IndiceRiga, 11, Fascicolo.SpeseATerzi)
    '            xls.SetCellValue(IndiceRiga, 12, Fascicolo.ImpegnoSP)
    '            xls.SetCellValue(IndiceRiga, 13, Fascicolo.Note)
    '            IndiceRiga = IndiceRiga + 1
    '        Next
    '        xls.Save(sfd.FileName)
    '        BaseLib.Msg.Info("Esportazione Completata")
    '    End If

    'End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim frm As New frmConto
        frm.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim frm As New frmTipoRegistrazione
        frm.ShowDialog()
    End Sub
End Class
