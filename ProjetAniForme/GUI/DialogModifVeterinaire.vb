Imports System.Windows.Forms
Imports BLL
Imports BO

Public Class DialogModifVeterinaire

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Dim codeVeto As Guid = New Guid(tbxCodeModif.Text)
            Dim nomVeto As String = tbxNomModif.Text
            Dim mdpVeto As String = tbxMdpModif.Text

            If nomVeto = "" Or mdpVeto = "" Then
                MessageBox.Show("Veuillez remplir tous les champs", "champs incomplet(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MgtVeterinaire.getInstance().modif(codeVeto, nomVeto, mdpVeto)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogModifVeterinaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim veto As Veterinaire = CType(EcranVeterinaire.lbxVeterinaires.SelectedItem, Veterinaire)
        tbxCodeModif.Text = veto.CodeVeto.ToString
        tbxNomModif.Text = veto.NomVeto
    End Sub
End Class
