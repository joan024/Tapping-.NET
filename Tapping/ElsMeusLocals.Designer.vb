<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ElsMeusLocals
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridViewLocals = New DataGridView()
        Panel1 = New Panel()
        TextBoxWeb = New TextBox()
        Label6 = New Label()
        TextBoxDescripcio = New TextBox()
        Label5 = New Label()
        RadioButtonActualitzar = New RadioButton()
        RadioButtonAfegir = New RadioButton()
        TextBoxDireccio = New TextBox()
        ButtonOk = New Button()
        TextBoxNom = New TextBox()
        TextBoxTelefon = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        CType(DataGridViewLocals, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridViewLocals
        ' 
        DataGridViewLocals.AllowUserToAddRows = False
        DataGridViewLocals.AllowUserToDeleteRows = False
        DataGridViewLocals.AllowUserToResizeColumns = False
        DataGridViewLocals.AllowUserToResizeRows = False
        DataGridViewLocals.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewLocals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewLocals.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewLocals.BackgroundColor = Color.White
        DataGridViewLocals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewLocals.Location = New Point(11, 67)
        DataGridViewLocals.Margin = New Padding(2)
        DataGridViewLocals.Name = "DataGridViewLocals"
        DataGridViewLocals.ReadOnly = True
        DataGridViewLocals.RowHeadersVisible = False
        DataGridViewLocals.RowHeadersWidth = 62
        DataGridViewLocals.RowTemplate.Height = 33
        DataGridViewLocals.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewLocals.Size = New Size(1757, 479)
        DataGridViewLocals.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(TextBoxWeb)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBoxDescripcio)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(RadioButtonActualitzar)
        Panel1.Controls.Add(RadioButtonAfegir)
        Panel1.Controls.Add(TextBoxDireccio)
        Panel1.Controls.Add(ButtonOk)
        Panel1.Controls.Add(TextBoxNom)
        Panel1.Controls.Add(TextBoxTelefon)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(11, 550)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1757, 245)
        Panel1.TabIndex = 14
        ' 
        ' TextBoxWeb
        ' 
        TextBoxWeb.Location = New Point(624, 119)
        TextBoxWeb.Margin = New Padding(2)
        TextBoxWeb.Name = "TextBoxWeb"
        TextBoxWeb.Size = New Size(459, 27)
        TextBoxWeb.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(624, 80)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 37)
        Label6.TabIndex = 20
        Label6.Text = "Web"
        ' 
        ' TextBoxDescripcio
        ' 
        TextBoxDescripcio.Location = New Point(624, 51)
        TextBoxDescripcio.Margin = New Padding(2)
        TextBoxDescripcio.Name = "TextBoxDescripcio"
        TextBoxDescripcio.Size = New Size(459, 27)
        TextBoxDescripcio.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(624, 12)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 37)
        Label5.TabIndex = 18
        Label5.Text = "Descripcio"
        ' 
        ' RadioButtonActualitzar
        ' 
        RadioButtonActualitzar.AutoSize = True
        RadioButtonActualitzar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonActualitzar.Location = New Point(844, 178)
        RadioButtonActualitzar.Margin = New Padding(2)
        RadioButtonActualitzar.Name = "RadioButtonActualitzar"
        RadioButtonActualitzar.Size = New Size(181, 36)
        RadioButtonActualitzar.TabIndex = 16
        RadioButtonActualitzar.TabStop = True
        RadioButtonActualitzar.Text = "ACTUALITZAR"
        RadioButtonActualitzar.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonAfegir
        ' 
        RadioButtonAfegir.AutoSize = True
        RadioButtonAfegir.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonAfegir.Location = New Point(695, 178)
        RadioButtonAfegir.Margin = New Padding(2)
        RadioButtonAfegir.Name = "RadioButtonAfegir"
        RadioButtonAfegir.Size = New Size(110, 36)
        RadioButtonAfegir.TabIndex = 14
        RadioButtonAfegir.TabStop = True
        RadioButtonAfegir.Text = "AFEGIR"
        RadioButtonAfegir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxDireccio
        ' 
        TextBoxDireccio.Location = New Point(14, 119)
        TextBoxDireccio.Margin = New Padding(2)
        TextBoxDireccio.Name = "TextBoxDireccio"
        TextBoxDireccio.Size = New Size(459, 27)
        TextBoxDireccio.TabIndex = 15
        ' 
        ' ButtonOk
        ' 
        ButtonOk.BackColor = Color.White
        ButtonOk.Location = New Point(1198, 80)
        ButtonOk.Margin = New Padding(2)
        ButtonOk.Name = "ButtonOk"
        ButtonOk.Size = New Size(220, 61)
        ButtonOk.TabIndex = 14
        ButtonOk.Text = "OK"
        ButtonOk.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNom
        ' 
        TextBoxNom.Location = New Point(14, 51)
        TextBoxNom.Margin = New Padding(2)
        TextBoxNom.Name = "TextBoxNom"
        TextBoxNom.Size = New Size(232, 27)
        TextBoxNom.TabIndex = 13
        ' 
        ' TextBoxTelefon
        ' 
        TextBoxTelefon.Location = New Point(14, 187)
        TextBoxTelefon.Margin = New Padding(2)
        TextBoxTelefon.MaxLength = 9
        TextBoxTelefon.Name = "TextBoxTelefon"
        TextBoxTelefon.Size = New Size(240, 27)
        TextBoxTelefon.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(14, 12)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 37)
        Label2.TabIndex = 3
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(14, 148)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 37)
        Label3.TabIndex = 4
        Label3.Text = "Telefon"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(14, 80)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 37)
        Label4.TabIndex = 5
        Label4.Text = "Direcció"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(11, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 41)
        Label1.TabIndex = 15
        Label1.Text = "ELS MEUS LOCALS"
        ' 
        ' ElsMeusLocals
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ClientSize = New Size(1779, 806)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(DataGridViewLocals)
        Margin = New Padding(2)
        Name = "ElsMeusLocals"
        Text = "Els Meus Locals"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewLocals, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridViewLocals As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButtonActualitzar As RadioButton
    Friend WithEvents RadioButtonAfegir As RadioButton
    Friend WithEvents TextBoxDireccio As TextBox
    Friend WithEvents ButtonOk As Button
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxTelefon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxWeb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDescripcio As TextBox
    Friend WithEvents Label5 As Label
End Class