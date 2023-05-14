Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Escriptori_Administradors
    Dim gvClients As New GridViewClients
    Dim gvTapes As New GridViewTapes
    Dim gvCategories As New GridViewCategories

    Private Sub Escriptori_Administradors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub ClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem.Click
        opcioClient()
        gvClients.selectTaula()
        'en el addhandler li afegeixo la opcio selectionchanged perquè desprès a la corresponent funcio pugui fer servir les dades
        AddHandler gvClients.DataGridViewClients.SelectionChanged, AddressOf MostrarClients_DataGridViewSelectionChanged
    End Sub
    Private Sub TapesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TapesToolStripMenuItem.Click
        opcioTapes()
        gvTapes.selectTaula()
        AddHandler gvTapes.DataGridViewTapes.SelectionChanged, AddressOf MostrarTapes_DataGridViewSelectionChanged
    End Sub
    Private Sub CategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriesToolStripMenuItem.Click
        opcioCategories()
        gvCategories.selectTaula()
        AddHandler gvCategories.DataGridViewCategories.SelectionChanged, AddressOf MostrarCategories_DataGridViewSelectionChanged
    End Sub

    Private Sub XatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XatToolStripMenuItem.Click
        FormXatAdmin.Show()
        Panel2.Visible = False
    End Sub

    Private Sub NotíciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotíciesToolStripMenuItem.Click
        FormNoticiesAdmin.Show()
        Panel2.Visible = False
        Me.Hide()
    End Sub

    Private Sub PreguntesFrequentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntesFrequentsToolStripMenuItem.Click
        FormPFAdmin.Show()
        Panel2.Visible = False
        Me.Hide()
    End Sub

    ' Quan l'administrador clica el boto dels clients:
    Private Sub ButtonConfirmarClients_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarClients.Click
        Dim dades(3) As String
        dades(0) = TextBoxNif.Text
        dades(1) = TextBoxTelefon.Text
        dades(2) = TextBoxPack.Text

        If RadioButtonAfegir.Checked Then
            ' el formAfegirUsuari l'utilitzo perquè abans d'afegir una nova empresa tinc que afegir-lo com a usuari i aquet té més dades que necessito.
            ' aquestes dades les demano en un formulari que l'executu amb el DialogResult
            Dim idUsuari As String = ""
            Dim formUsuari As New FormAfegirUsuari
            Dim result As DialogResult = formUsuari.ShowDialog(Me)
            If result = DialogResult.OK Then
                ' en la seguent funcio afegeixo un nou usuari i retorno la id d'aquest usuari per desprès poder afegir l'empresa
                idUsuari = gvClients.insertUsuari(formUsuari.TextBoxNom.Text, formUsuari.TextBoxCorreu.Text, formUsuari.TextBoxContrasenya.Text, formUsuari.DateTimePickerDataRegistre.Text, formUsuari.ComboBoxActiu.Text)
                'afegir l'empresa:rr
                gvClients.insertClient(idUsuari, TextBoxNif.Text, TextBoxTelefon.Text, TextBoxPack.Text)
            End If
            'creem el xat
            Dim dgv As New DataGridView
            Dim dadesXat(2) As String
            dadesXat(0) = Constants.IDUSUARI
            dadesXat(1) = idUsuari
            Constants.bbdd.InsertAdmin(Constants.TAULAXAT, dadesXat, dgv)
        ElseIf RadioButtonActualitzar.Checked Then
            gvClients.updateClient(TextBoxNif.Text, TextBoxTelefon.Text, TextBoxPack.Text, gvClients.EnviarId)
        ElseIf RadioButtonEliminar.Checked Then
            gvClients.deleteClient()
            gvClients.selectTaula()
        Else
            MsgBox("Teniu que seleccionar una categoria")
        End If
    End Sub

    ' Quan l'administrador clica el boto de les tapes:
    Private Sub ButtonConfirmarTapes_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarTapes.Click
        Dim dades(1) As String
        dades(0) = TextBoxNif.Text
        If RadioButtonAfegir.Checked Then
            Dim idTapa As String = gvTapes.insertTapa(TextBoxNif.Text)
            gvTapes.insertCategoriaTapa(idTapa, ComboBoxCategoria.Text)
            gvTapes.selectTaula()
        ElseIf RadioButtonActualitzar.Checked Then
            gvTapes.updateTapa(TextBoxNif.Text, gvTapes.EnviarId)
        ElseIf RadioButtonEliminar.Checked Then
            gvTapes.deleteTapa()
        Else
            MsgBox("Teniu que seleccionar una categoria")
        End If
    End Sub

    Private Sub ButtonConfirmarCategories_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarCategories.Click
        If RadioButtonAfegir.Checked Then
            gvCategories.insertCategoria(TextBoxNif.Text)
            gvCategories.selectTaula()
        ElseIf RadioButtonActualitzar.Checked Then
            gvCategories.updateCategoria(TextBoxNif.Text)
        ElseIf RadioButtonEliminar.Checked Then
            gvCategories.deleteCategoria()
        Else
            MsgBox("Teniu que seleccionar una categoria")
        End If
    End Sub

    Protected Sub opcioClient()
        ' aixo ho faig per quan s'inicia
        Label1.Text = "CLIENTS"
        gvTapes.Hide()
        gvCategories.Hide()
        Label1.Visible = True
        gvClients.TopLevel = False
        gvClients.Show()
        Panel1.Controls.Add(gvClients)
        Panel2.Visible = True

        ButtonConfirmarClients.Visible = True
        ButtonConfirmarCategories.Visible = False
        ButtonConfirmarTapes.Visible = False
        ComboBoxCategoria.Visible = False
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
        gvCategories.Hide()
        Label1.Visible = True
        gvTapes.TopLevel = False
        gvTapes.Show()
        Panel1.Controls.Add(gvTapes)
        Panel2.Visible = True
        ButtonConfirmarTapes.Visible = True
        ButtonConfirmarClients.Visible = False
        ButtonConfirmarCategories.Visible = False
        ComboBoxCategoria.Visible = False
        ' aixo ho faig per quan canvio de clients a tapes
        LabelNif.Text = "NOM"
        LabelPack.Visible = False
        LabelTelefon.Visible = False
        TextBoxPack.Visible = False
        TextBoxTelefon.Visible = False
        Dim llistaCategories As New ArrayList
        'mostrem categories en combobox
        llistaCategories = Constants.bbdd.obtenirCategories()
        For Each nom As String In llistaCategories
            ComboBoxCategoria.Items.Add(nom)
        Next
    End Sub
    Protected Sub opcioCategories()
        Label1.Text = "CATEGORIES"
        gvClients.Hide()
        gvTapes.Hide()
        Label1.Visible = True
        gvCategories.TopLevel = False
        gvCategories.Show()
        Panel1.Controls.Add(gvCategories)
        Panel2.Visible = True

        ButtonConfirmarCategories.Visible = True
        ButtonConfirmarTapes.Visible = False
        ButtonConfirmarClients.Visible = False
        ComboBoxCategoria.Visible = False

        LabelNif.Text = "NOM"
        LabelPack.Visible = False
        LabelTelefon.Visible = False
        TextBoxPack.Visible = False
        TextBoxTelefon.Visible = False
    End Sub

    Private Sub RadioButtonAfegir_Click(sender As Object, e As EventArgs) Handles RadioButtonAfegir.Click
        If Label1.Text.Equals("TAPES") Then
            ComboBoxCategoria.Visible = True
            LabelTelefon.Visible = True
            LabelTelefon.Text = "CATEGORIA"
        End If
    End Sub
    ' aquesta funcio serveix per actualitzar els camps cada cop que fa click damunt d'una fila 
    ' Pels Clients:
    Private Sub MostrarClients_DataGridViewSelectionChanged(sender As Object, e As EventArgs)
        TextBoxNif.Text = gvClients.DataGridViewClients.CurrentRow.Cells(1).Value
        TextBoxTelefon.Text = gvClients.DataGridViewClients.CurrentRow.Cells(2).Value
        TextBoxPack.Text = gvClients.DataGridViewClients.CurrentRow.Cells(3).Value
    End Sub
    ' Per les Tapes:
    Private Sub MostrarTapes_DataGridViewSelectionChanged(sender As Object, e As EventArgs)
        TextBoxNif.Text = gvTapes.DataGridViewTapes.CurrentRow.Cells(1).Value
    End Sub
    Private Sub MostrarCategories_DataGridViewSelectionChanged(sender As Object, e As EventArgs)
        TextBoxNif.Text = gvCategories.DataGridViewCategories.CurrentRow.Cells(1).Value
    End Sub

    Private Sub Escriptori_Administradors_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub

    Private Sub TancaSessióToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TancaSessióToolStripMenuItem.Click
        IniciSessio.Show()
        Me.Hide()
    End Sub
End Class