Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized

        Label1.Font = New Font("Arial", 20, FontStyle.Bold)
        Label1.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 15)
        Label3.Font = New Font("Arial", 15)

        Label1.Text = "TAPPING"

        Label2.Text = "Adreça: Carrer del Comtat d'Urgell, 6, 25700 La Seu d'Urgell, Lleida" + Environment.NewLine +
                      "Telèfon: 902 23 23 23" + Environment.NewLine +
                      "Horari: De dilluns a divendres de 10:00h a 14:00h i de 16:00h a 20:00h"


        Label3.Text = "Amb la nostra aplicació, tindràs accés a una àmplia gamma d'informació sobre cada establiment, incloent-hi les tapes que ofereixen, els preus, la ubicació, els horaris, i qualsevol altra informació important." + Environment.NewLine +
                      "A més, en aquesta aplicació podràs llegir comentaris i opinions d'altres usuaris que han visitat algun establiment." + Environment.NewLine +
                      "En resum, aquesta aplicació és una eina imprescindible per a qualsevol amant de les tapes." + Environment.NewLine +
                      "Comença avui amb la recerca dels millors llocs per tapejar!"



    End Sub

    ' ELS MEUS LOCALS:
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ElsMeusLocals.Show()
    End Sub

    ' LES TAPES
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        LesMevesTapes.Show()
    End Sub

    ' format del boto
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs)
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = Button1.ClientRectangle
        rectangle.Inflate(-1, -1)
        buttonPath.AddEllipse(rectangle)
        Button1.Region = New Region(buttonPath)
    End Sub
End Class
