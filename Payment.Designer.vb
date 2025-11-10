<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        txtresidentname = New TextBox()
        Label14 = New Label()
        txtrequestid = New TextBox()
        Label17 = New Label()
        cmbSitio = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        txtResidentid = New TextBox()
        cmbcertificateType = New ComboBox()
        btnPaid = New Button()
        txtReceiptNo = New TextBox()
        dtpDate = New DateTimePicker()
        txtAmount = New TextBox()
        txtPaymentID = New TextBox()
        Panel3 = New Panel()
        Label12 = New Label()
        Panel2 = New Panel()
        cbostatus = New ComboBox()
        txtfee = New TextBox()
        txtpurpose = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        Label7 = New Label()
        Label13 = New Label()
        dtgforpayments = New DataGridView()
        dgvtransactions_history = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dtgforpayments, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvtransactions_history, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(224, 29)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 65)
        Label1.TabIndex = 44
        Label1.Text = "Payment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 60)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 32)
        Label2.TabIndex = 45
        Label2.Text = "Payment ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 50)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 32)
        Label3.TabIndex = 46
        Label3.Text = "Resident ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 50)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 32)
        Label4.TabIndex = 47
        Label4.Text = "Certificate Type:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 120)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 32)
        Label5.TabIndex = 48
        Label5.Text = "Amount:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(24, 181)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 32)
        Label6.TabIndex = 50
        Label6.Text = "Date:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(24, 240)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 32)
        Label8.TabIndex = 52
        Label8.Text = "Receipt Number:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtresidentname)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtrequestid)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(cmbSitio)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtResidentid)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(127, 196)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(778, 288)
        Panel1.TabIndex = 56
        ' 
        ' txtresidentname
        ' 
        txtresidentname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtresidentname.Location = New Point(238, 103)
        txtresidentname.Margin = New Padding(4)
        txtresidentname.Name = "txtresidentname"
        txtresidentname.ReadOnly = True
        txtresidentname.Size = New Size(492, 39)
        txtresidentname.TabIndex = 63
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(24, 107)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(185, 32)
        Label14.TabIndex = 62
        Label14.Text = "Resident Name:"
        ' 
        ' txtrequestid
        ' 
        txtrequestid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtrequestid.Location = New Point(238, 222)
        txtrequestid.Margin = New Padding(4)
        txtrequestid.Name = "txtrequestid"
        txtrequestid.Size = New Size(492, 39)
        txtrequestid.TabIndex = 61
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(24, 225)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(138, 32)
        Label17.TabIndex = 60
        Label17.Text = "Request ID:"
        ' 
        ' cmbSitio
        ' 
        cmbSitio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbSitio.FormattingEnabled = True
        cmbSitio.Items.AddRange(New Object() {"Camella Homes III", "Lake Shore Subdivision", "Lindenwood Residences", "Midland II Subdivision", "Parkhomes Subdivision", "Planas", "Sto. Niño Village", "Susana Heights Subdivision", "Villa Carolina I", "Villa Carolina II"})
        cmbSitio.Location = New Point(238, 161)
        cmbSitio.Margin = New Padding(4)
        cmbSitio.Name = "cmbSitio"
        cmbSitio.Size = New Size(492, 40)
        cmbSitio.TabIndex = 59
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(24, 164)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 32)
        Label11.TabIndex = 58
        Label11.Text = "Sitio:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label10.Location = New Point(4, 4)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(299, 38)
        Label10.TabIndex = 57
        Label10.Text = "Resident Information"
        ' 
        ' txtResidentid
        ' 
        txtResidentid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResidentid.Location = New Point(238, 46)
        txtResidentid.Margin = New Padding(4)
        txtResidentid.Name = "txtResidentid"
        txtResidentid.ReadOnly = True
        txtResidentid.Size = New Size(492, 39)
        txtResidentid.TabIndex = 48
        ' 
        ' cmbcertificateType
        ' 
        cmbcertificateType.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbcertificateType.FormattingEnabled = True
        cmbcertificateType.Location = New Point(238, 46)
        cmbcertificateType.Margin = New Padding(4)
        cmbcertificateType.Name = "cmbcertificateType"
        cmbcertificateType.Size = New Size(492, 40)
        cmbcertificateType.TabIndex = 49
        ' 
        ' btnPaid
        ' 
        btnPaid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnPaid.FlatAppearance.BorderSize = 0
        btnPaid.FlatStyle = FlatStyle.Flat
        btnPaid.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPaid.ForeColor = Color.Black
        btnPaid.Location = New Point(1664, 94)
        btnPaid.Margin = New Padding(4)
        btnPaid.Name = "btnPaid"
        btnPaid.Size = New Size(118, 59)
        btnPaid.TabIndex = 57
        btnPaid.Text = "Paid"
        btnPaid.UseVisualStyleBackColor = False
        ' 
        ' txtReceiptNo
        ' 
        txtReceiptNo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReceiptNo.Location = New Point(238, 236)
        txtReceiptNo.Margin = New Padding(4)
        txtReceiptNo.Name = "txtReceiptNo"
        txtReceiptNo.ReadOnly = True
        txtReceiptNo.Size = New Size(492, 39)
        txtReceiptNo.TabIndex = 53
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(238, 175)
        dtpDate.Margin = New Padding(4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(492, 39)
        dtpDate.TabIndex = 52
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAmount.Location = New Point(238, 116)
        txtAmount.Margin = New Padding(4)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(492, 39)
        txtAmount.TabIndex = 50
        ' 
        ' txtPaymentID
        ' 
        txtPaymentID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPaymentID.Location = New Point(238, 53)
        txtPaymentID.Margin = New Padding(4)
        txtPaymentID.Name = "txtPaymentID"
        txtPaymentID.ReadOnly = True
        txtPaymentID.Size = New Size(492, 39)
        txtPaymentID.TabIndex = 46
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txtPaymentID)
        Panel3.Controls.Add(txtReceiptNo)
        Panel3.Controls.Add(txtAmount)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(dtpDate)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(1004, 161)
        Panel3.Margin = New Padding(4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(778, 292)
        Panel3.TabIndex = 59
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label12.Location = New Point(4, 4)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(238, 38)
        Label12.TabIndex = 60
        Label12.Text = "Payment Details"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cbostatus)
        Panel2.Controls.Add(txtfee)
        Panel2.Controls.Add(txtpurpose)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(cmbcertificateType)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label13)
        Panel2.Location = New Point(127, 492)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(778, 640)
        Panel2.TabIndex = 61
        ' 
        ' cbostatus
        ' 
        cbostatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbostatus.FormattingEnabled = True
        cbostatus.Location = New Point(238, 127)
        cbostatus.Margin = New Padding(4)
        cbostatus.Name = "cbostatus"
        cbostatus.Size = New Size(492, 40)
        cbostatus.TabIndex = 62
        ' 
        ' txtfee
        ' 
        txtfee.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtfee.Location = New Point(238, 206)
        txtfee.Margin = New Padding(4)
        txtfee.Name = "txtfee"
        txtfee.Size = New Size(492, 39)
        txtfee.TabIndex = 60
        ' 
        ' txtpurpose
        ' 
        txtpurpose.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpurpose.Location = New Point(201, 414)
        txtpurpose.Margin = New Padding(4)
        txtpurpose.Multiline = True
        txtpurpose.Name = "txtpurpose"
        txtpurpose.Size = New Size(529, 194)
        txtpurpose.TabIndex = 60
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(30, 417)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(108, 32)
        Label16.TabIndex = 67
        Label16.Text = "Purpose:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(24, 135)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(87, 32)
        Label15.TabIndex = 65
        Label15.Text = "Status:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label7.Location = New Point(4, 4)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(259, 38)
        Label7.TabIndex = 60
        Label7.Text = "Certificate Details"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(24, 213)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(134, 32)
        Label13.TabIndex = 61
        Label13.Text = "Fee Range:"
        ' 
        ' dtgforpayments
        ' 
        dtgforpayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgforpayments.Location = New Point(1003, 460)
        dtgforpayments.Name = "dtgforpayments"
        dtgforpayments.RowHeadersWidth = 62
        dtgforpayments.Size = New Size(779, 354)
        dtgforpayments.TabIndex = 62
        ' 
        ' dgvtransactions_history
        ' 
        dgvtransactions_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvtransactions_history.Location = New Point(1003, 820)
        dgvtransactions_history.Name = "dgvtransactions_history"
        dgvtransactions_history.RowHeadersWidth = 62
        dgvtransactions_history.Size = New Size(779, 354)
        dgvtransactions_history.TabIndex = 63
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1924, 1219)
        Controls.Add(dgvtransactions_history)
        Controls.Add(dtgforpayments)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(btnPaid)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        Name = "Payment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dtgforpayments, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvtransactions_history, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbcertificateType As ComboBox
    Friend WithEvents txtResidentid As TextBox
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents btnPaid As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbSitio As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtgforpayments As DataGridView
    Friend WithEvents txtpurpose As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtfee As TextBox
    Friend WithEvents txtrequestid As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents txtresidentname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvtransactions_history As DataGridView
End Class
