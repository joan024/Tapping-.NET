<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridViewClients
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
        DataGridViewClients = New DataGridView()
        IDUSUARI = New DataGridViewTextBoxColumn()
        NIF = New DataGridViewTextBoxColumn()
        TELEFON = New DataGridViewTextBoxColumn()
        PACK = New DataGridViewTextBoxColumn()
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewClients
        ' 
        DataGridViewClients.BackgroundColor = Color.White
        DataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewClients.Columns.AddRange(New DataGridViewColumn() {IDUSUARI, NIF, TELEFON, PACK})
        DataGridViewClients.Location = New Point(23, 12)
        DataGridViewClients.Name = "DataGridViewClients"
        DataGridViewClients.RowHeadersWidth = 62
        DataGridViewClients.RowTemplate.Height = 33
        DataGridViewClients.Size = New Size(1370, 635)
        DataGridViewClients.TabIndex = 2
        ' 
        ' IDUSUARI
        ' 
        IDUSUARI.HeaderText = "IDUSUARI"
        IDUSUARI.MinimumWidth = 8
        IDUSUARI.Name = "IDUSUARI"
        IDUSUARI.Width = 140
        ' 
        ' NIF
        ' 
        NIF.HeaderText = "NIF"
        NIF.MinimumWidth = 8
        NIF.Name = "NIF"
        NIF.Width = 220
        ' 
        ' TELEFON
        ' 
        TELEFON.HeaderText = "TELEFON"
        TELEFON.MinimumWidth = 8
        TELEFON.Name = "TELEFON"
        TELEFON.Width = 260
        ' 
        ' PACK
        ' 
        PACK.HeaderText = "PACK"
        PACK.MinimumWidth = 8
        PACK.Name = "PACK"
        PACK.Width = 230
        ' 
        ' GridViewClients
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1426, 659)
        Controls.Add(DataGridViewClients)
        FormBorderStyle = FormBorderStyle.None
        Name = "GridViewClients"
        Text = "GridViewClients"
        CType(DataGridViewClients, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewClients As DataGridView
    Friend WithEvents IDUSUARI As DataGridViewTextBoxColumn
    Friend WithEvents NIF As DataGridViewTextBoxColumn
    Friend WithEvents TELEFON As DataGridViewTextBoxColumn
    Friend WithEvents PACK As DataGridViewTextBoxColumn
End Class
