Imports BO

Public Class SQLAnimal

    Private Const NOM_TABLE As String = "Animaux"
    Private Const TABLE_RACE As String = "Races"
    Private Const PARAM_CODE_CLIENT As String = "@CodeClient"
    Private Const PARAM_CODE_ANIMAL As String = "@CodeAnimal"
    Private Const PARAM_NOM_ANIMAL As String = "@NomAnimal"
    Private Const PARAM_SEXE As String = "@Sexe"
    Private Const PARAM_COULEUR As String = "@Couleur"
    Private Const PARAM_RACE As String = "@Race"
    Private Const PARAM_ESPECE As String = "@Espece"
    Private Const PARAM_TATOUAGE As String = "@Tatouage"
    Private Const PARAM_ARCHIVE As String = "@Archive"

    Private Const REQUETE_SELECTION_TOUS As String = "select * from " & NOM_TABLE
    Private Const REQUETE_SELECTION_PAR_CLIENT As String = "select * from " & NOM_TABLE & " where CodeClient = " & PARAM_CODE_CLIENT
    Private Const REQUETE_SELECTION_RACE As String = "select * from " & TABLE_RACE
    Private Const REQUETE_AJOUT As String = "insert into " & NOM_TABLE & " (CodeAnimal, NomAnimal, Sexe, Couleur, Race, Espece, CodeClient, Tatouage, Archive) VALUES(" & PARAM_CODE_ANIMAL & ", " & PARAM_NOM_ANIMAL & ", " & PARAM_SEXE & ", " & PARAM_COULEUR & ", " & PARAM_RACE & ", " & PARAM_ESPECE & ", " & PARAM_CODE_CLIENT & ", " & PARAM_TATOUAGE & ", " & PARAM_ARCHIVE & ")"
    Private Const REQUETE_SUPPR As String = "delete from " & NOM_TABLE & " where codeAnimal = " & PARAM_CODE_ANIMAL

    Public Shared Function getListeAnimaux() As List(Of Animal)
        getListeAnimaux = New List(Of Animal)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()

            Dim CodeAnimal As Guid = reader.GetGuid(reader.GetOrdinal("CodeAnimal"))
            Dim NomAnimal As String = reader.GetString(reader.GetOrdinal("NomAnimal"))
            Dim SexeAnimal As String = reader.GetString(reader.GetOrdinal("Sexe"))
            Dim Couleur As String = reader.GetString(reader.GetOrdinal("Couleur"))
            Dim Race As String = reader.GetString(reader.GetOrdinal("Race"))
            Dim Espece As String = reader.GetString(reader.GetOrdinal("Espece"))
            Dim CodeClient As Guid = reader.GetGuid(reader.GetOrdinal("CodeClient"))
            Dim Tatouage As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Tatouage"))) Then
                Tatouage = reader.GetString(reader.GetOrdinal("Tatouage"))
            End If
            Dim Antecedent As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Antecedents"))) Then
                Antecedent = reader.GetString(reader.GetOrdinal("Antecedents"))
            End If
            Dim Archive As Boolean = reader.GetBoolean(reader.GetOrdinal("Archive"))
            Dim a As New Animal(CodeAnimal, NomAnimal, CChar(SexeAnimal), Couleur, Race, Espece, CodeClient, Tatouage, Archive, Antecedent)

            getListeAnimaux.Add(a)
        End While
        reader.Close()
    End Function

    Shared Function getListeAnimauxClient(ByVal codeClient As Guid) As List(Of Animal)
        getListeAnimauxClient = New List(Of Animal)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_PAR_CLIENT)
        SQLAccess.initialiserParametre(cmd, PARAM_CODE_CLIENT, codeClient.ToString)

        Dim reader As IDataReader = cmd.ExecuteReader()

        While (reader.Read())
            Dim CodeAnimal As Guid = reader.GetGuid(reader.GetOrdinal("CodeAnimal"))
            Dim NomAnimal As String = reader.GetString(reader.GetOrdinal("NomAnimal"))
            Dim SexeAnimal As String = reader.GetString(reader.GetOrdinal("Sexe"))
            Dim Couleur As String = reader.GetString(reader.GetOrdinal("Couleur"))
            Dim Race As String = reader.GetString(reader.GetOrdinal("Race"))
            Dim Espece As String = reader.GetString(reader.GetOrdinal("Espece"))
            Dim Tatouage As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Tatouage"))) Then
                Tatouage = reader.GetString(reader.GetOrdinal("Tatouage"))
            End If
            Dim Antecedent As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Antecedents"))) Then
                Antecedent = reader.GetString(reader.GetOrdinal("Antecedents"))
            End If
            Dim Archive As Boolean = reader.GetBoolean(reader.GetOrdinal("Archive"))
            Dim a As New Animal(CodeAnimal, NomAnimal, CChar(SexeAnimal), Couleur, Race, Espece, codeClient, Tatouage, Archive, Antecedent)

            getListeAnimauxClient.Add(a)
        End While
        reader.Close()
    End Function

    Shared Function getRaceAnimal() As List(Of Race)
        getRaceAnimal = New List(Of Race)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_RACE)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While (reader.Read())
            Dim race As String = reader.GetString(reader.GetOrdinal("Race"))
            Dim espece As String = reader.GetString(reader.GetOrdinal("Espece"))
            Dim r As Race = New Race(race, espece)
            getRaceAnimal.Add(r)
        End While
        reader.Close()
    End Function


    Shared Sub ajouterAnimal(ByVal a As Animal)
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_AJOUT)
            SQLAccess.initialiserParametre(cmd, PARAM_CODE_CLIENT, a.CodeClient.ToString)
            SQLAccess.initialiserParametre(cmd, PARAM_CODE_ANIMAL, a.CodeAnimal.ToString)
            SQLAccess.initialiserParametre(cmd, PARAM_NOM_ANIMAL, a.NomAnimal)
            SQLAccess.initialiserParametre(cmd, PARAM_SEXE, a.Sexe)
            SQLAccess.initialiserParametre(cmd, PARAM_COULEUR, a.Couleur)
            SQLAccess.initialiserParametre(cmd, PARAM_RACE, a.Race)
            SQLAccess.initialiserParametre(cmd, PARAM_ESPECE, a.Espece)
            SQLAccess.initialiserParametre(cmd, PARAM_TATOUAGE, a.Tatouage)
            SQLAccess.initialiserParametre(cmd, PARAM_ARCHIVE, a.archive)

            Dim nbModif As Integer = cmd.ExecuteNonQuery()

            If nbModif < 1 Then
                Throw New ApplicationException("Aucune ligne n'a été ajoutée")
            ElseIf nbModif > 1 Then
                Throw New ApplicationException(String.Format("Erreur lors de l'enregistrement des données : {0} lignes ont été ajoutées.", nbModif))
            End If
        Catch ex As System.InvalidOperationException
            Throw New ApplicationException("Une erreur est survenue lors de l'accès à la base")
        End Try
    End Sub

    Shared Sub supprimer(ByVal a As Animal)
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SUPPR)
            SQLAccess.initialiserParametre(cmd, PARAM_CODE_ANIMAL, a.CodeAnimal.ToString)

            Dim nbModif As Integer = cmd.ExecuteNonQuery()

            If nbModif < 1 Then
                Throw New ApplicationException("Animal introuvable")
            ElseIf nbModif > 1 Then
                Throw New ApplicationException(String.Format("Erreur lors de la suppression des données : {0} lignes ont été supprimées.", nbModif))
            End If
        Catch ex As System.InvalidOperationException
            Throw New ApplicationException("Une erreur est survenue lors de l'accès à la base")
        End Try
    End Sub

End Class
