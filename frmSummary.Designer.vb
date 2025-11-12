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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummary))
        lblTitle = New Label()
        cbocertificate = New ComboBox()
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
        btnComplaintRefresh = New Button()
        dtpComplaints = New DateTimePicker()
        chartcomplaintincident = New DataVisualization.Charting.Chart()
        Label22 = New Label()
        CType(chartpaymentrevenue, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartresidentinfo, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartcomplaintincident, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblTitle.Location = New Point(5, 7)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(318, 46)
        lblTitle.TabIndex = 44
        lblTitle.Text = "Reports Summary"
        ' 
        ' cbocertificate
        ' 
        cbocertificate.FormattingEnabled = True
        cbocertificate.Location = New Point(107, 107)
        cbocertificate.Margin = New Padding(2, 2, 2, 2)
        cbocertificate.Name = "cbocertificate"
        cbocertificate.Size = New Size(309, 28)
        cbocertificate.TabIndex = 65
        ' 
        ' btnPaymentRefresh
        ' 
        btnPaymentRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPaymentRefresh.Location = New Point(107, 138)
        btnPaymentRefresh.Margin = New Padding(2)
        btnPaymentRefresh.Name = "btnPaymentRefresh"
        btnPaymentRefresh.Size = New Size(308, 34)
        btnPaymentRefresh.TabIndex = 64
        btnPaymentRefresh.Text = "Refresh"
        btnPaymentRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartpaymentrevenue
        ' 
        ChartArea1.Name = "ChartArea1"
        chartpaymentrevenue.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        chartpaymentrevenue.Legends.Add(Legend1)
        chartpaymentrevenue.Location = New Point(5, 177)
        chartpaymentrevenue.Name = "chartpaymentrevenue"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chartpaymentrevenue.Series.Add(Series1)
        chartpaymentrevenue.Size = New Size(509, 513)
        chartpaymentrevenue.TabIndex = 63
        chartpaymentrevenue.Text = "Chart1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(134, 707)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 41)
        Label5.TabIndex = 47
        Label5.Text = "Payments"
        ' 
        ' dtppayment
        ' 
        dtppayment.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtppayment.Location = New Point(107, 72)
        dtppayment.Margin = New Padding(2)
        dtppayment.Name = "dtppayment"
        dtppayment.Size = New Size(309, 34)
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
        cboresident.Location = New Point(1127, 111)
        cboresident.Margin = New Padding(2, 2, 2, 2)
        cboresident.Name = "cboresident"
        cboresident.Size = New Size(322, 28)
        cboresident.TabIndex = 66
        ' 
        ' btnResidentRefresh
        ' 
        btnResidentRefresh.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnResidentRefresh.Location = New Point(1128, 142)
        btnResidentRefresh.Margin = New Padding(2)
        btnResidentRefresh.Name = "btnResidentRefresh"
        btnResidentRefresh.Size = New Size(321, 34)
        btnResidentRefresh.TabIndex = 65
        btnResidentRefresh.Text = "Refresh"
        btnResidentRefresh.UseVisualStyleBackColor = True
        ' 
        ' chartresidentinfo
        ' 
        ChartArea2.Name = "ChartArea1"
        chartresidentinfo.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        chartresidentinfo.Legends.Add(Legend2)
        chartresidentinfo.Location = New Point(1033, 177)
        chartresidentinfo.Name = "chartresidentinfo"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        chartresidentinfo.Series.Add(Series2)
        chartresidentinfo.Size = New Size(497, 513)
        chartresidentinfo.TabIndex = 48
        chartresidentinfo.Text = "Chart2"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(1114, 707)
        Label12.Name = "Label12"
        Label12.Size = New Size(316, 41)
        Label12.TabIndex = 47
        Label12.Text = "Resident Information"
        ' 
        ' dtpResidentInfo
        ' 
        dtpResidentInfo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpResidentInfo.Location = New Point(1127, 76)
        dtpResidentInfo.Margin = New Padding(2)
        dtpResidentInfo.Name = "dtpResidentInfo"
        dtpResidentInfo.Size = New Size(322, 34)
        dtpResidentInfo.TabIndex = 58
        ' 
        ' btnComplaintRefresh
        ' 
        btnComplaintRefresh.Location = New Point(610, 142)
        btnComplaintRefresh.Margin = New Padding(2)
        btnComplaintRefresh.Name = "btnComplaintRefresh"
        btnComplaintRefresh.Size = New Size(322, 34)
        btnComplaintRefresh.TabIndex = 66
        btnComplaintRefresh.Text = "Refresh"
        btnComplaintRefresh.UseVisualStyleBackColor = True
        ' 
        ' dtpComplaints
        ' 
        dtpComplaints.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpComplaints.Location = New Point(610, 106)
        dtpComplaints.Margin = New Padding(2)
        dtpComplaints.Name = "dtpComplaints"
        dtpComplaints.Size = New Size(322, 34)
        dtpComplaints.TabIndex = 59
        ' 
        ' chartcomplaintincident
        ' 
        ChartArea3.Name = "ChartArea1"
        chartcomplaintincident.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        chartcomplaintincident.Legends.Add(Legend3)
        chartcomplaintincident.Location = New Point(520, 177)
        chartcomplaintincident.Name = "chartcomplaintincident"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        chartcomplaintincident.Series.Add(Series3)
        chartcomplaintincident.Size = New Size(506, 513)
        chartcomplaintincident.TabIndex = 48
        chartcomplaintincident.Text = "Chart3"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 16.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(590, 709)
        Label22.Name = "Label22"
        Label22.Size = New Size(359, 40)
        Label22.TabIndex = 47
        Label22.Text = "Complaints and Incidents"
        ' 
        ' frmSummary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1554, 882)
        Controls.Add(chartcomplaintincident)
        Controls.Add(chartresidentinfo)
        Controls.Add(chartpaymentrevenue)
        Controls.Add(cbocertificate)
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
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSummary"
        CType(chartpaymentrevenue, ComponentModel.ISupportInitialize).EndInit()
        CType(chartresidentinfo, ComponentModel.ISupportInitialize).EndInit()
        CType(chartcomplaintincident, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnResidentRefresh As Button
    Friend WithEvents btnPaymentRefresh As Button
    Friend WithEvents btnComplaintRefresh As Button
    Friend WithEvents cbocertificate As ComboBox
    Friend WithEvents cboresident As ComboBox
End Class
