Imports System.Security.Cryptography
Imports System.Text

Public Class IniciSessio
    Dim textContrasenya As String
    Dim correu As String = ""
    Dim contrasenya As String = ""

    Private Sub IniciSessio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If WindowState = FormWindowState.Maximized Then
            Panel1.Location = New Point((Me.Width - Panel1.Width) / 2, (Me.Height - Panel1.Height) / 2)
        End If
        'la contrasenya surti amagada per defecte
        textContrasenya = TextBoxContrasenya.Text
        TextBoxContrasenya.UseSystemPasswordChar = True
        TextBoxContrasenya.Text = textContrasenya
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim text As String = TextBoxContrasenya.Text
        Dim hash As String = EncriptarSHA256(text)
        correu = ""
        contrasenya = ""
        Dim reader = Constants.bbdd.comprovacioLogin(Constants.TAULAUSUARI)

        'El següent bucle llegeix les columnes correu i contrasenya i mira si hi ha coincidencies
        Dim semafor As Boolean = False
        Dim canviContrasenya As Boolean = True
        While reader.Read()
            Constants.IDUSUARI = reader.GetString(0)
            correu = reader.GetString(1)
            contrasenya = reader.GetString(2)
            'el primer if es per quan un usuari ha d'inserir una nova contrasenya
            If (correu.Equals(TextBoxUsuari.Text) And contrasenya.Equals(text)) Then
                Dim formulariContrasenya As New GridViewNovaContrasenya
                Dim mostrarFormulari As DialogResult = formulariContrasenya.ShowDialog(Me)
                If (mostrarFormulari = DialogResult.OK) Then
                    Dim contrasenya As String = formulariContrasenya.TextBoxContra1.Text
                    Dim nouHash As String = EncriptarSHA256(contrasenya)
                    Constants.bbdd.UpdateContrasenya(nouHash, Constants.IDUSUARI)
                    canviContrasenya = False
                End If
                'el segon if es per quan el usuari ja esta registrat
            ElseIf (correu.Equals(TextBoxUsuari.Text) And contrasenya.Equals(hash)) Then
                semafor = True
                Exit While
            End If
        End While
        ' si dintre de la taula usuaris troba alguna coindicencia segurirà
        ' llavors en el seguent if busca el tipus d'usuari que es
        If (semafor) Then
            Dim contador As Integer = 0
            Dim condicio As Boolean = False
            Do While Not condicio
                Select Case contador
                    Case 0
                        reader = Constants.bbdd.comprovacioLogin(Constants.TAULAEMPRESA)
                    Case 1
                        reader = Constants.bbdd.comprovacioLogin(Constants.TAULAADMIN)
                End Select
                ' l'if reader is nothing el faig servir perque entri a la taula empresa i a la taula admin suman un mes al contador
                If (reader Is Nothing) Then
                    contador += 1
                End If
                ' segons el numero del contador la funcio opcions possibles fara el que toqui
                If contador >= 2 Or Not reader Is Nothing Then
                    condicio = True
                    OpcionsPossibles(contador)
                End If
            Loop
        Else
            If (canviContrasenya) Then
                MsgBox("Nom d'usuari o contrasenya incorrecta")
            End If
        End If
    End Sub

    Public Sub OpcionsPossibles(ByVal contador As Integer)
        Select Case contador
            Case 0 'contador 0 significa entrar a l'interficie empresa
                Form1.Show()
                Me.Hide()
            Case 1 'contador 1 significa entrar a l'interficie administradors
                Escriptori_Administradors.Show()
                Me.Hide()
            Case 2 ' contador 2 significa errors
                MsgBox("L'inici de sessió presenta un o varios errors: " & vbNewLine &
                       "- Nom d'usuari o contrasenya incorrecte" & vbNewLine &
                       "- Sigeu usuari consumidor")
        End Select
    End Sub

    'configuració quan clicka enter al textbox de la contrasenya
    Private Sub TextBoxContrasenya_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxContrasenya.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            ButtonLogin.PerformClick()
            e.Handled = True
        End If
    End Sub

    'funció perque és mostri el text o el tapi depenent del checkbox
    Private Sub CheckBoxMostrarContrasenya_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrarContrasenya.CheckedChanged
        textContrasenya = TextBoxContrasenya.Text
        If (CheckBoxMostrarContrasenya.Checked) Then
            TextBoxContrasenya.UseSystemPasswordChar = False
            TextBoxContrasenya.Text = textContrasenya
        Else
            TextBoxContrasenya.UseSystemPasswordChar = True
            TextBoxContrasenya.Text = textContrasenya
        End If
    End Sub

    Private Sub ButtonLogin_Paint(sender As Object, e As PaintEventArgs) Handles ButtonLogin.Paint
        ' fer que el button login l'efecte sigui d'eclipse
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = ButtonLogin.ClientRectangle
        rectangle.Inflate(-1, -1)
        buttonPath.AddEllipse(rectangle)
        ButtonLogin.Region = New Region(buttonPath)
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

    Private Sub ButtonSortir_Click(sender As Object, e As EventArgs) Handles ButtonSortir.Click
        Application.Exit()
    End Sub

End Class