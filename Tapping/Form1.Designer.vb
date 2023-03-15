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
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem4, ToolStripMenuItem3, ToolStripMenuItem2, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(2345, 83)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem4.DropDownItems.AddRange(New ToolStripItem() {NoticiesToolStripMenuItem, PreguntesFreqüentsToolStripMenuItem, XatToolStripMenuItem, TancaSessióToolStripMenuItem})
        ToolStripMenuItem4.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(106, 77)
        ToolStripMenuItem4.Text = "ALTRES"' 
        ' NoticiesToolStripMenuItem
        ' 
        NoticiesToolStripMenuItem.AutoSize = False
        NoticiesToolStripMenuItem.Name = "NoticiesToolStripMenuItem"
        NoticiesToolStripMenuItem.Size = New Size(211, 24)
        NoticiesToolStripMenuItem.Text = "Noticies"' 
        ' PreguntesFreqüentsToolStripMenuItem
        ' 
        PreguntesFreqüentsToolStripMenuItem.Name = "PreguntesFreqüentsToolStripMenuItem"
        PreguntesFreqüentsToolStripMenuItem.Size = New Size(328, 40)
        PreguntesFreqüentsToolStripMenuItem.Text = "Preguntes Freqüents"' 
        ' XatToolStripMenuItem
        ' 
        XatToolStripMenuItem.Name = "XatToolStripMenuItem"
        XatToolStripMenuItem.Size = New Size(328, 40)
        XatToolStripMenuItem.Text = "Xat"' 
        ' TancaSessióToolStripMenuItem
        ' 
        TancaSessióToolStripMenuItem.Name = "TancaSessióToolStripMenuItem"
        TancaSessióToolStripMenuItem.Size = New Size(328, 40)
        TancaSessióToolStripMenuItem.Text = "Tanca sessió"' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem3.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(170, 77)
        ToolStripMenuItem3.Text = "COMENTARIS"' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem2.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(135, 77)
        ToolStripMenuItem2.Text = "LES TAPES"' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.AccessibleRole = AccessibleRole.PushButton
        ToolStripMenuItem1.Alignment = ToolStripItemAlignment.Right
        ToolStripMenuItem1.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(218, 77)
        ToolStripMenuItem1.Text = "ELS MEUS LOCALS"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogoTappingSenseFondo
        PictureBox1.Location = New Point(185, 166)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(570, 474)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(177), CByte(46))
        Button1.Location = New Point(1924, 1089)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(199, 78)
        Button1.TabIndex = 7
        Button1.Text = "EDITAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(916, 382)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(731, 294)
        Label2.TabIndex = 8
        Label2.Text = "Label2"' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(916, 616)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(1032, 403)
        Label3.TabIndex = 9
        Label3.Text = "Label3"' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(916, 230)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(620, 142)
        Label1.TabIndex = 10
        Label1.Text = "Label1"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2345, 1248)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents NoticiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreguntesFreqüentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TancaSessióToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
