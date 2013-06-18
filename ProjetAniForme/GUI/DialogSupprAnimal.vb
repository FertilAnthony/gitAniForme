﻿Imports System.Windows.Forms
Imports BLL
Imports BO

Public Class DialogSupprAnimal

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim codeAnimal As Guid = New Guid(EcranAnimaux.tbxCodeAnimal.Text)
        Dim a As Animal = MgtAnimal.getInstance().ObtenirAnimal(codeAnimal)
        MgtAnimal.getInstance().supprimer(a)
        DialogAjoutAnimal.majDataGridView()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
