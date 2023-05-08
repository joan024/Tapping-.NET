Imports System.IO
Imports MySql.Data.MySqlClient

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

    'FUNCIONS ADMIN
    Public Sub SelectAdmin(ByVal taula As String, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                sentencia = "SELECT * FROM " & taula
            Case "preguntafrequent"
                sentencia = "SELECT * FROM " & taula
            Case "empresa"
                sentencia = "SELECT id_usuari,nif,telefon,pack,usuari.nom, usuari.correu, usuari.actiu FROM empresa INNER JOIN usuari on empresa.id_usuari = usuari.id where usuari.actiu = 1"
            Case "tapa"
                sentencia = "SELECT tapa.id AS id_tapa,tapa.nom AS Tapa, categoria.nom AS Categoria FROM tapa JOIN categoria_tapa ON tapa.id = categoria_tapa.id_tapa JOIN categoria ON categoria_tapa.id_categoria = categoria.id"
            Case "categoria"
                sentencia = "SELECT * FROM categoria"
        End Select
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error en 'SelectAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub UpdateAdmin(ByVal taula As String, ByVal dades() As String, ByVal id As Integer, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                sentencia = "UPDATE noticia SET titol = '" & dades(0) & "', descripcio = '" & dades(1) & "', foto = '" & dades(2) & "', data_publicacio = '" & dades(3) & "', data_inici = '" & dades(4) & "', data_fi = '" & dades(5) & "' WHERE id = " & id
            Case "preguntafrequent"
                sentencia = "UPDATE preguntafrequent SET pregunta = '" & dades(0) & "', resposta = '" & dades(1) & "' WHERE id = " & id
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
                SelectAdmin(taula, dgv)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'UpdateAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub InsertAdmin(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                If dades(5) = "" Then
                    sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "', NULL)"
                Else
                    sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "','" & dades(5) & "')"
                End If
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
                SelectAdmin(taula, dgv)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'InsertAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub Delete(ByVal taula As String, ByVal dgv As DataGridView, ByVal id As String)
        sentencia = "DELETE FROM " & taula & " WHERE id = " & id
        Select Case taula
            Case "noticia"
                sentencia = "DELETE FROM " & taula & " WHERE id = " & id
            Case "preguntafrequent"
                sentencia = "DELETE FROM " & taula & " WHERE id = " & id
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
                SelectAdmin(taula, dgv)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'Delete' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    Public Function SelectId(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView) As String
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

    'FUNCIONS PER XAT ADMIN
    Public Sub XatsEmpresa(ByVal dgv As DataGridView)
        sentencia = "SELECT nom FROM usuari INNER JOIN xat ON usuari.id = xat.id_empresa"
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error 'XatsEmpresa' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub MissatgesXatAdmin(ByVal empresa As String, ByVal dgv As DataGridView)
        sentencia = "SELECT lineaxat.usuari,lineaxat.missatge,lineaxat.id_xat FROM lineaxat INNER JOIN xat ON lineaxat.id_xat = xat.id INNER JOIN usuari ON xat.id_empresa = usuari.id WHERE usuari.nom = '" & empresa & "'"
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error 'MissatgesXatAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub InsertMissatgeAdmin(ByVal idXat As String, ByVal missatge As String, ByVal empresa As String, ByVal dgv As DataGridView)
        sentencia = "INSERT INTO lineaxat (id_xat,usuari,missatge,temps) VALUES (" & idXat & ",1,'" & missatge & "','" & Format(Date.Today, "yyyy-MM-dd") & "')"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 Then
                MissatgesXatAdmin(empresa, dgv)
            Else
                MsgBox("ERROR en fer la inserció del missatge", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'InsertMissatgeAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    'FUNCIONS PER EMPRESA
    Public Sub SelectEmpresa(ByVal taula As String, ByVal id As String, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                sentencia = "SELECT titol,descripcio,foto FROM " & taula & " WHERE data_inici <= '" & Format(Date.Today, "yyyy-MM-dd") & "' AND (data_fi >= '" & Format(Date.Today, "yyyy-MM-dd") & "' OR data_fi IS NULL)"
            Case "preguntafrequent"
                sentencia = "SELECT pregunta,resposta FROM " & taula & ""
            Case "valoracio"
                sentencia = "SELECT puntuacio,comentari FROM " & taula & " WHERE id_local = '" & id & "'"
        End Select
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error en 'SelectEmpresa' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    'FUNCIONS PER XAT EMPRESA
    Public Sub MissatgesXatEmpresa(ByVal id As String, ByVal dgv As DataGridView)
        sentencia = "SELECT lineaxat.usuari,lineaxat.missatge,lineaxat.id_xat FROM lineaxat INNER JOIN xat ON lineaxat.id_xat = xat.id WHERE xat.id_empresa = '" & id & "'"
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error 'MissatgesXatEmpresa' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub InsertMissatgeEmpresa(ByVal idXat As String, ByVal missatge As String, ByVal id As String, ByVal dgv As DataGridView)
        sentencia = "INSERT INTO lineaxat (id_xat,usuari,missatge,temps) VALUES (" & idXat & ",2,'" & missatge & "','" & Format(Date.Today, "yyyy-MM-dd") & "')"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 Then
                MissatgesXatEmpresa(id, dgv)
            Else
                MsgBox("ERROR en fer la inserció del missatge", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'InsertMissatgeEmpresa' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    'FUNCIONS ARXIU
    Public Sub ArxiuLocal()
        sentencia = "SELECT id_local,id,extensio FROM foto WHERE id = (SELECT MAX(id) FROM foto)"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            Dim reader As MySqlDataReader = comanda.ExecuteReader()
            While reader.Read()
                Dim path As String = "C:\TappingFotos\local\" & reader("id_local") & ".txt"
                If File.Exists(path) Then
                    Using writer As New StreamWriter(path, True)
                        writer.WriteLine(reader("id") & "" & reader("extensio"))
                    End Using
                Else
                    Using writer As New StreamWriter(path)
                        writer.WriteLine(Now & "#" & reader("id_local"))
                        writer.WriteLine(reader("id") & "" & reader("extensio"))
                    End Using
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("Error 'ArxiuLocal' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    Public Sub PujarFoto(ByVal dades() As String)
        sentencia = "INSERT INTO foto (id_local,extensio) VALUES ('" & dades(0) & "','" & dades(1) & "')"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            comanda.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error 'PujarFoto' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    Public Function SelectFoto() As String
        sentencia = "SELECT MAX(id) FROM foto"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            Dim reader As MySqlDataReader = comanda.ExecuteReader()
            If reader.Read() Then
                Dim maxId As Integer = reader.GetInt32(0)
                Return maxId.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'SelectFoto' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
        Return 0
    End Function

    Public Sub DeleteFoto(ByVal id As String)
        sentencia = "DELETE FROM foto WHERE id = " & id
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            Dim reader As MySqlDataReader = comanda.ExecuteReader()
            If reader.Read() Then
                Dim maxId As Integer = reader.GetInt32(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'DeleteFoto' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
End Class