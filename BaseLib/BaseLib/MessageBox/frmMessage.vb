Imports BaseLib.Win32
Imports BaseLib.Win32.ApiCalls

Namespace Messaging
    Public Class MessageForm

        '-- Instance Fields
        Private _Browser As WebBrowser
        Private _MessageItem As MessageItem
        Private _Sound As New PlaySound

        Private Shared _CancelText As String = "Annulla" 'Localization.RetrieveTextValue("Base_CancelText", "&Cancel")
        Private Shared _IsButtonTextSet As Boolean = False
        Private Shared _MsgForm As MessageForm
        Private Shared _NoText As String = "No" 'Localization.RetrieveTextValue("Base_NoText", "&No")
        Private Shared _RetryText As String = "Riprova" 'Localization.RetrieveTextValue("Base_RetryText", "&Retry")
        Private Shared _ReturnValue As MessageFunctionType
        Private Shared _YesText As String = "Si" 'Localization.RetrieveTextValue("Base_YesText", "&Yes")
        Private Shared _EventIdText As String = "Evento numero" 'Localization.RetrieveTextValue("Base_EventIDText", "Event ID")

        '-- Constants
        Private Const Button1Left As Integer = 82
        Private Const Button2Left As Integer = 173

#Region " Constructors "

        ''' <summary>
        ''' Initializes a new instance of the MessageForm class.
        ''' </summary>
        ''' <param name="NewMessageItem"></param>
        ''' <remarks></remarks>
        Private Sub New(ByVal NewMessageItem As MessageItem)
            MyClass.New()

            If Threading.Thread.CurrentThread.IsThreadPoolThread Then
                'DevExpress.UserSkins.OfficeSkins.Register()
                DevExpress.UserSkins.BonusSkins.Register()
                DevExpress.LookAndFeel.UserLookAndFeel.Default.Assign(Application.Skin)
            End If



            'This call is required by the Windows Form Designer.
            Me.LookAndFeel.SkinName = Application.Skin.SkinName
            '-- Save off the passed message item
            _MessageItem = NewMessageItem

            '-- Set the form dimensions
            SetFormDimensions()

            '-- Set the text fields
            SetText()

            '-- Play a sound
            If _MessageItem.MessageSound <> MessagingSounds.None Then
                Win32.PlaySound.PlayWavResource(_MessageItem.MessageSound)
            End If

            ' Position the message box in the center of the screen
            SetFormPosition()

            ' Start the timer if it needs to be started
            SetTimer()
            tmShowObjects.Enabled = True
        End Sub

        ''' <summary>
        ''' Initializes a new instance of the MessageForm class.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub New()
            'This call is required by the Windows Form Designer.
            InitializeComponent()

            '-- Try to create the web browser window
            Try
                '-- Create the new object
                Me._Browser = New WebBrowser()

                '-- Initialize the object
                Me._Browser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or _
                    AnchorStyles.Left Or AnchorStyles.Right
                Me._Browser.Location = New Point(3, 0)
                Me._Browser.MinimumSize = New Size(20, 20)
                Me._Browser.Name = "_Browser"
                Me._Browser.Size = New Size(337, 100)
                Me._Browser.TabIndex = 1
                Me._Browser.Visible = False
                Me._Browser.WebBrowserShortcutsEnabled = False
                Me.pnlBody.Controls.Add(Me._Browser)
            Catch ex As Exception
                '-- Set the object to nothing
                Me._Browser = Nothing
            End Try
        End Sub
#End Region

#Region " Protected Methods "

#End Region

#Region " Events & Delegates "

        ''' <summary>
        ''' Describes a method that will handle the ButtonClick event.
        ''' </summary>
        ''' <param name="FunctionItem">The type of button that was clicked.</param>
        ''' <remarks></remarks>
        Public Delegate Sub ButtonClickEventHandler(ByVal FunctionItem As MessageFunctionType)

        ''' <summary>
        ''' Occurs when a button is clicked on the message form.
        ''' </summary>
        ''' <remarks></remarks>
        Public Event ButtonClick As ButtonClickEventHandler

#End Region

        Public Shared Function ShowMessage(ByVal MsgItem As MessageItem) As MessageFunctionType
            _MsgForm = New MessageForm(MsgItem)
            AddHandlers()

            _MsgForm.ShowDialog()
            _MsgForm.Close()
            _MsgForm.Dispose()

            Return _ReturnValue
        End Function

        ''' <summary>
        ''' Adds handlers to a message form.
        ''' </summary>
        ''' <remarks></remarks>
        Private Shared Sub AddHandlers()
            AddHandler _MsgForm.ButtonClick, AddressOf HandleButtonClick
        End Sub

        ''' <summary>
        ''' Removes the handlers from a message form.
        ''' </summary>
        ''' <remarks></remarks>
        Private Shared Sub RemoveHandlers()
            RemoveHandler _MsgForm.ButtonClick, AddressOf HandleButtonClick
        End Sub

        ''' <summary>
        ''' Handles the ButtonClick event for all message forms.
        ''' </summary>
        ''' <param name="FunctionItem">Determines what button was clicked.</param>
        ''' <remarks></remarks>
        Private Shared Sub HandleButtonClick(ByVal FunctionItem As MessageFunctionType)
            ' Save off the return value
            _ReturnValue = FunctionItem

            ' Remove the form handlers
            RemoveHandlers()

            ' Close the message form
            _MsgForm.DialogResult = DialogResult.OK

        End Sub

        ''' <summary>
        ''' Sets the button widths and positions on the message form.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetButtonPositions()
            '-- Establish Locals
            Dim lnMaxButtonWidth As Integer = 0
            Dim loGraphics As Graphics = Me.CreateGraphics()
            Dim loItem As DevExpress.XtraEditors.BaseButton
            Dim loSize As SizeF = Nothing
            Dim loButtons As New System.Collections.Generic.List(Of DevExpress.XtraEditors.BaseButton)
            Dim lnLeft As Integer
            Dim lnSpacing As Integer = 15

            '-- Determine the number of visible buttons
            If cmdButton1.Visible Then
                loButtons.Add(cmdButton1)
            End If

            If cmdButton2.Visible Then
                loButtons.Add(cmdButton2)
            End If

            If cmdButton3.Visible Then
                loButtons.Add(cmdButton3)
            End If

            '-- Find the largest string width
            For Each loItem In loButtons
                '-- Get the size of the text based on the font of the buttons
                loSize = loGraphics.MeasureString(loItem.Text, loItem.Font)

                '-- See if the width is larger than the last item
                If loSize.Width > lnMaxButtonWidth Then
                    lnMaxButtonWidth = Convert.ToInt32(loSize.Width)
                End If
            Next

            '-- Give a small buffer to the width of the button
            lnMaxButtonWidth += 16

            '-- Don't let the button be too small (i.e. an OK button)
            If lnMaxButtonWidth < 65 Then
                lnMaxButtonWidth = 65
            End If

            '-- Set the button width
            For Each loItem In loButtons
                loItem.Width = lnMaxButtonWidth
            Next

            '-- Subtract the width of each button from the width of the working area
            lnLeft = Me.ClientRectangle.Width - (lnMaxButtonWidth * loButtons.Count)
            lnLeft -= (loButtons.Count - 1) * lnSpacing
            lnLeft = Convert.ToInt32((lnLeft / 2))

            '-- Sets the button positions
            For Each loItem In loButtons
                '-- Set the left position
                loItem.Left = lnLeft

                '-- Increment the next left position
                lnLeft += lnMaxButtonWidth + lnSpacing
            Next

        End Sub
        ''' <summary>
        ''' Sets the form dimensions based on the specified width and height from the message item information.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetFormDimensions()
            '-- Set the Width
            Select Case Me._MessageItem.MessageWidth
                Case MessageWidthSize.Small
                    Width = 350
                Case MessageWidthSize.Medium
                    Width = 500
                Case MessageWidthSize.Large
                    Width = 650
            End Select

            '-- Set the form height
            Select Case _MessageItem.MessageHeight
                Case MessageHeightSize.Small
                    Height = 200
                Case MessageHeightSize.Medium
                    Height = 350
                Case MessageHeightSize.Large
                    Height = 500
            End Select
        End Sub

        ''' <summary>
        ''' Sets the position on the screen to allow the message form to follow the appropriate screen in a
        ''' multiple monitor environment.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetFormPosition()
            '-- Establish locals
            Dim loTopLeft As Point
            Dim loMousePoint As Point
            Dim loCurrentScreen As Screen

            '-- Get the current mouse pointer
            User32.GetCursorPos(loMousePoint)

            '-- Get the screen that the mouse is on
            loCurrentScreen = Screen.FromPoint(loMousePoint)

            '-- Calculate the upper left point of the screen
            With loCurrentScreen.Bounds
                loTopLeft = New Point(Convert.ToInt32((.Width - Me.Width) / 2), Convert.ToInt32((.Height - Me.Height) / 2))
                loTopLeft.X += .Left
                loTopLeft.Y += .Top
            End With

            '-- Set the location of the form
            Me.Location = loTopLeft
        End Sub
        ''' <summary>
        ''' Sets the functionality for all buttons on the message form.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetButtonFunctionality()
            '-- Determine the function of the buttons
            Select Case _MessageItem.MessageFunctionality
                Case MessageFunction.NoYes
                    cmdButton1.Text = MessageForm.NoText
                    cmdButton1.Left = Button1Left
                    cmdButton1.Tag = MessageFunctionType.No

                    cmdButton2.Text = MessageForm.YesText
                    cmdButton2.Left = Button2Left
                    cmdButton2.Tag = MessageFunctionType.Yes

                    cmdButton1.Visible = True
                    cmdButton2.Visible = True

                Case MessageFunction.NoYesCancel
                    cmdButton1.Text = MessageForm.NoText
                    cmdButton1.Tag = MessageFunctionType.No

                    cmdButton2.Text = MessageForm.YesText
                    cmdButton2.Tag = MessageFunctionType.Yes

                    cmdButton3.Text = MessageForm.CancelText
                    cmdButton3.Tag = MessageFunctionType.Cancel

                    cmdButton1.Visible = True
                    cmdButton2.Visible = True
                    cmdButton3.Visible = True

                Case MessageFunction.OK
                    cmdButton1.Text = "&OK"
                    cmdButton1.Location = cmdButton2.Location
                    cmdButton1.Tag = MessageFunctionType.OK

                    cmdButton1.Visible = True

                Case MessageFunction.OKCancel
                    cmdButton1.Text = "&OK"
                    cmdButton1.Left = Button1Left
                    cmdButton1.Tag = MessageFunctionType.OK

                    cmdButton2.Text = MessageForm.CancelText
                    cmdButton2.Left = Button2Left
                    cmdButton2.Tag = MessageFunctionType.Cancel

                    cmdButton1.Visible = True
                    cmdButton2.Visible = True

                Case MessageFunction.RetryCancel
                    cmdButton1.Text = MessageForm.RetryText
                    cmdButton1.Left = Button1Left
                    cmdButton1.Tag = MessageFunctionType.Retry

                    cmdButton2.Text = MessageForm.CancelText
                    cmdButton2.Left = Button2Left
                    cmdButton2.Tag = MessageFunctionType.Cancel

                    cmdButton1.Visible = True
                    cmdButton2.Visible = True

                Case MessageFunction.YesNo
                    cmdButton1.Text = MessageForm.YesText
                    cmdButton1.Left = Button1Left
                    cmdButton1.Tag = MessageFunctionType.Yes

                    cmdButton2.Text = MessageForm.NoText
                    cmdButton2.Left = Button2Left
                    cmdButton2.Tag = MessageFunctionType.No

                    cmdButton1.Visible = True
                    cmdButton2.Visible = True

                Case MessageFunction.YesNoCancel
                    cmdButton1.Text = MessageForm.YesText
                    cmdButton1.Tag = MessageFunctionType.Yes

                    cmdButton2.Text = MessageForm.NoText
                    cmdButton2.Tag = MessageFunctionType.No

                    cmdButton3.Text = MessageForm.CancelText
                    cmdButton3.Tag = MessageFunctionType.Cancel

                    cmdButton1.Visible = True
                    cmdButton2.Visible = True
                    cmdButton3.Visible = True

                Case MessageFunction.Custom
                    '-- Establish Locals
                    Dim laButtons() As String = _MessageItem.ButtonCaptions.Split(";"c)
                    Dim lnCnt As Integer
                    Dim loButton As DevExpress.XtraEditors.BaseButton
                    Dim loType As MessageFunctionType

                    ' Set the Buttons
                    For lnCnt = 0 To laButtons.Length - 1
                        Select Case lnCnt
                            Case 0
                                loButton = cmdButton1
                                loType = MessageFunctionType.Button1

                            Case 1
                                loButton = cmdButton2
                                loType = MessageFunctionType.Button2

                            Case 2
                                loButton = cmdButton3
                                loType = MessageFunctionType.Button3

                            Case Else
                                Exit For
                        End Select

                        ' Set the text
                        loButton.Text = laButtons(lnCnt).Trim()

                        ' Set the tag
                        loButton.Tag = loType

                        ' Show the button
                        loButton.Visible = True
                    Next
            End Select

            '-- Set the accept button
            Me.AcceptButton = Me.cmdButton1
        End Sub
#Region " Event Handlers "

        ''' <summary>
        ''' Make sure the dialog come to front in case there are other TopMost forms in the way
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MessageForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Me.BringToFront()
            Me.Activate()
        End Sub

        ''' <summary>
        ''' Handles the cmdButton1.Click event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub cmdButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdButton1.Click
            RaiseEvent ButtonClick(CType(cmdButton1.Tag, MessageFunctionType))
        End Sub

        ''' <summary>
        ''' Handles the cmdButton2.Click event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub cmdButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdButton2.Click
            RaiseEvent ButtonClick(CType(cmdButton2.Tag, MessageFunctionType))
        End Sub

        ''' <summary>
        ''' Handles the cmdButton3.Click event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub cmdButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdButton3.Click
            RaiseEvent ButtonClick(CType(cmdButton3.Tag, MessageFunctionType))
        End Sub

        ''' <summary>
        ''' Handles the tmShowObjects.Tick event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub tmShowObjects_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmShowObjects.Tick
            tmShowObjects.Enabled = False

            '-- Set the buttons
            SetButtonFunctionality()

            '-- Set the button positions
            SetButtonPositions()
        End Sub

        ''' <summary>
        ''' Handles the tmTimeout.Tick event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub tmTimeOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTimeOut.Tick
            tmTimeOut.Enabled = False

            RaiseEvent ButtonClick(MessageFunctionType.Timeout)
        End Sub

        ''' <summary>
        ''' Handles the txtMessage.GotFocus event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub txtMessage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMessage.GotFocus
            cmdButton1.Focus()
        End Sub

        ''' <summary>
        ''' Handles the txtMessage.LinkClicked event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub txtMessage_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles txtMessage.LinkClicked
            System.Diagnostics.Process.Start(e.LinkText)
        End Sub

#End Region

        ''' <summary>
        ''' Sets the timeout timer specified by the message item information.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetTimer()
            If _MessageItem.TimeOut > 0 Then
                tmTimeOut.Interval = (_MessageItem.TimeOut * 1000)
                tmTimeOut.Enabled = True
            End If
        End Sub


#Region " Public Properties "

        ''' <summary>
        ''' The text that will be used on a Cancel button
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property CancelText() As String
            Get
                Return _CancelText
            End Get
            Set(ByVal value As String)
                _CancelText = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Set the text describing the event id label
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property EventIdText() As String
            Get
                Return _EventIdText
            End Get
            Set(ByVal value As String)
                _EventIdText = value
            End Set
        End Property

        ''' <summary>
        ''' The text that will be used on a Retry button
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property RetryText() As String
            Get
                Return _RetryText
            End Get
            Set(ByVal value As String)
                _RetryText = value
            End Set
        End Property

        ''' <summary>
        ''' The text that will be used on a No button
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property NoText() As String
            Get
                Return _NoText
            End Get
            Set(ByVal value As String)
                _NoText = value
            End Set
        End Property

        ''' <summary>
        ''' The text that will be used on a Yes button
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property YesText() As String
            Get
                Return _YesText
            End Get
            Set(ByVal value As String)
                _YesText = value
            End Set
        End Property

#End Region


        ''' <summary>
        ''' Sets all text on the message form including title, event ID, and message.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetText()
            '-- Set the title text
            Me.Text = _MessageItem.Title.Trim()
            Me.GroupControl1.Text = _MessageItem.Title.Trim()

            Dim loBitmap As Bitmap = MessagingBasics.LoadMessageIcon(_MessageItem.MessageIcon)
            Me.GroupControl1.CaptionImage = loBitmap
            Me.GroupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.BeforeText
            ''-- Set the event ID text color
            'If MicroFour.StrataFrame.UI.Windows.Forms.ApplicationTheme.Theme <> UI.Windows.Forms.ApplicationThemeName.NoTheme Then
            '    Me.lblEventID.ForeColor = MicroFour.StrataFrame.UI.Windows.Forms.ApplicationTheme.ThemeProperties.ThemeFormEventIDTextColor
            'End If

            '-- Replace the values
            _MessageItem.ReplaceValues()

            '-- Set the message text
            Try
                If (_MessageItem.IsHTML) Then
                    If (Me._Browser Is Nothing) Then
                        Throw New Exception("The MessageForm cannot be shown with an HTML message from off the main thread; the WebBrowser control cannot be created outside of a thread marked with [STATThread()].")
                    End If
                    txtMessage.Visible = False
                    _Browser.Visible = True
                    _Browser.DocumentText = _MessageItem.Text
                Else
                    If _MessageItem.Text.StartsWith("{\rtf", StringComparison.OrdinalIgnoreCase) Then
                        '-- Set the rtf value
                        Me.txtMessage.Rtf = Me._MessageItem.Text
                    Else
                        txtMessage.Text = _MessageItem.Text
                    End If
                End If
            Catch ex As Exception
                Throw New FormatException("An error occurred while attempting to format the text for the message box.", ex)
            End Try

            ''-- Set the Event ID text
            'If (_MessageItem.EventID.Length > 0) AndAlso (Not _MessageItem.EventID.Equals("0")) Then
            '    lblEventID.Text = _EventIdText & ": " & _MessageItem.EventID.Trim()
            '    lblEventID.Visible = True
            'Else
            '    '-- Hide the event ID and reposition the title message
            '    lblEventID.Visible = False
            '    TitleYOffset = 0
            'End If
        End Sub
    End Class


End Namespace