Public Class frmProgress 
    Public Property Progress As Integer
        Set(ByVal value As Integer)
            Me.ProgressBarControl1.EditValue = value
        End Set
        Get
            Return CType(Me.ProgressBarControl1.EditValue, Integer)
        End Get
    End Property
End Class