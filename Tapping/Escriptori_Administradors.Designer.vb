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
        XatToolStripMenuItem = New ToolStripMenuItem()
        NotíciesToolStripMenuItem = New ToolStripMenuItem()
        PreguntesFrequentsToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        RadioButtonEliminar = New RadioButton()
        RadioButtonActualitzar = New RadioButton()
        RadioButtonAfegir = New RadioButton()
        TextBoxPack = New TextBox()
        ButtonConfirmar = New Button()
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
        MenuStrip1.Items.AddRange(New ToolStripItem() {GestionarToolStripMenuItem, XatToolStripMenuItem, NotíciesToolStripMenuItem, PreguntesFrequentsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 2, 0, 2)
        MenuStrip1.Size = New Size(292, 1353)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' GestionarToolStripMenuItem
        ' 
        GestionarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientsToolStripMenuItem, TapesToolStripMenuItem})
        GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        GestionarToolStripMenuItem.Size = New Size(273, 33)
        GestionarToolStripMenuItem.Text = "Gestionar"' 
        ' ClientsToolStripMenuItem
        ' 
        ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        ClientsToolStripMenuItem.Size = New Size(202, 38)
        ClientsToolStripMenuItem.Text = "Clients"' 
        ' TapesToolStripMenuItem
        ' 
        TapesToolStripMenuItem.Name = "TapesToolStripMenuItem"
        TapesToolStripMenuItem.Size = New Size(202, 38)
        TapesToolStripMenuItem.Text = "Tapes"' 
        ' XatToolStripMenuItem
        ' 
        XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        XatToolStripMenuItem.Size = New Size(273, 33)
        XatToolStripMenuItem.Text = "Xat"' 
        ' NotíciesToolStripMenuItem
        ' 
        NotíciesToolStripMenuItem.Name = "NotíciesToolStripMenuItem"
        NotíciesToolStripMenuItem.Size = New Size(273, 33)
        NotíciesToolStripMenuItem.Text = "Notícies"' 
        ' PreguntesFrequentsToolStripMenuItem
        ' 
        PreguntesFrequentsToolStripMenuItem.Name = "PreguntesFrequentsToolStripMenuItem"
        PreguntesFrequentsToolStripMenuItem.Size = New Size(273, 33)
        PreguntesFrequentsToolStripMenuItem.Text = "Preguntes frequents"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(455, 56)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 38)
        Label1.TabIndex = 2
        Label1.Text = "Label1"' 
        ' Panel1
        ' 
        Panel1.Location = New Point(455, 144)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1329, 638)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Controls.Add(RadioButtonEliminar)
        Panel2.Controls.Add(RadioButtonActualitzar)
        Panel2.Controls.Add(RadioButtonAfegir)
        Panel2.Controls.Add(TextBoxPack)
        Panel2.Controls.Add(ButtonConfirmar)
        Panel2.Controls.Add(TextBoxNif)
        Panel2.Controls.Add(TextBoxTelefon)
        Panel2.Controls.Add(LabelNif)
        Panel2.Controls.Add(LabelTelefon)
        Panel2.Controls.Add(LabelPack)
        Panel2.Location = New Point(455, 830)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1285, 444)
        Panel2.TabIndex = 15
        ' 
        ' RadioButtonEliminar
        ' 
        RadioButtonEliminar.AutoSize = True
        RadioButtonEliminar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonEliminar.Location = New Point(829, 103)
        RadioButtonEliminar.Name = "RadioButtonEliminar"
        RadioButtonEliminar.Size = New Size(164, 42)
        RadioButtonEliminar.TabIndex = 17
        RadioButtonEliminar.TabStop = True
        RadioButtonEliminar.Text = "ELIMINAR"
        RadioButtonEliminar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonActualitzar
        ' 
        RadioButtonActualitzar.AutoSize = True
        RadioButtonActualitzar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonActualitzar.Location = New Point(1054, 103)
        RadioButtonActualitzar.Name = "RadioButtonActualitzar"
        RadioButtonActualitzar.Size = New Size(213, 42)
        RadioButtonActualitzar.TabIndex = 16
        RadioButtonActualitzar.TabStop = True
        RadioButtonActualitzar.Text = "ACTUALITZAR"
        RadioButtonActualitzar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonAfegir
        ' 
        RadioButtonAfegir.AutoSize = True
        RadioButtonAfegir.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonAfegir.Location = New Point(635, 103)
        RadioButtonAfegir.Name = "RadioButtonAfegir"
        RadioButtonAfegir.Size = New Size(131, 42)
        RadioButtonAfegir.TabIndex = 14
        RadioButtonAfegir.TabStop = True
        RadioButtonAfegir.Text = "AFEGIR"
        RadioButtonAfegir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPack
        ' 
        TextBoxPack.Location = New Point(56, 409)
        TextBoxPack.Name = "TextBoxPack"
        TextBoxPack.Size = New Size(180, 31)
        TextBoxPack.TabIndex = 15
        ' 
        ' ButtonConfirmar
        ' 
        ButtonConfirmar.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ButtonConfirmar.Location = New Point(800, 237)
        ButtonConfirmar.Name = "ButtonConfirmar"
        ButtonConfirmar.Size = New Size(275, 76)
        ButtonConfirmar.TabIndex = 14
        ButtonConfirmar.Text = "CONFIRMAR CANVIS"
        ButtonConfirmar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNif
        ' 
        TextBoxNif.Location = New Point(56, 113)
        TextBoxNif.Name = "TextBoxNif"
        TextBoxNif.Size = New Size(289, 31)
        TextBoxNif.TabIndex = 13
        ' 
        ' TextBoxTelefon
        ' 
        TextBoxTelefon.Location = New Point(56, 260)
        TextBoxTelefon.Name = "TextBoxTelefon"
        TextBoxTelefon.Size = New Size(299, 31)
        TextBoxTelefon.TabIndex = 12
        ' 
        ' LabelNif
        ' 
        LabelNif.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelNif.AutoSize = True
        LabelNif.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNif.Location = New Point(56, 34)
        LabelNif.Name = "LabelNif"
        LabelNif.Size = New Size(69, 45)
        LabelNif.TabIndex = 3
        LabelNif.Text = "NIF"' 
        ' LabelTelefon
        ' 
        LabelTelefon.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelTelefon.AutoSize = True
        LabelTelefon.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        LabelTelefon.Location = New Point(56, 185)
        LabelTelefon.Name = "LabelTelefon"
        LabelTelefon.Size = New Size(148, 45)
        LabelTelefon.TabIndex = 4
        LabelTelefon.Text = "TELEFON"' 
        ' LabelPack
        ' 
        LabelPack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelPack.AutoSize = True
        LabelPack.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        LabelPack.Location = New Point(56, 333)
        LabelPack.Name = "LabelPack"
        LabelPack.Size = New Size(95, 45)
        LabelPack.TabIndex = 5
        LabelPack.Text = "PACK"' 
        ' Escriptori_Administradors
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2347, 1353)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "Escriptori_Administradors"
        Text = "Escriptori_Administradors"
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
    Friend WithEvents ButtonConfirmar As Button
    Friend WithEvents TextBoxNif As TextBox
    Friend WithEvents TextBoxTelefon As TextBox
    Friend WithEvents LabelNif As Label
    Friend WithEvents LabelTelefon As Label
    Friend WithEvents LabelPack As Label
End Class
