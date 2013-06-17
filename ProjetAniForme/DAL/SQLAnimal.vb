Imports BO

Public Class SQLAnimal

    Private Const NOM_TABLE As String = "Animaux"
    Private Const PARAM_CODE_CLIENT As String = "@CodeClient"

    Private Const REQUETE_SELECTION_TOUS As String = "select * from " & NOM_TABLE
    Private Const REQUETE_SELECTION_PAR_CLIENT As String = "select * from " & NOM_TABLE & " where CodeClient = " & PARAM_CODE_CLIENT

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
                Tatouage = reader.GetString(reader.GetOrdinal("Sexe"))
            End If
            Dim Antecedent As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Antecedents"))) Then
                Antecedent = reader.GetString(reader.GetOrdinal("Tatouage"))
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
                Tatouage = reader.GetString(reader.GetOrdinal("Sexe"))
            End If
            Dim Antecedent As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Antecedents"))) Then
                Antecedent = reader.GetString(reader.GetOrdinal("Tatouage"))
            End If
            Dim Archive As Boolean = reader.GetBoolean(reader.GetOrdinal("Archive"))
            Dim a As New Animal(CodeAnimal, NomAnimal, CChar(SexeAnimal), Couleur, Race, Espece, codeClient, Tatouage, Archive, Antecedent)

            getListeAnimauxClient.Add(a)
        End While
        reader.Close()
    End Function

End Class
