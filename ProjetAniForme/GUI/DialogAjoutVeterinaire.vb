Imports System.Windows.Forms
Imports BLL

Public Class DialogAjoutVeterinaire

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim nomVeto As String = tbxNom.Text
        Dim mdpVeto As String = tbxMdp.Text
        Dim confirmationVeto As String = tbxConfirmation.Text

        If nomVeto = "" Or mdpVeto = "" Or confirmationVeto = "" Then
            MessageBox.Show("Veuillez remplir tous les champs", "champs incomplet(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf mdpVeto <> confirmationVeto Then
            MessageBox.Show("Mots de passe différents", "Erreur mots de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MgtVeterinaire.getInstance().ajoutProcedure(nomVeto, mdpVeto, False)
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
