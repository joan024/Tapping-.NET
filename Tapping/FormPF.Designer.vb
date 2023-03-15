<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPF
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
        ButtonEnrere = New Button()
        LabelTitolPF = New Label()
        DataGridViewPF = New DataGridView()
        Pregunta = New DataGridViewTextBoxColumn()
        Resposta = New DataGridViewTextBoxColumn()
        CType(DataGridViewPF, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonEnrere
        ' 
        ButtonEnrere.BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        ButtonEnrere.BackgroundImage = My.Resources.Resources.enrere
        ButtonEnrere.BackgroundImageLayout = ImageLayout.Stretch
        ButtonEnrere.FlatAppearance.BorderColor = Color.White
        ButtonEnrere.FlatAppearance.BorderSize = 0
        ButtonEnrere.FlatStyle = FlatStyle.Flat
        ButtonEnrere.Location = New Point(12, 20)
        ButtonEnrere.Name = "ButtonEnrere"
        ButtonEnrere.Size = New Size(64, 45)
        ButtonEnrere.TabIndex = 2
        ButtonEnrere.UseVisualStyleBackColor = False
        ' 
        ' LabelTitolPF
        ' 
        LabelTitolPF.Anchor = AnchorStyles.Top
        LabelTitolPF.AutoSize = True
        LabelTitolPF.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolPF.Location = New Point(686, 19)
        LabelTitolPF.Name = "LabelTitolPF"
        LabelTitolPF.Size = New Size(416, 46)
        LabelTitolPF.TabIndex = 0
        LabelTitolPF.Text = "PREGUNTES FREQÜENTS"' 
        ' DataGridViewPF
        ' 
        DataGridViewPF.AllowUserToAddRows = False
        DataGridViewPF.AllowUserToDeleteRows = False
        DataGridViewPF.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPF.BackgroundColor = Color.White
        DataGridViewPF.BorderStyle = BorderStyle.None
        DataGridViewPF.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewPF.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewPF.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewPF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPF.ColumnHeadersVisible = False
        DataGridViewPF.Columns.AddRange(New DataGridViewColumn() {Pregunta, Resposta})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewPF.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewPF.EnableHeadersVisualStyles = False
        DataGridViewPF.Location = New Point(12, 87)
        DataGridViewPF.Name = "DataGridViewPF"
        DataGridViewPF.ReadOnly = True
        DataGridViewPF.RowHeadersVisible = False
        DataGridViewPF.RowHeadersWidth = 51
        DataGridViewPF.RowTemplate.Height = 50
        DataGridViewPF.RowTemplate.ReadOnly = True
        DataGridViewPF.Size = New Size(1756, 707)
        DataGridViewPF.TabIndex = 2
        ' 
        ' Pregunta
        ' 
        Pregunta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Pregunta.HeaderText = "Pregunta"
        Pregunta.MinimumWidth = 6
        Pregunta.Name = "Pregunta"
        Pregunta.ReadOnly = True
        Pregunta.Width = 6
        ' 
        ' Resposta
        ' 
        Resposta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Resposta.HeaderText = "Resposta"
        Resposta.MinimumWidth = 6
        Resposta.Name = "Resposta"
        Resposta.ReadOnly = True
        Resposta.Width = 6
        ' 
        ' FormPF
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        ClientSize = New Size(1780, 806)
        Controls.Add(DataGridViewPF)
        Controls.Add(ButtonEnrere)
        Controls.Add(LabelTitolPF)
        Name = "FormPF"
        Text = "FormPF"
        CType(DataGridViewPF, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonEnrere As Button
    Friend WithEvents LabelTitolPF As Label
    Friend WithEvents DataGridViewPF As DataGridView
    Friend WithEvents Pregunta As DataGridViewTextBoxColumn
    Friend WithEvents Resposta As DataGridViewTextBoxColumn
End Class
