Imports System
Imports DevExpress.Xpo
Public Module Costanti
    Public Const INSTALLAZIONE_NON_CODIFICATA As String = "NONCOD"
End Module

Friend Enum E_PARAMETRI As Integer
    Anno = 0 'ok parametri
    Path = 1 'ok
    Etichetta = 2
End Enum

Friend Class PARAMETRI_DB
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

    Public Const FN_PARAMETRO As String = "PARAMETRO"
    Public Const FN_PC As String = "PC"
    Public Const FN_VALORE_INT As String = "VALORE_INT"
    Public Const FN_VALORE_BOOL As String = "VALORE_BOOL"
    Public Const FN_VALORE_DECIMAL As String = "VALORE_DECIMAL"
    Public Const FN_VALORE_DATE As String = "VALORE_DATE"
    Public Const FN_VALORE_STRING As String = "VALORE_STRING"


    Private fPARAMETRO As E_PARAMETRI
    Public Property PARAMETRO() As E_PARAMETRI
        Get
            Return fPARAMETRO
        End Get
        Set(ByVal value As E_PARAMETRI)
            SetPropertyValue(Of Integer)(FN_PARAMETRO, fPARAMETRO, value)
        End Set
    End Property

    Private fPC As String
    Public Property PC() As String
        Get
            Return fPC
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(FN_PC, fPC, value)
        End Set
    End Property

    Private fVALORE_INT As Integer
    Public Property VALORE_INT() As Integer
        Get
            Return fVALORE_INT
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)(FN_VALORE_INT, fVALORE_INT, value)
        End Set
    End Property

    Private fVALORE_BOOL As Boolean
    Public Property VALORE_BOOL() As Boolean
        Get
            Return fVALORE_BOOL
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)(FN_VALORE_BOOL, fVALORE_BOOL, value)
        End Set
    End Property
    Private fVALORE_DECIMAL As Decimal
    Public Property VALORE_DECIMAL() As Decimal
        Get
            Return fVALORE_DECIMAL
        End Get
        Set(ByVal value As Decimal)
            SetPropertyValue(Of Decimal)(FN_VALORE_DECIMAL, fVALORE_DECIMAL, value)
        End Set
    End Property

    Private fVALORE_DATE As Date
    Public Property VALORE_DATE() As Date
        Get
            Return fVALORE_DATE
        End Get
        Set(ByVal value As Date)
            SetPropertyValue(Of Date)(FN_VALORE_DATE, fVALORE_DATE, value)
        End Set
    End Property

    Private fVALORE_STRING As String
    Public Property VALORE_STRING() As String
        Get
            Return fVALORE_STRING
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(FN_VALORE_STRING, fVALORE_STRING, value)
        End Set
    End Property

End Class

Public Module ParametriXml
    Public Installazione As String
    Public ConnectionString As String
    Public UsaMotoreSSLocale As Boolean
    Public NomeMotoreSSLocale As String

    Private pb As BaseLib.ParametriBase

    Public Function LoadParametri(NomeParametri As String) As Boolean
        pb = New BaseLib.ParametriBase(NomeParametri)
        ' Questi continueranno a stare nel file xml
        UsaMotoreSSLocale = pb.GetKeyValueBoolean("UsaMotoreSSLocale", False)
        NomeMotoreSSLocale = pb.GetKeyValueString("NomeMotoreSSLocale", "")
        ConnectionString = pb.GetKeyValueString("ConnectionString", "XpoProvider=VistaDB5;Data Source= " & IO.Path.Combine(BaseLib.Application.SettingPath, NomeParametri & ".vdb5"))
        Installazione = pb.GetKeyValueString("Installazione", "Installazione")
        Return True
    End Function

    Public Sub SaveParametri() 'VecchiaInstallazione As String)
        pb.SetKeyValueString("Installazione", Installazione)
        pb.SaveParameters()
    End Sub
End Module

Public Module Parametri

    Private Function GetParametroDB(Parametro As E_PARAMETRI, PC As Boolean) As PARAMETRI_DB
        Dim FiltroPC As New DevExpress.Data.Filtering.BinaryOperator(PARAMETRI_DB.FN_PC, My.Computer.Name, DevExpress.Data.Filtering.BinaryOperatorType.Equal)
        Dim FiltroParametro As New DevExpress.Data.Filtering.BinaryOperator(PARAMETRI_DB.FN_PARAMETRO, Parametro, DevExpress.Data.Filtering.BinaryOperatorType.Equal)

        Dim xpc As DevExpress.Xpo.XPCollection(Of PARAMETRI_DB)
        If PC = True Then
            xpc = New DevExpress.Xpo.XPCollection(Of PARAMETRI_DB)(FiltroParametro And FiltroPC)
        Else
            xpc = New DevExpress.Xpo.XPCollection(Of PARAMETRI_DB)(FiltroParametro)
        End If
        If xpc.Count > 0 Then
            Return xpc(0)
        Else
            Dim ParDB As New PARAMETRI_DB
            If PC = True Then
                ParDB.PC = My.Computer.Name
            End If
            ParDB.PARAMETRO = Parametro
            ParDB.Save
            Return ParDB
        End If
    End Function

    Private Function GetValoreInt(Parametro As E_PARAMETRI, Optional ByVal PC As Boolean = False) As Integer
        Return GetParametroDB(Parametro, pc).VALORE_INT
    End Function

    Private Sub SetValoreInt(Parametro As E_PARAMETRI, valore As Integer, Optional ByVal PC As Boolean = False)
        Dim ParDB As PARAMETRI_DB = GetParametroDB(Parametro, pc)
        ParDB.VALORE_INT = valore
        ParDB.Save
    End Sub

    Private Function GetValoreBool(Parametro As E_PARAMETRI, Optional ByVal PC As Boolean = False) As Boolean
        Return GetParametroDB(Parametro, pc).VALORE_BOOL
    End Function

    Private Sub SetValoreBool(Parametro As E_PARAMETRI, valore As Boolean, Optional ByVal PC As Boolean = False)
        Dim ParDB As PARAMETRI_DB = GetParametroDB(Parametro, pc)
        ParDB.VALORE_BOOL = valore
        ParDB.Save
    End Sub

    Private Function GetValoreDecimal(Parametro As E_PARAMETRI, Optional ByVal PC As Boolean = False) As Decimal
        Return GetParametroDB(Parametro, pc).VALORE_DECIMAL
    End Function

    Private Sub SetValoreDecimal(Parametro As E_PARAMETRI, valore As Decimal, Optional ByVal PC As Boolean = False)
        Dim ParDB As PARAMETRI_DB = GetParametroDB(Parametro, pc)
        ParDB.VALORE_DECIMAL = valore
        ParDB.Save
    End Sub

    Private Function GetValoreDate(Parametro As E_PARAMETRI, Optional ByVal PC As Boolean = False) As Date
        Return GetParametroDB(Parametro, pc).VALORE_DATE
    End Function

    Private Sub SetValoreDate(Parametro As E_PARAMETRI, valore As Date, Optional ByVal PC As Boolean = False)
        Dim ParDB As PARAMETRI_DB = GetParametroDB(Parametro, pc)
        ParDB.VALORE_DATE = valore
        ParDB.Save
    End Sub

    Private Function GetValoreString(Parametro As E_PARAMETRI, Optional ByVal PC As Boolean = False) As String
        Return GetParametroDB(Parametro, pc).VALORE_STRING
    End Function

    Private Sub SetValoreString(Parametro As E_PARAMETRI, valore As String, Optional ByVal PC As Boolean = False)
        Dim ParDB As PARAMETRI_DB = GetParametroDB(Parametro, pc)
        ParDB.VALORE_STRING = valore
        ParDB.Save
    End Sub

    Public Property Anno As Integer
        Get
            Return GetValoreInt(E_PARAMETRI.Anno)
        End Get
        Set(value As Integer)
            SetValoreInt(E_PARAMETRI.Anno, value)
        End Set
    End Property

    Public Property path As String
        Get
            Return GetValoreString(E_PARAMETRI.Path, True)
        End Get
        Set(value As String)
            SetValoreString(E_PARAMETRI.Path, value, True)
        End Set
    End Property

    Public Property NomeReportEtichetta As String
        Get
            Return GetValoreString(E_PARAMETRI.Etichetta, False)
        End Get
        Set(value As String)
            SetValoreString(E_PARAMETRI.Etichetta, value, False)
        End Set
    End Property

End Module

Public Enum ValorizzazioneMagazzino As Integer
    Fifo
    Lifo
    ValorMedio
End Enum