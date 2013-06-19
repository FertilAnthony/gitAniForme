Imports System.ComponentModel
Imports BO
Imports DAL

Public Class MgtBareme

#Region "Déclarations"


    Private _bareme As New BindingList(Of Bareme)
    Private _libelleBareme As New BindingList(Of Bareme)

#End Region

#Region "Pattern de singleton"
    Private Shared _instance As New MgtBareme()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtBareme
        Return _instance
    End Function
#End Region

#Region "Propriétés"

    ReadOnly Property bareme As BindingList(Of Bareme)
        Get
            Return _bareme
        End Get
    End Property

    ReadOnly Property libelleBareme As BindingList(Of Bareme)
        Get
            Return _libelleBareme
        End Get
    End Property

#End Region

    Sub initialiserBareme()
        Dim typeBareme As List(Of Bareme) = SQLBareme.getListeBareme()
        For Each b As Bareme In typeBareme
            _bareme.Add(b)
        Next
    End Sub

End Class
