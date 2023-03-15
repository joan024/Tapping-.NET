Imports System.ComponentModel

Public Class FormNoticies
    Private Sub FormNoticies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridViewNoticies.Rows.Add("Benvingut a Tapping", "Ens complau anunciar que per fi l''aplicació de Tapping és una realitat. Esperem que gaudiu tant d''ella com nosaltres, qualsevol dubte estem a la vostra disposició", My.Resources.LogoTappingSenseFondo, "2023/01/10")
        DataGridViewNoticies.ClearSelection()
    End Sub
    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub FormNoticies_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Form1.Show()
    End Sub
End Class