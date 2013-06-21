Imports BLL
Imports BO

Public Class EcranBareme

    Private Sub EcranBareme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Chargement listes déroulantes acte
        Dim typeBareme As New List(Of String)
        For Each bareme As Bareme In MgtBareme.getInstance.bareme
            Dim typeActe As String = bareme.typeActe
            Dim unique As String = typeBareme.Find(Function(b As String) b = typeActe)
            If unique = Nothing Then
                typeBareme.Add(typeActe)
            End If
        Next
        cbxTypeActe.DataSource = typeBareme
        cbxTypeActe.SelectedIndex = 0
        'Dim type As String = cbxTypeActe.SelectedItem.ToString

        'dataGridViewBareme.DataSource = majBareme(type)

    End Sub

    Private Sub cbxTypeActe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTypeActe.SelectedIndexChanged
        Dim type As String = cbxTypeActe.SelectedItem.ToString

        dataGridViewBareme.DataSource = majBareme(Type)
    End Sub

    Private Function majBareme(ByVal type As String) As DataTable
        'initialisation bareme par type
        MgtBareme.getInstance().initialiserBaremeType(Type)

        'Initialisation du datagrid
        Dim voDataTable As New DataTable
        Dim voDataRow As DataRow

        'Création des champs 
        voDataTable.Columns.Add("Code groupement")
        voDataTable.Columns.Add("Date en vigueur")
        voDataTable.Columns.Add("Type")
        voDataTable.Columns.Add("Libelle")
        voDataTable.Columns.Add("Tarif fixe")
        voDataTable.Columns.Add("Tarif mini")
        voDataTable.Columns.Add("Tarif maxi")
        voDataTable.Columns.Add("Vaccin")
        voDataTable.Columns.Add("Archive")

        For Each b As Bareme In MgtBareme.getInstance().baremeType
            voDataRow = voDataTable.NewRow() 'Création d'une nouvelle ligne

            Dim copdeGroupemet As String = b.codeGrp
            Dim dateVigueur As Date = b.dateVigueur
            Dim typeActe As String = b.typeActe
            Dim libelle As String = b.libelle
            Dim tarifFixe As Decimal = b.tarifFixe
            Dim tarifMin As Decimal = b.tarifMini
            Dim tarifMax As Decimal = b.tarifMaxi
            Dim vaccin As String = Nothing
            If b.typeActe = "VACC" Then
                vaccin = b.vaccin.ToString()
            End If

            Dim archive As Boolean = b.Archive

            voDataRow("Code groupement") = copdeGroupemet
            voDataRow("Date en vigueur") = dateVigueur
            voDataRow("Type") = typeActe
            voDataRow("Libelle") = libelle
            voDataRow("Tarif fixe") = tarifFixe
            voDataRow("Tarif mini") = tarifMin
            voDataRow("Tarif maxi") = tarifMax
            voDataRow("Vaccin") = vaccin
            voDataRow("Archive") = archive

            voDataTable.Rows.Add(voDataRow)
        Next
        Return voDataTable
    End Function

    Private Sub btnExporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExporter.Click
        ImportExport.exporterBaremes()
    End Sub

    Private Sub btnImporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporter.Click
        ImportExport.importerBaremes()
    End Sub
End Class