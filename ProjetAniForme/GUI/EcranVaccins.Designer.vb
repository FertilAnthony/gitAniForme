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
        Me.DataGridViewVaccins = New System.Windows.Forms.DataGridView()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewVaccins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewVaccins
        '
        Me.DataGridViewVaccins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVaccins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVaccins.Location = New System.Drawing.Point(9, 100)
        Me.DataGridViewVaccins.Name = "DataGridViewVaccins"
        Me.DataGridViewVaccins.ReadOnly = True
        Me.DataGridViewVaccins.RowHeadersVisible = False
        Me.DataGridViewVaccins.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewVaccins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVaccins.Size = New System.Drawing.Size(494, 338)
        Me.DataGridViewVaccins.TabIndex = 33
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.GUI.My.Resources.Resources.gohome
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(231, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 51)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Home"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GUI.My.Resources.Resources._stop
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(158, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 51)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Supprimer"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Gestion des stocks de vaccins"
        '
        'EcranVaccins
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewVaccins)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EcranVaccins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des stocks de vaccins"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewVaccins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewVaccins As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
