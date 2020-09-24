Imports System.Net

Public Module WebUtilities

    Public Function DownloadFile(PosizioneFileSorgente As String, FileDestinazione As String) As Boolean
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try 'Checks if the file exist

            theRequest = CType(WebRequest.Create(PosizioneFileSorgente), HttpWebRequest)
            theResponse = CType(theRequest.GetResponse, HttpWebResponse)
        Catch ex As Exception
            Return False
        End Try
        Dim length As Long = theResponse.ContentLength 'Size of the response (in bytes)
        Dim writeStream As New IO.FileStream(FileDestinazione, IO.FileMode.Create)
        Dim nRead As Integer
        Do
            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
            nRead += bytesread
            If bytesread = 0 Then Exit Do
            writeStream.Write(readBytes, 0, bytesread)
        Loop
        theResponse.GetResponseStream.Close()
        writeStream.Close()
        Return True
    End Function

    Public Sub UploadFile()

    End Sub
End Module
