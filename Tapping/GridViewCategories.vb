Public Class GridViewCategories

    Public Sub selectTaula()
        Constants.bbdd.SelectAdmin(Constants.TAULACATEGORIA, DataGridViewCategories)
    End Sub

    Public Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewCategories.SelectedRows.Count > 0 Then
            id = DataGridViewCategories.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function

    Public Sub insertCategoria(ByVal nom As String)
        Dim dades(1) As String
        dades(0) = nom
        Constants.bbdd.InsertAdmin(Constants.TAULACATEGORIA, dades, DataGridViewCategories)
    End Sub
    Public Sub updateCategoria(ByVal nom As String)
        Dim dades(1) As String
        dades(0) = nom
        Constants.bbdd.UpdateAdmin(Constants.TAULACATEGORIA, dades, EnviarId, DataGridViewCategories)
    End Sub
    Public Sub deleteCategoria()
        Constants.bbdd.Delete(Constants.TAULACATEGORIA, DataGridViewCategories, EnviarId)
    End Sub

End Class