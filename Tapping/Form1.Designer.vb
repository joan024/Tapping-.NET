<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LlistarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TapesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfegirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LlistarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.XatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotíciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(16, 25)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem, Me.XatToolStripMenuItem, Me.NotíciesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(126, 649)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientsToolStripMenuItem, Me.TapesToolStripMenuItem})
        Me.GestionarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.EditarToolStripMenuItem, Me.ToolStripSeparator2, Me.LlistarToolStripMenuItem, Me.ToolStripSeparator3, Me.EliminarToolStripMenuItem})
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ClientsToolStripMenuItem.Text = "Clients"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 24)
        Me.ToolStripMenuItem1.Text = "Afegir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'LlistarToolStripMenuItem
        '
        Me.LlistarToolStripMenuItem.Name = "LlistarToolStripMenuItem"
        Me.LlistarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LlistarToolStripMenuItem.Text = "Llistar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'TapesToolStripMenuItem
        '
        Me.TapesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfegirToolStripMenuItem, Me.ToolStripSeparator4, Me.EditarToolStripMenuItem1, Me.ToolStripSeparator5, Me.LlistarToolStripMenuItem1, Me.ToolStripSeparator6, Me.EliminarToolStripMenuItem1})
        Me.TapesToolStripMenuItem.Name = "TapesToolStripMenuItem"
        Me.TapesToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.TapesToolStripMenuItem.Text = "Tapes"
        '
        'AfegirToolStripMenuItem
        '
        Me.AfegirToolStripMenuItem.Name = "AfegirToolStripMenuItem"
        Me.AfegirToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.AfegirToolStripMenuItem.Text = "Afegir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(137, 6)
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(137, 6)
        '
        'LlistarToolStripMenuItem1
        '
        Me.LlistarToolStripMenuItem1.Name = "LlistarToolStripMenuItem1"
        Me.LlistarToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.LlistarToolStripMenuItem1.Text = "Llistar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(137, 6)
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'XatToolStripMenuItem
        '
        Me.XatToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        Me.XatToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.XatToolStripMenuItem.Text = "Xat"
        '
        'NotíciesToolStripMenuItem
        '
        Me.NotíciesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NotíciesToolStripMenuItem.Name = "NotíciesToolStripMenuItem"
        Me.NotíciesToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.NotíciesToolStripMenuItem.Text = "Notícies"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 649)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotíciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsToolStripComboBox As ToolStripComboBox
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TapesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LlistarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfegirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LlistarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
End Class
