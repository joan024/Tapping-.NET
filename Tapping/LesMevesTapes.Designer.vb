﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LesMevesTapes
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
        personalitzacio = New DataGridViewTextBoxColumn()
        preu = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {nom, personalitzacio, preu})
        DataGridView1.Location = New Point(78, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1123, 573)
        DataGridView1.TabIndex = 1
        ' 
        ' nom
        ' 
        nom.HeaderText = "NOM"
        nom.MinimumWidth = 20
        nom.Name = "nom"
        nom.Width = 370
        ' 
        ' personalitzacio
        ' 
        personalitzacio.HeaderText = "PERSONALITZACIÓ"
        personalitzacio.MinimumWidth = 20
        personalitzacio.Name = "personalitzacio"
        personalitzacio.Width = 500
        ' 
        ' preu
        ' 
        preu.HeaderText = "PREU"
        preu.MinimumWidth = 20
        preu.Name = "preu"
        preu.Width = 250
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(78, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 48)
        Label1.TabIndex = 2
        Label1.Text = "LES TAPES"' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(56, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 45)
        Label2.TabIndex = 3
        Label2.Text = "Nom"' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(56, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 45)
        Label3.TabIndex = 4
        Label3.Text = "Personalització"' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(56, 319)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 45)
        Label4.TabIndex = 5
        Label4.Text = "Preu"' 
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
        Panel1.Location = New Point(1738, 166)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(694, 859)
        Panel1.TabIndex = 13
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.Location = New Point(498, 488)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(164, 42)
        RadioButton3.TabIndex = 17
        RadioButton3.TabStop = True
        RadioButton3.Text = "ELIMINAR"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(239, 488)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(213, 42)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "ACTUALITZAR"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(56, 488)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(131, 42)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "AFEGIR"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(56, 379)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 31)
        TextBox1.TabIndex = 15
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Location = New Point(222, 611)
        Button2.Name = "Button2"
        Button2.Size = New Size(275, 76)
        Button2.TabIndex = 14
        Button2.Text = "CONFIRMAR CANVIS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(56, 146)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(289, 31)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(56, 257)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(299, 31)
        TextBox4.TabIndex = 12
        ' 
        ' LesMevesTapes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        ClientSize = New Size(2502, 1217)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "LesMevesTapes"
        Text = "LesMevesTapes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents personalitzacio As DataGridViewTextBoxColumn
    Friend WithEvents preu As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
