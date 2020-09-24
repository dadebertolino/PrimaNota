Public Class DBFormIndagineXPO
    Private WithEvents lGridControl As DevExpress.XtraGrid.GridControl
    Private lAutoLoadData As Boolean
    Private lxpoObject As DevExpress.Xpo.XPObject
    Private WithEvents lxpcCollection As DevExpress.Xpo.XPCollection

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("La collection")> Public Property xpcCollection() As DevExpress.Xpo.XPCollection
        Get
            Return Me.lxpcCollection
        End Get
        Set(ByVal value As DevExpress.Xpo.XPCollection)
            Me.lxpcCollection = value
        End Set
    End Property

    Public WriteOnly Property Session As DevExpress.Xpo.Session
        Set(value As DevExpress.Xpo.Session)
            If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Runtime Then
                If Not Me.lxpcCollection Is Nothing Then
                    If Not value Is Nothing Then
                        Me.lxpcCollection.Session = value
                    End If
                End If
            End If
        End Set
    End Property

    Public ReadOnly Property xpoObject As DevExpress.Xpo.XPObject
        Get
            Return lxpoObject
        End Get
    End Property

    Private Sub BtnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Event DBLoadDatiIndagine()
    Public Event DBCaricaAltriDati()
    Public Event DBIndagineOk(xpoObject As DevExpress.Xpo.XPObject)

    <System.ComponentModel.Category("DBBaseLib"), System.ComponentModel.Description("Auto load Data on form load"), System.ComponentModel.DefaultValue(True)> Public Property AutoLoadData() As Boolean
        Get
            Return Me.lAutoLoadData
        End Get
        Set(ByVal value As Boolean)
            Me.lAutoLoadData = value
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
        lxpoObject = TryCast(Me.bsIndagine.Current, DevExpress.Xpo.XPObject)
        If Not lxpoObject Is Nothing Then
            RaiseEvent DBIndagineOk(lxpoObject)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dbFormIndagine_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Runtime Then
            RaiseEvent DBCaricaAltriDati()
            Me.xpcCollection.LoadingEnabled = False
            If Me.AutoLoadData Then
                RaiseEvent DBLoadDatiIndagine()
                Me.xpcCollection.LoadingEnabled = True
            End If
            AddHandler btnConferma.Click, AddressOf Me.btnConferma_Click
            AddHandler lGridControl.DoubleClick, AddressOf Me.btnConferma_Click
            AddHandler BtnAnnulla.Click, AddressOf Me.BtnAnnulla_Click
        End If
    End Sub

    Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
End Class