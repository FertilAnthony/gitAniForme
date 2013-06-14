Public Class LigneFacture

#Region "Attributs"
    Private _numFacture As Facture
    Private _numLigne As Guid
    Private _codeGroupement As String
    Private _prix As Decimal
    Private _archive As Boolean
#End Region

#Region "Propriétés"
    Public Property numFacture() As Facture
        Get
            Return _numFacture
        End Get
        Set(ByVal NumFacture As Facture)
            _numFacture = NumFacture
        End Set
    End Property

    Public Property numLigne() As Guid
        Get
            Return _numLigne
        End Get
        Set(ByVal NumLigne As Guid)
            _numLigne = NumLigne
        End Set
    End Property

    Public Property codeGroupement() As String
        Get
            Return _codeGroupement
        End Get
        Set(ByVal value As String)
            _codeGroupement = value
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

    Sub New(ByVal numFacture As Facture, ByVal numLigne As Guid, ByVal codeGroupement As String, ByVal prix As Decimal, ByVal archive As Boolean)
        Me.numFacture = numFacture
        Me.numLigne = numLigne
        Me.codeGroupement = codeGroupement
        Me.prix = prix
        Me.archive = archive
    End Sub
#End Region

End Class
