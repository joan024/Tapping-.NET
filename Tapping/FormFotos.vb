Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormFotos
    Dim bbdd As New ClasseBBDD
    Dim arxiu As String = "C:\TappingFotos\local\" & 11 & ".txt"
    Dim fotos As String = "C:\TappingFotos\"
    Dim foto As PictureBox
    Dim extensio As String = ""
    Private Sub FormFotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarFotos()
    End Sub

    Private Sub AfegirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfegirToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog()
        'sol mostrem 3 extensions d'imatge
        ofd.Filter = "Arxius imatge |*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog() = DialogResult.OK Then
            'obtenim la ruta de la imatge
            Dim rutaImagen As String = ofd.FileName

            'guardem l'extensio de la foto
            extensio = "." & ofd.FileName.Split(".").Last

            'carreguem les fotos a un picturebox
            foto = New PictureBox
            With foto
                .Image = Image.FromFile(rutaImagen)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Size = New Size(300, 250)
            End With
            'afegim l'imatge al flowLayoutPanel
            FlowLayoutPanelFotos.Controls.Add(foto)
            'afegim la foto a la base de dades
            bbdd.PujarFoto(PujarDades())
            'agafem ultim id de la taula
            Dim id As String = bbdd.SelectFoto()
            'MsgBox(id)
            'afegim la foto a l'arxiu del local
            bbdd.ArxiuLocal()
            'guardem la imatge del picturebox amb ultim id de bbdd i la extensio guardada
            foto.Image.Save(fotos & id & extensio)
        End If
    End Sub
    'creem array amb idlocal i la extensio per ficarlo a la bbdd
    Private Function PujarDades() As String()
        Dim dades(2) As String
        dades(0) = 11
        dades(1) = extensio
        Return dades
    End Function

    Private Sub Eliminar(sender As Object, e As EventArgs)
        'primer preguntem si vol eliminar la foto
        Dim r = MsgBox("Segur que vols eliminar aquesta foto?", vbYesNo)
        If r = vbYes Then
            Dim pb As PictureBox = DirectCast(sender, PictureBox)
            'MsgBox(pb.Name)

            Dim lineasModificadas As New List(Of String)()

            'llegim linea per linea i si la linea no coincideix la fiquem a la llista sino la descartem
            Using lector As New StreamReader(arxiu)
                While Not lector.EndOfStream
                    Dim linea As String = lector.ReadLine()
                    If linea <> pb.Name Then
                        lineasModificadas.Add(linea)
                    End If
                End While
            End Using

            'escrivim les linies de la llista
            Using escritor As New StreamWriter(arxiu)
                For Each linea In lineasModificadas
                    escritor.WriteLine(linea)
                Next
            End Using
            'eliminem la foto de la base de dades
            bbdd.DeleteFoto(pb.Name.Split(".").First)
            'eliminem el picturebox de la foto i la foto del disc
            pb.Parent.Controls.Remove(pb)
            pb.Image.Dispose()
            File.Delete(fotos & pb.Name)
        End If
    End Sub
    'mostrem una informacio per comunicar com eliminar una foto
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        MsgBox("Fes clic en la foto per eliminar-la", vbInformation)
    End Sub

    Private Sub MostrarFotos()
        'llegim l'arxiu del local i busquem el nom a les fotos i la fiquem a un picturebox
        If File.Exists(arxiu) Then
            Using lector As New StreamReader(arxiu)
                While Not lector.EndOfStream
                    Dim linea As String = lector.ReadLine()
                    If linea.Contains(".jpg") Or linea.Contains(".png") Or linea.Contains(".jpeg") Then
                        Dim rutaFoto As String = Path.Combine(fotos, linea)
                        foto = New PictureBox
                        With foto
                            .Image = Image.FromFile(rutaFoto)
                            .SizeMode = PictureBoxSizeMode.StretchImage
                            .Size = New Size(300, 250)
                            .Name = linea
                        End With
                        AddHandler foto.Click, AddressOf Eliminar
                        FlowLayoutPanelFotos.Controls.Add(foto)
                    End If
                End While
            End Using
        End If
    End Sub

    Private Sub BuidarFotos()
        For Each control In FlowLayoutPanelFotos.Controls
            FlowLayoutPanelFotos.Controls.Remove(control)
            control.Dispose()
        Next
    End Sub

End Class