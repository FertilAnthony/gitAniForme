Imports BLL
Imports BO

Public Class EcranVeterinaire

#Region "Initialisation"
    Private Sub EcranPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        lbxVeterinaires.DataSource = MgtVeterinaire.getInstance().veterinaires
    End Sub
#End Region

    Private Sub BtnConnexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConnexion.Click
        Try
            MgtVeterinaire.getInstance().TestConnexion(CType(lbxVeterinaires.SelectedItem, Veterinaire), tbxMdp.Text)
            MessageBox.Show("Connexion réussi", "Bienvenue", MessageBoxButtons.OK)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connexion impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class