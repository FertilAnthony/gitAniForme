Imports BLL
Imports BO

Public Class EcranVaccins

    Private Sub EcranVaccins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DataGridViewVaccins.DataSource = MgtVaccin.getInstance.vaccins



    End Sub

    Private Sub DataGridViewVaccins_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewVaccins.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim codeVaccin As String = DataGridViewVaccins.CurrentRow.Cells(0).Value.ToString

        MgtVaccin.getInstance().vaccinModifEnCour(codeVaccin.ToString)


        DialogAjoutVaccin.Visible = True

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Visible = False

    End Sub
End Class