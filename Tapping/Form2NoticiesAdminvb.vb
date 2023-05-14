Imports System.IO
Imports System.Net

Public Class Form2NoticiesAdminvb
    Private taula As String = "noticia"
    Private bbdd As New ClasseBBDD
    Private Sub Form2NoticiesAdminvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.mostrarAdmin(taula, DataGridViewNoticies)
        DataGridViewNoticies.Columns(4).DefaultCellStyle.Format = "yyyy-MM-dd"
        DataGridViewNoticies.Columns(5).DefaultCellStyle.Format = "yyyy-MM-dd"
        DataGridViewNoticies.Columns(6).DefaultCellStyle.Format = "yyyy-MM-dd"
        DataGridViewNoticies.ClearSelection()
        buid()
    End Sub
    Private Sub DataGridViewNoticies_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewNoticies.SelectionChanged
        TextBoxTitol.Text = DataGridViewNoticies.CurrentRow.Cells(1).Value
        TextBoxDescripcio.Text = DataGridViewNoticies.CurrentRow.Cells(2).Value
        TextBoxFoto.Text = DataGridViewNoticies.CurrentRow.Cells(3).Value
        DateTimePickerPublicacio.Text = DataGridViewNoticies.CurrentRow.Cells(4).Value
        DateTimePickerInici.Text = DataGridViewNoticies.CurrentRow.Cells(5).Value
        If IsDBNull(DataGridViewNoticies.CurrentRow.Cells(6).Value) Then
            DateTimePickerFi.Text = Date.Today
        Else
            DateTimePickerFi.Text = DataGridViewNoticies.CurrentRow.Cells(6).Value
        End If
    End Sub
    Private Sub RadioButtonAfegir_Click(sender As Object, e As EventArgs) Handles RadioButtonAfegir.Click
        DataGridViewNoticies.ClearSelection()
        buid()
    End Sub
    'Private Sub ButtonAccio_Click(sender As Object, e As EventArgs) Handles ButtonAccio.Click
    '    If RadioButtonAfegir.Checked Then
    '        bbdd.afegirAdmin(taula, EnviarDades(), DataGridViewNoticies)
    '    ElseIf RadioButtonModificar.Checked Then
    '        bbdd.modificarAdmin(taula, EnviarDades(), EnviarId(), DataGridViewNoticies)
    '    ElseIf RadioButtonEliminar.Checked Then
    '        Dim r = MsgBox("Segur que vols eliminar aquest registre?", vbYesNo)
    '        If r = vbYes Then
    '            bbdd.eliminar(taula, DataGridViewNoticies, EnviarId())
    '        End If
    '    End If
    'End Sub
    Private Function EnviarDades() As String()
        Dim dades(5) As String
        dades(0) = TextBoxTitol.Text
        dades(1) = TextBoxDescripcio.Text
        dades(2) = TextBoxFoto.Text
        dades(3) = DateTimePickerPublicacio.Text
        dades(4) = DateTimePickerInici.Text
        If DateTimePickerFi.Text = Date.Today Then
            Dim r = MsgBox("Vols ficar la data d'avui per 'Data Fi'?", vbYesNo)
            If r = vbYes Then
                dades(5) = DateTimePickerFi.Text
            Else
                dades(5) = ""
            End If
        End If
        Return dades
    End Function
    Private Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewNoticies.SelectedRows.Count > 0 Then
            id = DataGridViewNoticies.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function
    Private Sub buid()
        TextBoxTitol.Text = ""
        TextBoxDescripcio.Text = ""
        TextBoxFoto.Text = ""
        Me.DateTimePickerPublicacio.Text = Date.Today
        Me.DateTimePickerInici.Text = Date.Today
        Me.DateTimePickerFi.Text = Date.Today
    End Sub
End Class