Imports System.IO

Public Module DBLogger

    'Public Function InitLog() As Boolean
    '    Gibraltar.Agent.Log.StartSession("Apertura applicazione.")
    '    Return True
    'End Function

    'Public Sub AddLogInfo(Message As String)
    '    Gibraltar.Agent.Log.Information("", "", Message, Nothing)
    'End Sub

    'Public Sub AddLogError(Message As String)
    '    Gibraltar.Agent.Log.Error("", "", Message, Nothing)
    'End Sub
    'Private Log As TracerX.Logger
    Public Function InitLog() As Boolean
        'TracerX.Logger.Xml.Configure("LoggerConfig.xml")
        'TracerX.Logger.DefaultBinaryFile.Name = Application.ApplicationName
        'TracerX.Logger.DefaultBinaryFile.Directory = Path.Combine(Application.SettingPath, "Logs")
        'TracerX.Logger.DefaultBinaryFile.CircularStartDelaySeconds = 0
        'TracerX.Logger.DefaultBinaryFile.MaxSizeMb = 5
        'TracerX.Logger.DefaultBinaryFile.CircularStartSizeKb = 0
        'Log = TracerX.Logger.GetLogger(Application.ApplicationName)
        'Return TracerX.Logger.DefaultBinaryFile.Open()
        Return True
    End Function

    Public Sub AddLogInfo(Message As String)
        'If Log Is Nothing Then
        '    Exit Sub
        'End If
        'Log.Info(Message)

    End Sub
    Public Sub AddLogError(Message As String)
        'If Log Is Nothing Then
        '    Exit Sub
        'End If
        'Log.Info(Message)
    End Sub
End Module