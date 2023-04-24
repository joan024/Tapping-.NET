Imports System.Runtime.CompilerServices

Public Class Escriptori_Administradors
    Dim gvClients As New GridViewClients
    Dim gvTapes As New GridViewTapes

    Private Sub Escriptori_Administradors_Load(sender As Object, e As EventArgs)
        Label1.Visible = False
        Panel2.Visible = False
    End Sub

    ' menu:
    Private Sub ClientsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        opcioClient()
        gvClients.selectTaula()

        'en el addhandler li afegeixo la opcio selectionchanged perquè desprès a la corresponent funcio pugui fer servir les dades
        AddHandler gvClients.DataGridViewClients.SelectionChanged, AddressOf MostrarClients_DataGridViewSelectionChanged
    End Sub
    Private Sub TapesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        opcioTapes()
    End Sub

    Private Sub XatToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormXatAdmin.Show()
        Panel2.Visible = False
    End Sub

    Private Sub NotíciesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form2NoticiesAdminvb.Show()
        Panel2.Visible = False
    End Sub

    Private Sub PreguntesFrequentsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormPFAdmin.Show()
        Panel2.Visible = False
    End Sub

    ' aquesta funcio serveix per actualitzar els camps cada cop que fa click damunt d'una fila
    Private Sub MostrarClients_DataGridViewSelectionChanged(sender As Object, e As EventArgs)
        TextBoxNif.Text = gvClients.DataGridViewClients.CurrentRow.Cells(1).Value
        TextBoxTelefon.Text = gvClients.DataGridViewClients.CurrentRow.Cells(2).Value
        TextBoxPack.Text = gvClients.DataGridViewClients.CurrentRow.Cells(3).Value
    End Sub

    Private Sub ButtonConfirmar_Click(sender As Object, e As EventArgs)
        Dim dades(3) As String
        dades(0) = TextBoxNif.Text
        dades(1) = TextBoxTelefon.Text
        dades(2) = TextBoxPack.Text

        If RadioButtonAfegir.Checked Then
            ' el formAfegirUsuari l'utilitzo perquè abans d'afegir una nova empresa tinc que afegir-lo com a usuari i aquet té més dades que necessito.
            ' aquestes dades les demano en un formulari que l'executu amb el DialogResult
            Dim formUsuari As New FormAfegirUsuari
            Dim result As DialogResult = formUsuari.ShowDialog(Me)
            If result = DialogResult.OK Then
                ' en la seguent funcio afegeixo un nou usuari i retorno la id d'aquest usuari per desprès poder afegir l'empresa
                Dim idUsuari As String = gvClients.insertUsuari(formUsuari.TextBoxNom.Text, formUsuari.TextBoxCorreu.Text, formUsuari.TextBoxContrasenya.Text, formUsuari.DateTimePickerDataRegistre.Text, formUsuari.ComboBoxActiu.Text)
                'afegir l'empresa:
                gvClients.insertClient(idUsuari, TextBoxNif.Text, TextBoxTelefon.Text, TextBoxPack.Text)
                MsgBox("S'ha afegit correctament")
            End If
        ElseIf RadioButtonActualitzar.Checked Then
            gvClients.updateClient(TextBoxNif.Text, TextBoxTelefon.Text, TextBoxPack.Text, gvClients.EnviarId)
            MsgBox("S'ha actualitzat correctament")
        ElseIf RadioButtonEliminar.Checked Then
            gvClients.deleteClient()
            MsgBox("S'ha eliminat correctament")
        Else
            MsgBox("Teniu que seleccionar una categoria")
        End If
    End Sub

    Protected Sub opcioClient()
        ' aixo ho faig per quan s'inicia
        Label1.Text = "CLIENTS"
        gvTapes.Hide()
        Label1.Visible = True
        gvClients.TopLevel = False
        gvClients.Show()
        Panel1.Controls.Add(gvClients)
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
        gvClients.Hide()
        Label1.Visible = True
        gvTapes.TopLevel = False
        gvTapes.Show()
        Panel1.Controls.Add(gvTapes)
        Panel2.Visible = True
        ' aixo ho faig per quan canvio de clients a tapes
        LabelNif.Text = "NOM"
        LabelPack.Visible = False
        LabelTelefon.Visible = False
        TextBoxPack.Visible = False
        TextBoxTelefon.Visible = False
    End Sub

End Class