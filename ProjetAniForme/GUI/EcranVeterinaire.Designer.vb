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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnSupprimerVeto = New System.Windows.Forms.Button()
        Me.btnModifierVeto = New System.Windows.Forms.Button()
        Me.btnAjouterVeto = New System.Windows.Forms.Button()
        Me.gbxVetérinaires.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnConnexion
        '
        Me.BtnConnexion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConnexion.Location = New System.Drawing.Point(507, 273)
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
        Me.gbxVetérinaires.Location = New System.Drawing.Point(12, 75)
        Me.gbxVetérinaires.Name = "gbxVetérinaires"
        Me.gbxVetérinaires.Size = New System.Drawing.Size(421, 131)
        Me.gbxVetérinaires.TabIndex = 7
        Me.gbxVetérinaires.TabStop = False
        Me.gbxVetérinaires.Text = "Vétérinaires"
        '
        'tbxMdp
        '
        Me.tbxMdp.Location = New System.Drawing.Point(18, 248)
        Me.tbxMdp.Name = "tbxMdp"
        Me.tbxMdp.Size = New System.Drawing.Size(146, 20)
        Me.tbxMdp.TabIndex = 8
        '
        'lblVetérinaires
        '
        Me.lblVetérinaires.AutoSize = True
        Me.lblVetérinaires.Location = New System.Drawing.Point(12, 232)
        Me.lblVetérinaires.Name = "lblVetérinaires"
        Me.lblVetérinaires.Size = New System.Drawing.Size(77, 13)
        Me.lblVetérinaires.TabIndex = 9
        Me.lblVetérinaires.Text = "Mot de passe :"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GUI.My.Resources.Resources.gohome
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(275, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 51)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Home"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnSupprimerVeto
        '
        Me.btnSupprimerVeto.FlatAppearance.BorderSize = 0
        Me.btnSupprimerVeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerVeto.Image = Global.GUI.My.Resources.Resources._stop
        Me.btnSupprimerVeto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSupprimerVeto.Location = New System.Drawing.Point(187, 10)
        Me.btnSupprimerVeto.Name = "btnSupprimerVeto"
        Me.btnSupprimerVeto.Size = New System.Drawing.Size(67, 51)
        Me.btnSupprimerVeto.TabIndex = 12
        Me.btnSupprimerVeto.Text = "Supprimer"
        Me.btnSupprimerVeto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSupprimerVeto.UseVisualStyleBackColor = True
        '
        'btnModifierVeto
        '
        Me.btnModifierVeto.FlatAppearance.BorderSize = 0
        Me.btnModifierVeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifierVeto.Image = Global.GUI.My.Resources.Resources.pencil
        Me.btnModifierVeto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModifierVeto.Location = New System.Drawing.Point(97, 10)
        Me.btnModifierVeto.Name = "btnModifierVeto"
        Me.btnModifierVeto.Size = New System.Drawing.Size(67, 51)
        Me.btnModifierVeto.TabIndex = 11
        Me.btnModifierVeto.Text = "Modifier"
        Me.btnModifierVeto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModifierVeto.UseVisualStyleBackColor = True
        '
        'btnAjouterVeto
        '
        Me.btnAjouterVeto.FlatAppearance.BorderSize = 0
        Me.btnAjouterVeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouterVeto.Image = Global.GUI.My.Resources.Resources.add
        Me.btnAjouterVeto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAjouterVeto.Location = New System.Drawing.Point(12, 10)
        Me.btnAjouterVeto.Name = "btnAjouterVeto"
        Me.btnAjouterVeto.Size = New System.Drawing.Size(67, 51)
        Me.btnAjouterVeto.TabIndex = 10
        Me.btnAjouterVeto.Text = "Ajouter"
        Me.btnAjouterVeto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAjouterVeto.UseVisualStyleBackColor = True
        '
        'EcranVeterinaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 308)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSupprimerVeto)
        Me.Controls.Add(Me.btnModifierVeto)
        Me.Controls.Add(Me.btnAjouterVeto)
        Me.Controls.Add(Me.lblVetérinaires)
        Me.Controls.Add(Me.tbxMdp)
        Me.Controls.Add(Me.gbxVetérinaires)
        Me.Controls.Add(Me.BtnConnexion)
        Me.Name = "EcranVeterinaire"
        Me.Text = "Vétérinaires"
        Me.gbxVetérinaires.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnConnexion As System.Windows.Forms.Button
    Friend WithEvents lbxVeterinaires As System.Windows.Forms.ListBox
    Friend WithEvents gbxVetérinaires As System.Windows.Forms.GroupBox
    Friend WithEvents tbxMdp As System.Windows.Forms.TextBox
    Friend WithEvents lblVetérinaires As System.Windows.Forms.Label
    Friend WithEvents btnAjouterVeto As System.Windows.Forms.Button
    Friend WithEvents btnModifierVeto As System.Windows.Forms.Button
    Friend WithEvents btnSupprimerVeto As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
