Imports System.Drawing

Namespace Messaging

    ''' <summary>
    ''' Provides methods used for common tasks within the StrataFrame messaging system.
    ''' </summary>
    ''' <remarks></remarks>
    Public NotInheritable Class MessagingBasics

        ''' <summary>
        ''' Gets the resource name of a *.wav file associated with the specified MessagingSound.
        ''' </summary>
        ''' <param name="Sound">The MessagingSound for which to retrieve the resource name.</param>
        ''' <returns>The resource name of the sound file for the specified MessagingSound.</returns>
        ''' <remarks></remarks>
        Public Shared Function GetWAVResourceName(ByVal Sound As MessagingSounds) As String
            Dim lcReturn As String = ""

            Select Case Sound
                Case MessagingSounds.DefaultSound
                    lcReturn = "newalert.wav"

                Case MessagingSounds.ErrorSound
                    lcReturn = "error.wav"

                Case MessagingSounds.Fatal
                    lcReturn = "fatal.wav"

                Case MessagingSounds.Notify
                    lcReturn = "notify.wav"

                Case MessagingSounds.Question
                    lcReturn = "question.wav"

                Case MessagingSounds.Tip
                    lcReturn = "tip.wav"

                Case MessagingSounds.Warning
                    lcReturn = "warning.wav"

            End Select

            Return lcReturn
        End Function

        ''' <summary>
        ''' Generates a bitmap from resources for the specified MessagingIcon.
        ''' </summary>
        ''' <param name="MessageImage">The MessagingIcon for which to retrieve the bitmap.</param>
        ''' <returns>A Bitmap object for the specified MessagingIcon.</returns>
        ''' <remarks></remarks>
        Public Shared Function LoadMessageIcon(ByVal MessageImage As MessagingIcon) As Bitmap
            Dim loIcon As Bitmap = Nothing

            ' See if there is an image to draw
            Select Case MessageImage
                Case MessagingIcon.Information
                    loIcon = My.Resources.information_32

                Case MessagingIcon.Information_Balloon
                    loIcon = My.Resources.information_balloon_32

                Case MessagingIcon.Warning
                    loIcon = My.Resources.warning_32

                Case MessagingIcon.Question
                    loIcon = My.Resources.question_32

                Case MessagingIcon.Fatal
                    loIcon = My.Resources.fatal_32

                Case MessagingIcon.Bell
                    loIcon = My.Resources.bell_32

                Case MessagingIcon.Help
                    loIcon = My.Resources.help_32

                Case MessagingIcon.Mail
                    loIcon = My.Resources.email_32

                Case MessagingIcon.Touch
                    loIcon = My.Resources.touch_32

                Case MessagingIcon.LightBulb
                    loIcon = My.Resources.lightbulb_32

                Case MessagingIcon.FirstAid
                    loIcon = My.Resources.firstaid_32

                Case MessagingIcon.Gear
                    loIcon = My.Resources.gear_32

                Case MessagingIcon.GreenCheck
                    loIcon = My.Resources.greencheck_32

                Case MessagingIcon.Bookmark
                    loIcon = My.Resources.bookmark_32

                Case MessagingIcon.StopSign
                    loIcon = My.Resources.stop_32

                Case MessagingIcon.AlarmClock
                    loIcon = My.Resources.alarmclock_32

                Case MessagingIcon.Printer
                    loIcon = My.Resources.printer_32

                Case MessagingIcon.PrinterError
                    loIcon = My.Resources.printer_error_32

                Case MessagingIcon.PrinterInformation
                    loIcon = My.Resources.printer_info_32

                Case MessagingIcon.PrinterOK
                    loIcon = My.Resources.printer_ok_32

                Case MessagingIcon.PrinterWarning
                    loIcon = My.Resources.printer_warning_32

                Case MessagingIcon.Setup
                    loIcon = My.Resources.Setup_32

                Case MessagingIcon.StopWatch
                    loIcon = My.Resources.stopwatch_32

                Case MessagingIcon.Earth
                    loIcon = My.Resources.earth_32

                Case MessagingIcon.Document
                    loIcon = My.Resources.document_32

                Case MessagingIcon.OpenBox
                    loIcon = My.Resources.box_32

                Case MessagingIcon.ClosedBox
                    loIcon = My.Resources.box_closed_32

                Case MessagingIcon.Forbidden
                    loIcon = My.Resources.forbidden

                Case MessagingIcon.None
                    loIcon = New Bitmap(32, 32)

                Case Else
                    loIcon = My.Resources.information_balloon_32
            End Select

            Return loIcon
        End Function
    End Class
End Namespace