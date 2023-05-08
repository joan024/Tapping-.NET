Public Class GridViewCategories
    Private bbdd As New ClasseBBDD
    Dim taulaCategoria As String = "categoria"
    Dim taulaCategoriaTapa As String = "categoria_tapa"

    Public Sub selectTaula()
        bbdd.mostrarAdmin(taulaCategoria, DataGridViewCategories)
    End Sub

    Public Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewCategories.SelectedRows.Count > 0 Then
            id = DataGridViewCategories.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function

    Public Function insertCategoria(ByVal nom As String)
        Dim dades(1) As String
        dades(0) = nom
        bbdd.afegirAdmin(taulaCategoria, dades, DataGridViewCategories)
    End Function
    Public Function updateCategoria(ByVal nom As String)
        Dim dades(1) As String
        dades(0) = nom
        bbdd.modificarAdmin(taulaCategoria, dades, EnviarId, DataGridViewCategories)
    End Function
    Public Function deleteCategoria()
        bbdd.eliminar(taulaCategoria, DataGridViewCategories, EnviarId)
    End Function



End Class