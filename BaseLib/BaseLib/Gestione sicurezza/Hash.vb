Imports System
Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Hash algorithms.
''' </summary>
Public Class Hash

#Region "SHA"

    ''' <summary>
    ''' Computes the SHA1 hash for the specified value.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA1(ByVal value As String) As String

        Dim objHash As New SHA1Managed
        Return Hash(objHash, value, Config.Hexa)

    End Function

    ''' <summary>
    ''' Computes the SHA1 hash for the specified value, returns as hexadecimal.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA1(ByVal value As String, ByVal useHexa As Boolean) As String

        Dim objHash As New SHA1Managed
        Return Hash(objHash, value, useHexa)

    End Function

    ''' <summary>
    ''' Computes the SHA256 hash for the specified value.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA256(ByVal value As String) As String

        Dim objHash As New SHA256Managed
        Return Hash(objHash, value, Config.Hexa)

    End Function

    ''' <summary>
    ''' Computes the SHA256 hash for the specified value, returns as hexadecimal.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA256(ByVal value As String, ByVal useHexa As Boolean) As String

        Dim objHash As New SHA1Managed
        Return Hash(objHash, value, useHexa)

    End Function

    ''' <summary>
    ''' Computes the SHA384 hash for the specified value.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA384(ByVal value As String) As String

        Dim objHash As New SHA384Managed
        Return Hash(objHash, value, Config.Hexa)

    End Function

    ''' <summary>
    ''' Computes the SHA384 hash for the specified value, returns as hexadecimal.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA384(ByVal value As String, ByVal useHexa As Boolean) As String

        Dim objHash As New SHA384Managed
        Return Hash(objHash, value, useHexa)

    End Function

    ''' <summary>
    ''' Computes the SHA512 hash for the specified value.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA512(ByVal value As String) As String

        Dim objHash As New SHA512Managed
        Return Hash(objHash, value, Config.Hexa)

    End Function

    ''' <summary>
    ''' Computes the SHA512 hash for the specified value, returns as hexadecimal.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function SHA512(ByVal value As String, ByVal useHexa As Boolean) As String

        Dim objHash As New SHA512Managed
        Return Hash(objHash, value, useHexa)

    End Function

#End Region

#Region "MD5"

    ''' <summary>
    ''' Computes the MD5 hash for the specified value.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function MD5(ByVal value As String) As String

        Dim objHash As New MD5CryptoServiceProvider
        Return Hash(objHash, value, Config.Hexa)

    End Function

    ''' <summary>
    ''' Computes the MD5 hash for the specified value, returns as hexadecimal.
    ''' </summary>
    ''' <returns>The hash result as string.</returns>
    Public Shared Function MD5(ByVal value As String, ByVal useHexa As Boolean) As String

        Dim objHash As New MD5CryptoServiceProvider
        Return Hash(objHash, value, useHexa)

    End Function

#End Region

#Region "Hash internal"

    Private Shared Function Hash(ByVal objHash As HashAlgorithm, ByVal value As String, ByVal useHexa As Boolean) As String

        Dim strReturn As String = String.Empty
        Dim objStringBuilder As New StringBuilder
        Dim arrByte() As Byte
        Dim arrHash() As Byte
        Dim arrHexa() As Byte
        Dim intLength As Integer
        Dim i As Integer

        If value.Length > 0 Then

            arrByte = Config.Encoding.GetBytes(value)
            arrHash = objHash.ComputeHash(arrByte)

            If Not useHexa Then
                strReturn = Convert.ToBase64String(arrHash)
            Else
                arrHexa = Config.Encoding.GetBytes(Convert.ToBase64String(arrHash))
                intLength = arrHexa.Length - 1
                For i = 0 To intLength
                    objStringBuilder.Append(arrHexa(i).ToString("x"))
                Next i
                strReturn = objStringBuilder.ToString()
            End If

        End If

        Return strReturn

    End Function

#End Region

End Class