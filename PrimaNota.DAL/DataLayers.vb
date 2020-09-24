Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.ServiceProcess

Public Module DataLayers

    Public Function CheckStatoMotoreLocale() As Boolean
        Dim status As String  'service status (For example, Running or Stopped)
        Dim mySC As ServiceController
        'display service status: For example, Running, Stopped, or Paused
        Try
            mySC = New ServiceController(ParametriXml.NomeMotoreSSLocale)
        Catch ex As Exception
            BaseLib.Msg.ErrorContinue(ex.Message)
            Return False
        End Try

        Try
            status = mySC.Status.ToString
        Catch ex As Exception
            BaseLib.Msg.ErrorContinue("Nome del servizio SQLServer errato o motore non installato")
            Return False
        End Try
        'if service is Stopped or StopPending, you can run it with the following code.
        If mySC.Status.Equals(ServiceControllerStatus.Stopped) Or mySC.Status.Equals(ServiceControllerStatus.StopPending) Then
            Try
                mySC.Start()
                mySC.WaitForStatus(ServiceControllerStatus.Running)
                BaseLib.Msg.Info(mySC.Status.ToString)
            Catch ex As Exception
                BaseLib.Msg.ErrorContinue("Impossibile avviare il servizio SQLServer." & vbCrLf & "Riavviare il programma come amministratore o contattare l'assistenza")
                Return False
            End Try
        End If
        Return True
    End Function

    Private Sub ControlloVersioneDB()
        Dim XP_VERSIONE As New DevExpress.Xpo.XPCollection(Of VersioneDB)
        Dim VERSIONE As VersioneDB
        If XP_VERSIONE.Count = 0 Then
            VERSIONE = New VersioneDB(XP_VERSIONE.Session)
            VERSIONE.VERSIONE = 1
            XP_VERSIONE.Add(VERSIONE)
            VERSIONE.Save()
        End If
        VERSIONE = XP_VERSIONE(0)

    End Sub
    Public Function Setup() As Boolean
        Try
            If ParametriXml.UsaMotoreSSLocale = True Then
                If CheckStatoMotoreLocale() = False Then
                    Return False
                End If
            End If
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ParametriXml.ConnectionString, AutoCreateOption.DatabaseAndSchema)
            ControlloVersioneDB()
        Catch ex As Exception
            BaseLib.Msg.ErrorContinue("Impossibile connettersi con la base dei dati" & vbCrLf & ex.Message)
            Return False
        End Try
        Return True
    End Function

End Module
