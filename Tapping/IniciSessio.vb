﻿Public Class IniciSessio

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs)
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = Button1.ClientRectangle
        rectangle.Inflate(-1, -1)
        buttonPath.AddEllipse(rectangle)
        Button1.Region = New Region(buttonPath)
    End Sub

    Private Sub IniciSessio_Load(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonSortir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (TextBox1.Text = "empresa" And TextBox2.Text = "empresa") Then
            Form1.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then
            Escriptori_Administradors.Show()
            Me.Hide()
        End If
    End Sub

    'Private Sub ButtonSortir_Click_1(sender As Object, e As EventArgs) Handles ButtonSortir.Click

    'End Sub

    'Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    'End Sub

    'Private Sub Button1_Paint_1(sender As Object, e As PaintEventArgs) Handles Button1.Paint

    'End Sub
End Class