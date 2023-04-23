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
        Label1.Location = New Point(316, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nom: "' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(316, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 25)
        Label2.TabIndex = 1
        Label2.Text = "Correu: "' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(316, 343)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 25)
        Label3.TabIndex = 2
        Label3.Text = "Contrasenya: "' 
        ' TextBoxNom
        ' 
        TextBoxNom.Location = New Point(453, 179)
        TextBoxNom.Name = "TextBoxNom"
        TextBoxNom.Size = New Size(150, 31)
        TextBoxNom.TabIndex = 3
        ' 
        ' TextBoxCorreu
        ' 
        TextBoxCorreu.Location = New Point(453, 258)
        TextBoxCorreu.Name = "TextBoxCorreu"
        TextBoxCorreu.Size = New Size(150, 31)
        TextBoxCorreu.TabIndex = 4
        ' 
        ' TextBoxContrasenya
        ' 
        TextBoxContrasenya.Location = New Point(453, 343)
        TextBoxContrasenya.Name = "TextBoxContrasenya"
        TextBoxContrasenya.Size = New Size(150, 31)
        TextBoxContrasenya.TabIndex = 5
        ' 
        ' DateTimePickerDataRegistre
        ' 
        DateTimePickerDataRegistre.CustomFormat = "yyyy-MM-dd"
        DateTimePickerDataRegistre.Format = DateTimePickerFormat.Custom
        DateTimePickerDataRegistre.Location = New Point(850, 177)
        DateTimePickerDataRegistre.Name = "DateTimePickerDataRegistre"
        DateTimePickerDataRegistre.Size = New Size(300, 31)
        DateTimePickerDataRegistre.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(690, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 25)
        Label4.TabIndex = 7
        Label4.Text = "Data Registre: "' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(690, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 25)
        Label5.TabIndex = 8
        Label5.Text = "Actiu: "' 
        ' ComboBoxActiu
        ' 
        ComboBoxActiu.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxActiu.FormattingEnabled = True
        ComboBoxActiu.Items.AddRange(New Object() {"Si", "No"})
        ComboBoxActiu.Location = New Point(850, 258)
        ComboBoxActiu.Name = "ComboBoxActiu"
        ComboBoxActiu.Size = New Size(182, 33)
        ComboBoxActiu.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(316, 84)
        Label6.Name = "Label6"
        Label6.Size = New Size(801, 25)
        Label6.TabIndex = 10
        Label6.Text = "PER PODER AFEGIR UNA NOVA EMPRESA PRIMER TENIU QUE EMPLENAR AQUESTS CAMPS:"' 
        ' ButtonUsuari
        ' 
        ButtonUsuari.Location = New Point(618, 442)
        ButtonUsuari.Name = "ButtonUsuari"
        ButtonUsuari.Size = New Size(144, 50)
        ButtonUsuari.TabIndex = 11
        ButtonUsuari.Text = "CONFIRMAR"
        ButtonUsuari.UseVisualStyleBackColor = True
        ' 
        ' FormAfegirUsuari
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 694)
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
        Name = "FormAfegirUsuari"
        Text = "FormAfegirUsuari"
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
