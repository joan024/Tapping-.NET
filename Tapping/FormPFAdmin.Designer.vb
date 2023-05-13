<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPFAdmin
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
        DataGridViewPF = New DataGridView()
        LabelTitolPF = New Label()
        Panel1 = New Panel()
        ButtonAccio = New Button()
        RadioButtonEliminar = New RadioButton()
        RadioButtonModificar = New RadioButton()
        RadioButtonAfegir = New RadioButton()
        TextBoxResposta = New TextBox()
        TextBoxPregunta = New TextBox()
        LabelResposta = New Label()
        LabelPregunta = New Label()
        ButtonEnrere = New Button()
        CType(DataGridViewPF, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridViewPF
        ' 
        DataGridViewPF.AllowUserToAddRows = False
        DataGridViewPF.AllowUserToDeleteRows = False
        DataGridViewPF.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewPF.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewPF.BackgroundColor = Color.White
        DataGridViewPF.ColumnHeadersHeight = 29
        DataGridViewPF.Location = New Point(12, 58)
        DataGridViewPF.Name = "DataGridViewPF"
        DataGridViewPF.ReadOnly = True
        DataGridViewPF.RowHeadersWidth = 51
        DataGridViewPF.RowTemplate.Height = 29
        DataGridViewPF.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewPF.Size = New Size(1756, 603)
        DataGridViewPF.TabIndex = 23
        ' 
        ' LabelTitolPF
        ' 
        LabelTitolPF.Anchor = AnchorStyles.Top
        LabelTitolPF.AutoSize = True
        LabelTitolPF.BackColor = Color.Transparent
        LabelTitolPF.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolPF.Location = New Point(704, 9)
        LabelTitolPF.Name = "LabelTitolPF"
        LabelTitolPF.Size = New Size(416, 46)
        LabelTitolPF.TabIndex = 22
        LabelTitolPF.Text = "PREGUNTES FREQÜENTS"
        LabelTitolPF.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.Controls.Add(ButtonAccio)
        Panel1.Controls.Add(RadioButtonEliminar)
        Panel1.Controls.Add(RadioButtonModificar)
        Panel1.Controls.Add(RadioButtonAfegir)
        Panel1.Controls.Add(TextBoxResposta)
        Panel1.Controls.Add(TextBoxPregunta)
        Panel1.Controls.Add(LabelResposta)
        Panel1.Controls.Add(LabelPregunta)
        Panel1.Location = New Point(12, 667)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1756, 125)
        Panel1.TabIndex = 24
        ' 
        ' ButtonAccio
        ' 
        ButtonAccio.Location = New Point(1627, 50)
        ButtonAccio.Name = "ButtonAccio"
        ButtonAccio.Size = New Size(94, 29)
        ButtonAccio.TabIndex = 31
        ButtonAccio.Text = "Fer l'acció"
        ButtonAccio.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonEliminar
        ' 
        RadioButtonEliminar.AutoSize = True
        RadioButtonEliminar.Location = New Point(1527, 50)
        RadioButtonEliminar.Name = "RadioButtonEliminar"
        RadioButtonEliminar.Size = New Size(84, 24)
        RadioButtonEliminar.TabIndex = 30
        RadioButtonEliminar.Text = "Eliminar"
        RadioButtonEliminar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonModificar
        ' 
        RadioButtonModificar.AutoSize = True
        RadioButtonModificar.Location = New Point(1417, 50)
        RadioButtonModificar.Name = "RadioButtonModificar"
        RadioButtonModificar.Size = New Size(94, 24)
        RadioButtonModificar.TabIndex = 29
        RadioButtonModificar.Text = "Modificar"
        RadioButtonModificar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonAfegir
        ' 
        RadioButtonAfegir.AutoSize = True
        RadioButtonAfegir.Checked = True
        RadioButtonAfegir.Location = New Point(1331, 50)
        RadioButtonAfegir.Name = "RadioButtonAfegir"
        RadioButtonAfegir.Size = New Size(71, 24)
        RadioButtonAfegir.TabIndex = 28
        RadioButtonAfegir.TabStop = True
        RadioButtonAfegir.Text = "Afegir"
        RadioButtonAfegir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxResposta
        ' 
        TextBoxResposta.Location = New Point(107, 66)
        TextBoxResposta.Name = "TextBoxResposta"
        TextBoxResposta.Size = New Size(1185, 27)
        TextBoxResposta.TabIndex = 13
        ' 
        ' TextBoxPregunta
        ' 
        TextBoxPregunta.Location = New Point(107, 29)
        TextBoxPregunta.Name = "TextBoxPregunta"
        TextBoxPregunta.Size = New Size(1185, 27)
        TextBoxPregunta.TabIndex = 12
        ' 
        ' LabelResposta
        ' 
        LabelResposta.AutoSize = True
        LabelResposta.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelResposta.Location = New Point(4, 62)
        LabelResposta.Name = "LabelResposta"
        LabelResposta.Size = New Size(97, 28)
        LabelResposta.TabIndex = 11
        LabelResposta.Text = "Resposta"
        ' 
        ' LabelPregunta
        ' 
        LabelPregunta.AutoSize = True
        LabelPregunta.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPregunta.Location = New Point(3, 25)
        LabelPregunta.Name = "LabelPregunta"
        LabelPregunta.Size = New Size(98, 28)
        LabelPregunta.TabIndex = 10
        LabelPregunta.Text = "Pregunta"
        ' 
        ' ButtonEnrere
        ' 
        ButtonEnrere.BackColor = Color.LightGray
        ButtonEnrere.BackgroundImage = My.Resources.Resources.enrere
        ButtonEnrere.BackgroundImageLayout = ImageLayout.Stretch
        ButtonEnrere.FlatAppearance.BorderColor = Color.White
        ButtonEnrere.FlatAppearance.BorderSize = 0
        ButtonEnrere.FlatStyle = FlatStyle.Flat
        ButtonEnrere.Location = New Point(12, 9)
        ButtonEnrere.Name = "ButtonEnrere"
        ButtonEnrere.Size = New Size(64, 43)
        ButtonEnrere.TabIndex = 25
        ButtonEnrere.UseVisualStyleBackColor = False
        ' 
        ' FormPFAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1780, 804)
        ControlBox = False
        Controls.Add(ButtonEnrere)
        Controls.Add(Panel1)
        Controls.Add(DataGridViewPF)
        Controls.Add(LabelTitolPF)
        Name = "FormPFAdmin"
        Text = "Preguntes Freqüents"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewPF, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridViewPF As DataGridView
    Friend WithEvents LabelTitolPF As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxResposta As TextBox
    Friend WithEvents TextBoxPregunta As TextBox
    Friend WithEvents LabelResposta As Label
    Friend WithEvents LabelPregunta As Label
    Friend WithEvents ButtonAccio As Button
    Friend WithEvents RadioButtonEliminar As RadioButton
    Friend WithEvents RadioButtonModificar As RadioButton
    Friend WithEvents RadioButtonAfegir As RadioButton
    Friend WithEvents ButtonEnrere As Button
End Class
