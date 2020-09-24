Imports System.Runtime.InteropServices

Public Class TWU
    <DllImport("twu2010ui", EntryPoint:="TWUOpenUpdateW")> _
    Private Shared Function OpenUpdate(hwndMain As IntPtr) As IntPtr
    End Function

    <DllImport("twu2010ui", EntryPoint:="TWUCloseUpdateW")> _
    Private Shared Function CloseUpdate(hUpdate As IntPtr) As UInt32
    End Function

    <DllImport("twu2010ui", EntryPoint:="TWUCleanupUpdateW")> _
    Public Shared Sub CleanupUpdate()
    End Sub

    <DllImport("twu2010ui", EntryPoint:="TWUCheckUpdateW", CharSet:=CharSet.Unicode)> _
    Private Shared Function CheckUpdate(hUpdate As IntPtr, pszUpdateURL As [String], pszSection As [String], dwFlags As UInt32, ByRef pbUpdateAvailable As [Boolean]) As UInt32
    End Function

    <DllImport("twu2010ui", EntryPoint:="TWUGetUpdateNameW", CharSet:=CharSet.Unicode)> _
    Private Shared Function GetUpdateName(hUpdate As IntPtr) As [String]
    End Function

    <DllImport("twu2010ui", EntryPoint:="TWUGetUpdateVersionW", CharSet:=CharSet.Unicode)> _
    Private Shared Function GetUpdateVersion(hUpdate As IntPtr) As [String]
    End Function

    <DllImport("twu2010ui", EntryPoint:="TWUDownloadUpdateW")> _
    Private Shared Function DownloadUpdate(hUpdate As IntPtr, dwFlags As UInt32) As UInt32
    End Function

    <DllImport("twu2010ui", EntryPoint:="TWUInstallUpdateW")> _
    Private Shared Function InstallUpdate(hUpdate As IntPtr, dwFlags As UInt32) As UInt32
    End Function

    <DllImport("twu2010ui", EntryPoint:="TWURegisterRestartW", CharSet:=CharSet.Unicode)> _
    Private Shared Function RegisterRestart(hUpdate As IntPtr, pszAppPath As [String], pszOptions As [String], dwFlags As UInt32) As UInt32
    End Function

    Public Shared Sub CheckForUpdate(hwndMain As IntPtr, UpdateAddressPosition As String)
        Dim bUpdateAvailable As Boolean
        Dim MsgErrore As String
        Dim hUpdate As IntPtr
        Try
            hUpdate = BaseLib.TWU.OpenUpdate(hwndMain)
            BaseLib.TWU.CheckUpdate(hUpdate, UpdateAddressPosition, "", 0, bUpdateAvailable)
        Catch ex As Exception
            MsgErrore = "L'applicazione non può essere aggiornata"
            MsgErrore = MsgErrore & vbCrLf & "Descrizione dell'errore" & " " & ex.Message
            BaseLib.Msg.ErrorContinue(MsgErrore)
            GoTo fine
        End Try
        If (bUpdateAvailable) Then
            Dim doUpdate As Boolean = True
            Dim msgDomanda As String = "E' disponibile un aggiornamento"
            msgDomanda = msgDomanda & vbCrLf & "Vuoi scaricare l'aggiornamento e procedere con l'installazione?"
            Dim dr As DialogResult = BaseLib.Msg.QuestionYesNo(msgDomanda)
            If (Not System.Windows.Forms.DialogResult.Yes = dr) Then
                doUpdate = False
            End If
            If (doUpdate) Then
                Try
                    BaseLib.TWU.DownloadUpdate(hUpdate, 0)
                    BaseLib.TWU.InstallUpdate(hUpdate, 0)
                    BaseLib.Msg.Info("Aggiornamento dell'applicazione Completato")
                    BaseLib.TWU.RegisterRestart(hUpdate, "", "", 1)
                Catch ex As Exception
                    MsgErrore = "Impossibile installare l'aggiornamento"
                    MsgErrore = MsgErrore & vbCrLf & "Controllare provare nuovamente ad aggiornare l'applicazione"
                    MsgErrore = MsgErrore & vbCrLf & "Descrizione dell'errore" & " " & ex.Message
                    BaseLib.Msg.ErrorContinue(MsgErrore)
                    GoTo fine
                End Try
            End If
            'Else
            '    BaseLib.Msg.Info("Nessun aggiornamento disponibile")
        End If
fine:
        Try
            BaseLib.TWU.CloseUpdate(hUpdate)
        Catch ex As Exception

        End Try

    End Sub
End Class
