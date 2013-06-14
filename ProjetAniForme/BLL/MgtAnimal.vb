Imports BO
Imports DAL
Imports System.ComponentModel

Public Class MgtAnimal

    Private _listAnimaux As New BindingList(Of Animal)

#Region "Pattern de singleton"
    Private Shared _instance As New MgtAnimal()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtAnimal
        Return _instance
    End Function
#End Region

#Region "Propriétés"
    ReadOnly Property animaux As BindingList(Of Animal)
        Get
            Return _listAnimaux
        End Get
    End Property
#End Region

    Sub initialiserDonnees()
        Dim listAnimaux As List(Of Animal) = SQLAnimal.getListeAnimaux()
        For Each a As Animal In listAnimaux
            _listAnimaux.Add(a)
        Next
    End Sub

End Class
