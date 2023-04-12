Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography
Imports System.Text
' borrar aquet import abans de fer el merge:
Imports MySql.Data.MySqlClient


Public Class IniciSessio
    Dim textContrasenya As String
    Private connexio As MySqlConnection
    Private sentencia As String
    Dim idUsuari As String = ""
    Dim correu As String = ""
    Dim contrasenya As String = ""

    Public Sub connectar()
        Try
            connexio = New MySqlConnection
            With connexio
                .ConnectionString = "server=localhost; user id=root; password=; database=tapping; port=3306;"
            End With
            connexio.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function mostrar(ByVal tipusTaula As String)
        ' segons el tipus d'usuari aplica una query i la guarda a la variable sentencia
        Select Case tipusTaula
            Case Constants.TAULAADMIN
                sentencia = Constants.QUERYADMIN & idUsuari & ";"
            Case Constants.TAULAEMPRESA
                sentencia = Constants.QUERYEMPRESA & idUsuari & ";"
            Case Constants.TAULAUSUARI
                sentencia = "SELECT id,correu,contrasenya FROM " & Constants.TAULAUSUARI
        End Select
        ' hi ho busca a la base de dades
        connectar()
        Dim comando As New MySqlCommand(sentencia, connexio)
        Dim reader = comando.ExecuteReader()
        ' si de la base de dades no retorna res, enviaré un que sigui null
        If Not reader.HasRows Then
            reader = Nothing
        End If
        Return reader
    End Function

    Private Sub ButtonLogin_Paint(sender As Object, e As PaintEventArgs) Handles ButtonLogin.Paint 'Handles ButtonLogin.Paint
        ' fer que el button login l'efecte sigui d'eclipse
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = ButtonLogin.ClientRectangle
        rectangle.Inflate(-1, -1)
        buttonPath.AddEllipse(rectangle)
        ButtonLogin.Region = New Region(buttonPath)
    End Sub

    Private Sub IniciSessio_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'la contrasenya surti amagada per defecte
        textContrasenya = TextBoxContrasenya.Text
        TextBoxContrasenya.UseSystemPasswordChar = True
        TextBoxContrasenya.Text = textContrasenya
        'MsgBox(constantAdmin)
    End Sub

    Private Sub ButtonSortir_Click(sender As Object, e As EventArgs) Handles ButtonSortir.Click 'Handles ButtonSortir.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click 'Handles ButtonLogin.Click
        Dim text As String = TextBoxContrasenya.Text
        Dim hash As String = EncriptarSHA256(text)
        idUsuari = ""
        correu = ""
        contrasenya = ""
        Dim reader = mostrar(Constants.TAULAUSUARI)

        ' El següent bucle llegeix les columnes correu i contrasenya i mira si hi ha coincidencies
        Dim semafor As Boolean = False
        While reader.Read()
            idUsuari = reader.GetString(0)
            correu = reader.GetString(1)
            contrasenya = reader.GetString(2)
            If (correu.Equals(TextBoxUsuari.Text) And contrasenya.Equals(hash)) Then
                semafor = True
                Exit While
            End If
        End While
        ' si dintre de la taula usuaris troba alguna coindicencia segurirà
        ' llavors en el seguent if busca el tipus d'usuari que es
        If (semafor) Then
            Dim tipusUsuari As Integer
            Dim contador As Integer = 0
            Dim condicio As Boolean = False
            Do While Not condicio
                Select Case contador
                    Case 0
                        reader = mostrar(Constants.TAULAEMPRESA)
                    Case 1
                        reader = mostrar(Constants.TAULAADMIN)
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
            MsgBox("Nom d'usuari o contrasenya incorrecta")
        End If
    End Sub

    Public Function OpcionsPossibles(ByVal contador As Integer)
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
    End Function

    ' panel perquè surti el formulari de sessio centrat
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint 'Handles Panel1.Paint
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    ' funció perque és mostri el text o el tapi depenent del checkbox
    Private Sub CheckBoxMostrarContrasenya_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrarContrasenya.CheckedChanged 'Handles CheckBoxMostrarContrasenya.CheckedChanged
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
    Private Sub TextBoxContrasenya_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxContrasenya.KeyDown 'Handles TextBoxContrasenya.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            ButtonLogin.PerformClick()
            e.Handled = True
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