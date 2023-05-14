<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LesMevesTapes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridViewTapes = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        ComboBoxLocal = New ComboBox()
        Label5 = New Label()
        ComboBoxNom = New ComboBox()
        RadioButtonEliminar = New RadioButton()
        RadioButtonActualitzar = New RadioButton()
        RadioButtonAfegir = New RadioButton()
        TextBoxPreu = New TextBox()
        ButtonConfirmarTapes = New Button()
        TextBoxPersonalitzacio = New TextBox()
        CType(DataGridViewTapes, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridViewTapes
        ' 
        DataGridViewTapes.AllowUserToAddRows = False
        DataGridViewTapes.AllowUserToDeleteRows = False
        DataGridViewTapes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewTapes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewTapes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewTapes.BackgroundColor = Color.White
        DataGridViewTapes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTapes.Location = New Point(11, 69)
        DataGridViewTapes.Margin = New Padding(2)
        DataGridViewTapes.Name = "DataGridViewTapes"
        DataGridViewTapes.ReadOnly = True
        DataGridViewTapes.RowHeadersVisible = False
        DataGridViewTapes.RowHeadersWidth = 62
        DataGridViewTapes.RowTemplate.Height = 33
        DataGridViewTapes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewTapes.Size = New Size(612, 697)
        DataGridViewTapes.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(11, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 41)
        Label1.TabIndex = 2
        Label1.Text = "LES MEVES TAPES"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(48, 125)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 37)
        Label2.TabIndex = 3
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(48, 232)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 37)
        Label3.TabIndex = 4
        Label3.Text = "Personalització"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(48, 330)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 37)
        Label4.TabIndex = 5
        Label4.Text = "Preu"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(ComboBoxLocal)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ComboBoxNom)
        Panel1.Controls.Add(RadioButtonEliminar)
        Panel1.Controls.Add(RadioButtonActualitzar)
        Panel1.Controls.Add(RadioButtonAfegir)
        Panel1.Controls.Add(TextBoxPreu)
        Panel1.Controls.Add(ButtonConfirmarTapes)
        Panel1.Controls.Add(TextBoxPersonalitzacio)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(627, 52)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(995, 714)
        Panel1.TabIndex = 13
        ' 
        ' ComboBoxLocal
        ' 
        ComboBoxLocal.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxLocal.FormattingEnabled = True
        ComboBoxLocal.Location = New Point(48, 79)
        ComboBoxLocal.Margin = New Padding(2)
        ComboBoxLocal.Name = "ComboBoxLocal"
        ComboBoxLocal.Size = New Size(240, 28)
        ComboBoxLocal.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(48, 17)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 37)
        Label5.TabIndex = 18
        Label5.Text = "Local"
        ' 
        ' ComboBoxNom
        ' 
        ComboBoxNom.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxNom.FormattingEnabled = True
        ComboBoxNom.Location = New Point(48, 182)
        ComboBoxNom.Margin = New Padding(2)
        ComboBoxNom.Name = "ComboBoxNom"
        ComboBoxNom.Size = New Size(240, 28)
        ComboBoxNom.TabIndex = 14
        ' 
        ' RadioButtonEliminar
        ' 
        RadioButtonEliminar.AutoSize = True
        RadioButtonEliminar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonEliminar.Location = New Point(402, 462)
        RadioButtonEliminar.Margin = New Padding(2)
        RadioButtonEliminar.Name = "RadioButtonEliminar"
        RadioButtonEliminar.Size = New Size(139, 36)
        RadioButtonEliminar.TabIndex = 17
        RadioButtonEliminar.TabStop = True
        RadioButtonEliminar.Text = "ELIMINAR"
        RadioButtonEliminar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonActualitzar
        ' 
        RadioButtonActualitzar.AutoSize = True
        RadioButtonActualitzar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonActualitzar.Location = New Point(194, 462)
        RadioButtonActualitzar.Margin = New Padding(2)
        RadioButtonActualitzar.Name = "RadioButtonActualitzar"
        RadioButtonActualitzar.Size = New Size(181, 36)
        RadioButtonActualitzar.TabIndex = 16
        RadioButtonActualitzar.TabStop = True
        RadioButtonActualitzar.Text = "ACTUALITZAR"
        RadioButtonActualitzar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonAfegir
        ' 
        RadioButtonAfegir.AutoSize = True
        RadioButtonAfegir.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonAfegir.Location = New Point(48, 462)
        RadioButtonAfegir.Margin = New Padding(2)
        RadioButtonAfegir.Name = "RadioButtonAfegir"
        RadioButtonAfegir.Size = New Size(110, 36)
        RadioButtonAfegir.TabIndex = 14
        RadioButtonAfegir.TabStop = True
        RadioButtonAfegir.Text = "AFEGIR"
        RadioButtonAfegir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPreu
        ' 
        TextBoxPreu.Location = New Point(48, 378)
        TextBoxPreu.Margin = New Padding(2)
        TextBoxPreu.Name = "TextBoxPreu"
        TextBoxPreu.Size = New Size(145, 27)
        TextBoxPreu.TabIndex = 15
        ' 
        ' ButtonConfirmarTapes
        ' 
        ButtonConfirmarTapes.BackColor = Color.White
        ButtonConfirmarTapes.Location = New Point(181, 561)
        ButtonConfirmarTapes.Margin = New Padding(2)
        ButtonConfirmarTapes.Name = "ButtonConfirmarTapes"
        ButtonConfirmarTapes.Size = New Size(220, 61)
        ButtonConfirmarTapes.TabIndex = 14
        ButtonConfirmarTapes.Text = "OK"
        ButtonConfirmarTapes.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPersonalitzacio
        ' 
        TextBoxPersonalitzacio.Location = New Point(48, 281)
        TextBoxPersonalitzacio.Margin = New Padding(2)
        TextBoxPersonalitzacio.Name = "TextBoxPersonalitzacio"
        TextBoxPersonalitzacio.Size = New Size(240, 27)
        TextBoxPersonalitzacio.TabIndex = 12
        ' 
        ' LesMevesTapes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ClientSize = New Size(1633, 777)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(DataGridViewTapes)
        Margin = New Padding(2)
        Name = "LesMevesTapes"
        Text = "LesMevesTapes"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewTapes, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridViewTapes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonConfirmarTapes As Button
    Friend WithEvents TextBoxPersonalitzacio As TextBox
    Friend WithEvents TextBoxPreu As TextBox
    Friend WithEvents RadioButtonEliminar As RadioButton
    Friend WithEvents RadioButtonActualitzar As RadioButton
    Friend WithEvents RadioButtonAfegir As RadioButton
    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents ComboBoxLocal As ComboBox
    Friend WithEvents Label5 As Label
End Class