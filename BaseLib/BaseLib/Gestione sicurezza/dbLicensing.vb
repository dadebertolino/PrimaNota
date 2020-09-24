Friend Module dbLicensing

    Private Property LicNomeUtente As String
        Get
            Return BaseLib.RegistryAccess.GetStringRegistryValue("LicTo", "N", False)
        End Get
        Set(value As String)
            BaseLib.RegistryAccess.SetStringRegistryValue("LicTo", value)
        End Set
    End Property

    Private Property LicRiferimentoFattura As String
        Get
            Return BaseLib.RegistryAccess.GetStringRegistryValue("RifFt", "N", False)
        End Get
        Set(value As String)
            BaseLib.RegistryAccess.SetStringRegistryValue("RifFt", value)
        End Set
    End Property

    Public Function LicTrialFinito() As Boolean
        Dim DataFineTrial As Date = New Date(Long.Parse(BaseLib.RegistryAccess.GetStringRegistryValue("ET", Date.Today.AddDays(30).Ticks.ToString, True)))
        If Date.Compare(DateTime.Now, DataFineTrial) >= 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function LicIsTrial() As Boolean
        If BaseLib.RegistryAccess.GetStringRegistryValue("T", "1", False) = "1" Then
            Return True
        End If
        Return False
    End Function

    Public Function ValidaHw() As Boolean
        Dim CPUId As String = ""
        Dim MacAddress As String = ""
        Dim VolumeSerial As String = ""
        Dim NumeroFattura As String = ""
        Dim NomeUtente As String = ""
        Dim CPUIdReaded As String = SysInfo.GetCPUId()
        Dim MacAddressReaded As String = SysInfo.GetMacAddress()
        Dim VolumeSerialReaded As String = SysInfo.GetVolumeSerial()
        Dim Risultato As Integer = 0
        Dim StringaDecodificata As String

        StringaDecodificata = HwKey
        If StringaDecodificata = "NL" Then
            Return False
        End If
        Dim Programma As String = ""
        Dim IDX As Integer = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            Programma = StringaDecodificata.Substring(0, IDX)
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        If Programma <> ApplicationName Then
            Return False
        End If
        IDX = StringaDecodificata.IndexOf("|")
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
        If NomeUtente <> LicNomeUtente Then
            Return False
        End If
        If NumeroFattura <> LicRiferimentoFattura Then
            Return False
        End If
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

    Private Property HwKey As String
        Get
            Try
                Return Cipher.TripleDESDecrypt(BaseLib.RegistryAccess.GetStringRegistryValue("LN", Cipher.TripleDESEncrypt("NL"), False))
            Catch ex As Exception
            End Try
            Return "NL"
        End Get
        Set(value As String)
            BaseLib.RegistryAccess.SetStringRegistryValue("LN", Cipher.TripleDESEncrypt(value))
        End Set
    End Property

    Public Function GetLicenseInfo() As String
        If LicIsTrial() = True Then
            Return "Trial Version"
        End If
        Dim InfoLic As String = "Programma registrato a: " & LicNomeUtente
        InfoLic &= "Riferimento Fattura: " & LicRiferimentoFattura
        Return InfoLic
    End Function

    Public Function LicRegister(Key As String) As Boolean
        Dim NumeroFattura As String = ""
        Dim NomeUtente As String = ""
        Dim Risultato As Integer = 0
        Dim StringaDecodificata As String
        Try
            StringaDecodificata = Cipher.TripleDESDecrypt(Key)
        Catch ex As Exception
            Return False
        End Try
        Dim Programma As String = ""
        Dim IDX As Integer = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            Programma = StringaDecodificata.Substring(0, IDX)
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        If Programma <> ApplicationName Then
            Return False
        End If
        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
            Try
                StringaDecodificata = StringaDecodificata.Substring(IDX + 1)
            Catch ex As Exception
                Return False
            End Try
        End If
        IDX = StringaDecodificata.IndexOf("|")
        If IDX >= 0 Then
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
        LicNomeUtente = NomeUtente
        LicRiferimentoFattura = NumeroFattura
        HwKey = Key
        Return True
    End Function


End Module
