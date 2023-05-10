Public Class FormNoticiesAdmin
    Private Sub Form2NoticiesAdminvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem registres al datagridview
        Constants.bbdd.SelectAdmin(Constants.TAULANOTICIA, DataGridViewNoticies)
        'fiquem format data com a la base de dades
        DataGridViewNoticies.Columns(4).DefaultCellStyle.Format = "yyyy-MM-dd"
        DataGridViewNoticies.Columns(5).DefaultCellStyle.Format = "yyyy-MM-dd"
        DataGridViewNoticies.Columns(6).DefaultCellStyle.Format = "yyyy-MM-dd"
        buid()
        'fiquem columna descripcio con multilinea
        DataGridViewNoticies.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    'es fica la informació als textbox de la fila seleccionada
    Private Sub DataGridViewNoticies_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewNoticies.SelectionChanged
        TextBoxTitol.Text = DataGridViewNoticies.CurrentRow.Cells(1).Value
        TextBoxDescripcio.Text = DataGridViewNoticies.CurrentRow.Cells(2).Value
        TextBoxFoto.Text = DataGridViewNoticies.CurrentRow.Cells(3).Value
        DateTimePickerPublicacio.Text = DataGridViewNoticies.CurrentRow.Cells(4).Value
        DateTimePickerInici.Text = DataGridViewNoticies.CurrentRow.Cells(5).Value
        'si la data es null fiquem dia de avui
        If IsDBNull(DataGridViewNoticies.CurrentRow.Cells(6).Value) Then
            DateTimePickerFi.Text = Date.Today
        Else
            DateTimePickerFi.Text = DataGridViewNoticies.CurrentRow.Cells(6).Value
        End If
        RadioButtonModificar.Checked = True
        DataGridViewNoticies.Columns(0).Visible = False
    End Sub
    Private Sub RadioButtonAfegir_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAfegir.CheckedChanged
        If RadioButtonAfegir.Checked Then
            TextBoxTitol.Text = ""
            TextBoxDescripcio.Text = ""
            TextBoxFoto.Text = ""
            Me.DateTimePickerPublicacio.Text = Date.Today
            Me.DateTimePickerInici.Text = Date.Today
            Me.DateTimePickerFi.Text = Date.Today
        End If
    End Sub
    'Depenen de quin radiobutton estigui seleccionat farem una accio o un altra
    Private Sub ButtonAccio_Click(sender As Object, e As EventArgs) Handles ButtonAccio.Click
        If RadioButtonAfegir.Checked Then
            Constants.bbdd.InsertAdmin(Constants.TAULANOTICIA, EnviarDades(), DataGridViewNoticies)
            buid()
        ElseIf RadioButtonModificar.Checked Then
            Constants.bbdd.UpdateAdmin(Constants.TAULANOTICIA, EnviarDades(), EnviarId(), DataGridViewNoticies)
            buid()
        ElseIf RadioButtonEliminar.Checked Then
            'missatge de confirmacio 
            Dim r = MsgBox("Segur que vols eliminar aquest registre?", vbYesNo)
            If r = vbYes Then
                Constants.bbdd.Delete(Constants.TAULANOTICIA, DataGridViewNoticies, EnviarId())
                buid()
            End If
        End If
    End Sub
    'fiquem les dades en un array per enviar 
    Private Function EnviarDades() As String()
        Dim dades(5) As String
        dades(0) = TextBoxTitol.Text
        dades(1) = TextBoxDescripcio.Text
        dades(2) = TextBoxFoto.Text
        dades(3) = DateTimePickerPublicacio.Text
        dades(4) = DateTimePickerInici.Text
        'direm si vol ficar la data d'avui si data fi es null
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
    'enviem id de la fila seleccionada
    Private Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewNoticies.SelectedRows.Count > 0 Then
            id = DataGridViewNoticies.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function
    Private Sub buid()
        DataGridViewNoticies.ClearSelection()
        TextBoxTitol.Text = ""
        TextBoxDescripcio.Text = ""
        TextBoxFoto.Text = ""
        Me.DateTimePickerPublicacio.Text = Date.Today
        Me.DateTimePickerInici.Text = Date.Today
        Me.DateTimePickerFi.Text = Date.Today
        RadioButtonAfegir.Checked = True
    End Sub

    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Escriptori_Administradors.Show()
        Me.Close()
    End Sub

End Class