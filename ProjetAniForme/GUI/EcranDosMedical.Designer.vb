﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranDosMedical
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
        Me.btnRadioTous = New System.Windows.Forms.RadioButton()
        Me.radioBtnClient = New System.Windows.Forms.RadioButton()
        Me.cbxClient = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbxAnimaux = New System.Windows.Forms.ListBox()
        Me.btnDossierMed = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRadioTous
        '
        Me.btnRadioTous.AutoSize = True
        Me.btnRadioTous.Checked = True
        Me.btnRadioTous.Location = New System.Drawing.Point(403, 32)
        Me.btnRadioTous.Name = "btnRadioTous"
        Me.btnRadioTous.Size = New System.Drawing.Size(98, 17)
        Me.btnRadioTous.TabIndex = 17
        Me.btnRadioTous.TabStop = True
        Me.btnRadioTous.Text = "Tous les clients"
        Me.btnRadioTous.UseVisualStyleBackColor = True
        '
        'radioBtnClient
        '
        Me.radioBtnClient.AutoSize = True
        Me.radioBtnClient.Location = New System.Drawing.Point(403, 55)
        Me.radioBtnClient.Name = "radioBtnClient"
        Me.radioBtnClient.Size = New System.Drawing.Size(69, 17)
        Me.radioBtnClient.TabIndex = 18
        Me.radioBtnClient.Text = "Par client"
        Me.radioBtnClient.UseVisualStyleBackColor = True
        '
        'cbxClient
        '
        Me.cbxClient.FormattingEnabled = True
        Me.cbxClient.Location = New System.Drawing.Point(15, 23)
        Me.cbxClient.Name = "cbxClient"
        Me.cbxClient.Size = New System.Drawing.Size(163, 21)
        Me.cbxClient.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxClient)
        Me.GroupBox1.Location = New System.Drawing.Point(389, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 66)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'lbxAnimaux
        '
        Me.lbxAnimaux.FormattingEnabled = True
        Me.lbxAnimaux.Location = New System.Drawing.Point(53, 25)
        Me.lbxAnimaux.Name = "lbxAnimaux"
        Me.lbxAnimaux.Size = New System.Drawing.Size(282, 251)
        Me.lbxAnimaux.TabIndex = 25
        '
        'btnDossierMed
        '
        Me.btnDossierMed.FlatAppearance.BorderSize = 0
        Me.btnDossierMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDossierMed.Image = Global.GUI.My.Resources.Resources.kontact_journal
        Me.btnDossierMed.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDossierMed.Location = New System.Drawing.Point(447, 12)
        Me.btnDossierMed.Name = "btnDossierMed"
        Me.btnDossierMed.Size = New System.Drawing.Size(67, 67)
        Me.btnDossierMed.TabIndex = 24
        Me.btnDossierMed.Text = "Dossier Médical"
        Me.btnDossierMed.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDossierMed.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.GUI.My.Resources.Resources.gohome
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(520, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 55)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Home"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Recherche d'un dossier médical"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbxAnimaux)
        Me.GroupBox2.Controls.Add(Me.radioBtnClient)
        Me.GroupBox2.Controls.Add(Me.btnRadioTous)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(189, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 320)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'EcranDosMedical
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDossierMed)
        Me.Controls.Add(Me.Button9)
        Me.Name = "EcranDosMedical"
        Me.Text = "Dossier médical"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btnRadioTous As System.Windows.Forms.RadioButton
    Friend WithEvents radioBtnClient As System.Windows.Forms.RadioButton
    Friend WithEvents cbxClient As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDossierMed As System.Windows.Forms.Button
    Friend WithEvents lbxAnimaux As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
