Public Class Veterinaire

#Region "Attributs"

    Private _codeVeto As Guid
    Private _nomVeto As String
    Private _motPasse As String
    Private _archive As Boolean

#End Region

#Region "Propriétés"

    Public Property CodeVeto() As Guid
        Get
            Return _codeVeto
        End Get
        Set(ByVal codeVeto As Guid)
            verifIdentifiant(codeVeto)
            _codeVeto = codeVeto
        End Set
    End Property

    Public Property NomVeto() As String
        Get
            Return _nomVeto
        End Get
        Set(ByVal nomVeto As String)
            verifNom(nomVeto)
            _nomVeto = nomVeto
        End Set
    End Property

    Public Property MotPasse() As String
        Get
            Return _motPasse
        End Get
        Set(ByVal motPasse As String)
            verifMdp(motPasse)
            _motPasse = motPasse
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

    Public Sub New(ByVal codeVeto As Guid,
                   ByVal nomVeto As String,
                   ByVal motPasse As String,
                   Optional ByVal archive As Boolean = False)

        Me.CodeVeto = codeVeto
        Me.NomVeto = nomVeto
        Me.MotPasse = motPasse
        Me.Archive = archive

    End Sub

    Public Sub New(ByVal codeVeto As Guid,
                   ByVal nomVeto As String)
        Me.CodeVeto = codeVeto
        Me.NomVeto = nomVeto
    End Sub

#End Region

#Region "Méthodes d'instance"
    Public Overrides Function ToString() As String
        Return NomVeto
    End Function
#End Region

#Region "Méthodes de classe"
    Shared Sub verifIdentifiant(ByVal identifiant As Guid)
        If identifiant = Nothing Then
            Throw New Exception("L'identifiant ne doit pas être vide")
        End If
    End Sub

    Shared Sub verifNom(ByVal nom As String)
        If nom = Nothing Then
            Throw New Exception("Le nom ne doit pas être vide")
        ElseIf nom.Trim().Length > 30 Then
            Throw New Exception("Le nom ne doit pas êdépasser 30 caractères")
        End If
    End Sub

    Shared Sub verifMdp(ByVal mdp As String)
        If mdp Is Nothing OrElse mdp.Trim().Length = 0 Then
            Throw New Exception("Le mot de passe ne doit pas être vide")
        ElseIf mdp.Trim().Length > 10 Then
            Throw New Exception("Le mot de passe ne peut dépasser 10 caractères")
        End If
    End Sub
#End Region

End Class
