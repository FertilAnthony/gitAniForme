Public Class Bareme
#Region "Attributs"
    Private _codeGrp As String
    Private _dateVigueur As Date
    Private _typeActe As String
    Private _libelle As String
    Private _tarifFixe As Decimal
    Private _tarifMini As Decimal
    Private _tarifMaxi As Decimal
    Private _codeVaccin As Vaccin
    Private _archive As Boolean
#End Region

#Region "Propriétés"

    Public Property codeGrp() As String
        Get
            Return _codeGrp
        End Get
        Set(ByVal codeGrp As String)
            _codeGrp = codeGrp
        End Set
    End Property

    Public Property dateVigueur() As Date
        Get
            Return _dateVigueur
        End Get
        Set(ByVal value As Date)
            _dateVigueur = value
        End Set
    End Property

    Public Property typeActe() As String
        Get
            Return _typeActe
        End Get
        Set(ByVal value As String)
            _typeActe = value
        End Set
    End Property

    Public Property libelle() As String
        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            _libelle = value
        End Set
    End Property

    Public Property tarifFixe() As Decimal
        Get
            Return _tarifFixe
        End Get
        Set(ByVal value As Decimal)
            _tarifFixe = value
        End Set
    End Property

    Public Property tarifMini() As Decimal
        Get
            Return _tarifMini
        End Get
        Set(ByVal value As Decimal)
            _tarifMini = value
        End Set
    End Property

    Public Property tarifMaxi() As Decimal
        Get
            Return _tarifMaxi
        End Get
        Set(ByVal value As Decimal)
            _tarifMaxi = value
        End Set
    End Property

    Public Property codeVaccin() As Vaccin
        Get
            Return _codeVaccin
        End Get
        Set(ByVal value As Vaccin)
            _codeVaccin = value
        End Set
    End Property

    Public Property Archive() As Boolean
        Get
            Return _Archive
        End Get
        Set(ByVal value As Boolean)
            _Archive = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Sub New()

    End Sub

    Sub New(ByVal codeGrp As String, ByVal dateVigueur As Date, ByVal typeActe As String,
            ByVal libelle As String, ByVal tarifFixe As Decimal, ByVal tarifMini As Decimal,
            ByVal tarifMaxi As Decimal, ByVal codeVaccin As Vaccin, ByVal archive As Boolean)

        Me.codeGrp = codeGrp
        Me.dateVigueur = dateVigueur
        Me.typeActe = typeActe
        Me.libelle = libelle
        Me.tarifFixe = tarifFixe
        Me.tarifMini = tarifMini
        Me.tarifMaxi = tarifMaxi
        Me.codeVaccin = codeVaccin
        Me.Archive = archive
    End Sub

#End Region

End Class
