Imports BLL
Imports BO

Public Class EcranRdv

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Me.Visible = False
    End Sub

    Private Sub EcranRdv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxVeterinaire.DataSource = MgtVeterinaire.getInstance().veterinaires
        cbxClient.DataSource = MgtClient.getInstance().clients
        Dim client As Client = CType(cbxClient.SelectedItem, Client)
        Dim codeClient As Guid = client.CodeClient
        MgtAnimal.getInstance.rechercheAnimauxClient(codeClient)
        cbxAnimalClient.DataSource = MgtAnimal.getInstance().animauxClient

        'Désactivation du cadre nouveau rdv au chargement de la page
        Me.cbxClient.Enabled = False
        Me.cbxAnimalClient.Enabled = False
        Me.Visible = True
        Me.BringToFront()
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Me.Visible = False
        EcranClient.Visible = True
        EcranClient.BringToFront()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Me.Visible = False
        EcranAnimaux.Visible = True
        EcranAnimaux.BringToFront()
    End Sub

    Private Sub cbxClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxClient.SelectedIndexChanged
        Dim client As Client = CType(cbxClient.SelectedItem, Client)
        Dim codeClient As Guid = client.CodeClient
        MgtAnimal.getInstance.rechercheAnimauxClient(codeClient)
        cbxAnimalClient.DataSource = Nothing
        cbxAnimalClient.Items.Clear()
        cbxAnimalClient.DataSource = MgtAnimal.getInstance.animauxClient
    End Sub

    Private Sub btnAjouterRdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouterRdv.Click
        Me.cbxClient.Enabled = True
        Me.cbxAnimalClient.Enabled = True
    End Sub
End Class