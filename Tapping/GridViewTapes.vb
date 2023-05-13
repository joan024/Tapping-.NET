Public Class GridViewTapes

    Public Sub selectTaula()
        Constants.bbdd.SelectAdmin(Constants.TAULATAPA, DataGridViewTapes)
    End Sub

    Public Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewTapes.SelectedRows.Count > 0 Then
            id = DataGridViewTapes.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function
    Public Function insertTapa(ByVal nom As String) As String
        Dim dades(1) As String
        dades(0) = nom
        Constants.bbdd.InsertAdmin(Constants.TAULATAPA, dades, DataGridViewTapes)
        Dim retornar = Constants.bbdd.SelectId(Constants.TAULATAPA, dades)
        Return retornar
    End Function
    Public Sub insertCategoriaTapa(ByVal idTapa As String, ByVal categoria As String)
        Dim dades(1) As String
        dades(0) = categoria
        Dim idCategoria = Constants.bbdd.SelectId(Constants.TAULACATEGORIA, dades)
        Dim dadesCategoria(2) As String
        dadesCategoria(0) = idCategoria
        dadesCategoria(1) = idTapa
        Constants.bbdd.InsertAdmin(Constants.TAULACATEGORIATAPA, dadesCategoria, DataGridViewTapes)
    End Sub

    Public Sub deleteTapa()
        Dim id As String = EnviarId()
        Constants.bbdd.Delete(Constants.TAULACATEGORIATAPA, DataGridViewTapes, id)
        Constants.bbdd.Delete(Constants.TAULATAPA, DataGridViewTapes, id)
    End Sub

    Public Sub updateTapa(ByVal nom As String, ByVal id As String)
        Dim dades(1) As String
        dades(0) = nom
        Constants.bbdd.UpdateAdmin(Constants.TAULATAPA, dades, id, DataGridViewTapes)
    End Sub

End Class