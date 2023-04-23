Imports System.Runtime.CompilerServices

Public Class Escriptori_Administradors
    Dim mostrarClients As New GridViewClients
    Dim mostrarTapes As New GridViewTapes
    Private bbdd As New ClasseBBDD
    Private control As Boolean

    Private Sub Escriptori_Administradors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Panel2.Visible = False
    End Sub

    ' quan en el menu fa click a clients:
    Private Sub ClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem.Click
        control = True
        opcioClient()
        mostrarClients.selectAdmin()

        'en el addhandler li afegeixo la opcio selectionchanged perquè desprès a la corresponent funcio pugui fer servir les dades
        AddHandler mostrarClients.DataGridViewClients.SelectionChanged, AddressOf MostrarClients_DataGridViewSelectionChanged
    End Sub

    ' quan en el menu fa click a tapes:
    Private Sub TapesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TapesToolStripMenuItem.Click
        control = False
        opcioTapes()
    End Sub

    Private Sub XatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XatToolStripMenuItem.Click
        FormXatAdmin.Show()
        Panel2.Visible = False
    End Sub

    Private Sub NotíciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotíciesToolStripMenuItem.Click
        Form2NoticiesAdminvb.Show()
        Panel2.Visible = False
    End Sub

    Private Sub PreguntesFrequentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntesFrequentsToolStripMenuItem.Click
        FormPFAdmin.Show()
        Panel2.Visible = False
    End Sub

    ' aquesta funcio serveix per actualitzar els camps cada cop que fa click damunt d'una fila
    Private Sub MostrarClients_DataGridViewSelectionChanged(sender As Object, e As EventArgs)
        TextBoxNif.Text = mostrarClients.DataGridViewClients.CurrentRow.Cells(1).Value
        TextBoxTelefon.Text = mostrarClients.DataGridViewClients.CurrentRow.Cells(2).Value
        TextBoxPack.Text = mostrarClients.DataGridViewClients.CurrentRow.Cells(3).Value
    End Sub


    Protected Sub opcioClient()
        ' aixo ho faig per quan s'inicia
        Label1.Text = "CLIENTS"
        mostrarTapes.Hide()
        Label1.Visible = True
        mostrarClients.TopLevel = False
        mostrarClients.Show()
        Panel1.Controls.Add(mostrarClients)
        Panel2.Visible = True
        ' aixo ho faig per quan canvio de tapes a clients
        LabelNif.Text = "NIF"
        LabelPack.Visible = True
        LabelTelefon.Visible = True
        TextBoxPack.Visible = True
        TextBoxTelefon.Visible = True
    End Sub
    Protected Sub opcioTapes()
        ' aixo ho faig per quan s'inicia
        Label1.Text = "TAPES"
        mostrarClients.Hide()
        Label1.Visible = True
        mostrarTapes.TopLevel = False
        mostrarTapes.Show()
        Panel1.Controls.Add(mostrarTapes)
        Panel2.Visible = True
        ' aixo ho faig per quan canvio de tapes a clients
        LabelNif.Text = "NOM"
        LabelPack.Visible = False
        LabelTelefon.Visible = False
        TextBoxPack.Visible = False
        TextBoxTelefon.Visible = False
    End Sub

    Private Sub ButtonConfirmar_Click(sender As Object, e As EventArgs) Handles ButtonConfirmar.Click
        Dim dades(3) As String
        dades(0) = TextBoxNif.Text
        dades(1) = TextBoxTelefon.Text
        dades(2) = TextBoxPack.Text

        If RadioButtonAfegir.Checked Then
            ' el formAfegirUsuari l'utilitzo perquè abans d'afegir una nova empresa tinc que afegir-lo com a usuari i aquet té més dades que necessito.
            ' aquestes dades les demano en un formulari que l'executu amb el DialogResult
            Dim formUsuari As New FormAfegirUsuari
            Dim result As DialogResult = formUsuari.ShowDialog(Me)
            Dim idUsuari As String = ""
            If result = DialogResult.OK Then
                ' en la seguent funcio afegeixo un nou usuari i retorno la id d'aquest usuari per desprès poder afegir l'empresa
                idUsuari = mostrarClients.insertUser(formUsuari.TextBoxNom.Text, formUsuari.TextBoxCorreu.Text, formUsuari.TextBoxContrasenya.Text, formUsuari.DateTimePickerDataRegistre.Text, formUsuari.ComboBoxActiu.Text)
            End If
            ' aqui afegeixo l'empresa
            mostrarClients.insertEmpresa(dades)
        ElseIf RadioButtonActualitzar.Checked Then
            mostrarClients.updateAdmin(dades, mostrarClients.EnviarId)
        ElseIf RadioButtonEliminar.Checked Then

        Else
            MsgBox("Teniu que seleccionar una categoria")
        End If
    End Sub

End Class