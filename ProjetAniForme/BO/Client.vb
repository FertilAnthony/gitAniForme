Public Class Client

#Region "Attributs"
    Private _codeClient As Guid
    Private _nomClient As String
    Private _prenomClient As String
    Private _adresse1 As String
    Private _adresse2 As String
    Private _codePostal As String
    Private _ville As String
    Private _numTel As String
    Private _assurance As String
    Private _email As String
    Private _remarque As String
    Private _archive As Boolean
#End Region

#Region "Propriétés"

    Public Property CodeClient() As Guid
        Get
            Return _codeClient
        End Get
        Private Set(ByVal codeClient As Guid)
            _codeClient = codeClient
        End Set
    End Property

    Public Property NomClient() As String
        Get
            Return _nomClient
        End Get
        Set(ByVal nom As String)
            _nomClient = nom
        End Set
    End Property

    Public Property PrenomClient() As String
        Get
            Return _prenomClient
        End Get
        Set(ByVal prenom As String)
            _prenomClient = prenom
        End Set
    End Property

    Public Property Adresse1() As String
        Get
            Return _adresse1
        End Get
        Set(ByVal adresse1 As String)
            _adresse1 = adresse1
        End Set
    End Property

    Public Property Adresse2() As String
        Get
            Return _adresse2
        End Get
        Set(ByVal adresse2 As String)
            _adresse2 = adresse2
        End Set
    End Property

    Public Property CodePostal() As String
        Get
            Return _codePostal
        End Get
        Set(ByVal codePostal As String)
            _codePostal = codePostal
        End Set
    End Property

    Public Property Ville() As String
        Get
            Return _ville
        End Get
        Set(ByVal ville As String)
            _ville = ville
        End Set
    End Property

    Public Property NumTel() As String
        Get
            Return _numTel
        End Get
        Set(ByVal numTel As String)
            _numTel = numTel
        End Set
    End Property

    Public Property Assurance() As String
        Get
            Return _assurance
        End Get
        Set(ByVal assurance As String)
            _assurance = assurance
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal email As String)
            _email = email
        End Set
    End Property

    Public Property Remarque() As String
        Get
            Return _remarque
        End Get
        Set(ByVal remarque As String)
            _remarque = remarque
        End Set
    End Property

    Public Property Archive() As Boolean
        Get
            Return _archive
        End Get
        Set(ByVal archive As Boolean)
            _archive = archive
        End Set
    End Property

#End Region

#Region "Constructeurs"
    Public Sub New(ByVal codeClient As Guid,
                   ByVal nomClient As String,
                   ByVal prenomClient As String,
                   ByVal adresse1 As String,
                   ByVal adresse2 As String,
                   ByVal codePostal As String,
                   ByVal ville As String,
                   ByVal assurance As String,
                   ByVal email As String,
                   ByVal archive As Boolean,
                   Optional ByVal remarque As String = Nothing)

        Me.CodeClient = codeClient
        Me.NomClient = nomClient
        Me.PrenomClient = prenomClient
        Me.Adresse1 = adresse1
        Me.Adresse2 = adresse2
        Me.CodePostal = codePostal
        Me.Ville = ville
        Me.Assurance = assurance
        Me.Email = email
        Me.Archive = archive
        Me.Remarque = remarque

    End Sub

#End Region

End Class
