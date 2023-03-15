Public Class FormPFAdmin
    Private Sub FormPFAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridViewPF.Rows.Add(1, "Com i on puc utilitzar els meus descomptes?", "Pots utilitzar els teus descomptes, durant les dates indicades, al mateix o mateixos restaurants vàlids del descompte")
    End Sub
End Class