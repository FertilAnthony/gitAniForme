Public Class Race

#Region "Attributs"

    Private _race As String
    Private _espece As String

#End Region

#Region "Propriétés"

    Public Property Race() As String
        Get
            Return _race
        End Get
        Set(ByVal race As String)
            _race = race
        End Set
    End Property

    Public Property Espece() As String
        Get
            Return _espece
        End Get
        Set(ByVal espece As String)
            _espece = espece
        End Set
    End Property

#End Region

#Region "Constructeur"

    Public Sub New(ByVal race As String,
                   ByVal espece As String)

        Me.Race = race
        Me.Espece = espece

    End Sub

#End Region


End Class
