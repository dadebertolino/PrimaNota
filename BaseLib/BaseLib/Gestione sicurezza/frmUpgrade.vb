Public Class frmUpgrade 
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.txtHardwareKey.Text = SysInfo.GetUniqueID
    End Sub

    Public Event LicenziaSoftware()
    Public Event BloccaLicenza()

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Nomeutente As String = ""
        Dim NumeroFattura As String = ""
        Dim Licensed As String = BaseLib.RegistryAccess.GetStringRegistryValue("Licensed", "N", False)
        Dim LicensedTo As String = BaseLib.RegistryAccess.GetStringRegistryValue("LicensedTo", "N", False)
        Dim Trial As Boolean = False
        Dim DurataTrial As Integer = 30
        Try
            Dim b As Boolean = SysInfo.ValidateHardware(Me.txtUnlock.Text, Nomeutente, NumeroFattura, Trial, DurataTrial)
            If b = True Then

                BaseLib.Msg.Info("Licensed to " & Nomeutente & vbCrLf & "Doc N° " & NumeroFattura)
                BaseLib.RegistryAccess.SetStringRegistryValue("Licensed", "Y")
                BaseLib.RegistryAccess.SetStringRegistryValue("LicensedTo", Nomeutente)
                BaseLib.RegistryAccess.SetStringRegistryValue("DocNumber", NumeroFattura)
                If Trial = True Then
                    BaseLib.RegistryAccess.SetStringRegistryValue("T", "1")
                Else
                    BaseLib.RegistryAccess.SetStringRegistryValue("T", "0")
                End If
                BaseLib.RegistryAccess.SetStringRegistryValue("ET", Date.Today.AddDays(DurataTrial).ToString)
                RaiseEvent LicenziaSoftware()
            End If
        Catch ex As Exception
            BaseLib.Msg.ErrorContinue("Invalid Key")
            RaiseEvent BloccaLicenza()
            BaseLib.RegistryAccess.SetStringRegistryValue("Licensed", "N")
            BaseLib.RegistryAccess.SetStringRegistryValue("LicensedTo", "N")
            BaseLib.RegistryAccess.SetStringRegistryValue("DocNumber", "xxx")
        End Try

    End Sub
End Class