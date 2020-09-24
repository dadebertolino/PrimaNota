Public Class DB_DIALOG_CONFERMA_ANNULLA

    Public Event Caricamento(ByRef Runtime As Boolean)



    Public Sub New()
        Me.ControlBox = False
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    <System.ComponentModel.DefaultValue(False)> _
    Public Overloads Property ControlBox() As Boolean
        Get
            Return MyBase.ControlBox
        End Get
        Set(ByVal value As Boolean)
            MyBase.ControlBox = value
        End Set
    End Property

    Public Overridable Function Controlli() As Boolean
        Return True
    End Function

    Public Overridable Function DaRecordAVideo() As Boolean

    End Function

    Public Overridable Function DaVideoARecord() As Boolean

    End Function

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
        If Controlli() Then
            DaVideoARecord()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub DB_DIALOG_CONFERMA_ANNULLA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Runtime As Boolean = False
        If Me.DesignMode = False Then
            Runtime = True
        End If
        RaiseEvent Caricamento(Runtime)
        If Runtime = True Then
            Me.btnAnnulla.Text = "Annulla"
            Me.btnConferma.Text = "Conferma"
        End If
        If Runtime Then
            Me.DaRecordAVideo()
        End If
    End Sub

    Private Sub btnAnnulla_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
