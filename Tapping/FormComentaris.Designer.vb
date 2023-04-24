<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComentaris
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
        Label1 = New Label()
        DataGridViewComentaris = New DataGridView()
        CType(DataGridViewComentaris, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(356, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 46)
        Label1.TabIndex = 1
        Label1.Text = "Comentaris"
        ' 
        ' DataGridViewComentaris
        ' 
        DataGridViewComentaris.AllowUserToAddRows = False
        DataGridViewComentaris.AllowUserToDeleteRows = False
        DataGridViewComentaris.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewComentaris.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewComentaris.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewComentaris.BackgroundColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        DataGridViewComentaris.BorderStyle = BorderStyle.None
        DataGridViewComentaris.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewComentaris.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewComentaris.ColumnHeadersVisible = False
        DataGridViewComentaris.Location = New Point(12, 58)
        DataGridViewComentaris.Name = "DataGridViewComentaris"
        DataGridViewComentaris.ReadOnly = True
        DataGridViewComentaris.RowHeadersVisible = False
        DataGridViewComentaris.RowHeadersWidth = 51
        DataGridViewComentaris.RowTemplate.Height = 29
        DataGridViewComentaris.Size = New Size(890, 530)
        DataGridViewComentaris.TabIndex = 2
        ' 
        ' FormComentaris
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        ClientSize = New Size(914, 600)
        Controls.Add(DataGridViewComentaris)
        Controls.Add(Label1)
        MinimumSize = New Size(932, 647)
        Name = "FormComentaris"
        Text = "FormComentaris"
        CType(DataGridViewComentaris, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewComentaris As DataGridView
End Class
