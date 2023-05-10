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
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        NoticiesToolStripMenuItem = New ToolStripMenuItem()
        PreguntesFreqüentsToolStripMenuItem = New ToolStripMenuItem()
        XatToolStripMenuItem = New ToolStripMenuItem()
        TancaSessióToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        PictureBoxFoto = New PictureBox()
        LabelInfo = New Label()
        LabelTitol = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem4, ToolStripMenuItem3, ToolStripMenuItem6, ToolStripMenuItem5, ToolStripMenuItem2, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(1874, 66)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem4.DropDownItems.AddRange(New ToolStripItem() {NoticiesToolStripMenuItem, PreguntesFreqüentsToolStripMenuItem, XatToolStripMenuItem, TancaSessióToolStripMenuItem})
        ToolStripMenuItem4.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(88, 62)
        ToolStripMenuItem4.Text = "ALTRES"
        ' 
        ' NoticiesToolStripMenuItem
        ' 
        NoticiesToolStripMenuItem.AutoSize = False
        NoticiesToolStripMenuItem.Name = "NoticiesToolStripMenuItem"
        NoticiesToolStripMenuItem.Size = New Size(211, 24)
        NoticiesToolStripMenuItem.Text = "Noticies"
        ' 
        ' PreguntesFreqüentsToolStripMenuItem
        ' 
        PreguntesFreqüentsToolStripMenuItem.Name = "PreguntesFreqüentsToolStripMenuItem"
        PreguntesFreqüentsToolStripMenuItem.Size = New Size(271, 30)
        PreguntesFreqüentsToolStripMenuItem.Text = "Preguntes Freqüents"
        ' 
        ' XatToolStripMenuItem
        ' 
        XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        XatToolStripMenuItem.Size = New Size(271, 30)
        XatToolStripMenuItem.Text = "Xat"
        ' 
        ' TancaSessióToolStripMenuItem
        ' 
        TancaSessióToolStripMenuItem.Name = "TancaSessióToolStripMenuItem"
        TancaSessióToolStripMenuItem.Size = New Size(271, 30)
        TancaSessióToolStripMenuItem.Text = "Tanca sessió"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem3.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(141, 62)
        ToolStripMenuItem3.Text = "COMENTARIS"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem6.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(98, 62)
        ToolStripMenuItem6.Text = "GALERIA"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem5.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(143, 62)
        ToolStripMenuItem5.Text = "DESCOMPTES"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem2.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(113, 62)
        ToolStripMenuItem2.Text = "LES TAPES"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.AccessibleRole = AccessibleRole.PushButton
        ToolStripMenuItem1.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem1.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(181, 62)
        ToolStripMenuItem1.Text = "ELS MEUS LOCALS"
        ' 
        ' PictureBoxFoto
        ' 
        PictureBoxFoto.Image = My.Resources.Resources.SenseFoto
        PictureBoxFoto.Location = New Point(148, 133)
        PictureBoxFoto.Margin = New Padding(3, 4, 3, 4)
        PictureBoxFoto.Name = "PictureBoxFoto"
        PictureBoxFoto.Size = New Size(456, 379)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxFoto.TabIndex = 6
        PictureBoxFoto.TabStop = False
        ' 
        ' LabelInfo
        ' 
        LabelInfo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelInfo.Location = New Point(733, 306)
        LabelInfo.Name = "LabelInfo"
        LabelInfo.Size = New Size(585, 235)
        LabelInfo.TabIndex = 8
        LabelInfo.Text = "Label"
        ' 
        ' LabelTitol
        ' 
        LabelTitol.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelTitol.Location = New Point(733, 184)
        LabelTitol.Name = "LabelTitol"
        LabelTitol.Size = New Size(496, 114)
        LabelTitol.TabIndex = 10
        LabelTitol.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1874, 942)
        Controls.Add(LabelTitol)
        Controls.Add(LabelInfo)
        Controls.Add(PictureBoxFoto)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents LabelInfo As Label
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents NoticiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreguntesFreqüentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TancaSessióToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelTitol As Label
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
End Class
