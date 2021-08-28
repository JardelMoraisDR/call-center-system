<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbValue = New System.Windows.Forms.Label()
        Me.lbLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbValue
        '
        Me.lbValue.AutoSize = True
        Me.lbValue.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbValue.Location = New System.Drawing.Point(9, 9)
        Me.lbValue.Name = "lbValue"
        Me.lbValue.Size = New System.Drawing.Size(97, 41)
        Me.lbValue.TabIndex = 6
        Me.lbValue.Text = "Sobre"
        '
        'lbLabel
        '
        Me.lbLabel.AutoSize = True
        Me.lbLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lbLabel.Location = New System.Drawing.Point(12, 60)
        Me.lbLabel.Name = "lbLabel"
        Me.lbLabel.Size = New System.Drawing.Size(384, 51)
        Me.lbLabel.TabIndex = 7
        Me.lbLabel.Text = "Desenvolvido por: Jardel Morais Dias Ribeiro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GitHub: https://github.com/JardelMo" &
    "raisDR/call-center-system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Icones: https://icons8.com.br/"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 156)
        Me.Controls.Add(Me.lbLabel)
        Me.Controls.Add(Me.lbValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbValue As Label
    Friend WithEvents lbLabel As Label
End Class
