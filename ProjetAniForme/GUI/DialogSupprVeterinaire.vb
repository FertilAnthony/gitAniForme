Imports System.Windows.Forms
Imports BLL
Imports BO

Public Class DialogSupprVeterinaire

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim veto As Veterinaire = CType(EcranVeterinaire.lbxVeterinaires.SelectedItem, Veterinaire)
        MgtVeterinaire.getInstance().supprimer(veto)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
