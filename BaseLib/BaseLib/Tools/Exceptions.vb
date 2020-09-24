Imports System.Collections.Generic
Imports System.Reflection
Imports System.Text

Namespace Tools

    ''' <summary>
    ''' Contains methods for generating detailed messages from exceptions.
    ''' </summary>
    ''' <remarks></remarks>
    Public NotInheritable Class Exceptions

#Region " Constructors "

        ''' <summary>
        ''' Initializes a new instance of the Exceptions class.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub New()
        End Sub

#End Region

#Region " Private Methods "

        Private Shared Sub AppendMessageForException(ByVal Ex As Exception, ByVal Builder As StringBuilder, ByVal Indent As String)
            '-- Establish locals
            Dim loRtle As ReflectionTypeLoadException

            '-- Add the message to the output
            Builder.Append(Indent)
            Builder.AppendLine(Ex.GetType().Name)
            Builder.Append(Indent)
            Builder.Append("  ")
            Builder.AppendLine(Ex.Message)

            '-- If the exception is a reflection type load exception, then add it's errors
            '   to the output
            loRtle = TryCast(Ex, ReflectionTypeLoadException)
            If loRtle IsNot Nothing Then
                Builder.Append(Indent)
                Builder.Append("  ")
                Builder.AppendLine("LoadExceptions:")
                For Each loLoadError As Exception In loRtle.LoaderExceptions
                    AppendMessageForException(loLoadError, Builder, Indent & "  ")
                Next
            End If
        End Sub

        ''' <summary>
        ''' Creates a combined stack trace from the given partial stack traces.
        ''' </summary>
        ''' <param name="StackTraces"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Shared Function BuildStackTrace(ByVal StackTraces As String()) As String
            '-- Establish locals
            Dim lcReturn As String = ""
            Dim lnCnt As Integer
            Dim laParts As String()
            Dim lnPart As Integer

            '-- Go through the given stack traces and add the parts to the stack trace
            For lnCnt = StackTraces.Length - 1 To 0 Step -1
                '-- Make sure the stack trace is not nothing
                If StackTraces(lnCnt) Is Nothing Then
                    Continue For
                End If

                '-- Split the stack trace
                laParts = StackTraces(lnCnt).Split(New Char() {ControlChars.Cr, ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)

                '-- Go through the parts
                For lnPart = 0 To laParts.Length - 1
                    '-- Add the line to the end if it is not unique
                    If Not lcReturn.Contains(laParts(lnPart)) Then
                        lcReturn &= laParts(lnPart) & ControlChars.CrLf
                    End If
                Next
            Next

            '-- Return the stack trace
            Return lcReturn
        End Function

#End Region

#Region " Public Methods "

        ''' <summary>
        ''' Creates a detailed exception message listing the information contained within
        ''' the exception and all inner exceptions.
        ''' </summary>
        ''' <param name="Ex"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function CreateExceptionDetails(ByVal Ex As Exception) As String
            '-- Establish locals
            Dim lcReturn As New StringBuilder(2048)
            Dim loException As Exception
            Dim lcStackTraces As New List(Of String)

            If Ex Is Nothing Then
                Return "Exception object is null."
            End If

            '-- Set the initial exception
            loException = Ex

            '-- Loop through the inner exceptions
            While loException IsNot Nothing
                '-- Append the details for this exception
                AppendMessageForException(loException, lcReturn, String.Empty)

                '-- Append the value to the stack trace
                lcStackTraces.Add(loException.StackTrace)

                '-- Get the inner exception
                loException = loException.InnerException
            End While

            '-- Add the stack trace to the error message
            lcReturn.AppendLine()
            lcReturn.Append("Source     : ")
            lcReturn.AppendLine(Ex.Source)
            lcReturn.AppendLine()
            lcReturn.AppendLine("Stack Trace: ")
            lcReturn.Append(BuildStackTrace(lcStackTraces.ToArray()))

            '-- Return the created message
            Return lcReturn.ToString()
        End Function

#End Region

    End Class

End Namespace