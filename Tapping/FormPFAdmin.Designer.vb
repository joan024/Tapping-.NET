<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPFAdmin
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
        GroupBox1 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox3 = New TextBox()
        LabelResposta = New Label()
        TextBox2 = New TextBox()
        LabelPregunta = New Label()
        DataGridViewPF = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        pregunta = New DataGridViewTextBoxColumn()
        resposta = New DataGridViewTextBoxColumn()
        LabelTitolNoticies = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridViewPF, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(LabelResposta)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(LabelPregunta)
        GroupBox1.Location = New Point(12, 646)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1756, 148)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1074, 93)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 11
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1074, 58)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 10
        Button2.Text = "Modificar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1074, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 9
        Button1.Text = "Afegir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(848, 74)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 8
        ' 
        ' LabelResposta
        ' 
        LabelResposta.AutoSize = True
        LabelResposta.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LabelResposta.Location = New Point(846, 23)
        LabelResposta.Name = "LabelResposta"
        LabelResposta.Size = New Size(127, 38)
        LabelResposta.TabIndex = 5
        LabelResposta.Text = "Resposta"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(616, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(146, 27)
        TextBox2.TabIndex = 7
        ' 
        ' LabelPregunta
        ' 
        LabelPregunta.AutoSize = True
        LabelPregunta.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LabelPregunta.Location = New Point(616, 23)
        LabelPregunta.Name = "LabelPregunta"
        LabelPregunta.Size = New Size(129, 38)
        LabelPregunta.TabIndex = 4
        LabelPregunta.Text = "Pregunta"' 
        ' DataGridViewPF
        ' 
        DataGridViewPF.AllowUserToAddRows = False
        DataGridViewPF.AllowUserToDeleteRows = False
        DataGridViewPF.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewPF.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewPF.BackgroundColor = Color.White
        DataGridViewPF.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewPF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPF.Columns.AddRange(New DataGridViewColumn() {id, pregunta, resposta})
        DataGridViewPF.Location = New Point(12, 89)
        DataGridViewPF.Name = "DataGridViewPF"
        DataGridViewPF.ReadOnly = True
        DataGridViewPF.RowHeadersWidth = 51
        DataGridViewPF.RowTemplate.Height = 29
        DataGridViewPF.Size = New Size(1756, 554)
        DataGridViewPF.TabIndex = 11
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
        ' pregunta
        ' 
        pregunta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        pregunta.HeaderText = "Pregunta"
        pregunta.MinimumWidth = 6
        pregunta.Name = "pregunta"
        pregunta.ReadOnly = True
        pregunta.Width = 97
        ' 
        ' resposta
        ' 
        resposta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        resposta.HeaderText = "Resposta"
        resposta.MinimumWidth = 6
        resposta.Name = "resposta"
        resposta.ReadOnly = True
        resposta.Width = 98
        ' 
        ' LabelTitolNoticies
        ' 
        LabelTitolNoticies.Anchor = AnchorStyles.Top
        LabelTitolNoticies.AutoSize = True
        LabelTitolNoticies.BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        LabelTitolNoticies.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitolNoticies.Location = New Point(700, 18)
        LabelTitolNoticies.Name = "LabelTitolNoticies"
        LabelTitolNoticies.Size = New Size(416, 46)
        LabelTitolNoticies.TabIndex = 10
        LabelTitolNoticies.Text = "PREGUNTES FREQÜENTS"
        LabelTitolNoticies.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormPFAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1781, 806)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridViewPF)
        Controls.Add(LabelTitolNoticies)
        Name = "FormPFAdmin"
        Text = "FormPFAdmin"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridViewPF, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LabelResposta As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelPregunta As Label
    Friend WithEvents DataGridViewPF As DataGridView
    Friend WithEvents LabelTitolNoticies As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents pregunta As DataGridViewTextBoxColumn
    Friend WithEvents resposta As DataGridViewTextBoxColumn
End Class
