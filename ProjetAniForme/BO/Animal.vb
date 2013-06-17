Public Class Animal
    Inherits Race

#Region "Attributs"

    Private _codeAnimal As Guid
    Private _nomAnimal As String
    Private _sexe As Char
    Private _couleur As String
    Private _race As Race
    Private _espece As String
    Private _codeClient As Guid
    Private _tatouage As String
    Private _antecedents As String
    Private _archive As Boolean

#End Region

#Region "Propriétés"

    Public Property CodeAnimal() As Guid
        Get
            Return _codeAnimal
        End Get
        Set(ByVal codeAnimal As Guid)
            _codeAnimal = codeAnimal
        End Set
    End Property

    Public Property NomAnimal() As String
        Get
            Return _nomAnimal
        End Get
        Set(ByVal nomAnimal As String)
            _nomAnimal = nomAnimal
        End Set
    End Property

    Public Property Sexe() As Char
        Get
            Return _sexe
        End Get
        Set(ByVal sexe As Char)
            'verifSexe(sexe)
            _sexe = sexe
        End Set
    End Property

    Public Property Couleur() As String
        Get
            Return _couleur
        End Get
        Set(ByVal couleur As String)
            _couleur = couleur
        End Set
    End Property

    Public Property CodeClient() As Guid
        Get
            Return _codeClient
        End Get
        Set(ByVal codeClient As Guid)
            _codeClient = codeClient
        End Set
    End Property

    Public Property Tatouage() As String
        Get
            Return _tatouage
        End Get
        Set(ByVal tatouage As String)
            If String.IsNullOrEmpty(tatouage) Then
                _tatouage = ""
            Else
                _tatouage = tatouage
            End If
        End Set
    End Property

    Public Property Antecedents() As String
        Get
            Return _antecedents
        End Get
        Set(ByVal antecedents As String)
            If String.IsNullOrEmpty(antecedents) Then
                _antecedents = ""
            Else
                _antecedents = antecedents
            End If
        End Set
    End Property

    Public Property archive() As Boolean
        Get
            Return _archive
        End Get
        Set(ByVal archive As Boolean)
            _archive = archive
        End Set
    End Property

#End Region

#Region "Contrôles"

    Shared Sub verifSexe(ByVal sexe As Char)

        If sexe <> "M" Or sexe <> "F" Or sexe <> "H" Then
            Throw New ApplicationException("Il y a une erreur pour le sexe de votre animal : M, F ou H")
        End If
    End Sub

#End Region

#Region "Constructeur"

    Public Sub New(ByVal codeAnimal As Guid,
                   ByVal nomAnimal As String,
                   ByVal sexe As Char,
                   ByVal couleur As String,
                   ByVal race As String,
                   ByVal espece As String,
                   ByVal codeClient As Guid,
                   ByVal tatouage As String,
                   ByVal archive As Boolean,
                   Optional ByVal antecedents As String = Nothing)

        MyBase.New(race, espece)
        Me.CodeAnimal = codeAnimal
        Me.NomAnimal = nomAnimal
        Me.Sexe = sexe
        Me.Couleur = couleur
        Me.CodeClient = codeClient
        Me.Tatouage = tatouage
        Me.archive = archive
        Me.Antecedents = antecedents

    End Sub

    Public Sub New(ByVal codeAnimal As Guid,
                   ByVal nomAnimal As String,
                   ByVal race As String,
                   ByVal espece As String,
                   ByVal codeClient As Guid)

        MyBase.New(race, espece)
        Me.CodeAnimal = codeAnimal
        Me.NomAnimal = nomAnimal
        Me.CodeClient = codeClient
    End Sub

#End Region

#Region "Méthodes d'instance"
    Public Overrides Function ToString() As String
        Return NomAnimal & " - " & Race & " - " & Espece
    End Function
#End Region

#Region "Méthodes de classe"
    Shared Sub verifCode(ByVal codeAnimal As Guid)
        If codeAnimal = Nothing Then
            Throw New Exception("L'identifiant ne doit pas être vide")
        End If
    End Sub

#End Region

End Class
