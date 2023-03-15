<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNoticies
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridViewNoticies = New DataGridView()
        Titol = New DataGridViewTextBoxColumn()
        Descripcio = New DataGridViewTextBoxColumn()
        Foto = New DataGridViewImageColumn()
        Data = New DataGridViewTextBoxColumn()
        ButtonEnrere = New Button()
        LabelTitolNoticies = New Label()
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewNoticies
        ' 
        DataGridViewNoticies.AllowUserToAddRows = False
        DataGridViewNoticies.AllowUserToDeleteRows = False
        DataGridViewNoticies.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewNoticies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewNoticies.BackgroundColor = Color.White
        DataGridViewNoticies.BorderStyle = BorderStyle.None
        DataGridViewNoticies.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewNoticies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewNoticies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewNoticies.ColumnHeadersHeight = 29
        DataGridViewNoticies.ColumnHeadersVisible = False
        DataGridViewNoticies.Columns.AddRange(New DataGridViewColumn() {Titol, Descripcio, Foto, Data})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewNoticies.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewNoticies.EnableHeadersVisualStyles = False
        DataGridViewNoticies.Location = New Point(12, 88)
        DataGridViewNoticies.Name = "DataGridViewNoticies"
        DataGridViewNoticies.ReadOnly = True
        DataGridViewNoticies.RowHeadersVisible = False
        DataGridViewNoticies.RowHeadersWidth = 51
        DataGridViewNoticies.RowTemplate.Height = 50
        DataGridViewNoticies.RowTemplate.ReadOnly = True
        DataGridViewNoticies.Size = New Size(1756, 705)
        DataGridViewNoticies.TabIndex = 1
        ' 
        ' Titol
        ' 
        Titol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Titol.HeaderText = "Titol"
        Titol.MinimumWidth = 6
        Titol.Name = "Titol"
        Titol.ReadOnly = True
        Titol.Width = 6
        ' 
        ' Descripcio
        ' 
        Descripcio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Descripcio.HeaderText = "Descripcio"
        Descripcio.MinimumWidth = 6
        Descripcio.Name = "Descripcio"
        Descripcio.ReadOnly = True
        Descripcio.Width = 6
        ' 
        ' Foto
        ' 
        Foto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Foto.FillWeight = 200F
        Foto.HeaderText = "Foto"
        Foto.MinimumWidth = 6
        Foto.Name = "Foto"
        Foto.ReadOnly = True
        Foto.Width = 6
        ' 
        ' Data
        ' 
        Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Data.HeaderText = "Data"
        Data.MinimumWidth = 6
        Data.Name = "Data"
        Data.ReadOnly = True
        Data.Width = 6
        ' 
        ' ButtonEnrere
        ' 
        ButtonEnrere.BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        ButtonEnrere.BackgroundImage = My.Resources.Resources.enrere
        ButtonEnrere.BackgroundImageLayout = ImageLayout.Stretch
        ButtonEnrere.FlatAppearance.BorderColor = Color.White
        ButtonEnrere.FlatAppearance.BorderSize = 0
        ButtonEnrere.FlatStyle = FlatStyle.Flat
        ButtonEnrere.Location = New Point(12, 22)
        ButtonEnrere.Name = "ButtonEnrere"
        ButtonEnrere.Size = New Size(64, 45)
        ButtonEnrere.TabIndex = 2
        ButtonEnrere.UseVisualStyleBackColor = False
        ' 
        ' LabelTitolNoticies
        ' 
        LabelTitolNoticies.Anchor = AnchorStyles.Top
        LabelTitolNoticies.AutoSize = True
        LabelTitolNoticies.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolNoticies.Location = New Point(784, 21)
        LabelTitolNoticies.Name = "LabelTitolNoticies"
        LabelTitolNoticies.Size = New Size(172, 46)
        LabelTitolNoticies.TabIndex = 0
        LabelTitolNoticies.Text = "NOTÍCIES"
        LabelTitolNoticies.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormNoticies
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        ClientSize = New Size(1780, 805)
        Controls.Add(DataGridViewNoticies)
        Controls.Add(ButtonEnrere)
        Controls.Add(LabelTitolNoticies)
        Name = "FormNoticies"
        Text = "FormNoticies"
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LabelTitolNoticies As Label
    Friend WithEvents DataGridViewNoticies As DataGridView
    Friend WithEvents ButtonEnrere As Button
    Friend WithEvents Titol As DataGridViewTextBoxColumn
    Friend WithEvents Descripcio As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
End Class
