Public Class FormComentaris
    Private Sub FormComentaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Constants.bbdd.SelectEmpresa(Constants.TAULAVALORACIO, Constants.IDUSUARI, DataGridViewComentaris)
    End Sub
    Private Sub DataGridViewComentaris_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewComentaris.SelectionChanged
        DataGridViewComentaris.ClearSelection()
    End Sub
End Class