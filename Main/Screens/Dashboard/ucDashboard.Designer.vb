<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDashboard))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.colSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colTempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcMenuChart5 = New Components.ucMenuChart()
        Me.UcMenuChart4 = New Components.ucMenuChart()
        Me.UcMenuChart3 = New Components.ucMenuChart()
        Me.UcMenuChart2 = New Components.ucMenuChart()
        Me.UcMenuChart1 = New Components.ucMenuChart()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.UcMenuChart5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UcMenuChart4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UcMenuChart3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UcMenuChart2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UcMenuChart1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1171, 102)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgGrid
        '
        Me.dgGrid.AllowUserToAddRows = False
        Me.dgGrid.AllowUserToDeleteRows = False
        Me.dgGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgGrid.ColumnHeadersHeight = 31
        Me.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSel, Me.colID, Me.colOperador, Me.colRama, Me.colStatus, Me.colTempo, Me.colTelefone})
        Me.dgGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGrid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgGrid.Location = New System.Drawing.Point(5, 0)
        Me.dgGrid.Name = "dgGrid"
        Me.dgGrid.RowHeadersVisible = False
        Me.dgGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrid.Size = New System.Drawing.Size(1161, 332)
        Me.dgGrid.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgGrid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(1171, 337)
        Me.Panel1.TabIndex = 2
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
        Me.colID.DataPropertyName = "colID"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colID.DefaultCellStyle = DataGridViewCellStyle6
        Me.colID.HeaderText = "Código"
        Me.colID.MinimumWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colID.Width = 70
        '
        'colOperador
        '
        Me.colOperador.DataPropertyName = "colOperador"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colOperador.DefaultCellStyle = DataGridViewCellStyle7
        Me.colOperador.HeaderText = "Operador"
        Me.colOperador.MinimumWidth = 70
        Me.colOperador.Name = "colOperador"
        Me.colOperador.Width = 150
        '
        'colRama
        '
        Me.colRama.DataPropertyName = "colRama"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRama.DefaultCellStyle = DataGridViewCellStyle8
        Me.colRama.HeaderText = "Ramal"
        Me.colRama.MinimumWidth = 100
        Me.colRama.Name = "colRama"
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "colStatus"
        Me.colStatus.HeaderText = "Situação"
        Me.colStatus.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 110
        '
        'colTempo
        '
        Me.colTempo.DataPropertyName = "colTempo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTempo.DefaultCellStyle = DataGridViewCellStyle9
        Me.colTempo.HeaderText = "Tempo em linha"
        Me.colTempo.MinimumWidth = 70
        Me.colTempo.Name = "colTempo"
        Me.colTempo.Width = 120
        '
        'colTelefone
        '
        Me.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTelefone.DataPropertyName = "colTelefone"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colTelefone.DefaultCellStyle = DataGridViewCellStyle10
        Me.colTelefone.HeaderText = "Falando com"
        Me.colTelefone.Name = "colTelefone"
        '
        'UcMenuChart5
        '
        Me.UcMenuChart5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuChart5.Location = New System.Drawing.Point(936, 5)
        Me.UcMenuChart5.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.UcMenuChart5.MyIcon = CType(resources.GetObject("UcMenuChart5.MyIcon"), System.Drawing.Image)
        Me.UcMenuChart5.MyLabel = "Agendadas"
        Me.UcMenuChart5.MyValue = "174"
        Me.UcMenuChart5.Name = "UcMenuChart5"
        Me.UcMenuChart5.Size = New System.Drawing.Size(230, 92)
        Me.UcMenuChart5.TabIndex = 4
        '
        'UcMenuChart4
        '
        Me.UcMenuChart4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuChart4.Location = New System.Drawing.Point(702, 5)
        Me.UcMenuChart4.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.UcMenuChart4.MyIcon = CType(resources.GetObject("UcMenuChart4.MyIcon"), System.Drawing.Image)
        Me.UcMenuChart4.MyLabel = "Em atendimento"
        Me.UcMenuChart4.MyValue = "80"
        Me.UcMenuChart4.Name = "UcMenuChart4"
        Me.UcMenuChart4.Size = New System.Drawing.Size(229, 92)
        Me.UcMenuChart4.TabIndex = 3
        '
        'UcMenuChart3
        '
        Me.UcMenuChart3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuChart3.Location = New System.Drawing.Point(468, 5)
        Me.UcMenuChart3.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.UcMenuChart3.MyIcon = CType(resources.GetObject("UcMenuChart3.MyIcon"), System.Drawing.Image)
        Me.UcMenuChart3.MyLabel = "Sem acordos"
        Me.UcMenuChart3.MyValue = "347"
        Me.UcMenuChart3.Name = "UcMenuChart3"
        Me.UcMenuChart3.Size = New System.Drawing.Size(229, 92)
        Me.UcMenuChart3.TabIndex = 2
        '
        'UcMenuChart2
        '
        Me.UcMenuChart2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuChart2.Location = New System.Drawing.Point(234, 5)
        Me.UcMenuChart2.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.UcMenuChart2.MyIcon = CType(resources.GetObject("UcMenuChart2.MyIcon"), System.Drawing.Image)
        Me.UcMenuChart2.MyLabel = "Negociações"
        Me.UcMenuChart2.MyValue = "184"
        Me.UcMenuChart2.Name = "UcMenuChart2"
        Me.UcMenuChart2.Size = New System.Drawing.Size(229, 92)
        Me.UcMenuChart2.TabIndex = 1
        '
        'UcMenuChart1
        '
        Me.UcMenuChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuChart1.Location = New System.Drawing.Point(5, 5)
        Me.UcMenuChart1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcMenuChart1.MyIcon = CType(resources.GetObject("UcMenuChart1.MyIcon"), System.Drawing.Image)
        Me.UcMenuChart1.MyLabel = "Atendimentos"
        Me.UcMenuChart1.MyValue = "785"
        Me.UcMenuChart1.Name = "UcMenuChart1"
        Me.UcMenuChart1.Size = New System.Drawing.Size(224, 92)
        Me.UcMenuChart1.TabIndex = 0
        '
        'ucDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ucDashboard"
        Me.Size = New System.Drawing.Size(1171, 439)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgGrid As DataGridView
    Friend WithEvents UcMenuChart5 As Components.ucMenuChart
    Friend WithEvents UcMenuChart4 As Components.ucMenuChart
    Friend WithEvents UcMenuChart3 As Components.ucMenuChart
    Friend WithEvents UcMenuChart2 As Components.ucMenuChart
    Friend WithEvents UcMenuChart1 As Components.ucMenuChart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents colSel As DataGridViewCheckBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colOperador As DataGridViewTextBoxColumn
    Friend WithEvents colRama As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewImageColumn
    Friend WithEvents colTempo As DataGridViewTextBoxColumn
    Friend WithEvents colTelefone As DataGridViewTextBoxColumn
End Class
