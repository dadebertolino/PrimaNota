Imports System

Friend Class CryptoException : Inherits System.Exception

    Public Sub New(ByVal sender As Type, ByVal message As String)

        MyBase.New(message)
        Me.Source = sender.Name

    End Sub

End Class