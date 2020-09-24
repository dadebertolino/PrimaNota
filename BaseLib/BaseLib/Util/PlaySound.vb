Imports System
Imports System.IO
Imports BaseLib.Messaging
Namespace Win32

    ''' <summary>
    ''' Plays a sound and synchronizes the playing with other PlaySound objects.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class PlaySound

#Region " Constructors "

        ''' <summary>
        ''' Initializes a new instance of the PlaySound class.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the PlaySound class.
        ''' </summary>
        ''' <param name="Sound">The filename of the sound to play.</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal Sound As String)
            MyClass.New(Sound, True)
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the PlaySound class.
        ''' </summary>
        ''' <param name="Sound">The filename of the sound to play.</param>
        ''' <param name="IsEmbeddedResource">True if the sound is an embedded resource.</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal Sound As String, ByVal IsEmbeddedResource As Boolean)
            If IsEmbeddedResource Then
                PlayWavResource(CType(System.Enum.Parse(GetType(MessagingSounds), Sound), MessagingSounds))
            Else
                PlayWavFile(Sound)
            End If
        End Sub

#End Region

#Region " Private Fields "

        Private Shared _PlayList As New System.Collections.Generic.List(Of MessagingSounds)

#End Region

#Region " Private Methods "

        ''' <summary>
        ''' Plays the given sound on a thread.
        ''' </summary>
        ''' <param name="AlertSound"></param>
        ''' <remarks></remarks>
        Private Shared Sub PlayWavOnThread(ByVal AlertSound As Object)
            With My.Computer.Audio
                Select Case CType(AlertSound, MessagingSounds)
                    Case MessagingSounds.DefaultSound
                        '.Play(My.Resources.wav_newalert, AudioPlayMode.Background)
                        .Play(My.Resources.wav_newalert, AudioPlayMode.WaitToComplete)

                    Case MessagingSounds.ErrorSound
                        '.Play(My.Resources.wav_error, AudioPlayMode.Background)
                        .Play(My.Resources.wav_error, AudioPlayMode.WaitToComplete)


                    Case MessagingSounds.Fatal
                        '.Play(My.Resources.wav_fatal, AudioPlayMode.Background)
                        .Play(My.Resources.wav_fatal, AudioPlayMode.WaitToComplete)

                    Case MessagingSounds.Notify
                        '.Play(My.Resources.wav_notify, AudioPlayMode.Background)
                        .Play(My.Resources.wav_notify, AudioPlayMode.WaitToComplete)

                    Case MessagingSounds.Question
                        '.Play(My.Resources.wav_question, AudioPlayMode.Background)
                        .Play(My.Resources.wav_question, AudioPlayMode.WaitToComplete)

                    Case MessagingSounds.Tip
                        '.Play(My.Resources.wav_tip, AudioPlayMode.Background)
                        .Play(My.Resources.wav_tip, AudioPlayMode.WaitToComplete)

                    Case MessagingSounds.Warning
                        '.Play(My.Resources.wav_warning, AudioPlayMode.Background)
                        .Play(My.Resources.wav_warning, AudioPlayMode.WaitToComplete)
                End Select
            End With

            '-- Remove the alert sound from the play list
            SyncLock _PlayList
                _PlayList.Remove(CType(AlertSound, MessagingSounds))
            End SyncLock
        End Sub

#End Region

#Region " Public Methods "

        ''' <summary>
        ''' Pulls the given sound.
        ''' </summary>
        ''' <param name="Sound"></param>
        ''' <remarks></remarks>
        Public Shared Sub PlayWavResource(ByVal Sound As MessagingSounds)
            '-- Establish Locals
            Dim loThread As System.Threading.Thread

            If Not _PlayList.Contains(Sound) Then
                '-- Lock the list
                SyncLock _PlayList
                    '-- Add the play type to the list
                    _PlayList.Add(Sound)

                    '-- Create a thread
                    loThread = New System.Threading.Thread(AddressOf PlayWavOnThread)
                    loThread.Start(Sound)
                End SyncLock
            End If
        End Sub

        ''' <summary>
        ''' Plays the given wave file.
        ''' </summary>
        ''' <param name="WavPath">Full path to the *.wave file to play.</param>
        ''' <remarks></remarks>
        Public Shared Sub PlayWavFile(ByVal WavPath As String)
            '-- Establish locals
            Dim loSound() As Byte

            '-- Read the file
            Try
                loSound = File.ReadAllBytes(WavPath)
            Catch ex As Exception
                Exit Sub
            End Try

            '-- Play the sound
            My.Computer.Audio.Play(loSound, AudioPlayMode.Background)

        End Sub

#End Region

    End Class

End Namespace