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
        EcranRdv.Visible = False

        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False
        EcranVaccins.Visible = False
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
            txtboxTel.Text = client.NumTel
            MgtAnimal.getInstance.rechercheAnimauxClient(client.CodeClient)
            dataGridViewAnimauxClient.DataSource = MgtAnimal.getInstance().animauxClient
        Catch ex As Exception
            MessageBox.Show("Désolé ce client n'existe pas", "Client inexistant", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        
    End Sub

    Private Sub tbxNomClient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxNomClient.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim archive As Boolean = False
        Try

            MgtClient.getInstance().ajouterClient(tbxNomClient.Text, tbxPrenomClient.Text, tbxAdresseClient.Text, Nothing, tbxCpClient.Text, tbxVilleClient.Text, txtboxTel.Text, tbxAssuranceClient.Text, tbxEmailClient.Text, archive)
            MessageBox.Show("le client a bien était ajouté", "", MessageBoxButtons.OK)
            tbxCodeClient.Text = ""
            tbxNomClient.Text = ""
            tbxPrenomClient.Text = ""
            tbxAdresseClient.Text = ""
            tbxCpClient.Text = ""
            tbxVilleClient.Text = ""
            txtboxTel.Text = ""
            tbxEmailClient.Text = ""
            tbxAssuranceClient.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERREUR: le client n'a pas était ajouté ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbxAdresseClient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxAdresseClient.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxTel.TextChanged

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTel.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            MgtClient.getInstance().supprimerClient(tbxNomClient.Text)
            MessageBox.Show("Le client à bien était supprimé", "", MessageBoxButtons.OK)
            tbxCodeClient.Text = ""
            tbxNomClient.Text = ""
            tbxPrenomClient.Text = ""
            tbxAdresseClient.Text = ""
            tbxCpClient.Text = ""
            tbxVilleClient.Text = ""
            txtboxTel.Text = ""
            tbxEmailClient.Text = ""
            tbxAssuranceClient.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim archive As Boolean = False
        Try
            MgtClient.getInstance().modifierClient(tbxNomClient.Text, tbxPrenomClient.Text, tbxAdresseClient.Text, tbxAdresseClient.Text, tbxCpClient.Text, tbxVilleClient.Text, txtboxTel.Text, tbxAssuranceClient.Text, tbxEmailClient.Text, archive)
            MessageBox.Show("Le client à bien était modifé", "", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Echec de la modification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private _courant As Integer = -1
    Private _clientCourant As Client

    Private Property courant() As Integer
        Get
            Return _courant
        End Get
        Set(ByVal courant As Integer)
            _clientCourant = MgtClient.getInstance.clients(courant)
            _courant = courant
            'btnPrecedent = (_courant <> MgtClient.getInstance().clients.Count - 1)
            'btnSuivant = (_courant <> 0)
            afficherClientCourant()
        End Set
    End Property

    Private Property clientCourant() As Client
        Get
            Return _clientCourant
        End Get
        Set(ByVal value As Client)
            _clientCourant = value
        End Set
    End Property

    Private Sub afficherClientCourant()

        tbxCodeClient.Text = _clientCourant.CodeClient.ToString
        tbxNomClient.Text = _clientCourant.NomClient
        tbxPrenomClient.Text = _clientCourant.PrenomClient
        tbxAdresseClient.Text = _clientCourant.Adresse1
        tbxCpClient.Text = _clientCourant.CodePostal
        tbxVilleClient.Text = _clientCourant.Ville
        txtboxTel.Text = _clientCourant.NumTel
        tbxEmailClient.Text = _clientCourant.Email
        tbxAssuranceClient.Text = _clientCourant.Assurance
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim c As Client = MgtClient.getInstance().ObtenirClient(tbxNomClient.Text)
        tbxCodeClient.Text = c.CodeClient.ToString
        tbxNomClient.Text = c.NomClient
        tbxPrenomClient.Text = c.PrenomClient
        tbxAdresseClient.Text = c.Adresse1
        tbxCpClient.Text = c.CodePostal
        tbxVilleClient.Text = c.Ville
        txtboxTel.Text = c.NumTel
        tbxEmailClient.Text = c.Email
        tbxAssuranceClient.Text = c.Assurance
    End Sub

    Private Sub dataGridViewAnimauxClient_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridViewAnimauxClient.CellContentClick

    End Sub
End Class