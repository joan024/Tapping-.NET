Imports System.ComponentModel

Public Class FormPF
    Private Sub FormPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridViewPF.Rows.Add("Com i on puc utilitzar els meus descomptes?", "Pots utilitzar els teus descomptes, durant les dates indicades, al mateix o mateixos restaurants vàlids del descompte")
        DataGridViewPF.ClearSelection()
    End Sub
    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub FormPF_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Form1.Show()
    End Sub
End Class