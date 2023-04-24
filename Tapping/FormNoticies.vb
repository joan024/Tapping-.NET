Imports System.ComponentModel

Public Class FormNoticies
    Dim taula As String = "noticia"
    Dim bbdd As New ClasseBBDD
    Private Sub FormNoticies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.SelectEmpresa(taula, 0, DataGridViewNoticies)
    End Sub
    Private Sub DataGridViewNoticies_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewNoticies.SelectionChanged
        DataGridViewNoticies.ClearSelection()
    End Sub
    Private Sub ButtonEnrere_Click(sender As Object, e As EventArgs) Handles ButtonEnrere.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub FormNoticies_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Form1.Show()
        Me.Close()
    End Sub
End Class