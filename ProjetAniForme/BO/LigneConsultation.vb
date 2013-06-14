Public Class ligneConsultation

#Region "Attributs"
    Private _codeConsultation As Consultation
    Private _numLigne As Guid
    Private _codeGroupement As bareme
    Private _dateVigueur As bareme
    Private _prix As Decimal
    Private _rappelEnvoye As Boolean
    Private _archive As Boolean
#End Region

#Region "Propriétés"

    Public Property codeConsultation() As Consultation
        Get
            Return _codeConsultation
        End Get
        Set(ByVal value As Consultation)
            _codeConsultation = value
        End Set
    End Property

    Public Property numLigne() As Guid
        Get
            Return _numLigne
        End Get
        Set(ByVal value As Guid)
            _numLigne = value
        End Set
    End Property

    Public Property codeGroupement() As bareme
        Get
            Return _codeGroupement
        End Get
        Set(ByVal value As bareme)
            _codeGroupement = value
        End Set
    End Property

    Public Property dateVigueur() As bareme
        Get
            Return _dateVigueur
        End Get
        Set(ByVal value As bareme)
            _dateVigueur = value
        End Set
    End Property

    Public Property prix() As Decimal
        Get
            Return _prix
        End Get
        Set(ByVal value As Decimal)
            _prix = value
        End Set
    End Property

    Public Property rappelEnvoye() As Boolean
        Get
            Return _rappelEnvoye
        End Get
        Set(ByVal value As Boolean)
            _rappelEnvoye = value
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

#Region "Constructeurs"

    Sub New()

    End Sub

    Sub New(ByVal codeConsultation As Consultation, ByVal numLigne As Guid,
            ByVal codeGroupement As bareme, ByVal dateVigueur As bareme,
            ByVal prix As Decimal, ByVal rappelEnvoye As Boolean, ByVal archive As Boolean)

        Me.codeConsultation = codeConsultation
        Me.numLigne = numLigne
        Me.codeGroupement = codeGroupement
        Me.dateVigueur = dateVigueur
        Me.prix = prix
        Me.rappelEnvoye = rappelEnvoye
        Me.archive = archive
    End Sub


#End Region

End Class
