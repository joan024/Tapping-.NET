<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComentaris
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
        ListView1 = New ListView()
        Puntuacio = New ColumnHeader()
        Comentari = New ColumnHeader()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListView1.Columns.AddRange(New ColumnHeader() {Puntuacio, Comentari})
        ListView1.Location = New Point(12, 68)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(890, 520)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(353, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 46)
        Label1.TabIndex = 1
        Label1.Text = "Comentaris"' 
        ' FormComentaris
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(914, 600)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        MinimumSize = New Size(932, 647)
        Name = "FormComentaris"
        Text = "FormComentaris"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Puntuacio As ColumnHeader
    Friend WithEvents Comentari As ColumnHeader
End Class
