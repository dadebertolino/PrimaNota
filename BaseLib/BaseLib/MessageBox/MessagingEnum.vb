Namespace Messaging

    ''' <summary>
    ''' Determines the type of buttons that will be displayed on an InfoBox.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum InfoBoxButtonType As Integer
        ''' <summary>
        ''' A custom set of buttons will be shown.
        ''' </summary>
        ''' <remarks></remarks>
        Custom = 0

        ''' <summary>
        ''' Only the close button will be shown.
        ''' </summary>
        ''' <remarks></remarks>
        Close = 1

        ''' <summary>
        ''' An options menu button will be shown along with the close button.
        ''' </summary>
        ''' <remarks></remarks>
        OptionsMenu = 2
    End Enum

    ''' <summary>
    ''' Determines the variant of an InfoBox.
    ''' </summary>
    ''' <remarks>This is my remark</remarks>
    Public Enum InfoBoxFormType As Integer
        ''' <summary>
        ''' An AlertBox.
        ''' </summary>
        ''' <remarks></remarks>
        AlertBox = 0

        ''' <summary>
        ''' An ErrorBox.
        ''' </summary>
        ''' <remarks></remarks>
        ErrorBox = 1

        ''' <summary>
        ''' A NotifyBox.
        ''' </summary>
        ''' <remarks></remarks>
        NotifyBox = 2

        ''' <summary>
        ''' A TipBox.
        ''' </summary>
        ''' <remarks></remarks>
        TipBox = 3

        ''' <summary>
        ''' A WarningBox.
        ''' </summary>
        ''' <remarks></remarks>
        WarningBox = 4
    End Enum

    ''' <summary>
    ''' Determines the effect used to display and remove a message window from the screen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum InfoBoxSpecialEffect As Integer
        ''' <summary>
        ''' The default affect is used to show the window.
        ''' </summary>
        ''' <remarks></remarks>
        DefaultEffect = 1

        ''' <summary>
        ''' A scroll effect is used to show the window.
        ''' </summary>
        ''' <remarks></remarks>
        Scroll = 1

        ''' <summary>
        ''' A fade effect is used to show the window.
        ''' </summary>
        ''' <remarks></remarks>
        Fade = 2
    End Enum

    ''' <summary>
    ''' Determines what buttons are displayed on a message window.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessageFunction As Integer
        ''' <summary>
        ''' Only an OK button is displayed.
        ''' </summary>
        ''' <remarks></remarks>
        OK = 1

        ''' <summary>
        ''' Buttons for OK and cancel are displayed.
        ''' </summary>
        ''' <remarks></remarks>
        OKCancel = 2

        ''' <summary>
        ''' Buttons for Yes and No are displayed.
        ''' </summary>
        ''' <remarks></remarks>
        YesNo = 3

        ''' <summary>
        ''' Buttons for Yes, No, and Cancel are displayed.
        ''' </summary>
        ''' <remarks></remarks>
        YesNoCancel = 4

        ''' <summary>
        ''' Buttons for No and Yes are displayed.
        ''' </summary>
        ''' <remarks></remarks>
        NoYes = 5

        ''' <summary>
        ''' Buttons for No, Yes, and Cancel are displayed.
        ''' </summary>
        ''' <remarks></remarks>
        NoYesCancel = 6

        ''' <summary>
        ''' Buttons for Retry and Cancel are displayed.
        ''' </summary>
        ''' <remarks></remarks>
        RetryCancel = 7

        ''' <summary>
        ''' A custom group of up to 3 buttons are displayed.
        ''' </summary>
        ''' <remarks></remarks>
        Custom = 8
    End Enum

    ''' <summary>
    ''' Determines what button was clicked by the user on a message form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessageFunctionType As Integer
        ''' <summary>
        ''' The OK button was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        OK = 1

        ''' <summary>
        ''' The Yes button was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        Yes = 2

        ''' <summary>
        ''' The No button was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        No = 3

        ''' <summary>
        ''' The Cancel button was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        Cancel = 4

        ''' <summary>
        ''' The Retry button was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        Retry = 5

        ''' <summary>
        ''' The custom button #1 was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        Button1 = 6

        ''' <summary>
        ''' The custom button #2 was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        Button2 = 7

        ''' <summary>
        ''' The custom button #3 was clicked.
        ''' </summary>
        ''' <remarks></remarks>
        Button3 = 8

        ''' <summary>
        ''' No button was clicked as the message form timed out.
        ''' </summary>
        ''' <remarks></remarks>
        Timeout = 9
    End Enum

    ''' <summary>
    ''' Determines the height of a message window.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessageHeightSize As Integer
        ''' <summary>
        ''' The default height for a message window.
        ''' </summary>
        ''' <remarks></remarks>
        [Default] = 0

        ''' <summary>
        ''' Indicates that the message window should use a small height.
        ''' </summary>
        ''' <remarks></remarks>
        Small = 0

        ''' <summary>
        ''' Indicates that the message window should use a medium height.
        ''' </summary>
        ''' <remarks></remarks>
        Medium = 1

        ''' <summary>
        ''' Indicates that the message window should use a large height.
        ''' </summary>
        ''' <remarks></remarks>
        Large = 2
    End Enum

    ''' <summary>
    ''' Determines whether a message item is a text value or a complete message.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessageItemType As Integer
        ''' <summary>
        ''' The message item is a complete message.
        ''' </summary>
        ''' <remarks></remarks>
        Message = 1

        ''' <summary>
        ''' The message item is a text value.
        ''' </summary>
        ''' <remarks></remarks>
        TextValue = 2
    End Enum

    ''' <summary>
    ''' Determines the location of the data store for localized messages.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessageKeyDataType As Integer
        ''' <summary>
        ''' Indicates that the application should look to an XML file for the message store.
        ''' </summary>
        ''' <remarks></remarks>
        XML = 0

        ''' <summary>
        ''' Indicates that the application should look to the application's main data-store 
        ''' (SqlServer, Oracle, OLEDB) for the localized messages.
        ''' </summary>
        ''' <remarks></remarks>
        SqlServer = 1
    End Enum

    ''' <summary>
    ''' Determines the type of messaging project.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessageProjectType As Integer
        ''' <summary>
        ''' The message project is a common project that can be included with all other projects.
        ''' </summary>
        ''' <remarks></remarks>
        Common = 1

        ''' <summary>
        ''' The message project is a standard project.
        ''' </summary>
        ''' <remarks></remarks>
        Standard = 2
    End Enum

    ''' <summary>
    ''' Determines the width of a message window.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessageWidthSize As Integer
        ''' <summary>
        ''' The default width for a message window.
        ''' </summary>
        ''' <remarks></remarks>
        [Default] = 0

        ''' <summary>
        ''' Indicates that the message window should be a small width.
        ''' </summary>
        ''' <remarks></remarks>
        Small = 0

        ''' <summary>
        ''' Indicates that the message window should be a medium width.
        ''' </summary>
        ''' <remarks></remarks>
        Medium = 1

        ''' <summary>
        ''' Indicates that the message window should be a large width.
        ''' </summary>
        ''' <remarks></remarks>
        Large = 2
    End Enum

    ''' <summary>
    ''' Determines the cardinal position at which to display a message window.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessagingCardinalPosition As Integer
        ''' <summary>
        ''' The message window will be shown in the southeast corner of the parent or screen.
        ''' </summary>
        ''' <remarks></remarks>
        SouthEast = 1

        ''' <summary>
        ''' The message window will be shown in the northeast corner of the parent or screen.
        ''' </summary>
        ''' <remarks></remarks>
        NorthEast = 2

        ''' <summary>
        ''' The message window will be shown in the northwest corner of the parent or screen.
        ''' </summary>
        ''' <remarks></remarks>
        NorthWest = 3

        ''' <summary>
        ''' The message window will be shown in the southwest corner of the parent or screen.
        ''' </summary>
        ''' <remarks></remarks>
        SouthWest = 4

        ''' <summary>
        ''' The message window will be shown in the center of the parent or screen.
        ''' </summary>
        ''' <remarks></remarks>
        Center = 5

        ''' <summary>
        ''' The message window will be shown at the default location.
        ''' </summary>
        ''' <remarks></remarks>
        [Default] = 6
    End Enum

    ''' <summary>
    ''' Determines the icon displayed on a message window.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessagingIcon As Integer
        None = 0
        Information = 1
        Warning = 2
        Question = 3
        Fatal = 4
        Bell = 5
        Help = 6
        Mail = 7
        Touch = 8
        LightBulb = 9
        Information_Balloon = 10
        Gear = 11
        FirstAid = 12
        GreenCheck = 13
        StopSign = 14
        Bookmark = 15
        AlarmClock = 16
        StopWatch = 17
        Setup = 18
        Printer = 19
        PrinterError = 20
        PrinterOK = 21
        PrinterWarning = 22
        PrinterInformation = 23
        Earth = 24
        Document = 25
        OpenBox = 26
        ClosedBox = 27
        Forbidden = 28
    End Enum

    ''' <summary>
    ''' Determines the type of sound to be played when a message window is shown.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MessagingSounds As Integer
        ''' <summary>
        ''' No sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        None = 0

        ''' <summary>
        ''' The default sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        DefaultSound = 1

        ''' <summary>
        ''' An error sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        ErrorSound = 2

        ''' <summary>
        ''' A warning sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        Warning = 3

        ''' <summary>
        ''' A fatal sound it played.
        ''' </summary>
        ''' <remarks></remarks>
        Fatal = 4

        ''' <summary>
        ''' A notification sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        Notify = 5

        ''' <summary>
        ''' A tip sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        Tip = 6

        ''' <summary>
        ''' A question sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        Question = 7

        ''' <summary>
        ''' A custom sound is played.
        ''' </summary>
        ''' <remarks></remarks>
        Custom = 8
    End Enum

End Namespace