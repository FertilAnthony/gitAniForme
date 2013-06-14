Public Class Vaccin

#Region "Attributs"
    Private _CodeVaccin As Guid
    Private _nomVaccin As String
    Private _quantite As Integer
    Private _periodeVal As Integer
    Private _archive As Boolean
#End Region

#Region "Propriétés"

    Public Property codeVaccin() As Guid
        Get
            Return codeVaccin
        End Get
        Private Set(ByVal codeVaccin As Guid)
            _CodeVaccin = codeVaccin
        End Set
    End Property

    Public Property nomVaccin() As String
        Get
            nomVaccin = _nomVaccin
        End Get
        Set(ByVal nomVaccin As String)
            _nomVaccin = nomVaccin
        End Set
    End Property

    Public Property quantite() As Integer
        Get
            Return _quantite
        End Get
        Set(ByVal quantite As Integer)
            _quantite = quantite
        End Set
    End Property

    Public Property periodeVal() As Integer
        Get
            Return _periodeVal
        End Get
        Set(ByVal periodeVal As Integer)
            _periodeVal = periodeVal
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

#Region "Constructeurs"
    Public Sub New(ByVal nomVaccin As String, ByVal quantite As Integer, ByVal periodeVal As Integer, ByVal archive As Boolean)
        Me.codeVaccin = New Guid()
        Me.nomVaccin = nomVaccin
        Me.quantite = quantite
        Me.periodeVal = periodeVal
        Me.archive = archive
    End Sub

#End Region

#Region "Méthodes d'instance"
    Public Overrides Function ToString() As String
        Return nomVaccin
    End Function
#End Region

#Region "Méthodes de classe"
    'Shared Sub verifSalaire(ByVal salaire As Decimal)
    '    If salaire < 0 Then
    '        Throw New Exception("Le salaire doit être positif")
    '    End If
    'End Sub
#End Region

End Class
