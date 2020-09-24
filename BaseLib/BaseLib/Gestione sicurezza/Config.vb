Imports System

''' <summary>
''' Configuration class for the Crypto methods.
''' </summary>
Public Class Config

#Region "Variables"

    Private Shared _Encoding As Text.Encoding = Text.Encoding.UTF8
    Private Shared _Hexa As Boolean
    Private Shared _Key As String = "UsoUnaChiaveSuperSicuraHaHaHaHa"
    Private Shared _IV() As Byte = {1, 3, 10, 55, 70, 90, 240, 2}
    Private Shared _AutoAdjustKeyLength As Boolean = True

#End Region

#Region "Properties"

    ''' <value>Encoding to be used for (de)encryption. Default is UTF8.</value>
    Public Shared Property Encoding() As Text.Encoding
        Get
            Return _Encoding
        End Get
        Set(ByVal value As Text.Encoding)
            _Encoding = value
        End Set
    End Property

    ''' <value>Will return and use hexadecimal values. Default is False.</value>
    Public Shared Property Hexa() As Boolean
        Get
            Return _Hexa
        End Get
        Set(ByVal value As Boolean)
            _Hexa = value
        End Set
    End Property

    ''' <value>Encryption key. Default is "Crypto00"</value>
    Public Shared Property Key() As String
        Get
            Return _Key
        End Get
        Set(ByVal value As String)
            _Key = value
        End Set
    End Property

    ''' <value>Initialization vector. Default is {1, 3, 10, 55, 70, 90, 240, 2}</value>
    Public Shared Property IV() As Byte()
        Get
            Return _IV
        End Get
        Set(ByVal value() As Byte)
            _IV = value
        End Set
    End Property

    ''' <value>Will auto adjust the key value if length is invalid. Defaut is True.</value>
    Public Shared Property AutoAdjustKeyLength() As Boolean
        Get
            Return _AutoAdjustKeyLength
        End Get
        Set(ByVal value As Boolean)
            _AutoAdjustKeyLength = value
        End Set
    End Property

#End Region

#Region "Load configuration"

    ' ''' <summary>
    ' ''' Loads settings from the application configuration file.
    ' ''' </summary>
    'Public Shared Sub LoadFromXml()

    '	Dim strConfigIV As String
    '	Dim arrConfigIV() As String
    '	Dim i As Integer
    '	Dim intEncoding As Integer

    '       intEncoding = ConfigUtil.GetConfig("Devv.Encoding", 0)

    '	If intEncoding < 1 Then
    '           intEncoding = ConfigUtil.GetConfig("Devv.Core.Crypto.Encoding", _Encoding.CodePage)
    '	End If

    '	Encoding = Text.Encoding.GetEncoding(intEncoding)

    '       Hexa = ConfigUtil.GetConfig("Devv.Core.Crypto.Hexa", _Hexa)
    '       Key = ConfigUtil.GetConfig("Devv.Core.Crypto.Key", _Key)

    '       strConfigIV = ConfigUtil.GetConfig("Devv.Core.Crypto.IV")

    '	If strConfigIV.Length > 0 Then

    '		strConfigIV = strConfigIV.Replace(" ", ",")
    '		strConfigIV = strConfigIV.Replace("-", ",")
    '		strConfigIV = strConfigIV.Replace(";", ",")
    '		strConfigIV = strConfigIV.Replace(".", ",")
    '		strConfigIV = strConfigIV.Replace("|", ",")

    '		While strConfigIV.Contains(",,")
    '			strConfigIV = strConfigIV.Replace(",,", ",")
    '		End While

    '		arrConfigIV = strConfigIV.Split(Convert.ToChar(","))

    '		ReDim IV(arrConfigIV.Length)

    '		For i = 0 To arrConfigIV.Length - 1
    '			IV(i) = Convert.ToByte(arrConfigIV(i))
    '		Next

    '	End If

    '       AutoAdjustKeyLength = ConfigUtil.GetConfig("Devv.Core.Crypto.AutoAdjustKeyLength", _AutoAdjustKeyLength)

    'End Sub

#End Region

End Class