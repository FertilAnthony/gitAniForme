
Public Class Facture

#Region "Attributs"

    Private _numFacture As Guid
    Private _dateFacture As Date
    Private _codeClient As Client
    Private _totalFacture As Decimal
    Private _archive As Boolean
    Private _etat As Integer
    Private _rappelEnvoye As Date

#End Region

#Region "Propriétés"

    Public Overloads Property numFacture() As Guid
        Get
            Return _numFacture
        End Get
        Set(ByVal value As Guid)
            _numFacture = numFacture
        End Set
    End Property

    Public Property dateFacture() As Date
        Get
            Return _dateFacture
        End Get
        Set(ByVal value As Date)
            _dateFacture = value
        End Set
    End Property

    Public Property codeClient() As Client
        Get
            Return _codeClient
        End Get
        Set(ByVal value As Client)
            _codeClient = value
        End Set
    End Property

    Public Property totalFacture() As Decimal
        Get
            Return _totalFacture
        End Get
        Set(ByVal value As Decimal)
            _totalFacture = value
        End Set
    End Property

    Public Overloads Property archive() As Boolean
        Get
            Return _archive
        End Get
        Set(ByVal value As Boolean)
            _archive = value
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

    Public Property rappelEnvoye() As Date
        Get
            Return _rappelEnvoye
        End Get
        Set(ByVal value As Date)
            _rappelEnvoye = value
        End Set
    End Property

#End Region

#Region "Constructeurs"

    Sub New()

    End Sub

    Sub New(ByVal dateFacture As Date,
            ByVal codeClient As Client, ByVal totalFacture As Decimal,
            ByVal archive As Boolean, ByVal etat As Integer, ByVal rappelEnvoye As Date)
        Me.numFacture = New Guid()
        Me.dateFacture = dateFacture
        Me.codeClient = codeClient
        Me.totalFacture = totalFacture
        Me.archive = archive
        Me.etat = etat
        Me.rappelEnvoye = rappelEnvoye
    End Sub

#End Region

End Class
