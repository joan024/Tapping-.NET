﻿Imports MySql.Data.MySqlClient

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
    Public Sub SelectAdmin(ByVal taula As String, ByVal dgv As DataGridView)
        sentencia = "SELECT * FROM " & taula
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
        End Select
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() Then
                SelectAdmin(taula, dgv)
            Else
                MsgBox("ERROR en fer la modificació", vbExclamation)
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
        End Select

        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() > 0 Then
                SelectAdmin(taula, dgv)
            Else
                MsgBox("ERROR al fer la inserció", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'InsertAdmin' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
    Public Sub Delete(ByVal taula As String, ByVal dgv As DataGridView, ByVal id As String)
        sentencia = "DELETE FROM " & taula & " WHERE id = " & id
        Try
            connectar()
            comanda = New MySqlCommand(sentencia, connexio)
            If comanda.ExecuteNonQuery() Then
                SelectAdmin(taula, dgv)
            Else
                MsgBox("ERROR en fer l'eliminació", vbExclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 'Delete' ClasseBBDD: " & ex.Message)
        Finally
            desconnectar()
        End Try
    End Sub
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
End Class