<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranBareme
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
        Me.btnExporter = New System.Windows.Forms.Button()
        Me.btnImporter = New System.Windows.Forms.Button()
        Me.dataGridViewBareme = New System.Windows.Forms.DataGridView()
        Me.cbxTypeActe = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dataGridViewBareme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExporter
        '
        Me.btnExporter.Location = New System.Drawing.Point(12, 12)
        Me.btnExporter.Name = "btnExporter"
        Me.btnExporter.Size = New System.Drawing.Size(75, 23)
        Me.btnExporter.TabIndex = 0
        Me.btnExporter.Text = "Exporter"
        Me.btnExporter.UseVisualStyleBackColor = True
        '
        'btnImporter
        '
        Me.btnImporter.Location = New System.Drawing.Point(103, 12)
        Me.btnImporter.Name = "btnImporter"
        Me.btnImporter.Size = New System.Drawing.Size(75, 23)
        Me.btnImporter.TabIndex = 1
        Me.btnImporter.Text = "Importer"
        Me.btnImporter.UseVisualStyleBackColor = True
        '
        'dataGridViewBareme
        '
        Me.dataGridViewBareme.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewBareme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewBareme.Location = New System.Drawing.Point(12, 62)
        Me.dataGridViewBareme.Name = "dataGridViewBareme"
        Me.dataGridViewBareme.Size = New System.Drawing.Size(952, 344)
        Me.dataGridViewBareme.TabIndex = 2
        '
        'cbxTypeActe
        '
        Me.cbxTypeActe.FormattingEnabled = True
        Me.cbxTypeActe.Location = New System.Drawing.Point(843, 38)
        Me.cbxTypeActe.Name = "cbxTypeActe"
        Me.cbxTypeActe.Size = New System.Drawing.Size(121, 21)
        Me.cbxTypeActe.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(774, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Catégories :"
        '
        'EcranBareme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 418)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxTypeActe)
        Me.Controls.Add(Me.dataGridViewBareme)
        Me.Controls.Add(Me.btnImporter)
        Me.Controls.Add(Me.btnExporter)
        Me.Name = "EcranBareme"
        Me.Text = "Barèmes"
        CType(Me.dataGridViewBareme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExporter As System.Windows.Forms.Button
    Friend WithEvents btnImporter As System.Windows.Forms.Button
    Friend WithEvents dataGridViewBareme As System.Windows.Forms.DataGridView
    Friend WithEvents cbxTypeActe As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
