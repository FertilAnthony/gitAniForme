Imports BLL
Imports BO
Imports System.Data.Common

Public Class EcranVeterinaire

#Region "Initialisation"
    Private Sub EcranPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        lbxVeterinaires.DataSource = MgtVeterinaire.getInstance().veterinaires
    End Sub
#End Region

    Private Sub BtnConnexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConnexion.Click
        Try
            Dim vetoConnect As Veterinaire = CType(lbxVeterinaires.SelectedItem, Veterinaire)
            MgtVeterinaire.getInstance().TestConnexion(vetoConnect, tbxMdp.Text)
            MgtVeterinaire.getInstance().getVetoConnect(vetoConnect)
            MessageBox.Show("Connexion réussi", "Bienvenue", MessageBoxButtons.OK)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connexion impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAjouterVeto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouterVeto.Click
        DialogAjoutVeterinaire.Visible = True
    End Sub

    Private Sub btnSupprimerVeto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimerVeto.Click
        DialogSupprVeterinaire.Visible = True
    End Sub

    Private Sub btnModifierVeto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifierVeto.Click
        DialogModifVeterinaire.Visible = True
    End Sub

End Class