Imports BLL

Public Class EcranClient

#Region "Initialisation"
    Private Sub EcranPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        dataGridViewAnimauxClient.DataSource = MgtAnimal.getInstance().animaux
        'cbxClient.DataSource = MgtClient.getInstance().clients
    End Sub
#End Region

    Private Sub EcranClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridViewAnimauxClient.CellContentClick

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Me.Visible = False

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Me.Visible = False
        EcranAnimaux.Visible = True
        EcranAnimaux.BringToFront()
    End Sub
End Class