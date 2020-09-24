Namespace Win32
    ''' <summary>
    ''' Contains the file type details for a specified file 
    ''' extension associated with the operating system.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FileTypeInformation

#Region " Declare Privates "
        Private _FileIconSmall As System.Drawing.Icon
        Private _FileIconLarge As System.Drawing.Icon
        Private _IconKey As String
        Private _TypeDescription As String
        Private _ShellExecutable As String
#End Region

#Region " Declare Properties "

        ''' <summary>
        ''' The large icon associated with a particular file extension on the 
        ''' operating system.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FileIconLarge() As System.Drawing.Icon
            Get
                Return _FileIconLarge
            End Get
            Set(ByVal value As System.Drawing.Icon)
                _FileIconLarge = value
            End Set
        End Property

        ''' <summary>
        ''' The small icon associated with a particular file extension on the 
        ''' operating system.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FileIconSmall() As System.Drawing.Icon
            Get
                Return _FileIconSmall
            End Get
            Set(ByVal value As System.Drawing.Icon)
                _FileIconSmall = value
            End Set
        End Property

        ''' <summary>
        ''' The registry key associated with the icon
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IconKey() As String
            Get
                Return _IconKey
            End Get
            Set(ByVal value As String)
                _IconKey = value
            End Set
        End Property

        ''' <summary>
        ''' The path and file name of the shell executable that launches the application
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ShellExecutable() As String
            Get
                Return _ShellExecutable
            End Get
            Set(ByVal value As String)
                _ShellExecutable = value
            End Set
        End Property

        ''' <summary>
        ''' A readable description of the file type (i.e. Word Document, Excel Document, etc.)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TypeDescription() As String
            Get
                Return _TypeDescription
            End Get
            Set(ByVal value As String)
                _TypeDescription = value
            End Set
        End Property

#End Region

    End Class
End Namespace
