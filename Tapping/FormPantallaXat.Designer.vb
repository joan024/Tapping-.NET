<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPantallaXat
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
        ButtonEnviar = New Button()
        TextBoxXat = New TextBox()
        Label1 = New Label()
        PanelXat = New Panel()
        PictureBox1 = New PictureBox()
        DataGridViewXat = New DataGridView()
        PanelXat.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewXat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonEnviar
        ' 
        ButtonEnviar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonEnviar.BackColor = Color.LightGray
        ButtonEnviar.BackgroundImage = My.Resources.Resources.enviar
        ButtonEnviar.BackgroundImageLayout = ImageLayout.Stretch
        ButtonEnviar.Location = New Point(854, 551)
        ButtonEnviar.Margin = New Padding(3, 4, 3, 4)
        ButtonEnviar.Name = "ButtonEnviar"
        ButtonEnviar.Size = New Size(47, 33)
        ButtonEnviar.TabIndex = 0
        ButtonEnviar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxXat
        ' 
        TextBoxXat.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxXat.Location = New Point(14, 529)
        TextBoxXat.Margin = New Padding(3, 4, 3, 4)
        TextBoxXat.Multiline = True
        TextBoxXat.Name = "TextBoxXat"
        TextBoxXat.ScrollBars = ScrollBars.Vertical
        TextBoxXat.Size = New Size(833, 53)
        TextBoxXat.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(97, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 31)
        Label1.TabIndex = 2
        Label1.Text = "Tapping"
        ' 
        ' PanelXat
        ' 
        PanelXat.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelXat.BackColor = Color.White
        PanelXat.Controls.Add(Label1)
        PanelXat.Location = New Point(14, 16)
        PanelXat.Margin = New Padding(3, 4, 3, 4)
        PanelXat.Name = "PanelXat"
        PanelXat.Size = New Size(887, 88)
        PanelXat.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = My.Resources.Resources.LogoTappingSenseFondo
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(14, 16)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 88)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
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
        DataGridViewXat.Location = New Point(14, 111)
        DataGridViewXat.Name = "DataGridViewXat"
        DataGridViewXat.ReadOnly = True
        DataGridViewXat.RowHeadersVisible = False
        DataGridViewXat.RowHeadersWidth = 51
        DataGridViewXat.RowTemplate.Height = 29
        DataGridViewXat.Size = New Size(887, 411)
        DataGridViewXat.TabIndex = 5
        ' 
        ' FormPantallaXat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(914, 600)
        Controls.Add(DataGridViewXat)
        Controls.Add(PictureBox1)
        Controls.Add(PanelXat)
        Controls.Add(TextBoxXat)
        Controls.Add(ButtonEnviar)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(932, 647)
        Name = "FormPantallaXat"
        Text = "Xat"
        PanelXat.ResumeLayout(False)
        PanelXat.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewXat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents TextBoxXat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelXat As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewXat As DataGridView
End Class
