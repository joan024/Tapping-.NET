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
        FlowLayoutPanelFotos = New FlowLayoutPanel()
        MenuStrip1 = New MenuStrip()
        AfegirToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanelFotos
        ' 
        FlowLayoutPanelFotos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanelFotos.BackColor = SystemColors.Control
        FlowLayoutPanelFotos.Location = New Point(12, 31)
        FlowLayoutPanelFotos.Name = "FlowLayoutPanelFotos"
        FlowLayoutPanelFotos.Size = New Size(1746, 672)
        FlowLayoutPanelFotos.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AfegirToolStripMenuItem, EliminarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1770, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AfegirToolStripMenuItem
        ' 
        AfegirToolStripMenuItem.Name = "AfegirToolStripMenuItem"
        AfegirToolStripMenuItem.Size = New Size(64, 24)
        AfegirToolStripMenuItem.Text = "Afegir"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(77, 24)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' FormFotos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1770, 715)
        Controls.Add(FlowLayoutPanelFotos)
        Controls.Add(MenuStrip1)
        Name = "FormFotos"
        Text = "FormFotos"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanelFotos As FlowLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AfegirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
