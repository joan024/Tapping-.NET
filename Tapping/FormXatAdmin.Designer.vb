<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormXatAdmin
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
        PictureBoxEmpresa = New PictureBox()
        PanelXat = New Panel()
        LabelXat = New Label()
        TextBoxXat = New TextBox()
        ButtonEnviar = New Button()
        DataGridViewEmpreses = New DataGridView()
        DataGridViewXat = New DataGridView()
        CType(PictureBoxEmpresa, ComponentModel.ISupportInitialize).BeginInit()
        PanelXat.SuspendLayout()
        CType(DataGridViewEmpreses, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewXat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxEmpresa
        ' 
        PictureBoxEmpresa.BackColor = Color.White
        PictureBoxEmpresa.BackgroundImage = My.Resources.Resources.LogoTappingSenseFondo
        PictureBoxEmpresa.BackgroundImageLayout = ImageLayout.Zoom
        PictureBoxEmpresa.Location = New Point(0, 0)
        PictureBoxEmpresa.Margin = New Padding(3, 4, 3, 4)
        PictureBoxEmpresa.Name = "PictureBoxEmpresa"
        PictureBoxEmpresa.Size = New Size(90, 88)
        PictureBoxEmpresa.TabIndex = 8
        PictureBoxEmpresa.TabStop = False
        ' 
        ' PanelXat
        ' 
        PanelXat.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelXat.BackColor = Color.White
        PanelXat.Controls.Add(LabelXat)
        PanelXat.Controls.Add(PictureBoxEmpresa)
        PanelXat.Location = New Point(141, 13)
        PanelXat.Margin = New Padding(3, 4, 3, 4)
        PanelXat.Name = "PanelXat"
        PanelXat.Size = New Size(760, 88)
        PanelXat.TabIndex = 7
        ' 
        ' LabelXat
        ' 
        LabelXat.AutoSize = True
        LabelXat.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        LabelXat.Location = New Point(97, 27)
        LabelXat.Name = "LabelXat"
        LabelXat.Size = New Size(100, 31)
        LabelXat.TabIndex = 2
        LabelXat.Text = "Tapping"
        ' 
        ' TextBoxXat
        ' 
        TextBoxXat.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxXat.Location = New Point(145, 535)
        TextBoxXat.Margin = New Padding(3, 4, 3, 4)
        TextBoxXat.Multiline = True
        TextBoxXat.Name = "TextBoxXat"
        TextBoxXat.ScrollBars = ScrollBars.Vertical
        TextBoxXat.Size = New Size(703, 53)
        TextBoxXat.TabIndex = 6
        ' 
        ' ButtonEnviar
        ' 
        ButtonEnviar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonEnviar.BackColor = Color.White
        ButtonEnviar.BackgroundImage = My.Resources.Resources.enviar
        ButtonEnviar.BackgroundImageLayout = ImageLayout.Stretch
        ButtonEnviar.Location = New Point(854, 555)
        ButtonEnviar.Margin = New Padding(3, 4, 3, 4)
        ButtonEnviar.Name = "ButtonEnviar"
        ButtonEnviar.Size = New Size(47, 33)
        ButtonEnviar.TabIndex = 5
        ButtonEnviar.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewEmpreses
        ' 
        DataGridViewEmpreses.AllowUserToAddRows = False
        DataGridViewEmpreses.AllowUserToDeleteRows = False
        DataGridViewEmpreses.AllowUserToResizeColumns = False
        DataGridViewEmpreses.AllowUserToResizeRows = False
        DataGridViewEmpreses.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridViewEmpreses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewEmpreses.BackgroundColor = Color.White
        DataGridViewEmpreses.BorderStyle = BorderStyle.None
        DataGridViewEmpreses.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewEmpreses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewEmpreses.ColumnHeadersVisible = False
        DataGridViewEmpreses.Location = New Point(12, 108)
        DataGridViewEmpreses.Name = "DataGridViewEmpreses"
        DataGridViewEmpreses.ReadOnly = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewEmpreses.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewEmpreses.RowHeadersVisible = False
        DataGridViewEmpreses.RowHeadersWidth = 51
        DataGridViewEmpreses.RowTemplate.Height = 29
        DataGridViewEmpreses.Size = New Size(123, 420)
        DataGridViewEmpreses.TabIndex = 8
        ' 
        ' DataGridViewXat
        ' 
        DataGridViewXat.AllowUserToAddRows = False
        DataGridViewXat.AllowUserToDeleteRows = False
        DataGridViewXat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewXat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewXat.BackgroundColor = Color.White
        DataGridViewXat.BorderStyle = BorderStyle.None
        DataGridViewXat.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewXat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewXat.ColumnHeadersVisible = False
        DataGridViewXat.Location = New Point(141, 108)
        DataGridViewXat.MultiSelect = False
        DataGridViewXat.Name = "DataGridViewXat"
        DataGridViewXat.ReadOnly = True
        DataGridViewXat.RowHeadersVisible = False
        DataGridViewXat.RowHeadersWidth = 51
        DataGridViewXat.RowTemplate.Height = 29
        DataGridViewXat.Size = New Size(760, 420)
        DataGridViewXat.TabIndex = 9
        ' 
        ' FormXatAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(914, 600)
        Controls.Add(DataGridViewXat)
        Controls.Add(DataGridViewEmpreses)
        Controls.Add(PanelXat)
        Controls.Add(TextBoxXat)
        Controls.Add(ButtonEnviar)
        MinimumSize = New Size(932, 647)
        Name = "FormXatAdmin"
        Text = "Xats"
        CType(PictureBoxEmpresa, ComponentModel.ISupportInitialize).EndInit()
        PanelXat.ResumeLayout(False)
        PanelXat.PerformLayout()
        CType(DataGridViewEmpreses, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewXat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxEmpresa As PictureBox
    Friend WithEvents PanelXat As Panel
    Friend WithEvents LabelXat As Label
    Friend WithEvents TextBoxXat As TextBox
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents DataGridViewEmpreses As DataGridView
    Friend WithEvents DataGridViewXat As DataGridView
End Class
