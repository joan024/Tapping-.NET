﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElsMeusLocals
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
        DataGridView1 = New DataGridView()
        nom = New DataGridViewTextBoxColumn()
        direccio = New DataGridViewTextBoxColumn()
        telefon = New DataGridViewTextBoxColumn()
        id_horari = New DataGridViewTextBoxColumn()
        descripcio = New DataGridViewTextBoxColumn()
        web = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {nom, direccio, telefon, id_horari, descripcio, web})
        DataGridView1.Location = New Point(87, 119)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1715, 494)
        DataGridView1.TabIndex = 0
        ' 
        ' nom
        ' 
        nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        nom.HeaderText = "LOCAL"
        nom.MinimumWidth = 20
        nom.Name = "nom"
        nom.Width = 220
        ' 
        ' direccio
        ' 
        direccio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        direccio.HeaderText = "DIRECCIÓ"
        direccio.MinimumWidth = 8
        direccio.Name = "direccio"
        direccio.Width = 200
        ' 
        ' telefon
        ' 
        telefon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        telefon.HeaderText = "TELÈFON"
        telefon.MinimumWidth = 20
        telefon.Name = "telefon"
        telefon.Width = 170
        ' 
        ' id_horari
        ' 
        id_horari.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        id_horari.HeaderText = "HORARI"
        id_horari.MinimumWidth = 20
        id_horari.Name = "id_horari"
        id_horari.Width = 220
        ' 
        ' descripcio
        ' 
        descripcio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        descripcio.HeaderText = "DESCRIPCIÓ"
        descripcio.MinimumWidth = 20
        descripcio.Name = "descripcio"
        descripcio.Width = 400
        ' 
        ' web
        ' 
        web.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        web.HeaderText = "WEB"
        web.MinimumWidth = 20
        web.Name = "web"
        web.Width = 220
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(RadioButton3)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(546, 634)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(599, 155)
        Panel1.TabIndex = 14
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(663, 82)
        RadioButton3.Margin = New Padding(2, 2, 2, 2)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(139, 36)
        RadioButton3.TabIndex = 17
        RadioButton3.TabStop = True
        RadioButton3.Text = "ELIMINAR"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(843, 82)
        RadioButton2.Margin = New Padding(2, 2, 2, 2)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(181, 36)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "ACTUALITZAR"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(508, 82)
        RadioButton1.Margin = New Padding(2, 2, 2, 2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(110, 36)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "AFEGIR"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(45, 327)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(145, 27)
        TextBox1.TabIndex = 15
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Location = New Point(640, 190)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(220, 61)
        Button2.TabIndex = 14
        Button2.Text = "CONFIRMAR CANVIS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(45, 90)
        TextBox5.Margin = New Padding(2, 2, 2, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(232, 27)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(45, 208)
        TextBox4.Margin = New Padding(2, 2, 2, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(240, 27)
        TextBox4.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(45, 27)
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
        Label3.Location = New Point(45, 148)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 37)
        Label3.TabIndex = 4
        Label3.Text = "Personalització"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(45, 266)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 37)
        Label4.TabIndex = 5
        Label4.Text = "Preu"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(87, 29)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 41)
        Label1.TabIndex = 15
        Label1.Text = "LES MEUS LOCALS"
        ' 
        ' ElsMeusLocals
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ClientSize = New Size(1539, 844)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "ElsMeusLocals"
        Text = "Els Meus Locals"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents direccio As DataGridViewTextBoxColumn
    Friend WithEvents telefon As DataGridViewTextBoxColumn
    Friend WithEvents id_horari As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents web As DataGridViewTextBoxColumn
End Class
