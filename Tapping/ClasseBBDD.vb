Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

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
                .ConnectionString = "server=192.168.1.150; user id=tapping; password=JuMaJoJo!!25231; database=tappingDB; port=25230;Convert Zero Datetime=True;"
                'Remot
                '.ConnectionString = "server=webapps.insjoanbrudieu.cat; user id=tapping; password=JuMaJoJo!!25231; database=tappingDB; port=25230;Convert Zero Datetime=True;"
                'Localhost
                '.ConnectionString = "server=localhost; user id=root; password=''; database=tapping; port=3306;Convert Zero Datetime=True;"
            End With
            connexio.Open()
            'MessageBox.Show("Connectat al servidor")
        Catch ex As Exception
            MessageBox.Show("Error en 'connectar' ClasseBBDD: " & ex.Message)
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
        Select Case taula
            Case "empresa"
                sentencia = "SELECT id_usuari,nif,telefon,pack,usuari.nom, usuari.correu, usuari.actiu FROM empresa INNER JOIN usuari on empresa.id_usuari = usuari.id where usuari.actiu = 1"
            Case "tapa"
                sentencia = "SELECT tapa.id AS id_tapa,tapa.nom AS Tapa, categoria.nom AS Categoria FROM tapa JOIN categoria_tapa ON tapa.id = categoria_tapa.id_tapa JOIN categoria ON categoria_tapa.id_categoria = categoria.id"
            Case "categoria"
                sentencia = "SELECT * FROM categoria"
        End Select
        'sentencia = "SELECT * FROM " & taula
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error en 'mostrarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub modificarAdmin(ByVal taula As String, ByVal dades() As String, ByVal id As Integer, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                sentencia = "UPDATE noticia SET titol = '" & dades(0) & "', descripcio = '" & dades(1) & "', foto = '" & dades(2) & "', data_publicacio = '" & dades(3) & "', data_inici = '" & dades(4) & "', data_fi = '" & dades(3) & "' WHERE id = " & id
            Case "empresa"
                sentencia = "UPDATE empresa SET nif = '" & dades(0) & "', telefon = '" & dades(1) & "', pack = '" & dades(2) & "' WHERE id_usuari = " & id
            Case "tapa"
                sentencia = "UPDATE tapa SET nom = '" & dades(0) & "' WHERE id = " & id
            Case "categoria"
                sentencia = "UPDATE categoria SET nom = '" & dades(0) & "' WHERE id = " & id
        End Select
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() Then
                mostrarAdmin(taula, dgv)
            Else
                MsgBox("ERROR al fer la modificació", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en 'modificarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    Public Function afegirAdmin(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView) As String
        Dim retornar As String = ""
        Select Case taula
            Case "noticia"
                sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "','" & dades(5) & "')"
            Case "preguntafrequent"
                sentencia = "INSERT INTO preguntafrequent (pregunta,resposta) VALUES ('" & dades(0) & "','" & dades(1) & "')"
            Case "categoria"
                sentencia = "INSERT INTO categoria (nom) VALUES ('" & dades(0) & "')"
            Case "empresa"
                sentencia = "INSERT INTO empresa (id_usuari,nif,telefon,pack) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "')"
            Case "usuari"
                sentencia = "INSERT INTO usuari(nom,correu,contrasenya,data_registre,actiu) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "')"
            Case "tapa"
                sentencia = "INSERT INTO tapa(nom) VALUES ('" & dades(0) & "')"
            Case "categoria_tapa"
                sentencia = "INSERT INTO categoria_tapa(id_categoria, id_tapa) VALUES ('" & dades(0) & "','" & dades(1) & "')"
        End Select

        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 And taula.Equals("empresa") Then
                mostrarAdmin(taula, dgv)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'afegirAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
        Return retornar
    End Function
    Public Function buscar(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView) As String
        Dim retornar As String = ""
        Select Case taula
            Case "usuari"
                sentencia = "SELECT id FROM usuari WHERE nom='" & dades(0) & "' AND correu='" & dades(1) & "' AND contrasenya='" & dades(2) & "' AND data_registre='" & dades(3) & "' AND actiu='" & dades(4) & "'"
            Case "empresa"
                sentencia = "SELECT id FROM empresa WHERE nif='" & dades(0) & "' AND telefon='" & dades(1) & "' AND pack='" & dades(2) & "'"
            Case "tapa"
                sentencia = "SELECT MAX(id) FROM tapa"
            Case "categoria"
                sentencia = "SELECT id FROM categoria WHERE nom='" & dades(0) & "'"
        End Select

        Try
            table = New DataTable
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            Dim reader = comanda.ExecuteReader()
            If reader.Read() Then
                retornar = reader.GetString(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en 'mostrarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
        Return retornar
    End Function
    Public Sub eliminar(ByVal taula As String, ByVal dgv As DataGridView, ByVal id As String)
        Select Case taula
            Case "usuari"
                ' en aquest cas actualitzo l'actiu a 0 en comptes d'eliminar
                sentencia = "UPDATE usuari SET actiu = 0 where id = " & id
            Case "categoria_tapa"
                sentencia = "DELETE FROM categoria_tapa where id_tapa = " & id
            Case "tapa"
                sentencia = "DELETE FROM tapa where id = " & id
            Case "categoria"
                sentencia = "DELETE FROM categoria where id = " & id
        End Select

        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() Then
                mostrarAdmin(taula, dgv)
            Else
                MsgBox("ERROR en fer l'eliminació", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en 'eliminar' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

End Class
