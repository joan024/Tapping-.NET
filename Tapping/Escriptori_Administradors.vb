Public Class Escriptori_Administradors
    Private Sub Escriptori_Administradors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            MsgBox(ListView1.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub ClientsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem.Click
        ' Agregar dos columnas al control ListView
        ListView1.Columns.Add("Nombre")
        ListView1.Columns.Add("Edad")

        ' Crear un objeto ListViewItem con el texto "Juan" y "25"
        Dim item As New ListViewItem
        item.Text = "Juan"
        item.SubItems.Add("25")

        ' Agregar el objeto ListViewItem a la lista
        ListView1.Items.Add(item)


    End Sub
End Class