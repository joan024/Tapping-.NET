<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Escriptori_Administradors
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TapesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotíciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreguntesFrequentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TancaSessióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonConfirmarCategories = New System.Windows.Forms.Button()
        Me.ButtonConfirmarTapes = New System.Windows.Forms.Button()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.RadioButtonEliminar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActualitzar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAfegir = New System.Windows.Forms.RadioButton()
        Me.TextBoxPack = New System.Windows.Forms.TextBox()
        Me.ButtonConfirmarClients = New System.Windows.Forms.Button()
        Me.TextBoxNif = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefon = New System.Windows.Forms.TextBox()
        Me.LabelNif = New System.Windows.Forms.Label()
        Me.LabelTelefon = New System.Windows.Forms.Label()
        Me.LabelPack = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem, Me.XatToolStripMenuItem, Me.NotíciesToolStripMenuItem, Me.PreguntesFrequentsToolStripMenuItem, Me.TancaSessióToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(192, 746)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientsToolStripMenuItem, Me.TapesToolStripMenuItem, Me.CategoriesToolStripMenuItem})
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ClientsToolStripMenuItem.Text = "Clients"
        '
        'TapesToolStripMenuItem
        '
        Me.TapesToolStripMenuItem.Name = "TapesToolStripMenuItem"
        Me.TapesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TapesToolStripMenuItem.Text = "Tapes"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'XatToolStripMenuItem
        '
        Me.XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        Me.XatToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.XatToolStripMenuItem.Text = "Xat"
        '
        'NotíciesToolStripMenuItem
        '
        Me.NotíciesToolStripMenuItem.Name = "NotíciesToolStripMenuItem"
        Me.NotíciesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NotíciesToolStripMenuItem.Text = "Notícies"
        '
        'PreguntesFrequentsToolStripMenuItem
        '
        Me.PreguntesFrequentsToolStripMenuItem.Name = "PreguntesFrequentsToolStripMenuItem"
        Me.PreguntesFrequentsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PreguntesFrequentsToolStripMenuItem.Text = "Preguntes frequents"
        '
        'TancaSessióToolStripMenuItem
        '
        Me.TancaSessióToolStripMenuItem.Name = "TancaSessióToolStripMenuItem"
        Me.TancaSessióToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TancaSessióToolStripMenuItem.Text = "Tanca Sessió"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(318, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(318, 86)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 271)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ButtonConfirmarCategories)
        Me.Panel2.Controls.Add(Me.ButtonConfirmarTapes)
        Me.Panel2.Controls.Add(Me.ComboBoxCategoria)
        Me.Panel2.Controls.Add(Me.RadioButtonEliminar)
        Me.Panel2.Controls.Add(Me.RadioButtonActualitzar)
        Me.Panel2.Controls.Add(Me.RadioButtonAfegir)
        Me.Panel2.Controls.Add(Me.TextBoxPack)
        Me.Panel2.Controls.Add(Me.ButtonConfirmarClients)
        Me.Panel2.Controls.Add(Me.TextBoxNif)
        Me.Panel2.Controls.Add(Me.TextBoxTelefon)
        Me.Panel2.Controls.Add(Me.LabelNif)
        Me.Panel2.Controls.Add(Me.LabelTelefon)
        Me.Panel2.Controls.Add(Me.LabelPack)
        Me.Panel2.Location = New System.Drawing.Point(318, 361)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 350)
        Me.Panel2.TabIndex = 15
        '
        'ButtonConfirmarCategories
        '
        Me.ButtonConfirmarCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ButtonConfirmarCategories.Location = New System.Drawing.Point(560, 141)
        Me.ButtonConfirmarCategories.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonConfirmarCategories.Name = "ButtonConfirmarCategories"
        Me.ButtonConfirmarCategories.Size = New System.Drawing.Size(192, 46)
        Me.ButtonConfirmarCategories.TabIndex = 19
        Me.ButtonConfirmarCategories.Text = "CONFIRMAR CANVIS"
        Me.ButtonConfirmarCategories.UseVisualStyleBackColor = False
        '
        'ButtonConfirmarTapes
        '
        Me.ButtonConfirmarTapes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ButtonConfirmarTapes.Location = New System.Drawing.Point(560, 142)
        Me.ButtonConfirmarTapes.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonConfirmarTapes.Name = "ButtonConfirmarTapes"
        Me.ButtonConfirmarTapes.Size = New System.Drawing.Size(192, 46)
        Me.ButtonConfirmarTapes.TabIndex = 16
        Me.ButtonConfirmarTapes.Text = "CONFIRMAR CANVIS"
        Me.ButtonConfirmarTapes.UseVisualStyleBackColor = False
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(39, 154)
        Me.ComboBoxCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(128, 23)
        Me.ComboBoxCategoria.TabIndex = 18
        '
        'RadioButtonEliminar
        '
        Me.RadioButtonEliminar.AutoSize = True
        Me.RadioButtonEliminar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonEliminar.Location = New System.Drawing.Point(580, 62)
        Me.RadioButtonEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonEliminar.Name = "RadioButtonEliminar"
        Me.RadioButtonEliminar.Size = New System.Drawing.Size(113, 29)
        Me.RadioButtonEliminar.TabIndex = 17
        Me.RadioButtonEliminar.TabStop = True
        Me.RadioButtonEliminar.Text = "ELIMINAR"
        Me.RadioButtonEliminar.UseVisualStyleBackColor = True
        '
        'RadioButtonActualitzar
        '
        Me.RadioButtonActualitzar.AutoSize = True
        Me.RadioButtonActualitzar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonActualitzar.Location = New System.Drawing.Point(738, 62)
        Me.RadioButtonActualitzar.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonActualitzar.Name = "RadioButtonActualitzar"
        Me.RadioButtonActualitzar.Size = New System.Drawing.Size(147, 29)
        Me.RadioButtonActualitzar.TabIndex = 16
        Me.RadioButtonActualitzar.TabStop = True
        Me.RadioButtonActualitzar.Text = "ACTUALITZAR"
        Me.RadioButtonActualitzar.UseVisualStyleBackColor = True
        '
        'RadioButtonAfegir
        '
        Me.RadioButtonAfegir.AutoSize = True
        Me.RadioButtonAfegir.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonAfegir.Location = New System.Drawing.Point(444, 62)
        Me.RadioButtonAfegir.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonAfegir.Name = "RadioButtonAfegir"
        Me.RadioButtonAfegir.Size = New System.Drawing.Size(90, 29)
        Me.RadioButtonAfegir.TabIndex = 14
        Me.RadioButtonAfegir.TabStop = True
        Me.RadioButtonAfegir.Text = "AFEGIR"
        Me.RadioButtonAfegir.UseVisualStyleBackColor = True
        '
        'TextBoxPack
        '
        Me.TextBoxPack.Location = New System.Drawing.Point(39, 231)
        Me.TextBoxPack.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPack.Name = "TextBoxPack"
        Me.TextBoxPack.Size = New System.Drawing.Size(127, 23)
        Me.TextBoxPack.TabIndex = 15
        '
        'ButtonConfirmarClients
        '
        Me.ButtonConfirmarClients.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ButtonConfirmarClients.Location = New System.Drawing.Point(560, 142)
        Me.ButtonConfirmarClients.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonConfirmarClients.Name = "ButtonConfirmarClients"
        Me.ButtonConfirmarClients.Size = New System.Drawing.Size(192, 46)
        Me.ButtonConfirmarClients.TabIndex = 14
        Me.ButtonConfirmarClients.Text = "CONFIRMAR CANVIS"
        Me.ButtonConfirmarClients.UseVisualStyleBackColor = False
        '
        'TextBoxNif
        '
        Me.TextBoxNif.Location = New System.Drawing.Point(39, 68)
        Me.TextBoxNif.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNif.Name = "TextBoxNif"
        Me.TextBoxNif.Size = New System.Drawing.Size(204, 23)
        Me.TextBoxNif.TabIndex = 13
        '
        'TextBoxTelefon
        '
        Me.TextBoxTelefon.Location = New System.Drawing.Point(39, 156)
        Me.TextBoxTelefon.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTelefon.Name = "TextBoxTelefon"
        Me.TextBoxTelefon.Size = New System.Drawing.Size(210, 23)
        Me.TextBoxTelefon.TabIndex = 12
        '
        'LabelNif
        '
        Me.LabelNif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelNif.AutoSize = True
        Me.LabelNif.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNif.Location = New System.Drawing.Point(39, 20)
        Me.LabelNif.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNif.Name = "LabelNif"
        Me.LabelNif.Size = New System.Drawing.Size(46, 30)
        Me.LabelNif.TabIndex = 3
        Me.LabelNif.Text = "NIF"
        '
        'LabelTelefon
        '
        Me.LabelTelefon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTelefon.AutoSize = True
        Me.LabelTelefon.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTelefon.Location = New System.Drawing.Point(39, 111)
        Me.LabelTelefon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTelefon.Name = "LabelTelefon"
        Me.LabelTelefon.Size = New System.Drawing.Size(101, 30)
        Me.LabelTelefon.TabIndex = 4
        Me.LabelTelefon.Text = "TELEFON"
        '
        'LabelPack
        '
        Me.LabelPack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPack.AutoSize = True
        Me.LabelPack.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPack.Location = New System.Drawing.Point(39, 190)
        Me.LabelPack.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPack.Name = "LabelPack"
        Me.LabelPack.Size = New System.Drawing.Size(64, 30)
        Me.LabelPack.TabIndex = 5
        Me.LabelPack.Text = "PACK"
        '
        'Escriptori_Administradors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1401, 746)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Escriptori_Administradors"
        Me.Text = "Inici"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotíciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreguntesFrequentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TapesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButtonEliminar As RadioButton
    Friend WithEvents RadioButtonActualitzar As RadioButton
    Friend WithEvents RadioButtonAfegir As RadioButton
    Friend WithEvents TextBoxPack As TextBox
    Friend WithEvents ButtonConfirmarClients As Button
    Friend WithEvents TextBoxNif As TextBox
    Friend WithEvents TextBoxTelefon As TextBox
    Friend WithEvents LabelNif As Label
    Friend WithEvents LabelTelefon As Label
    Friend WithEvents LabelPack As Label
    Friend WithEvents TancaSessióToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxCategoria As ComboBox
    Friend WithEvents ButtonConfirmarTapes As Button
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonConfirmarCategories As Button
End Class
