<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenuChart
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMenuChart))
        Me.pnBackground = New System.Windows.Forms.Panel()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lbValue = New System.Windows.Forms.Label()
        Me.lbLabel = New System.Windows.Forms.Label()
        Me.pnBackground.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnBackground
        '
        Me.pnBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnBackground.Controls.Add(Me.pbIcon)
        Me.pnBackground.Controls.Add(Me.lbValue)
        Me.pnBackground.Controls.Add(Me.lbLabel)
        Me.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnBackground.Location = New System.Drawing.Point(0, 0)
        Me.pnBackground.Name = "pnBackground"
        Me.pnBackground.Size = New System.Drawing.Size(238, 101)
        Me.pnBackground.TabIndex = 2
        '
        'pbIcon
        '
        Me.pbIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbIcon.Image = CType(resources.GetObject("pbIcon.Image"), System.Drawing.Image)
        Me.pbIcon.Location = New System.Drawing.Point(140, 13)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(85, 74)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcon.TabIndex = 6
        Me.pbIcon.TabStop = False
        '
        'lbValue
        '
        Me.lbValue.AutoSize = True
        Me.lbValue.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbValue.Location = New System.Drawing.Point(12, 16)
        Me.lbValue.Name = "lbValue"
        Me.lbValue.Size = New System.Drawing.Size(68, 41)
        Me.lbValue.TabIndex = 5
        Me.lbValue.Text = "785"
        '
        'lbLabel
        '
        Me.lbLabel.AutoSize = True
        Me.lbLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lbLabel.Location = New System.Drawing.Point(12, 58)
        Me.lbLabel.Name = "lbLabel"
        Me.lbLabel.Size = New System.Drawing.Size(94, 17)
        Me.lbLabel.TabIndex = 4
        Me.lbLabel.Text = "Atendimentos"
        '
        'ucMenuChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnBackground)
        Me.Name = "ucMenuChart"
        Me.Size = New System.Drawing.Size(238, 101)
        Me.pnBackground.ResumeLayout(False)
        Me.pnBackground.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnBackground As Panel
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents lbValue As Label
    Friend WithEvents lbLabel As Label
End Class
