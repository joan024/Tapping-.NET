Public Class FormPFAdmin
    Private Sub FormPFAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem els registres
        Constants.bbdd.SelectAdmin(Constants.TAULAPREGUNTAFREQUENT, DataGridViewPF)
        buid()
    End Sub
    Private Sub DataGridViewPF_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPF.SelectionChanged
        'fiquem les dades de la fila seleccionada
        TextBoxPregunta.Text = DataGridViewPF.CurrentRow.Cells(1).Value
        TextBoxResposta.Text = DataGridViewPF.CurrentRow.Cells(2).Value
        DataGridViewPF.Columns(0).Visible = False
        RadioButtonModificar.Checked = True
    End Sub
    Private Sub RadioButtonAfegir_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAfegir.CheckedChanged
        If RadioButtonAfegir.Checked Then
            TextBoxPregunta.Text = ""
            TextBoxResposta.Text = ""
        End If
    End Sub
    Private Sub ButtonAccio_Click(sender As Object, e As EventArgs) Handles ButtonAccio.Click
        'depenen de quin radio button esta seleccionat farem una accio diferent
        If RadioButtonAfegir.Checked Then
            Constants.bbdd.InsertAdmin(Constants.TAULAPREGUNTAFREQUENT, EnviarDades(), DataGridViewPF)
            buid()
        ElseIf RadioButtonModificar.Checked Then
            Constants.bbdd.UpdateAdmin(Constants.TAULAPREGUNTAFREQUENT, EnviarDades(), EnviarId(), DataGridViewPF)
            buid()
        ElseIf RadioButtonEliminar.Checked Then
            'missatge de confirmacio
            Dim r = MsgBox("Segur que vols eliminar aquest registre?", vbYesNo)
            If r = vbYes Then
                Constants.bbdd.Delete(Constants.TAULAPREGUNTAFREQUENT, DataGridViewPF, EnviarId())
                buid()
            End If
        End If
    End Sub
    Private Function EnviarDades() As String()
        'fiquem les dades en un array per enviar
        Dim dades(2) As String
        dades(0) = TextBoxPregunta.Text
        dades(1) = TextBoxResposta.Text
        Return dades
    End Function
    Private Function EnviarId() As String
        'enviem id de la fila seleccionada
        Dim id As String = ""
        If DataGridViewPF.SelectedRows.Count > 0 Then
            id = DataGridViewPF.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function
    Private Sub buid()
        'fiquem tot buid i sense seleccio
        DataGridViewPF.ClearSelection()
        TextBoxPregunta.Text = ""
        TextBoxResposta.Text = ""
        RadioButtonAfegir.Checked = True
    End Sub

    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Escriptori_Administradors.Show()
        Me.Close()
    End Sub

End Class