Imports System.IO.Packaging

Public Class GridViewClients
    Private bbdd As New ClasseBBDD
    Dim taulaClients As String = "empresa"
    Dim taulaUsuari As String = "usuari"

    Public Sub selectTaula()
        bbdd.mostrarAdmin(taulaClients, DataGridViewClients)
    End Sub
    Public Sub updateClient(ByVal nif As String, ByVal telefon As String, ByVal pack As String, ByVal id As String)
        'Dim dades As String() = {nif, telefon, pack}
        Dim dades(3) As String
        dades(0) = nif
        dades(1) = telefon
        dades(2) = pack
        '  bbdd.modificarAdmin(taulaClients, dades, id, DataGridViewClients)
    End Sub
    Public Sub deleteClient()
        ' bbdd.eliminar(taulaUsuari, DataGridViewClients, EnviarId)
    End Sub
    Public Sub insertClient(ByVal idUsuari As String, ByVal nif As String, ByVal telefon As String, ByVal pack As String)
        Dim dades As String() = {idUsuari, nif, telefon, pack}
        bbdd.afegirAdmin(taulaClients, dades, DataGridViewClients)
    End Sub
    'Public Function insertUsuari(ByVal nom As String, ByVal correu As String, ByVal contrasenya As String, ByVal data_registre As String, ByVal actiu As String)
    '    Dim dades(4) As String
    '    dades(0) = nom
    '    dades(1) = correu
    '    dades(2) = contrasenya
    '    dades(3) = data_registre
    '    If (actiu.Equals("Si")) Then
    '        dades(4) = "1"
    '    Else
    '        dades(4) = "0"
    '    End If
    '    bbdd.afegirAdmin(taulaUsuari, dades, DataGridViewClients)
    '    Dim retornar = bbdd.buscar(taulaUsuari, dades, DataGridViewClients)
    '    Return retornar
    'End Function
    Public Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewClients.SelectedRows.Count > 0 Then
            id = DataGridViewClients.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function

End Class