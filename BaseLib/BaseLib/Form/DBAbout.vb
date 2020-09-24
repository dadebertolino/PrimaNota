Public NotInheritable Class DBAbout

    Private Sub Ovo2About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Imposta il titolo del form.
        Dim ApplicationTitle As String = ApplicationDescription
        Me.Text = "Informazioni su " & ApplicationTitle
        Me.TextBoxDescription.Text = dbLicensing.GetLicenseInfo

        If dbLicensing.LicIsTrial = True Then
            Me.btnRegistra.Visible = True
        Else
            Me.btnRegistra.Visible = False
        End If
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versione {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.Invalidate()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub btnRegistra_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistra.Click
        Dim frm As New frmUpgrade
        frm.ShowDialog()
    End Sub
End Class
