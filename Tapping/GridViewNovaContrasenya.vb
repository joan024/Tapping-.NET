Imports System.Text.RegularExpressions

Public Class GridViewNovaContrasenya
    Dim textContrasenya1 As String
    Dim textContrasenya2 As String

    Private Sub GridViewNovaContrasenya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' quan inicia surt la contrasenya amagada:
        textContrasenya1 = TextBoxContra1.Text
        TextBoxContra1.UseSystemPasswordChar = True
        TextBoxContra1.Text = textContrasenya1

        textContrasenya2 = TextBoxContra2.Text
        TextBoxContra2.UseSystemPasswordChar = True
        TextBoxContra2.Text = textContrasenya2
    End Sub
    Private Sub ButtonConfirmarContrasenya_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarContrasenya.Click
        Dim controlar As Boolean = True
        If (TextBoxContra1.Text.Equals("")) Then
            controlar = False
        End If
        If (TextBoxContra2.Text.Equals("")) Then
            controlar = False
        End If
        If (Not TextBoxContra1.Text.Equals(TextBoxContra2.Text)) Then
            controlar = False
        End If
        If (controlar) Then
            Dim correcte As Boolean = validarContrasenya(TextBoxContra2.Text)
            If (correcte) Then
                MsgBox("CONTRASENYA CANVIADA CORRECTAMENT!!!")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("ALGO A FALLAT, RECORDEU QUE LA CONTRASENYA HA DE CONTENIR COM A MINIM: " & vbNewLine &
                       "- 8 CARACTERS" & vbNewLine &
                       "- 1 MAJUSCULA" & vbNewLine &
                       "- 1 MINUSCULA" & vbNewLine &
                       "- 1 NUMERO" & vbNewLine &
                       "- 1 SIMBOL" & vbNewLine)
                TextBoxContra1.Text = ""
                TextBoxContra2.Text = ""
            End If
        Else
            MsgBox("ALGO A FALLAT, TORNA A INSERTAR LES CONTRASENYES")
            TextBoxContra1.Text = ""
            TextBoxContra2.Text = ""
        End If
    End Sub
    ' La següent funció validar que la contrasenya tingui els minims que s'han de complir
    Private Function validarContrasenya(ByVal contrasenya As String) As Boolean
        Dim regexMajuscula As New Regex("[A-Z]") ' almenys una majuscula
        Dim regexMinuscula As New Regex("[a-z]") ' almenys una minuscula
        Dim regexNumero As New Regex("\d") ' almenys un numero
        Dim regexSimbol As New Regex("[^\w]") ' almenys un simbol   

        If contrasenya.Length < 8 Then
            Return False
        End If
        If regexMajuscula.IsMatch(contrasenya) AndAlso regexMinuscula.IsMatch(contrasenya) AndAlso regexNumero.IsMatch(contrasenya) AndAlso regexSimbol.IsMatch(contrasenya) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CheckBoxMostrarContrasenya_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrarContrasenya.CheckedChanged
        textContrasenya1 = TextBoxContra1.Text
        textContrasenya2 = TextBoxContra2.Text
        If (CheckBoxMostrarContrasenya.Checked) Then
            TextBoxContra1.UseSystemPasswordChar = False
            TextBoxContra1.Text = textContrasenya1
            TextBoxContra2.UseSystemPasswordChar = False
            TextBoxContra2.Text = textContrasenya2
        Else
            TextBoxContra1.UseSystemPasswordChar = True
            TextBoxContra1.Text = textContrasenya1
            TextBoxContra2.UseSystemPasswordChar = True
            TextBoxContra2.Text = textContrasenya2
        End If

    End Sub

End Class