<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogAjoutVaccin
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
        Me.lbVaccin = New System.Windows.Forms.Label()
        Me.tbOldQuantite = New System.Windows.Forms.TextBox()
        Me.lblOldQt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudNewQt = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.nudNewQt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbVaccin
        '
        Me.lbVaccin.AutoSize = True
        Me.lbVaccin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVaccin.Location = New System.Drawing.Point(110, 9)
        Me.lbVaccin.Name = "lbVaccin"
        Me.lbVaccin.Size = New System.Drawing.Size(0, 25)
        Me.lbVaccin.TabIndex = 0
        '
        'tbOldQuantite
        '
        Me.tbOldQuantite.Location = New System.Drawing.Point(115, 45)
        Me.tbOldQuantite.Name = "tbOldQuantite"
        Me.tbOldQuantite.ReadOnly = True
        Me.tbOldQuantite.Size = New System.Drawing.Size(127, 20)
        Me.tbOldQuantite.TabIndex = 1
        '
        'lblOldQt
        '
        Me.lblOldQt.AutoSize = True
        Me.lblOldQt.Location = New System.Drawing.Point(12, 48)
        Me.lblOldQt.Name = "lblOldQt"
        Me.lblOldQt.Size = New System.Drawing.Size(53, 13)
        Me.lblOldQt.TabIndex = 3
        Me.lblOldQt.Text = "Quantité :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ajouter :"
        '
        'nudNewQt
        '
        Me.nudNewQt.Location = New System.Drawing.Point(115, 80)
        Me.nudNewQt.Name = "nudNewQt"
        Me.nudNewQt.Size = New System.Drawing.Size(127, 20)
        Me.nudNewQt.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(76, 129)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DialogAjoutVaccin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(292, 164)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.nudNewQt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOldQt)
        Me.Controls.Add(Me.tbOldQuantite)
        Me.Controls.Add(Me.lbVaccin)
        Me.Name = "DialogAjoutVaccin"
        Me.Text = "Ajout vaccins"
        CType(Me.nudNewQt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbVaccin As System.Windows.Forms.Label
    Friend WithEvents tbOldQuantite As System.Windows.Forms.TextBox
    Friend WithEvents lblOldQt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudNewQt As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
