<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridViewCategories
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
        DataGridViewCategories = New DataGridView()
        CType(DataGridViewCategories, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewCategories
        ' 
        DataGridViewCategories.AllowUserToAddRows = False
        DataGridViewCategories.AllowUserToDeleteRows = False
        DataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCategories.BackgroundColor = Color.White
        DataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCategories.Location = New Point(32, 2)
        DataGridViewCategories.Name = "DataGridViewCategories"
        DataGridViewCategories.ReadOnly = True
        DataGridViewCategories.RowHeadersWidth = 62
        DataGridViewCategories.RowTemplate.Height = 33
        DataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewCategories.Size = New Size(783, 520)
        DataGridViewCategories.TabIndex = 5
        ' 
        ' GridViewCategories
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 558)
        Controls.Add(DataGridViewCategories)
        FormBorderStyle = FormBorderStyle.None
        Name = "GridViewCategories"
        Text = "GridViewCategories"
        CType(DataGridViewCategories, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewCategories As DataGridView
End Class
