<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucConnections
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 10.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 25.0R)
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 70.0R)
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 40.0R)
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 51.0R)
        Dim DataPoint6 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucConnections))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgGrid = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnChart = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.colSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coCampanha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coAcao = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.UcMenuChart5 = New Components.ucMenuChart()
        Me.Panel1.SuspendLayout()
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnChart.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgGrid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(1171, 337)
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
        Me.dgGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSel, Me.colID, Me.colOperador, Me.colRama, Me.coData, Me.colTempo, Me.colTelefone, Me.coCampanha, Me.coAcao})
        Me.dgGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGrid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgGrid.Location = New System.Drawing.Point(5, 0)
        Me.dgGrid.Name = "dgGrid"
        Me.dgGrid.RowHeadersVisible = False
        Me.dgGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrid.Size = New System.Drawing.Size(1161, 332)
        Me.dgGrid.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnChart, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UcMenuChart5, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1171, 102)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'pnChart
        '
        Me.pnChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnChart.Controls.Add(Me.Chart1)
        Me.pnChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChart.Location = New System.Drawing.Point(5, 5)
        Me.pnChart.Margin = New System.Windows.Forms.Padding(5)
        Me.pnChart.Name = "pnChart"
        Me.pnChart.Padding = New System.Windows.Forms.Padding(10)
        Me.pnChart.Size = New System.Drawing.Size(791, 92)
        Me.pnChart.TabIndex = 5
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        ChartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisX2.LineWidth = 0
        ChartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisY.LineWidth = 0
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        ChartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisY2.LineWidth = 0
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        ChartArea1.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart1.Location = New System.Drawing.Point(10, 10)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Series1.IsVisibleInLegend = False
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Series1.LabelBorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series1.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(252, Byte), Integer))
        Series1.Name = "Series1"
        DataPoint1.LegendText = ""
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.Points.Add(DataPoint3)
        Series1.Points.Add(DataPoint4)
        Series1.Points.Add(DataPoint5)
        Series1.Points.Add(DataPoint6)
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(771, 72)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
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
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colID.Width = 70
        '
        'colOperador
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colOperador.DefaultCellStyle = DataGridViewCellStyle2
        Me.colOperador.HeaderText = "Operador"
        Me.colOperador.MinimumWidth = 70
        Me.colOperador.Name = "colOperador"
        Me.colOperador.Width = 150
        '
        'colRama
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRama.DefaultCellStyle = DataGridViewCellStyle3
        Me.colRama.HeaderText = "Ramal"
        Me.colRama.MinimumWidth = 100
        Me.colRama.Name = "colRama"
        '
        'coData
        '
        Me.coData.HeaderText = "Data da ligação"
        Me.coData.Name = "coData"
        '
        'colTempo
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTempo.DefaultCellStyle = DataGridViewCellStyle4
        Me.colTempo.HeaderText = "Tempo em linha"
        Me.colTempo.MinimumWidth = 70
        Me.colTempo.Name = "colTempo"
        Me.colTempo.Width = 120
        '
        'colTelefone
        '
        Me.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTelefone.DefaultCellStyle = DataGridViewCellStyle5
        Me.colTelefone.HeaderText = "Cliente"
        Me.colTelefone.Name = "colTelefone"
        '
        'coCampanha
        '
        Me.coCampanha.HeaderText = "Campanha"
        Me.coCampanha.Name = "coCampanha"
        '
        'coAcao
        '
        Me.coAcao.HeaderText = "Ação"
        Me.coAcao.MinimumWidth = 50
        Me.coAcao.Name = "coAcao"
        Me.coAcao.Width = 50
        '
        'UcMenuChart5
        '
        Me.UcMenuChart5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMenuChart5.Location = New System.Drawing.Point(801, 5)
        Me.UcMenuChart5.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.UcMenuChart5.MyIcon = CType(resources.GetObject("UcMenuChart5.MyIcon"), System.Drawing.Image)
        Me.UcMenuChart5.MyLabel = "Total de ligações"
        Me.UcMenuChart5.MyValue = "785"
        Me.UcMenuChart5.Name = "UcMenuChart5"
        Me.UcMenuChart5.Size = New System.Drawing.Size(365, 92)
        Me.UcMenuChart5.TabIndex = 4
        '
        'ucConnections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ucConnections"
        Me.Size = New System.Drawing.Size(1171, 439)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnChart.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgGrid As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UcMenuChart5 As Components.ucMenuChart
    Friend WithEvents pnChart As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents colSel As DataGridViewCheckBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colOperador As DataGridViewTextBoxColumn
    Friend WithEvents colRama As DataGridViewTextBoxColumn
    Friend WithEvents coData As DataGridViewTextBoxColumn
    Friend WithEvents colTempo As DataGridViewTextBoxColumn
    Friend WithEvents colTelefone As DataGridViewTextBoxColumn
    Friend WithEvents coCampanha As DataGridViewTextBoxColumn
    Friend WithEvents coAcao As DataGridViewButtonColumn
End Class
