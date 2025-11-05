<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcomplaints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcomplaints))
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        lblSearch = New Label()
        txtSearch = New TextBox()
        btnAdd = New Button()
        panelPending = New Panel()
        lblPendingCount = New Label()
        lblPending = New Label()
        panelResolved = New Panel()
        lblResolvedCount = New Label()
        lblResolved = New Label()
        panelTotal = New Panel()
        lblTotalCount = New Label()
        lblTotalComplaints = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnSaveDb = New Button()
        btnClear = New Button()
        btnCancel = New Button()
        txtComplaintID = New TextBox()
        txtResidentID = New TextBox()
        txtSubject = New TextBox()
        txtDetails = New TextBox()
        txtActionTaken = New TextBox()
        dtpComplaintDate = New DateTimePicker()
        cmbStatus = New ComboBox()
        dgvComplaints = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelPending.SuspendLayout()
        panelResolved.SuspendLayout()
        panelTotal.SuspendLayout()
        CType(dgvComplaints, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblTitle.Location = New Point(179, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(207, 46)
        lblTitle.TabIndex = 22
        lblTitle.Text = "Complaints"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(191, 60)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(77, 28)
        lblSearch.TabIndex = 24
        lblSearch.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(273, 61)
        txtSearch.Margin = New Padding(2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(218, 27)
        txtSearch.TabIndex = 25
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Khaki
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(38, 650)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(162, 39)
        btnAdd.TabIndex = 26
        btnAdd.Text = "Add Complaint"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' panelPending
        ' 
        panelPending.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        panelPending.Controls.Add(lblPendingCount)
        panelPending.Controls.Add(lblPending)
        panelPending.Location = New Point(191, 114)
        panelPending.Name = "panelPending"
        panelPending.Size = New Size(250, 125)
        panelPending.TabIndex = 28
        ' 
        ' lblPendingCount
        ' 
        lblPendingCount.AutoSize = True
        lblPendingCount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPendingCount.Location = New Point(114, 64)
        lblPendingCount.Name = "lblPendingCount"
        lblPendingCount.Size = New Size(23, 28)
        lblPendingCount.TabIndex = 1
        lblPendingCount.Text = "0"
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPending.Location = New Point(82, 21)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(87, 28)
        lblPending.TabIndex = 0
        lblPending.Text = "Pending"
        ' 
        ' panelResolved
        ' 
        panelResolved.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        panelResolved.Controls.Add(lblResolvedCount)
        panelResolved.Controls.Add(lblResolved)
        panelResolved.Location = New Point(516, 114)
        panelResolved.Name = "panelResolved"
        panelResolved.Size = New Size(250, 125)
        panelResolved.TabIndex = 29
        ' 
        ' lblResolvedCount
        ' 
        lblResolvedCount.AutoSize = True
        lblResolvedCount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResolvedCount.Location = New Point(118, 64)
        lblResolvedCount.Name = "lblResolvedCount"
        lblResolvedCount.Size = New Size(23, 28)
        lblResolvedCount.TabIndex = 2
        lblResolvedCount.Text = "0"
        ' 
        ' lblResolved
        ' 
        lblResolved.AutoSize = True
        lblResolved.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResolved.Location = New Point(80, 21)
        lblResolved.Name = "lblResolved"
        lblResolved.Size = New Size(93, 28)
        lblResolved.TabIndex = 1
        lblResolved.Text = "Resolved"
        ' 
        ' panelTotal
        ' 
        panelTotal.BackColor = Color.FromArgb(CByte(23), CByte(162), CByte(184))
        panelTotal.Controls.Add(lblTotalCount)
        panelTotal.Controls.Add(lblTotalComplaints)
        panelTotal.Location = New Point(838, 114)
        panelTotal.Name = "panelTotal"
        panelTotal.Size = New Size(250, 125)
        panelTotal.TabIndex = 30
        ' 
        ' lblTotalCount
        ' 
        lblTotalCount.AutoSize = True
        lblTotalCount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCount.Location = New Point(113, 64)
        lblTotalCount.Name = "lblTotalCount"
        lblTotalCount.Size = New Size(23, 28)
        lblTotalCount.TabIndex = 3
        lblTotalCount.Text = "0"
        ' 
        ' lblTotalComplaints
        ' 
        lblTotalComplaints.AutoSize = True
        lblTotalComplaints.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalComplaints.Location = New Point(47, 21)
        lblTotalComplaints.Name = "lblTotalComplaints"
        lblTotalComplaints.Size = New Size(163, 28)
        lblTotalComplaints.TabIndex = 2
        lblTotalComplaints.Text = "Total Complaints"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 28)
        Label1.TabIndex = 31
        Label1.Text = "Complaint ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 362)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 28)
        Label2.TabIndex = 32
        Label2.Text = "Resident ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 406)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 28)
        Label3.TabIndex = 33
        Label3.Text = "Complaint Subject:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 451)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 28)
        Label4.TabIndex = 34
        Label4.Text = "Complaint Details:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(38, 499)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 28)
        Label5.TabIndex = 35
        Label5.Text = "Complaint Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(38, 545)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 28)
        Label6.TabIndex = 36
        Label6.Text = "Status:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(38, 588)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 28)
        Label7.TabIndex = 37
        Label7.Text = "Action Taken:"
        ' 
        ' btnSaveDb
        ' 
        btnSaveDb.BackColor = Color.Khaki
        btnSaveDb.FlatAppearance.BorderSize = 0
        btnSaveDb.FlatStyle = FlatStyle.Popup
        btnSaveDb.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveDb.Location = New Point(206, 650)
        btnSaveDb.Name = "btnSaveDb"
        btnSaveDb.Size = New Size(186, 39)
        btnSaveDb.TabIndex = 38
        btnSaveDb.Text = "Save to Database"
        btnSaveDb.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Khaki
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(398, 650)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(87, 39)
        btnClear.TabIndex = 39
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Khaki
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(491, 650)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(98, 39)
        btnCancel.TabIndex = 40
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtComplaintID
        ' 
        txtComplaintID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComplaintID.Location = New Point(246, 309)
        txtComplaintID.Margin = New Padding(2)
        txtComplaintID.Name = "txtComplaintID"
        txtComplaintID.Size = New Size(343, 34)
        txtComplaintID.TabIndex = 41
        ' 
        ' txtResidentID
        ' 
        txtResidentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtResidentID.Location = New Point(246, 356)
        txtResidentID.Margin = New Padding(2)
        txtResidentID.Name = "txtResidentID"
        txtResidentID.Size = New Size(343, 34)
        txtResidentID.TabIndex = 42
        ' 
        ' txtSubject
        ' 
        txtSubject.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSubject.Location = New Point(246, 400)
        txtSubject.Margin = New Padding(2)
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(343, 34)
        txtSubject.TabIndex = 43
        ' 
        ' txtDetails
        ' 
        txtDetails.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDetails.Location = New Point(246, 445)
        txtDetails.Margin = New Padding(2)
        txtDetails.Name = "txtDetails"
        txtDetails.Size = New Size(343, 34)
        txtDetails.TabIndex = 44
        ' 
        ' txtActionTaken
        ' 
        txtActionTaken.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtActionTaken.Location = New Point(246, 582)
        txtActionTaken.Margin = New Padding(2)
        txtActionTaken.Name = "txtActionTaken"
        txtActionTaken.Size = New Size(343, 34)
        txtActionTaken.TabIndex = 45
        ' 
        ' dtpComplaintDate
        ' 
        dtpComplaintDate.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpComplaintDate.Location = New Point(246, 501)
        dtpComplaintDate.Name = "dtpComplaintDate"
        dtpComplaintDate.Size = New Size(343, 27)
        dtpComplaintDate.TabIndex = 46
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Pending", "Resolved"})
        cmbStatus.Location = New Point(246, 537)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(343, 36)
        cmbStatus.TabIndex = 47
        ' 
        ' dgvComplaints
        ' 
        dgvComplaints.AllowUserToAddRows = False
        dgvComplaints.AllowUserToDeleteRows = False
        dgvComplaints.BackgroundColor = Color.White
        dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvComplaints.Location = New Point(634, 309)
        dgvComplaints.Name = "dgvComplaints"
        dgvComplaints.ReadOnly = True
        dgvComplaints.RowHeadersWidth = 51
        dgvComplaints.Size = New Size(479, 380)
        dgvComplaints.TabIndex = 48
        ' 
        ' frmcomplaints
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1539, 844)
        Controls.Add(dgvComplaints)
        Controls.Add(cmbStatus)
        Controls.Add(dtpComplaintDate)
        Controls.Add(txtActionTaken)
        Controls.Add(txtDetails)
        Controls.Add(txtSubject)
        Controls.Add(txtResidentID)
        Controls.Add(txtComplaintID)
        Controls.Add(btnCancel)
        Controls.Add(btnClear)
        Controls.Add(btnSaveDb)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(panelTotal)
        Controls.Add(panelResolved)
        Controls.Add(panelPending)
        Controls.Add(btnAdd)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
        Name = "frmcomplaints"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmcomplaints"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelPending.ResumeLayout(False)
        panelPending.PerformLayout()
        panelResolved.ResumeLayout(False)
        panelResolved.PerformLayout()
        panelTotal.ResumeLayout(False)
        panelTotal.PerformLayout()
        CType(dgvComplaints, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents panelPending As Panel
    Friend WithEvents panelResolved As Panel
    Friend WithEvents panelTotal As Panel
    Friend WithEvents lblPending As Label
    Friend WithEvents lblResolved As Label
    Friend WithEvents lblTotalComplaints As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblResolvedCount As Label
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSaveDb As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtComplaintID As TextBox
    Friend WithEvents txtResidentID As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtActionTaken As TextBox
    Friend WithEvents dtpComplaintDate As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dgvComplaints As DataGridView
End Class
