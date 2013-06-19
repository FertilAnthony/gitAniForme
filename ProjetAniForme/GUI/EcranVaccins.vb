﻿Imports BLL
Imports BO

Public Class EcranVaccins

    Private Sub EcranVaccins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridViewVaccins.DataSource = MgtVaccin.getInstance.vaccins


    End Sub

    Private Sub DataGridViewVaccins_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewVaccins.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim codeVaccin As String = DataGridViewVaccins.CurrentRow.Cells(0).Value.ToString

        MgtVaccin.getInstance().vaccinModifEnCour(codeVaccin.ToString)


        EcranModifVaccin.Visible = True

    End Sub
End Class