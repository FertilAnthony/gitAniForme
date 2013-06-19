Imports BO
Imports DAL
Imports System.ComponentModel

Public Class MgtClient

    Private _listeClients As New BindingList(Of Client)

#Region "Pattern de singleton"
    Private Shared _instance As New MgtClient()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtClient
        Return _instance
    End Function
#End Region

#Region "Propriétés"
    ReadOnly Property clients As BindingList(Of Client)
        Get
            Return _listeClients
        End Get
    End Property
#End Region

    Sub initialiserDonnees()
        Dim listClients As List(Of Client) = SqlClient.getListeClient()
        For Each c As Client In listClients
            _listeClients.Add(c)
        Next
    End Sub

    Public Function ObtenirClient(ByVal nomClient As String) As Client
        Dim retourClient As Client = Nothing

        Client.verifNom(nomClient)

        retourClient = _listeClients.ToList.Find(Function(c As Client) c.NomClient.ToUpper().Equals(nomClient.ToUpper()))

        Return retourClient
    End Function

    Public Function ObtenirClient(ByVal codeClient As Guid) As Client
        Dim retourClient As Client = Nothing
        'nécessite verif code
        retourClient = _listeClients.ToList.Find(Function(c As Client) c.CodeClient.Equals(codeClient))

        Return retourClient
    End Function


    Public Sub ajouterClient(ByVal nomClient As String, ByVal prenomClient As String, ByVal adresse1 As String, ByVal adresse2 As String, ByVal codePostal As String, ByVal ville As String, ByVal numTel As String, ByVal assurance As String, ByVal email As String, ByVal archive As Boolean)

        'Créer l'instance de client
        '
        Dim c As Client = New Client(Guid.NewGuid(), nomClient, prenomClient, adresse1, adresse2, codePostal, ville, numTel, assurance, email, archive)
        '
        ' Ajouter l'instance créée à la liste
        '
        ajouterClient(c)
    End Sub

    Private Sub ajouterClient(ByVal c As Client)
        _listeClients.Add(c)
        DAL.SQLClient.ajouterClient(c)
    End Sub

    Sub supprimerClient(ByVal c As Client)

        If _listeClients.Contains(c) Then
            _listeClients.Remove(c)
            DAL.SQLClient.supprimerClient(c)


        Else

            Throw New ApplicationException("L'instance à supprimer n'appartient pas à la liste courante de l'application.")
        End If
    End Sub

    Sub supprimerClient(ByVal nomClient As String)

        Dim c As Client = ObtenirClient(nomClient)
        If c IsNot Nothing Then
            supprimerClient(c)
        Else
            Throw New ApplicationException(String.Format("Aucun client avec le nom {0} n'existe dans la liste courante de l'application.", nomClient))
        End If
    End Sub

    Sub modifierClient(ByVal nomClient As String)
        Dim c As Client = ObtenirClient(nomClient)
        If c IsNot Nothing Then
            modifierClient(c)
        Else
            Throw New ApplicationException(String.Format("Aucun client avec le nom {0} n'existe dans la liste courante de l'application.", nomClient))
        End If
    End Sub

    Sub modifierClient(ByVal c As Client)
        Try

            DAL.SQLClient.modifierClient(c)
        Catch

            Throw New ApplicationException("ERREUR.")
        End Try
    End Sub

    'Sub modifierClient(ByVal nomClient As String, ByVal prenomClient As String, ByVal adresse1 As String, ByVal adresse2 As String, ByVal codePostal As String, ByVal ville As String, ByVal numTel As String, ByVal assurance As String, ByVal email As String, ByVal archive As Boolean)
    '    Dim client As Client = ObtenirClient(nomClient)

    '    Dim c As Client = New Client(client.CodeClient, nomClient, prenomClient, adresse1, adresse2, codePostal, ville, numTel, assurance, email, archive)
    '    '
    '    ' Ajouter l'instance créée à la liste
    '    '
    '    modifierClient(c)
    'End Sub

    Public Sub modifierClient(ByVal nomClient As String, ByVal prenomClient As String, ByVal adresse1 As String, ByVal adresse2 As String, ByVal codePostal As String, ByVal ville As String, ByVal numTel As String, ByVal assurance As String, ByVal email As String, ByVal archive As Boolean)
        '
        ' Vérifier que l'instance de Service est bien dans la liste.
        ' Succés : Modifier ses propriétés avec les valeurs passées en argument
        ' Echec : Levée d'une exception.
        Dim c As Client = ObtenirClient(nomClient)


        If _listeClients.Contains(c) Then
            '
            ' Sauvegerder l'ancienne valeur temporairement.
            '
            Dim oldCode As String = c.CodeClient.ToString
            Try
                c.NomClient = nomClient
                c.PrenomClient = prenomClient
                c.Adresse1 = adresse1
                c.CodePostal = codePostal
                c.Ville = ville
                c.NumTel = numTel
                c.Assurance = assurance
                c.Archive = archive

                DAL.SQLClient.modifierClient(c)

            Catch

            End Try
        Else
            Throw New ApplicationException("L'instance à modifier n'appartient pas à la liste courante de l'application.")
        End If
    End Sub
End Class
