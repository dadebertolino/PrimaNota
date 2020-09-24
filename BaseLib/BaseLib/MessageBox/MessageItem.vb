Imports System.Text.RegularExpressions

Namespace Messaging

    ''' <summary>
    ''' Describes all aspects of a MessageForm.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class MessageItem

#Region " Private Fields "

        Private _ButtonCaptions As String = ""
        Private _EventID As String = ""
        Private _MessageFunctionality As MessageFunction = MessageFunction.OK
        Private _MessageHeight As MessageHeightSize = MessageHeightSize.Default
        Private _MessageIcon As MessagingIcon = MessagingIcon.Information
        Private _MessageSound As MessagingSounds = MessagingSounds.DefaultSound
        Private _MessageWidth As MessageWidthSize = MessageWidthSize.Default
        Private _OriginalText As String = ""
        Private _ReplacementValues As New System.Collections.Generic.List(Of Object)
        Private _Text As String = ""
        Private _Timeout As Integer = 0
        Private _Title As String = ""
        Private _IsHTML As Boolean = False

#End Region

#Region " Declare Properties "

        ''' <summary>
        ''' When True, indicates that the text is HTML code and will
        ''' be handled accordingly.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IsHTML() As Boolean
            Get
                Return _IsHTML
            End Get
            Set(ByVal value As Boolean)
                _IsHTML = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the custom button captions displayed on the MessageForm (semi-colon delimited:
        ''' i.e. "OK;Cancel;Help"
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property ButtonCaptions() As String
            Get
                Return Me._ButtonCaptions
            End Get
            Set(ByVal value As String)
                Me._ButtonCaptions = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the event id associated witht the message.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>The event id allows the developer to set a unique value that will be displayed on
        ''' the message that allows the end-user to tell a support technician a specific error message number.</remarks>
        Public Property EventID() As String
            Get
                Return Me._EventID
            End Get
            Set(ByVal value As String)
                Me._EventID = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value that determines the functionallity of the MessageForm (the buttons 
        ''' displayed).
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property MessageFunctionality() As MessageFunction
            Get
                Return Me._MessageFunctionality
            End Get
            Set(ByVal value As MessageFunction)
                Me._MessageFunctionality = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the height of the message form.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property MessageHeight() As MessageHeightSize
            Get
                Return Me._MessageHeight
            End Get
            Set(ByVal value As MessageHeightSize)
                Me._MessageHeight = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the MessagingIcon that will be displayed on the MessageForm.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property MessageIcon() As MessagingIcon
            Get
                Return Me._MessageIcon
            End Get
            Set(ByVal value As MessagingIcon)
                Me._MessageIcon = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the sound to play when the MessageForm is displayed.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property MessageSound() As MessagingSounds
            Get
                Return Me._MessageSound
            End Get
            Set(ByVal value As MessagingSounds)
                Me._MessageSound = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the width of the message form.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property MessageWidth() As MessageWidthSize
            Get
                Return Me._MessageWidth
            End Get
            Set(ByVal value As MessageWidthSize)
                Me._MessageWidth = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the values used within the replacement markers in the message.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property ReplacementValues() As System.Collections.Generic.List(Of Object)
            Get
                Return Me._ReplacementValues
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Object))
                Me._ReplacementValues = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the text to be displayed within the body of the message; can be either RTF formatted
        ''' text or plain text.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property Text() As String
            Get
                Return Me._Text
            End Get
            Set(ByVal value As String)
                _Text = value
                _OriginalText = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the time, in ms, that the MessageForm will be displayed without user intervention 
        ''' before closing; -1 specifies infinite.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property TimeOut() As Integer
            Get
                Return Me._Timeout
            End Get
            Set(ByVal value As Integer)
                Me._Timeout = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the title of the MessageForm.
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property Title() As String
            Get
                Return Me._Title
            End Get
            Set(ByVal value As String)
                Me._Title = value
            End Set
        End Property

#End Region

#Region " Public Methods "

        ''' <summary>
        ''' Replaces the embedded places holders with the actual replacement values
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ReplaceValues()
            '-- Establish locals
            Dim lnOffset As Integer = 0
            Dim lnPreLength, lnPostLength As Integer
            Dim lcReplacement As String

            Try
                If (IsHTML) Then
                    If ReplacementValues.Count > 0 Then
                        _Text = String.Format(_OriginalText, ReplacementValues.ToArray())
                    Else
                        _Text = _OriginalText
                    End If
                Else
                    If _OriginalText.StartsWith("{\rtf", StringComparison.OrdinalIgnoreCase) Then
                        Using rtf As New RichTextBox
                            '-- Set the rtf value
                            rtf.Rtf = _OriginalText

                            '-- Cycle through the rtf values and replace the replacement values
                            For Each loMatch As Match In Regex.Matches(rtf.Text, "{(\d*?)(?::(.*?))?}")
                                '-- Check the length of the string
                                lnPreLength = rtf.TextLength

                                '-- Replace the characters
                                rtf.Select(loMatch.Index + lnOffset, loMatch.Length)
                                If loMatch.Groups.Count = 2 Then
                                    lcReplacement = ReplacementValues(Integer.Parse(loMatch.Groups(1).Value)).ToString()
                                Else
                                    lcReplacement = String.Format("{0:" & loMatch.Groups(2).Value & "}", ReplacementValues(Integer.Parse(loMatch.Groups(1).Value)))
                                End If
                                If Not String.IsNullOrEmpty(lcReplacement) Then
                                    rtf.SelectedText = lcReplacement
                                Else
                                    rtf.SelectedText = " "
                                End If

                                '-- Check the length of the string after the replacement
                                lnPostLength = rtf.TextLength

                                '-- Calculate the offset
                                lnOffset += lnPostLength - lnPreLength
                            Next

                            '-- Save off the text
                            _Text = rtf.Rtf
                        End Using
                    Else
                        _Text = String.Format(_OriginalText, ReplacementValues.ToArray())
                    End If
                End If
            Catch ex As Exception
                Throw New FormatException("An error occurred while attempting to format the text for the message box.", ex)
            End Try
        End Sub

#End Region

    End Class

End Namespace