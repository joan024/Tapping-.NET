Public Class Form2NoticiesAdminvb
    Private Sub Form2NoticiesAdminvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridViewNoticies.Rows.Add("1", "Benvingut a Tapping", "Ens complau anunciar que per fi l'aplicació de Tapping és una realitat. Esperem que gaudiu tant d'ella com nosaltres, qualsevol dubte estem a la vostra disposició", My.Resources.LogoTappingSenseFondo, "2023/01/10")
    End Sub
End Class