Imports BLL
Imports BO
Imports System.ComponentModel

Public Class DialogAjoutVaccin

    Private Sub EcranModifVaccin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each v As Vaccin In MgtVaccin.getInstance.vaccinModif
            lbVaccin.Text = v.nomVaccin
            tbOldQuantite.Text = v.quantite.ToString
            Dim oldQt As Integer = v.quantite

        Next







    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbOldQuantite.TextChanged

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        For Each v As Vaccin In MgtVaccin.getInstance.vaccinModif

            Dim newQt As Integer = CInt(tbOldQuantite.Text)

            MgtVaccin.getInstance().AjoutQt(newQt, v.codeVaccin)
        Next
        Me.Visible = False
        MgtVaccin.getInstance.vaccinModif.Clear()

        nudNewQt.Value = 0


        MgtVaccin.getInstance.vaccins.Clear()
        MgtVaccin.getInstance.vaccinModif.Clear()

        MgtVaccin.getInstance.initialiserDonnees()

    End Sub

    Private Sub nudNewQt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudNewQt.ValueChanged
        For Each v As Vaccin In MgtVaccin.getInstance.vaccinModif
            tbOldQuantite.Text = CStr(v.quantite + nudNewQt.Value)

        Next


    End Sub
End Class