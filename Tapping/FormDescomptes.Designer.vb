<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDescomptes
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
        DataGridViewDescomptes = New DataGridView()
        Label1 = New Label()
        TextBoxText = New TextBox()
        Label2 = New Label()
        DateTimePickerInici = New DateTimePicker()
        Label3 = New Label()
        DateTimePickerFinal = New DateTimePicker()
        Label4 = New Label()
        TextBoxCodi = New TextBox()
        Label5 = New Label()
        ButtonAccio = New Button()
        ButtonGenerar = New Button()
        CType(DataGridViewDescomptes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewDescomptes
        ' 
        DataGridViewDescomptes.AllowUserToAddRows = False
        DataGridViewDescomptes.AllowUserToDeleteRows = False
        DataGridViewDescomptes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewDescomptes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewDescomptes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewDescomptes.BackgroundColor = Color.White
        DataGridViewDescomptes.BorderStyle = BorderStyle.None
        DataGridViewDescomptes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewDescomptes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewDescomptes.ColumnHeadersVisible = False
        DataGridViewDescomptes.Location = New Point(12, 74)
        DataGridViewDescomptes.Name = "DataGridViewDescomptes"
        DataGridViewDescomptes.ReadOnly = True
        DataGridViewDescomptes.RowHeadersVisible = False
        DataGridViewDescomptes.RowHeadersWidth = 51
        DataGridViewDescomptes.RowTemplate.Height = 29
        DataGridViewDescomptes.Size = New Size(1032, 429)
        DataGridViewDescomptes.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(464, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 46)
        Label1.TabIndex = 4
        Label1.Text = "Descomptes"
        ' 
        ' TextBoxText
        ' 
        TextBoxText.Location = New Point(1050, 143)
        TextBoxText.Name = "TextBoxText"
        TextBoxText.Size = New Size(250, 27)
        TextBoxText.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1161, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 6
        Label2.Text = "Text"
        ' 
        ' DateTimePickerInici
        ' 
        DateTimePickerInici.CustomFormat = "yyyy-MM-dd"
        DateTimePickerInici.Format = DateTimePickerFormat.Custom
        DateTimePickerInici.Location = New Point(1050, 214)
        DateTimePickerInici.Name = "DateTimePickerInici"
        DateTimePickerInici.Size = New Size(250, 27)
        DateTimePickerInici.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1144, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 8
        Label3.Text = "Data Inici"
        ' 
        ' DateTimePickerFinal
        ' 
        DateTimePickerFinal.CustomFormat = "yyyy-MM-dd"
        DateTimePickerFinal.Format = DateTimePickerFormat.Custom
        DateTimePickerFinal.Location = New Point(1050, 286)
        DateTimePickerFinal.Name = "DateTimePickerFinal"
        DateTimePickerFinal.Size = New Size(250, 27)
        DateTimePickerFinal.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1144, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 10
        Label4.Text = "Data Final"
        ' 
        ' TextBoxCodi
        ' 
        TextBoxCodi.Location = New Point(1050, 357)
        TextBoxCodi.Name = "TextBoxCodi"
        TextBoxCodi.ReadOnly = True
        TextBoxCodi.Size = New Size(250, 27)
        TextBoxCodi.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1157, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 20)
        Label5.TabIndex = 12
        Label5.Text = "Codi"
        ' 
        ' ButtonAccio
        ' 
        ButtonAccio.Location = New Point(1144, 474)
        ButtonAccio.Name = "ButtonAccio"
        ButtonAccio.Size = New Size(94, 29)
        ButtonAccio.TabIndex = 13
        ButtonAccio.Text = "Crear"
        ButtonAccio.UseVisualStyleBackColor = True
        ' 
        ' ButtonGenerar
        ' 
        ButtonGenerar.Location = New Point(1144, 400)
        ButtonGenerar.Name = "ButtonGenerar"
        ButtonGenerar.Size = New Size(94, 29)
        ButtonGenerar.TabIndex = 16
        ButtonGenerar.Text = "Generar"
        ButtonGenerar.UseVisualStyleBackColor = True
        ' 
        ' FormDescomptes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(194), CByte(102))
        ClientSize = New Size(1312, 515)
        Controls.Add(ButtonGenerar)
        Controls.Add(ButtonAccio)
        Controls.Add(Label5)
        Controls.Add(TextBoxCodi)
        Controls.Add(Label4)
        Controls.Add(DateTimePickerFinal)
        Controls.Add(Label3)
        Controls.Add(DateTimePickerInici)
        Controls.Add(Label2)
        Controls.Add(TextBoxText)
        Controls.Add(Label1)
        Controls.Add(DataGridViewDescomptes)
        MaximumSize = New Size(1330, 562)
        MinimumSize = New Size(1330, 562)
        Name = "FormDescomptes"
        Text = "Descomptes"
        CType(DataGridViewDescomptes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridViewDescomptes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerInici As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerFinal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCodi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonAccio As Button
    Friend WithEvents ButtonGenerar As Button
End Class
