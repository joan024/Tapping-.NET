<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNoticiesAdmin
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
        Me.LabelDescripcio = New System.Windows.Forms.Label()
        Me.LabelTitol = New System.Windows.Forms.Label()
        Me.TextBoxTitol = New System.Windows.Forms.TextBox()
        Me.DateTimePickerPublicacio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerInici = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFi = New System.Windows.Forms.DateTimePicker()
        Me.LabelPublicacio = New System.Windows.Forms.Label()
        Me.LabelInici = New System.Windows.Forms.Label()
        Me.LabelFi = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonAccio = New System.Windows.Forms.Button()
        Me.RadioButtonEliminar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModificar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAfegir = New System.Windows.Forms.RadioButton()
        Me.LabelFoto = New System.Windows.Forms.Label()
        Me.TextBoxFoto = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcio = New System.Windows.Forms.TextBox()
        Me.LabelTitolNoticies = New System.Windows.Forms.Label()
        Me.DataGridViewNoticies = New System.Windows.Forms.DataGridView()
        Me.ButtonEnrere = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewNoticies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDescripcio
        '
        Me.LabelDescripcio.AutoSize = True
        Me.LabelDescripcio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDescripcio.Location = New System.Drawing.Point(4, 48)
        Me.LabelDescripcio.Name = "LabelDescripcio"
        Me.LabelDescripcio.Size = New System.Drawing.Size(90, 21)
        Me.LabelDescripcio.TabIndex = 8
        Me.LabelDescripcio.Text = "Descripció"
        '
        'LabelTitol
        '
        Me.LabelTitol.AutoSize = True
        Me.LabelTitol.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitol.Location = New System.Drawing.Point(4, 14)
        Me.LabelTitol.Name = "LabelTitol"
        Me.LabelTitol.Size = New System.Drawing.Size(45, 21)
        Me.LabelTitol.TabIndex = 9
        Me.LabelTitol.Text = "Titol"
        '
        'TextBoxTitol
        '
        Me.TextBoxTitol.Location = New System.Drawing.Point(58, 14)
        Me.TextBoxTitol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxTitol.Name = "TextBoxTitol"
        Me.TextBoxTitol.Size = New System.Drawing.Size(616, 23)
        Me.TextBoxTitol.TabIndex = 11
        '
        'DateTimePickerPublicacio
        '
        Me.DateTimePickerPublicacio.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerPublicacio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerPublicacio.Location = New System.Drawing.Point(695, 64)
        Me.DateTimePickerPublicacio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerPublicacio.Name = "DateTimePickerPublicacio"
        Me.DateTimePickerPublicacio.Size = New System.Drawing.Size(219, 23)
        Me.DateTimePickerPublicacio.TabIndex = 12
        Me.DateTimePickerPublicacio.Value = New Date(2023, 4, 12, 21, 6, 17, 0)
        '
        'DateTimePickerInici
        '
        Me.DateTimePickerInici.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerInici.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerInici.Location = New System.Drawing.Point(927, 64)
        Me.DateTimePickerInici.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerInici.Name = "DateTimePickerInici"
        Me.DateTimePickerInici.Size = New System.Drawing.Size(219, 23)
        Me.DateTimePickerInici.TabIndex = 13
        '
        'DateTimePickerFi
        '
        Me.DateTimePickerFi.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerFi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerFi.Location = New System.Drawing.Point(1159, 64)
        Me.DateTimePickerFi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerFi.Name = "DateTimePickerFi"
        Me.DateTimePickerFi.Size = New System.Drawing.Size(219, 23)
        Me.DateTimePickerFi.TabIndex = 14
        '
        'LabelPublicacio
        '
        Me.LabelPublicacio.AutoSize = True
        Me.LabelPublicacio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPublicacio.Location = New System.Drawing.Point(737, 37)
        Me.LabelPublicacio.Name = "LabelPublicacio"
        Me.LabelPublicacio.Size = New System.Drawing.Size(130, 21)
        Me.LabelPublicacio.TabIndex = 15
        Me.LabelPublicacio.Text = "Data Publicació"
        '
        'LabelInici
        '
        Me.LabelInici.AutoSize = True
        Me.LabelInici.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInici.Location = New System.Drawing.Point(989, 37)
        Me.LabelInici.Name = "LabelInici"
        Me.LabelInici.Size = New System.Drawing.Size(83, 21)
        Me.LabelInici.TabIndex = 16
        Me.LabelInici.Text = "Data Inici"
        '
        'LabelFi
        '
        Me.LabelFi.AutoSize = True
        Me.LabelFi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFi.Location = New System.Drawing.Point(1236, 37)
        Me.LabelFi.Name = "LabelFi"
        Me.LabelFi.Size = New System.Drawing.Size(63, 21)
        Me.LabelFi.TabIndex = 17
        Me.LabelFi.Text = "Data Fi"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.ButtonAccio)
        Me.Panel1.Controls.Add(Me.RadioButtonEliminar)
        Me.Panel1.Controls.Add(Me.RadioButtonModificar)
        Me.Panel1.Controls.Add(Me.RadioButtonAfegir)
        Me.Panel1.Controls.Add(Me.LabelFoto)
        Me.Panel1.Controls.Add(Me.TextBoxFoto)
        Me.Panel1.Controls.Add(Me.TextBoxDescripcio)
        Me.Panel1.Controls.Add(Me.LabelTitol)
        Me.Panel1.Controls.Add(Me.LabelDescripcio)
        Me.Panel1.Controls.Add(Me.TextBoxTitol)
        Me.Panel1.Controls.Add(Me.LabelPublicacio)
        Me.Panel1.Controls.Add(Me.DateTimePickerFi)
        Me.Panel1.Controls.Add(Me.LabelFi)
        Me.Panel1.Controls.Add(Me.DateTimePickerPublicacio)
        Me.Panel1.Controls.Add(Me.LabelInici)
        Me.Panel1.Controls.Add(Me.DateTimePickerInici)
        Me.Panel1.Location = New System.Drawing.Point(10, 479)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1536, 114)
        Me.Panel1.TabIndex = 21
        '
        'ButtonAccio
        '
        Me.ButtonAccio.Location = New System.Drawing.Point(1415, 81)
        Me.ButtonAccio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAccio.Name = "ButtonAccio"
        Me.ButtonAccio.Size = New System.Drawing.Size(82, 22)
        Me.ButtonAccio.TabIndex = 27
        Me.ButtonAccio.Text = "Fer l'acció"
        Me.ButtonAccio.UseVisualStyleBackColor = True
        '
        'RadioButtonEliminar
        '
        Me.RadioButtonEliminar.AutoSize = True
        Me.RadioButtonEliminar.Location = New System.Drawing.Point(1415, 58)
        Me.RadioButtonEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonEliminar.Name = "RadioButtonEliminar"
        Me.RadioButtonEliminar.Size = New System.Drawing.Size(68, 19)
        Me.RadioButtonEliminar.TabIndex = 26
        Me.RadioButtonEliminar.Text = "Eliminar"
        Me.RadioButtonEliminar.UseVisualStyleBackColor = True
        '
        'RadioButtonModificar
        '
        Me.RadioButtonModificar.AutoSize = True
        Me.RadioButtonModificar.Location = New System.Drawing.Point(1415, 36)
        Me.RadioButtonModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonModificar.Name = "RadioButtonModificar"
        Me.RadioButtonModificar.Size = New System.Drawing.Size(76, 19)
        Me.RadioButtonModificar.TabIndex = 25
        Me.RadioButtonModificar.Text = "Modificar"
        Me.RadioButtonModificar.UseVisualStyleBackColor = True
        '
        'RadioButtonAfegir
        '
        Me.RadioButtonAfegir.AutoSize = True
        Me.RadioButtonAfegir.Checked = True
        Me.RadioButtonAfegir.Location = New System.Drawing.Point(1415, 14)
        Me.RadioButtonAfegir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonAfegir.Name = "RadioButtonAfegir"
        Me.RadioButtonAfegir.Size = New System.Drawing.Size(57, 19)
        Me.RadioButtonAfegir.TabIndex = 24
        Me.RadioButtonAfegir.TabStop = True
        Me.RadioButtonAfegir.Text = "Afegir"
        Me.RadioButtonAfegir.UseVisualStyleBackColor = True
        '
        'LabelFoto
        '
        Me.LabelFoto.AutoSize = True
        Me.LabelFoto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFoto.Location = New System.Drawing.Point(5, 84)
        Me.LabelFoto.Name = "LabelFoto"
        Me.LabelFoto.Size = New System.Drawing.Size(44, 21)
        Me.LabelFoto.TabIndex = 23
        Me.LabelFoto.Text = "Foto"
        '
        'TextBoxFoto
        '
        Me.TextBoxFoto.Location = New System.Drawing.Point(58, 85)
        Me.TextBoxFoto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxFoto.Name = "TextBoxFoto"
        Me.TextBoxFoto.Size = New System.Drawing.Size(616, 23)
        Me.TextBoxFoto.TabIndex = 22
        '
        'TextBoxDescripcio
        '
        Me.TextBoxDescripcio.Location = New System.Drawing.Point(106, 40)
        Me.TextBoxDescripcio.Multiline = True
        Me.TextBoxDescripcio.Name = "TextBoxDescripcio"
        Me.TextBoxDescripcio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDescripcio.Size = New System.Drawing.Size(568, 41)
        Me.TextBoxDescripcio.TabIndex = 21
        '
        'LabelTitolNoticies
        '
        Me.LabelTitolNoticies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitolNoticies.AutoSize = True
        Me.LabelTitolNoticies.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitolNoticies.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitolNoticies.Location = New System.Drawing.Point(726, 7)
        Me.LabelTitolNoticies.Name = "LabelTitolNoticies"
        Me.LabelTitolNoticies.Size = New System.Drawing.Size(137, 37)
        Me.LabelTitolNoticies.TabIndex = 1
        Me.LabelTitolNoticies.Text = "NOTÍCIES"
        Me.LabelTitolNoticies.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridViewNoticies
        '
        Me.DataGridViewNoticies.AllowUserToAddRows = False
        Me.DataGridViewNoticies.AllowUserToDeleteRows = False
        Me.DataGridViewNoticies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewNoticies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewNoticies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewNoticies.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewNoticies.ColumnHeadersHeight = 29
        Me.DataGridViewNoticies.Location = New System.Drawing.Point(10, 44)
        Me.DataGridViewNoticies.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewNoticies.Name = "DataGridViewNoticies"
        Me.DataGridViewNoticies.ReadOnly = True
        Me.DataGridViewNoticies.RowHeadersWidth = 51
        Me.DataGridViewNoticies.RowTemplate.Height = 29
        Me.DataGridViewNoticies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewNoticies.Size = New System.Drawing.Size(1536, 431)
        Me.DataGridViewNoticies.TabIndex = 2
        '
        'ButtonEnrere
        '
        Me.ButtonEnrere.BackColor = System.Drawing.Color.LightGray
        Me.ButtonEnrere.BackgroundImage = Global.Tapping.My.Resources.Resources.enrere
        Me.ButtonEnrere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEnrere.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnrere.FlatAppearance.BorderSize = 0
        Me.ButtonEnrere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnrere.Location = New System.Drawing.Point(10, 7)
        Me.ButtonEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEnrere.Name = "ButtonEnrere"
        Me.ButtonEnrere.Size = New System.Drawing.Size(56, 32)
        Me.ButtonEnrere.TabIndex = 22
        Me.ButtonEnrere.UseVisualStyleBackColor = False
        '
        'FormNoticiesAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1558, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonEnrere)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewNoticies)
        Me.Controls.Add(Me.LabelTitolNoticies)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1574, 642)
        Me.Name = "FormNoticiesAdmin"
        Me.Text = "Notícies"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewNoticies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents ButtonEnrere As Button
End Class
