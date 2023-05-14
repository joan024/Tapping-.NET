Public Class FormAfegirUsuari
    'Quan li doni clic al boto tanquem pantalla
    Private Sub ButtonUsuari_Click(sender As Object, e As EventArgs) Handles ButtonUsuari.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class