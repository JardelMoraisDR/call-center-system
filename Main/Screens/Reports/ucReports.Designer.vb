<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucReports
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btVendas = New System.Windows.Forms.Button()
        Me.btRepresentantes = New System.Windows.Forms.Button()
        Me.btCampanha = New System.Windows.Forms.Button()
        Me.btTempo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgGrid = New System.Windows.Forms.DataGridView()
        Me.colSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbReportDescription = New System.Windows.Forms.Label()
        Me.lbReport = New System.Windows.Forms.Label()
        Me.pnBottom = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.pnDiv1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btVendas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btRepresentantes, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btCampanha, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btTempo, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(229, 436)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btVendas
        '
        Me.btVendas.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btVendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btVendas.FlatAppearance.BorderSize = 0
        Me.btVendas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVendas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVendas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btVendas.Location = New System.Drawing.Point(5, 5)
        Me.btVendas.Margin = New System.Windows.Forms.Padding(5, 5, 3, 5)
        Me.btVendas.Name = "btVendas"
        Me.btVendas.Size = New System.Drawing.Size(221, 60)
        Me.btVendas.TabIndex = 3
        Me.btVendas.Text = "Vendas diárias"
        Me.btVendas.UseVisualStyleBackColor = False
        '
        'btRepresentantes
        '
        Me.btRepresentantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btRepresentantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btRepresentantes.FlatAppearance.BorderSize = 0
        Me.btRepresentantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btRepresentantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btRepresentantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRepresentantes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRepresentantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btRepresentantes.Location = New System.Drawing.Point(5, 75)
        Me.btRepresentantes.Margin = New System.Windows.Forms.Padding(5, 5, 3, 5)
        Me.btRepresentantes.Name = "btRepresentantes"
        Me.btRepresentantes.Size = New System.Drawing.Size(221, 60)
        Me.btRepresentantes.TabIndex = 4
        Me.btRepresentantes.Text = "Relação de vendas por representantes"
        Me.btRepresentantes.UseVisualStyleBackColor = False
        '
        'btCampanha
        '
        Me.btCampanha.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btCampanha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btCampanha.FlatAppearance.BorderSize = 0
        Me.btCampanha.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btCampanha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btCampanha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCampanha.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCampanha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btCampanha.Location = New System.Drawing.Point(5, 145)
        Me.btCampanha.Margin = New System.Windows.Forms.Padding(5, 5, 3, 5)
        Me.btCampanha.Name = "btCampanha"
        Me.btCampanha.Size = New System.Drawing.Size(221, 60)
        Me.btCampanha.TabIndex = 5
        Me.btCampanha.Text = "Relação de vendas por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "campanha"
        Me.btCampanha.UseVisualStyleBackColor = False
        '
        'btTempo
        '
        Me.btTempo.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btTempo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btTempo.FlatAppearance.BorderSize = 0
        Me.btTempo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btTempo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTempo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTempo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btTempo.Location = New System.Drawing.Point(5, 215)
        Me.btTempo.Margin = New System.Windows.Forms.Padding(5, 5, 3, 5)
        Me.btTempo.Name = "btTempo"
        Me.btTempo.Size = New System.Drawing.Size(221, 60)
        Me.btTempo.TabIndex = 6
        Me.btTempo.Text = "Relação de tempo em linha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por operador"
        Me.btTempo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgGrid)
        Me.Panel1.Controls.Add(Me.lbReportDescription)
        Me.Panel1.Controls.Add(Me.lbReport)
        Me.Panel1.Controls.Add(Me.pnBottom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(229, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(563, 436)
        Me.Panel1.TabIndex = 4
        '
        'dgGrid
        '
        Me.dgGrid.AllowUserToAddRows = False
        Me.dgGrid.AllowUserToDeleteRows = False
        Me.dgGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgGrid.ColumnHeadersHeight = 31
        Me.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSel, Me.colID, Me.colOperador, Me.colRama, Me.colTempo, Me.Acao})
        Me.dgGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGrid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgGrid.Location = New System.Drawing.Point(5, 49)
        Me.dgGrid.Name = "dgGrid"
        Me.dgGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgGrid.RowHeadersVisible = False
        Me.dgGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrid.Size = New System.Drawing.Size(553, 351)
        Me.dgGrid.TabIndex = 1
        '
        'colSel
        '
        Me.colSel.HeaderText = "N/D"
        Me.colSel.MinimumWidth = 50
        Me.colSel.Name = "colSel"
        Me.colSel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSel.Width = 50
        '
        'colID
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colID.DefaultCellStyle = DataGridViewCellStyle6
        Me.colID.HeaderText = "Código"
        Me.colID.MinimumWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colID.Width = 70
        '
        'colOperador
        '
        Me.colOperador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colOperador.DefaultCellStyle = DataGridViewCellStyle7
        Me.colOperador.HeaderText = "Representante"
        Me.colOperador.MinimumWidth = 70
        Me.colOperador.Name = "colOperador"
        '
        'colRama
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRama.DefaultCellStyle = DataGridViewCellStyle8
        Me.colRama.HeaderText = "Ligação"
        Me.colRama.MinimumWidth = 70
        Me.colRama.Name = "colRama"
        Me.colRama.Width = 70
        '
        'colTempo
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTempo.DefaultCellStyle = DataGridViewCellStyle9
        Me.colTempo.HeaderText = "Data"
        Me.colTempo.MinimumWidth = 100
        Me.colTempo.Name = "colTempo"
        '
        'Acao
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Acao.DefaultCellStyle = DataGridViewCellStyle10
        Me.Acao.HeaderText = "Total"
        Me.Acao.MinimumWidth = 50
        Me.Acao.Name = "Acao"
        Me.Acao.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Acao.Width = 50
        '
        'lbReportDescription
        '
        Me.lbReportDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbReportDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReportDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbReportDescription.Location = New System.Drawing.Point(5, 27)
        Me.lbReportDescription.Name = "lbReportDescription"
        Me.lbReportDescription.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lbReportDescription.Size = New System.Drawing.Size(553, 22)
        Me.lbReportDescription.TabIndex = 11
        Me.lbReportDescription.Text = "Este relatório relaciona as vendas diárias do mês"
        '
        'lbReport
        '
        Me.lbReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbReport.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbReport.Location = New System.Drawing.Point(5, 0)
        Me.lbReport.Name = "lbReport"
        Me.lbReport.Size = New System.Drawing.Size(553, 27)
        Me.lbReport.TabIndex = 10
        Me.lbReport.Text = "Vendas diárias"
        '
        'pnBottom
        '
        Me.pnBottom.Controls.Add(Me.Button5)
        Me.pnBottom.Controls.Add(Me.pnDiv1)
        Me.pnBottom.Controls.Add(Me.Button4)
        Me.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnBottom.Location = New System.Drawing.Point(5, 400)
        Me.pnBottom.Name = "pnBottom"
        Me.pnBottom.Size = New System.Drawing.Size(553, 31)
        Me.pnBottom.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(185, 0)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5, 5, 3, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 31)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Gerar PDF"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'pnDiv1
        '
        Me.pnDiv1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnDiv1.Location = New System.Drawing.Point(365, 0)
        Me.pnDiv1.Name = "pnDiv1"
        Me.pnDiv1.Size = New System.Drawing.Size(8, 31)
        Me.pnDiv1.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(373, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 5, 3, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 31)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Imprimir"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ucReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ucReports"
        Me.Size = New System.Drawing.Size(792, 436)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btVendas As Button
    Friend WithEvents btRepresentantes As Button
    Friend WithEvents btCampanha As Button
    Friend WithEvents btTempo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnBottom As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents dgGrid As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents pnDiv1 As Panel
    Friend WithEvents lbReport As Label
    Friend WithEvents colSel As DataGridViewCheckBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colOperador As DataGridViewTextBoxColumn
    Friend WithEvents colRama As DataGridViewTextBoxColumn
    Friend WithEvents colTempo As DataGridViewTextBoxColumn
    Friend WithEvents Acao As DataGridViewTextBoxColumn
    Friend WithEvents lbReportDescription As Label
End Class
