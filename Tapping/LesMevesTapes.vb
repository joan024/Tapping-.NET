Imports Google.Protobuf.Collections

Public Class LesMevesTapes
    Private bbdd As New ClasseBBDD
    Dim llistaTapes As New ArrayList
    Dim llistaLocals As New ArrayList
    Private Sub LesMevesTapes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LLISTAR NOMES LES TAPES QUE TÉ EL LOCAL
        bbdd.mostrarTapa(Constants.TAULALOCAL, DataGridViewTapes)
        'LLISTAR TOTES LES TAPES QUE HI HA AL COMBOBOX DE TAPES
        llistaTapes = bbdd.obtenirNoms(Constants.TAULATAPA)
        emplenarSelect(llistaTapes, Constants.TAULATAPA)
        'LLISTAR LOCALS AL COMBOBOX DE LOCALS
        llistaLocals = bbdd.obtenirNoms(Constants.TAULALOCAL)
        emplenarSelect(llistaLocals, Constants.TAULALOCAL)
        'fiquem el local que té per defecte
        ComboBoxLocal.SelectedIndex = 0
        buid()
    End Sub
    Private Sub DataGridViewTapes_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewTapes.SelectionChanged
        'fiquem les dades de la fila seleccionada als textboxs
        ComboBoxNom.Text = DataGridViewTapes.CurrentRow.Cells(0).Value
        TextBoxPersonalitzacio.Text = DataGridViewTapes.CurrentRow.Cells(1).Value
        TextBoxPreu.Text = DataGridViewTapes.CurrentRow.Cells(2).Value
        RadioButtonActualitzar.Checked = True
    End Sub
    ' la seguent funcio serveix per emplenar el select de forma dinamica dels noms que hi ha a la base de dades
    Private Sub emplenarSelect(ByVal llistaNoms As ArrayList, ByVal taula As String)
        Select Case taula
            Case Constants.TAULATAPA
                For Each nom As String In llistaNoms
                    ComboBoxNom.Items.Add(nom)
                Next
            Case Constants.TAULALOCAL
                For Each nom As String In llistaNoms
                    ComboBoxLocal.Items.Add(nom)
                Next
        End Select
    End Sub
    Private Sub RadioButtonAfegir_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAfegir.CheckedChanged
        If RadioButtonAfegir.Checked Then
            ComboBoxNom.Text = ""
            TextBoxPersonalitzacio.Text = ""
            TextBoxPreu.Text = ""
        End If
    End Sub
    Private Sub ButtonConfirmarTapes_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarTapes.Click
        'l'array dades guarda personalitzacio i preu:
        Dim dades(2) As String
        dades(0) = TextBoxPersonalitzacio.Text
        dades(1) = TextBoxPreu.Text

        ' obtenir id de la tapa que selecciona:
        Dim indexSeleccionat As Integer = ComboBoxNom.SelectedIndex
        Constants.NOMTAPA = ComboBoxNom.Items(indexSeleccionat).ToString()
        bbdd.obtenirId(Constants.TAULATAPA)

        'obtenir el id del local que selecciona:
        indexSeleccionat = ComboBoxLocal.SelectedIndex
        Constants.NOMLOCAL = ComboBoxLocal.Items(indexSeleccionat).ToString()
        bbdd.obtenirId("local2")

        'obtenir el id de local_tapa:
        bbdd.obtenirId(Constants.TAULALOCALTAPA)

        'depenen del radiobutton fem una accio
        If RadioButtonAfegir.Checked Then
            bbdd.afegirTapa(Constants.TAULALOCALTAPA, dades, DataGridViewTapes)
            buid()
        ElseIf RadioButtonActualitzar.Checked Then
            bbdd.actualitzarTapa(Constants.TAULALOCALTAPA, dades, DataGridViewTapes)
            buid()
        ElseIf RadioButtonEliminar.Checked Then
            bbdd.eliminarTapa(Constants.TAULALOCALTAPA, dades, DataGridViewTapes)
            buid()
        Else
            MsgBox("Teniu que sel·leccionar una opcio")
        End If
        bbdd.mostrarTapa(Constants.TAULATAPA, DataGridViewTapes)
    End Sub
    Private Sub buid()
        DataGridViewTapes.ClearSelection()
        ComboBoxNom.Text = ""
        TextBoxPersonalitzacio.Text = ""
        TextBoxPreu.Text = ""
        RadioButtonAfegir.Checked = True
    End Sub
End Class