Imports BO

Public Class SQLClient

    Private Const NOM_TABLE As String = "Clients"

    Private Const REQUETE_SELECTION_TOUS As String = "select CodeClient, NomClient, PrenomClient from " & NOM_TABLE

    Public Shared Function getListeClient() As List(Of Client)
        getListeClient = New List(Of Client)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim c As Client = New Client(reader.GetGuid(reader.GetOrdinal("CodeClient")),
                                         reader.GetString(reader.GetOrdinal("NomClient")),
                                         reader.GetString(reader.GetOrdinal("PrenomClient")))

            getListeClient.Add(c)
        End While
        reader.Close()
    End Function

End Class
