Imports MySql.Data.MySqlClient

Public Class FormXatAdmin
    Private bbdd As New ClasseBBDD
    Private Sub FormXatAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.XatsEmpresa(DataGridViewEmpreses)
        'DataGridViewEmpreses.ClearSelection()
    End Sub
    Private Sub DataGridViewEmpreses_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewEmpreses.SelectionChanged
        LabelXat.Text = DataGridViewEmpreses.CurrentRow.Cells(0).Value
        bbdd.MissatgesXatAdmin(DataGridViewEmpreses.CurrentRow.Cells(0).Value, DataGridViewXat)
    End Sub
    Private Sub DataGridViewXat_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewXat.SelectionChanged
        DataGridViewXat.ClearSelection()
        DataGridViewXat.Columns(0).Visible = False
        DataGridViewXat.Columns(2).Visible = False
    End Sub
    Private Sub DataGridViewXat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewXat.CellFormatting
        If e.ColumnIndex = 1 And DataGridViewXat.Rows(e.RowIndex).Cells(0).Value.ToString() = "1" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub
    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        bbdd.InsertMissatgeAdmin(DataGridViewXat.CurrentRow.Cells(2).Value, TextBoxXat.Text, DataGridViewEmpreses.CurrentRow.Cells(0).Value, DataGridViewXat)
        TextBoxXat.Text = ""
    End Sub
End Class