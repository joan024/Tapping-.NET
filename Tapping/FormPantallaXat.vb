Public Class FormPantallaXat
    Dim bbdd As New ClasseBBDD
    Private Sub FormPantallaXat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  bbdd.MissatgesXatEmpresa(6, DataGridViewXat)
    End Sub
    Private Sub DataGridViewXat_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewXat.SelectionChanged
        DataGridViewXat.ClearSelection()
        DataGridViewXat.Columns(0).Visible = False
        DataGridViewXat.Columns(2).Visible = False
    End Sub
    Private Sub DataGridViewXat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewXat.CellFormatting
        If e.ColumnIndex = 1 AndAlso DataGridViewXat.Rows(e.RowIndex).Cells(0).Value.ToString() = "2" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub
    'Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
    '    bbdd.InsertMissatgeEmpresa(DataGridViewXat.CurrentRow.Cells(2).Value, TextBoxXat.Text, 6, DataGridViewXat)
    '    TextBoxXat.Text = ""
    'End Sub
End Class