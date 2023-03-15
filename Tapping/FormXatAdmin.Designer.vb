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
        PictureBox1 = New PictureBox()
        PanelXat = New Panel()
        Label1 = New Label()
        TextBoxXat = New TextBox()
        ButtonEnviar = New Button()
        DataGridViewEmpreses = New DataGridView()
        Empresa = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelXat.SuspendLayout()
        CType(DataGridViewEmpreses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = My.Resources.Resources.LogoTappingSenseFondo
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 88)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PanelXat
        ' 
        PanelXat.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelXat.BackColor = Color.White
        PanelXat.Controls.Add(Label1)
        PanelXat.Controls.Add(PictureBox1)
        PanelXat.Location = New Point(141, 13)
        PanelXat.Margin = New Padding(3, 4, 3, 4)
        PanelXat.Name = "PanelXat"
        PanelXat.Size = New Size(760, 88)
        PanelXat.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(97, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 31)
        Label1.TabIndex = 2
        Label1.Text = "Tapping"' 
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
        ButtonEnviar.BackgroundImage = My.Resources.Resources.enviar
        ButtonEnviar.BackgroundImageLayout = ImageLayout.Stretch
        ButtonEnviar.Location = New Point(854, 555)
        ButtonEnviar.Margin = New Padding(3, 4, 3, 4)
        ButtonEnviar.Name = "ButtonEnviar"
        ButtonEnviar.Size = New Size(47, 33)
        ButtonEnviar.TabIndex = 5
        ButtonEnviar.UseVisualStyleBackColor = True
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
        DataGridViewEmpreses.Columns.AddRange(New DataGridViewColumn() {Empresa})
        DataGridViewEmpreses.Location = New Point(12, 12)
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
        DataGridViewEmpreses.Size = New Size(123, 576)
        DataGridViewEmpreses.TabIndex = 8
        ' 
        ' Empresa
        ' 
        Empresa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Empresa.HeaderText = "empresa"
        Empresa.MinimumWidth = 6
        Empresa.Name = "Empresa"
        Empresa.ReadOnly = True
        Empresa.Width = 6
        ' 
        ' FormXatAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(DataGridViewEmpreses)
        Controls.Add(PanelXat)
        Controls.Add(TextBoxXat)
        Controls.Add(ButtonEnviar)
        MinimumSize = New Size(932, 647)
        Name = "FormXatAdmin"
        Text = "FormXatAdmin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelXat.ResumeLayout(False)
        PanelXat.PerformLayout()
        CType(DataGridViewEmpreses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelXat As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxXat As TextBox
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents DataGridViewEmpreses As DataGridView
    Friend WithEvents Empresa As DataGridViewTextBoxColumn
End Class
