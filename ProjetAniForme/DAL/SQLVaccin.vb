Imports BO

Public Class SQLVaccin
#Region "Requêtes"
    Private Const NOM_TABLE As String = "Vaccins"
    Private Const REQUETE_SELECTION_TOUS As String = "select * from " & NOM_TABLE

#End Region
    Shared Function getLstVaccin() As List(Of BO.Vaccin)
        getLstVaccin = New List(Of Vaccin)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()

            Dim CodeVaccin As Guid = reader.GetGuid(reader.GetOrdinal("CodeVaccin"))
            Dim NomVaccin As String = reader.GetString(reader.GetOrdinal("NomVaccin"))
            Dim QuantiteStock As Integer = reader.GetInt16(reader.GetOrdinal("QuantiteStock"))
            Dim PeriodeValidite As Integer = reader.GetInt16(reader.GetOrdinal("PeriodeValidite"))
            Dim Archive As Boolean = reader.GetBoolean(reader.GetOrdinal("Archive"))
            Dim v As New Vaccin(CodeVaccin, NomVaccin, QuantiteStock, PeriodeValidite, Archive)

            getLstVaccin.Add(v)
        End While
        reader.Close()
    End Function

End Class
