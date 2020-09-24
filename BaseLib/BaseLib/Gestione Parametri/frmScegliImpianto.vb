Public Class frmScegliImpianto

   
    Private Sub frmScegliImpianto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.LookUpEdit1.EditValue = Me.DsElencoImpianti.ElencoImpianti(0).ID
    End Sub
End Class