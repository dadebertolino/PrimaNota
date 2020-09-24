Public Class DBFrmParametri

    Public Event CaricaParametri()

    Public Event SalvaParametri()

    Public Event CheckParametri(ByRef Cancel As Boolean)

    Private Sub BtnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnulla.Click
        Me.Close()
    End Sub

    Private Sub DBFrmParametri_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = "Personalizzazione dei parametri di " & ApplicationTitle
        RaiseEvent CaricaParametri()
    End Sub

    Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
        Dim Cancel As Boolean = False
        RaiseEvent CheckParametri(Cancel)
        If Cancel = True Then
            Exit Sub
        End If
        RaiseEvent SalvaParametri()
        Me.Close()
    End Sub
End Class