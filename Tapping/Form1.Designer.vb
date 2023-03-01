<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoticiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreguntesFreqüentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TancaSessióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1327, 50)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoticiesToolStripMenuItem, Me.PreguntesFreqüentsToolStripMenuItem, Me.XatToolStripMenuItem, Me.TancaSessióToolStripMenuItem})
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(71, 46)
        Me.ToolStripMenuItem4.Text = "ALTRES"
        '
        'NoticiesToolStripMenuItem
        '
        Me.NoticiesToolStripMenuItem.AutoSize = False
        Me.NoticiesToolStripMenuItem.Name = "NoticiesToolStripMenuItem"
        Me.NoticiesToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.NoticiesToolStripMenuItem.Text = "Noticies"
        '
        'PreguntesFreqüentsToolStripMenuItem
        '
        Me.PreguntesFreqüentsToolStripMenuItem.Name = "PreguntesFreqüentsToolStripMenuItem"
        Me.PreguntesFreqüentsToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.PreguntesFreqüentsToolStripMenuItem.Text = "Preguntes Freqüents"
        '
        'XatToolStripMenuItem
        '
        Me.XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        Me.XatToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.XatToolStripMenuItem.Text = "Xat"
        '
        'TancaSessióToolStripMenuItem
        '
        Me.TancaSessióToolStripMenuItem.Name = "TancaSessióToolStripMenuItem"
        Me.TancaSessióToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.TancaSessióToolStripMenuItem.Text = "Tanca sessió"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(112, 46)
        Me.ToolStripMenuItem3.Text = "COMENTARIS"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(90, 46)
        Me.ToolStripMenuItem2.Text = "LES TAPES"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 46)
        Me.ToolStripMenuItem1.Text = "ELS MEUS LOCALS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(238, 201)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 273)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1009, 632)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 51)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "EDITAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(713, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 273)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(441, 519)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(465, 81)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 749)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents NoticiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreguntesFreqüentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TancaSessióToolStripMenuItem As ToolStripMenuItem
End Class
