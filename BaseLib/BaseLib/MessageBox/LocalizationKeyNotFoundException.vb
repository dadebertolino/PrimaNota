Namespace Messaging

    Public Class LocalizationKeyNotFoundException
        Inherits System.Exception

#Region " Constructors "

        ''' <summary>
        ''' Generic Constructor
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

        End Sub

        ''' <summary>
        ''' Set with inner exception
        ''' </summary>
        ''' <param name="InnerException"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal message As String, ByVal InnerException As Exception)
            MyBase.New(message, InnerException)
        End Sub

        ''' <summary>
        ''' Set with message
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

#End Region


    End Class

End Namespace