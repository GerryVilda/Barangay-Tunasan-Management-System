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
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        Panel2 = New Panel()
        btnrefreshpayments = New Button()
        chartpaymentrevenue = New DataVisualization.Charting.Chart()
        Label5 = New Label()
        dtppaymentrevenue = New DateTimePicker()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel3 = New Panel()
        btnrefreshresidents = New Button()
        chartresidentinfo = New DataVisualization.Charting.Chart()
        Label12 = New Label()
        dtpResidentInfo = New DateTimePicker()
        Panel4 = New Panel()
        btnrefreshcomplaints = New Button()
        dtpcomplaintincident = New DateTimePicker()
        chartcomplaintincident = New DataVisualization.Charting.Chart()
        Label22 = New Label()
        Panel5 = New Panel()
        btnrefreshcertifications = New Button()
        chartcertificationsrequest = New DataVisualization.Charting.Chart()
        Label2 = New Label()
        dtpcertificationsrequest = New DateTimePicker()
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
        Label6 = New Label()
        dtpFilter = New DateTimePicker()
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(btnrefreshpayments)
        Panel2.Controls.Add(chartpaymentrevenue)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(dtppaymentrevenue)
        Panel2.Location = New Point(10, 154)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(500, 455)
        Panel2.TabIndex = 46
        ' 
        ' btnrefreshpayments
        ' 
        btnrefreshpayments.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnrefreshpayments.Location = New Point(370, 10)
        btnrefreshpayments.Margin = New Padding(2)
        btnrefreshpayments.Name = "btnrefreshpayments"
        btnrefreshpayments.Size = New Size(117, 34)
        btnrefreshpayments.TabIndex = 64
        btnrefreshpayments.Text = "Refresh"
        btnrefreshpayments.UseVisualStyleBackColor = True
        ' 
        ' chartpaymentrevenue
        ' 
        ChartArea7.Name = "ChartArea1"
        chartpaymentrevenue.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        chartpaymentrevenue.Legends.Add(Legend7)
        chartpaymentrevenue.Location = New Point(3, 89)
        chartpaymentrevenue.Name = "chartpaymentrevenue"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        chartpaymentrevenue.Series.Add(Series7)
        chartpaymentrevenue.Size = New Size(494, 362)
        chartpaymentrevenue.TabIndex = 63
        chartpaymentrevenue.Text = "Chart1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 3)
        Label5.Name = "Label5"
        Label5.Size = New Size(345, 41)
        Label5.TabIndex = 47
        Label5.Text = "Payments and Revenue"
        ' 
        ' dtppaymentrevenue
        ' 
        dtppaymentrevenue.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtppaymentrevenue.Location = New Point(3, 53)
        dtppaymentrevenue.Margin = New Padding(2)
        dtppaymentrevenue.Name = "dtppaymentrevenue"
        dtppaymentrevenue.Size = New Size(309, 34)
        dtppaymentrevenue.TabIndex = 57
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
        Panel3.Location = New Point(520, 154)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(500, 455)
        Panel3.TabIndex = 55
        ' 
        ' btnrefreshresidents
        ' 
        btnrefreshresidents.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnrefreshresidents.Location = New Point(370, 10)
        btnrefreshresidents.Margin = New Padding(2)
        btnrefreshresidents.Name = "btnrefreshresidents"
        btnrefreshresidents.Size = New Size(117, 34)
        btnrefreshresidents.TabIndex = 65
        btnrefreshresidents.Text = "Refresh"
        btnrefreshresidents.UseVisualStyleBackColor = True
        ' 
        ' chartresidentinfo
        ' 
        ChartArea8.Name = "ChartArea1"
        chartresidentinfo.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        chartresidentinfo.Legends.Add(Legend8)
        chartresidentinfo.Location = New Point(3, 89)
        chartresidentinfo.Name = "chartresidentinfo"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        chartresidentinfo.Series.Add(Series8)
        chartresidentinfo.Size = New Size(494, 362)
        chartresidentinfo.TabIndex = 48
        chartresidentinfo.Text = "Chart2"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(3, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(316, 41)
        Label12.TabIndex = 47
        Label12.Text = "Resident Information"
        ' 
        ' dtpResidentInfo
        ' 
        dtpResidentInfo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpResidentInfo.Location = New Point(3, 53)
        dtpResidentInfo.Margin = New Padding(2)
        dtpResidentInfo.Name = "dtpResidentInfo"
        dtpResidentInfo.Size = New Size(322, 34)
        dtpResidentInfo.TabIndex = 58
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(btnrefreshcomplaints)
        Panel4.Controls.Add(dtpcomplaintincident)
        Panel4.Controls.Add(chartcomplaintincident)
        Panel4.Controls.Add(Label22)
        Panel4.Location = New Point(1027, 151)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(500, 455)
        Panel4.TabIndex = 62
        ' 
        ' btnrefreshcomplaints
        ' 
        btnrefreshcomplaints.Location = New Point(366, 10)
        btnrefreshcomplaints.Margin = New Padding(2)
        btnrefreshcomplaints.Name = "btnrefreshcomplaints"
        btnrefreshcomplaints.Size = New Size(117, 34)
        btnrefreshcomplaints.TabIndex = 66
        btnrefreshcomplaints.Text = "Refresh"
        btnrefreshcomplaints.UseVisualStyleBackColor = True
        ' 
        ' dtpcomplaintincident
        ' 
        dtpcomplaintincident.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpcomplaintincident.Location = New Point(3, 53)
        dtpcomplaintincident.Margin = New Padding(2)
        dtpcomplaintincident.Name = "dtpcomplaintincident"
        dtpcomplaintincident.Size = New Size(322, 34)
        dtpcomplaintincident.TabIndex = 59
        ' 
        ' chartcomplaintincident
        ' 
        ChartArea9.Name = "ChartArea1"
        chartcomplaintincident.ChartAreas.Add(ChartArea9)
        Legend9.Name = "Legend1"
        chartcomplaintincident.Legends.Add(Legend9)
        chartcomplaintincident.Location = New Point(3, 89)
        chartcomplaintincident.Name = "chartcomplaintincident"
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        chartcomplaintincident.Series.Add(Series9)
        chartcomplaintincident.Size = New Size(494, 362)
        chartcomplaintincident.TabIndex = 48
        chartcomplaintincident.Text = "Chart3"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 16.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(3, 3)
        Label22.Name = "Label22"
        Label22.Size = New Size(359, 40)
        Label22.TabIndex = 47
        Label22.Text = "Complaints and Incidents"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Controls.Add(btnrefreshcertifications)
        Panel5.Controls.Add(chartcertificationsrequest)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(dtpcertificationsrequest)
        Panel5.Location = New Point(7, 627)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(500, 455)
        Panel5.TabIndex = 64
        ' 
        ' btnrefreshcertifications
        ' 
        btnrefreshcertifications.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnrefreshcertifications.Location = New Point(373, 8)
        btnrefreshcertifications.Margin = New Padding(2)
        btnrefreshcertifications.Name = "btnrefreshcertifications"
        btnrefreshcertifications.Size = New Size(117, 34)
        btnrefreshcertifications.TabIndex = 67
        btnrefreshcertifications.Text = "Refresh"
        btnrefreshcertifications.UseVisualStyleBackColor = True
        ' 
        ' chartcertificationsrequest
        ' 
        ChartArea10.Name = "ChartArea1"
        chartcertificationsrequest.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        chartcertificationsrequest.Legends.Add(Legend10)
        chartcertificationsrequest.Location = New Point(3, 89)
        chartcertificationsrequest.Name = "chartcertificationsrequest"
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Series1"
        chartcertificationsrequest.Series.Add(Series10)
        chartcertificationsrequest.Size = New Size(494, 362)
        chartcertificationsrequest.TabIndex = 63
        chartcertificationsrequest.Text = "Chart1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(327, 41)
        Label2.TabIndex = 47
        Label2.Text = "Certifications Request"
        ' 
        ' dtpcertificationsrequest
        ' 
        dtpcertificationsrequest.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpcertificationsrequest.Location = New Point(2, 50)
        dtpcertificationsrequest.Margin = New Padding(2)
        dtpcertificationsrequest.Name = "dtpcertificationsrequest"
        dtpcertificationsrequest.Size = New Size(325, 34)
        dtpcertificationsrequest.TabIndex = 57
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Controls.Add(Button5)
        Panel6.Controls.Add(Chart2)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(DateTimePicker2)
        Panel6.Location = New Point(520, 627)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(500, 455)
        Panel6.TabIndex = 59
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Button5.Location = New Point(370, 8)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(117, 34)
        Button5.TabIndex = 68
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Chart2
        ' 
        ChartArea11.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Chart2.Legends.Add(Legend11)
        Chart2.Location = New Point(3, 89)
        Chart2.Name = "Chart2"
        Series11.ChartArea = "ChartArea1"
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Chart2.Series.Add(Series11)
        Chart2.Size = New Size(494, 362)
        Chart2.TabIndex = 48
        Chart2.Text = "Chart2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(316, 41)
        Label3.TabIndex = 47
        Label3.Text = "Resident Information"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        DateTimePicker2.Location = New Point(3, 50)
        DateTimePicker2.Margin = New Padding(2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(322, 34)
        DateTimePicker2.TabIndex = 58
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Transparent
        Panel7.Controls.Add(Button6)
        Panel7.Controls.Add(Chart3)
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(DateTimePicker3)
        Panel7.Location = New Point(1027, 627)
        Panel7.Margin = New Padding(3, 2, 3, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(500, 455)
        Panel7.TabIndex = 59
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Button6.Location = New Point(366, 8)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(117, 34)
        Button6.TabIndex = 69
        Button6.Text = "Refresh"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Chart3
        ' 
        ChartArea12.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Chart3.Legends.Add(Legend12)
        Chart3.Location = New Point(3, 89)
        Chart3.Name = "Chart3"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.Name = "Series1"
        Chart3.Series.Add(Series12)
        Chart3.Size = New Size(494, 362)
        Chart3.TabIndex = 48
        Chart3.Text = "Chart2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(316, 41)
        Label4.TabIndex = 47
        Label4.Text = "Resident Information"
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        DateTimePicker3.Location = New Point(3, 53)
        DateTimePicker3.Margin = New Padding(2)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(322, 34)
        DateTimePicker3.TabIndex = 58
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
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.PeachPuff
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Color.Black
        btnGenerate.Location = New Point(900, 14)
        btnGenerate.Margin = New Padding(3, 2, 3, 2)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(110, 36)
        btnGenerate.TabIndex = 6
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(dtpFilter)
        Panel1.Controls.Add(btnGenerate)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbSitio)
        Panel1.Location = New Point(181, 72)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1115, 62)
        Panel1.TabIndex = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(433, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 31)
        Label6.TabIndex = 8
        Label6.Text = "Filter:"
        ' 
        ' dtpFilter
        ' 
        dtpFilter.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpFilter.Location = New Point(516, 16)
        dtpFilter.Name = "dtpFilter"
        dtpFilter.Size = New Size(343, 34)
        dtpFilter.TabIndex = 7
        ' 
        ' frmSummary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1557, 891)
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
    Friend WithEvents dtppaymentrevenue As DateTimePicker
    Friend WithEvents dtpResidentInfo As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents chartpaymentrevenue As DataVisualization.Charting.Chart
    Friend WithEvents chartresidentinfo As DataVisualization.Charting.Chart
    Friend WithEvents chartcomplaintincident As DataVisualization.Charting.Chart
    Friend WithEvents dtpcomplaintincident As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents chartcertificationsrequest As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpcertificationsrequest As DateTimePicker
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
    Friend WithEvents dtpFilter As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
