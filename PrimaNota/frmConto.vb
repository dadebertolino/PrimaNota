Public Class frmConto
    Public Const GridViewConti As String = "GridviewConti.xml"

    Private Sub frmConto_DBDaVideoARecord() Handles Me.DBDaVideoARecord
        Dim Conto As PrimaNota.DAL.Conto
        Conto = Me.xpoObject
        Conto.Descrizione = Me.txtDescrizione.Text
    End Sub

    Private Sub frmConto_DBDaRecordAVideo() Handles Me.DBDaRecordAVideo
        Dim Conto As PrimaNota.DAL.Conto
        Conto = Me.xpoObject
        Me.txtDescrizione.Text = Conto.Descrizione
    End Sub

    Private Sub frmConto_DBRecordInit() Handles Me.DBRecordInit
        Dim Conto As PrimaNota.DAL.Conto
        Conto = Me.xpoObject
        Conto.Descrizione = ""
    End Sub

    Protected Overrides Function DBControlliSalva() As Boolean
        If Me.txtDescrizione.Text = "" Then
            BaseLib.Msg.ErrorContinue("Inserire la descrizione del conto")
            Me.txtDescrizione.Focus()
            Return False
        End If
        Return MyBase.DBControlliSalva
    End Function

    Private Sub frmConto_DBLoad() Handles Me.DBLoad
        Dim fi As New IO.FileInfo(GridViewConti)
        If fi.Exists = True Then
            Me.GridView1.RestoreLayoutFromXml(GridViewConti)
        End If
        Me.DBConsentiStampa = False
    End Sub

    Private Sub frmConto_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.GridView1.SaveLayoutToXml(GridViewConti)
    End Sub
End Class