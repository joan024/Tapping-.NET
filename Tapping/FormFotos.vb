Imports System.IO

Public Class FormFotos
    Dim arxiu As String = Constants.ARXIUS & Constants.IDLOCAL & Constants.EXTENSIOARXIU
    Dim foto As PictureBox
    Dim extensio As String
    Private Sub FormFotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrem les fotos que te guardades
        MostrarFotos()
    End Sub

    Private Sub AfegirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfegirToolStripMenuItem.Click
        'si no te cap local mostrem missatge error, sino mostrem fotos
        If Constants.IDLOCAL <> "" Then
            'obrim pantalla per que seleccioni una foto
            Dim ofd As New OpenFileDialog()
            'sol mostrem 3 extensions d'imatge
            ofd.Filter = "Arxius imatge |*.jpg;*.jpeg;*.png"
            'quan seleccioni la foto
            If ofd.ShowDialog() = DialogResult.OK Then
                'obtenim la ruta de la imatge
                Dim rutaImagen As String = ofd.FileName

                'guardem l'extensio de la foto
                extensio = "." & ofd.FileName.Split(".").Last

                'afegim l'imatge al flowLayoutPanel
                FlowLayoutPanelFotos.Controls.Add(foto)
                'afegim la foto a la base de dades
                Constants.bbdd.PujarFoto(PujarDades())
                'agafem ultim id de la taula
                Dim id As String = Constants.bbdd.SelectFoto()
                'afegim la foto a l'arxiu del local
                Constants.bbdd.ArxiuLocal()
                'carreguem la foto a un picturebox
                foto = New PictureBox
                With foto
                    .Image = Image.FromFile(rutaImagen)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Size = New Size(300, 250)
                    .Name = id & extensio
                End With
                'funcio per poder eliminar la foto
                AddHandler foto.Click, AddressOf Eliminar
                'guardem la imatge del picturebox amb ultim id de bbdd i la extensio guardada
                foto.Image.Save(Constants.FOTOS & id & extensio)
            End If
        Else
            MsgBox("Has de tenir un local", vbExclamation)
        End If
    End Sub
    Private Function PujarDades() As String()
        'creem array amb idlocal i la extensio per enviar a la funcio
        Dim dades(2) As String
        dades(0) = Constants.IDLOCAL
        dades(1) = extensio
        Return dades
    End Function

    Private Sub Eliminar(sender As Object, e As EventArgs)
        'primer preguntem si vol eliminar la foto
        Dim r = MsgBox("Segur que vols eliminar aquesta foto?", vbYesNo)
        If r = vbYes Then
            Dim pb As PictureBox = DirectCast(sender, PictureBox)

            Dim lineasModificadas As New List(Of String)()

            'llegim linea per linea
            Using lector As New StreamReader(arxiu)
                While Not lector.EndOfStream
                    Dim linea As String = lector.ReadLine()
                    If linea.Contains("#") Then
                        'modifiquem la data i hora
                        Dim primeraLinea = Now & "#" & Constants.IDLOCAL
                        lineasModificadas.Add(primeraLinea)
                    ElseIf linea <> pb.Name Then
                        'si no es la foto per eliminar afegim a la llista
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
            Constants.bbdd.DeleteFoto(pb.Name.Split(".").First)
            'eliminem el picturebox de la foto i la foto del disc
            pb.Parent.Controls.Remove(pb)
            pb.Image.Dispose()
            File.Delete(Constants.FOTOS & pb.Name)
        End If
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        'mostrem una informacio per comunicar com eliminar una foto
        MsgBox("Fes clic en la foto per eliminar-la", vbInformation)
    End Sub

    Private Sub MostrarFotos()
        'llegim l'arxiu del local linea per linea
        If File.Exists(arxiu) Then
            Using lector As New StreamReader(arxiu)
                While Not lector.EndOfStream
                    Dim linea As String = lector.ReadLine()
                    If linea.Contains(".jpg") Or linea.Contains(".png") Or linea.Contains(".jpeg") Then
                        'busquem la foto pel nom(linea)
                        Dim rutaFoto As String = Path.Combine(Constants.FOTOS, linea)
                        'creem el picturebox
                        foto = New PictureBox
                        With foto
                            .Image = Image.FromFile(rutaFoto)
                            .SizeMode = PictureBoxSizeMode.StretchImage
                            .Size = New Size(300, 250)
                            .Name = linea
                        End With
                        'funcio per poder eliminar la foto
                        AddHandler foto.Click, AddressOf Eliminar
                        'mostrem foto
                        FlowLayoutPanelFotos.Controls.Add(foto)
                    End If
                End While
            End Using
        End If
    End Sub

    Private Sub SortirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class