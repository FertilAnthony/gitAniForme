Imports BO
Imports DAL
Imports System.ComponentModel

Public Class MgtVeterinaire

    Private _listeVeterinaires As New BindingList(Of Veterinaire)

#Region "Pattern de singleton"
    Private Shared _instance As New MgtVeterinaire()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtVeterinaire
        Return _instance
    End Function
#End Region

#Region "Propriétés"
    ReadOnly Property veterinaires As BindingList(Of Veterinaire)
        Get
            Return _listeVeterinaires
        End Get
    End Property
#End Region

    Public Sub TestConnexion(ByVal veterinaire As Veterinaire, ByVal motDePasse As String)
        Dim identifiant As Guid = veterinaire.CodeVeto
        BO.Veterinaire.verifIdentifiant(identifiant)
        BO.Veterinaire.verifMdp(motDePasse)
        SQLVeterinaire.TestConnexion(identifiant, motDePasse)

    End Sub

#Region "Controles"



#End Region

    Sub initialiserDonnees()
        Dim listVeterinaire As List(Of Veterinaire) = SQLVeterinaire.getListeVeterinaire()
        For Each v As Veterinaire In listVeterinaire
            _listeVeterinaires.Add(v)
        Next
    End Sub

End Class
