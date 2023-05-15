Imports System.ComponentModel
Imports System.Reflection.Metadata

Public Class ElsMeusLocals
    Private bbdd As New ClasseBBDD

    Private Sub ElsMeusLocals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem local si en te
        bbdd.SelectEmpresa(Constants.TAULALOCAL, Constants.IDUSUARI, DataGridViewLocals)
        buid()
        'si te un local no deixem afegir mes
        If DataGridViewLocals.RowCount > 0 Then
            RadioButtonAfegir.Visible = False
        End If
    End Sub
    Private Sub GridViewLocals_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewLocals.SelectionChanged
        'fiquem les dades seleccionades al textbox
        TextBoxNom.Text = DataGridViewLocals.CurrentRow.Cells(1).Value
        TextBoxDireccio.Text = DataGridViewLocals.CurrentRow.Cells(2).Value
        TextBoxTelefon.Text = DataGridViewLocals.CurrentRow.Cells(3).Value
        If IsDBNull(DataGridViewLocals.CurrentRow.Cells(4).Value) Then
            TextBoxDescripcio.Text = ""
        Else
            TextBoxDescripcio.Text = DataGridViewLocals.CurrentRow.Cells(4).Value
        End If
        If IsDBNull(DataGridViewLocals.CurrentRow.Cells(5).Value) Then
            TextBoxWeb.Text = ""
        Else
            TextBoxWeb.Text = DataGridViewLocals.CurrentRow.Cells(5).Value
        End If
        DataGridViewLocals.Columns(0).Visible = False
    End Sub
    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        'depenen del radiobutton seleccionar fem una accio
        If RadioButtonAfegir.Checked Then
            Constants.bbdd.InsertEmpresa(Constants.TAULALOCAL, EnviarDades, DataGridViewLocals)
            RadioButtonAfegir.Visible = False
        ElseIf RadioButtonActualitzar.Checked Then
            Constants.bbdd.UpdateEmpresa(Constants.TAULALOCAL, EnviarDades, DataGridViewLocals.CurrentRow.Cells(0).Value, DataGridViewLocals)
        End If
    End Sub
    Private Function EnviarDades() As String()
        'array per enviar dades a la funcio
        Dim dades(5) As String
        dades(0) = TextBoxNom.Text
        dades(1) = TextBoxDireccio.Text
        dades(2) = TextBoxTelefon.Text
        dades(3) = TextBoxDescripcio.Text
        dades(4) = TextBoxWeb.Text
        Return dades
    End Function
    Private Sub buid()
        DataGridViewLocals.ClearSelection()
        TextBoxNom.Text = ""
        TextBoxDireccio.Text = ""
        TextBoxTelefon.Text = ""
        TextBoxDescripcio.Text = ""
        TextBoxWeb.Text = ""
    End Sub
    'obtenim id local afegit
    Private Sub ElsMeusLocals_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim dades(1) As String
        dades(0) = Constants.IDUSUARI
        Constants.IDLOCAL = Constants.bbdd.SelectId(Constants.TAULALOCAL, dades)
    End Sub
End Class