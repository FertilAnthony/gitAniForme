Imports BLL
Imports BO

Public Class EcranDosMedical

#Region "Initialisation"
    Private Sub EcranPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        lbxAnimaux.DataSource = MgtAnimal.getInstance().animaux
        cbxClient.DataSource = MgtClient.getInstance().clients
    End Sub
#End Region

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Visible = False
    End Sub

    Private Sub EcranDosMedical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.BringToFront()

    End Sub

    Private Sub btnDossierMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossierMed.Click
        EcranDossierMedical.Visible = True
    End Sub

    Private Sub btnRadioTous_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRadioTous.CheckedChanged
        If btnRadioTous.Checked Then
            cbxClient.Enabled = False
        Else
            cbxClient.Enabled = True
        End If
    End Sub

    Private Sub cbxClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxClient.SelectedIndexChanged
        If cbxClient.Enabled = True Then
            majLbxAnimauxClient()
        End If
    End Sub


    Private Sub radioBtnClient_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles radioBtnClient.MouseClick
        majLbxAnimauxClient()
    End Sub

    Private Sub majLbxAnimauxClient()
        Dim client As Client = CType(cbxClient.SelectedItem, Client)
        Dim codeClient As Guid = client.CodeClient
        MgtAnimal.getInstance.rechercheAnimauxClient(codeClient)
        lbxAnimaux.DataSource = Nothing
        lbxAnimaux.Items.Clear()
        lbxAnimaux.DataSource = MgtAnimal.getInstance.animauxClient
    End Sub

    Private Sub btnRadioTous_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRadioTous.MouseClick
        lbxAnimaux.DataSource = Nothing
        lbxAnimaux.Items.Clear()
        lbxAnimaux.DataSource = MgtAnimal.getInstance().animaux
    End Sub
End Class