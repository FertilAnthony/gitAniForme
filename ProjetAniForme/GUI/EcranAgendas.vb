Imports BLL
Imports BO

Public Class EcranAgendas

    Private Sub EcranAgendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbVeterinaires.DataSource = MgtVeterinaire.getInstance().veterinaires
        Me.Visible = True
        Me.BringToFront()
        Dim nomVeto As String = cbVeterinaires.SelectedItem.ToString
        Dim v As Veterinaire = MgtVeterinaire.getInstance().ObtenirVeterinaire(nomVeto)

        MgtVeterinaire.getInstance().rechercheRdvVeto(v.CodeVeto)
        DataGridViewAgendas.DataSource = MgtVeterinaire.getInstance().lstRdvVeto

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Me.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        EcranConsultation.Visible = True
        EcranConsultation.BringToFront()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Me.Visible = False
        EcranDosMedical.Visible = True
        EcranDosMedical.BringToFront()
    End Sub
End Class