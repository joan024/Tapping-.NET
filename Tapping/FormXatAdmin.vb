Imports MySql.Data.MySqlClient

Public Class FormXatAdmin
    Private Sub FormXatAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem empreses
        Constants.bbdd.SelectAdmin(Constants.TAULAXAT, DataGridViewEmpreses)
    End Sub
    Private Sub DataGridViewEmpreses_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewEmpreses.SelectionChanged
        'amagem columna de id empresa
        DataGridViewEmpreses.Columns(1).Visible = False
        'mostrem el nom del xat de la empresa seleccionada
        LabelXat.Text = DataGridViewEmpreses.CurrentRow.Cells(0).Value
        'carreguem els missatges de la empresa seleccionada
        Constants.bbdd.MissatgesXatAdmin(DataGridViewEmpreses.CurrentRow.Cells(0).Value, DataGridViewXat)
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
        'si les cel·les de la columna columna 0 conté un 1 fiquem text a la dreta
        If e.ColumnIndex = 1 And DataGridViewXat.Rows(e.RowIndex).Cells(0).Value.ToString() = "1" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub
    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        'si el xat no esta buit enviem missatge
        If DataGridViewXat.CurrentRow IsNot Nothing AndAlso DataGridViewXat.CurrentRow.Cells(2) IsNot Nothing Then
            Constants.bbdd.InsertMissatgeAdmin(DataGridViewXat.CurrentRow.Cells(2).Value, TextBoxXat.Text, DataGridViewEmpreses.CurrentRow.Cells(0).Value, DataGridViewXat)
        Else
            'sino busquem el id de xat per crear una nova linea de xat
            Dim dades(1) As String
            dades(0) = DataGridViewEmpreses.CurrentRow.Cells(1).Value
            Dim idXat As String = Constants.bbdd.SelectId(Constants.TAULAXAT, dades)
            Constants.bbdd.InsertMissatgeAdmin(idXat, TextBoxXat.Text, DataGridViewEmpreses.CurrentRow.Cells(0).Value, DataGridViewXat)
        End If
        'per quan carregui, el scroll es fiqui al final
        If DataGridViewXat.RowCount <> 0 Then
            DataGridViewXat.FirstDisplayedScrollingRowIndex = DataGridViewXat.Rows.Count - 1
        End If
        TextBoxXat.Text = ""
    End Sub
End Class