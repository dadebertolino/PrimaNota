Public Class dbFormIndagine

    Private WithEvents lGridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents lDataRow As DataRow
    Private lAutoLoadData As Boolean

    Private Sub BtnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Event DBLoadDatiIndagine()
    Public Event DBCaricaAltriDati()
    Public Event DBIndagineOk(DataRow As DataRow)

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Auto load Data on form load"), System.ComponentModel.DefaultValue(True)> Public Property AutoLoadData() As Boolean
        Get
            Return Me.lAutoLoadData
        End Get
        Set(ByVal value As Boolean)
            Me.lAutoLoadData = value
        End Set
    End Property

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Il DataRow")> Public Property DataRow() As DataRow
        Get
            Return Me.lDataRow
        End Get
        Set(ByVal value As DataRow)
            Me.lDataRow = value
        End Set
    End Property

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Il GridControl")> Public Property GridControl() As DevExpress.XtraGrid.GridControl
        Get
            Return Me.lGridControl
        End Get
        Set(ByVal value As DevExpress.XtraGrid.GridControl)
            Me.lGridControl = value
        End Set
    End Property

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Conferma()
    End Sub

    Private Sub Conferma()
        Dim DataRowView As DataRowView
        DataRowView = TryCast(Me.bsIndagine.Current, DataRowView)
        If Not DataRowView Is Nothing Then
            Me.lDataRow = DataRowView.Row
            RaiseEvent DBIndagineOk(Me.lDataRow)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dbFormIndagine_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Runtime Then
            RaiseEvent DBCaricaAltriDati()
            If Me.AutoLoadData Then
                RaiseEvent DBLoadDatiIndagine()
            End If
            AddHandler btnConferma.Click, AddressOf Me.btnConferma_Click
            AddHandler lGridControl.DoubleClick, AddressOf Me.btnConferma_Click
            AddHandler BtnAnnulla.Click, AddressOf Me.BtnAnnulla_Click
        End If
    End Sub
End Class