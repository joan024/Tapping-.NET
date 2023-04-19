Public Class FormPFAdmin
    Private taula As String = "preguntafrequent"
    Private bbdd As New ClasseBBDD
    Private Sub FormPFAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.mostrarAdmin(taula, DataGridViewPF)
        DataGridViewPF.ClearSelection()
        buid()
    End Sub
    Private Sub DataGridViewPF_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPF.SelectionChanged
        TextBoxPregunta.Text = DataGridViewPF.CurrentRow.Cells(1).Value
        TextBoxResposta.Text = DataGridViewPF.CurrentRow.Cells(2).Value
    End Sub
    Private Sub RadioButtonAfegir_Click(sender As Object, e As EventArgs) Handles RadioButtonAfegir.Click
        DataGridViewPF.ClearSelection()
        buid()
    End Sub
    Private Sub ButtonAccio_Click(sender As Object, e As EventArgs) Handles ButtonAccio.Click
        If RadioButtonAfegir.Checked Then
            bbdd.afegirAdmin(taula, EnviarDades(), DataGridViewPF)
        ElseIf RadioButtonModificar.Checked Then
            bbdd.modificarAdmin(taula, EnviarDades(), EnviarId(), DataGridViewPF)
        ElseIf RadioButtonEliminar.Checked Then
        Dim r = MsgBox("Segur que vols eliminar aquest registre?", vbYesNo)
            If r = vbYes Then
                bbdd.eliminar(taula, DataGridViewPF, EnviarId())
            End If
        End If
    End Sub
    Private Function EnviarDades() As String()
        Dim dades(2) As String
        dades(0) = TextBoxPregunta.Text
        dades(1) = TextBoxResposta.Text
        Return dades
    End Function
    Private Function EnviarId() As String
        Dim id As String = ""
        If DataGridViewPF.SelectedRows.Count > 0 Then
            id = DataGridViewPF.CurrentRow.Cells(0).Value
        End If
        Return id
    End Function
    Private Sub buid()
        TextBoxPregunta.Text = ""
        TextBoxResposta.Text = ""
    End Sub
End Class