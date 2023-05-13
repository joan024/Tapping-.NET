Public Class FormDescomptes
    Private Sub FormDescomptes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carreguem descomptes del local
        Constants.bbdd.SelectEmpresa(Constants.TAULADESCOMPTE, Constants.IDLOCAL, DataGridViewDescomptes)
        'canviem format de la data per com esta a la base de dades
        If DataGridViewDescomptes.Rows.Count > 0 Then
            DataGridViewDescomptes.Columns(1).DefaultCellStyle.Format = "yyyy-MM-dd"
            DataGridViewDescomptes.Columns(2).DefaultCellStyle.Format = "yyyy-MM-dd"
        End If
        buid()
    End Sub
    Private Sub DataGridViewDescomptes_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewDescomptes.SelectionChanged
        'perque no pugi seleccionar res
        DataGridViewDescomptes.ClearSelection()
    End Sub
    Private Sub ButtonGenerar_Click(sender As Object, e As EventArgs) Handles ButtonGenerar.Click
        Dim caracters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()"
        Dim codi As String = ""

        'fem un random de 10 caracters per generar codi descompte
        Randomize()
        For i = 1 To 10
            Dim index As Integer = Int((Len(caracters) * Rnd()) + 1)
            codi = codi & Mid(caracters, index, 1)
        Next
        'fiquem el codi random al textbox del codi
        TextBoxCodi.Text = codi
    End Sub
    Private Sub ButtonAccio_Click(sender As Object, e As EventArgs) Handles ButtonAccio.Click
        'fer la inserció de les dades donades
        Constants.bbdd.InsertEmpresa(Constants.TAULADESCOMPTE, EnviarDades(), DataGridViewDescomptes)
        buid()
    End Sub
    Private Function EnviarDades() As String()
        'fiquem les dades en un array per enviar a la funcio 
        Dim dades(5) As String
        dades(0) = Constants.IDLOCAL
        dades(1) = TextBoxText.Text
        dades(2) = DateTimePickerInici.Text
        dades(3) = DateTimePickerFinal.Text
        dades(4) = TextBoxCodi.Text
        Return dades
    End Function
    Private Sub buid()
        'fiquem tot buid
        DataGridViewDescomptes.ClearSelection()
        TextBoxText.Text = ""
        DateTimePickerInici.Text = Date.Today
        DateTimePickerFinal.Text = Date.Today
        TextBoxCodi.Text = ""
    End Sub
End Class