Imports System.ComponentModel
Imports BO
Imports DAL

Public Class MgtVaccin
#Region "Déclarations"
    Private _listeVaccins As New BindingList(Of Vaccin)
#End Region

#Region "Pattern de singleton"
    Private Shared _instance As New MgtVaccin()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtVaccin
        Return _instance
    End Function
#End Region

#Region "Propriétés"
    ReadOnly Property vaccins As BindingList(Of Vaccin)
        Get
            Return _listeVaccins
        End Get
    End Property

    Sub initialiser()
        Dim listeVaccin As List(Of Vaccin) = SQLVaccin.getLstVaccin()

        For Each v As Vaccin In vaccins
            _listeVaccins.Add(v)

        Next
    End Sub
#End Region

End Class
