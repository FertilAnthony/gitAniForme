Imports BO
Imports DAL
Imports System.ComponentModel

Public Class MgtClient

    Private _listeClients As New BindingList(Of Client)

#Region "Pattern de singleton"
    Private Shared _instance As New MgtClient()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtClient
        Return _instance
    End Function
#End Region

#Region "Propriétés"
    ReadOnly Property clients As BindingList(Of Client)
        Get
            Return _listeClients
        End Get
    End Property
#End Region

    Sub initialiserDonnees()
        Dim listClients As List(Of Client) = SqlClient.getListeClient()
        For Each c As Client In listClients
            _listeClients.Add(c)
        Next
    End Sub

End Class
