Imports System.Collections.Specialized
Imports System.IO

Namespace Strings

    ''' <summary>
    ''' Provides basic methods for managing strings within the StrataFrame class library.
    ''' </summary>
    ''' <remarks></remarks>
    Public NotInheritable Class StringBasics

#Region " Constructors "

        ''' <summary>
        ''' Initializes a new instance of the StringBasics class.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub New()
        End Sub

#End Region

#Region " Public Methods "

        ''' <summary>
        ''' Adds a backslash to the end of the given string if the string does not already end with a backslash.
        ''' </summary>
        ''' <param name="FilePath">The string onto which the backslash will be added.</param>
        ''' <returns>The given string ending in a backslash.</returns>
        ''' <remarks></remarks>
        Public Shared Function AddBS(ByVal FilePath As String) As String
            ' Establish Locals
            Dim lcReturn As String = FilePath.Trim()

            ' Determine is a backslash should be added
            If (lcReturn.Length > 0) AndAlso (Not lcReturn.EndsWith("\")) Then
                lcReturn &= "\"
            End If

            Return lcReturn
        End Function

        ''' <summary>
        ''' Creates a new StringCollection from the specified string array.
        ''' </summary>
        ''' <param name="Items">The string array from which to create the StringCollection.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function CreateStringCollection(ByVal ParamArray Items As String()) As StringCollection
            '-- Establish locals
            Dim loReturn As New StringCollection

            '-- Add the items
            loReturn.AddRange(Items)

            '-- Return the list
            Return loReturn
        End Function

#End Region

    End Class

End Namespace

