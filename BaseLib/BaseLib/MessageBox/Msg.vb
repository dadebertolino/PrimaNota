Public Module Msg
    Public Sub ErrorStop(Optional ByVal ErrorMessage As String = "")
        Dim Messaggio As String
        If ErrorMessage = "" Then
            Messaggio = "Si è verificata una situazione non prevista" & vbCrLf & "Contattare il fornitore del programma"
        Else
            Messaggio = ErrorMessage
        End If
        Dim m As New Messaging.MessageItem
        m.Title = Application.ApplicationDescription
        m.Text = Messaggio
        m.MessageWidth = Messaging.MessageWidthSize.Large
        m.MessageHeight = Messaging.MessageHeightSize.Large
        m.MessageFunctionality = Messaging.MessageFunction.OK
        m.MessageIcon = Messaging.MessagingIcon.Fatal
        m.MessageSound = Messaging.MessagingSounds.Fatal
        BaseLib.Messaging.MessageForm.ShowMessage(m)
        'DevExpress.XtraEditors.XtraMessageBox.Show(Messaggio, Application.Name, MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub
    Public Sub ErrorContinue(ByVal ErrorMessage As String)
        Dim m As New Messaging.MessageItem
        m.Title = Application.ApplicationDescription
        m.Text = ErrorMessage
        m.MessageFunctionality = Messaging.MessageFunction.OK
        m.MessageIcon = Messaging.MessagingIcon.Forbidden
        m.MessageSound = Messaging.MessagingSounds.ErrorSound
        BaseLib.Messaging.MessageForm.ShowMessage(m)
        'DevExpress.XtraEditors.XtraMessageBox.Show(ErrorMessage, Application.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub Info(ByVal Message As String)
        Dim m As New Messaging.MessageItem
        m.Title = Application.ApplicationDescription
        m.Text = Message
        m.MessageFunctionality = Messaging.MessageFunction.OK
        m.MessageIcon = Messaging.MessagingIcon.Information
        m.MessageSound = Messaging.MessagingSounds.Tip
        BaseLib.Messaging.MessageForm.ShowMessage(m)
        'DevExpress.XtraEditors.XtraMessageBox.Show(Message, Application.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub Warning(ByVal Message As String)
        Dim m As New Messaging.MessageItem
        m.Title = Application.ApplicationDescription
        m.Text = Message
        m.MessageFunctionality = Messaging.MessageFunction.OK
        m.MessageIcon = Messaging.MessagingIcon.Warning
        m.MessageSound = Messaging.MessagingSounds.Warning
        BaseLib.Messaging.MessageForm.ShowMessage(m)
        'DevExpress.XtraEditors.XtraMessageBox.Show(Message, Application.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Function QuestionYesNo(ByVal QuestionMsg As String) As MsgBoxResult
        Dim m As New Messaging.MessageItem
        m.Title = Application.ApplicationDescription
        m.Text = QuestionMsg
        m.MessageFunctionality = Messaging.MessageFunction.YesNo
        m.MessageIcon = Messaging.MessagingIcon.Question
        m.MessageSound = Messaging.MessagingSounds.Question
        Dim r As Messaging.MessageFunctionType = BaseLib.Messaging.MessageForm.ShowMessage(m)
        If r = Messaging.MessageFunctionType.Yes Then
            Return MsgBoxResult.Yes
        End If
        Return MsgBoxResult.No
        'Return DevExpress.XtraEditors.XtraMessageBox.Show(QuestionMsg, Application.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Public Function QuestionYesNoCancel(ByVal QuestionMsg As String) As MsgBoxResult
        Dim m As New Messaging.MessageItem
        m.Title = Application.ApplicationDescription
        m.Text = QuestionMsg
        m.MessageFunctionality = Messaging.MessageFunction.YesNoCancel
        m.MessageIcon = Messaging.MessagingIcon.Question
        m.MessageSound = Messaging.MessagingSounds.Question
        Dim r As Messaging.MessageFunctionType = BaseLib.Messaging.MessageForm.ShowMessage(m)
        If r = Messaging.MessageFunctionType.Yes Then
            Return MsgBoxResult.Yes
        ElseIf r = Messaging.MessageFunctionType.No Then
            Return MsgBoxResult.No
        End If
        Return MsgBoxResult.Cancel
        'Return DevExpress.XtraEditors.XtraMessageBox.Show(QuestionMsg, Application.Name, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
    End Function
End Module