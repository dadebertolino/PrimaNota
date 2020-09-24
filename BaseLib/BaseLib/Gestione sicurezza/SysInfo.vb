Imports System.Management
Imports System.Net.NetworkInformation
Imports System

Public Class SysInfo

#Region " Constructors "



#End Region

#Region " Private Fields "



#End Region

#Region " Events "



#End Region

#Region " Protected Properties "



#End Region

#Region " Public Properties "



#End Region

#Region " Private Methods "

    Friend Shared Function GetCPUId() As String
        Dim cpuInfo As String = String.Empty
        Dim temp As String = String.Empty
        Dim mc As New ManagementClass("Win32_Processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If cpuInfo = String.Empty Then
                cpuInfo = mo.Properties("ProcessorId").Value.ToString()
            End If
        Next
        Return cpuInfo
    End Function

    Friend Shared Function GetMacAddress() As String
        Dim macs As String = String.Empty
        Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        For Each ni As NetworkInterface In interfaces
            Dim pa As PhysicalAddress = ni.GetPhysicalAddress
            macs += pa.ToString()
        Next
        Return macs
    End Function

    Friend Shared Function GetVolumeSerial() As String
        Dim strDriveLetter As String = String.Empty

        Dim mc As New ManagementClass("Win32_LogicalDisk")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            Try
                If CType(mo.Properties("MediaType").Value, UInt16) = 12 Then
                    Dim serial As String = mo("VolumeSerialNumber").ToString().Trim()
                    If Not String.IsNullOrEmpty(serial) Then
                        Return serial
                    End If
                End If
            Catch
            End Try

        Next
        Return strDriveLetter
    End Function

#End Region

#Region " Protected Methods "



#End Region

#Region " Public Methods "

    Public Shared Function GetUniqueID() As String
        Dim ID As String = Cipher.AESEncrypt(GetCPUId() & "|" & GetMacAddress() & "|" & GetVolumeSerial())
        Return ID
    End Function

    Public Shared Function ValidateHardware(Key As String, ByRef NomeUtente As String, ByRef NumeroFattura As String, ByRef Trial As Boolean, ByRef DurataTrial As Integer) As Boolean
        Dim CPUId As String = ""
        Dim MacAddress As String = ""
        Dim VolumeSerial As String = ""
        Dim CPUIdReaded As String = GetCPUId()
        Dim MacAddressReaded As String = GetMacAddress()
        Dim VolumeSerialReaded As String = GetVolumeSerial()
        Dim Risultato As Integer = 0
        Dim StringaDecodificata As String = Cipher.TripleDESDecrypt(Key)
        Dim IDX As Integer = StringaDecodificata.IndexOf("|")
        Trial = False
        DurataTrial = 30
        If IDX >= 0 Then
            CPUId = StringaDecodificata.Substring(0, IDX)
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            MacAddress = StringaDecodificata.Substring(0, IDX)
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            VolumeSerial = StringaDecodificata.Substring(0, IDX)
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            NomeUtente = StringaDecodificata.Substring(0, IDX)
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            NumeroFattura = StringaDecodificata.Substring(0, IDX)
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If

        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            If StringaDecodificata.Substring(0, IDX) = "1" Then
                Trial = True
            Else
                Trial = False
            End If
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        Try
            DurataTrial = CInt(StringaDecodificata.Substring(0, IDX))
        Catch ex As Exception
            DurataTrial = 30
        End Try
        'IDX = StringaDecodificata.IndexOf("|")
        'If IDX >= 0 Then
        '    DurataTrial = CInt(StringaDecodificata.Substring(0, IDX))
        '    Try
        '        StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
        '    Catch ex As Exception
        '        Return False
        '    End Try
        'End If
TrialByPass:

        If String.Compare(CPUId, CPUIdReaded) = 0 Then
            Risultato += 1
        End If
        If String.Compare(MacAddress, MacAddressReaded) = 0 Then
            Risultato += 1
        End If
        If String.Compare(VolumeSerial, VolumeSerialReaded) = 0 Then
            Risultato += 1
        End If
        If Risultato >= 2 Then
            Return True
        End If
        Return False
    End Function


#End Region

End Class