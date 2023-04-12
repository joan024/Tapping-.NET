Public Class Form2NoticiesAdminvb
    Private taula As String = "noticia"
    Private bbdd As New ClasseBBDD
    Private Sub Form2NoticiesAdminvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.mostrarAdmin(taula, DataGridViewNoticies)
    End Sub
End Class