Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class frmUploadFile
    Private WithEvents myWebClient As New WebClient()
    Private Credentials As System.Net.NetworkCredential
    Private _LocazioneFile As String = "ftp://62.149.134.70/dbsistemi.it/app_data/"
    Private Const NomeFileUpload As String = "upload.xxx"
    Private _NomeFileArchivio As String = "Myshop.vdb4"
    Private _NomeFileRemoto As String
    Private Shared _frmUpload As New frmUploadFile

    Public Function SetupUpload(UserName As String, Password As String, PercorsoFTP As String, NomeFile As String, NomeFileRemoto As String) As Boolean
        Me.Credentials = New System.Net.NetworkCredential(UserName, Password)
        _LocazioneFile = PercorsoFTP
        If _LocazioneFile.EndsWith("/") = False Then
            _LocazioneFile = _LocazioneFile & "/"
        End If
        _NomeFileArchivio = NomeFile
        _NomeFileRemoto = NomeFileRemoto
    End Function

    Private Sub frmUpload_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lcInfoOperazione.Text = "Upload del file " & _NomeFileRemoto
        Me.ProgressBarControl1.EditValue = 0
        Dim myUri As New System.Uri(_LocazioneFile & NomeFileUpload)
        myWebClient.Credentials = Credentials
        myWebClient.UploadFileAsync(myUri, _NomeFileArchivio)
    End Sub

    Private Sub myWebClient_UploadProgressChanged(sender As Object, e As UploadProgressChangedEventArgs) Handles myWebClient.UploadProgressChanged
        Dim PercentualeProgresso As Integer = (e.BytesSent * 100) / e.TotalBytesToSend
        Me.ProgressBarControl1.EditValue = PercentualeProgresso
        Me.lcProgresso.Text = e.BytesSent.ToString & "/" & e.TotalBytesToSend.ToString
    End Sub

    Private Sub myWebClient_UploadFileCompleted(sender As Object, e As UploadFileCompletedEventArgs) Handles myWebClient.UploadFileCompleted
        If e.Cancelled = True Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End If
        Dim DeleteRequest As FtpWebRequest
        DeleteRequest = FtpWebRequest.Create(New Uri(_LocazioneFile & _NomeFileRemoto))
        DeleteRequest.Proxy = Nothing
        DeleteRequest.Credentials = Credentials
        DeleteRequest.Method = WebRequestMethods.Ftp.DeleteFile
        Try
            DeleteRequest.GetResponse()
        Catch ex As Exception

        End Try
        Dim RenameRequest As FtpWebRequest
        RenameRequest = FtpWebRequest.Create(New Uri(_LocazioneFile & NomeFileUpload))
        RenameRequest.Proxy = Nothing
        RenameRequest.Credentials = Credentials
        RenameRequest.Method = WebRequestMethods.Ftp.Rename
        RenameRequest.RenameTo = _NomeFileRemoto
        RenameRequest.GetResponse()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Public Shared Sub UploadFile(UserName As String, Password As String, PercorsoFTP As String, NomeFileSorgente As String, NomeFileRemoto As String)
        _frmUpload = New frmUploadFile
        _frmUpload.SetupUpload(UserName, Password, PercorsoFTP, NomeFileSorgente, NomeFileRemoto)
        _frmUpload.ShowDialog()
        _frmUpload.Close()
        _frmUpload.Dispose()
    End Sub
End Class