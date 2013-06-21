Imports System.ComponentModel
Imports BO
Imports DAL
Imports System.IO
Imports System.Text

Public Class MgtBareme

#Region "Déclarations"


    Private _bareme As New BindingList(Of Bareme)
    Private _baremeType As New BindingList(Of Bareme)

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

    ReadOnly Property baremeType As BindingList(Of Bareme)
        Get
            Return _baremeType
        End Get
    End Property

#End Region

    Sub initialiserBareme()
        Dim typeBareme As List(Of Bareme) = SQLBareme.getListeBareme()
        For Each b As Bareme In typeBareme
            _bareme.Add(b)
        Next
    End Sub

    Sub initialiserBaremeType(ByVal type As String)
        _baremeType.Clear()
        Dim typeBareme As List(Of Bareme) = SQLBareme.getListeBaremeByType(type)
        For Each b As Bareme In typeBareme
            _baremeType.Add(b)
        Next
    End Sub

    Public Function ObtenirBareme(ByVal codeGrp As String) As Bareme
        Dim retourBareme As Bareme = Nothing
        retourBareme = _baremeType.ToList.Find(Function(b As Bareme) b.codeGrp.Equals(codeGrp))

        Return retourBareme
    End Function

#Region "Import / Export"

    Sub exporterBaremes(ByVal fichier As String)
        Dim extension As String = Path.GetExtension(fichier)
        If (extension = ".xml") Then
            Export.exporterBaremes(Me.baremeType.ToList(), fichier)
        Else
            Dim serialiseur As Serialiseur = FabriqueSerialiseur.getSerialiseur(fichier)
            serialiseur.serialiser(Me.baremeType.ToArray(), fichier)
        End If
    End Sub

#End Region

    Sub importerBaremes(ByVal fichier As String)
        Dim extension As String = Path.GetExtension(fichier)
        Dim tableauBaremes As Bareme()
        If (extension = ".xml") Then
            tableauBaremes = Import.importerBaremes(fichier)
        Else
            Dim serialiseur As Serialiseur = FabriqueSerialiseur.getSerialiseur(fichier)
            tableauBaremes = CType(serialiseur.deserialiser(fichier), Bareme())
        End If

        If (tableauBaremes IsNot Nothing) Then
            For Each b As Bareme In tableauBaremes
                If (Me.ObtenirBareme(b.codeGrp) Is Nothing) Then
                    Me.baremeType.Add(b)
                End If
            Next
        End If
    End Sub

End Class
