<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciSessio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(IniciSessio))
        usuari = New Label()
        TextBoxUsuari = New TextBox()
        Label2 = New Label()
        TextBoxContrasenya = New TextBox()
        ButtonLogin = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        CheckBoxMostrarContrasenya = New CheckBox()
        Label3 = New Label()
        ButtonSortir = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ButtonSortir, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' usuari
        ' 
        usuari.AutoSize = True
        usuari.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        usuari.Location = New Point(286, 332)
        usuari.Name = "usuari"
        usuari.Size = New Size(258, 23)
        usuari.TabIndex = 3
        usuari.Text = "Introdueix el nom d'usuari"
        ' 
        ' TextBoxUsuari
        ' 
        TextBoxUsuari.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxUsuari.Location = New Point(286, 378)
        TextBoxUsuari.Margin = New Padding(3, 4, 3, 4)
        TextBoxUsuari.Name = "TextBoxUsuari"
        TextBoxUsuari.Size = New Size(318, 32)
        TextBoxUsuari.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(286, 470)
        Label2.Name = "Label2"
        Label2.Size = New Size(259, 23)
        Label2.TabIndex = 5
        Label2.Text = "Introdueix la contrasenya"
        ' 
        ' TextBoxContrasenya
        ' 
        TextBoxContrasenya.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxContrasenya.Location = New Point(286, 522)
        TextBoxContrasenya.Margin = New Padding(3, 4, 3, 4)
        TextBoxContrasenya.Name = "TextBoxContrasenya"
        TextBoxContrasenya.Size = New Size(318, 32)
        TextBoxContrasenya.TabIndex = 6
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ButtonLogin.FlatAppearance.BorderSize = 0
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.Location = New Point(370, 646)
        ButtonLogin.Margin = New Padding(3, 4, 3, 4)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(134, 60)
        ButtonLogin.TabIndex = 7
        ButtonLogin.Text = "LOGIN"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogoTappingSenseFondo
        PictureBox1.Location = New Point(355, 46)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(51, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 28)
        Label1.TabIndex = 9
        Label1.Text = "Benvingut a Tapping!"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Right
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(CheckBoxMostrarContrasenya)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ButtonSortir)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ButtonLogin)
        Panel1.Controls.Add(TextBoxContrasenya)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(usuari)
        Panel1.Controls.Add(TextBoxUsuari)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(10, 11)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(850, 786)
        Panel1.TabIndex = 10
        ' 
        ' CheckBoxMostrarContrasenya
        ' 
        CheckBoxMostrarContrasenya.AutoSize = True
        CheckBoxMostrarContrasenya.Location = New Point(361, 583)
        CheckBoxMostrarContrasenya.Margin = New Padding(2)
        CheckBoxMostrarContrasenya.Name = "CheckBoxMostrarContrasenya"
        CheckBoxMostrarContrasenya.Size = New Size(167, 24)
        CheckBoxMostrarContrasenya.TabIndex = 12
        CheckBoxMostrarContrasenya.Text = "Mostrar Contrasenya"
        CheckBoxMostrarContrasenya.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(286, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(321, 22)
        Label3.TabIndex = 11
        Label3.Text = "Inicia sessió per accedir a Tapping"
        ' 
        ' ButtonSortir
        ' 
        ButtonSortir.Image = CType(resources.GetObject("ButtonSortir.Image"), Image)
        ButtonSortir.Location = New Point(801, 26)
        ButtonSortir.Margin = New Padding(3, 4, 3, 4)
        ButtonSortir.Name = "ButtonSortir"
        ButtonSortir.Size = New Size(32, 34)
        ButtonSortir.TabIndex = 10
        ButtonSortir.TabStop = False
        ' 
        ' IniciSessio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ClientSize = New Size(1536, 882)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "IniciSessio"
        Text = "IniciSessio"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ButtonSortir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents usuari As Label
    Friend WithEvents TextBoxUsuari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxContrasenya As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonSortir As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBoxMostrarContrasenya As CheckBox
End Class
