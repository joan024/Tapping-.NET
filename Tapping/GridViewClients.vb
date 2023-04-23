Imports System.IO.Packaging

Public Class GridViewClients
    Private bbdd As New ClasseBBDD
    Dim taulaClients As String = "empresa"
    Dim taulaUsuari As String = "usuari"
    Public Sub selectAdmin()
        bbdd.mostrarAdmin(taulaClients, DataGridViewClients)
    End Sub
    Public Sub updateAdmin(ByVal dades() As String, ByVal id As Integer)
        bbdd.modificarAdmin(taulaClients, dades, id, DataGridViewClients)
    End Sub
    Public Sub insertEmpresa(ByVal dades() As String)
        bbdd.afegirAdmin(taulaClients, dades, DataGridViewClients)
    End Sub
    Public Function insertUser(ByVal nom As String, ByVal correu As String, ByVal contrasenya As String, ByVal data_registre As String, ByVal actiu As String)
        Dim dades(4) As String
        dades(0) = nom
        dades(1) = correu
        dades(2) = contrasenya
        dades(3) = data_registre
        If (actiu.Equals("Si")) Then
            dades(4) = "1"
        Else
            dades(4) = "0"
        End If
        bbdd.afegirAdmin(taulaUsuari, dades, DataGridViewClients)
        Dim retornar = bbdd.buscarUsuari(taulaUsuari, dades, DataGridViewClients)
        Return retornar
    End Function
    Public Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewClients.SelectedRows.Count > 0 Then
            id = DataGridViewClients.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function

End Class