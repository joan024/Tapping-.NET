<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAfegirUsuari
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
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxNom = New TextBox()
        TextBoxCorreu = New TextBox()
        TextBoxContrasenya = New TextBox()
        DateTimePickerDataRegistre = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        ComboBoxActiu = New ComboBox()
        Label6 = New Label()
        ButtonUsuari = New Button()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(253, 146)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nom: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(253, 209)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 1
        Label2.Text = "Correu: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(253, 274)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 2
        Label3.Text = "Contrasenya: "
        ' 
        ' TextBoxNom
        ' 
        TextBoxNom.Location = New Point(362, 143)
        TextBoxNom.Margin = New Padding(2, 2, 2, 2)
        TextBoxNom.Name = "TextBoxNom"
        TextBoxNom.Size = New Size(121, 27)
        TextBoxNom.TabIndex = 3
        ' 
        ' TextBoxCorreu
        ' 
        TextBoxCorreu.Location = New Point(362, 206)
        TextBoxCorreu.Margin = New Padding(2, 2, 2, 2)
        TextBoxCorreu.Name = "TextBoxCorreu"
        TextBoxCorreu.Size = New Size(121, 27)
        TextBoxCorreu.TabIndex = 4
        ' 
        ' TextBoxContrasenya
        ' 
        TextBoxContrasenya.Location = New Point(362, 274)
        TextBoxContrasenya.Margin = New Padding(2, 2, 2, 2)
        TextBoxContrasenya.Name = "TextBoxContrasenya"
        TextBoxContrasenya.Size = New Size(121, 27)
        TextBoxContrasenya.TabIndex = 5
        ' 
        ' DateTimePickerDataRegistre
        ' 
        DateTimePickerDataRegistre.CustomFormat = "yyyy-MM-dd"
        DateTimePickerDataRegistre.Format = DateTimePickerFormat.Custom
        DateTimePickerDataRegistre.Location = New Point(680, 142)
        DateTimePickerDataRegistre.Margin = New Padding(2, 2, 2, 2)
        DateTimePickerDataRegistre.Name = "DateTimePickerDataRegistre"
        DateTimePickerDataRegistre.Size = New Size(241, 27)
        DateTimePickerDataRegistre.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(552, 146)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 20)
        Label4.TabIndex = 7
        Label4.Text = "Data Registre: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(552, 209)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 8
        Label5.Text = "Actiu: "
        ' 
        ' ComboBoxActiu
        ' 
        ComboBoxActiu.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxActiu.FormattingEnabled = True
        ComboBoxActiu.Items.AddRange(New Object() {"Si", "No"})
        ComboBoxActiu.Location = New Point(680, 206)
        ComboBoxActiu.Margin = New Padding(2, 2, 2, 2)
        ComboBoxActiu.Name = "ComboBoxActiu"
        ComboBoxActiu.Size = New Size(146, 28)
        ComboBoxActiu.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(253, 67)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(659, 20)
        Label6.TabIndex = 10
        Label6.Text = "PER PODER AFEGIR UNA NOVA EMPRESA PRIMER TENIU QUE EMPLENAR AQUESTS CAMPS:"
        ' 
        ' ButtonUsuari
        ' 
        ButtonUsuari.Location = New Point(494, 354)
        ButtonUsuari.Margin = New Padding(2, 2, 2, 2)
        ButtonUsuari.Name = "ButtonUsuari"
        ButtonUsuari.Size = New Size(115, 40)
        ButtonUsuari.TabIndex = 11
        ButtonUsuari.Text = "CONFIRMAR"
        ButtonUsuari.UseVisualStyleBackColor = True
        ' 
        ' FormAfegirUsuari
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1142, 555)
        Controls.Add(ButtonUsuari)
        Controls.Add(Label6)
        Controls.Add(ComboBoxActiu)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DateTimePickerDataRegistre)
        Controls.Add(TextBoxContrasenya)
        Controls.Add(TextBoxCorreu)
        Controls.Add(TextBoxNom)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "FormAfegirUsuari"
        Text = "Usuari"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxCorreu As TextBox
    Friend WithEvents TextBoxContrasenya As TextBox
    Friend WithEvents DateTimePickerDataRegistre As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxActiu As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonUsuari As Button
End Class
