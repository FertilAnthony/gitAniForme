Imports BLL

Public Class EcranPrincipal


    Private Sub btnAgendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgendas.Click


        EcranAgendas.Visible = True
        EcranAgendas.BringToFront()

    End Sub


    Private Sub EcranPrincipal_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        EcranAgendas.MdiParent = Me
        EcranRdv.MdiParent = Me
        EcranClient.MdiParent = Me
        EcranAnimaux.MdiParent = Me
        EcranDosMedical.MdiParent = Me
        EcranConsultation.MdiParent = Me
        EcranVeterinaire.MdiParent = Me

        MgtVeterinaire.getInstance.initialiserDonnees()
        MgtAnimal.getInstance.initialiserDonnees()
        MgtClient.getInstance.initialiserDonnees()
        MgtAnimal.getInstance.getAllraceAnimaux()
        MgtAgendas.getInstance.rechercheRdv()
        MgtVaccin.getInstance.initialiserDonnees()


    End Sub

    Private Sub btnRdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRdv.Click


        EcranRdv.Visible = True
        EcranRdv.BringToFront()
        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False


    End Sub

    Private Sub btnClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click

        EcranClient.Visible = True
        EcranClient.BringToFront()

    End Sub



    Private Sub btnDosMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDosMedical.Click
        EcranDosMedical.Visible = True
        EcranDosMedical.BringToFront()
    End Sub

    Private Sub ToolStripContainer1_LeftToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripPanel.Click

    End Sub




    Private Sub VétérinairesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VétérinairesToolStripMenuItem.Click
        EcranVeterinaire.Visible = True
        EcranVeterinaire.BringToFront()
    End Sub

    Private Sub MiseÀJourDuStockDeVaccinsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseÀJourDuStockDeVaccinsToolStripMenuItem.Click
        EcranVaccins.Visible = True
        EcranVaccins.BringToFront()
    End Sub
End Class
