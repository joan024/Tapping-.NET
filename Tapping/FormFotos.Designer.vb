<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFotos
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
        AfegirToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        SortirToolStripMenuItem = New ToolStripMenuItem()
        FlowLayoutPanelFotos = New FlowLayoutPanel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AfegirToolStripMenuItem, EliminarToolStripMenuItem, SortirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1770, 36)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AfegirToolStripMenuItem
        ' 
        AfegirToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AfegirToolStripMenuItem.Name = "AfegirToolStripMenuItem"
        AfegirToolStripMenuItem.Size = New Size(79, 32)
        AfegirToolStripMenuItem.Text = "Afegir"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(96, 32)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' SortirToolStripMenuItem
        ' 
        SortirToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SortirToolStripMenuItem.Name = "SortirToolStripMenuItem"
        SortirToolStripMenuItem.Size = New Size(75, 32)
        SortirToolStripMenuItem.Text = "Sortir"
        ' 
        ' FlowLayoutPanelFotos
        ' 
        FlowLayoutPanelFotos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanelFotos.BackColor = SystemColors.Control
        FlowLayoutPanelFotos.Location = New Point(12, 39)
        FlowLayoutPanelFotos.Name = "FlowLayoutPanelFotos"
        FlowLayoutPanelFotos.Size = New Size(1746, 664)
        FlowLayoutPanelFotos.TabIndex = 0
        ' 
        ' FormFotos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1770, 715)
        ControlBox = False
        Controls.Add(FlowLayoutPanelFotos)
        Controls.Add(MenuStrip1)
        Name = "FormFotos"
        Text = "Galeria"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AfegirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanelFotos As FlowLayoutPanel
End Class
