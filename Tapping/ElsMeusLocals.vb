Public Class ElsMeusLocals
    Private bbdd As New ClasseBBDD

    Private Sub ElsMeusLocals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbdd.mostrarLocal(Constants.TAULALOCAL, GridViewLocals)
    End Sub

End Class