Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Label1.Font = New Font("Arial", 14, FontStyle.Regular Or FontStyle.Italic)
        Label1.Font = New Font("Arial", 20)
        Label2.Font = New Font("Arial", 20)

        Label1.Text = "Nom: Mosicopa & El Mos" + Environment.NewLine +
                       "" + Environment.NewLine +
                       "Adreça: Carrer del Comtat d'Urgell, 6, 25700 La Seu d'Urgell, Lleida" + Environment.NewLine +
                       "" + Environment.NewLine +
                       "Telèfon: 973 35 19 00"


        Label2.Text = "Descripció del local:" + Environment.NewLine +
                        "" + Environment.NewLine +
                      "Mosicopa, el teu Restaurant Japonès a la Seu d'Urgell" + Environment.NewLine +
                      "Cuina de fusió japonesa amb un toc pirinenc." + Environment.NewLine +
                      "Elaboració artesanal de tots els plats amb productes de proximitat."

    End Sub

End Class
