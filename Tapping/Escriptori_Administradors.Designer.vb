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
        MenuStrip1 = New MenuStrip()
        GestionarToolStripMenuItem = New ToolStripMenuItem()
        ClientsToolStripMenuItem = New ToolStripMenuItem()
        TapesToolStripMenuItem = New ToolStripMenuItem()
        CategoriesToolStripMenuItem = New ToolStripMenuItem()
        XatToolStripMenuItem = New ToolStripMenuItem()
        NotíciesToolStripMenuItem = New ToolStripMenuItem()
        PreguntesFrequentsToolStripMenuItem = New ToolStripMenuItem()
        TancaSessióToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        ButtonConfirmarCategories = New Button()
        ButtonConfirmarTapes = New Button()
        ComboBoxCategoria = New ComboBox()
        RadioButtonEliminar = New RadioButton()
        RadioButtonActualitzar = New RadioButton()
        RadioButtonAfegir = New RadioButton()
        TextBoxPack = New TextBox()
        ButtonConfirmarClients = New Button()
        TextBoxNif = New TextBox()
        TextBoxTelefon = New TextBox()
        LabelNif = New Label()
        LabelTelefon = New Label()
        LabelPack = New Label()
        MenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.Font = New Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GestionarToolStripMenuItem, XatToolStripMenuItem, NotíciesToolStripMenuItem, PreguntesFrequentsToolStripMenuItem, TancaSessióToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(239, 844)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GestionarToolStripMenuItem
        ' 
        GestionarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientsToolStripMenuItem, TapesToolStripMenuItem, CategoriesToolStripMenuItem})
        GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        GestionarToolStripMenuItem.Size = New Size(224, 28)
        GestionarToolStripMenuItem.Text = "Gestionar"
        ' 
        ' ClientsToolStripMenuItem
        ' 
        ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        ClientsToolStripMenuItem.Size = New Size(202, 28)
        ClientsToolStripMenuItem.Text = "Clients"
        ' 
        ' TapesToolStripMenuItem
        ' 
        TapesToolStripMenuItem.Name = "TapesToolStripMenuItem"
        TapesToolStripMenuItem.Size = New Size(202, 28)
        TapesToolStripMenuItem.Text = "Tapes"
        ' 
        ' CategoriesToolStripMenuItem
        ' 
        CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        CategoriesToolStripMenuItem.Size = New Size(202, 28)
        CategoriesToolStripMenuItem.Text = "Categories"
        ' 
        ' XatToolStripMenuItem
        ' 
        XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        XatToolStripMenuItem.Size = New Size(224, 28)
        XatToolStripMenuItem.Text = "Xat"
        ' 
        ' NotíciesToolStripMenuItem
        ' 
        NotíciesToolStripMenuItem.Name = "NotíciesToolStripMenuItem"
        NotíciesToolStripMenuItem.Size = New Size(224, 28)
        NotíciesToolStripMenuItem.Text = "Notícies"
        ' 
        ' PreguntesFrequentsToolStripMenuItem
        ' 
        PreguntesFrequentsToolStripMenuItem.Name = "PreguntesFrequentsToolStripMenuItem"
        PreguntesFrequentsToolStripMenuItem.Size = New Size(224, 28)
        PreguntesFrequentsToolStripMenuItem.Text = "Preguntes frequents"
        ' 
        ' TancaSessióToolStripMenuItem
        ' 
        TancaSessióToolStripMenuItem.Name = "TancaSessióToolStripMenuItem"
        TancaSessióToolStripMenuItem.Size = New Size(224, 28)
        TancaSessióToolStripMenuItem.Text = "Tanca Sessió"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(364, 45)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 32)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(364, 115)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1063, 510)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Controls.Add(ButtonConfirmarCategories)
        Panel2.Controls.Add(ButtonConfirmarTapes)
        Panel2.Controls.Add(ComboBoxCategoria)
        Panel2.Controls.Add(RadioButtonEliminar)
        Panel2.Controls.Add(RadioButtonActualitzar)
        Panel2.Controls.Add(RadioButtonAfegir)
        Panel2.Controls.Add(TextBoxPack)
        Panel2.Controls.Add(ButtonConfirmarClients)
        Panel2.Controls.Add(TextBoxNif)
        Panel2.Controls.Add(TextBoxTelefon)
        Panel2.Controls.Add(LabelNif)
        Panel2.Controls.Add(LabelTelefon)
        Panel2.Controls.Add(LabelPack)
        Panel2.Location = New Point(364, 664)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1028, 117)
        Panel2.TabIndex = 15
        ' 
        ' ButtonConfirmarCategories
        ' 
        ButtonConfirmarCategories.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ButtonConfirmarCategories.Location = New Point(640, 188)
        ButtonConfirmarCategories.Margin = New Padding(2)
        ButtonConfirmarCategories.Name = "ButtonConfirmarCategories"
        ButtonConfirmarCategories.Size = New Size(220, 61)
        ButtonConfirmarCategories.TabIndex = 19
        ButtonConfirmarCategories.Text = "CONFIRMAR CANVIS"
        ButtonConfirmarCategories.UseVisualStyleBackColor = False
        ' 
        ' ButtonConfirmarTapes
        ' 
        ButtonConfirmarTapes.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ButtonConfirmarTapes.Location = New Point(640, 190)
        ButtonConfirmarTapes.Margin = New Padding(2)
        ButtonConfirmarTapes.Name = "ButtonConfirmarTapes"
        ButtonConfirmarTapes.Size = New Size(220, 61)
        ButtonConfirmarTapes.TabIndex = 16
        ButtonConfirmarTapes.Text = "CONFIRMAR CANVIS"
        ButtonConfirmarTapes.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxCategoria
        ' 
        ComboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxCategoria.FormattingEnabled = True
        ComboBoxCategoria.Location = New Point(45, 206)
        ComboBoxCategoria.Margin = New Padding(2)
        ComboBoxCategoria.Name = "ComboBoxCategoria"
        ComboBoxCategoria.Size = New Size(146, 28)
        ComboBoxCategoria.TabIndex = 18
        ' 
        ' RadioButtonEliminar
        ' 
        RadioButtonEliminar.AutoSize = True
        RadioButtonEliminar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonEliminar.Location = New Point(663, 82)
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
        RadioButtonActualitzar.Location = New Point(843, 82)
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
        RadioButtonAfegir.Location = New Point(508, 82)
        RadioButtonAfegir.Margin = New Padding(2)
        RadioButtonAfegir.Name = "RadioButtonAfegir"
        RadioButtonAfegir.Size = New Size(110, 36)
        RadioButtonAfegir.TabIndex = 14
        RadioButtonAfegir.TabStop = True
        RadioButtonAfegir.Text = "AFEGIR"
        RadioButtonAfegir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPack
        ' 
        TextBoxPack.Location = New Point(45, 327)
        TextBoxPack.Margin = New Padding(2)
        TextBoxPack.Name = "TextBoxPack"
        TextBoxPack.Size = New Size(145, 27)
        TextBoxPack.TabIndex = 15
        ' 
        ' ButtonConfirmarClients
        ' 
        ButtonConfirmarClients.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ButtonConfirmarClients.Location = New Point(640, 190)
        ButtonConfirmarClients.Margin = New Padding(2)
        ButtonConfirmarClients.Name = "ButtonConfirmarClients"
        ButtonConfirmarClients.Size = New Size(220, 61)
        ButtonConfirmarClients.TabIndex = 14
        ButtonConfirmarClients.Text = "CONFIRMAR CANVIS"
        ButtonConfirmarClients.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNif
        ' 
        TextBoxNif.Location = New Point(45, 90)
        TextBoxNif.Margin = New Padding(2)
        TextBoxNif.Name = "TextBoxNif"
        TextBoxNif.Size = New Size(232, 27)
        TextBoxNif.TabIndex = 13
        ' 
        ' TextBoxTelefon
        ' 
        TextBoxTelefon.Location = New Point(45, 208)
        TextBoxTelefon.Margin = New Padding(2)
        TextBoxTelefon.Name = "TextBoxTelefon"
        TextBoxTelefon.Size = New Size(240, 27)
        TextBoxTelefon.TabIndex = 12
        ' 
        ' LabelNif
        ' 
        LabelNif.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelNif.AutoSize = True
        LabelNif.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNif.Location = New Point(45, 27)
        LabelNif.Margin = New Padding(2, 0, 2, 0)
        LabelNif.Name = "LabelNif"
        LabelNif.Size = New Size(57, 37)
        LabelNif.TabIndex = 3
        LabelNif.Text = "NIF"
        ' 
        ' LabelTelefon
        ' 
        LabelTelefon.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelTelefon.AutoSize = True
        LabelTelefon.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        LabelTelefon.Location = New Point(45, 148)
        LabelTelefon.Margin = New Padding(2, 0, 2, 0)
        LabelTelefon.Name = "LabelTelefon"
        LabelTelefon.Size = New Size(125, 37)
        LabelTelefon.TabIndex = 4
        LabelTelefon.Text = "TELEFON"
        ' 
        ' LabelPack
        ' 
        LabelPack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelPack.AutoSize = True
        LabelPack.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        LabelPack.Location = New Point(45, 266)
        LabelPack.Margin = New Padding(2, 0, 2, 0)
        LabelPack.Name = "LabelPack"
        LabelPack.Size = New Size(79, 37)
        LabelPack.TabIndex = 5
        LabelPack.Text = "PACK"
        ' 
        ' Escriptori_Administradors
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1539, 844)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Escriptori_Administradors"
        Text = "Inici"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
