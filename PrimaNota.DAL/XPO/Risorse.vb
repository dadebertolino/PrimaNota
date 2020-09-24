Imports System
Imports DevExpress.Xpo

Public Class TipoRegistrazione
    Inherits XPObject

    Public Sub New()
        MyBase.New()
        ' This constructor is used when an object is loaded from a persistent storage.
        ' Do not place any code here.			
    End Sub

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
        ' This constructor is used when an object is loaded from a persistent storage.
        ' Do not place any code here.			
    End Sub

    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place here your initialization code.
    End Sub

    <Size(200)> Public Property Descrizione As String
    Public Property Spesa As Boolean
    Public Property PercentualeDetrazione As Decimal

End Class

Public Class Conto
    Inherits XPObject

    Public Sub New()
        MyBase.New()
        ' This constructor is used when an object is loaded from a persistent storage.
        ' Do not place any code here.			
    End Sub

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
        ' This constructor is used when an object is loaded from a persistent storage.
        ' Do not place any code here.			
    End Sub

    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place here your initialization code.
    End Sub

    <Size(200)> Public Property Descrizione As String
End Class

Public Class Registrazione
    Inherits XPObject

    Public Sub New()
        MyBase.New()
        ' This constructor is used when an object is loaded from a persistent storage.
        ' Do not place any code here.			
    End Sub

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
        ' This constructor is used when an object is loaded from a persistent storage.
        ' Do not place any code here.			
    End Sub

    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place here your initialization code.
    End Sub

    <Size(200)> Public Property Descrizione As String
    Public Property Tipo As TipoRegistrazione
    Public Property Conto As Conto
    <Size(200)> Public Property ClienteFornitore As String
    Public Property Entrate As Decimal
    Public Property Uscite As Decimal
    Public Property DataScadenza As Date
    Public Property DataPagamento As Date
    Public Property ValoreAmmortamento As Decimal
    Public Property ModalitaPagamento As String
End Class