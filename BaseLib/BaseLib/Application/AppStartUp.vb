Public Module Application
    Private Name As String
    Friend Skin As DevExpress.LookAndFeel.UserLookAndFeel

    ReadOnly Property DBSistemiString As String
        Get
            Return "DBSistemi"
        End Get
    End Property

    ReadOnly Property ApplicationName As String
        Get
            Return Name
        End Get
    End Property

    ReadOnly Property ApplicationDescription As String
        Get
            Return Name '& " By " & DBSistemiString
        End Get
    End Property

    ReadOnly Property ApplicationVersion As String
        Get
            Return System.String.Format("V: {0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        End Get
    End Property

    Public ReadOnly Property SettingPath As String
        Get
            Dim DataDir As String
            DataDir = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, Application.DBSistemiString)
            Dim di As New IO.DirectoryInfo(DataDir)
            If di.Exists = False Then
                di.Create()
            End If
            Return DataDir
        End Get
    End Property

    Public Function StartUp(ByVal ApplicationName As String) As Boolean
        'BaseLib.TWU.CleanupUpdate()
        Name = ApplicationName
        BaseLib.DBLogger.InitLog()
        'DevExpress.UserSkins.OfficeSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = BaseLib.RegistryAccess.GetStringRegistryValue("SkinName", "Office 2007 Blue", True)
        Skin = DevExpress.LookAndFeel.UserLookAndFeel.Default
        Name = ApplicationName
        Return True
        If ValidaHw() = True Then
            Return True
        Else
            If dbLicensing.LicTrialFinito = False Then

            End If
        End If
        BaseLib.Msg.ErrorStop("Periodo di vautazione terminato")

        Return False
    End Function


    Public Sub Close()
        BaseLib.RegistryAccess.SetStringRegistryValue("SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName)
    End Sub
End Module
