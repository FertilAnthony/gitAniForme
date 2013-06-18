Imports BLL
Imports BO

Public Class EcranAgendas

    Private Sub EcranAgendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbVeterinaires.DataSource = MgtVeterinaire.getInstance().veterinaires
        Me.Visible = True
        Me.BringToFront()
        Dim nomVeto As String = cbVeterinaires.SelectedItem.ToString
        Dim v As Veterinaire = MgtVeterinaire.getInstance().ObtenirVeterinaire(nomVeto)

        MgtAgendas.getInstance().rechercheRdvVeto(v.CodeVeto, dtAgendas.Value)
        DataGridViewAgendas.DataSource = MgtAgendas.getInstance().lstRdvVeto

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

    Private Sub cbVeterinaires_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbVeterinaires.SelectedIndexChanged
     

        Dim nomVeto As String = cbVeterinaires.SelectedItem.ToString
        Dim v As Veterinaire = MgtVeterinaire.getInstance().ObtenirVeterinaire(nomVeto)

        MgtAgendas.getInstance().rechercheRdvVeto(v.CodeVeto, dtAgendas.Value)
        DataGridViewAgendas.DataSource = MgtAgendas.getInstance().lstRdvVeto
    End Sub

    Private Sub dtAgendas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtAgendas.ValueChanged
        Dim nomVeto As String = cbVeterinaires.SelectedItem.ToString
        Dim v As Veterinaire = MgtVeterinaire.getInstance().ObtenirVeterinaire(nomVeto)

        MgtAgendas.getInstance().rechercheRdvVeto(v.CodeVeto, dtAgendas.Value)
        DataGridViewAgendas.DataSource = MgtAgendas.getInstance().lstRdvVeto
    End Sub
End Class