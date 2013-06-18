Imports BO

Public Class SQLAgendas

    Private Const NOM_TABLE As String = "Agendas"
    Private Const PARAM_CODE_VETO As String = "@CodeVeto"
    Private Const REQUETE_SELECTION_PAR_VETO As String = "select * from " & NOM_TABLE & " where CodeVeto = " & PARAM_CODE_VETO
    Private Const REQUETE_SELECTION_TOUS As String = "select * from " & NOM_TABLE

    Public Shared Function getLstRdv() As List(Of Agendas)
        getLstRdv = New List(Of Agendas)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()

            Dim CdVeto As Guid = reader.GetGuid(reader.GetOrdinal("CodeVeto"))
            Dim DateRdv As Date = reader.GetDateTime(reader.GetOrdinal("DateRdv"))
            Dim CodeAnimal As Guid = reader.GetGuid(reader.GetOrdinal("CodeAnimal"))
           
            Dim rdv As New Agendas(CdVeto, DateRdv, CodeAnimal)

            getLstRdv.Add(rdv)
        End While
        reader.Close()
    End Function

    Shared Function getLstRdvVeto(ByVal codeVeto As Guid) As List(Of Agendas)
        getLstRdvVeto = New List(Of Agendas)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_PAR_VETO)
        SQLAccess.initialiserParametre(cmd, PARAM_CODE_VETO, codeVeto.ToString)

        Dim reader As IDataReader = cmd.ExecuteReader()

        While (reader.Read())

            Dim CdVeto As Guid = reader.GetGuid(reader.GetOrdinal("CodeVeto"))
            Dim DateRdv As Date = reader.GetDateTime(reader.GetOrdinal("DateRdv"))
            Dim CodeAnimal As Guid = reader.GetGuid(reader.GetOrdinal("CodeAnimal"))

            Dim rdv As New Agendas(CdVeto, DateRdv, CodeAnimal)

            getLstRdvVeto.Add(rdv)
        End While
        reader.Close()
    End Function
End Class
