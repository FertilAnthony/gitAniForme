Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Runtime.Serialization.Formatters.Binary

Public MustInherit Class Serialiseur

    Protected _formatter As IFormatter

    Public Sub serialiser(Of T)(ByVal objetASerialiser As T, ByVal nomFichier As String)
        Dim fichier As FileStream = Nothing
        Try
            fichier = New FileStream(nomFichier, FileMode.Create, FileAccess.Write, FileShare.None)
            Me._formatter.Serialize(fichier, objetASerialiser)
        Catch ex As Exception
            Throw ex
        Finally
            Try
                fichier.Close()
            Catch ex As Exception
                Throw ex
            End Try
        End Try
    End Sub

    Function deserialiser(ByVal nomFichier As String) As Object
        Dim objetDeserialisee As Object = Nothing
        Dim fichierSauvegarde As FileStream = Nothing
        Try
            fichierSauvegarde = New FileStream(nomFichier,
                                           FileMode.Open,
                                           FileAccess.Read,
                                           FileShare.Read)

            objetDeserialisee = _formatter.Deserialize(fichierSauvegarde)
        Catch ex As Exception
            Throw New ApplicationException("Une erreur est survenue à la lecture des données")
        Finally
            If (fichierSauvegarde IsNot Nothing) Then
                fichierSauvegarde.Close()
            End If
        End Try
        Return objetDeserialisee
    End Function

End Class
