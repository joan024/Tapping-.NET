Imports System.Globalization
Imports Google.Protobuf.Collections
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class ClasseBBDD
    Private connexio As MySqlConnection
    Private adapter As MySqlDataAdapter
    Private comanda As New MySqlCommand
    Private table As DataTable
    Private sentencia As String
    Private reader As MySqlDataReader
    Private Sub connectar()
        Try
            connexio = New MySqlConnection
            With connexio
                'Local
                .ConnectionString = "server=192.168.1.150; user id=tapping; password=JuMaJoJo!!25231; database=tappingDB; port=25230;Convert Zero Datetime=True;"
                'Remot
                '.ConnectionString = "server=webapps.insjoanbrudieu.cat; user id=tapping; password=JuMaJoJo!!25231; database=tappingDB; port=25230;Convert Zero Datetime=True;"
                'Localhost
                '.ConnectionString = "server=localhost; user id=root; password=admin123; database=tapping; port=3306;Convert Zero Datetime=True;"
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
    Public Function obtenirId(ByVal taula As String)
        Select Case taula
            Case Constants.TAULALOCAL
                sentencia = "SELECT id FROM local WHERE id_usuari =" & Constants.IDUSUARI
            Case Constants.TAULATAPA
                sentencia = "SELECT id FROM tapa WHERE nom =""" & Constants.NOMTAPA & """"
            Case Constants.TAULALOCALTAPA
                'sentencia = "SELECT id FROM local_tapa WHERE id_local =""" & Constants.IDLOCAL & """"
                sentencia = "SELECT id FROM local_tapa WHERE id_local =" & Constants.IDLOCAL & " AND id_tapa = '" & Constants.IDTAPA & "'"
            Case "local2"
                sentencia = "SELECT id FROM local WHERE id_usuari =" & Constants.IDUSUARI & " AND nom = '" & Constants.NOMLOCAL & "'"
        End Select
        Try
            table = New DataTable
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            reader = comanda.ExecuteReader()
            If reader.Read() Then
                Select Case taula
                    Case Constants.TAULALOCAL
                        Constants.IDLOCAL = reader.GetString(0)
                    Case Constants.TAULATAPA
                        Constants.IDTAPA = reader.GetString(0)
                    Case Constants.TAULALOCALTAPA
                        Constants.IDLOCALTAPA = reader.GetString(0)
                    Case "local2"
                        Constants.IDLOCAL = reader.GetString(0)
                End Select

            End If

        Catch ex As Exception
            MessageBox.Show("Error en 'mostrarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
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
            MessageBox.Show("Error en 'mostrarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub mostrarTapa(ByVal taula As String, ByVal dgv As DataGridView)
        sentencia = Constants.QUERYTAPA
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
    Public Sub mostrarLocal(ByVal taula As String, ByVal dgv As DataGridView)
        sentencia = Constants.QUERYLOCAL + Constants.IDUSUARI
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
    Public Function obtenirNoms(ByVal taula As String) As ArrayList
        Dim llistaNoms As New ArrayList
        Select Case taula
            Case Constants.TAULATAPA
                sentencia = "SELECT nom FROM tapa"
            Case Constants.TAULALOCAL
                'la comanda comentada es la bona
                'sentencia = "SELECT nom FROM local WHERE id_usuari =" & Constants.IDUSUARI
                sentencia = "SELECT nom FROM local WHERE id_usuari = 15"
        End Select

        Try
            table = New DataTable
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            reader = comanda.ExecuteReader()
            While reader.Read()
                llistaNoms.Add(reader.GetString(0))
            End While

        Catch ex As Exception
            MessageBox.Show("Error en 'mostrarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
        Return llistaNoms
    End Function

    Public Sub modificarAdmin(ByVal taula As String, ByVal dgv As DataGridView, ByVal numColMod As Integer, ByVal text As String, ByVal numColId As Integer, ByVal id As Integer)
        sentencia = "UPDATE " & taula & " SET " & dgv.Columns(numColMod).Name & "= '" & text & "' WHERE " & dgv.Columns(numColId).Name & " = " & id
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
    Public Sub actualitzarTapa(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView)
        sentencia = "UPDATE " & Constants.TAULALOCALTAPA & " SET personalitzacio = '" & dades(0) & "', preu = '" & dades(1) & "' WHERE id = " & Constants.IDLOCALTAPA
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            comanda.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en 'modificarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub eliminarTapa(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView)
        'sentencia = "UPDATE " & Constants.TAULALOCALTAPA & " SET personalitzacio = '" & dades(0) & "', preu = '" & dades(1) & "' WHERE id = " & Constants.IDLOCALTAPA
        sentencia = "DELETE FROM " & Constants.TAULALOCALTAPA & " WHERE id = " & Constants.IDLOCALTAPA
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            comanda.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en 'modificarAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub

    Public Sub afegirAdmin(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView)
        Select Case taula
            Case Constants.TAULALOCALTAPA
                sentencia = "INSERT INTO local_tapa (id_local,id_tapa,personalitzacio,preu) VALUES ('" & Constants.IDLOCAL & "','" & Constants.IDTAPA & "','" & dades(0) & "','" & dades(1) & "')"
        End Select

        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            comanda.ExecuteNonQuery()
            mostrarAdmin(Constants.TAULALOCALTAPA, dgv)
        Catch ex As Exception
            MessageBox.Show("Error 'afegirAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
End Class