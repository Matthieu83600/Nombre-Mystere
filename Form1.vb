Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim leNombreMystere As Integer
        Dim compteurDeCoups As Integer
        Dim laReponse As Integer

        Randomize()
        leNombreMystere = Int((Rnd() * 100) + 1)
        ' Verifier le nombre mystère
        ' MessageBox.Show(leNombreMystere)

        Do While laReponse <> leNombreMystere
            laReponse = InputBox(
                "Quel est le nombre mystère ?",
                "Jeu du nombre mystère"
                )
            compteurDeCoups += 1
            If laReponse < leNombreMystere Then
                MessageBox.Show(
                    "Plus grand !",
                    "Jeu du nombre mystère",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    )
            ElseIf laReponse > leNombreMystere Then
                MessageBox.Show(
                    "Plus petit !",
                    "Jeu du nombre mystère",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    )
            End If
        Loop
        ' Le nombre a été trouvé 
        MessageBox.Show(
            "Bravo ! Tu as trouvé le nombre mystère en " & compteurDeCoups & " tentatives.",
            "Jeu du nombre mystère",
            MessageBoxButtons.OK
            )
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
