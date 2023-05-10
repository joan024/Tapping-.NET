Imports System.IO
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto

Public Class ClasseBBDD
    Private connexio As MySqlConnection
    Private adapter As MySqlDataAdapter
    Private comanda As New MySqlCommand
    Private table As DataTable
    Private reader As MySqlDataReader
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
        Catch ex As Exception
            MessageBox.Show("Error en 'connectar' ClasseBBDD: " & ex.Message)
        End Try
    End Sub
    Private Sub desconnectar()
        If connexio.State = 1 Then
            connexio.Dispose()
        End If
    End Sub

    'FUNCIONS LOGIN
    Public Function comprovacioLogin(ByVal taula As String)
        ' segons el tipus d'usuari aplica una query i la guarda a la variable sentencia
        Select Case taula
            Case Constants.TAULAADMIN
                sentencia = Constants.QUERYADMIN & Constants.IDUSUARI
            Case Constants.TAULAEMPRESA
                sentencia = Constants.QUERYEMPRESA & Constants.IDUSUARI
            Case Constants.TAULAUSUARI
                sentencia = "SELECT id,correu,contrasenya,actiu FROM usuari"
        End Select

        Try
            ' hi ho busca a la base de dades
            connectar()
            Dim comando As New MySqlCommand(sentencia, connexio)
            reader = comando.ExecuteReader()
            ' si de la base de dades no retorna res, enviaré un que sigui null
            If Not reader.HasRows Then
                reader = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR LOGIN")
        End Try
        Return reader
    End Function

    Public Sub UpdateContrasenya(ByVal contrasenya As String, ByVal idUsuari As String)
        sentencia = "UPDATE usuari SET contrasenya = '" & contrasenya & "' where id = " & idUsuari
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            comanda.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error 'UpdateAdmin' ClasseBBDD: " & ex.Message)
        End Try
    End Sub

    'FUNCIONS ADMIN
    Public Sub SelectAdmin(ByVal taula As String, ByVal dgv As DataGridView)
        Select Case taula
            Case Constants.TAULANOTICIA
                sentencia = "SELECT * FROM noticia"
            Case Constants.TAULAPREGUNTAFREQUENT
                sentencia = "SELECT * FROM preguntafrequent"
            Case Constants.TAULAEMPRESA
                sentencia = "SELECT id_usuari,nif,telefon,pack,usuari.nom, usuari.correu, usuari.actiu FROM empresa INNER JOIN usuari on empresa.id_usuari = usuari.id where usuari.actiu = 1"
            Case Constants.TAULATAPA
                sentencia = "SELECT tapa.id AS id_tapa,tapa.nom AS Tapa, categoria.nom AS Categoria FROM tapa JOIN categoria_tapa ON tapa.id = categoria_tapa.id_tapa JOIN categoria ON categoria_tapa.id_categoria = categoria.id"
            Case Constants.TAULACATEGORIA
                sentencia = "SELECT * FROM categoria"
            Case Constants.TAULAUSUARI
                sentencia = "SELECT nom FROM usuari INNER JOIN xat ON usuari.id = xat.id_empresa"
            Case Constants.TAULALINEAXAT

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
            Case Constants.TAULANOTICIA
                If dades(5) = "" Then
                    sentencia = "UPDATE noticia SET titol = '" & dades(0) & "', descripcio = '" & dades(1) & "', foto = '" & dades(2) & "', data_publicacio = '" & dades(3) & "', data_inici = '" & dades(4) & "', data_fi = NULL WHERE id = " & id
                Else
                    sentencia = "UPDATE noticia SET titol = '" & dades(0) & "', descripcio = '" & dades(1) & "', foto = '" & dades(2) & "', data_publicacio = '" & dades(3) & "', data_inici = '" & dades(4) & "', data_fi = '" & dades(5) & "' WHERE id = " & id
                End If

            Case Constants.TAULAPREGUNTAFREQUENT
                sentencia = "UPDATE preguntafrequent SET pregunta = '" & dades(0) & "', resposta = '" & dades(1) & "' WHERE id = " & id
            Case Constants.TAULAEMPRESA
                sentencia = "UPDATE empresa SET nif = '" & dades(0) & "', telefon = '" & dades(1) & "', pack = '" & dades(2) & "' WHERE id_usuari = " & id
            Case Constants.TAULATAPA
                sentencia = "UPDATE tapa SET nom = '" & dades(0) & "' WHERE id = " & id
            Case Constants.TAULACATEGORIA
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
            Case Constants.TAULANOTICIA
                If dades(5) = "" Then
                    sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "', NULL)"
                Else
                    sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "','" & dades(5) & "')"
                End If
            Case Constants.TAULAPREGUNTAFREQUENT
                sentencia = "INSERT INTO preguntafrequent (pregunta,resposta) VALUES ('" & dades(0) & "','" & dades(1) & "')"
            Case Constants.TAULACATEGORIA
                sentencia = "INSERT INTO categoria (nom) VALUES ('" & dades(0) & "')"
            Case Constants.TAULAEMPRESA
                sentencia = "INSERT INTO empresa (id_usuari,nif,telefon,pack) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "')"
            Case Constants.TAULAUSUARI
                sentencia = "INSERT INTO usuari(nom,correu,contrasenya,data_registre,actiu) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "')"
            Case Constants.TAULATAPA
                sentencia = "INSERT INTO tapa(nom) VALUES ('" & dades(0) & "')"
            Case Constants.TAULACATEGORIATAPA
                sentencia = "INSERT INTO categoria_tapa(id_categoria, id_tapa) VALUES ('" & dades(0) & "','" & dades(1) & "')"
        End Select

        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 And Not taula.Equals("empresa") Then
                SelectAdmin(taula, dgv)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'InsertAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub Delete(ByVal taula As String, ByVal dgv As DataGridView, ByVal id As String)
        Select Case taula
            Case Constants.TAULANOTICIA
                sentencia = "DELETE FROM noticia WHERE id = " & id
            Case Constants.TAULAPREGUNTAFREQUENT
                sentencia = "DELETE FROM preguntafrequent WHERE id = " & id
            Case Constants.TAULAUSUARI
                ' en aquest cas actualitzo l'actiu a 0 en comptes d'eliminar
                sentencia = "UPDATE usuari SET actiu = 0 where id = " & id
            Case Constants.TAULACATEGORIATAPA
                sentencia = "DELETE FROM categoria_tapa where id_tapa = " & id
            Case Constants.TAULATAPA
                sentencia = "DELETE FROM tapa where id = " & id
            Case Constants.TAULACATEGORIA
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
            Case Constants.TAULAUSUARI
                sentencia = "SELECT id FROM usuari WHERE nom='" & dades(0) & "' AND correu='" & dades(1) & "' AND contrasenya='" & dades(2) & "' AND data_registre='" & dades(3) & "' AND actiu='" & dades(4) & "'"
            Case Constants.TAULAEMPRESA
                sentencia = "SELECT id FROM empresa WHERE nif='" & dades(0) & "' AND telefon='" & dades(1) & "' AND pack='" & dades(2) & "'"
            Case Constants.TAULATAPA
                sentencia = "SELECT MAX(id) FROM tapa"
            Case Constants.TAULACATEGORIA
                sentencia = "SELECT id FROM categoria WHERE nom='" & dades(0) & "'"
        End Select

        Try
            table = New DataTable
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            reader = comanda.ExecuteReader()
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
    Public Function Pack() As String
        Dim packEmpresa As String = ""
        sentencia = "SELECT pack FROM empresa WHERE id_usuari = " & Constants.IDUSUARI
        Try
            connectar()
            Dim comando As New MySqlCommand(sentencia, connexio)
            reader = comando.ExecuteReader()
            If reader.Read Then
                packEmpresa = reader.GetString(0)
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR PACK")
        End Try
        Return packEmpresa
    End Function
    Public Function PantallaEmpresa(ByVal id As String)
        sentencia = "SELECT empresa.nif, empresa.telefon, usuari.nom, usuari.correu FROM empresa INNER JOIN usuari ON empresa.id_usuari = usuari.id WHERE usuari.id = " & id
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            reader = comanda.ExecuteReader()
        Catch ex As Exception
            MsgBox("ERROR en carregar la informació", vbExclamation)
        End Try
        Return reader
    End Function
    Public Sub SelectEmpresa(ByVal taula As String, ByVal id As String, ByVal dgv As DataGridView)
        Select Case taula
            Case Constants.TAULANOTICIA
                sentencia = "SELECT titol,descripcio,foto FROM noticia WHERE data_inici <= '" & Format(Date.Today, "yyyy-MM-dd") & "' AND (data_fi >= '" & Format(Date.Today, "yyyy-MM-dd") & "' OR data_fi IS NULL)"
            Case Constants.TAULAPREGUNTAFREQUENT
                sentencia = "SELECT pregunta,resposta FROM preguntafrequent"
            Case Constants.TAULAVALORACIO
                sentencia = "SELECT puntuacio,comentari FROM valoracio WHERE id_local = '" & id & "'"
            Case Constants.TAULAEMPRESA
                sentencia = "SELECT nom,direccio,telefon,descripcio,web FROM local WHERE id_usuari = '" & id & "'"
            Case Constants.TAULALINEAXAT
                sentencia = "SELECT lineaxat.usuari,lineaxat.missatge,lineaxat.id_xat FROM lineaxat INNER JOIN xat ON lineaxat.id_xat = xat.id WHERE xat.id_empresa = '" & id & "'"
        End Select
        Try
            table = New DataTable
            connectar()
            adapter = New MySqlDataAdapter(sentencia, connexio)
            adapter.Fill(table)
            dgv.DataSource = table
        Catch ex As Exception
            MsgBox("Error en carregar dades", vbExclamation)
        Finally
            desconnectar()
        End Try
    End Sub

    'FUNCIONS PER XAT EMPRESA
    Public Sub InsertMissatgeEmpresa(ByVal idXat As String, ByVal missatge As String, ByVal id As String, ByVal dgv As DataGridView)
        sentencia = "INSERT INTO lineaxat (id_xat,usuari,missatge,temps) VALUES (" & idXat & ",2,'" & missatge & "','" & Format(Date.Today, "yyyy-MM-dd") & "')"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 Then
                SelectEmpresa(Constants.TAULALINEAXAT, id, dgv)
            End If
        Catch ex As Exception
            MsgBox("ERROR en enviar el missatge", vbExclamation)
        Finally
            desconnectar()
        End Try
    End Sub

    'FUNCIONS ARXIU
    Public Sub SelectIdLocal()
        sentencia = "SELECT id FROM local WHERE id_usuari = " & Constants.IDUSUARI
        Try
            connectar()
            Dim comando As New MySqlCommand(sentencia, connexio)
            reader = comando.ExecuteReader()
            While reader.Read()
                Constants.IDLOCAL = reader.GetString(0)
            End While
        Catch ex As Exception
            MsgBox("ERROR en carregar la informació", vbExclamation)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub ArxiuLocal()
        sentencia = "SELECT id_local,id,extensio FROM foto WHERE id = (SELECT MAX(id) FROM foto)"
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            reader = comanda.ExecuteReader()
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
            reader = comanda.ExecuteReader()
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
            reader = comanda.ExecuteReader()
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