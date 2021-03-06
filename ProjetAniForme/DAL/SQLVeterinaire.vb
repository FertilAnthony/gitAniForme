﻿Imports BO

Public Class SQLVeterinaire

    Private Const NOM_TABLE As String = "Veterinaires"
    Private Const PARAM_NOM_VETO As String = "@NomVeto"
    Private Const PARAM_MDP As String = "@MotPasse"
    Private Const PARAM_CODE As String = "@CodeVeto"

    Private Const REQUETE_SELECTION_TOUS As String = "select CodeVeto, NomVeto from " & NOM_TABLE
    Private Const REQUETE_CONNEXION As String = "select MotPasse, CodeVeto from " & NOM_TABLE & " where CodeVeto = " & PARAM_CODE
    Private Const REQUETE_AJOUT As String = "INSERT INTO " & NOM_TABLE & " (codeVeto, NomVeto, MotPasse, Archive) VALUES(" & PARAM_CODE & ", " & PARAM_NOM_VETO & ", " & PARAM_MDP & ", 0)"
    Private Const REQUETE_SUPPR As String = "delete from " & NOM_TABLE & " where codeVeto = " & PARAM_CODE
    Private Const REQUETE_UPDATE As String = "update " & NOM_TABLE & " set NomVeto = " & PARAM_NOM_VETO & ", MotPasse = " & PARAM_MDP & " where CodeVeto = " & PARAM_CODE

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
            Dim r As Guid = reader.GetGuid(reader.GetOrdinal("CodeVeto"))
            Dim v As Veterinaire = New Veterinaire(reader.GetGuid(reader.GetOrdinal("CodeVeto")), reader.GetString(reader.GetOrdinal("NomVeto")))
            getListeVeterinaire.Add(v)
        End While
        reader.Close()
    End Function

    Shared Sub ajouter(ByVal veto As Veterinaire)
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_AJOUT)
            SQLAccess.initialiserParametre(cmd, PARAM_CODE, veto.CodeVeto.ToString)
            SQLAccess.initialiserParametre(cmd, PARAM_NOM_VETO, veto.NomVeto)
            SQLAccess.initialiserParametre(cmd, PARAM_MDP, veto.MotPasse)

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

    Shared Sub supprimer(ByVal veto As Veterinaire)
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SUPPR)
            SQLAccess.initialiserParametre(cmd, PARAM_CODE, veto.CodeVeto.ToString)

            Dim nbModif As Integer = cmd.ExecuteNonQuery()

            If nbModif < 1 Then
                Throw New ApplicationException("Vétérinaire introuvable")
            ElseIf nbModif > 1 Then
                Throw New ApplicationException(String.Format("Erreur lors de la suppression des données : {0} lignes ont été supprimées.", nbModif))
            End If
        Catch ex As System.InvalidOperationException
            Throw New ApplicationException("Une erreur est survenue lors de l'accès à la base")
        End Try
    End Sub

    Shared Sub modifier(ByVal veto As Veterinaire)
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_UPDATE)
            SQLAccess.initialiserParametre(cmd, PARAM_CODE, veto.CodeVeto.ToString)
            SQLAccess.initialiserParametre(cmd, PARAM_NOM_VETO, veto.NomVeto)
            SQLAccess.initialiserParametre(cmd, PARAM_MDP, veto.MotPasse)

            Dim nbModif As Integer = cmd.ExecuteNonQuery()

            If nbModif < 1 Then
                Throw New ApplicationException("Aucune ligne n'a été modifiée")
            ElseIf nbModif > 1 Then
                Throw New ApplicationException(String.Format("Erreur lors de la modification des données : {0} lignes ont été modifiées.", nbModif))
            End If
        Catch ex As System.InvalidOperationException
            Throw New ApplicationException("Une erreur est survenue lors de l'accès à la base")
        End Try
    End Sub

    Shared Sub AjoutVetoProcedure(ByVal veto As Veterinaire)
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande("ajout_veterinaire", CommandType.StoredProcedure)
            SQLAccess.initialiserParametre(cmd, "@codeVeto", veto.CodeVeto)
            SQLAccess.initialiserParametre(cmd, "@NomVeto", veto.NomVeto)
            SQLAccess.initialiserParametre(cmd, "@MotPasse", veto.MotPasse)
            SQLAccess.initialiserParametre(cmd, "@Archive", veto.Archive)

            Dim nbModif As Integer = cmd.ExecuteNonQuery()

            If nbModif < 1 Then
                Throw New ApplicationException("Aucune ligne n'a été modifiée")
            ElseIf nbModif > 1 Then
                Throw New ApplicationException(String.Format("Erreur lors de l'ajout des données : {0} lignes ont été modifiées.", nbModif))
            End If
        Catch ex As System.InvalidOperationException
            Throw New ApplicationException("Une erreur est survenue lors de l'accès à la base")

        End Try
    End Sub

End Class
