Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Per MyApplication sono disponibili gli eventi seguenti:
    ' Startup: generato all'avvio dell'applicazione, prima della creazione del form di avvio.
    ' Shutdown: generato dopo la chiusura di tutti i form dell'applicazione. Questo evento non viene generato se l'applicazione termina in modo anomalo.
    ' UnhandledException: generato se nell'applicazione si verifica un'eccezione non gestita.
    ' StartupNextInstance: generato all'avvio di un'applicazione a istanza singola se l'applicazione è già attiva. 
    ' NetworkAvailabilityChanged: generato quando la connessione di rete viene connessa o disconnessa.
    Partial Friend Class MyApplication
        Const AppName As String = "PrimaNota"

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If BaseLib.Application.StartUp(AppName) = False Then
                e.Cancel = True
                Exit Sub
            End If
            If PrimaNota.DAL.ParametriXml.LoadParametri(AppName) = False Then
                e.Cancel = True
                Exit Sub
            End If
            If PrimaNota.DAL.DataLayers.Setup = False Then
                e.Cancel = True
                Exit Sub
            End If
            DevExpress.XtraEditors.Preview.PrintDialogRunner.Instance = New DevExpress.XtraEditors.Preview.SystemPrintDialogRunner()

        End Sub

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            BaseLib.Application.Close()
        End Sub
    End Class
End Namespace
