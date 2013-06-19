Imports BO
Imports BLL

Public Class EcranConsultation

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub EcranRelances_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Chargement données de l'animal + vétérinaire
        Dim codeAnimal As Guid = New Guid(EcranAgendas.DataGridViewAgendas.CurrentRow.Cells.Item("codeAnimal").Value.ToString)
        Dim a As Animal = MgtAnimal.getInstance().ObtenirAnimal(codeAnimal)

        Me.tbxCodeAnimal.Text = a.CodeAnimal.ToString
        Me.tbxCouleurAnimal.Text = a.Couleur
        Me.tbxEspeceAnimal.Text = a.Espece
        Me.tbxNomAnimal.Text = a.NomAnimal
        Me.tbxRaceAnimal.Text = a.Race
        Me.tbxTatouageAnimal.Text = a.Tatouage
        Me.tbxVeterinaire.Text = "veto connecté"
        Dim sexe As Char = a.Sexe

        If sexe = "M" Then
            Me.tbxSexeAnimal.Text = "Mâle - (M)"
        ElseIf sexe = "F" Then
            Me.tbxSexeAnimal.Text = "Femelle - (F)"
        Else
            Me.tbxSexeAnimal.Text = "Hermaphrodite - (H)"
        End If

        'Chargement listes déroulantes acte
        Dim typeBareme As New List(Of String)
        For Each bareme As Bareme In MgtBareme.getInstance.bareme
            Dim typeActe As String = bareme.typeActe
            Dim unique As String = typeBareme.Find(Function(b As String) b = typeActe)
            If unique = Nothing Then
                typeBareme.Add(typeActe)
            End If
        Next
        cbxTypeActe.DataSource = typeBareme

        Me.Visible = True
        Me.BringToFront()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Visible = False
    End Sub

    Private Sub cbxTypeActe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTypeActe.SelectedIndexChanged
        Dim libelleBareme As New List(Of Bareme)

        For Each b As Bareme In MgtBareme.getInstance.bareme
            Dim typeActe As String = cbxTypeActe.Text
            If b.typeActe = typeActe Then
                libelleBareme.Add(b)
            End If
        Next
        cbxLibelleActe.DataSource = libelleBareme
        cbxLibelleActe.DisplayMember = "Libelle" 'affiche le libelle dans la comboBox
    End Sub
End Class