Public Class FormComentaris
    Dim taula As String = "valoracio"
    Dim bbdd As New ClasseBBDD
    Private Sub FormComentaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.SelectEmpresa(taula, 0, DataGridViewComentaris)
    End Sub
    Private Sub DataGridViewComentaris_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewComentaris.SelectionChanged
        DataGridViewComentaris.ClearSelection()
    End Sub
End Class