Imports System.ComponentModel

Public Class FormPF
    Private Sub FormPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Constants.bbdd.SelectEmpresa(Constants.TAULAPREGUNTAFREQUENT, 0, DataGridViewPF)
    End Sub
    Private Sub DataGridViewPF_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPF.SelectionChanged
        DataGridViewPF.ClearSelection()
    End Sub
    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class