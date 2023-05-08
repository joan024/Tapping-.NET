<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridViewNovaContrasenya
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxContra1 = New TextBox()
        TextBoxContra2 = New TextBox()
        ButtonConfirmarContrasenya = New Button()
        CheckBoxMostrarContrasenya = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(593, 25)
        Label1.TabIndex = 0
        Label1.Text = "PER PODER ACCEDIR A TAPPING TENS QUE CANVIAR LA CONTRASENYA"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(192, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 25)
        Label2.TabIndex = 1
        Label2.Text = "Introdueix la contrasenya:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(192, 273)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 25)
        Label3.TabIndex = 2
        Label3.Text = "Repeteix la contrasenya:"' 
        ' TextBoxContra1
        ' 
        TextBoxContra1.Location = New Point(479, 168)
        TextBoxContra1.Name = "TextBoxContra1"
        TextBoxContra1.Size = New Size(150, 31)
        TextBoxContra1.TabIndex = 3
        ' 
        ' TextBoxContra2
        ' 
        TextBoxContra2.Location = New Point(479, 270)
        TextBoxContra2.Name = "TextBoxContra2"
        TextBoxContra2.Size = New Size(150, 31)
        TextBoxContra2.TabIndex = 4
        ' 
        ' ButtonConfirmarContrasenya
        ' 
        ButtonConfirmarContrasenya.Location = New Point(407, 452)
        ButtonConfirmarContrasenya.Name = "ButtonConfirmarContrasenya"
        ButtonConfirmarContrasenya.Size = New Size(150, 44)
        ButtonConfirmarContrasenya.TabIndex = 5
        ButtonConfirmarContrasenya.Text = "CONFIRMAR"
        ButtonConfirmarContrasenya.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMostrarContrasenya
        ' 
        CheckBoxMostrarContrasenya.AutoSize = True
        CheckBoxMostrarContrasenya.Location = New Point(387, 367)
        CheckBoxMostrarContrasenya.Name = "CheckBoxMostrarContrasenya"
        CheckBoxMostrarContrasenya.Size = New Size(198, 29)
        CheckBoxMostrarContrasenya.TabIndex = 6
        CheckBoxMostrarContrasenya.Text = "MostrarContrasenya"
        CheckBoxMostrarContrasenya.UseVisualStyleBackColor = True
        ' 
        ' GridViewNovaContrasenya
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(959, 570)
        ControlBox = False
        Controls.Add(CheckBoxMostrarContrasenya)
        Controls.Add(ButtonConfirmarContrasenya)
        Controls.Add(TextBoxContra2)
        Controls.Add(TextBoxContra1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "GridViewNovaContrasenya"
        Text = "GridViewNovaContrasenya"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxContra1 As TextBox
    Friend WithEvents TextBoxContra2 As TextBox
    Friend WithEvents ButtonConfirmarContrasenya As Button
    Friend WithEvents CheckBoxMostrarContrasenya As CheckBox
End Class
