Public Class dbFormGAT
    Private WithEvents lDataGridView As DataGridView
    Private WithEvents lDataSet As DataSet
    Private WithEvents lDataRow As DataRow

    Private Sub BtnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnulla.Click
        If Me.Modal = True Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.Close()
        End If
    End Sub

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

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Il DataRow")> Public Property DataRow() As DataRow
        Get
            Return Me.lDataRow
        End Get
        Set(ByVal value As DataRow)
            Me.lDataRow = value
        End Set
    End Property
    Private Event DBEventoRinfrescaCorrente()

    Private Sub lbsNavigazione_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsIndagine.PositionChanged
        RaiseEvent DBEventoRinfrescaCorrente()
    End Sub

    Private Sub DBFormTable_DBEventoRinfrescaCorrente() Handles Me.DBEventoRinfrescaCorrente
        Me.BindingNavigatorPositionItem.Text = Me.bsIndagine.Position + 1
        If Me.bsIndagine.Position <= 0 Then
            Me.BindingNavigatorMoveFirstItem.Enabled = False
            Me.BindingNavigatorMovePreviousItem.Enabled = False
        Else
            Me.BindingNavigatorMoveFirstItem.Enabled = True
            Me.BindingNavigatorMovePreviousItem.Enabled = True
        End If
        If Me.bsIndagine.Position = Me.bsIndagine.Count - 1 Then
            Me.BindingNavigatorMoveNextItem.Enabled = False
            Me.BindingNavigatorMoveLastItem.Enabled = False
        Else
            Me.BindingNavigatorMoveNextItem.Enabled = True
            Me.BindingNavigatorMoveLastItem.Enabled = True
        End If
        Dim DataRowView As DataRowView
        DataRowView = TryCast(Me.bsIndagine.Current, DataRowView)
        If Not DataRowView Is Nothing Then
            Me.lDataRow = DataRowView.Row
        End If
    End Sub

    Public Event SalvaDati()

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
        If Not Me.lDataRow Is Nothing Then
            RaiseEvent SalvaDati()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class