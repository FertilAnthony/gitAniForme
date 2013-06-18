Imports BO
Imports BLL

Imports System.Windows.Forms

Public Class DialogAjoutAnimal

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim sexeAnimal As String
        Dim nomAnimal As String = tbxNomAnimal.Text
        Dim couleurAnimal As String = tbxCouleurAnimal.Text
        Dim tatouageAnimal As String = tbxTatouageAnimal.Text
        Dim raceAnimal As String = cbxRaceAnimal.Text
        Dim especeAnimal As String = cbxEspeceAnimal.Text
        If cbxSexeAnimal.SelectedIndex = 1 Then
            sexeAnimal = "M"
        ElseIf cbxSexeAnimal.SelectedIndex = 2 Then
            sexeAnimal = "F"
        Else
            sexeAnimal = "H"
        End If
        Dim codeClient As Guid = New Guid(EcranAnimaux.tbxCodeClient.Text)

        Dim a As New Animal(Guid.NewGuid(), nomAnimal, CChar(sexeAnimal), couleurAnimal, raceAnimal, especeAnimal, codeClient, tatouageAnimal, False)
        MgtAnimal.getInstance().ajout(a)
        majDataGridView()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogAjoutAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim tRace(MgtAnimal.getInstance().raceAnimaux.Count) As String
        Dim tEspece(MgtAnimal.getInstance().raceAnimaux.Count) As String
        While i < MgtAnimal.getInstance().raceAnimaux.Count
            tRace(i) = MgtAnimal.getInstance().raceAnimaux.Item(i).Race
            tEspece(i) = MgtAnimal.getInstance().raceAnimaux.Item(i).Espece
            i = i + 1
        End While
        cbxRaceAnimal.DataSource = tRace
        cbxRaceAnimal.SelectedIndex = 0
        cbxEspeceAnimal.DataSource = tEspece
        cbxEspeceAnimal.SelectedIndex = 0
    End Sub

    Public Sub majDataGridView()
        Dim codeClient As Guid = New Guid(EcranAnimaux.tbxCodeClient.Text)
        MgtAnimal.getInstance.rechercheAnimauxClient(codeClient)
        EcranAnimaux.DataGridView1.DataSource = Nothing
        EcranAnimaux.DataGridView1.Rows.Clear()
        EcranAnimaux.DataGridView1.DataSource = MgtAnimal.getInstance.animauxClient
    End Sub

End Class
