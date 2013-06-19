Imports BLL
Imports BO

Public Class EcranAnimaux

    Private position As Integer = 0

    Private Sub EcranClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficherAnimauxClient()
        Me.Visible = True

        Me.BringToFront()
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Me.Visible = False

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click


        Me.Visible = False
        EcranClient.Visible = True
        EcranClient.BringToFront()
        EcranAgendas.Visible = False
        EcranRdv.Visible = False
        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False
        EcranVaccins.Visible = False

    End Sub

    Private Sub afficherAnimauxClient()
        Dim c As Client = MgtClient.getInstance().clients.Item(position)
        Dim a As Animal = MgtAnimal.getInstance().animaux.Item(position)
        Dim codeClient As Guid = c.CodeClient
        MgtAnimal.getInstance.rechercheAnimauxClient(codeClient)
        DataGridView1.DataSource = MgtAnimal.getInstance.animauxClient

        tbxCodeClient.Text = codeClient.ToString()
        tbxNomClient.Text = c.NomClient
        tbxPrenomClient.Text = c.PrenomClient

        tbxCodeAnimal.Text = a.CodeAnimal.ToString()
        tbxNomAnimal.Text = a.NomAnimal
        tbxCouleurAnimal.Text = a.Couleur
        tbxTatouageAnimal.Text = a.Tatouage
        'Dim i As Integer = 0
        'Dim tRace(MgtAnimal.getInstance().raceAnimaux.Count) As String
        'Dim tEspece(MgtAnimal.getInstance().raceAnimaux.Count) As String
        'While i < MgtAnimal.getInstance().raceAnimaux.Count
        'tRace(i) = MgtAnimal.getInstance().raceAnimaux.Item(i).Race
        'tEspece(i) = MgtAnimal.getInstance().raceAnimaux.Item(i).Espece
        'i = i + 1
        'End While
        'cbxRaceAnimal.DataSource = tRace
        'cbxRaceAnimal.SelectedIndex = 0
        'cbxEspeceAnimal.DataSource = tEspece
        'cbxEspeceAnimal.SelectedIndex = 0

        'Ajout espece dans combobox espece
        Dim especeAnimal As New List(Of String)
        For Each r As Race In MgtAnimal.getInstance().raceAnimaux
            Dim espece As String = r.Espece
            Dim unique As String = especeAnimal.Find(Function(e As String) e = espece)
            If unique = Nothing Then
                especeAnimal.Add(espece)
            End If
        Next
        cbxEspeceAnimal.DataSource = especeAnimal

        Select Case a.Sexe
            Case "M".ToCharArray
                cbxSexeAnimal.SelectedIndex = 1
            Case "F".ToCharArray
                cbxSexeAnimal.SelectedIndex = 2
            Case "H".ToCharArray
                cbxSexeAnimal.SelectedIndex = 3
            Case Else
                cbxSexeAnimal.SelectedIndex = 0
        End Select

    End Sub

    Private Sub cbxEspeceAnimal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEspeceAnimal.SelectedIndexChanged
        Dim raceAnimal As New List(Of Race)

        For Each es As Race In MgtAnimal.getInstance.raceAnimaux
            Dim espece As String = cbxEspeceAnimal.Text
            If es.Espece = espece Then
                raceAnimal.Add(es)
            End If
        Next
        cbxRaceAnimal.DataSource = raceAnimal
        cbxRaceAnimal.DisplayMember = "Race" 'affiche le libelle dans la comboBox
    End Sub

    Private Sub btnAjouterAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouterAnimal.Click
        DialogAjoutAnimal.Visible = True
    End Sub

    Private Sub btnSupprimerAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimerAnimal.Click
        DialogSupprAnimal.Visible = True
    End Sub


    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

        If DataGridView1.RowCount > 0 Then

            tbxCodeAnimal.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            tbxNomAnimal.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            Dim sexe As String = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            If sexe = "M" Then
                cbxSexeAnimal.SelectedIndex = 1
            ElseIf sexe = "F" Then
                cbxSexeAnimal.SelectedIndex = 2
            Else
                cbxSexeAnimal.SelectedIndex = 3
            End If
            tbxCouleurAnimal.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            tbxCodeClient.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            tbxTatouageAnimal.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            cbxRaceAnimal.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
            cbxEspeceAnimal.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()

        End If
    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click
        Dim codeAnimal As Guid = New Guid(tbxCodeAnimal.Text)
        Dim nomAnimal As String = tbxNomAnimal.Text
        Dim couleurAnimal As String = tbxCouleurAnimal.Text
        Dim tatouageAnimal As String = tbxTatouageAnimal.Text
        Dim raceAnimal As String = cbxRaceAnimal.SelectedItem.ToString()
        Dim especeAnimal As String = cbxEspeceAnimal.SelectedItem.ToString()
        Dim sexe As Integer = cbxSexeAnimal.SelectedIndex
        Dim sexeAnimal As String
        If sexe = 1 Then
            sexeAnimal = "M"
        ElseIf sexe = 1 Then
            sexeAnimal = "F"
        Else
            sexeAnimal = "H"
        End If

        MgtAnimal.getInstance().modifier(codeAnimal, nomAnimal, couleurAnimal, sexeAnimal, tatouageAnimal, raceAnimal, especeAnimal)
        DialogAjoutAnimal.majDataGridView()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim codeAnimal As Guid = New Guid(tbxCodeAnimal.Text)
        Dim a As Animal = MgtAnimal.getInstance().ObtenirAnimal(codeAnimal)
        tbxNomAnimal.Text = a.NomAnimal
        tbxCouleurAnimal.Text = a.Couleur
        tbxTatouageAnimal.Text = a.Tatouage
        cbxEspeceAnimal.SelectedItem = a.Espece
        cbxRaceAnimal.SelectedItem = a.Race

        Select Case a.Sexe
            Case "M".ToCharArray
                cbxSexeAnimal.SelectedIndex = 1
            Case "F".ToCharArray
                cbxSexeAnimal.SelectedIndex = 2
            Case "H".ToCharArray
                cbxSexeAnimal.SelectedIndex = 3
            Case Else
                cbxSexeAnimal.SelectedIndex = 0
        End Select
    End Sub
End Class