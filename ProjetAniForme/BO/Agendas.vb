Public Class Agendas

#Region "Attributs"

    Private _codeVeto As Guid
    Private _dateRdv As Date
    Private _codeAnimal As Guid

#End Region

#Region "Propriétés"

    Public Property CodeVeto() As Guid
        Get
            Return _codeVeto
        End Get
        Set(ByVal codeVeto As Guid)
            _codeVeto = codeVeto
        End Set
    End Property

    Public Property DateRdv() As Date
        Get
            Return _dateRdv
        End Get
        Set(ByVal dateRdv As Date)
            _dateRdv = dateRdv
        End Set
    End Property

    Public Property CodeAnimal() As Guid
        Get
            Return _codeAnimal
        End Get
        Set(ByVal codeAnimal As Guid)

            _codeAnimal = codeAnimal
        End Set
    End Property

#End Region

#Region "Constructeur"

    Public Sub New(ByVal codeVeto As Guid,
                   ByVal dateRdv As Date,
                   ByVal codeAnimal As Guid)


        Me.CodeVeto = codeVeto
        Me.DateRdv = dateRdv
        Me.CodeAnimal = codeAnimal


    End Sub

#End Region
End Class
