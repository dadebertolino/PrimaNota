Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim EAN13 As New BaseLib.BarCode.Ean13
        Me.TextBox2.Text = EAN13.encode(Me.TextBox1.Text)
    End Sub
End Class
