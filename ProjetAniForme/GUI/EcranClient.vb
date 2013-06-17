Imports BLL
Imports BO

Public Class EcranClient

    Private Sub EcranClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Me.Visible = False

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Me.Visible = False
        EcranAnimaux.Visible = True
        EcranAnimaux.BringToFront()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim nomClient As String = tbxNomClient.Text
            Dim client As Client = MgtClient.getInstance().ObtenirClient(nomClient)
            tbxCodeClient.Text = client.CodeClient.ToString()
            tbxNomClient.Text = client.NomClient
            tbxPrenomClient.Text = client.PrenomClient
            tbxAdresseClient.Text = client.Adresse1 & " " & client.Adresse2
            tbxCpClient.Text = client.CodePostal
            tbxVilleClient.Text = client.Ville
            tbxAssuranceClient.Text = client.Assurance
            tbxEmailClient.Text = client.Email
            MgtAnimal.getInstance.rechercheAnimauxClient(client.CodeClient)
            dataGridViewAnimauxClient.DataSource = MgtAnimal.getInstance().animauxClient
        Catch ex As Exception
            MessageBox.Show("Désolé ce client n'existe pas", "Client inexistant", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        
    End Sub
End Class