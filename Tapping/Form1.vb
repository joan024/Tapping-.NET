﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub XatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XatToolStripMenuItem.Click
        FormPantallaXat.Show()
    End Sub
    Private Sub NoticiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoticiesToolStripMenuItem.Click
        FormNoticies.Show()
        'Me.Hide()
    End Sub
End Class
