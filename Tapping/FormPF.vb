Imports System.ComponentModel

Public Class FormPF
    Dim taula As String = "preguntafrequent"
    Dim bbdd As New ClasseBBDD
    Private Sub FormPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.SelectEmpresa(taula, 0, DataGridViewPF)
    End Sub
    Private Sub DataGridViewPF_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPF.SelectionChanged
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