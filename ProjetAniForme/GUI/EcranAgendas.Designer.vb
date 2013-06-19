<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranAgendas
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridViewAgendas = New System.Windows.Forms.DataGridView()
        Me.cbVeterinaires = New System.Windows.Forms.ComboBox()
        Me.dtAgendas = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewAgendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(480, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 51)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Consultation"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridViewAgendas
        '
        Me.DataGridViewAgendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAgendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewAgendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewAgendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAgendas.Location = New System.Drawing.Point(11, 19)
        Me.DataGridViewAgendas.Name = "DataGridViewAgendas"
        Me.DataGridViewAgendas.ReadOnly = True
        Me.DataGridViewAgendas.RowHeadersVisible = False
        Me.DataGridViewAgendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewAgendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAgendas.Size = New System.Drawing.Size(443, 400)
        Me.DataGridViewAgendas.TabIndex = 8
        '
        'cbVeterinaires
        '
        Me.cbVeterinaires.FormattingEnabled = True
        Me.cbVeterinaires.Location = New System.Drawing.Point(11, 19)
        Me.cbVeterinaires.Name = "cbVeterinaires"
        Me.cbVeterinaires.Size = New System.Drawing.Size(121, 21)
        Me.cbVeterinaires.TabIndex = 9
        '
        'dtAgendas
        '
        Me.dtAgendas.Location = New System.Drawing.Point(163, 19)
        Me.dtAgendas.Name = "dtAgendas"
        Me.dtAgendas.Size = New System.Drawing.Size(200, 20)
        Me.dtAgendas.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewAgendas)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 428)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agenda"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtAgendas)
        Me.GroupBox2.Controls.Add(Me.cbVeterinaires)
        Me.GroupBox2.Location = New System.Drawing.Point(118, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 52)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vétérinaire"
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.GUI.My.Resources.Resources.gohome
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(579, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(76, 51)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Home"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.GUI.My.Resources.Resources.kontact_journal
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(352, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 51)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Dossier Médical"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GUI.My.Resources.Resources._2rightarrow
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(269, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Dernier"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GUI.My.Resources.Resources._1rightarrow
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(177, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 51)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Suivant"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.GUI.My.Resources.Resources._1leftarrow
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(100, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Pécédent"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GUI.My.Resources.Resources._2leftarrow
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Premier"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Agendas"
        '
        'EcranAgendas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(667, 736)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EcranAgendas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Agendas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewAgendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewAgendas As System.Windows.Forms.DataGridView
    Friend WithEvents cbVeterinaires As System.Windows.Forms.ComboBox
    Friend WithEvents dtAgendas As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
