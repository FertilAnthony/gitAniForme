<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogAjoutAnimal
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cbxRaceAnimal = New System.Windows.Forms.ComboBox()
        Me.cbxSexeAnimal = New System.Windows.Forms.ComboBox()
        Me.tbxNomAnimal = New System.Windows.Forms.TextBox()
        Me.cbxEspeceAnimal = New System.Windows.Forms.ComboBox()
        Me.tbxCouleurAnimal = New System.Windows.Forms.TextBox()
        Me.tbxTatouageAnimal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(444, 190)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'cbxRaceAnimal
        '
        Me.cbxRaceAnimal.FormattingEnabled = True
        Me.cbxRaceAnimal.Location = New System.Drawing.Point(353, 113)
        Me.cbxRaceAnimal.Name = "cbxRaceAnimal"
        Me.cbxRaceAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cbxRaceAnimal.TabIndex = 51
        '
        'cbxSexeAnimal
        '
        Me.cbxSexeAnimal.FormattingEnabled = True
        Me.cbxSexeAnimal.Items.AddRange(New Object() {"Sélectionnez ...", "Mâle - (M)", "Femelle - (F)", "Hemaphrodite - (H)"})
        Me.cbxSexeAnimal.Location = New System.Drawing.Point(353, 87)
        Me.cbxSexeAnimal.Name = "cbxSexeAnimal"
        Me.cbxSexeAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cbxSexeAnimal.TabIndex = 52
        '
        'tbxNomAnimal
        '
        Me.tbxNomAnimal.Location = New System.Drawing.Point(77, 61)
        Me.tbxNomAnimal.Name = "tbxNomAnimal"
        Me.tbxNomAnimal.Size = New System.Drawing.Size(204, 20)
        Me.tbxNomAnimal.TabIndex = 49
        '
        'cbxEspeceAnimal
        '
        Me.cbxEspeceAnimal.FormattingEnabled = True
        Me.cbxEspeceAnimal.Location = New System.Drawing.Point(77, 113)
        Me.cbxEspeceAnimal.Name = "cbxEspeceAnimal"
        Me.cbxEspeceAnimal.Size = New System.Drawing.Size(204, 21)
        Me.cbxEspeceAnimal.TabIndex = 50
        '
        'tbxCouleurAnimal
        '
        Me.tbxCouleurAnimal.Location = New System.Drawing.Point(77, 87)
        Me.tbxCouleurAnimal.Name = "tbxCouleurAnimal"
        Me.tbxCouleurAnimal.Size = New System.Drawing.Size(204, 20)
        Me.tbxCouleurAnimal.TabIndex = 48
        '
        'tbxTatouageAnimal
        '
        Me.tbxTatouageAnimal.Location = New System.Drawing.Point(77, 139)
        Me.tbxTatouageAnimal.Name = "tbxTatouageAnimal"
        Me.tbxTatouageAnimal.Size = New System.Drawing.Size(204, 20)
        Me.tbxTatouageAnimal.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Nom :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Couleur :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Espèce :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Tatouage :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(310, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Sexe :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Race :"
        '
        'DialogAjoutAnimal
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(602, 231)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxRaceAnimal)
        Me.Controls.Add(Me.cbxSexeAnimal)
        Me.Controls.Add(Me.tbxNomAnimal)
        Me.Controls.Add(Me.cbxEspeceAnimal)
        Me.Controls.Add(Me.tbxCouleurAnimal)
        Me.Controls.Add(Me.tbxTatouageAnimal)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogAjoutAnimal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajout d'un animal"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cbxRaceAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSexeAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNomAnimal As System.Windows.Forms.TextBox
    Friend WithEvents cbxEspeceAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents tbxCouleurAnimal As System.Windows.Forms.TextBox
    Friend WithEvents tbxTatouageAnimal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
