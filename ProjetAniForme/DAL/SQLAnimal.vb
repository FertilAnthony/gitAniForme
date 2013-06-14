﻿Imports BO

Public Class SQLAnimal

    Private Const NOM_TABLE As String = "Animaux"

    Private Const REQUETE_SELECTION_TOUS As String = "select CodeAnimal, NomAnimal, Race, Espece, CodeClient from " & NOM_TABLE

    Public Shared Function getListeAnimaux() As List(Of Animal)
        getListeAnimaux = New List(Of Animal)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim a As Animal = New Animal(reader.GetGuid(reader.GetOrdinal("CodeAnimal")),
                                         reader.GetString(reader.GetOrdinal("NomAnimal")),
                                         reader.GetString(reader.GetOrdinal("Race")),
                                         reader.GetString(reader.GetOrdinal("Espece")),
                                         reader.GetGuid(reader.GetOrdinal("CodeClient")))

            getListeAnimaux.Add(a)
        End While
        reader.Close()
    End Function

End Class