Imports System.ComponentModel
Imports System.IO

Public Class FormNoticies
    Private Sub FormNoticies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem les noticies
        Constants.bbdd.SelectEmpresa(Constants.TAULANOTICIA, 0, DataGridViewNoticies)
        'amagem columna foto
        DataGridViewNoticies.Columns(2).Visible = False
        'creem nova columna
        ColumnaImatge()
        'fiquem que la columna de descripcio sigui multilinea
        DataGridViewNoticies.Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    'fiquem aixo per que no es pugi seleccionar
    Private Sub DataGridViewNoticies_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewNoticies.SelectionChanged
        DataGridViewNoticies.ClearSelection()
    End Sub
    Private Sub DataGridViewNoticies_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewNoticies.CellFormatting
        If e.ColumnIndex = 3 Then
            'obtenim la url de la columna "foto" de la base de dades
            Dim urlImagen As String = DataGridViewNoticies.Rows(e.RowIndex).Cells("foto").Value.ToString()

            'descarreguem imatge i passem a bytes
            Dim webClient As New System.Net.WebClient()
            Dim imagenBytes As Byte() = webClient.DownloadData(urlImagen)

            'creem un objecte Image apartir dels bytes
            Dim imagen As Image = Image.FromStream(New MemoryStream(imagenBytes))

            'fem la imatge més petita
            Dim imagenRedimensionada As Image = New Bitmap(imagen, 100, 100)

            'fiquem imatge a la nova columna
            e.Value = imagenRedimensionada
        End If
    End Sub
    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub ColumnaImatge()
        'funcio per crear nova columna de tipus imatge
        Dim columnaImagen As New DataGridViewImageColumn()
        columnaImagen.Name = "imatge"
        columnaImagen.HeaderText = "imatge"
        columnaImagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewNoticies.Columns.Add(columnaImagen)
    End Sub
End Class