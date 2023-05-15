Public Class FormNoticiesAdmin
    Private Sub Form2NoticiesAdminvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem registres
        Constants.bbdd.SelectAdmin(Constants.TAULANOTICIA, DataGridViewNoticies)
        'fiquem format de la data com esta a la base de dades
        DataGridViewNoticies.Columns(4).DefaultCellStyle.Format = "yyyy-MM-dd"
        DataGridViewNoticies.Columns(5).DefaultCellStyle.Format = "yyyy-MM-dd"
        DataGridViewNoticies.Columns(6).DefaultCellStyle.Format = "yyyy-MM-dd"
        buid()
        'fiquem columna descripcio com multilinea
        DataGridViewNoticies.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    Private Sub DataGridViewNoticies_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewNoticies.SelectionChanged
        'es fica la informació als textboxs de la fila seleccionada
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
        'amagem columna id
        DataGridViewNoticies.Columns(0).Visible = False
    End Sub
    Private Sub RadioButtonAfegir_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAfegir.CheckedChanged
        'si selecciona afegir fiquem tot buid
        If RadioButtonAfegir.Checked Then
            TextBoxTitol.Text = ""
            TextBoxDescripcio.Text = ""
            TextBoxFoto.Text = ""
            Me.DateTimePickerPublicacio.Text = Date.Today
            Me.DateTimePickerInici.Text = Date.Today
            Me.DateTimePickerFi.Text = Date.Today
        End If
    End Sub
    Private Sub ButtonAccio_Click(sender As Object, e As EventArgs) Handles ButtonAccio.Click
        'Depenen de quin radiobutton estigui seleccionat farem una accio o un altra
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
    Private Function EnviarDades() As String()
        'fiquem les dades en un array per enviar a la funcio
        Dim dades(5) As String
        dades(0) = TextBoxTitol.Text
        dades(1) = TextBoxDescripcio.Text
        dades(2) = TextBoxFoto.Text
        dades(3) = DateTimePickerPublicacio.Text
        dades(4) = DateTimePickerInici.Text
        'si la data fi es data actual direm si la vol ficar, sino la fiquem buida
        If DateTimePickerFi.Text = Date.Today Then
            Dim r = MsgBox("Vols ficar la data d'avui per 'Data Fi'?", vbYesNo)
            If r = vbYes Then
                dades(5) = DateTimePickerFi.Text
            Else
                dades(5) = ""
            End If
        Else
            dades(5) = DateTimePickerFi.Text
        End If
        Return dades
    End Function
    Private Function EnviarId() As String
        'enviem id de la fila seleccionada
        Dim id As String = ""
        If DataGridViewNoticies.SelectedRows.Count > 0 Then
            id = DataGridViewNoticies.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function
    Private Sub buid()
        'fiquem tot buid i sense seleccio
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