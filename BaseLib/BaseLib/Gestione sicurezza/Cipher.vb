Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Methods for cipher algorithms.
''' </summary>
Public Class Cipher

#Region "RC2 Encrypt"

    ''' <summary>
    ''' Encrypts the value using RC2 with the default settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function RC2Encrypt(ByVal value As String) As String

        Return Encrypt(New RC2CryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function RC2Encrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New RC2CryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function RC2Encrypt(ByVal value As String, ByVal encKey As String) As String

        Return Encrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function RC2Encrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function RC2Encrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Encrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function RC2Encrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Encrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), useHexa)

    End Function

#End Region

#Region "DES Encrypt"

    ''' <summary>
    ''' Encrypts the value using DES with the default settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function DESEncrypt(ByVal value As String) As String

        Return Encrypt(New DESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function DESEncrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New DESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function DESEncrypt(ByVal value As String, ByVal encKey As String) As String

        Return Encrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function DESEncrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function DESEncrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Encrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function DESEncrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Encrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), useHexa)

    End Function

#End Region

#Region "TripleDES Encrypt"

    ''' <summary>
    ''' Encrypts the value using TripleDES with the default settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function TripleDESEncrypt(ByVal value As String) As String

        Return Encrypt(New TripleDESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function TripleDESEncrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New TripleDESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function TripleDESEncrypt(ByVal value As String, ByVal encKey As String) As String

        Return Encrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function TripleDESEncrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function TripleDESEncrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Encrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function TripleDESEncrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Encrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), useHexa)

    End Function

#End Region

#Region "AES Encrypt"

    ''' <summary>
    ''' Encrypts the value using AES with the default settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function AESEncrypt(ByVal value As String) As String

        Return Encrypt(New RijndaelManaged, value, Config.Key, IVHandler(Config.IV, 16), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function AESEncrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New RijndaelManaged, value, Config.Key, IVHandler(Config.IV, 16), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function AESEncrypt(ByVal value As String, ByVal encKey As String) As String

        Return Encrypt(New RijndaelManaged, value, encKey, IVHandler(Config.IV, 16), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function AESEncrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Encrypt(New RijndaelManaged, value, encKey, IVHandler(Config.IV, 16), useHexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function AESEncrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Encrypt(New RijndaelManaged, value, encKey, IVHandler(arrIV, 16), Config.Hexa)

    End Function

    ''' <summary>
    ''' Encrypts the value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The encryption result as string.</returns>
    Public Shared Function AESEncrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Encrypt(New RijndaelManaged, value, encKey, IVHandler(arrIV, 16), useHexa)

    End Function

#End Region

#Region "RC2 Decrypt"

    ''' <summary>
    ''' Decrypts the encrypted value using RC2 with the default settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function RC2Decrypt(ByVal value As String) As String

        Return Decrypt(New RC2CryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function RC2Decrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New RC2CryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function RC2Decrypt(ByVal value As String, ByVal encKey As String) As String

        Return Decrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function RC2Decrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function RC2Decrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Decrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using RC2 with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function RC2Decrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Decrypt(New RC2CryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), useHexa)

    End Function

#End Region

#Region "DES Decrypt"

    ''' <summary>
    ''' Decrypts the encrypted value using DES with the default settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function DESDecrypt(ByVal value As String) As String

        Return Decrypt(New DESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function DESDecrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New DESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function DESDecrypt(ByVal value As String, ByVal encKey As String) As String

        Return Decrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function DESDecrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function DESDecrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Decrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using DES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function DESDecrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Decrypt(New DESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), useHexa)

    End Function

#End Region

#Region "TripeDES Decrypt"

    ''' <summary>
    ''' Decrypts the encrypted value using TripleDES with the default settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function TripleDESDecrypt(ByVal value As String) As String

        Return Decrypt(New TripleDESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function TripleDESDecrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New TripleDESCryptoServiceProvider, value, Config.Key, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function TripleDESDecrypt(ByVal value As String, ByVal encKey As String) As String

        Return Decrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function TripleDESDecrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(Config.IV, 8), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function TripleDESDecrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Decrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using TripleDES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function TripleDESDecrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Decrypt(New TripleDESCryptoServiceProvider, value, encKey, IVHandler(arrIV, 8), useHexa)

    End Function

#End Region

#Region "AES Decrypt"

    ''' <summary>
    ''' Decrypts the encrypted value using AES with the default settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function AESDecrypt(ByVal value As String) As String

        Return Decrypt(New RijndaelManaged, value, Config.Key, IVHandler(Config.IV, 16), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function AESDecrypt(ByVal value As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New RijndaelManaged, value, Config.Key, IVHandler(Config.IV, 16), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function AESDecrypt(ByVal value As String, ByVal encKey As String) As String

        Return Decrypt(New RijndaelManaged, value, encKey, IVHandler(Config.IV, 16), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function AESDecrypt(ByVal value As String, ByVal encKey As String, ByVal useHexa As Boolean) As String

        Return Decrypt(New RijndaelManaged, value, encKey, IVHandler(Config.IV, 16), useHexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function AESDecrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte) As String

        Return Decrypt(New RijndaelManaged, value, encKey, IVHandler(arrIV, 16), Config.Hexa)

    End Function

    ''' <summary>
    ''' Decrypts the encrypted value using AES with the provided settings.
    ''' </summary>
    ''' <returns>The decryption result as string.</returns>
    Public Shared Function AESDecrypt(ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal useHexa As Boolean) As String

        Return Decrypt(New RijndaelManaged, value, encKey, IVHandler(arrIV, 16), useHexa)

    End Function

#End Region

#Region "Encrypt and decrypt internal"

    Private Shared Function Encrypt(ByVal objCrypto As SymmetricAlgorithm, ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal blnHexa As Boolean) As String

        Dim strReturn As String = String.Empty
        Dim objStringBuilder As New StringBuilder
        Dim objMS As New MemoryStream
        Dim objCS As CryptoStream
        Dim objSW As StreamWriter
        Dim arrHexa() As Byte
        Dim arrKey() As Byte
        Dim intLength As Integer
        Dim i As Integer

        If value.Length > 0 Then

            arrKey = KeyHandler(encKey, objCrypto.LegalKeySizes(0).MinSize \ 8)

            objCS = New CryptoStream(objMS, objCrypto.CreateEncryptor(arrKey, arrIV), CryptoStreamMode.Write)
            objSW = New StreamWriter(objCS)
            objSW.Write(value)
            objSW.Flush()
            objCS.FlushFinalBlock()
            objMS.Flush()

            strReturn = Convert.ToBase64String(objMS.GetBuffer(), 0, Convert.ToInt32(objMS.Length))

            If blnHexa Then
                arrHexa = Config.Encoding.GetBytes(strReturn)
                intLength = arrHexa.Length - 1
                For i = 0 To intLength
                    objStringBuilder.Append(arrHexa(i).ToString("x"))
                Next i
                strReturn = objStringBuilder.ToString()
            End If

            objSW.Close()
            objCS.Close()
            objMS.Close()
            objCrypto.Clear()

        End If

        Return strReturn

    End Function

    Private Shared Function Decrypt(ByVal objCrypto As SymmetricAlgorithm, ByVal value As String, ByVal encKey As String, ByVal arrIV() As Byte, ByVal blnHexa As Boolean) As String

        Dim strReturn As String = String.Empty
        Dim objStringBuilder As New StringBuilder
        Dim objMS As MemoryStream
        Dim objCS As CryptoStream
        Dim objSR As StreamReader
        Dim arrHexa() As Byte
        Dim arrKey() As Byte
        Dim intLength As Integer
        Dim i As Integer

        If value.Length > 0 Then

            If blnHexa Then
                intLength = Convert.ToInt32((value.Length / 2) - 1)
                ReDim arrHexa(intLength)
                For i = 0 To intLength
                    arrHexa(i) = Byte.Parse(value.Substring(i * 2, 2), Globalization.NumberStyles.HexNumber)
                Next i
                value = Config.Encoding.GetString(arrHexa)
            End If

            arrKey = KeyHandler(encKey, objCrypto.LegalKeySizes(0).MinSize \ 8)

            objMS = New MemoryStream(Convert.FromBase64String(value))
            objCS = New CryptoStream(objMS, objCrypto.CreateDecryptor(arrKey, arrIV), CryptoStreamMode.Read)
            objSR = New StreamReader(objCS)

            strReturn = objSR.ReadToEnd()

            objSR.Close()
            objCS.Close()
            objMS.Close()
            objCrypto.Clear()

        End If

        Return strReturn

    End Function

#End Region

#Region "Helper methods"

    Private Shared Function IVHandler(ByVal arrIV() As Byte, ByVal intSize As Integer) As Byte()

        Dim arrReturn(intSize) As Byte
        Dim i As Integer
        Dim z As Integer = 0

        If arrIV Is Nothing Then
            arrIV = Config.IV
        End If

        If Not Config.AutoAdjustKeyLength And arrIV.Length <> intSize Then
            Throw (New CryptoException(GetType(Cipher), "Exception"))
        End If

        If intSize = arrIV.Length Then
            Return arrIV
        ElseIf intSize < arrIV.Length Then
            For i = 0 To intSize - 1
                arrReturn(i) = arrIV(i)
            Next
        ElseIf intSize > arrIV.Length Then
            For i = 0 To intSize - 1
                arrReturn(i) = arrIV(z)
                z += 1
                If z > arrIV.Length - 1 Then
                    z = 0
                End If
            Next
        End If

        Return arrReturn

    End Function

    Private Shared Function KeyHandler(ByVal encKey As String, ByVal intSize As Integer) As Byte()

        Dim strNewKey As String
        Dim i As Integer
        Dim z As Integer = 0

        If Not Config.AutoAdjustKeyLength And encKey.Length <> intSize Then
            Throw (New CryptoException(GetType(Cipher), "Exception"))
        End If

        strNewKey = encKey

        If encKey.Length < intSize Then
            For i = encKey.Length + 1 To intSize
                strNewKey &= encKey.Substring(z, 1)
                z += 1
                If z > encKey.Length - 1 Then
                    z = 0
                End If
            Next
        ElseIf encKey.Length > intSize Then
            strNewKey = encKey.Substring(0, intSize)
        End If

        Return Config.Encoding.GetBytes(strNewKey)

    End Function

#End Region

End Class