Public Class FormCategoria
    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewCategoria.Rows.Add("1", "Bocadillos")
        DataGridViewCategoria.Rows.Add("2", "Ensaladas")
    End Sub
End Class