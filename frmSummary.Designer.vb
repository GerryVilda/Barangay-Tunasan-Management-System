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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        Panel2 = New Panel()
        cbopayments = New ComboBox()
        btnPaymentRefresh = New Button()
        chartpaymentrevenue = New DataVisualization.Charting.Chart()
        Label5 = New Label()
        dtppayment = New DateTimePicker()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel3 = New Panel()
        cboresident = New ComboBox()
        btnResidentRefresh = New Button()
        chartresidentinfo = New DataVisualization.Charting.Chart()
        Label12 = New Label()
        dtpResidentInfo = New DateTimePicker()
        Panel4 = New Panel()
        cbocomplaints = New ComboBox()
        btnComplaintRefresh = New Button()
        dtpComplaints = New DateTimePicker()
        chartcomplaintincident = New DataVisualization.Charting.Chart()
        Label22 = New Label()
        Panel5 = New Panel()
        cbocertificaterequest = New ComboBox()
        btnCertificateRefresh = New Button()
        chartcertificationsrequest = New DataVisualization.Charting.Chart()
        Label2 = New Label()
        dtpCertificates = New DateTimePicker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(chartpaymentrevenue, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(chartresidentinfo, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(chartcomplaintincident, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(chartcertificationsrequest, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.Controls.Add(cbopayments)
        Panel2.Controls.Add(btnPaymentRefresh)
        Panel2.Controls.Add(chartpaymentrevenue)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(dtppayment)
        Panel2.Location = New Point(13, 196)
        Panel2.Margin = New Padding(4, 2, 4, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1021, 569)
        Panel2.TabIndex = 46
        ' 
        ' cbopayments
        ' 
        cbopayments.FormattingEnabled = True
        cbopayments.Location = New Point(394, 69)
        cbopayments.Name = "cbopayments"
        cbopayments.Size = New Size(214, 33)
        cbopayments.TabIndex = 65
        ' 
        ' btnPaymentRefresh
        ' 
        btnPaymentRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPaymentRefresh.Location = New Point(462, 12)
        btnPaymentRefresh.Margin = New Padding(2)
        btnPaymentRefresh.Name = "btnPaymentRefresh"
        btnPaymentRefresh.Size = New Size(146, 42)
        btnPaymentRefresh.TabIndex = 64
        btnPaymentRefresh.Text = "Refresh"
        btnPaymentRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartpaymentrevenue
        ' 
        ChartArea5.Name = "ChartArea1"
        chartpaymentrevenue.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        chartpaymentrevenue.Legends.Add(Legend5)
        chartpaymentrevenue.Location = New Point(4, 111)
        chartpaymentrevenue.Margin = New Padding(4)
        chartpaymentrevenue.Name = "chartpaymentrevenue"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        chartpaymentrevenue.Series.Add(Series5)
        chartpaymentrevenue.Size = New Size(1012, 452)
        chartpaymentrevenue.TabIndex = 63
        chartpaymentrevenue.Text = "Chart1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(4, 4)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(414, 48)
        Label5.TabIndex = 47
        Label5.Text = "Payments and Revenue"
        ' 
        ' dtppayment
        ' 
        dtppayment.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtppayment.Location = New Point(4, 66)
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(cboresident)
        Panel3.Controls.Add(btnResidentRefresh)
        Panel3.Controls.Add(chartresidentinfo)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(dtpResidentInfo)
        Panel3.Location = New Point(1037, 196)
        Panel3.Margin = New Padding(4, 2, 4, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(870, 569)
        Panel3.TabIndex = 55
        ' 
        ' cboresident
        ' 
        cboresident.FormattingEnabled = True
        cboresident.Location = New Point(413, 69)
        cboresident.Name = "cboresident"
        cboresident.Size = New Size(195, 33)
        cboresident.TabIndex = 66
        ' 
        ' btnResidentRefresh
        ' 
        btnResidentRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnResidentRefresh.Location = New Point(462, 12)
        btnResidentRefresh.Margin = New Padding(2)
        btnResidentRefresh.Name = "btnResidentRefresh"
        btnResidentRefresh.Size = New Size(146, 42)
        btnResidentRefresh.TabIndex = 65
        btnResidentRefresh.Text = "Refresh"
        btnResidentRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartresidentinfo
        ' 
        ChartArea6.Name = "ChartArea1"
        chartresidentinfo.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        chartresidentinfo.Legends.Add(Legend6)
        chartresidentinfo.Location = New Point(4, 111)
        chartresidentinfo.Margin = New Padding(4)
        chartresidentinfo.Name = "chartresidentinfo"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        chartresidentinfo.Series.Add(Series6)
        chartresidentinfo.Size = New Size(862, 452)
        chartresidentinfo.TabIndex = 48
        chartresidentinfo.Text = "Chart2"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(4, 4)
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
        Panel4.Controls.Add(cbocomplaints)
        Panel4.Controls.Add(btnComplaintRefresh)
        Panel4.Controls.Add(dtpComplaints)
        Panel4.Controls.Add(chartcomplaintincident)
        Panel4.Controls.Add(Label22)
        Panel4.Location = New Point(1037, 774)
        Panel4.Margin = New Padding(4, 2, 4, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(870, 569)
        Panel4.TabIndex = 62
        ' 
        ' cbocomplaints
        ' 
        cbocomplaints.FormattingEnabled = True
        cbocomplaints.Location = New Point(409, 71)
        cbocomplaints.Name = "cbocomplaints"
        cbocomplaints.Size = New Size(195, 33)
        cbocomplaints.TabIndex = 66
        ' 
        ' btnComplaintRefresh
        ' 
        btnComplaintRefresh.Location = New Point(458, 12)
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
        dtpComplaints.Location = New Point(4, 71)
        dtpComplaints.Margin = New Padding(2)
        dtpComplaints.Name = "dtpComplaints"
        dtpComplaints.Size = New Size(402, 39)
        dtpComplaints.TabIndex = 59
        ' 
        ' chartcomplaintincident
        ' 
        ChartArea7.Name = "ChartArea1"
        chartcomplaintincident.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        chartcomplaintincident.Legends.Add(Legend7)
        chartcomplaintincident.Location = New Point(4, 111)
        chartcomplaintincident.Margin = New Padding(4)
        chartcomplaintincident.Name = "chartcomplaintincident"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        chartcomplaintincident.Series.Add(Series7)
        chartcomplaintincident.Size = New Size(862, 452)
        chartcomplaintincident.TabIndex = 48
        chartcomplaintincident.Text = "Chart3"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 16.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(4, 4)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(425, 46)
        Label22.TabIndex = 47
        Label22.Text = "Complaints and Incidents"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Controls.Add(cbocertificaterequest)
        Panel5.Controls.Add(btnCertificateRefresh)
        Panel5.Controls.Add(chartcertificationsrequest)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(dtpCertificates)
        Panel5.Location = New Point(12, 774)
        Panel5.Margin = New Padding(4, 2, 4, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1021, 569)
        Panel5.TabIndex = 64
        ' 
        ' cbocertificaterequest
        ' 
        cbocertificaterequest.FormattingEnabled = True
        cbocertificaterequest.Location = New Point(417, 68)
        cbocertificaterequest.Name = "cbocertificaterequest"
        cbocertificaterequest.Size = New Size(195, 33)
        cbocertificaterequest.TabIndex = 67
        ' 
        ' btnCertificateRefresh
        ' 
        btnCertificateRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnCertificateRefresh.Location = New Point(466, 10)
        btnCertificateRefresh.Margin = New Padding(2)
        btnCertificateRefresh.Name = "btnCertificateRefresh"
        btnCertificateRefresh.Size = New Size(146, 42)
        btnCertificateRefresh.TabIndex = 67
        btnCertificateRefresh.Text = "Refresh"
        btnCertificateRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartcertificationsrequest
        ' 
        ChartArea8.Name = "ChartArea1"
        chartcertificationsrequest.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        chartcertificationsrequest.Legends.Add(Legend8)
        chartcertificationsrequest.Location = New Point(4, 111)
        chartcertificationsrequest.Margin = New Padding(4)
        chartcertificationsrequest.Name = "chartcertificationsrequest"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        chartcertificationsrequest.Series.Add(Series8)
        chartcertificationsrequest.Size = New Size(1013, 452)
        chartcertificationsrequest.TabIndex = 63
        chartcertificationsrequest.Text = "Chart1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(4, 4)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 48)
        Label2.TabIndex = 47
        Label2.Text = "Certifications Request"
        ' 
        ' dtpCertificates
        ' 
        dtpCertificates.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpCertificates.Location = New Point(2, 62)
        dtpCertificates.Margin = New Padding(2)
        dtpCertificates.Name = "dtpCertificates"
        dtpCertificates.Size = New Size(405, 39)
        dtpCertificates.TabIndex = 57
        ' 
        ' frmSummary
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1946, 1114)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
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
    Friend WithEvents dtppayment As DateTimePicker
    Friend WithEvents dtpResidentInfo As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents chartpaymentrevenue As DataVisualization.Charting.Chart
    Friend WithEvents chartresidentinfo As DataVisualization.Charting.Chart
    Friend WithEvents chartcomplaintincident As DataVisualization.Charting.Chart
    Friend WithEvents dtpComplaints As DateTimePicker
    Friend WithEvents Panel5 As Panel
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
End Class
