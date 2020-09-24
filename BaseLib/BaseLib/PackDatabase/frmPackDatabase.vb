'Imports System
'Imports System.IO
'Imports System.Net
'Imports System.Text
'Imports VistaDB
'Imports VistaDB.Engine
'Imports VistaDB.DDA

'Public Class frmPackDatabase
'    Private NomeFileSorgente As String
'    Private Shared _frmPack As frmPackDatabase
'    Private _errors As String
'    Private Function PerformPackDatabase(fileName As String) As Boolean
'        Dim successState As Boolean = False
'        Try
'            Using ddaObj As IVistaDBDDA = VistaDBEngine.Connections.OpenDDA()
'                ddaObj.PackDatabase(fileName, Nothing, Nothing, 4, 2057, False, False, New VistaDB.DDA.OperationCallbackDelegate(AddressOf OnPackInfo))
'                successState = True
'            End Using
'        Catch ex As Exception
'            _errors = String.Format("The sytem returned the error: {0}", ex.Message)
'        End Try
'        Return successState
'    End Function

'    Public Sub OnPackInfo(operationCallback As IVistaDBOperationCallbackStatus)
'        If operationCallback.Progress > 0 And operationCallback.Progress < 100 Then
'            Me.BackgroundWorker1.ReportProgress(operationCallback.Progress)
'        End If
'    End Sub

'    Private Sub frmUpload_Load(sender As Object, e As EventArgs) Handles Me.Load
'        Me.lcInfoOperazione.Text = "Ricostruzione Indici in corso"
'        Me.BackgroundWorker1.RunWorkerAsync()
'    End Sub

'    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
'        Me.ProgressBarControl1.EditValue = 0
'        Me.PerformPackDatabase(NomeFileSorgente)
'    End Sub

'    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
'        Me.ProgressBarControl1.EditValue = e.ProgressPercentage
'    End Sub

'    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
'        Me.Close()
'    End Sub

'    Public Shared Sub PackDatabase(NomeFileSorgente As String)
'        _frmPack = New frmPackDatabase
'        _frmPack.NomeFileSorgente = NomeFileSorgente
'        _frmPack.ShowDialog()
'        _frmPack.Close()
'        _frmPack.Dispose()
'    End Sub
'End Class