<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSettings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btSistema = New System.Windows.Forms.Button()
        Me.btUsuarios = New System.Windows.Forms.Button()
        Me.btCampanhas = New System.Windows.Forms.Button()
        Me.btClientes = New System.Windows.Forms.Button()
        Me.btOperadores = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgGrid = New System.Windows.Forms.DataGridView()
        Me.colSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acao = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btSistema, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btUsuarios, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btCampanhas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btClientes, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btOperadores, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(828, 51)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btSistema
        '
        Me.btSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btSistema.FlatAppearance.BorderSize = 0
        Me.btSistema.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btSistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSistema.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btSistema.Location = New System.Drawing.Point(498, 3)
        Me.btSistema.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.btSistema.Name = "btSistema"
        Me.btSistema.Size = New System.Drawing.Size(159, 43)
        Me.btSistema.TabIndex = 7
        Me.btSistema.Text = "Configurações do sistema"
        Me.btSistema.UseVisualStyleBackColor = False
        '
        'btUsuarios
        '
        Me.btUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btUsuarios.FlatAppearance.BorderSize = 0
        Me.btUsuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUsuarios.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btUsuarios.Location = New System.Drawing.Point(663, 3)
        Me.btUsuarios.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.btUsuarios.Name = "btUsuarios"
        Me.btUsuarios.Size = New System.Drawing.Size(160, 43)
        Me.btUsuarios.TabIndex = 6
        Me.btUsuarios.Text = "Usuários"
        Me.btUsuarios.UseVisualStyleBackColor = False
        '
        'btCampanhas
        '
        Me.btCampanhas.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btCampanhas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btCampanhas.FlatAppearance.BorderSize = 0
        Me.btCampanhas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btCampanhas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btCampanhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCampanhas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCampanhas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btCampanhas.Location = New System.Drawing.Point(333, 3)
        Me.btCampanhas.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.btCampanhas.Name = "btCampanhas"
        Me.btCampanhas.Size = New System.Drawing.Size(159, 43)
        Me.btCampanhas.TabIndex = 5
        Me.btCampanhas.Text = "Cadastro de campanhas"
        Me.btCampanhas.UseVisualStyleBackColor = False
        '
        'btClientes
        '
        Me.btClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btClientes.FlatAppearance.BorderSize = 0
        Me.btClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btClientes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btClientes.Location = New System.Drawing.Point(5, 3)
        Me.btClientes.Margin = New System.Windows.Forms.Padding(5, 3, 3, 5)
        Me.btClientes.Name = "btClientes"
        Me.btClientes.Size = New System.Drawing.Size(157, 43)
        Me.btClientes.TabIndex = 4
        Me.btClientes.Text = "Lista de clientes"
        Me.btClientes.UseVisualStyleBackColor = False
        '
        'btOperadores
        '
        Me.btOperadores.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btOperadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btOperadores.FlatAppearance.BorderSize = 0
        Me.btOperadores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btOperadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btOperadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btOperadores.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOperadores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btOperadores.Location = New System.Drawing.Point(168, 3)
        Me.btOperadores.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.btOperadores.Name = "btOperadores"
        Me.btOperadores.Size = New System.Drawing.Size(159, 43)
        Me.btOperadores.TabIndex = 3
        Me.btOperadores.Text = "Ficha de operadores"
        Me.btOperadores.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgGrid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(828, 361)
        Me.Panel1.TabIndex = 3
        '
        'dgGrid
        '
        Me.dgGrid.AllowUserToAddRows = False
        Me.dgGrid.AllowUserToDeleteRows = False
        Me.dgGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgGrid.ColumnHeadersHeight = 31
        Me.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSel, Me.colID, Me.colStatus, Me.colOperador, Me.colRama, Me.colTempo, Me.Acao})
        Me.dgGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGrid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgGrid.Location = New System.Drawing.Point(5, 0)
        Me.dgGrid.Name = "dgGrid"
        Me.dgGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgGrid.RowHeadersVisible = False
        Me.dgGrid.RowTemplate.Height = 52
        Me.dgGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrid.Size = New System.Drawing.Size(818, 356)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colID.DefaultCellStyle = DataGridViewCellStyle1
        Me.colID.HeaderText = "Código"
        Me.colID.MinimumWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colID.Width = 70
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Foto"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colStatus.Width = 120
        '
        'colOperador
        '
        Me.colOperador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colOperador.DefaultCellStyle = DataGridViewCellStyle2
        Me.colOperador.HeaderText = "Nome"
        Me.colOperador.MinimumWidth = 70
        Me.colOperador.Name = "colOperador"
        '
        'colRama
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRama.DefaultCellStyle = DataGridViewCellStyle3
        Me.colRama.HeaderText = "Ramal"
        Me.colRama.MinimumWidth = 100
        Me.colRama.Name = "colRama"
        '
        'colTempo
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTempo.DefaultCellStyle = DataGridViewCellStyle4
        Me.colTempo.HeaderText = "Equipe"
        Me.colTempo.MinimumWidth = 70
        Me.colTempo.Name = "colTempo"
        Me.colTempo.Width = 120
        '
        'Acao
        '
        Me.Acao.HeaderText = "Ação"
        Me.Acao.MinimumWidth = 50
        Me.Acao.Name = "Acao"
        Me.Acao.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Acao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Acao.Text = ""
        Me.Acao.Width = 50
        '
        'ucSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ucSettings"
        Me.Size = New System.Drawing.Size(828, 412)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btOperadores As Button
    Friend WithEvents btSistema As Button
    Friend WithEvents btUsuarios As Button
    Friend WithEvents btCampanhas As Button
    Friend WithEvents btClientes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgGrid As DataGridView
    Friend WithEvents colSel As DataGridViewCheckBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewImageColumn
    Friend WithEvents colOperador As DataGridViewTextBoxColumn
    Friend WithEvents colRama As DataGridViewTextBoxColumn
    Friend WithEvents colTempo As DataGridViewTextBoxColumn
    Friend WithEvents Acao As DataGridViewButtonColumn
End Class
