Imports MySql.Data.MySqlClient
Public Class ClasseBBDD
    Private sentencia As String
    Public Function connectar()
        Dim connexio As New MySqlConnection()
        Try
            With connexio
                .ConnectionString = "server=localhost; user id=root; password=admin123; database=tapping; port=3306;"
            End With
            connexio.Open()
            MessageBox.Show("Conectado al servidor")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return connexio
    End Function
    Public Function mostrar(ByVal connexio As MySqlConnection, ByVal taula As String)
        sentencia = "SELECT * FROM" & taula
        Dim comando As New MySqlCommand(sentencia, connexio)
        Dim reader = comando.ExecuteReader()
        Return reader
    End Function
End Class
