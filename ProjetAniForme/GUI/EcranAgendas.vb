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

        DataGridViewAgendas.DataSource = majAgenda()
        Me.DataGridViewAgendas.Columns("codeAnimal").Visible = False

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Me.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If DataGridViewAgendas.SelectedRows.Count > 0 Then
            EcranConsultation.Visible = True
            EcranConsultation.BringToFront()
        End If
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

        DataGridViewAgendas.DataSource = majAgenda()
        Me.DataGridViewAgendas.Columns("codeAnimal").Visible = False

    End Sub

    Private Sub dtAgendas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtAgendas.ValueChanged
        Dim nomVeto As String = cbVeterinaires.SelectedItem.ToString
        Dim v As Veterinaire = MgtVeterinaire.getInstance().ObtenirVeterinaire(nomVeto)

        MgtAgendas.getInstance().rechercheRdvVeto(v.CodeVeto, dtAgendas.Value)

        DataGridViewAgendas.DataSource = majAgenda()
        Me.DataGridViewAgendas.Columns("codeAnimal").Visible = False
    End Sub

    Private Function majAgenda() As DataTable
        Dim voDataTable As New DataTable
        Dim voDataRow As DataRow

        'Création des champs 
        voDataTable.Columns.Add("Heure")
        voDataTable.Columns.Add("Nom du client")
        voDataTable.Columns.Add("Animal")
        voDataTable.Columns.Add("Race")
        voDataTable.Columns.Add("codeAnimal")

        For Each rdv As Agendas In MgtAgendas.getInstance().lstRdvVeto
            voDataRow = voDataTable.NewRow() 'Création d'une nouvelle ligne

            Dim heure As String = rdv.DateRdv.ToString
            Dim a As Animal = MgtAnimal.getInstance().ObtenirAnimal(rdv.CodeAnimal)
            Dim race As String = a.Race & " - " & a.Espece
            Dim codeClient As Guid = a.CodeClient
            Dim c As Client = MgtClient.getInstance().ObtenirClient(codeClient)

            voDataRow("Heure") = heure
            voDataRow("Nom du client") = c.ToString
            voDataRow("Animal") = a.NomAnimal
            voDataRow("Race") = race
            voDataRow("codeAnimal") = a.CodeAnimal
            voDataTable.Rows.Add(voDataRow)
        Next
        Return voDataTable

    End Function
End Class