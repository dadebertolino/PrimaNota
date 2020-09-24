Public Class DB_DIALOG

    Public Sub New()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    <System.ComponentModel.DefaultValue(Windows.Forms.FormStartPosition.CenterScreen)> Public Overloads Property StartPosition() As Windows.Forms.FormStartPosition
        Get
            Return MyBase.StartPosition
        End Get
        Set(ByVal value As Windows.Forms.FormStartPosition)
            MyBase.StartPosition = value
        End Set
    End Property
    <System.ComponentModel.DefaultValue(Windows.Forms.FormBorderStyle.FixedDialog)> Public Overloads Property FormBorderStyle() As Windows.Forms.FormBorderStyle
        Get
            Return MyBase.FormBorderStyle
        End Get
        Set(ByVal value As Windows.Forms.FormBorderStyle)
            MyBase.FormBorderStyle = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(False)> Public Overloads Property MinimizeBox() As Boolean
        Get
            Return MyBase.MinimizeBox
        End Get
        Set(ByVal value As Boolean)
            MyBase.MinimizeBox = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(False)> Public Overloads Property MaximizeBox() As Boolean
        Get
            Return MyBase.MaximizeBox
        End Get
        Set(ByVal value As Boolean)
            MyBase.MaximizeBox = value
        End Set
    End Property
End Class
