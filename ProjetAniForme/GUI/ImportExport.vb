Imports BLL

Public Class ImportExport

    Const DefaultExt As String = "*.soap"
    Const Filter As String = "Fichier SOAP|*.soap|Fichier binaire|*.dat|Fichier xml|*.xml"

    Shared Sub exporterBaremes()
        Try
            Dim sfdServices As SaveFileDialog = New SaveFileDialog()
            sfdServices.DefaultExt = DefaultExt
            sfdServices.Filter = Filter
            sfdServices.Title = "Enregistrer les barèmes sous..."
            sfdServices.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If (sfdServices.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fichier As String = sfdServices.FileName
                MgtBareme.getInstance().exporterBaremes(fichier)
                MessageBox.Show("La sauvegarde s'est effectuée avec succès", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("L'enregistrement est annulé", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As ApplicationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Shared Sub importerBaremes()
        Try
            Dim ofdBaremes As OpenFileDialog = New OpenFileDialog()
            ofdBaremes.DefaultExt = DefaultExt
            ofdBaremes.Filter = Filter
            ofdBaremes.Title = "Importer les barèmes depuis..."
            ofdBaremes.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If (ofdBaremes.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fichier As String = ofdBaremes.FileName
                MgtBareme.getInstance().importerBaremes(fichier)
            Else
                MessageBox.Show("L'ouverture du fichier est annulée", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
