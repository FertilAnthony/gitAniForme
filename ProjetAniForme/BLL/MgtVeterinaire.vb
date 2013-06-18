Imports BO
Imports DAL
Imports System.ComponentModel

Public Class MgtVeterinaire

    Private _listeVeterinaires As New BindingList(Of Veterinaire)
    Private _lstRdv As New BindingList(Of Agendas)
    Private _lstRdvVeto As New BindingList(Of Agendas)

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

    ReadOnly Property rdv As BindingList(Of Agendas)
        Get
            Return _lstRdv
        End Get
    End Property

    ReadOnly Property lstRdvVeto As BindingList(Of Agendas)
        Get
            Return _lstRdvVeto
        End Get
    End Property

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

    Public Function ObtenirVeterinaire(ByVal nomVeto As String) As Veterinaire
        Dim retourVeterinaire As Veterinaire = Nothing
        '
        ' Vérifier que le nom proposé est un nom de Veterinaire valide
        '
        Veterinaire.verifNom(nomVeto)
        '
        ' Pas d'erreur, on recherche dans la liste le veterinaire possédant 
        ' ce nom. S'il n'est pas trouvé la variable reste Nothing.
        '
        retourVeterinaire = _listeVeterinaires.ToList.Find(Function(v As Veterinaire) v.NomVeto.Equals(nomVeto))

        Return retourVeterinaire
    End Function

    Sub rechercheRdvVeto(ByVal codeVeto As Guid)
        Dim lstRdvVeto As List(Of Agendas) = SQLAgendas.getLstRdvVeto(codeVeto)
        _lstRdvVeto.Clear()
        For Each a As Agendas In lstRdvVeto
            _lstRdvVeto.Add(a)

        Next
    End Sub
    Sub rechercheRdv()
        Dim lstRdv As List(Of Agendas) = SQLAgendas.getLstRdv()

        For Each a As Agendas In lstRdv
            _lstRdv.Add(a)

        Next
    End Sub
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
