<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2NoticiesAdminvb
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
        LabelTitolNoticies = New Label()
        DataGridViewNoticies = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        Titol = New DataGridViewTextBoxColumn()
        descripcio = New DataGridViewTextBoxColumn()
        foto = New DataGridViewImageColumn()
        dataPublicacio = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        LabelDescripcio = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox1 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelTitolNoticies
        ' 
        LabelTitolNoticies.Anchor = AnchorStyles.Top
        LabelTitolNoticies.AutoSize = True
        LabelTitolNoticies.BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        LabelTitolNoticies.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolNoticies.Location = New Point(797, 19)
        LabelTitolNoticies.Name = "LabelTitolNoticies"
        LabelTitolNoticies.Size = New Size(172, 46)
        LabelTitolNoticies.TabIndex = 1
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
        DataGridViewNoticies.BackgroundColor = Color.White
        DataGridViewNoticies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewNoticies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewNoticies.Columns.AddRange(New DataGridViewColumn() {id, Titol, descripcio, foto, dataPublicacio})
        DataGridViewNoticies.Location = New Point(12, 87)
        DataGridViewNoticies.Name = "DataGridViewNoticies"
        DataGridViewNoticies.ReadOnly = True
        DataGridViewNoticies.RowHeadersWidth = 51
        DataGridViewNoticies.RowTemplate.Height = 29
        DataGridViewNoticies.Size = New Size(1756, 554)
        DataGridViewNoticies.TabIndex = 2
        ' 
        ' id
        ' 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        id.HeaderText = "Id"
        id.MinimumWidth = 6
        id.Name = "id"
        id.ReadOnly = True
        id.Width = 51
        ' 
        ' Titol
        ' 
        Titol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Titol.HeaderText = "Titol"
        Titol.MinimumWidth = 6
        Titol.Name = "Titol"
        Titol.ReadOnly = True
        Titol.Width = 68
        ' 
        ' descripcio
        ' 
        descripcio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        descripcio.HeaderText = "Descripció"
        descripcio.MinimumWidth = 6
        descripcio.Name = "descripcio"
        descripcio.ReadOnly = True
        descripcio.Width = 108
        ' 
        ' foto
        ' 
        foto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        foto.HeaderText = "Foto"
        foto.MinimumWidth = 6
        foto.Name = "foto"
        foto.ReadOnly = True
        foto.Width = 45
        ' 
        ' dataPublicacio
        ' 
        dataPublicacio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dataPublicacio.HeaderText = "Data Publicació"
        dataPublicacio.MinimumWidth = 6
        dataPublicacio.Name = "dataPublicacio"
        dataPublicacio.ReadOnly = True
        dataPublicacio.Resizable = DataGridViewTriState.True
        dataPublicacio.Width = 142
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(447, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 38)
        Label1.TabIndex = 3
        Label1.Text = "Titol"' 
        ' LabelDescripcio
        ' 
        LabelDescripcio.AutoSize = True
        LabelDescripcio.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDescripcio.Location = New Point(658, 23)
        LabelDescripcio.Name = "LabelDescripcio"
        LabelDescripcio.Size = New Size(146, 38)
        LabelDescripcio.TabIndex = 4
        LabelDescripcio.Text = "Descripció"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(897, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(207, 38)
        Label2.TabIndex = 5
        Label2.Text = "Data Publicació"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(413, 74)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(658, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(146, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(931, 74)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(LabelDescripcio)
        GroupBox1.Location = New Point(12, 644)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1756, 148)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1157, 93)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 11
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1157, 58)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 10
        Button2.Text = "Modificar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1157, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 9
        Button1.Text = "Afegir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2NoticiesAdminvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1780, 804)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridViewNoticies)
        Controls.Add(LabelTitolNoticies)
        Name = "Form2NoticiesAdminvb"
        Text = "Form2NoticiesAdminvb"
        CType(DataGridViewNoticies, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTitolNoticies As Label
    Friend WithEvents DataGridViewNoticies As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDescripcio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Titol As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents foto As DataGridViewImageColumn
    Friend WithEvents dataPublicacio As DataGridViewTextBoxColumn
End Class
