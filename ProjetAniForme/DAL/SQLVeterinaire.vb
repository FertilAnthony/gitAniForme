Imports BO

Public Class SQLVeterinaire

    Private Const NOM_TABLE As String = "Veterinaires"
    Private Const PARAM_NOM_VETO As String = "@NomVeto"
    Private Const PARAM_MDP As String = "@MotPasse"
    Private Const PARAM_CODE As String = "@CodeVeto"

    Private Const REQUETE_SELECTION_TOUS As String = "select CodeVeto, NomVeto from " & NOM_TABLE
    Private Const REQUETE_CONNEXION As String = "select MotPasse, CodeVeto from " & NOM_TABLE & " where CodeVeto = " & PARAM_CODE

    Public Shared Sub TestConnexion(ByVal codeVeto As Guid, ByVal motPasse As String)
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_CONNEXION)
            SQLAccess.initialiserParametre(cmd, PARAM_MDP, motPasse)
            SQLAccess.initialiserParametre(cmd, PARAM_CODE, codeVeto.ToString)

            Dim reader As IDataReader = cmd.ExecuteReader()

            If reader.FieldCount() > 0 Then
                reader.Read()
                If motPasse <> reader.Item("MotPasse").ToString Then
                    reader.Close()
                    Throw New ApplicationException("Identifiant et/ou mot de passe incorrect")
                End If
            End If

            reader.Close()
        Catch ex As System.InvalidOperationException
            Throw New ApplicationException(ex.Message & "Une erreur est survenue lors de l'accès à la base")
        End Try

    End Sub

    Public Shared Function getListeVeterinaire() As List(Of Veterinaire)
        getListeVeterinaire = New List(Of Veterinaire)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim v As Veterinaire = New Veterinaire(reader.GetGuid(reader.GetOrdinal("CodeVeto")), reader.GetString(reader.GetOrdinal("NomVeto")))
            getListeVeterinaire.Add(v)
        End While
        reader.Close()
    End Function

End Class
