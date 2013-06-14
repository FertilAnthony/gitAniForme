Public Class Consultation

#Region "Attributs"

    Private _codeConsultation As Guid
    Private _dateConsulation As Date
    Private _codeVeto As Veterinaire
    Private _codeAnimal As Animal
    Private _commentaire As String
    Private _etat As Integer
    Private _numFacture As Facture
    Private _archive As Boolean
#End Region
#Region "Propriétés"
    Public Property codeConsultation() As Guid
        Get
            Return _codeConsultation
        End Get
        Set(ByVal value As Guid)
            _codeConsultation = value
        End Set
    End Property

    Public Property dateConsulation() As Date
        Get
            Return _dateConsulation
        End Get
        Set(ByVal value As Date)
            _dateConsulation = value
        End Set
    End Property


    Public Property codeVeto() As Veterinaire
        Get
            Return _codeVeto
        End Get
        Set(ByVal value As Veterinaire)
            _codeVeto = value
        End Set
    End Property

    Public Property codeAnimal() As Animal
        Get
            Return _codeAnimal
        End Get
        Set(ByVal value As Animal)
            _codeAnimal = value
        End Set
    End Property

    Public Property commentaire() As String
        Get
            Return _commentaire
        End Get
        Set(ByVal value As String)
            _commentaire = value
        End Set
    End Property

    Public Property etat() As Integer
        Get
            Return _etat
        End Get
        Set(ByVal value As Integer)
            _etat = value
        End Set
    End Property

    Public Property numFacture() As Facture
        Get
            Return _numFacture
        End Get
        Set(ByVal value As Facture)
            _numFacture = value
        End Set
    End Property

    Public Property archive() As Boolean
        Get
            Return _archive
        End Get
        Set(ByVal value As Boolean)
            _archive = value
        End Set
    End Property


#End Region

#Region "Constructeur"

    Sub New()

    End Sub

    Sub New(ByVal codeConsultation As Guid,
            ByVal dateConsulation As Date,
            ByVal codeVeto As Veterinaire,
            ByVal codeAnimal As Animal,
            ByVal commentaire As String,
            ByVal etat As Integer,
            ByVal numFacture As Facture,
            ByVal archive As Boolean)
        Me.codeConsultation = codeConsultation
        Me.dateConsulation = dateConsulation
        Me.codeVeto = codeVeto
        Me.codeAnimal = codeAnimal
        Me.commentaire = commentaire
        Me.etat = etat
        Me._numFacture = numFacture
        Me.archive = archive
    End Sub


#End Region

End Class



