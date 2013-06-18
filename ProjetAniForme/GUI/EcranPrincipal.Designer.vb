<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranPrincipal
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnDosMedical = New System.Windows.Forms.Button()
        Me.btnAgendas = New System.Windows.Forms.Button()
        Me.btnRelances = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnRdv = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SecrétériatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriseDeRendezvousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DossierClientAnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiseÀJourDuStockDeVaccinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VétérinaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DossiersMédicauxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamétrageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VétérinairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiseÀJourDuBarèmeDeTarificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListView1.Location = New System.Drawing.Point(0, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 643)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(768, 485)
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnQuitter.Image = Global.GUI.My.Resources.Resources.logout
        Me.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQuitter.Location = New System.Drawing.Point(12, 532)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(95, 91)
        Me.btnQuitter.TabIndex = 9
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'btnDosMedical
        '
        Me.btnDosMedical.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDosMedical.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnDosMedical.FlatAppearance.BorderSize = 0
        Me.btnDosMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDosMedical.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDosMedical.Image = Global.GUI.My.Resources.Resources.kwrite
        Me.btnDosMedical.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDosMedical.Location = New System.Drawing.Point(12, 435)
        Me.btnDosMedical.Name = "btnDosMedical"
        Me.btnDosMedical.Size = New System.Drawing.Size(95, 91)
        Me.btnDosMedical.TabIndex = 8
        Me.btnDosMedical.Text = "Dossier Médical"
        Me.btnDosMedical.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDosMedical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDosMedical.UseVisualStyleBackColor = False
        '
        'btnAgendas
        '
        Me.btnAgendas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAgendas.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgendas.FlatAppearance.BorderSize = 0
        Me.btnAgendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgendas.Image = Global.GUI.My.Resources.Resources.Calenders
        Me.btnAgendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgendas.Location = New System.Drawing.Point(12, 333)
        Me.btnAgendas.Name = "btnAgendas"
        Me.btnAgendas.Size = New System.Drawing.Size(95, 96)
        Me.btnAgendas.TabIndex = 7
        Me.btnAgendas.Text = "Agendas"
        Me.btnAgendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAgendas.UseVisualStyleBackColor = False
        '
        'btnRelances
        '
        Me.btnRelances.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRelances.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRelances.FlatAppearance.BorderSize = 0
        Me.btnRelances.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelances.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRelances.Image = Global.GUI.My.Resources.Resources.evolution
        Me.btnRelances.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRelances.Location = New System.Drawing.Point(12, 231)
        Me.btnRelances.Name = "btnRelances"
        Me.btnRelances.Size = New System.Drawing.Size(95, 96)
        Me.btnRelances.TabIndex = 6
        Me.btnRelances.Text = "Relances"
        Me.btnRelances.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRelances.UseVisualStyleBackColor = False
        '
        'btnClient
        '
        Me.btnClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClient.FlatAppearance.BorderSize = 0
        Me.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClient.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClient.Image = Global.GUI.My.Resources.Resources.Login_Manager
        Me.btnClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClient.Location = New System.Drawing.Point(12, 129)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(95, 96)
        Me.btnClient.TabIndex = 5
        Me.btnClient.Text = "Clients/Animaux"
        Me.btnClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClient.UseVisualStyleBackColor = False
        '
        'btnRdv
        '
        Me.btnRdv.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRdv.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRdv.FlatAppearance.BorderSize = 0
        Me.btnRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRdv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRdv.Image = Global.GUI.My.Resources.Resources.kontact_date1
        Me.btnRdv.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRdv.Location = New System.Drawing.Point(12, 27)
        Me.btnRdv.Name = "btnRdv"
        Me.btnRdv.Size = New System.Drawing.Size(95, 96)
        Me.btnRdv.TabIndex = 4
        Me.btnRdv.Text = "Rendez-vous"
        Me.btnRdv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRdv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRdv.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.MenuStrip1.BackgroundImage = Global.GUI.My.Resources.Resources.strilles
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecrétériatToolStripMenuItem, Me.VétérinaireToolStripMenuItem, Me.ParamétrageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(950, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SecrétériatToolStripMenuItem
        '
        Me.SecrétériatToolStripMenuItem.Checked = True
        Me.SecrétériatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.SecrétériatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PriseDeRendezvousToolStripMenuItem, Me.DossierClientAnimalToolStripMenuItem, Me.RelancesToolStripMenuItem, Me.MiseÀJourDuStockDeVaccinsToolStripMenuItem})
        Me.SecrétériatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SecrétériatToolStripMenuItem.Name = "SecrétériatToolStripMenuItem"
        Me.SecrétériatToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SecrétériatToolStripMenuItem.Text = "Secrétériat"
        '
        'PriseDeRendezvousToolStripMenuItem
        '
        Me.PriseDeRendezvousToolStripMenuItem.Name = "PriseDeRendezvousToolStripMenuItem"
        Me.PriseDeRendezvousToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.PriseDeRendezvousToolStripMenuItem.Text = "Prise de Rendez-vous"
        '
        'DossierClientAnimalToolStripMenuItem
        '
        Me.DossierClientAnimalToolStripMenuItem.Name = "DossierClientAnimalToolStripMenuItem"
        Me.DossierClientAnimalToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.DossierClientAnimalToolStripMenuItem.Text = "Dossiers Client/Animal"
        '
        'RelancesToolStripMenuItem
        '
        Me.RelancesToolStripMenuItem.Name = "RelancesToolStripMenuItem"
        Me.RelancesToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RelancesToolStripMenuItem.Text = "Relances"
        '
        'MiseÀJourDuStockDeVaccinsToolStripMenuItem
        '
        Me.MiseÀJourDuStockDeVaccinsToolStripMenuItem.Name = "MiseÀJourDuStockDeVaccinsToolStripMenuItem"
        Me.MiseÀJourDuStockDeVaccinsToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.MiseÀJourDuStockDeVaccinsToolStripMenuItem.Text = "Gestion des stocks de vaccins"
        '
        'VétérinaireToolStripMenuItem
        '
        Me.VétérinaireToolStripMenuItem.Checked = True
        Me.VétérinaireToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.VétérinaireToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendaToolStripMenuItem, Me.DossiersMédicauxToolStripMenuItem})
        Me.VétérinaireToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VétérinaireToolStripMenuItem.Name = "VétérinaireToolStripMenuItem"
        Me.VétérinaireToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.VétérinaireToolStripMenuItem.Text = "Vétérinaire"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'DossiersMédicauxToolStripMenuItem
        '
        Me.DossiersMédicauxToolStripMenuItem.Name = "DossiersMédicauxToolStripMenuItem"
        Me.DossiersMédicauxToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DossiersMédicauxToolStripMenuItem.Text = "Dossiers Médicaux"
        '
        'ParamétrageToolStripMenuItem
        '
        Me.ParamétrageToolStripMenuItem.Checked = True
        Me.ParamétrageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ParamétrageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VétérinairesToolStripMenuItem, Me.MiseÀJourDuBarèmeDeTarificationToolStripMenuItem})
        Me.ParamétrageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ParamétrageToolStripMenuItem.Name = "ParamétrageToolStripMenuItem"
        Me.ParamétrageToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ParamétrageToolStripMenuItem.Text = "Paramétrage"
        '
        'VétérinairesToolStripMenuItem
        '
        Me.VétérinairesToolStripMenuItem.Name = "VétérinairesToolStripMenuItem"
        Me.VétérinairesToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.VétérinairesToolStripMenuItem.Text = "Vétérinaires"
        '
        'MiseÀJourDuBarèmeDeTarificationToolStripMenuItem
        '
        Me.MiseÀJourDuBarèmeDeTarificationToolStripMenuItem.Name = "MiseÀJourDuBarèmeDeTarificationToolStripMenuItem"
        Me.MiseÀJourDuBarèmeDeTarificationToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.MiseÀJourDuBarèmeDeTarificationToolStripMenuItem.Text = "Mise à jour du barème de tarification"
        '
        'EcranPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(950, 667)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnDosMedical)
        Me.Controls.Add(Me.btnAgendas)
        Me.Controls.Add(Me.btnRelances)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.btnRdv)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EcranPrincipal"
        Me.Text = "Clinique Vétérinaire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnRdv As System.Windows.Forms.Button
    Friend WithEvents btnClient As System.Windows.Forms.Button
    Friend WithEvents btnRelances As System.Windows.Forms.Button
    Friend WithEvents btnAgendas As System.Windows.Forms.Button
    Friend WithEvents btnDosMedical As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents SecrétériatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriseDeRendezvousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DossierClientAnimalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelancesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiseÀJourDuStockDeVaccinsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VétérinaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DossiersMédicauxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParamétrageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VétérinairesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiseÀJourDuBarèmeDeTarificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel

End Class
