﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EcranClient))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxCodeClient = New System.Windows.Forms.TextBox()
        Me.tbxNomClient = New System.Windows.Forms.TextBox()
        Me.tbxPrenomClient = New System.Windows.Forms.TextBox()
        Me.tbxAdresseClient = New System.Windows.Forms.TextBox()
        Me.tbxCpClient = New System.Windows.Forms.TextBox()
        Me.tbxVilleClient = New System.Windows.Forms.TextBox()
        Me.tbxAssuranceClient = New System.Windows.Forms.TextBox()
        Me.tbxEmailClient = New System.Windows.Forms.TextBox()
        Me.dataGridViewAnimauxClient = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtboxTel = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dataGridViewAnimauxClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Prénom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Adresse :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Code postale :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(616, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Ville :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Assurance :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Email :"
        '
        'tbxCodeClient
        '
        Me.tbxCodeClient.Location = New System.Drawing.Point(132, 23)
        Me.tbxCodeClient.Name = "tbxCodeClient"
        Me.tbxCodeClient.ReadOnly = True
        Me.tbxCodeClient.Size = New System.Drawing.Size(166, 20)
        Me.tbxCodeClient.TabIndex = 20
        '
        'tbxNomClient
        '
        Me.tbxNomClient.Location = New System.Drawing.Point(132, 45)
        Me.tbxNomClient.Name = "tbxNomClient"
        Me.tbxNomClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxNomClient.TabIndex = 21
        '
        'tbxPrenomClient
        '
        Me.tbxPrenomClient.Location = New System.Drawing.Point(132, 69)
        Me.tbxPrenomClient.Name = "tbxPrenomClient"
        Me.tbxPrenomClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxPrenomClient.TabIndex = 22
        '
        'tbxAdresseClient
        '
        Me.tbxAdresseClient.Location = New System.Drawing.Point(482, 20)
        Me.tbxAdresseClient.Name = "tbxAdresseClient"
        Me.tbxAdresseClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxAdresseClient.TabIndex = 23
        '
        'tbxCpClient
        '
        Me.tbxCpClient.Location = New System.Drawing.Point(482, 50)
        Me.tbxCpClient.Name = "tbxCpClient"
        Me.tbxCpClient.Size = New System.Drawing.Size(100, 20)
        Me.tbxCpClient.TabIndex = 24
        '
        'tbxVilleClient
        '
        Me.tbxVilleClient.Location = New System.Drawing.Point(654, 50)
        Me.tbxVilleClient.Name = "tbxVilleClient"
        Me.tbxVilleClient.Size = New System.Drawing.Size(100, 20)
        Me.tbxVilleClient.TabIndex = 25
        '
        'tbxAssuranceClient
        '
        Me.tbxAssuranceClient.Location = New System.Drawing.Point(482, 77)
        Me.tbxAssuranceClient.Name = "tbxAssuranceClient"
        Me.tbxAssuranceClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxAssuranceClient.TabIndex = 26
        '
        'tbxEmailClient
        '
        Me.tbxEmailClient.Location = New System.Drawing.Point(132, 95)
        Me.tbxEmailClient.Name = "tbxEmailClient"
        Me.tbxEmailClient.Size = New System.Drawing.Size(204, 20)
        Me.tbxEmailClient.TabIndex = 27
        '
        'dataGridViewAnimauxClient
        '
        Me.dataGridViewAnimauxClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewAnimauxClient.Location = New System.Drawing.Point(22, 169)
        Me.dataGridViewAnimauxClient.Name = "dataGridViewAnimauxClient"
        Me.dataGridViewAnimauxClient.Size = New System.Drawing.Size(750, 150)
        Me.dataGridViewAnimauxClient.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Liste des annimaux du client :"
        '
        'txtboxTel
        '
        Me.txtboxTel.Location = New System.Drawing.Point(482, 103)
        Me.txtboxTel.Name = "txtboxTel"
        Me.txtboxTel.Size = New System.Drawing.Size(204, 20)
        Me.txtboxTel.TabIndex = 33
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(386, 106)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(28, 13)
        Me.lblTel.TabIndex = 32
        Me.lblTel.Text = "Tél :"
        '
        'Button11
        '
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(344, 45)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(20, 20)
        Me.Button11.TabIndex = 28
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.GUI.My.Resources.Resources.package_toys
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(714, 12)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(67, 51)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "Animaux"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.GUI.My.Resources.Resources.gohome
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(787, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 51)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Home"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.GUI.My.Resources.Resources._2rightarrow
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(641, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(67, 51)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Dernier"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.FlatAppearance.BorderSize = 0
        Me.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuivant.Image = Global.GUI.My.Resources.Resources._1rightarrow
        Me.btnSuivant.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSuivant.Location = New System.Drawing.Point(578, 12)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(67, 51)
        Me.btnSuivant.TabIndex = 8
        Me.btnSuivant.Text = "Suivant"
        Me.btnSuivant.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnPrecedent
        '
        Me.btnPrecedent.FlatAppearance.BorderSize = 0
        Me.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrecedent.Image = Global.GUI.My.Resources.Resources._1leftarrow
        Me.btnPrecedent.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrecedent.Location = New System.Drawing.Point(516, 12)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(67, 51)
        Me.btnPrecedent.TabIndex = 7
        Me.btnPrecedent.Text = "Précédent"
        Me.btnPrecedent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.GUI.My.Resources.Resources._2leftarrow
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(454, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 51)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Premier"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GUI.My.Resources.Resources.undo
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(381, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 51)
        Me.Button4.TabIndex = 5
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
        Me.Button3.Location = New System.Drawing.Point(317, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 51)
        Me.Button3.TabIndex = 4
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
        Me.Button2.Location = New System.Drawing.Point(255, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 51)
        Me.Button2.TabIndex = 3
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
        Me.Button1.Location = New System.Drawing.Point(193, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(406, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Gestion des clients"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtboxTel)
        Me.GroupBox1.Controls.Add(Me.lblTel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dataGridViewAnimauxClient)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.tbxEmailClient)
        Me.GroupBox1.Controls.Add(Me.tbxAssuranceClient)
        Me.GroupBox1.Controls.Add(Me.tbxVilleClient)
        Me.GroupBox1.Controls.Add(Me.tbxCpClient)
        Me.GroupBox1.Controls.Add(Me.tbxAdresseClient)
        Me.GroupBox1.Controls.Add(Me.tbxPrenomClient)
        Me.GroupBox1.Controls.Add(Me.tbxNomClient)
        Me.GroupBox1.Controls.Add(Me.tbxCodeClient)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 349)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'EcranClient
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EcranClient"
        Me.Text = "Clients"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dataGridViewAnimauxClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnPrecedent As System.Windows.Forms.Button
    Friend WithEvents btnSuivant As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbxCodeClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxNomClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxPrenomClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxAdresseClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxCpClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxVilleClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxAssuranceClient As System.Windows.Forms.TextBox
    Friend WithEvents tbxEmailClient As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents dataGridViewAnimauxClient As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtboxTel As System.Windows.Forms.TextBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
