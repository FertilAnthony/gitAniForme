<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranVeterinaire
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnConnexion = New System.Windows.Forms.Button()
        Me.lbxVeterinaires = New System.Windows.Forms.ListBox()
        Me.gbxVetérinaires = New System.Windows.Forms.GroupBox()
        Me.tbxMdp = New System.Windows.Forms.TextBox()
        Me.lblVetérinaires = New System.Windows.Forms.Label()
        Me.gbxVetérinaires.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnConnexion
        '
        Me.BtnConnexion.Location = New System.Drawing.Point(569, 235)
        Me.BtnConnexion.Name = "BtnConnexion"
        Me.BtnConnexion.Size = New System.Drawing.Size(88, 23)
        Me.BtnConnexion.TabIndex = 4
        Me.BtnConnexion.Text = "Connexion"
        Me.BtnConnexion.UseVisualStyleBackColor = True
        '
        'lbxVeterinaires
        '
        Me.lbxVeterinaires.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbxVeterinaires.FormattingEnabled = True
        Me.lbxVeterinaires.Location = New System.Drawing.Point(6, 18)
        Me.lbxVeterinaires.Name = "lbxVeterinaires"
        Me.lbxVeterinaires.Size = New System.Drawing.Size(409, 108)
        Me.lbxVeterinaires.TabIndex = 6
        '
        'gbxVetérinaires
        '
        Me.gbxVetérinaires.Controls.Add(Me.lbxVeterinaires)
        Me.gbxVetérinaires.Location = New System.Drawing.Point(12, 51)
        Me.gbxVetérinaires.Name = "gbxVetérinaires"
        Me.gbxVetérinaires.Size = New System.Drawing.Size(421, 131)
        Me.gbxVetérinaires.TabIndex = 7
        Me.gbxVetérinaires.TabStop = False
        Me.gbxVetérinaires.Text = "Vétérinaires"
        '
        'tbxMdp
        '
        Me.tbxMdp.Location = New System.Drawing.Point(18, 220)
        Me.tbxMdp.Name = "tbxMdp"
        Me.tbxMdp.Size = New System.Drawing.Size(146, 20)
        Me.tbxMdp.TabIndex = 8
        '
        'lblVetérinaires
        '
        Me.lblVetérinaires.AutoSize = True
        Me.lblVetérinaires.Location = New System.Drawing.Point(15, 204)
        Me.lblVetérinaires.Name = "lblVetérinaires"
        Me.lblVetérinaires.Size = New System.Drawing.Size(77, 13)
        Me.lblVetérinaires.TabIndex = 9
        Me.lblVetérinaires.Text = "Mot de passe :"
        '
        'EcranVeterinaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 270)
        Me.Controls.Add(Me.lblVetérinaires)
        Me.Controls.Add(Me.tbxMdp)
        Me.Controls.Add(Me.gbxVetérinaires)
        Me.Controls.Add(Me.BtnConnexion)
        Me.Name = "EcranVeterinaire"
        Me.Text = "Connexion"
        Me.gbxVetérinaires.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnConnexion As System.Windows.Forms.Button
    Friend WithEvents lbxVeterinaires As System.Windows.Forms.ListBox
    Friend WithEvents gbxVetérinaires As System.Windows.Forms.GroupBox
    Friend WithEvents tbxMdp As System.Windows.Forms.TextBox
    Friend WithEvents lblVetérinaires As System.Windows.Forms.Label
End Class
