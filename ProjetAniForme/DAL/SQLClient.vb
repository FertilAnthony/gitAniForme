Imports BO

Public Class SQLClient

    Private Const NOM_TABLE As String = "Clients"

    Private Const REQUETE_SELECTION_TOUS As String = "select * from " & NOM_TABLE
    Private Const REQUETE_INSERT_CLIENT As String = "insert into clients(CodeClient,NomClient,PrenomClient,Adresse1,Adresse2,CodePostal,Ville,NumTel,Assurance,Email,Archive) values(@CodeClient,@NomClient,@PrenomClient,@Adresse1,@Adresse2,@CodePostal,@Ville,@NumTel,@Assurance,@Email,@Archive)"
    Private Const REQUETE_DELETE_CLIENT As String = "delete from Clients where NomClient=@nomClient"
    Private Const REQUETE_UPDATE_CLIENT As String = "update Clients set NomClient=@nomClient,PrenomClient=@prenomClient,Adresse1=@adresse1,Adresse2=@adresse2,CodePostal=@codePostal,Ville=@ville,NumTel=@numTel,Assurance=@assurance,Email=@email where CodeClient=@codeClient"
    Public Shared Function getListeClient() As List(Of Client)
        getListeClient = New List(Of Client)
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECTION_TOUS)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim remarque As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Remarque"))) Then
                remarque = reader.GetString(reader.GetOrdinal("Remarque"))

            End If
            Dim adresse2 As String = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("Adresse2"))) Then
                adresse2 = reader.GetString(reader.GetOrdinal("Adresse2"))


            End If
            Dim c As Client = New Client(reader.GetGuid(reader.GetOrdinal("CodeClient")),
                                         reader.GetString(reader.GetOrdinal("NomClient")),
                                         reader.GetString(reader.GetOrdinal("PrenomClient")),
                                         reader.GetString(reader.GetOrdinal("Adresse1")),
                                         adresse2,
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

    Public Shared Sub ajouterClient(ByVal Client As Client)
        Dim erreur As String = "l'ajout du client a echoué"
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_INSERT_CLIENT)

            SQLAccess.creerParametre(cmd, "@CodeClient", Client.CodeClient.ToString)
            SQLAccess.creerParametre(cmd, "@NomClient", Client.NomClient)
            SQLAccess.creerParametre(cmd, "@PrenomClient", Client.PrenomClient)
            SQLAccess.creerParametre(cmd, "@Adresse1", Client.Adresse1)
            SQLAccess.creerParametre(cmd, "@Adresse2", Client.Adresse2)
            SQLAccess.creerParametre(cmd, "@CodePostal", Client.CodePostal)
            SQLAccess.creerParametre(cmd, "@Ville", Client.Ville)
            SQLAccess.creerParametre(cmd, "@NumTel", Client.NumTel)
            SQLAccess.creerParametre(cmd, "@Assurance", Client.Assurance)
            SQLAccess.creerParametre(cmd, "@Email", Client.Email)
            SQLAccess.creerParametre(cmd, "@archive", Client.Archive)

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

    Shared Sub supprimerClient(ByVal c As Client)
        Dim erreur As String = "la suppression du client a echoué"
        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_DELETE_CLIENT)
            SQLAccess.creerParametre(cmd, "@nomClient", c.NomClient)
            Dim res As Integer = cmd.ExecuteNonQuery()

            If (res <> 1) Then
                Throw New ApplicationException(erreur)
            End If
        Catch ex As Exception


            Throw New ApplicationException(erreur)

        Finally
            SQLAccess.seDeconnecter()
        End Try
    End Sub

    Shared Sub modifierClient(ByVal c As Client)

        Dim erreur As String = "La mise à jour du service a echoué"

        Try
            Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_UPDATE_CLIENT)

            SQLAccess.creerParametre(cmd, "@CodeClient", c.CodeClient.ToString)
            SQLAccess.creerParametre(cmd, "@NomClient", c.NomClient)
            SQLAccess.creerParametre(cmd, "@PrenomClient", c.PrenomClient)
            SQLAccess.creerParametre(cmd, "@Adresse1", c.Adresse1)
            SQLAccess.creerParametre(cmd, "@Adresse2", c.Adresse2)
            SQLAccess.creerParametre(cmd, "@CodePostal", c.CodePostal)
            SQLAccess.creerParametre(cmd, "@Ville", c.Ville)
            SQLAccess.creerParametre(cmd, "@NumTel", c.NumTel)
            SQLAccess.creerParametre(cmd, "@Assurance", c.Assurance)
            SQLAccess.creerParametre(cmd, "@Email", c.Email)
            SQLAccess.creerParametre(cmd, "@archive", c.Archive)

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

