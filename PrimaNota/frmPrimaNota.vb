Public Class frmPrimaNota
    Private Sub btnNuova_Click(sender As Object, e As EventArgs) Handles btnNuova.Click
        Using frm As New frmDettaglioRegistrazione
            Dim Registrazione As New DAL.Registrazione
            frm.Registrazione = Registrazione
            frm.DBVisualizzaAnnulla = True
            If frm.ShowDialog = DialogResult.OK Then
                Me.XPC_Registrazioni.Add(Registrazione)
            End If
        End Using
    End Sub

    Private Sub btnCarica_Click(sender As Object, e As EventArgs) Handles btnCarica.Click
        Dim OP_DataDa As New DevExpress.Data.Filtering.BinaryOperator("DataScadenza", Me.DateEdit1.EditValue, DevExpress.Data.Filtering.BinaryOperatorType.GreaterOrEqual)
        Dim OP_DataA As New DevExpress.Data.Filtering.BinaryOperator("DataScadenza", Me.DateEdit2.EditValue, DevExpress.Data.Filtering.BinaryOperatorType.LessOrEqual)
        Me.XPC_Registrazioni.Filter = OP_DataDa And OP_DataA

        Me.XPC_Registrazioni.Reload()
    End Sub

    Private Sub gvDettaglio_DoubleClick(sender As Object, e As EventArgs) Handles gvDettaglio.DoubleClick, btnModifica.Click
        Dim REGISTRAZIONE As PrimaNota.DAL.Registrazione = TryCast(Me.BindingSource1.Current, PrimaNota.DAL.Registrazione)
        If Not REGISTRAZIONE Is Nothing Then
            Dim frm As New frmDettaglioRegistrazione
            frm.Registrazione = REGISTRAZIONE
            If frm.ShowDialog() = DialogResult.OK Then
                frm.Registrazione = REGISTRAZIONE
                REGISTRAZIONE.Save()
            End If
        End If
    End Sub

    Private Sub btnCancella_Click(sender As Object, e As EventArgs) Handles btnCancella.Click
        Dim REGISTRAZIONE As PrimaNota.DAL.Registrazione = TryCast(Me.BindingSource1.Current, PrimaNota.DAL.Registrazione)
        If Not REGISTRAZIONE Is Nothing Then
            If BaseLib.Msg.QuestionYesNo("Cancello questa registrazione?") = MsgBoxResult.Yes Then
                REGISTRAZIONE.Delete()

            End If
            'Dim frm As New frmDettaglioRegistrazione
            'frm.Registrazione = REGISTRAZIONE
            'If frm.ShowDialog() = DialogResult.OK Then
            '    frm.Registrazione = REGISTRAZIONE
            '    REGISTRAZIONE.Save()
            'End If
        End If
    End Sub

    Private Sub frmPrimaNota_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DateEdit1.EditValue = New Date(Date.Now.Year, Date.Now.Month, 1)
        Me.DateEdit2.EditValue = New Date(Date.Now.Year, Date.Now.Month, 1).AddMonths(1).AddDays(-1)
    End Sub

    Private Sub btnStampa_Click(sender As Object, e As EventArgs) Handles btnStampa.Click
        If Not Me.gcPrimaNota.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If

        ' Opens the Preview window. 
        gcPrimaNota.ShowPrintPreview()
    End Sub
End Class