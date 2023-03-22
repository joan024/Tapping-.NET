Imports System.Security.Cryptography
Imports System.Text
Public Class IniciSessio
    Dim textContrasenya As String
    Private Sub ButtonLogin_Paint(sender As Object, e As PaintEventArgs) Handles ButtonLogin.Paint
        ' fer que el button login l'efecte sigui d'eclipse
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = ButtonLogin.ClientRectangle
        rectangle.Inflate(-1, -1)
        buttonPath.AddEllipse(rectangle)
        ButtonLogin.Region = New Region(buttonPath)
    End Sub

    Private Sub IniciSessio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'la contrasenya surti amagada per defecte
        textContrasenya = TextBoxContrasenya.Text
        TextBoxContrasenya.UseSystemPasswordChar = True
        TextBoxContrasenya.Text = textContrasenya
    End Sub

    Private Sub ButtonSortir_Click(sender As Object, e As EventArgs) Handles ButtonSortir.Click
        Me.Close()
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim text As String = TextBoxContrasenya.Text
        Dim hash As String = EncriptarSHA256(text)
        'Console.WriteLine("Ara mostru el hash:")

        'Console.WriteLine(hash)
        If (TextBoxUsuari.Text = "empresa" And TextBoxContrasenya.Text = "empresa") Then
            Form1.Show()
            Me.Hide()
        ElseIf (TextBoxUsuari.Text = "admin" And TextBoxContrasenya.Text = "admin") Then
            Escriptori_Administradors.Show()
            Me.Hide()
        Else
            MsgBox("Contrasenya Incorrecte")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Me.CenterToScreen()
    End Sub

    Private Sub CheckBoxMostrarContrasenya_CheckedChanged(sender As Object, e As EventArgs)
        textContrasenya = TextBoxContrasenya.Text
        If (CheckBoxMostrarContrasenya.Checked) Then
            TextBoxContrasenya.UseSystemPasswordChar = False
            TextBoxContrasenya.Text = textContrasenya
        Else
            TextBoxContrasenya.UseSystemPasswordChar = True
            TextBoxContrasenya.Text = textContrasenya
        End If
    End Sub

    ' configuració quan clicka enter al textbox de la contrasenya
    Private Sub TextBoxContrasenya_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxContrasenya.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim text As String = TextBoxContrasenya.Text
            Dim hash As String = EncriptarSHA256(text)
            If (TextBoxUsuari.Text = "empresa" And TextBoxContrasenya.Text = "empresa") Then
                Form1.Show()
                Me.Hide()
            ElseIf (TextBoxUsuari.Text = "admin" And TextBoxContrasenya.Text = "admin") Then
                Escriptori_Administradors.Show()
                Me.Hide()
            Else
                MsgBox("Contrasenya Incorrecte")
            End If
        End If
    End Sub

    'funció per encriptar amb sha 256
    Public Function EncriptarSHA256(ByVal text As String) As String
        Dim sha256 As New SHA256Managed()
        Dim bytesText() As Byte = Encoding.UTF8.GetBytes(text)
        Dim bytesHash() As Byte = sha256.ComputeHash(bytesText)
        Dim hashString As New StringBuilder()
        For i As Integer = 0 To bytesHash.Length - 1
            hashString.Append(bytesHash(i).ToString("x2"))
        Next
        Return hashString.ToString()
    End Function


End Class