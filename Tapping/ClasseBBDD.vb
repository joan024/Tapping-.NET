Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Crypto

Public Class ClasseBBDD
    Private connexio As MySqlConnection
    Private adapter As MySqlDataAdapter
    Private comanda As New MySqlCommand
    Private table As DataTable
    Private sentencia As String
    Private Sub connectar()
        Try
            connexio = New MySqlConnection
            With connexio
                'Local
                '.ConnectionString = "server=192.168.1.150; user id=tapping; password=JuMaJoJo!!25231; database=tappingDB; port=25230;Convert Zero Datetime=True;"
                'Remot
                '.ConnectionString = "server=webapps.insjoanbrudieu.cat; user id=tapping; password=JuMaJoJo!!25231; database=tappingDB; port=25230;Convert Zero Datetime=True;"
                'Localhost
                .ConnectionString = "server=localhost; user id=root; password=admin123; database=tapping; port=3306;Convert Zero Datetime=True;"
            End With
            connexio.Open()
            'MessageBox.Show("Connexio Establerta")
        Catch ex As Exception
            MessageBox.Show("Error 'connectar' ClasseBBDD: " & ex.Message)
        End Try
    End Sub
    Private Sub desconnectar()
        If connexio.State = 1 Then
            connexio.Dispose()
            'MessageBox.Show("Connexio Tancada")
        End If
    End Sub
    Public Function comprovacioLogin(ByVal taula As String)
        sentencia = "SELECT * FROM " & taula
        connectar()
        comanda = New MySqlCommand(sentencia, connexio)
        Dim reader = comanda.ExecuteReader()
        Return reader
    End Function
    Public Sub mostrarAdmin(ByVal taula As String, ByVal dgv As DataGridView)
        sentencia = "SELECT * FROM " & taula
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error 'mostrarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub modificarAdmin(ByVal taula As String, ByVal dades() As String, ByVal id As Integer, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                sentencia = "UPDATE noticia SET titol = '" & dades(0) & "', descripcio = '" & dades(1) & "', foto = '" & dades(2) & "', data_publicacio = '" & dades(3) & "', data_inici = '" & dades(4) & "', data_fi = '" & dades(5) & "' WHERE id = " & id
            Case "preguntafrequent"
                sentencia = "UPDATE preguntafrequent SET pregunta = '" & dades(0) & "', resposta = '" & dades(1) & "' WHERE id = " & id
        End Select
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() Then
                mostrarAdmin(taula, dgv)
            Else
                MsgBox("ERROR en fer la modificació", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'modificarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub afegirAdmin(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "','" & dades(5) & "')"
            Case "preguntafrequent"
                sentencia = "INSERT INTO preguntafrequent (pregunta,resposta) VALUES ('" & dades(0) & "','" & dades(1) & "')"
            Case "categoria"
                sentencia = "INSERT INTO categoria (nom) VALUES ('" & dades(0) & "')"
        End Select

        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 Then
                mostrarAdmin(taula, dgv)
            Else
                MsgBox("ERROR en fer la inserció", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'afegirAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub eliminar(ByVal taula As String, ByVal dgv As DataGridView, ByVal id As String)
        sentencia = "DELETE FROM " & taula & " WHERE id = " & id
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() Then
                mostrarAdmin(taula, dgv)
            Else
                MsgBox("ERROR en fer l'eliminació", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'eliminar' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub XatEmpresa(ByVal dgv As DataGridView)
        sentencia = "SELECT nom FROM usuari INNER JOIN xat ON usuari.id = xat.id_empresa"
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error 'XatEmpresa' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub MissatgesXat(ByVal empresa As String, ByVal dgv As DataGridView)
        sentencia = "SELECT lineaxat.usuari,lineaxat.missatge,lineaxat.id_xat FROM lineaxat INNER JOIN xat ON lineaxat.id_xat = xat.id INNER JOIN usuari ON xat.id_empresa = usuari.id WHERE usuari.nom = '" & empresa & "'"
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error 'MissatgeXat' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub InsertMissatge(ByVal idXat As String, ByVal missatge As String, ByVal empresa As String, ByVal dgv As DataGridView)
        sentencia = "INSERT INTO lineaxat (id_xat,usuari,missatge,temps) VALUES (" & idXat & ",1,'" & missatge & "','" & Format(Date.Today, "yyyy-MM-dd") & "')"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 Then
                MissatgesXat(empresa, dgv)
            Else
                MsgBox("ERROR en fer la inserció del missatge", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'InsertXat' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
End Class
