Imports BO

Public Class SQLClient

    Private Const NOM_TABLE As String = "Clients"

    Private Const REQUETE_SELECTION_TOUS As String = "select * from " & NOM_TABLE

    Public Shared Function getListeClient() As List(Of Client)
        getListeClient = New List(Of Client)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim remarque As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Remarque"))) Then
                remarque = reader.GetString(reader.GetOrdinal("Tatouage"))
            End If
            Dim c As Client = New Client(reader.GetGuid(reader.GetOrdinal("CodeClient")),
                                         reader.GetString(reader.GetOrdinal("NomClient")),
                                         reader.GetString(reader.GetOrdinal("PrenomClient")),
                                         reader.GetString(reader.GetOrdinal("Adresse1")),
                                         reader.GetString(reader.GetOrdinal("Adresse2")),
                                         reader.GetString(reader.GetOrdinal("CodePostal")),
                                         reader.GetString(reader.GetOrdinal("Ville")),
                                         reader.GetString(reader.GetOrdinal("NumTel")),
                                         reader.GetString(reader.GetOrdinal("Assurance")),
                                         reader.GetString(reader.GetOrdinal("Email")),
                                         reader.GetBoolean(reader.GetOrdinal("Archive")),
                                         remarque)

            getListeClient.Add(c)
        End While
        reader.Close()
    End Function

End Class
