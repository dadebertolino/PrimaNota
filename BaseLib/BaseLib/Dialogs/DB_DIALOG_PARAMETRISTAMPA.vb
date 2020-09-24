Public Class DB_DIALOG_PARAMETRISTAMPA
    Public Event DBCaricaDati()
    Public Event DBStampa()
    Private Sub btnEsci_Click(sender As System.Object, e As System.EventArgs) Handles btnEsci.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnStampa_Click(sender As System.Object, e As System.EventArgs) Handles btnStampa.Click
        RaiseEvent DBStampa()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub DB_DIALOG_PARAMETRISTAMPA_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        RaiseEvent DBCaricaDati()
    End Sub
End Class
