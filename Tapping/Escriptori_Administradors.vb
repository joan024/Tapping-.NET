Public Class Escriptori_Administradors
    Dim mostrarClients As New GridViewClients
    Dim mostrarTapes As New GridViewTapes

    Private Sub Escriptori_Administradors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Label1.Visible = False
    End Sub

    Private Sub ClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem.Click
        Label1.Text = "CLIENTS"
        mostrarTapes.Hide()
        Label1.Visible = True
        mostrarClients.TopLevel = False
        mostrarClients.Show()
        Panel1.Controls.Add(mostrarClients)
    End Sub

    Private Sub TapesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TapesToolStripMenuItem.Click
        Label1.Text = "TAPES"
        mostrarClients.Hide()
        Label1.Visible = True
        mostrarTapes.TopLevel = False
        mostrarTapes.Show()
        Panel1.Controls.Add(mostrarTapes)
    End Sub

    Private Sub XatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XatToolStripMenuItem.Click
        FormXatAdmin.Show()
    End Sub

    Private Sub NotíciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotíciesToolStripMenuItem.Click
        FormNoticies.Show()
    End Sub

    Private Sub PreguntesFrequentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntesFrequentsToolStripMenuItem.Click
        FormPFAdmin.Show()
    End Sub
End Class