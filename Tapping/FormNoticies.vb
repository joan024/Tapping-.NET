Public Class FormNoticies
    Private Sub FormNoticies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.Rows.Add("Benvingut a Tapping", "Ens complau anunciar que per fi l''aplicació de Tapping és una realitat. Esperem que gaudiu tant d''ella com nosaltres, qualsevol dubte estem a la vostra disposició", My.Resources.LogoTappingSenseFondo, "2023/01/10")
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Form1.Show()
    End Sub
End Class