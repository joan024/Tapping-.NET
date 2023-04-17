<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridViewTapes
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
        DataGridViewTapes = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        NOM = New DataGridViewTextBoxColumn()
        CType(DataGridViewTapes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewTapes
        ' 
        DataGridViewTapes.BackgroundColor = Color.White
        DataGridViewTapes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTapes.Columns.AddRange(New DataGridViewColumn() {ID, NOM})
        DataGridViewTapes.Location = New Point(23, 12)
        DataGridViewTapes.Name = "DataGridViewTapes"
        DataGridViewTapes.RowHeadersWidth = 62
        DataGridViewTapes.RowTemplate.Height = 33
        DataGridViewTapes.Size = New Size(767, 635)
        DataGridViewTapes.TabIndex = 4
        ' 
        ' ID
        ' 
        ID.HeaderText = "id"
        ID.MinimumWidth = 8
        ID.Name = "ID"
        ID.Width = 170
        ' 
        ' NOM
        ' 
        NOM.HeaderText = "NOM"
        NOM.MinimumWidth = 8
        NOM.Name = "NOM"
        NOM.Width = 300
        ' 
        ' GridViewTapes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(812, 659)
        Controls.Add(DataGridViewTapes)
        FormBorderStyle = FormBorderStyle.None
        Name = "GridViewTapes"
        Text = "GridViewTapes"
        CType(DataGridViewTapes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewTapes As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
End Class
