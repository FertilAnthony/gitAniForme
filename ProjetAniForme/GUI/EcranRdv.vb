Public Class EcranRdv

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Me.Visible = False
    End Sub

    Private Sub EcranRdv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Visible = True
        Me.BringToFront()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
       
        Me.Visible = False
        EcranClient.Visible = True
        EcranClient.BringToFront()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    
        Me.Visible = False
        EcranAnimaux.Visible = True
        EcranAnimaux.BringToFront()
    End Sub
End Class