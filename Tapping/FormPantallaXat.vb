Public Class FormPantallaXat
    Private Sub FormPantallaXat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem els missatges de la empresa
        Constants.bbdd.SelectEmpresa(Constants.TAULALINEAXAT, Constants.IDUSUARI, DataGridViewXat)
        'si hi ha un scroll que es fiqui al final
        If DataGridViewXat.RowCount <> 0 Then
            DataGridViewXat.FirstDisplayedScrollingRowIndex = DataGridViewXat.Rows.Count - 1
        End If
    End Sub
    Private Sub DataGridViewXat_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewXat.SelectionChanged
        'fem aixo perque no surti la seleccio al fer clic al text del xat
        DataGridViewXat.ClearSelection()
        'amaguem columnes del xat
        DataGridViewXat.Columns(0).Visible = False
        DataGridViewXat.Columns(2).Visible = False
    End Sub
    Private Sub DataGridViewXat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewXat.CellFormatting
        'si les cel·les de la columna columna 0 conté un 2 fiquem text a la dreta
        If e.ColumnIndex = 1 AndAlso DataGridViewXat.Rows(e.RowIndex).Cells(0).Value.ToString() = "2" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub
    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        'si el xat no esta buit enviem missatge
        If DataGridViewXat.CurrentRow IsNot Nothing AndAlso DataGridViewXat.CurrentRow.Cells(2) IsNot Nothing Then
            Constants.bbdd.InsertMissatgeEmpresa(DataGridViewXat.CurrentRow.Cells(2).Value, TextBoxXat.Text, Constants.IDUSUARI, DataGridViewXat)
        Else
            'sino busquem el id de xat per crear una nova linea de xat
            Dim dades(1) As String
            dades(0) = Constants.IDUSUARI
            Dim idXat As String = Constants.bbdd.SelectId(Constants.TAULAXAT, dades)
            Constants.bbdd.InsertMissatgeEmpresa(idXat, TextBoxXat.Text, Constants.IDUSUARI, DataGridViewXat)
        End If
        'per quan carregui, el scroll es fiqui al final
        If DataGridViewXat.RowCount <> 0 Then
            DataGridViewXat.FirstDisplayedScrollingRowIndex = DataGridViewXat.Rows.Count - 1
        End If
        TextBoxXat.Text = ""
    End Sub
End Class