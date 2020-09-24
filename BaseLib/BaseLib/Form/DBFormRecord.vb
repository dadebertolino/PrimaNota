Public Class DBFormRecord

    Public Event DBCaricaDati()
    Public Event DBCaricaEtichetteLingua()
    Public Event DBVisualizzaDati()
    Public Event DBSalvaDati()
    Public Overridable Function DBControlli() As Boolean
        Return True
    End Function
    Private lVisualizzaAnnulla As Boolean
    Protected CaricaEtichetteLinguaBase As Boolean

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Visualizza il pulsante annulla")> Public Property DBVisualizzaAnnulla() As Boolean
        Get
            Return Me.lVisualizzaAnnulla
        End Get
        Set(ByVal value As Boolean)
            Me.lVisualizzaAnnulla = value
        End Set
    End Property

    Private Sub DBFormRecord_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CaricaEtichetteLinguaBase = False
        If Me.DBVisualizzaAnnulla = False Then
            Me.btnAnnulla.Visible = False
        End If
        RaiseEvent DBCaricaDati()
        RaiseEvent DBCaricaEtichetteLingua()
        RaiseEvent DBVisualizzaDati()
        If Me.CaricaEtichetteLinguaBase = True Then
            Me.btnConferma.Text = "Conferma"
            Me.btnAnnulla.Text = "Annulla"
        End If
    End Sub

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
        If DBControlli() = True Then
            RaiseEvent DBSalvaDati()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class
