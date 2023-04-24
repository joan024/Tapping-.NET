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
        ButtonEnrere = New Button()
        LabelTitolNoticies = New Label()
        DataGridViewNoticies = New DataGridView()
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).BeginInit()
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
        ButtonEnrere.Location = New Point(12, 9)
        ButtonEnrere.Name = "ButtonEnrere"
        ButtonEnrere.Size = New Size(64, 43)
        ButtonEnrere.TabIndex = 2
        ButtonEnrere.UseVisualStyleBackColor = False
        ' 
        ' LabelTitolNoticies
        ' 
        LabelTitolNoticies.Anchor = AnchorStyles.Top
        LabelTitolNoticies.AutoSize = True
        LabelTitolNoticies.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolNoticies.Location = New Point(783, 9)
        LabelTitolNoticies.Name = "LabelTitolNoticies"
        LabelTitolNoticies.Size = New Size(172, 46)
        LabelTitolNoticies.TabIndex = 0
        LabelTitolNoticies.Text = "NOTÍCIES"
        LabelTitolNoticies.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DataGridViewNoticies
        ' 
        DataGridViewNoticies.AllowUserToAddRows = False
        DataGridViewNoticies.AllowUserToDeleteRows = False
        DataGridViewNoticies.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewNoticies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewNoticies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewNoticies.BackgroundColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        DataGridViewNoticies.BorderStyle = BorderStyle.None
        DataGridViewNoticies.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewNoticies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewNoticies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewNoticies.ColumnHeadersHeight = 29
        DataGridViewNoticies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewNoticies.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewNoticies.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewNoticies.EnableHeadersVisualStyles = False
        DataGridViewNoticies.Location = New Point(12, 58)
        DataGridViewNoticies.Name = "DataGridViewNoticies"
        DataGridViewNoticies.ReadOnly = True
        DataGridViewNoticies.RowHeadersVisible = False
        DataGridViewNoticies.RowHeadersWidth = 51
        DataGridViewNoticies.RowTemplate.Height = 50
        DataGridViewNoticies.RowTemplate.ReadOnly = True
        DataGridViewNoticies.Size = New Size(1756, 735)
        DataGridViewNoticies.TabIndex = 1
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
        WindowState = FormWindowState.Maximized
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LabelTitolNoticies As Label
    Friend WithEvents ButtonEnrere As Button
    Friend WithEvents DataGridViewNoticies As DataGridView
End Class
