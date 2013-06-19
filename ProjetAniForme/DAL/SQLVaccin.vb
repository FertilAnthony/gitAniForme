Imports BO

Public Class SQLVaccin
#Region "Requêtes"
    Private Const NOM_TABLE As String = "Vaccins"
    Private Const PARAM_CODE As String = "@CodeVaccin"
    Private Const REQUETE_SELECTION_TOUS As String = "select * from " & NOM_TABLE
    Private Const REQUETE_SELECTION_UNIQUE As String = "select * from " & NOM_TABLE & "where CodeVaccin ="
    Private Const REQUETE_UPDATE_VACCIN As String = "update " & NOM_TABLE & " set QuantiteStock=@QuantiteStock where CodeVaccin=@CodeVaccin"
#End Region
    Shared Function getLstVaccin() As List(Of BO.Vaccin)

        getLstVaccin = New List(Of Vaccin)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()

            Dim CodeVaccin As Guid = reader.GetGuid(reader.GetOrdinal("CodeVaccin"))
            Dim NomVaccin As String = reader.GetString(reader.GetOrdinal("NomVaccin"))
            Dim QuantiteStock As Integer = reader.GetInt32(reader.GetOrdinal("QuantiteStock"))
            Dim PeriodeValidite As Integer = reader.GetInt32(reader.GetOrdinal("PeriodeValidite"))
            Dim Archive As Boolean = reader.GetBoolean(reader.GetOrdinal("Archive"))
            Dim v As New Vaccin(CodeVaccin, NomVaccin, QuantiteStock, PeriodeValidite, Archive)

            getLstVaccin.Add(v)

        End While
        reader.Close()
    End Function


    Shared Sub AjoutQt(ByVal newQt As Integer, ByVal guid As Guid)

        Dim erreur As String = "L'ajout de vaccins a échoué"

        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_UPDATE_VACCIN)

            SQLAccess.creerParametre(cmd, "@CodeVaccin", guid.ToString)
            SQLAccess.creerParametre(cmd, "@QuantiteStock", newQt)
       
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

    

End Class
