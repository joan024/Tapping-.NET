<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridViewClients
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
        DataGridViewClients = New DataGridView()
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewClients
        ' 
        DataGridViewClients.AllowUserToAddRows = False
        DataGridViewClients.AllowUserToDeleteRows = False
        DataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewClients.BackgroundColor = Color.White
        DataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewClients.Location = New Point(23, 12)
        DataGridViewClients.Name = "DataGridViewClients"
        DataGridViewClients.ReadOnly = True
        DataGridViewClients.RowHeadersWidth = 62
        DataGridViewClients.RowTemplate.Height = 33
        DataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewClients.Size = New Size(1229, 635)
        DataGridViewClients.TabIndex = 2
        ' 
        ' GridViewClients
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1285, 659)
        Controls.Add(DataGridViewClients)
        FormBorderStyle = FormBorderStyle.None
        Name = "GridViewClients"
        Text = "GridViewClients"
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewClients As DataGridView
End Class
