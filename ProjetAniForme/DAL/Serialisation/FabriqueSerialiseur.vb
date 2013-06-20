Imports System.IO

Public Class FabriqueSerialiseur

    Private Sub New()
    End Sub

    Public Shared Function getSerialiseur(ByVal nomFichier As String) As Serialiseur
        Dim serialiseur As Serialiseur = Nothing
        If Path.GetExtension(nomFichier) = ".soap" Then
            serialiseur = New SerialiseurSoap()
        ElseIf Path.GetExtension(nomFichier) = ".dat" Then
            serialiseur = New SerialiseurBinaire()
        Else
            Throw New ApplicationException("Le type de fichier spécifié n'est pas supporté")
        End If
        Return serialiseur
    End Function

End Class
