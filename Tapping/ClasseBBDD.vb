Imports System.Globalization
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

    Public Sub afegirAdmin(ByVal taula As String, ByVal dades() As String, ByVal dgv As DataGridView)
        Select Case taula
            Case "noticia"
                If dades.Length = 6 Then
                    sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "','" & dades(5) & "')"
                Else
                    sentencia = "INSERT INTO noticia (titol,descripcio,foto,data_publicacio,data_inici,data_fi) VALUES ('" & dades(0) & "','" & dades(1) & "','" & dades(2) & "','" & dades(3) & "','" & dades(4) & "')"
                End If
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
                MsgBox("ERROR al fer la inserció", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'afegirAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
End Class
