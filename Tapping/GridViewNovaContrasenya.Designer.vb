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
        Label1.Location = New Point(154, 50)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(490, 20)
        Label1.TabIndex = 0
        Label1.Text = "PER PODER ACCEDIR A TAPPING TENS QUE CANVIAR LA CONTRASENYA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(154, 137)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 20)
        Label2.TabIndex = 1
        Label2.Text = "Introdueix la contrasenya:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(154, 218)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 20)
        Label3.TabIndex = 2
        Label3.Text = "Repeteix la contrasenya:"
        ' 
        ' TextBoxContra1
        ' 
        TextBoxContra1.Location = New Point(383, 134)
        TextBoxContra1.Margin = New Padding(2, 2, 2, 2)
        TextBoxContra1.Name = "TextBoxContra1"
        TextBoxContra1.Size = New Size(121, 27)
        TextBoxContra1.TabIndex = 3
        ' 
        ' TextBoxContra2
        ' 
        TextBoxContra2.Location = New Point(383, 216)
        TextBoxContra2.Margin = New Padding(2, 2, 2, 2)
        TextBoxContra2.Name = "TextBoxContra2"
        TextBoxContra2.Size = New Size(121, 27)
        TextBoxContra2.TabIndex = 4
        ' 
        ' ButtonConfirmarContrasenya
        ' 
        ButtonConfirmarContrasenya.Location = New Point(326, 362)
        ButtonConfirmarContrasenya.Margin = New Padding(2, 2, 2, 2)
        ButtonConfirmarContrasenya.Name = "ButtonConfirmarContrasenya"
        ButtonConfirmarContrasenya.Size = New Size(120, 35)
        ButtonConfirmarContrasenya.TabIndex = 5
        ButtonConfirmarContrasenya.Text = "CONFIRMAR"
        ButtonConfirmarContrasenya.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMostrarContrasenya
        ' 
        CheckBoxMostrarContrasenya.AutoSize = True
        CheckBoxMostrarContrasenya.Location = New Point(310, 294)
        CheckBoxMostrarContrasenya.Margin = New Padding(2, 2, 2, 2)
        CheckBoxMostrarContrasenya.Name = "CheckBoxMostrarContrasenya"
        CheckBoxMostrarContrasenya.Size = New Size(163, 24)
        CheckBoxMostrarContrasenya.TabIndex = 6
        CheckBoxMostrarContrasenya.Text = "MostrarContrasenya"
        CheckBoxMostrarContrasenya.UseVisualStyleBackColor = True
        ' 
        ' GridViewNovaContrasenya
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 456)
        ControlBox = False
        Controls.Add(CheckBoxMostrarContrasenya)
        Controls.Add(ButtonConfirmarContrasenya)
        Controls.Add(TextBoxContra2)
        Controls.Add(TextBoxContra1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "GridViewNovaContrasenya"
        Text = "Nova Contrasenya"
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
