<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranConsultation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbxCodeAnimal = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbxPrixMax = New System.Windows.Forms.TextBox()
        Me.tbxPrix = New System.Windows.Forms.TextBox()
        Me.tbxPrixMin = New System.Windows.Forms.TextBox()
        Me.tbxVeterinaire = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.tbxTatouageAnimal = New System.Windows.Forms.TextBox()
        Me.tbxSexeAnimal = New System.Windows.Forms.TextBox()
        Me.tbxCouleurAnimal = New System.Windows.Forms.TextBox()
        Me.tbxRaceAnimal = New System.Windows.Forms.TextBox()
        Me.tbxEspeceAnimal = New System.Windows.Forms.TextBox()
        Me.tbxNomAnimal = New System.Windows.Forms.TextBox()
        Me.rTbxCommentaire = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbxTypeActe = New System.Windows.Forms.ComboBox()
        Me.cbxLibelleActe = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.acteNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Espèce :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Couleur :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nom :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Race :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sexe :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tatouage :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Commentaire :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Acte :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 417)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 402)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Vétérinaire :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(385, 402)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Type :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(385, 454)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Libellé :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(522, 473)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Prix :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(517, 443)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Maxi :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(461, 684)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Total consultation :"
        '
        'tbxCodeAnimal
        '
        Me.tbxCodeAnimal.Location = New System.Drawing.Point(69, 126)
        Me.tbxCodeAnimal.Name = "tbxCodeAnimal"
        Me.tbxCodeAnimal.ReadOnly = True
        Me.tbxCodeAnimal.Size = New System.Drawing.Size(100, 20)
        Me.tbxCodeAnimal.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(558, 681)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(83, 20)
        Me.TextBox3.TabIndex = 20
        '
        'tbxPrixMax
        '
        Me.tbxPrixMax.Location = New System.Drawing.Point(558, 447)
        Me.tbxPrixMax.Name = "tbxPrixMax"
        Me.tbxPrixMax.ReadOnly = True
        Me.tbxPrixMax.Size = New System.Drawing.Size(83, 20)
        Me.tbxPrixMax.TabIndex = 21
        '
        'tbxPrix
        '
        Me.tbxPrix.Location = New System.Drawing.Point(558, 473)
        Me.tbxPrix.Name = "tbxPrix"
        Me.tbxPrix.ReadOnly = True
        Me.tbxPrix.Size = New System.Drawing.Size(83, 20)
        Me.tbxPrix.TabIndex = 22
        '
        'tbxPrixMin
        '
        Me.tbxPrixMin.Location = New System.Drawing.Point(558, 414)
        Me.tbxPrixMin.Name = "tbxPrixMin"
        Me.tbxPrixMin.ReadOnly = True
        Me.tbxPrixMin.Size = New System.Drawing.Size(83, 20)
        Me.tbxPrixMin.TabIndex = 23
        '
        'tbxVeterinaire
        '
        Me.tbxVeterinaire.Location = New System.Drawing.Point(282, 418)
        Me.tbxVeterinaire.Name = "tbxVeterinaire"
        Me.tbxVeterinaire.ReadOnly = True
        Me.tbxVeterinaire.Size = New System.Drawing.Size(100, 20)
        Me.tbxVeterinaire.TabIndex = 24
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(66, 364)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(27, 20)
        Me.TextBox8.TabIndex = 25
        '
        'tbxTatouageAnimal
        '
        Me.tbxTatouageAnimal.Location = New System.Drawing.Point(233, 212)
        Me.tbxTatouageAnimal.Name = "tbxTatouageAnimal"
        Me.tbxTatouageAnimal.ReadOnly = True
        Me.tbxTatouageAnimal.Size = New System.Drawing.Size(100, 20)
        Me.tbxTatouageAnimal.TabIndex = 26
        '
        'tbxSexeAnimal
        '
        Me.tbxSexeAnimal.Location = New System.Drawing.Point(394, 173)
        Me.tbxSexeAnimal.Name = "tbxSexeAnimal"
        Me.tbxSexeAnimal.ReadOnly = True
        Me.tbxSexeAnimal.Size = New System.Drawing.Size(100, 20)
        Me.tbxSexeAnimal.TabIndex = 27
        '
        'tbxCouleurAnimal
        '
        Me.tbxCouleurAnimal.Location = New System.Drawing.Point(394, 126)
        Me.tbxCouleurAnimal.Name = "tbxCouleurAnimal"
        Me.tbxCouleurAnimal.ReadOnly = True
        Me.tbxCouleurAnimal.Size = New System.Drawing.Size(100, 20)
        Me.tbxCouleurAnimal.TabIndex = 28
        '
        'tbxRaceAnimal
        '
        Me.tbxRaceAnimal.Location = New System.Drawing.Point(233, 173)
        Me.tbxRaceAnimal.Name = "tbxRaceAnimal"
        Me.tbxRaceAnimal.ReadOnly = True
        Me.tbxRaceAnimal.Size = New System.Drawing.Size(100, 20)
        Me.tbxRaceAnimal.TabIndex = 29
        '
        'tbxEspeceAnimal
        '
        Me.tbxEspeceAnimal.Location = New System.Drawing.Point(233, 126)
        Me.tbxEspeceAnimal.Name = "tbxEspeceAnimal"
        Me.tbxEspeceAnimal.ReadOnly = True
        Me.tbxEspeceAnimal.Size = New System.Drawing.Size(100, 20)
        Me.tbxEspeceAnimal.TabIndex = 30
        '
        'tbxNomAnimal
        '
        Me.tbxNomAnimal.Location = New System.Drawing.Point(69, 173)
        Me.tbxNomAnimal.Name = "tbxNomAnimal"
        Me.tbxNomAnimal.ReadOnly = True
        Me.tbxNomAnimal.Size = New System.Drawing.Size(100, 20)
        Me.tbxNomAnimal.TabIndex = 31
        '
        'rTbxCommentaire
        '
        Me.rTbxCommentaire.Location = New System.Drawing.Point(123, 252)
        Me.rTbxCommentaire.Name = "rTbxCommentaire"
        Me.rTbxCommentaire.Size = New System.Drawing.Size(371, 96)
        Me.rTbxCommentaire.TabIndex = 32
        Me.rTbxCommentaire.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(66, 417)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'cbxTypeActe
        '
        Me.cbxTypeActe.Enabled = False
        Me.cbxTypeActe.FormattingEnabled = True
        Me.cbxTypeActe.Location = New System.Drawing.Point(388, 418)
        Me.cbxTypeActe.Name = "cbxTypeActe"
        Me.cbxTypeActe.Size = New System.Drawing.Size(121, 21)
        Me.cbxTypeActe.TabIndex = 34
        '
        'cbxLibelleActe
        '
        Me.cbxLibelleActe.Enabled = False
        Me.cbxLibelleActe.FormattingEnabled = True
        Me.cbxLibelleActe.Location = New System.Drawing.Point(388, 470)
        Me.cbxLibelleActe.Name = "cbxLibelleActe"
        Me.cbxLibelleActe.Size = New System.Drawing.Size(121, 21)
        Me.cbxLibelleActe.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(520, 417)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Mini :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acteNum, Me.type, Me.libelle, Me.prix})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 515)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(610, 150)
        Me.DataGridView1.TabIndex = 37
        '
        'acteNum
        '
        Me.acteNum.HeaderText = "Acte N°"
        Me.acteNum.Name = "acteNum"
        '
        'type
        '
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        '
        'libelle
        '
        Me.libelle.HeaderText = "Libellé"
        Me.libelle.Name = "libelle"
        '
        'prix
        '
        Me.prix.HeaderText = "Prix"
        Me.prix.Name = "prix"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 385)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(503, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 113)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 135)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(149, 88)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 47)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.GUI.My.Resources.Resources.gohome
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(328, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 51)
        Me.Button9.TabIndex = 45
        Me.Button9.Text = "Sortir"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.GUI.My.Resources.Resources.adept_commit
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(255, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 51)
        Me.Button5.TabIndex = 44
        Me.Button5.Text = "Valider"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GUI.My.Resources.Resources.undo
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(195, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 51)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Anuler"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GUI.My.Resources.Resources._stop
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(131, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 51)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Supprimer"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.GUI.My.Resources.Resources.filesave
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(69, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 51)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Enregistrer"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GUI.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(7, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 51)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(228, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 25)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Consultations"
        '
        'EcranConsultation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(653, 771)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cbxLibelleActe)
        Me.Controls.Add(Me.cbxTypeActe)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rTbxCommentaire)
        Me.Controls.Add(Me.tbxNomAnimal)
        Me.Controls.Add(Me.tbxEspeceAnimal)
        Me.Controls.Add(Me.tbxRaceAnimal)
        Me.Controls.Add(Me.tbxCouleurAnimal)
        Me.Controls.Add(Me.tbxSexeAnimal)
        Me.Controls.Add(Me.tbxTatouageAnimal)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.tbxVeterinaire)
        Me.Controls.Add(Me.tbxPrixMin)
        Me.Controls.Add(Me.tbxPrix)
        Me.Controls.Add(Me.tbxPrixMax)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.tbxCodeAnimal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "EcranConsultation"
        Me.Text = "Consultations"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbxCodeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents tbxPrixMax As System.Windows.Forms.TextBox
    Friend WithEvents tbxPrix As System.Windows.Forms.TextBox
    Friend WithEvents tbxPrixMin As System.Windows.Forms.TextBox
    Friend WithEvents tbxVeterinaire As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents tbxTatouageAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxSexeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxCouleurAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxRaceAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxEspeceAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxNomAnimal As System.Windows.Forms.TextBox
    Friend WithEvents rTbxCommentaire As System.Windows.Forms.RichTextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxTypeActe As System.Windows.Forms.ComboBox
    Friend WithEvents cbxLibelleActe As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents acteNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
