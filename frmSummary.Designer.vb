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
        Dim ChartArea19 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend19 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea20 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend20 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea21 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend21 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series21 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea22 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend22 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series22 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea23 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend23 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series23 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea24 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend24 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series24 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        Panel2 = New Panel()
        btnrefreshpayments = New Button()
        chartpaymentrevenue = New DataVisualization.Charting.Chart()
        Label5 = New Label()
        dtpSitioInfo = New DateTimePicker()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel3 = New Panel()
        btnrefreshresidents = New Button()
        chartresidentinfo = New DataVisualization.Charting.Chart()
        Label12 = New Label()
        dtpResidentInfo = New DateTimePicker()
        Panel4 = New Panel()
        btnrefreshcomplaints = New Button()
        dtpSitioIncident = New DateTimePicker()
        chartcomplaintincident = New DataVisualization.Charting.Chart()
        Label22 = New Label()
        Panel5 = New Panel()
        btnrefreshcertifications = New Button()
        chartcertificationsrequest = New DataVisualization.Charting.Chart()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Panel6 = New Panel()
        Button5 = New Button()
        Chart2 = New DataVisualization.Charting.Chart()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Panel7 = New Panel()
        Button6 = New Button()
        Chart3 = New DataVisualization.Charting.Chart()
        Label4 = New Label()
        DateTimePicker3 = New DateTimePicker()
        cmbSitio = New ComboBox()
        Label1 = New Label()
        btnGenerate = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(chartpaymentrevenue, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(chartresidentinfo, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(chartcomplaintincident, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(chartcertificationsrequest, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblTitle.Location = New Point(226, 22)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(374, 54)
        lblTitle.TabIndex = 44
        lblTitle.Text = "Reports Summary"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(btnrefreshpayments)
        Panel2.Controls.Add(chartpaymentrevenue)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(dtpSitioInfo)
        Panel2.Location = New Point(15, 224)
        Panel2.Margin = New Padding(4, 2, 4, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(625, 835)
        Panel2.TabIndex = 46
        ' 
        ' btnrefreshpayments
        ' 
        btnrefreshpayments.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnrefreshpayments.Location = New Point(463, 13)
        btnrefreshpayments.Name = "btnrefreshpayments"
        btnrefreshpayments.Size = New Size(146, 42)
        btnrefreshpayments.TabIndex = 64
        btnrefreshpayments.Text = "Refresh"
        btnrefreshpayments.UseVisualStyleBackColor = True
        ' 
        ' chartpaymentrevenue
        ' 
        ChartArea19.Name = "ChartArea1"
        chartpaymentrevenue.ChartAreas.Add(ChartArea19)
        Legend19.Name = "Legend1"
        chartpaymentrevenue.Legends.Add(Legend19)
        chartpaymentrevenue.Location = New Point(4, 111)
        chartpaymentrevenue.Margin = New Padding(4)
        chartpaymentrevenue.Name = "chartpaymentrevenue"
        Series19.ChartArea = "ChartArea1"
        Series19.Legend = "Legend1"
        Series19.Name = "Series1"
        chartpaymentrevenue.Series.Add(Series19)
        chartpaymentrevenue.Size = New Size(618, 720)
        chartpaymentrevenue.TabIndex = 63
        chartpaymentrevenue.Text = "Chart1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(4, 0)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(350, 48)
        Label5.TabIndex = 47
        Label5.Text = "Payments & Revenue"
        ' 
        ' dtpSitioInfo
        ' 
        dtpSitioInfo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpSitioInfo.Location = New Point(4, 66)
        dtpSitioInfo.Margin = New Padding(2)
        dtpSitioInfo.Name = "dtpSitioInfo"
        dtpSitioInfo.Size = New Size(385, 39)
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
        Panel3.Controls.Add(btnrefreshresidents)
        Panel3.Controls.Add(chartresidentinfo)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(dtpResidentInfo)
        Panel3.Location = New Point(650, 224)
        Panel3.Margin = New Padding(4, 2, 4, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(625, 831)
        Panel3.TabIndex = 55
        ' 
        ' btnrefreshresidents
        ' 
        btnrefreshresidents.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnrefreshresidents.Location = New Point(463, 13)
        btnrefreshresidents.Name = "btnrefreshresidents"
        btnrefreshresidents.Size = New Size(146, 42)
        btnrefreshresidents.TabIndex = 65
        btnrefreshresidents.Text = "Refresh"
        btnrefreshresidents.UseVisualStyleBackColor = True
        ' 
        ' chartresidentinfo
        ' 
        ChartArea20.Name = "ChartArea1"
        chartresidentinfo.ChartAreas.Add(ChartArea20)
        Legend20.Name = "Legend1"
        chartresidentinfo.Legends.Add(Legend20)
        chartresidentinfo.Location = New Point(4, 111)
        chartresidentinfo.Margin = New Padding(4)
        chartresidentinfo.Name = "chartresidentinfo"
        Series20.ChartArea = "ChartArea1"
        Series20.Legend = "Legend1"
        Series20.Name = "Series1"
        chartresidentinfo.Series.Add(Series20)
        chartresidentinfo.Size = New Size(618, 724)
        chartresidentinfo.TabIndex = 48
        chartresidentinfo.Text = "Chart2"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(4, 0)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(379, 48)
        Label12.TabIndex = 47
        Label12.Text = "Resident Information"
        ' 
        ' dtpResidentInfo
        ' 
        dtpResidentInfo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpResidentInfo.Location = New Point(4, 66)
        dtpResidentInfo.Margin = New Padding(2)
        dtpResidentInfo.Name = "dtpResidentInfo"
        dtpResidentInfo.Size = New Size(402, 39)
        dtpResidentInfo.TabIndex = 58
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(btnrefreshcomplaints)
        Panel4.Controls.Add(dtpSitioIncident)
        Panel4.Controls.Add(chartcomplaintincident)
        Panel4.Controls.Add(Label22)
        Panel4.Location = New Point(1284, 224)
        Panel4.Margin = New Padding(4, 2, 4, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(625, 835)
        Panel4.TabIndex = 62
        ' 
        ' btnrefreshcomplaints
        ' 
        btnrefreshcomplaints.Location = New Point(458, 13)
        btnrefreshcomplaints.Name = "btnrefreshcomplaints"
        btnrefreshcomplaints.Size = New Size(146, 42)
        btnrefreshcomplaints.TabIndex = 66
        btnrefreshcomplaints.Text = "Refresh"
        btnrefreshcomplaints.UseVisualStyleBackColor = True
        ' 
        ' dtpSitioIncident
        ' 
        dtpSitioIncident.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpSitioIncident.Location = New Point(4, 66)
        dtpSitioIncident.Margin = New Padding(2)
        dtpSitioIncident.Name = "dtpSitioIncident"
        dtpSitioIncident.Size = New Size(402, 39)
        dtpSitioIncident.TabIndex = 59
        ' 
        ' chartcomplaintincident
        ' 
        ChartArea21.Name = "ChartArea1"
        chartcomplaintincident.ChartAreas.Add(ChartArea21)
        Legend21.Name = "Legend1"
        chartcomplaintincident.Legends.Add(Legend21)
        chartcomplaintincident.Location = New Point(4, 111)
        chartcomplaintincident.Margin = New Padding(4)
        chartcomplaintincident.Name = "chartcomplaintincident"
        Series21.ChartArea = "ChartArea1"
        Series21.Legend = "Legend1"
        Series21.Name = "Series1"
        chartcomplaintincident.Series.Add(Series21)
        chartcomplaintincident.Size = New Size(618, 724)
        chartcomplaintincident.TabIndex = 48
        chartcomplaintincident.Text = "Chart3"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(-1, 0)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(386, 48)
        Label22.TabIndex = 47
        Label22.Text = "Complaints & Incidents"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Controls.Add(btnrefreshcertifications)
        Panel5.Controls.Add(chartcertificationsrequest)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(DateTimePicker1)
        Panel5.Location = New Point(12, 1084)
        Panel5.Margin = New Padding(4, 2, 4, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(625, 835)
        Panel5.TabIndex = 64
        ' 
        ' btnrefreshcertifications
        ' 
        btnrefreshcertifications.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnrefreshcertifications.Location = New Point(466, 10)
        btnrefreshcertifications.Name = "btnrefreshcertifications"
        btnrefreshcertifications.Size = New Size(146, 42)
        btnrefreshcertifications.TabIndex = 67
        btnrefreshcertifications.Text = "Refresh"
        btnrefreshcertifications.UseVisualStyleBackColor = True
        ' 
        ' chartcertificationsrequest
        ' 
        ChartArea22.Name = "ChartArea1"
        chartcertificationsrequest.ChartAreas.Add(ChartArea22)
        Legend22.Name = "Legend1"
        chartcertificationsrequest.Legends.Add(Legend22)
        chartcertificationsrequest.Location = New Point(4, 111)
        chartcertificationsrequest.Margin = New Padding(4)
        chartcertificationsrequest.Name = "chartcertificationsrequest"
        Series22.ChartArea = "ChartArea1"
        Series22.Legend = "Legend1"
        Series22.Name = "Series1"
        chartcertificationsrequest.Series.Add(Series22)
        chartcertificationsrequest.Size = New Size(618, 720)
        chartcertificationsrequest.TabIndex = 63
        chartcertificationsrequest.Text = "Chart1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(0, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 48)
        Label2.TabIndex = 47
        Label2.Text = "Certifications Request"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(3, 62)
        DateTimePicker1.Margin = New Padding(2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(405, 39)
        DateTimePicker1.TabIndex = 57
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Controls.Add(Button5)
        Panel6.Controls.Add(Chart2)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(DateTimePicker2)
        Panel6.Location = New Point(650, 1084)
        Panel6.Margin = New Padding(4, 2, 4, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(625, 831)
        Panel6.TabIndex = 59
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Button5.Location = New Point(463, 10)
        Button5.Name = "Button5"
        Button5.Size = New Size(146, 42)
        Button5.TabIndex = 68
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Chart2
        ' 
        ChartArea23.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea23)
        Legend23.Name = "Legend1"
        Chart2.Legends.Add(Legend23)
        Chart2.Location = New Point(4, 111)
        Chart2.Margin = New Padding(4)
        Chart2.Name = "Chart2"
        Series23.ChartArea = "ChartArea1"
        Series23.Legend = "Legend1"
        Series23.Name = "Series1"
        Chart2.Series.Add(Series23)
        Chart2.Size = New Size(618, 724)
        Chart2.TabIndex = 48
        Chart2.Text = "Chart2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(4, 0)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(379, 48)
        Label3.TabIndex = 47
        Label3.Text = "Resident Information"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        DateTimePicker2.Location = New Point(4, 62)
        DateTimePicker2.Margin = New Padding(2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(402, 39)
        DateTimePicker2.TabIndex = 58
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Transparent
        Panel7.Controls.Add(Button6)
        Panel7.Controls.Add(Chart3)
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(DateTimePicker3)
        Panel7.Location = New Point(1284, 1084)
        Panel7.Margin = New Padding(4, 2, 4, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(625, 831)
        Panel7.TabIndex = 59
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Button6.Location = New Point(458, 10)
        Button6.Name = "Button6"
        Button6.Size = New Size(146, 42)
        Button6.TabIndex = 69
        Button6.Text = "Refresh"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Chart3
        ' 
        ChartArea24.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea24)
        Legend24.Name = "Legend1"
        Chart3.Legends.Add(Legend24)
        Chart3.Location = New Point(4, 111)
        Chart3.Margin = New Padding(4)
        Chart3.Name = "Chart3"
        Series24.ChartArea = "ChartArea1"
        Series24.Legend = "Legend1"
        Series24.Name = "Series1"
        Chart3.Series.Add(Series24)
        Chart3.Size = New Size(618, 724)
        Chart3.TabIndex = 48
        Chart3.Text = "Chart2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(-1, 0)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(379, 48)
        Label4.TabIndex = 47
        Label4.Text = "Resident Information"
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        DateTimePicker3.Location = New Point(4, 66)
        DateTimePicker3.Margin = New Padding(2)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(402, 39)
        DateTimePicker3.TabIndex = 58
        ' 
        ' cmbSitio
        ' 
        cmbSitio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbSitio.FormattingEnabled = True
        cmbSitio.Items.AddRange(New Object() {"Camella Homes III", "Lake Shore Subdivision", "Lindenwood Residences", "Midland II Subdivision", "Parkhomes Subdivision", "Planas", "Sto. Niño Village", "Susana Heights Subdivision", "Villa Carolina I", "Villa Carolina II"})
        cmbSitio.Location = New Point(99, 18)
        cmbSitio.Margin = New Padding(4, 2, 4, 2)
        cmbSitio.Name = "cmbSitio"
        cmbSitio.Size = New Size(405, 40)
        cmbSitio.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(4, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 38)
        Label1.TabIndex = 1
        Label1.Text = "Sitio:"
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.PeachPuff
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Color.Black
        btnGenerate.Location = New Point(512, 20)
        btnGenerate.Margin = New Padding(4, 2, 4, 2)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(138, 45)
        btnGenerate.TabIndex = 6
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnGenerate)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbSitio)
        Panel1.Location = New Point(226, 90)
        Panel1.Margin = New Padding(4, 2, 4, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(665, 78)
        Panel1.TabIndex = 45
        ' 
        ' frmSummary
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(2236, 1626)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSummary"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(chartpaymentrevenue, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(chartresidentinfo, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(chartcomplaintincident, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(chartcertificationsrequest, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpSitioInfo As DateTimePicker
    Friend WithEvents dtpResidentInfo As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents chartpaymentrevenue As DataVisualization.Charting.Chart
    Friend WithEvents chartresidentinfo As DataVisualization.Charting.Chart
    Friend WithEvents chartcomplaintincident As DataVisualization.Charting.Chart
    Friend WithEvents dtpSitioIncident As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents chartcertificationsrequest As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents btnrefreshresidents As Button
    Friend WithEvents btnrefreshpayments As Button
    Friend WithEvents btnrefreshcomplaints As Button
    Friend WithEvents btnrefreshcertifications As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cmbSitio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Panel1 As Panel
End Class
