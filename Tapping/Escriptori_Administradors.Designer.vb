﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        MenuStrip1.SuspendLayout()
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
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(239, 844)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' GestionarToolStripMenuItem
        ' 
        GestionarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientsToolStripMenuItem, TapesToolStripMenuItem})
        GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        GestionarToolStripMenuItem.Size = New Size(224, 28)
        GestionarToolStripMenuItem.Text = "Gestionar"' 
        ' ClientsToolStripMenuItem
        ' 
        ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        ClientsToolStripMenuItem.Size = New Size(165, 28)
        ClientsToolStripMenuItem.Text = "Clients"' 
        ' TapesToolStripMenuItem
        ' 
        TapesToolStripMenuItem.Name = "TapesToolStripMenuItem"
        TapesToolStripMenuItem.Size = New Size(165, 28)
        TapesToolStripMenuItem.Text = "Tapes"' 
        ' XatToolStripMenuItem
        ' 
        XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        XatToolStripMenuItem.Size = New Size(224, 28)
        XatToolStripMenuItem.Text = "Xat"' 
        ' NotíciesToolStripMenuItem
        ' 
        NotíciesToolStripMenuItem.Name = "NotíciesToolStripMenuItem"
        NotíciesToolStripMenuItem.Size = New Size(224, 28)
        NotíciesToolStripMenuItem.Text = "Notícies"' 
        ' PreguntesFrequentsToolStripMenuItem
        ' 
        PreguntesFrequentsToolStripMenuItem.Name = "PreguntesFrequentsToolStripMenuItem"
        PreguntesFrequentsToolStripMenuItem.Size = New Size(224, 28)
        PreguntesFrequentsToolStripMenuItem.Text = "Preguntes frequents"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(364, 45)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 32)
        Label1.TabIndex = 2
        Label1.Text = "Label1"' 
        ' Panel1
        ' 
        Panel1.Location = New Point(364, 115)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1074, 510)
        Panel1.TabIndex = 3
        ' 
        ' Escriptori_Administradors
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1539, 844)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Escriptori_Administradors"
        Text = "Escriptori_Administradors"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
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
End Class
