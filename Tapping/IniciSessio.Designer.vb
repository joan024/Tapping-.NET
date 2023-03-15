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
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
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
        usuari.Location = New Point(357, 415)
        usuari.Margin = New Padding(4, 0, 4, 0)
        usuari.Name = "usuari"
        usuari.Size = New Size(318, 30)
        usuari.TabIndex = 3
        usuari.Text = "Introdueix el nom d'usuari"' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(357, 472)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(397, 37)
        TextBox1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(357, 588)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(314, 30)
        Label2.TabIndex = 5
        Label2.Text = "Introdueix la contrasenya"' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(357, 652)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(397, 37)
        TextBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(463, 807)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 75)
        Button1.TabIndex = 7
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogoTappingSenseFondo
        PictureBox1.Location = New Point(444, 57)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(210, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(64, 85)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 36)
        Label1.TabIndex = 9
        Label1.Text = "Benvingut a Tapping!"' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ButtonSortir)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(usuari)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(421, 115)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1061, 982)
        Panel1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(357, 300)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(406, 27)
        Label3.TabIndex = 11
        Label3.Text = "Inicia sessió per accedir a Tapping"' 
        ' ButtonSortir
        ' 
        ButtonSortir.Image = CType(resources.GetObject("ButtonSortir.Image"), Image)
        ButtonSortir.Location = New Point(1001, 33)
        ButtonSortir.Margin = New Padding(4, 5, 4, 5)
        ButtonSortir.Name = "ButtonSortir"
        ButtonSortir.Size = New Size(40, 42)
        ButtonSortir.TabIndex = 10
        ButtonSortir.TabStop = False
        ' 
        ' IniciSessio
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ClientSize = New Size(1920, 1242)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "IniciSessio"
        Text = "IniciSessio"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ButtonSortir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents usuari As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonSortir As PictureBox
    Friend WithEvents Label3 As Label
End Class
