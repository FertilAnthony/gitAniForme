Imports BO
Imports DAL
Imports System.ComponentModel

Public Class MgtAnimal

    Private _listAnimaux As New BindingList(Of Animal)
    Private _listAnimauxClient As New BindingList(Of Animal)
    Private _race As New BindingList(Of Race)

#Region "Pattern de singleton"
    Private Shared _instance As New MgtAnimal()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtAnimal
        Return _instance
    End Function
#End Region

#Region "Propriétés"
    ReadOnly Property animaux As BindingList(Of Animal)
        Get
            Return _listAnimaux
        End Get
    End Property

    ReadOnly Property animauxClient As BindingList(Of Animal)
        Get
            Return _listAnimauxClient
        End Get
    End Property

    ReadOnly Property raceAnimaux As BindingList(Of Race)
        Get
            Return _race
        End Get
    End Property
#End Region

    Sub initialiserDonnees()
        Dim listAnimaux As List(Of Animal) = SQLAnimal.getListeAnimaux()
        For Each a As Animal In listAnimaux
            _listAnimaux.Add(a)
        Next
    End Sub

    Sub rechercheAnimauxClient(ByVal codeClient As Guid)
        Dim listAnimauxClient As List(Of Animal) = SQLAnimal.getListeAnimauxClient(codeClient)
        _listAnimauxClient.Clear()
        For Each a As Animal In listAnimauxClient
            _listAnimauxClient.Add(a)
        Next
    End Sub

    Sub getAllraceAnimaux()
        Dim raceAnimaux As List(Of Race) = SQLAnimal.getRaceAnimal()
        For Each r As Race In raceAnimaux
            _race.Add(r)
        Next
    End Sub

    Public Function ObtenirAnimal(ByVal codeAnimal As Guid) As Animal
        Dim retourAnimal As Animal = Nothing
        '
        ' Vérifier que le code proposé est un code d'animal valide
        '
        Animal.verifCode(codeAnimal)
        '
        ' Pas d'erreur, on recherche dans la liste l'animal possédant 
        ' ce code. S'il n'est pas trouvé la variable reste Nothing.
        '
        retourAnimal = _listAnimaux.ToList.Find(Function(a As Animal) a.CodeAnimal.Equals(codeAnimal))

        Return retourAnimal
    End Function

    Sub ajout(ByVal a As Animal)
        SQLAnimal.ajouterAnimal(a)
        animaux.Add(a)
    End Sub

    Sub supprimer(ByVal a As Animal)
        SQLAnimal.supprimer(a)
        animaux.Remove(a)
    End Sub

    Sub modifier(ByVal codeAnimal As Guid, ByVal nomAnimal As String, ByVal couleurAnimal As String, ByVal sexeAnimal As String, ByVal tatouageAnimal As String, ByVal raceAnimal As String, ByVal especeAnimal As String)
        Dim a As Animal = ObtenirAnimal(codeAnimal)

        If _listAnimaux.Contains(a) Then
            Dim oldNomAnimal As String = nomAnimal
            Dim oldCouleur As String = couleurAnimal
            Dim oldSexe As String = sexeAnimal
            Dim oldTatouage As String = tatouageAnimal
            Dim oldRace As String = raceAnimal
            Dim oldEspece As String = especeAnimal
            Try
                a.NomAnimal = nomAnimal
                a.Couleur = couleurAnimal
                a.Sexe = CChar(sexeAnimal)
                a.Tatouage = tatouageAnimal
                a.Race = raceAnimal
                a.Espece = especeAnimal
                SQLAnimal.modifier(a)
            Catch ex As Exception
                With a
                    .NomAnimal = oldNomAnimal
                    .Couleur = oldCouleur
                    .Sexe = CChar(oldSexe)
                    .Tatouage = oldTatouage
                    .Race = oldRace
                    .Espece = oldEspece
                    Throw New ApplicationException(ex.Message)
                End With
            End Try
        Else
            Throw New ApplicationException("L'instance à modifier n'appartient pas à la liste courante de l'application.")
        End If
    End Sub

End Class
