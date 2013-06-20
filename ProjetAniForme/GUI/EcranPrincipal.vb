﻿Imports BLL

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

    Private Sub MiseÀJourDuBarèmeDeTarificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseÀJourDuBarèmeDeTarificationToolStripMenuItem.Click
        EcranBareme.Visible = True
    End Sub
End Class
