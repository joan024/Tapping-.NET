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
    Dim constantAdmin As String = "select usuari.correu,usuari.contrasenya, administrador.dni, administrador.cognom" _
                                   & " from usuari" _
                                   & " join administrador" _
                                   & " on usuari.id = administrador.id_usuari" _
                                   & " where administrador.id_usuari = "

    Dim constantConsumidor As String = "select usuari.correu,usuari.contrasenya, consumidor.cognom" _
                                        & " from usuari" _
                                        & " join consumidor on" _
                                        & " usuari.id = consumidor.id_usuari" _
                                        & " where consumidor.id_usuari = "

    Dim constantEmpresa As String = "Select usuari.correu,usuari.contrasenya, empresa.nif
                                     from usuari 
                                     join empresa 
                                     on usuari.id = empresa.id_usuari 
                                     where empresa.id_usuari = ;"
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
    Public Function mostrar(ByVal taula As String)
        sentencia = "SELECT id,correu,contrasenya FROM " & Constants.TAULAUSUARI
        connectar()
        Dim comando As New MySqlCommand(sentencia, connexio)
        Dim reader = comando.ExecuteReader()
        Return reader
    End Function
    Public Function mostrar2(ByVal tipusTaula As String)
        Select Case tipusTaula
            Case Constants.TAULAADMIN
                sentencia = "SELECT id_usuari,dni,cognom FROM " & Constants.TAULAADMIN
            Case Constants.TAULAEMPRESA
                sentencia = "SELECT id_usuari,nif FROM " & Constants.TAULAEMPRESA
            Case Constants.TAULAUSUARI
                sentencia = "SELECT id,correu,contrasenya FROM " & Constants.TAULAUSUARI
        End Select
        connectar()
        Dim comando As New MySqlCommand(sentencia, connexio)
        Dim reader = comando.ExecuteReader()
        ' si de la base de dades no retorna res, enviaré un null
        If Not reader.HasRows Then
            reader = Nothing
        End If
        Return reader
    End Function

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
        MsgBox(constantAdmin)
    End Sub

    Private Sub ButtonSortir_Click(sender As Object, e As EventArgs) Handles ButtonSortir.Click
        Me.Close()
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
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

        If (semafor) Then
            ' Form1.Show()
            ' Me.Hide()
            Dim tipusUsuari As Integer
            Dim contador As Integer = 0
            Select Case contador
                Case 0
                    reader = mostrar2(Constants.TAULAEMPRESA)
                    If (reader Is Nothing) Then
                        contador += 1
                    End If
                Case 1
                    reader = mostrar2(Constants.TAULAADMIN)
            End Select
            While reader.Read()
                tipusUsuari = reader.GetString(0)
                If (tipusUsuari = idUsuari) Then

                End If
            End While
        Else
                MsgBox("Nom d'usuari o contrasenya incorrecta")
        End If

        'If (TextBoxUsuari.Text = "empresa" And TextBoxContrasenya.Text = "empresa") Then
        '    Form1.Show()
        '    Me.Hide()
        'ElseIf (TextBoxUsuari.Text = "admin" And TextBoxContrasenya.Text = "admin") Then
        '    Escriptori_Administradors.Show()
        '    Me.Hide()
        'Else
        '    MsgBox("Contrasenya Incorrecte")
        'End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

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