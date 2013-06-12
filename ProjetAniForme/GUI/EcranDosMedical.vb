Public Class EcranDosMedical

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Visible = False
    End Sub

    Private Sub EcranDosMedical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.BringToFront()

    End Sub
End Class