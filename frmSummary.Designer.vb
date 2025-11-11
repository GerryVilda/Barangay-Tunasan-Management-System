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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummary))
        lblTitle = New Label()
        cbopayments = New ComboBox()
        btnPaymentRefresh = New Button()
        chartpaymentrevenue = New DataVisualization.Charting.Chart()
        Label5 = New Label()
        dtppayment = New DateTimePicker()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        cboresident = New ComboBox()
        btnResidentRefresh = New Button()
        chartresidentinfo = New DataVisualization.Charting.Chart()
        Label12 = New Label()
        dtpResidentInfo = New DateTimePicker()
        cbocomplaints = New ComboBox()
        btnComplaintRefresh = New Button()
        dtpComplaints = New DateTimePicker()
        chartcomplaintincident = New DataVisualization.Charting.Chart()
        Label22 = New Label()
        cbocertificaterequest = New ComboBox()
        btnCertificateRefresh = New Button()
        chartcertificationsrequest = New DataVisualization.Charting.Chart()
        Label2 = New Label()
        dtpCertificates = New DateTimePicker()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(chartpaymentrevenue, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartresidentinfo, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartcomplaintincident, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartcertificationsrequest, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblTitle.Location = New Point(6, 9)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(374, 54)
        lblTitle.TabIndex = 44
        lblTitle.Text = "Reports Summary"
        ' 
        ' cbopayments
        ' 
        cbopayments.FormattingEnabled = True
        cbopayments.Location = New Point(402, 161)
        cbopayments.Name = "cbopayments"
        cbopayments.Size = New Size(214, 33)
        cbopayments.TabIndex = 65
        ' 
        ' btnPaymentRefresh
        ' 
        btnPaymentRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPaymentRefresh.Location = New Point(470, 104)
        btnPaymentRefresh.Margin = New Padding(2)
        btnPaymentRefresh.Name = "btnPaymentRefresh"
        btnPaymentRefresh.Size = New Size(146, 42)
        btnPaymentRefresh.TabIndex = 64
        btnPaymentRefresh.Text = "Refresh"
        btnPaymentRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartpaymentrevenue
        ' 
        ChartArea1.Name = "ChartArea1"
        chartpaymentrevenue.ChartAreas.Add(ChartArea1)
        chartpaymentrevenue.Dock = DockStyle.Fill
        Legend1.Name = "Legend1"
        chartpaymentrevenue.Legends.Add(Legend1)
        chartpaymentrevenue.Location = New Point(4, 4)
        chartpaymentrevenue.Margin = New Padding(4)
        chartpaymentrevenue.Name = "chartpaymentrevenue"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chartpaymentrevenue.Series.Add(Series1)
        chartpaymentrevenue.Size = New Size(958, 442)
        chartpaymentrevenue.TabIndex = 63
        chartpaymentrevenue.Text = "Chart1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 96)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(414, 48)
        Label5.TabIndex = 47
        Label5.Text = "Payments and Revenue"
        ' 
        ' dtppayment
        ' 
        dtppayment.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtppayment.Location = New Point(12, 158)
        dtppayment.Margin = New Padding(2)
        dtppayment.Name = "dtppayment"
        dtppayment.Size = New Size(385, 39)
        dtppayment.TabIndex = 57
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' cboresident
        ' 
        cboresident.FormattingEnabled = True
        cboresident.Location = New Point(1383, 279)
        cboresident.Name = "cboresident"
        cboresident.Size = New Size(195, 33)
        cboresident.TabIndex = 66
        ' 
        ' btnResidentRefresh
        ' 
        btnResidentRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnResidentRefresh.Location = New Point(1432, 222)
        btnResidentRefresh.Margin = New Padding(2)
        btnResidentRefresh.Name = "btnResidentRefresh"
        btnResidentRefresh.Size = New Size(146, 42)
        btnResidentRefresh.TabIndex = 65
        btnResidentRefresh.Text = "Refresh"
        btnResidentRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartresidentinfo
        ' 
        ChartArea2.Name = "ChartArea1"
        chartresidentinfo.ChartAreas.Add(ChartArea2)
        chartresidentinfo.Dock = DockStyle.Fill
        Legend2.Name = "Legend1"
        chartresidentinfo.Legends.Add(Legend2)
        chartresidentinfo.Location = New Point(970, 4)
        chartresidentinfo.Margin = New Padding(4)
        chartresidentinfo.Name = "chartresidentinfo"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        chartresidentinfo.Series.Add(Series2)
        chartresidentinfo.Size = New Size(958, 442)
        chartresidentinfo.TabIndex = 48
        chartresidentinfo.Text = "Chart2"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(978, 94)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(379, 48)
        Label12.TabIndex = 47
        Label12.Text = "Resident Information"
        ' 
        ' dtpResidentInfo
        ' 
        dtpResidentInfo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpResidentInfo.Location = New Point(978, 156)
        dtpResidentInfo.Margin = New Padding(2)
        dtpResidentInfo.Name = "dtpResidentInfo"
        dtpResidentInfo.Size = New Size(402, 39)
        dtpResidentInfo.TabIndex = 58
        ' 
        ' cbocomplaints
        ' 
        cbocomplaints.FormattingEnabled = True
        cbocomplaints.Location = New Point(1383, 778)
        cbocomplaints.Name = "cbocomplaints"
        cbocomplaints.Size = New Size(195, 33)
        cbocomplaints.TabIndex = 66
        ' 
        ' btnComplaintRefresh
        ' 
        btnComplaintRefresh.Location = New Point(1427, 716)
        btnComplaintRefresh.Margin = New Padding(2)
        btnComplaintRefresh.Name = "btnComplaintRefresh"
        btnComplaintRefresh.Size = New Size(146, 42)
        btnComplaintRefresh.TabIndex = 66
        btnComplaintRefresh.Text = "Refresh"
        btnComplaintRefresh.UseVisualStyleBackColor = True
        ' 
        ' dtpComplaints
        ' 
        dtpComplaints.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpComplaints.Location = New Point(977, 655)
        dtpComplaints.Margin = New Padding(2)
        dtpComplaints.Name = "dtpComplaints"
        dtpComplaints.Size = New Size(402, 39)
        dtpComplaints.TabIndex = 59
        ' 
        ' chartcomplaintincident
        ' 
        ChartArea3.Name = "ChartArea1"
        chartcomplaintincident.ChartAreas.Add(ChartArea3)
        chartcomplaintincident.Dock = DockStyle.Fill
        Legend3.Name = "Legend1"
        chartcomplaintincident.Legends.Add(Legend3)
        chartcomplaintincident.Location = New Point(970, 454)
        chartcomplaintincident.Margin = New Padding(4)
        chartcomplaintincident.Name = "chartcomplaintincident"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        chartcomplaintincident.Series.Add(Series3)
        chartcomplaintincident.Size = New Size(958, 442)
        chartcomplaintincident.TabIndex = 48
        chartcomplaintincident.Text = "Chart3"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 16.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(977, 588)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(425, 46)
        Label22.TabIndex = 47
        Label22.Text = "Complaints and Incidents"
        ' 
        ' cbocertificaterequest
        ' 
        cbocertificaterequest.FormattingEnabled = True
        cbocertificaterequest.Location = New Point(425, 651)
        cbocertificaterequest.Name = "cbocertificaterequest"
        cbocertificaterequest.Size = New Size(195, 33)
        cbocertificaterequest.TabIndex = 67
        ' 
        ' btnCertificateRefresh
        ' 
        btnCertificateRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnCertificateRefresh.Location = New Point(474, 593)
        btnCertificateRefresh.Margin = New Padding(2)
        btnCertificateRefresh.Name = "btnCertificateRefresh"
        btnCertificateRefresh.Size = New Size(146, 42)
        btnCertificateRefresh.TabIndex = 67
        btnCertificateRefresh.Text = "Refresh"
        btnCertificateRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartcertificationsrequest
        ' 
        ChartArea4.Name = "ChartArea1"
        chartcertificationsrequest.ChartAreas.Add(ChartArea4)
        chartcertificationsrequest.Dock = DockStyle.Fill
        Legend4.Name = "Legend1"
        chartcertificationsrequest.Legends.Add(Legend4)
        chartcertificationsrequest.Location = New Point(4, 454)
        chartcertificationsrequest.Margin = New Padding(4)
        chartcertificationsrequest.Name = "chartcertificationsrequest"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        chartcertificationsrequest.Series.Add(Series4)
        chartcertificationsrequest.Size = New Size(958, 442)
        chartcertificationsrequest.TabIndex = 63
        chartcertificationsrequest.Text = "Chart1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 587)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 48)
        Label2.TabIndex = 47
        Label2.Text = "Certifications Request"
        ' 
        ' dtpCertificates
        ' 
        dtpCertificates.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpCertificates.Location = New Point(10, 645)
        dtpCertificates.Margin = New Padding(2)
        dtpCertificates.Name = "dtpCertificates"
        dtpCertificates.Size = New Size(405, 39)
        dtpCertificates.TabIndex = 57
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(chartcomplaintincident, 1, 1)
        TableLayoutPanel1.Controls.Add(chartpaymentrevenue, 0, 0)
        TableLayoutPanel1.Controls.Add(chartcertificationsrequest, 0, 1)
        TableLayoutPanel1.Controls.Add(chartresidentinfo, 1, 0)
        TableLayoutPanel1.Location = New Point(6, 180)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1932, 900)
        TableLayoutPanel1.TabIndex = 66
        ' 
        ' frmSummary
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1946, 1114)
        Controls.Add(cbocertificaterequest)
        Controls.Add(cbocomplaints)
        Controls.Add(btnCertificateRefresh)
        Controls.Add(cbopayments)
        Controls.Add(Label2)
        Controls.Add(dtpCertificates)
        Controls.Add(btnComplaintRefresh)
        Controls.Add(cboresident)
        Controls.Add(dtpComplaints)
        Controls.Add(btnPaymentRefresh)
        Controls.Add(Label22)
        Controls.Add(Label5)
        Controls.Add(dtppayment)
        Controls.Add(btnResidentRefresh)
        Controls.Add(Label12)
        Controls.Add(dtpResidentInfo)
        Controls.Add(lblTitle)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSummary"
        CType(chartpaymentrevenue, ComponentModel.ISupportInitialize).EndInit()
        CType(chartresidentinfo, ComponentModel.ISupportInitialize).EndInit()
        CType(chartcomplaintincident, ComponentModel.ISupportInitialize).EndInit()
        CType(chartcertificationsrequest, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label12 As Label
    Friend WithEvents dtppayment As DateTimePicker
    Friend WithEvents dtpResidentInfo As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents chartpaymentrevenue As DataVisualization.Charting.Chart
    Friend WithEvents chartresidentinfo As DataVisualization.Charting.Chart
    Friend WithEvents chartcomplaintincident As DataVisualization.Charting.Chart
    Friend WithEvents dtpComplaints As DateTimePicker
    Friend WithEvents chartcertificationsrequest As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCertificates As DateTimePicker
    Friend WithEvents btnResidentRefresh As Button
    Friend WithEvents btnPaymentRefresh As Button
    Friend WithEvents btnComplaintRefresh As Button
    Friend WithEvents btnCertificateRefresh As Button
    Friend WithEvents cbopayments As ComboBox
    Friend WithEvents cboresident As ComboBox
    Friend WithEvents cbocomplaints As ComboBox
    Friend WithEvents cbocertificaterequest As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
