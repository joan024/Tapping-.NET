<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2NoticiesAdminvb
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
        LabelDescripcio = New Label()
        LabelTitol = New Label()
        TextBoxTitol = New TextBox()
        DateTimePickerPublicacio = New DateTimePicker()
        DateTimePickerInici = New DateTimePicker()
        DateTimePickerFi = New DateTimePicker()
        LabelPublicacio = New Label()
        LabelInici = New Label()
        LabelFi = New Label()
        Panel1 = New Panel()
        ButtonAccio = New Button()
        RadioButtonEliminar = New RadioButton()
        RadioButtonModificar = New RadioButton()
        RadioButtonAfegir = New RadioButton()
        LabelFoto = New Label()
        TextBoxFoto = New TextBox()
        TextBoxDescripcio = New TextBox()
        LabelTitolNoticies = New Label()
        DataGridViewNoticies = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelDescripcio
        ' 
        LabelDescripcio.AutoSize = True
        LabelDescripcio.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelDescripcio.Location = New Point(4, 64)
        LabelDescripcio.Name = "LabelDescripcio"
        LabelDescripcio.Size = New Size(111, 28)
        LabelDescripcio.TabIndex = 8
        LabelDescripcio.Text = "Descripció"
        ' 
        ' LabelTitol
        ' 
        LabelTitol.AutoSize = True
        LabelTitol.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitol.Location = New Point(4, 18)
        LabelTitol.Name = "LabelTitol"
        LabelTitol.Size = New Size(56, 28)
        LabelTitol.TabIndex = 9
        LabelTitol.Text = "Titol"
        ' 
        ' TextBoxTitol
        ' 
        TextBoxTitol.Location = New Point(66, 18)
        TextBoxTitol.Name = "TextBoxTitol"
        TextBoxTitol.Size = New Size(703, 27)
        TextBoxTitol.TabIndex = 11
        ' 
        ' DateTimePickerPublicacio
        ' 
        DateTimePickerPublicacio.CustomFormat = "yyyy-MM-dd"
        DateTimePickerPublicacio.Format = DateTimePickerFormat.Custom
        DateTimePickerPublicacio.Location = New Point(794, 86)
        DateTimePickerPublicacio.Name = "DateTimePickerPublicacio"
        DateTimePickerPublicacio.Size = New Size(250, 27)
        DateTimePickerPublicacio.TabIndex = 12
        DateTimePickerPublicacio.Value = New DateTime(2023, 4, 12, 21, 6, 17, 0)
        ' 
        ' DateTimePickerInici
        ' 
        DateTimePickerInici.CustomFormat = "yyyy-MM-dd"
        DateTimePickerInici.Format = DateTimePickerFormat.Custom
        DateTimePickerInici.Location = New Point(1059, 86)
        DateTimePickerInici.Name = "DateTimePickerInici"
        DateTimePickerInici.Size = New Size(250, 27)
        DateTimePickerInici.TabIndex = 13
        ' 
        ' DateTimePickerFi
        ' 
        DateTimePickerFi.CustomFormat = "yyyy-MM-dd"
        DateTimePickerFi.Format = DateTimePickerFormat.Custom
        DateTimePickerFi.Location = New Point(1325, 86)
        DateTimePickerFi.Name = "DateTimePickerFi"
        DateTimePickerFi.Size = New Size(250, 27)
        DateTimePickerFi.TabIndex = 14
        ' 
        ' LabelPublicacio
        ' 
        LabelPublicacio.AutoSize = True
        LabelPublicacio.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPublicacio.Location = New Point(842, 49)
        LabelPublicacio.Name = "LabelPublicacio"
        LabelPublicacio.Size = New Size(160, 28)
        LabelPublicacio.TabIndex = 15
        LabelPublicacio.Text = "Data Publicació"
        ' 
        ' LabelInici
        ' 
        LabelInici.AutoSize = True
        LabelInici.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelInici.Location = New Point(1130, 49)
        LabelInici.Name = "LabelInici"
        LabelInici.Size = New Size(103, 28)
        LabelInici.TabIndex = 16
        LabelInici.Text = "Data Inici"
        ' 
        ' LabelFi
        ' 
        LabelFi.AutoSize = True
        LabelFi.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelFi.Location = New Point(1413, 49)
        LabelFi.Name = "LabelFi"
        LabelFi.Size = New Size(79, 28)
        LabelFi.TabIndex = 17
        LabelFi.Text = "Data Fi"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.AutoSize = True
        Panel1.Controls.Add(ButtonAccio)
        Panel1.Controls.Add(RadioButtonEliminar)
        Panel1.Controls.Add(RadioButtonModificar)
        Panel1.Controls.Add(RadioButtonAfegir)
        Panel1.Controls.Add(LabelFoto)
        Panel1.Controls.Add(TextBoxFoto)
        Panel1.Controls.Add(TextBoxDescripcio)
        Panel1.Controls.Add(LabelTitol)
        Panel1.Controls.Add(LabelDescripcio)
        Panel1.Controls.Add(TextBoxTitol)
        Panel1.Controls.Add(LabelPublicacio)
        Panel1.Controls.Add(DateTimePickerFi)
        Panel1.Controls.Add(LabelFi)
        Panel1.Controls.Add(DateTimePickerPublicacio)
        Panel1.Controls.Add(LabelInici)
        Panel1.Controls.Add(DateTimePickerInici)
        Panel1.Location = New Point(12, 639)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1756, 152)
        Panel1.TabIndex = 21
        ' 
        ' ButtonAccio
        ' 
        ButtonAccio.Location = New Point(1617, 108)
        ButtonAccio.Name = "ButtonAccio"
        ButtonAccio.Size = New Size(94, 29)
        ButtonAccio.TabIndex = 27
        ButtonAccio.Text = "Fer l'acció"
        ButtonAccio.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonEliminar
        ' 
        RadioButtonEliminar.AutoSize = True
        RadioButtonEliminar.Location = New Point(1617, 78)
        RadioButtonEliminar.Name = "RadioButtonEliminar"
        RadioButtonEliminar.Size = New Size(84, 24)
        RadioButtonEliminar.TabIndex = 26
        RadioButtonEliminar.Text = "Eliminar"
        RadioButtonEliminar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonModificar
        ' 
        RadioButtonModificar.AutoSize = True
        RadioButtonModificar.Location = New Point(1617, 48)
        RadioButtonModificar.Name = "RadioButtonModificar"
        RadioButtonModificar.Size = New Size(94, 24)
        RadioButtonModificar.TabIndex = 25
        RadioButtonModificar.Text = "Modificar"
        RadioButtonModificar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonAfegir
        ' 
        RadioButtonAfegir.AutoSize = True
        RadioButtonAfegir.Checked = True
        RadioButtonAfegir.Location = New Point(1617, 18)
        RadioButtonAfegir.Name = "RadioButtonAfegir"
        RadioButtonAfegir.Size = New Size(71, 24)
        RadioButtonAfegir.TabIndex = 24
        RadioButtonAfegir.TabStop = True
        RadioButtonAfegir.Text = "Afegir"
        RadioButtonAfegir.UseVisualStyleBackColor = True
        ' 
        ' LabelFoto
        ' 
        LabelFoto.AutoSize = True
        LabelFoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelFoto.Location = New Point(6, 112)
        LabelFoto.Name = "LabelFoto"
        LabelFoto.Size = New Size(54, 28)
        LabelFoto.TabIndex = 23
        LabelFoto.Text = "Foto"
        ' 
        ' TextBoxFoto
        ' 
        TextBoxFoto.Location = New Point(66, 113)
        TextBoxFoto.Name = "TextBoxFoto"
        TextBoxFoto.Size = New Size(703, 27)
        TextBoxFoto.TabIndex = 22
        ' 
        ' TextBoxDescripcio
        ' 
        TextBoxDescripcio.Location = New Point(121, 53)
        TextBoxDescripcio.Margin = New Padding(3, 4, 3, 4)
        TextBoxDescripcio.Multiline = True
        TextBoxDescripcio.Name = "TextBoxDescripcio"
        TextBoxDescripcio.ScrollBars = ScrollBars.Vertical
        TextBoxDescripcio.Size = New Size(648, 53)
        TextBoxDescripcio.TabIndex = 21
        ' 
        ' LabelTitolNoticies
        ' 
        LabelTitolNoticies.Anchor = AnchorStyles.Top
        LabelTitolNoticies.AutoSize = True
        LabelTitolNoticies.BackColor = Color.Transparent
        LabelTitolNoticies.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolNoticies.Location = New Point(830, 9)
        LabelTitolNoticies.Name = "LabelTitolNoticies"
        LabelTitolNoticies.Size = New Size(172, 46)
        LabelTitolNoticies.TabIndex = 1
        LabelTitolNoticies.Text = "NOTÍCIES"
        LabelTitolNoticies.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DataGridViewNoticies
        ' 
        DataGridViewNoticies.AllowUserToAddRows = False
        DataGridViewNoticies.AllowUserToDeleteRows = False
        DataGridViewNoticies.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewNoticies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewNoticies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewNoticies.BackgroundColor = Color.White
        DataGridViewNoticies.ColumnHeadersHeight = 29
        DataGridViewNoticies.Location = New Point(12, 58)
        DataGridViewNoticies.Name = "DataGridViewNoticies"
        DataGridViewNoticies.ReadOnly = True
        DataGridViewNoticies.RowHeadersWidth = 51
        DataGridViewNoticies.RowTemplate.Height = 29
        DataGridViewNoticies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewNoticies.Size = New Size(1756, 575)
        DataGridViewNoticies.TabIndex = 2
        ' 
        ' Form2NoticiesAdminvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1780, 804)
        Controls.Add(Panel1)
        Controls.Add(DataGridViewNoticies)
        Controls.Add(LabelTitolNoticies)
        Name = "Form2NoticiesAdminvb"
        Text = "Form2NoticiesAdminvb"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LabelDescripcio As Label
    Friend WithEvents LabelTitol As Label
    Friend WithEvents TextBoxTitol As TextBox
    Friend WithEvents DateTimePickerPublicacio As DateTimePicker
    Friend WithEvents DateTimePickerInici As DateTimePicker
    Friend WithEvents DateTimePickerFi As DateTimePicker
    Friend WithEvents LabelPublicacio As Label
    Friend WithEvents LabelInici As Label
    Friend WithEvents LabelFi As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxDescripcio As TextBox
    Friend WithEvents LabelFoto As Label
    Friend WithEvents TextBoxFoto As TextBox
    Friend WithEvents RadioButtonEliminar As RadioButton
    Friend WithEvents RadioButtonModificar As RadioButton
    Friend WithEvents RadioButtonAfegir As RadioButton
    Friend WithEvents ButtonAccio As Button
    Friend WithEvents LabelTitolNoticies As Label
    Friend WithEvents DataGridViewNoticies As DataGridView
End Class
