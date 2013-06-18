<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranVaccins
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewVaccins = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewVaccins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.GUI.My.Resources.Resources.pencil
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(85, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 51)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Modifier"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GUI.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GUI.My.Resources.Resources.edittrash
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(158, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 51)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Supprimer"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.GUI.My.Resources.Resources._stop
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(231, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 51)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Sortir"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(304, 25)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Gestion des stocks de vaccins"
        '
        'DataGridViewVaccins
        '
        Me.DataGridViewVaccins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVaccins.Location = New System.Drawing.Point(9, 100)
        Me.DataGridViewVaccins.Name = "DataGridViewVaccins"
        Me.DataGridViewVaccins.Size = New System.Drawing.Size(301, 338)
        Me.DataGridViewVaccins.TabIndex = 33
        '
        'EcranVaccins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 446)
        Me.Controls.Add(Me.DataGridViewVaccins)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EcranVaccins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EcranVaccins"
        CType(Me.DataGridViewVaccins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewVaccins As System.Windows.Forms.DataGridView
End Class
