Imports System.ComponentModel
Imports BO
Imports DAL

Public Class MgtVaccin
#Region "Déclarations"
    Private _listeVaccins As New BindingList(Of Vaccin)
    Private _vaccinModif As New BindingList(Of Vaccin)

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

    ReadOnly Property vaccinModif As BindingList(Of Vaccin)
        Get
            Return _vaccinModif
        End Get
    End Property

    Sub initialiserDonnees()
        Dim listeVaccin As List(Of Vaccin) = SQLVaccin.getLstVaccin()

        For Each v As Vaccin In listeVaccin
            _listeVaccins.Add(v)

        Next
    End Sub
#End Region

    Sub vaccinModifEnCour(ByVal codeVaccin As String)
        vaccinModif.Clear()

        For Each v As Vaccin In vaccins
            If (v.codeVaccin.ToString = codeVaccin) Then


                _vaccinModif.Add(v)
            End If

        Next
    End Sub


    Sub AjoutQt(ByVal newQt As Integer, ByVal guid As Guid)
        SQLVaccin.AjoutQt(newQt, guid)
    End Sub



End Class
