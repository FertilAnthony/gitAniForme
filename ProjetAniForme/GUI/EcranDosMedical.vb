Imports BLL

Public Class EcranDosMedical

#Region "Initialisation"
    Private Sub EcranPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        lbxAnimaux.DataSource = MgtAnimal.getInstance().animaux
        cbxClient.DataSource = MgtVeterinaire.getInstance().veterinaires
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

    End Sub

    Private Sub btnRadioTous_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRadioTous.CheckedChanged
        If btnRadioTous.Checked Then
            cbxClient.Enabled = False
        Else
            cbxClient.Enabled = True
        End If
    End Sub
End Class