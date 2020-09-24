Imports System
Imports DevExpress.Xpo

Public Class PROGRESSIVI
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

    Public Const FN_TABELLA As String = "TABELLA"
    Public Const FN_VALORE As String = "VALORE"
    Public Const FN_ANNO As String = "ANNO"

    Private fTABELLA As String
    Public Property TABELLA() As String
        Get
            Return fTABELLA
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(FN_TABELLA, fTABELLA, value)
        End Set
    End Property

    Private fVALORE As Integer
    Public Property VALORE() As Integer
        Get
            Return fVALORE
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)(FN_VALORE, fVALORE, value)
        End Set
    End Property

    Private fANNO As Integer
    Public Property ANNO() As Integer
        Get
            Return fANNO
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)(FN_ANNO, fANNO, value)
        End Set
    End Property
End Class