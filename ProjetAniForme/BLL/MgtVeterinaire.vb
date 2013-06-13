Imports BO
Imports DAL
Imports System.ComponentModel

Public Class MgtVeterinaire

    Private _listeVeterinaires As New BindingList(Of Veterinaire)

#Region "Pattern de singleton"
    Private Shared _instance As New MgtVeterinaire()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtVeterinaire
        Return _instance
    End Function
#End Region

#Region "Propriétés"
    ReadOnly Property veterinaires As BindingList(Of Veterinaire)
        Get
            Return _listeVeterinaires
        End Get
    End Property
#End Region

    Public Sub TestConnexion(ByVal veterinaire As Veterinaire, ByVal motDePasse As String)
        Dim identifiant As Guid = veterinaire.CodeVeto
        BO.Veterinaire.verifIdentifiant(identifiant)
        BO.Veterinaire.verifMdp(motDePasse)
        SQLVeterinaire.TestConnexion(identifiant, motDePasse)

    End Sub


    Public Function ObtenirVeterinaire(ByVal codeVeto As Guid) As Veterinaire
        Dim retourVeterinaire As Veterinaire = Nothing
        '
        ' Vérifier que le code proposé est un code de Veterinaire valide
        '
        Veterinaire.verifIdentifiant(codeVeto)
        '
        ' Pas d'erreur, on recherche dans la liste le service possédant 
        ' ce code. S'il n'est pas trouvé la variable reste Nothing.
        '
        retourVeterinaire = _listeVeterinaires.ToList.Find(Function(v As Veterinaire) v.CodeVeto.Equals(codeVeto))

        Return retourVeterinaire
    End Function

    Sub initialiserDonnees()
        Dim listVeterinaire As List(Of Veterinaire) = SQLVeterinaire.getListeVeterinaire()
        For Each v As Veterinaire In listVeterinaire
            _listeVeterinaires.Add(v)
        Next
    End Sub

    Sub ajout(ByVal nomVeto As String, ByVal mdpVeto As String)
        ajout(New Veterinaire(Guid.NewGuid(), nomVeto, mdpVeto))
    End Sub

    Private Sub ajout(ByVal veto As Veterinaire)
        SQLVeterinaire.ajouter(veto)
        veterinaires.Add(veto)
    End Sub

    Sub supprimer(ByVal veto As Veterinaire)
        SQLVeterinaire.supprimer(veto)
        veterinaires.Remove(veto)
    End Sub

    Sub modif(ByVal codeVeto As Guid, ByVal nomVeto As String, ByVal mdpVeto As String)
        Dim veto As Veterinaire = ObtenirVeterinaire(codeVeto)

        If _listeVeterinaires.Contains(veto) Then
            Dim oldNomVeto As String = nomVeto
            Dim oldMdpVeto As String = mdpVeto
            Try
                veto.NomVeto = nomVeto
                veto.MotPasse = mdpVeto
                SQLVeterinaire.modifier(veto)
            Catch ex As Exception
                With veto
                    .NomVeto = oldNomVeto
                    .MotPasse = oldMdpVeto
                End With
            End Try
        Else
            Throw New ApplicationException("L'instance à modifier n'appartient pas à la liste courante de l'application.")
        End If
    End Sub

End Class
