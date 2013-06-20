Imports BO

Public Class SQLBareme

    Private Const NOM_TABLE As String = "Baremes"
    Private Const PARAM_CODE As String = "@CodeGroupement"
    Private Const PARAM_DATE As String = "@DateVigueur"
    Private Const PARAM_TYPE As String = "@TypeActe"
    Private Const PARAM_LIBELLE As String = "@Libelle"
    Private Const PARAM_TARIF As String = "@TarifFixe"
    Private Const PARAM_TARIF_MIN As String = "@TarifMini"
    Private Const PARAM_TARIF_MAX As String = "@TarifMaxi"
    Private Const PARAM_CODE_VACCIN As String = "@CodeVaccin"
    Private Const PARAM_ARCHIVE As String = "@Archive"

    Private Const REQUETE_SELECT_ALL As String = "select * from " & NOM_TABLE
    Private Const REQUETE_SELECT_BY_TYPE As String = "select * from " & NOM_TABLE & " where TypeActe = " & PARAM_TYPE

    Public Shared Function getListeBareme() As List(Of Bareme)
        getListeBareme = New List(Of Bareme)
        Dim listeVaccins As List(Of Vaccin) = SQLVaccin.getLstVaccin()
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECT_ALL)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim code As String = reader.GetString(reader.GetOrdinal("CodeGroupement"))
            Dim dateVigeur As Date = CDate(reader.GetString(reader.GetOrdinal("DateVigueur")))
            Dim type As String = reader.GetString(reader.GetOrdinal("TypeActe"))
            Dim libelle As String = reader.GetString(reader.GetOrdinal("Libelle"))
            Dim tarif As Decimal = reader.GetDecimal(reader.GetOrdinal("TarifFixe"))
            Dim tarifMin As Decimal = reader.GetDecimal(reader.GetOrdinal("TarifMini"))
            Dim tarifMax As Decimal = reader.GetDecimal(reader.GetOrdinal("TarifMaxi"))
            Dim codeVaccin As Guid = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("CodeVaccin"))) Then
                codeVaccin = reader.GetGuid(7)
            End If
            Dim archive As Boolean = reader.GetBoolean(reader.GetOrdinal("Archive"))

            Dim v As Vaccin = Nothing
            For Each vac As Vaccin In listeVaccins
                If vac.codeVaccin = codeVaccin Then
                    v = vac
                    Exit For
                End If
            Next

            Dim b As New Bareme(code, dateVigeur, type, libelle, tarif, tarifMin, tarifMax, v, archive)

            getListeBareme.Add(b)
        End While
        reader.Close()
    End Function


    Public Shared Function getListeBaremeByType(ByVal typeBareme As String) As List(Of Bareme)
        getListeBaremeByType = New List(Of Bareme)
        Dim listeVaccins As List(Of Vaccin) = SQLVaccin.getLstVaccin()
        Dim cmd As IDbCommand = SQLAccess.creerCommande(REQUETE_SELECT_BY_TYPE)
        SQLAccess.creerParametre(cmd, "@TypeActe", typeBareme)
        Dim reader As IDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim code As String = reader.GetString(reader.GetOrdinal("CodeGroupement"))
            Dim dateVigeur As Date = CDate(reader.GetString(reader.GetOrdinal("DateVigueur")))
            Dim type As String = reader.GetString(reader.GetOrdinal("TypeActe"))
            Dim libelle As String = reader.GetString(reader.GetOrdinal("Libelle"))
            Dim tarif As Decimal = reader.GetDecimal(reader.GetOrdinal("TarifFixe"))
            Dim tarifMin As Decimal = reader.GetDecimal(reader.GetOrdinal("TarifMini"))
            Dim tarifMax As Decimal = reader.GetDecimal(reader.GetOrdinal("TarifMaxi"))
            Dim codeVaccin As Guid = Nothing
            If (Not reader.IsDBNull(reader.GetOrdinal("CodeVaccin"))) Then
                codeVaccin = reader.GetGuid(7)
            End If
            Dim archive As Boolean = reader.GetBoolean(reader.GetOrdinal("Archive"))

            Dim v As Vaccin = Nothing
            For Each vac As Vaccin In listeVaccins
                If vac.codeVaccin = codeVaccin Then
                    v = vac
                    Exit For
                End If
            Next

            Dim b As New Bareme(code, dateVigeur, type, libelle, tarif, tarifMin, tarifMax, v, archive)

            getListeBaremeByType.Add(b)
        End While
        reader.Close()
    End Function

End Class
