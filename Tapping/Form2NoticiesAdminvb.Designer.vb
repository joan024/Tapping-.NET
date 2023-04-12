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
        LabelTitolNoticies = New Label()
        DataGridViewNoticies = New DataGridView()
        TextBoxXat = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBoxTitol = New TextBox()
        DateTimePickerPublicacio = New DateTimePicker()
        DateTimePickerInici = New DateTimePicker()
        DateTimePickerFi = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        TextBoxFoto = New TextBox()
        TextBoxDescripcio = New TextBox()
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        DataGridViewNoticies.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridViewNoticies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewNoticies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewNoticies.BackgroundColor = Color.White
        DataGridViewNoticies.ColumnHeadersHeight = 29
        DataGridViewNoticies.Location = New Point(12, 58)
        DataGridViewNoticies.Name = "DataGridViewNoticies"
        DataGridViewNoticies.ReadOnly = True
        DataGridViewNoticies.RowHeadersWidth = 51
        DataGridViewNoticies.RowTemplate.Height = 29
        DataGridViewNoticies.Size = New Size(1756, 575)
        DataGridViewNoticies.TabIndex = 2
        ' 
        ' TextBoxXat
        ' 
        TextBoxXat.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxXat.Location = New Point(129, 66)
        TextBoxXat.Margin = New Padding(3, 4, 3, 4)
        TextBoxXat.Multiline = True
        TextBoxXat.Name = "TextBoxXat"
        TextBoxXat.ScrollBars = ScrollBars.Vertical
        TextBoxXat.Size = New Size(0, 53)
        TextBoxXat.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(4, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 28)
        Label1.TabIndex = 8
        Label1.Text = "Descripció"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(4, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 28)
        Label2.TabIndex = 9
        Label2.Text = "Titol"
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
        DateTimePickerPublicacio.Location = New Point(794, 86)
        DateTimePickerPublicacio.Name = "DateTimePickerPublicacio"
        DateTimePickerPublicacio.Size = New Size(250, 27)
        DateTimePickerPublicacio.TabIndex = 12
        DateTimePickerPublicacio.Value = New DateTime(2023, 4, 12, 20, 43, 37, 0)
        ' 
        ' DateTimePickerInici
        ' 
        DateTimePickerInici.Location = New Point(1059, 86)
        DateTimePickerInici.Name = "DateTimePickerInici"
        DateTimePickerInici.Size = New Size(250, 27)
        DateTimePickerInici.TabIndex = 13
        ' 
        ' DateTimePickerFi
        ' 
        DateTimePickerFi.Location = New Point(1325, 86)
        DateTimePickerFi.Name = "DateTimePickerFi"
        DateTimePickerFi.Size = New Size(250, 27)
        DateTimePickerFi.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(842, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 28)
        Label3.TabIndex = 15
        Label3.Text = "Data Publicació"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(1130, 49)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 28)
        Label4.TabIndex = 16
        Label4.Text = "Data Inici"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(1413, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 28)
        Label5.TabIndex = 17
        Label5.Text = "Data Fi"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1631, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 29)
        Button1.TabIndex = 18
        Button1.Text = "Afegir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1631, 65)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 29)
        Button2.TabIndex = 19
        Button2.Text = "Modificació"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1631, 100)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 29)
        Button3.TabIndex = 20
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.AutoSize = True
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBoxFoto)
        Panel1.Controls.Add(TextBoxDescripcio)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBoxTitol)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(DateTimePickerFi)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(DateTimePickerPublicacio)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(DateTimePickerInici)
        Panel1.Location = New Point(12, 639)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1756, 152)
        Panel1.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(6, 112)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 28)
        Label6.TabIndex = 23
        Label6.Text = "Foto"
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
        TextBoxDescripcio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxDescripcio.Location = New Point(121, 53)
        TextBoxDescripcio.Margin = New Padding(3, 4, 3, 4)
        TextBoxDescripcio.Multiline = True
        TextBoxDescripcio.Name = "TextBoxDescripcio"
        TextBoxDescripcio.ScrollBars = ScrollBars.Vertical
        TextBoxDescripcio.Size = New Size(648, 53)
        TextBoxDescripcio.TabIndex = 21
        ' 
        ' Form2NoticiesAdminvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1780, 804)
        Controls.Add(Panel1)
        Controls.Add(TextBoxXat)
        Controls.Add(DataGridViewNoticies)
        Controls.Add(LabelTitolNoticies)
        Name = "Form2NoticiesAdminvb"
        Text = "Form2NoticiesAdminvb"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTitolNoticies As Label
    Friend WithEvents DataGridViewNoticies As DataGridView
    Friend WithEvents TextBoxXat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTitol As TextBox
    Friend WithEvents DateTimePickerPublicacio As DateTimePicker
    Friend WithEvents DateTimePickerInici As DateTimePicker
    Friend WithEvents DateTimePickerFi As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxDescripcio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxFoto As TextBox
End Class
