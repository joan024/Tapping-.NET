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
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
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
        Panel2.Controls.Add(RadioButton3)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(455, 830)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1285, 444)
        Panel2.TabIndex = 15
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(829, 103)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(164, 42)
        RadioButton3.TabIndex = 17
        RadioButton3.TabStop = True
        RadioButton3.Text = "ELIMINAR"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(1054, 103)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(213, 42)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "ACTUALITZAR"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(635, 103)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(131, 42)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "AFEGIR"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(56, 409)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 31)
        TextBox1.TabIndex = 15
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        Button2.Location = New Point(800, 237)
        Button2.Name = "Button2"
        Button2.Size = New Size(275, 76)
        Button2.TabIndex = 14
        Button2.Text = "CONFIRMAR CANVIS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(56, 113)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(289, 31)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(56, 260)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(299, 31)
        TextBox4.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(56, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 45)
        Label2.TabIndex = 3
        Label2.Text = "Nom"' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(56, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 45)
        Label3.TabIndex = 4
        Label3.Text = "Personalització"' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(56, 333)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 45)
        Label4.TabIndex = 5
        Label4.Text = "Preu"' 
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
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
