Imports System.ComponentModel

Public Class Form1
    Private nif As String
    Private telefon As String
    Private nom As String
    Private correu As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'guardem el pack
        Constants.PACK = Constants.bbdd.Pack()
        'guardem idLocal de la empresa
        Dim dades(1) As String
        dades(0) = Constants.IDUSUARI
        Constants.IDLOCAL = Constants.bbdd.SelectId(Constants.TAULALOCAL, dades)

        'guardem les dades obtingudes de la empresa en variables i les mostrem
        Dim reader = Constants.bbdd.PantallaEmpresa(Constants.IDUSUARI)
        While reader.Read()
            nif = reader.GetString(0)
            telefon = reader.GetString(1)
            nom = reader.GetString(2)
            correu = reader.GetString(3)
        End While

        LabelTitol.Font = New Font("Arial", 20, FontStyle.Bold)
        LabelTitol.BackColor = Color.Transparent
        LabelInfo.Font = New Font("Arial", 15)

        LabelTitol.Text = nom

        LabelInfo.Text = "Telèfon: " & telefon + Environment.NewLine & Environment.NewLine +
                         "Correu: " & correu + Environment.NewLine & Environment.NewLine +
                         "NIF: " & nif + Environment.NewLine
    End Sub
    'ELS MEUS LOCALS
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ElsMeusLocals.Show()
    End Sub
    'LES TAPES
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If Constants.IDLOCAL <> "" Then
            LesMevesTapes.Show()
        Else
            MsgBox("Has de tenir un local", vbExclamation)

        End If
    End Sub
    'COMENTARIS
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        'depenen del pack deixem entrar o mostrem missatge
        If Constants.PACK = "3" Or Constants.PACK = "2" Then
            MsgBox("Has de tenir Pack Brava per poder accedir", vbExclamation)
        ElseIf Constants.PACK = "1" Then
            FormComentaris.Show()
        End If
    End Sub
    'DESCOMPTES
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        'depenen del pack deixem entrar o mostrem missatge
        If Constants.PACK = "3" Then
            MsgBox("Has de tenir Pack Brava o Chipis per poder accedir", vbExclamation)
        ElseIf Constants.PACK = "1" Or Constants.PACK = "2" Then
            'si no te cap local mostrem missatge, sino entrem a la pantalla
            If Constants.IDLOCAL <> "" Then
                FormDescomptes.Show()
            Else
                MsgBox("Has de tenir un local", vbExclamation)
            End If
        End If
    End Sub
    'GALERIA
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        FormFotos.Show()
        Me.Hide()
    End Sub
    'NOTICIES
    Private Sub NoticiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoticiesToolStripMenuItem.Click
        FormNoticies.Show()
        Me.Hide()
    End Sub
    'PREGUNTES FREQÜENTS
    Private Sub PreguntesFreqüentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntesFreqüentsToolStripMenuItem.Click
        FormPF.Show()
        Me.Hide()
    End Sub
    'XAT
    Private Sub XatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XatToolStripMenuItem.Click
        FormPantallaXat.Show()
    End Sub
    'TANCAR SESSIO
    Private Sub TancaSessióToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TancaSessióToolStripMenuItem.Click
        'mostrem login i tanquem actual(inici)
        IniciSessio.Show()
        Me.Hide()
    End Sub
    'tanquem tota l'aplicació quan li dona al close(x)
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub
End Class
