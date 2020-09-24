Imports System
Imports DevExpress.Xpo

Public Class VersioneDB
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

    Public Const FN_VERSIONE As String = "VERSIONE"

    Private fVERSIONE As Integer
    Public Property VERSIONE() As Integer
        Get
            Return fVERSIONE
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)(FN_VERSIONE, fVERSIONE, value)
        End Set
    End Property
End Class