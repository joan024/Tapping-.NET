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
        Me.DataGridViewClients = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewClients
        '
        Me.DataGridViewClients.AllowUserToAddRows = False
        Me.DataGridViewClients.AllowUserToDeleteRows = False
        Me.DataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewClients.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClients.Location = New System.Drawing.Point(16, 8)
        Me.DataGridViewClients.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewClients.Name = "DataGridViewClients"
        Me.DataGridViewClients.ReadOnly = True
        Me.DataGridViewClients.RowHeadersWidth = 62
        Me.DataGridViewClients.RowTemplate.Height = 33
        Me.DataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewClients.Size = New System.Drawing.Size(860, 381)
        Me.DataGridViewClients.TabIndex = 2
        '
        'GridViewClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 395)
        Me.Controls.Add(Me.DataGridViewClients)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GridViewClients"
        Me.Text = "Clients"
        CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewClients As DataGridView
End Class
