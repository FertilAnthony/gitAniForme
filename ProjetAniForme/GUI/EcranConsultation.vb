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
        'cbxLibelleActe.DataSource = mgt

        Me.Visible = True
        Me.BringToFront()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Visible = False
    End Sub
End Class