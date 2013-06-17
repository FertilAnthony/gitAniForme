<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranAnimaux
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
        Me.btnAjouterAnimal = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnSupprimerAnimal = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxCodeClient = New System.Windows.Forms.TextBox()
        Me.tbxNomClient = New System.Windows.Forms.TextBox()
        Me.tbxPrenomClient = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxTatouageAnimal = New System.Windows.Forms.TextBox()
        Me.tbxCouleurAnimal = New System.Windows.Forms.TextBox()
        Me.tbxNomAnimal = New System.Windows.Forms.TextBox()
        Me.tbxCodeAnimal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxEspeceAnimal = New System.Windows.Forms.ComboBox()
        Me.cbxRaceAnimal = New System.Windows.Forms.ComboBox()
        Me.cbxSexeAnimal = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAjouterAnimal
        '
        Me.btnAjouterAnimal.FlatAppearance.BorderSize = 0
        Me.btnAjouterAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouterAnimal.Image = Global.GUI.My.Resources.Resources.add
        Me.btnAjouterAnimal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAjouterAnimal.Location = New System.Drawing.Point(12, 12)
        Me.btnAjouterAnimal.Name = "btnAjouterAnimal"
        Me.btnAjouterAnimal.Size = New System.Drawing.Size(67, 51)
        Me.btnAjouterAnimal.TabIndex = 2
        Me.btnAjouterAnimal.Text = "Ajouter"
        Me.btnAjouterAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAjouterAnimal.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.FlatAppearance.BorderSize = 0
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.Image = Global.GUI.My.Resources.Resources.filesave
        Me.btnModif.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModif.Location = New System.Drawing.Point(74, 12)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(67, 51)
        Me.btnModif.TabIndex = 3
        Me.btnModif.Text = "Enregistrer"
        Me.btnModif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnSupprimerAnimal
        '
        Me.btnSupprimerAnimal.FlatAppearance.BorderSize = 0
        Me.btnSupprimerAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerAnimal.Image = Global.GUI.My.Resources.Resources.edittrash
        Me.btnSupprimerAnimal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSupprimerAnimal.Location = New System.Drawing.Point(136, 12)
        Me.btnSupprimerAnimal.Name = "btnSupprimerAnimal"
        Me.btnSupprimerAnimal.Size = New System.Drawing.Size(67, 51)
        Me.btnSupprimerAnimal.TabIndex = 4
        Me.btnSupprimerAnimal.Text = "Supprimer"
        Me.btnSupprimerAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSupprimerAnimal.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GUI.My.Resources.Resources.cancel
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(200, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 51)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Anuler"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.GUI.My.Resources.Resources._2leftarrow
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(273, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 51)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Premier"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.GUI.My.Resources.Resources._1leftarrow
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(335, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 51)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Précédent"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.GUI.My.Resources.Resources._1rightarrow
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(397, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 51)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Suivant"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.GUI.My.Resources.Resources._2rightarrow
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(460, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(67, 51)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Dernier"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.GUI.My.Resources.Resources._stop
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(606, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 51)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Sortir"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Prénom :"
        '
        'tbxCodeClient
        '
        Me.tbxCodeClient.Location = New System.Drawing.Point(78, 40)
        Me.tbxCodeClient.Name = "tbxCodeClient"
        Me.tbxCodeClient.ReadOnly = True
        Me.tbxCodeClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxCodeClient.TabIndex = 20
        '
        'tbxNomClient
        '
        Me.tbxNomClient.Location = New System.Drawing.Point(345, 26)
        Me.tbxNomClient.Name = "tbxNomClient"
        Me.tbxNomClient.ReadOnly = True
        Me.tbxNomClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxNomClient.TabIndex = 21
        '
        'tbxPrenomClient
        '
        Me.tbxPrenomClient.Location = New System.Drawing.Point(345, 69)
        Me.tbxPrenomClient.Name = "tbxPrenomClient"
        Me.tbxPrenomClient.ReadOnly = True
        Me.tbxPrenomClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxPrenomClient.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 400)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 150)
        Me.DataGridView1.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Liste des annimaux du client :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(268, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 25)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Gestion des animaux"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbxCodeClient)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbxNomClient)
        Me.GroupBox1.Controls.Add(Me.tbxPrenomClient)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 100)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client"
        '
        'tbxTatouageAnimal
        '
        Me.tbxTatouageAnimal.Location = New System.Drawing.Point(80, 124)
        Me.tbxTatouageAnimal.Name = "tbxTatouageAnimal"
        Me.tbxTatouageAnimal.Size = New System.Drawing.Size(204, 20)
        Me.tbxTatouageAnimal.TabIndex = 33
        '
        'tbxCouleurAnimal
        '
        Me.tbxCouleurAnimal.Location = New System.Drawing.Point(80, 72)
        Me.tbxCouleurAnimal.Name = "tbxCouleurAnimal"
        Me.tbxCouleurAnimal.Size = New System.Drawing.Size(204, 20)
        Me.tbxCouleurAnimal.TabIndex = 34
        '
        'tbxNomAnimal
        '
        Me.tbxNomAnimal.Location = New System.Drawing.Point(80, 47)
        Me.tbxNomAnimal.Name = "tbxNomAnimal"
        Me.tbxNomAnimal.Size = New System.Drawing.Size(204, 20)
        Me.tbxNomAnimal.TabIndex = 35
        '
        'tbxCodeAnimal
        '
        Me.tbxCodeAnimal.Location = New System.Drawing.Point(78, 19)
        Me.tbxCodeAnimal.Name = "tbxCodeAnimal"
        Me.tbxCodeAnimal.ReadOnly = True
        Me.tbxCodeAnimal.Size = New System.Drawing.Size(204, 20)
        Me.tbxCodeAnimal.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Nom :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Tatouage :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Race :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(302, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Sexe :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Espèce :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Couleur :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Code :"
        '
        'cbxEspeceAnimal
        '
        Me.cbxEspeceAnimal.FormattingEnabled = True
        Me.cbxEspeceAnimal.Location = New System.Drawing.Point(80, 97)
        Me.cbxEspeceAnimal.Name = "cbxEspeceAnimal"
        Me.cbxEspeceAnimal.Size = New System.Drawing.Size(204, 21)
        Me.cbxEspeceAnimal.TabIndex = 44
        '
        'cbxRaceAnimal
        '
        Me.cbxRaceAnimal.FormattingEnabled = True
        Me.cbxRaceAnimal.Location = New System.Drawing.Point(347, 91)
        Me.cbxRaceAnimal.Name = "cbxRaceAnimal"
        Me.cbxRaceAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cbxRaceAnimal.TabIndex = 45
        '
        'cbxSexeAnimal
        '
        Me.cbxSexeAnimal.FormattingEnabled = True
        Me.cbxSexeAnimal.Items.AddRange(New Object() {"Sélectionnez ...", "Mâle - (M)", "Femelle - (F)", "Hemaphrodite - (H)"})
        Me.cbxSexeAnimal.Location = New System.Drawing.Point(347, 44)
        Me.cbxSexeAnimal.Name = "cbxSexeAnimal"
        Me.cbxSexeAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cbxSexeAnimal.TabIndex = 46
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxRaceAnimal)
        Me.GroupBox2.Controls.Add(Me.cbxSexeAnimal)
        Me.GroupBox2.Controls.Add(Me.tbxCodeAnimal)
        Me.GroupBox2.Controls.Add(Me.tbxNomAnimal)
        Me.GroupBox2.Controls.Add(Me.cbxEspeceAnimal)
        Me.GroupBox2.Controls.Add(Me.tbxCouleurAnimal)
        Me.GroupBox2.Controls.Add(Me.tbxTatouageAnimal)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 169)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Animaux"
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.GUI.My.Resources.Resources.kontact_contacts
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(533, 12)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(67, 51)
        Me.Button10.TabIndex = 48
        Me.Button10.Text = "Client"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = True
        '
        'EcranAnimaux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 592)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSupprimerAnimal)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnAjouterAnimal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EcranAnimaux"
        Me.Text = "EcranAnimaux"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAjouterAnimal As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnSupprimerAnimal As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxCodeClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxNomClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxPrenomClient As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbxTatouageAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxCouleurAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxNomAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxCodeAnimal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbxEspeceAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cbxRaceAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSexeAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
