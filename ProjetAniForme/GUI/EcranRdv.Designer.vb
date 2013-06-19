<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranRdv
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
        Me.cbxVeterinaire = New System.Windows.Forms.ComboBox()
        Me.cbxAnimalClient = New System.Windows.Forms.ComboBox()
        Me.cbxClient = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.heure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomDuClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.race = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAjouterRdv = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gestion des rendez-vous "
        '
        'cbxVeterinaire
        '
        Me.cbxVeterinaire.FormattingEnabled = True
        Me.cbxVeterinaire.Location = New System.Drawing.Point(36, 151)
        Me.cbxVeterinaire.Name = "cbxVeterinaire"
        Me.cbxVeterinaire.Size = New System.Drawing.Size(121, 21)
        Me.cbxVeterinaire.TabIndex = 9
        '
        'cbxAnimalClient
        '
        Me.cbxAnimalClient.FormattingEnabled = True
        Me.cbxAnimalClient.Location = New System.Drawing.Point(410, 229)
        Me.cbxAnimalClient.Name = "cbxAnimalClient"
        Me.cbxAnimalClient.Size = New System.Drawing.Size(121, 21)
        Me.cbxAnimalClient.TabIndex = 10
        '
        'cbxClient
        '
        Me.cbxClient.FormattingEnabled = True
        Me.cbxClient.Location = New System.Drawing.Point(410, 173)
        Me.cbxClient.Name = "cbxClient"
        Me.cbxClient.Size = New System.Drawing.Size(121, 21)
        Me.cbxClient.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 151)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(176, 207)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(48, 21)
        Me.ComboBox4.TabIndex = 13
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(230, 207)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(45, 21)
        Me.ComboBox5.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Vétérinaire"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date du rendez-vous"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(52, 208)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "Urgence"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Heure du rendez-vous"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nouveau rendez-vous"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(407, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Client concerné"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(407, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Animal"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.heure, Me.nomDuClient, Me.animal, Me.race})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 278)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(452, 294)
        Me.DataGridView1.TabIndex = 22
        '
        'heure
        '
        Me.heure.HeaderText = "Heure"
        Me.heure.Name = "heure"
        '
        'nomDuClient
        '
        Me.nomDuClient.HeaderText = "Nom du client"
        Me.nomDuClient.Name = "nomDuClient"
        '
        'animal
        '
        Me.animal.HeaderText = "Animal"
        Me.animal.Name = "animal"
        '
        'race
        '
        Me.race.HeaderText = "Race"
        Me.race.Name = "race"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Agenda"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(631, 573)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 392
        Me.LineShape1.X2 = 392
        Me.LineShape1.Y1 = 127
        Me.LineShape1.Y2 = 252
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.GUI.My.Resources.Resources._stop
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(450, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 51)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Sortir"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.GUI.My.Resources.Resources.package_toys
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(359, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 51)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Animaux"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.GUI.My.Resources.Resources.kontact_contacts
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(295, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 51)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Clients"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GUI.My.Resources.Resources.cancel
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(204, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 51)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Annuler"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GUI.My.Resources.Resources.edittrash
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(140, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 51)
        Me.Button3.TabIndex = 3
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
        Me.Button2.Location = New System.Drawing.Point(76, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 51)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Enregistrer"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAjouterRdv
        '
        Me.btnAjouterRdv.FlatAppearance.BorderSize = 0
        Me.btnAjouterRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouterRdv.Image = Global.GUI.My.Resources.Resources.add
        Me.btnAjouterRdv.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAjouterRdv.Location = New System.Drawing.Point(12, 12)
        Me.btnAjouterRdv.Name = "btnAjouterRdv"
        Me.btnAjouterRdv.Size = New System.Drawing.Size(67, 51)
        Me.btnAjouterRdv.TabIndex = 1
        Me.btnAjouterRdv.Text = "Ajouter"
        Me.btnAjouterRdv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAjouterRdv.UseVisualStyleBackColor = True
        '
        'EcranRdv
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(631, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cbxClient)
        Me.Controls.Add(Me.cbxAnimalClient)
        Me.Controls.Add(Me.cbxVeterinaire)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAjouterRdv)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "EcranRdv"
        Me.Text = "EcranRdv"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAjouterRdv As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxVeterinaire As System.Windows.Forms.ComboBox
    Friend WithEvents cbxAnimalClient As System.Windows.Forms.ComboBox
    Friend WithEvents cbxClient As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents heure As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomDuClient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents animal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents race As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
