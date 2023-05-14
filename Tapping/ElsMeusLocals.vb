Public Class ElsMeusLocals
    Private bbdd As New ClasseBBDD

    Public Sub selectTaula()
        'bbdd.mostrarAdmin(Constants.TAULALOCAL, GridViewLocals)
    End Sub
    Private Sub ElsMeusLocals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        bbdd.mostrarLocal(Constants.TAULALOCAL, GridViewLocals)
    End Sub

End Class