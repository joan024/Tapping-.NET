Public Class GridViewTapes
    Private bbdd As New ClasseBBDD
    Dim taulaClients As String = "empresa"
    Dim taulaUsuari As String = "usuari"
    Dim taulaTapa As String = "tapa"
    Dim taulaCategoria As String = "categoria"
    Dim taulaCategoriaTapa As String = "categoria_tapa"

    Public Sub selectTaula()
        bbdd.mostrarAdmin(taulaTapa, DataGridViewTapes)
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
        bbdd.afegirAdmin(taulaTapa, dades, DataGridViewTapes)
        Dim retornar = bbdd.buscar(taulaTapa, dades, DataGridViewTapes)
        Return retornar
    End Function
    Public Function insertCategoriaTapa(ByVal idTapa As String, ByVal categoria As String)
        Dim dades(1) As String
        dades(0) = categoria
        Dim retornar = bbdd.buscar(taulaCategoria, dades, DataGridViewTapes)
        Dim dadesCategoria(2) As String
        dadesCategoria(0) = retornar
        dadesCategoria(1) = idTapa
        bbdd.afegirAdmin(taulaCategoriaTapa, dadesCategoria, DataGridViewTapes)
    End Function

    Public Function deleteTapa()
        Dim id As String = EnviarId()
        bbdd.eliminar(taulaCategoriaTapa, DataGridViewTapes, id)
        bbdd.eliminar(taulaTapa, DataGridViewTapes, id)
    End Function

    Public Sub updateTapa(ByVal nom As String, ByVal id As String)
        Dim dades(1) As String
        dades(0) = nom
        bbdd.modificarAdmin(taulaTapa, dades, id, DataGridViewTapes)
    End Sub


End Class