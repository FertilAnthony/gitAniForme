Imports BLL

Public Class EcranPrincipal


    Private Sub btnAgendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgendas.Click


        EcranAgendas.Visible = True
        EcranAgendas.BringToFront()
        EcranRdv.Visible = False


        EcranAnimaux.Visible = False

        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False
        EcranVaccins.Visible = False

    End Sub


    Private Sub EcranPrincipal_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.BringToFront()
        EcranAgendas.MdiParent = Me
        EcranRdv.MdiParent = Me
        EcranClient.MdiParent = Me
        EcranAnimaux.MdiParent = Me
        EcranDosMedical.MdiParent = Me
        EcranConsultation.MdiParent = Me
        EcranVeterinaire.MdiParent = Me
        EcranVaccins.MdiParent = Me
        EcranVeterinaire.Visible = True
        MgtVeterinaire.getInstance.initialiserDonnees()
        MgtAnimal.getInstance.initialiserDonnees()
        MgtClient.getInstance.initialiserDonnees()
        MgtAnimal.getInstance.getAllraceAnimaux()
        MgtAgendas.getInstance.rechercheRdv()
        MgtVaccin.getInstance.initialiserDonnees()
        MgtBareme.getInstance.initialiserBareme()

    End Sub

    Private Sub btnRdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRdv.Click


        EcranRdv.Visible = True
        EcranRdv.BringToFront()
        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False
        EcranVaccins.Visible = False

    End Sub

    Private Sub btnClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click

        EcranClient.Visible = True
        EcranClient.BringToFront()
        EcranRdv.Visible = False

        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False

        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False
        EcranVaccins.Visible = False

    End Sub



    Private Sub btnDosMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDosMedical.Click
        EcranDosMedical.Visible = True
        EcranDosMedical.BringToFront()
        EcranRdv.Visible = False

        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False

        EcranVaccins.Visible = False
    End Sub

    Private Sub ToolStripContainer1_LeftToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripPanel.Click

    End Sub




    Private Sub VétérinairesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VétérinairesToolStripMenuItem.Click
        EcranVeterinaire.Visible = True
        EcranVeterinaire.BringToFront()
        EcranRdv.Visible = False
        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False
        EcranVaccins.Visible = False
    End Sub

    Private Sub MiseÀJourDuStockDeVaccinsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseÀJourDuStockDeVaccinsToolStripMenuItem.Click
        EcranVaccins.Visible = True
        EcranVaccins.BringToFront()
        EcranVeterinaire.Visible = False

        EcranRdv.Visible = False
        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False
        EcranDosMedical.Visible = False

    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()

    End Sub

    Private Sub PriseDeRendezvousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriseDeRendezvousToolStripMenuItem.Click
        EcranRdv.Visible = True
        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False
        EcranVaccins.Visible = True
        EcranDosMedical.Visible = False
        EcranVeterinaire.Visible = False

    End Sub

    Private Sub DossierClientAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DossierClientAnimalToolStripMenuItem.Click
        EcranRdv.Visible = False
        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = True
        EcranConsultation.Visible = False
        EcranVaccins.Visible = False
        EcranDosMedical.Visible = False
        EcranVeterinaire.Visible = False
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendaToolStripMenuItem.Click
        EcranRdv.Visible = False
        EcranAgendas.Visible = True
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False
        EcranVaccins.Visible = False
        EcranDosMedical.Visible = False
        EcranVeterinaire.Visible = False
    End Sub

    Private Sub DossiersMédicauxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DossiersMédicauxToolStripMenuItem.Click
        EcranRdv.Visible = False
        EcranAgendas.Visible = False
        EcranAnimaux.Visible = False
        EcranClient.Visible = False
        EcranConsultation.Visible = False
        EcranVaccins.Visible = False
        EcranDosMedical.Visible = True
        EcranVeterinaire.Visible = False
    End Sub

    Private Sub MiseÀJourDuBarèmeDeTarificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseÀJourDuBarèmeDeTarificationToolStripMenuItem.Click
        EcranBareme.Visible = True
    End Sub
End Class
