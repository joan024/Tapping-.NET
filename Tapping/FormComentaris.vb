Public Class FormComentaris
    Private Sub FormComentaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem comentaris dels locals de la empresa
        Constants.bbdd.SelectEmpresa(Constants.TAULAVALORACIO, Constants.IDUSUARI, DataGridViewComentaris)
    End Sub
    Private Sub DataGridViewComentaris_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewComentaris.SelectionChanged
        'fem aixo per que no pugui seleccionar res
        DataGridViewComentaris.ClearSelection()
    End Sub
End Class