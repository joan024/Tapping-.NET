Public Class IniciSessio

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
        Form1.Show()
        Me.Hide()
    End Sub
End Class