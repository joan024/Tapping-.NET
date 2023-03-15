<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategoria
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
        LabelTitolCategoria = New Label()
        DataGridViewCategoria = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        Nom = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(DataGridViewCategoria, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelTitolCategoria
        ' 
        LabelTitolCategoria.AutoSize = True
        LabelTitolCategoria.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        LabelTitolCategoria.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolCategoria.Location = New Point(367, 18)
        LabelTitolCategoria.Name = "LabelTitolCategoria"
        LabelTitolCategoria.Size = New Size(208, 46)
        LabelTitolCategoria.TabIndex = 1
        LabelTitolCategoria.Text = "CATEGORIA"
        LabelTitolCategoria.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DataGridViewCategoria
        ' 
        DataGridViewCategoria.BackgroundColor = Color.White
        DataGridViewCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCategoria.Columns.AddRange(New DataGridViewColumn() {Id, Nom})
        DataGridViewCategoria.Location = New Point(12, 79)
        DataGridViewCategoria.Name = "DataGridViewCategoria"
        DataGridViewCategoria.ReadOnly = True
        DataGridViewCategoria.RowHeadersWidth = 51
        DataGridViewCategoria.RowTemplate.Height = 29
        DataGridViewCategoria.Size = New Size(399, 509)
        DataGridViewCategoria.TabIndex = 2
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.MinimumWidth = 6
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Width = 125
        ' 
        ' Nom
        ' 
        Nom.HeaderText = "Nom"
        Nom.MinimumWidth = 6
        Nom.Name = "Nom"
        Nom.ReadOnly = True
        Nom.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(517, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 38)
        Label1.TabIndex = 3
        Label1.Text = "Nom"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(498, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(417, 178)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Afegir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(517, 178)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Modificar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(617, 178)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 7
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' FormCategoria
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(914, 600)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridViewCategoria)
        Controls.Add(LabelTitolCategoria)
        MinimumSize = New Size(932, 647)
        Name = "FormCategoria"
        Text = "FormCategoria"
        CType(DataGridViewCategoria, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTitolCategoria As Label
    Friend WithEvents DataGridViewCategoria As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
