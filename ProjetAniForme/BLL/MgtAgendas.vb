Imports System.ComponentModel
Imports BO
Imports DAL

Public Class MgtAgendas

#Region "Déclarations"


    Private _lstRdv As New BindingList(Of Agendas)
    Private _lstRdvVeto As New BindingList(Of Agendas)

#End Region

#Region "Pattern de singleton"
    Private Shared _instance As New MgtAgendas()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtAgendas
        Return _instance
    End Function
#End Region

#Region "Propriétés"

    ReadOnly Property rdv As BindingList(Of Agendas)
        Get
            Return _lstRdv
        End Get
    End Property

    ReadOnly Property lstRdvVeto As BindingList(Of Agendas)
        Get
            Return _lstRdvVeto
        End Get
    End Property

    Sub rechercheRdvVeto(ByVal codeVeto As Guid, ByVal dateRdv As Date)
        lstRdvVeto.Clear()

        For Each lst As Agendas In rdv
            If (lst.CodeVeto = codeVeto And lst.DateRdv.Date = dateRdv.Date) Then


                _lstRdvVeto.Add(lst)
            End If

        Next

    End Sub
    Sub rechercheRdv()
        Dim lstRdv As List(Of Agendas) = SQLAgendas.getLstRdv()

        For Each a As Agendas In lstRdv
            _lstRdv.Add(a)

        Next
    End Sub

#End Region
End Class
