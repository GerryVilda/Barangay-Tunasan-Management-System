<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummary))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        Panel1 = New Panel()
        btnGenerate = New Button()
        Label1 = New Label()
        cmbSitio = New ComboBox()
        Panel2 = New Panel()
        chrtSitio = New DataVisualization.Charting.Chart()
        Label5 = New Label()
        dtpSitioInfo = New DateTimePicker()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel3 = New Panel()
        Chart2 = New DataVisualization.Charting.Chart()
        Label12 = New Label()
        dtpResidentInfo = New DateTimePicker()
        Panel4 = New Panel()
        dtpSitioIncident = New DateTimePicker()
        Chart3 = New DataVisualization.Charting.Chart()
        Label22 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(chrtSitio, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblTitle.Location = New Point(181, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(318, 46)
        lblTitle.TabIndex = 44
        lblTitle.Text = "Reports Summary"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnGenerate)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbSitio)
        Panel1.Location = New Point(181, 72)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(532, 62)
        Panel1.TabIndex = 45
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.PeachPuff
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Color.Black
        btnGenerate.Location = New Point(410, 16)
        btnGenerate.Margin = New Padding(3, 2, 3, 2)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(110, 36)
        btnGenerate.TabIndex = 6
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 31)
        Label1.TabIndex = 1
        Label1.Text = "Sitio:"
        ' 
        ' cmbSitio
        ' 
        cmbSitio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbSitio.FormattingEnabled = True
        cmbSitio.Items.AddRange(New Object() {"Camella Homes III", "Lake Shore Subdivision", "Lindenwood Residences", "Midland II Subdivision", "Parkhomes Subdivision", "Planas", "Sto. Niño Village", "Susana Heights Subdivision", "Villa Carolina I", "Villa Carolina II"})
        cmbSitio.Location = New Point(79, 14)
        cmbSitio.Margin = New Padding(3, 2, 3, 2)
        cmbSitio.Name = "cmbSitio"
        cmbSitio.Size = New Size(325, 36)
        cmbSitio.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(chrtSitio)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(dtpSitioInfo)
        Panel2.Location = New Point(12, 179)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(500, 668)
        Panel2.TabIndex = 46
        ' 
        ' chrtSitio
        ' 
        ChartArea1.Name = "ChartArea1"
        chrtSitio.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        chrtSitio.Legends.Add(Legend1)
        chrtSitio.Location = New Point(3, 89)
        chrtSitio.Name = "chrtSitio"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chrtSitio.Series.Add(Series1)
        chrtSitio.Size = New Size(494, 576)
        chrtSitio.TabIndex = 63
        chrtSitio.Text = "Chart1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(123, 7)
        Label5.Name = "Label5"
        Label5.Size = New Size(259, 41)
        Label5.TabIndex = 47
        Label5.Text = "Sitio Information"
        ' 
        ' dtpSitioInfo
        ' 
        dtpSitioInfo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpSitioInfo.Location = New Point(85, 50)
        dtpSitioInfo.Margin = New Padding(2)
        dtpSitioInfo.Name = "dtpSitioInfo"
        dtpSitioInfo.Size = New Size(322, 34)
        dtpSitioInfo.TabIndex = 57
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(Chart2)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(dtpResidentInfo)
        Panel3.Location = New Point(520, 179)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(500, 665)
        Panel3.TabIndex = 55
        ' 
        ' Chart2
        ' 
        ChartArea2.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Chart2.Legends.Add(Legend2)
        Chart2.Location = New Point(3, 89)
        Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Chart2.Series.Add(Series2)
        Chart2.Size = New Size(494, 579)
        Chart2.TabIndex = 48
        Chart2.Text = "Chart2"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(83, 7)
        Label12.Name = "Label12"
        Label12.Size = New Size(316, 41)
        Label12.TabIndex = 47
        Label12.Text = "Resident Information"
        ' 
        ' dtpResidentInfo
        ' 
        dtpResidentInfo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpResidentInfo.Location = New Point(82, 50)
        dtpResidentInfo.Margin = New Padding(2)
        dtpResidentInfo.Name = "dtpResidentInfo"
        dtpResidentInfo.Size = New Size(322, 34)
        dtpResidentInfo.TabIndex = 58
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(dtpSitioIncident)
        Panel4.Controls.Add(Chart3)
        Panel4.Controls.Add(Label22)
        Panel4.Location = New Point(1027, 179)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(500, 668)
        Panel4.TabIndex = 62
        ' 
        ' dtpSitioIncident
        ' 
        dtpSitioIncident.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpSitioIncident.Location = New Point(95, 50)
        dtpSitioIncident.Margin = New Padding(2)
        dtpSitioIncident.Name = "dtpSitioIncident"
        dtpSitioIncident.Size = New Size(322, 34)
        dtpSitioIncident.TabIndex = 59
        ' 
        ' Chart3
        ' 
        ChartArea3.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Chart3.Legends.Add(Legend3)
        Chart3.Location = New Point(3, 89)
        Chart3.Name = "Chart3"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Chart3.Series.Add(Series3)
        Chart3.Size = New Size(494, 579)
        Chart3.TabIndex = 48
        Chart3.Text = "Chart3"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(98, 7)
        Label22.Name = "Label22"
        Label22.Size = New Size(319, 41)
        Label22.TabIndex = 47
        Label22.Text = "Sitio Incident Reports"
        ' 
        ' frmSummary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1539, 844)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSummary"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(chrtSitio, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSitio As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpSitioInfo As DateTimePicker
    Friend WithEvents dtpResidentInfo As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents chrtSitio As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents dtpSitioIncident As DateTimePicker
End Class
