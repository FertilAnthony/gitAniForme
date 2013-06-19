Imports BO

Public Class SQLBareme

    Private Const NOM_TABLE As String = "Bareme"
    Private Const PARAM_TYPE As String = "@TypeActe"
    Private Const PARAM_LIBELLE As String = "@Libelle"

    Private Const REQUETE_SELECT_UNIQUE As String = "select distinct * from " & NOM_TABLE
    Private Const REQUETE_SELECT_ALL As String = "select * from " & NOM_TABLE


    Public Shared Function getListeBareme() As List(Of Bareme)
        getListeBareme = New List(Of Bareme)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECT_ALL)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()


            'getListeBareme.Add(b)
        End While
        reader.Close()
    End Function

End Class
