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
        lblTitle = New Label()
        btnAdd = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnResolved = New Button()
        txtComplaintID = New TextBox()
        txtResidentID = New TextBox()
        txtSubject = New TextBox()
        txtDetails = New TextBox()
        txtActionTaken = New TextBox()
        dtpComplaintDate = New DateTimePicker()
        cmbStatus = New ComboBox()
        dgvComplaints = New DataGridView()
        btnBlotter = New Button()
        dgvResolved = New DataGridView()
        txtrespondentname = New TextBox()
        Label8 = New Label()
        txtcomplaintname = New TextBox()
        Label9 = New Label()
        txtLocation = New TextBox()
        Label10 = New Label()
        txtIncidentDescription = New TextBox()
        Label11 = New Label()
        btnupdate = New Button()
        Label12 = New Label()
        Label13 = New Label()
        CType(dgvComplaints, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvResolved, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblTitle.Location = New Point(12, 9)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(284, 65)
        lblTitle.TabIndex = 22
        lblTitle.Text = "Complaints"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Khaki
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnAdd.Location = New Point(493, 1288)
        btnAdd.Margin = New Padding(4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(244, 64)
        btnAdd.TabIndex = 26
        btnAdd.Text = "Add Complaint"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 285)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 45)
        Label1.TabIndex = 31
        Label1.Text = "Complaint ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(30, 420)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 45)
        Label2.TabIndex = 32
        Label2.Text = "Respondent ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(951, 218)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(305, 45)
        Label3.TabIndex = 33
        Label3.Text = "Complaint Subject:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(951, 281)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(296, 45)
        Label4.TabIndex = 34
        Label4.Text = "Complaint Details:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(951, 468)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(264, 45)
        Label5.TabIndex = 35
        Label5.Text = "Complaint Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label6.Location = New Point(951, 534)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 45)
        Label6.TabIndex = 36
        Label6.Text = "Status:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(951, 599)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(220, 45)
        Label7.TabIndex = 37
        Label7.Text = "Action Taken:"
        ' 
        ' btnResolved
        ' 
        btnResolved.BackColor = Color.Khaki
        btnResolved.FlatAppearance.BorderSize = 0
        btnResolved.FlatStyle = FlatStyle.Popup
        btnResolved.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnResolved.Location = New Point(756, 1288)
        btnResolved.Margin = New Padding(4)
        btnResolved.Name = "btnResolved"
        btnResolved.Size = New Size(156, 64)
        btnResolved.TabIndex = 40
        btnResolved.Text = "Resolved"
        btnResolved.UseVisualStyleBackColor = False
        ' 
        ' txtComplaintID
        ' 
        txtComplaintID.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtComplaintID.Location = New Point(378, 285)
        txtComplaintID.Margin = New Padding(2)
        txtComplaintID.Name = "txtComplaintID"
        txtComplaintID.Size = New Size(553, 44)
        txtComplaintID.TabIndex = 41
        ' 
        ' txtResidentID
        ' 
        txtResidentID.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtResidentID.Location = New Point(378, 420)
        txtResidentID.Margin = New Padding(2)
        txtResidentID.Name = "txtResidentID"
        txtResidentID.Size = New Size(553, 44)
        txtResidentID.TabIndex = 42
        ' 
        ' txtSubject
        ' 
        txtSubject.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtSubject.Location = New Point(1284, 218)
        txtSubject.Margin = New Padding(2)
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(553, 44)
        txtSubject.TabIndex = 43
        ' 
        ' txtDetails
        ' 
        txtDetails.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtDetails.Location = New Point(1284, 284)
        txtDetails.Margin = New Padding(2)
        txtDetails.Multiline = True
        txtDetails.Name = "txtDetails"
        txtDetails.Size = New Size(553, 181)
        txtDetails.TabIndex = 44
        ' 
        ' txtActionTaken
        ' 
        txtActionTaken.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtActionTaken.Location = New Point(1284, 599)
        txtActionTaken.Margin = New Padding(2)
        txtActionTaken.Name = "txtActionTaken"
        txtActionTaken.Size = New Size(553, 44)
        txtActionTaken.TabIndex = 45
        ' 
        ' dtpComplaintDate
        ' 
        dtpComplaintDate.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpComplaintDate.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        dtpComplaintDate.Location = New Point(1284, 468)
        dtpComplaintDate.Margin = New Padding(4)
        dtpComplaintDate.Name = "dtpComplaintDate"
        dtpComplaintDate.Size = New Size(553, 44)
        dtpComplaintDate.TabIndex = 46
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Pending", "Ongoing", "Resolved"})
        cmbStatus.Location = New Point(1284, 532)
        cmbStatus.Margin = New Padding(4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(553, 46)
        cmbStatus.TabIndex = 47
        ' 
        ' dgvComplaints
        ' 
        dgvComplaints.AllowUserToAddRows = False
        dgvComplaints.AllowUserToDeleteRows = False
        dgvComplaints.BackgroundColor = Color.White
        dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvComplaints.Location = New Point(269, 762)
        dgvComplaints.Margin = New Padding(4)
        dgvComplaints.Name = "dgvComplaints"
        dgvComplaints.ReadOnly = True
        dgvComplaints.RowHeadersWidth = 51
        dgvComplaints.Size = New Size(729, 518)
        dgvComplaints.TabIndex = 48
        ' 
        ' btnBlotter
        ' 
        btnBlotter.BackColor = Color.Khaki
        btnBlotter.FlatAppearance.BorderSize = 0
        btnBlotter.FlatStyle = FlatStyle.Popup
        btnBlotter.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnBlotter.Location = New Point(943, 1288)
        btnBlotter.Margin = New Padding(4)
        btnBlotter.Name = "btnBlotter"
        btnBlotter.Size = New Size(228, 64)
        btnBlotter.TabIndex = 49
        btnBlotter.Text = "Set to Blotter"
        btnBlotter.UseVisualStyleBackColor = False
        ' 
        ' dgvResolved
        ' 
        dgvResolved.AllowUserToAddRows = False
        dgvResolved.AllowUserToDeleteRows = False
        dgvResolved.BackgroundColor = Color.White
        dgvResolved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResolved.Location = New Point(1031, 762)
        dgvResolved.Margin = New Padding(4)
        dgvResolved.Name = "dgvResolved"
        dgvResolved.ReadOnly = True
        dgvResolved.RowHeadersWidth = 51
        dgvResolved.Size = New Size(729, 518)
        dgvResolved.TabIndex = 50
        ' 
        ' txtrespondentname
        ' 
        txtrespondentname.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtrespondentname.Location = New Point(378, 356)
        txtrespondentname.Margin = New Padding(2)
        txtrespondentname.Name = "txtrespondentname"
        txtrespondentname.Size = New Size(553, 44)
        txtrespondentname.TabIndex = 52
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(30, 356)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(306, 45)
        Label8.TabIndex = 51
        Label8.Text = "Respondent Name:"
        ' 
        ' txtcomplaintname
        ' 
        txtcomplaintname.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtcomplaintname.Location = New Point(379, 216)
        txtcomplaintname.Margin = New Padding(2)
        txtcomplaintname.Name = "txtcomplaintname"
        txtcomplaintname.Size = New Size(553, 44)
        txtcomplaintname.TabIndex = 54
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(31, 216)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(318, 45)
        Label9.TabIndex = 53
        Label9.Text = "Complainant Name:"
        ' 
        ' txtLocation
        ' 
        txtLocation.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtLocation.Location = New Point(378, 486)
        txtLocation.Margin = New Padding(2)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(553, 44)
        txtLocation.TabIndex = 58
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(30, 486)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(157, 45)
        Label10.TabIndex = 57
        Label10.Text = "Location:"
        ' 
        ' txtIncidentDescription
        ' 
        txtIncidentDescription.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtIncidentDescription.Location = New Point(378, 550)
        txtIncidentDescription.Margin = New Padding(2)
        txtIncidentDescription.Multiline = True
        txtIncidentDescription.Name = "txtIncidentDescription"
        txtIncidentDescription.Size = New Size(553, 151)
        txtIncidentDescription.TabIndex = 56
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label11.Location = New Point(30, 550)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(333, 45)
        Label11.TabIndex = 55
        Label11.Text = "Incident Description:"
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.Khaki
        btnupdate.FlatAppearance.BorderSize = 0
        btnupdate.FlatStyle = FlatStyle.Popup
        btnupdate.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnupdate.Location = New Point(1188, 1288)
        btnupdate.Margin = New Padding(4)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(228, 64)
        btnupdate.TabIndex = 59
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label12.Location = New Point(1031, 713)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(343, 45)
        Label12.TabIndex = 60
        Label12.Text = "Resolved Complaints:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label13.Location = New Point(269, 713)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(330, 45)
        Label13.TabIndex = 61
        Label13.Text = "Pending Complaints:"
        ' 
        ' frmcomplaints
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1924, 1396)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(btnupdate)
        Controls.Add(txtLocation)
        Controls.Add(Label10)
        Controls.Add(txtIncidentDescription)
        Controls.Add(Label11)
        Controls.Add(txtcomplaintname)
        Controls.Add(Label9)
        Controls.Add(txtrespondentname)
        Controls.Add(Label8)
        Controls.Add(dgvResolved)
        Controls.Add(btnBlotter)
        Controls.Add(dgvComplaints)
        Controls.Add(cmbStatus)
        Controls.Add(dtpComplaintDate)
        Controls.Add(txtActionTaken)
        Controls.Add(txtDetails)
        Controls.Add(txtSubject)
        Controls.Add(txtResidentID)
        Controls.Add(txtComplaintID)
        Controls.Add(btnResolved)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAdd)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
        Name = "frmcomplaints"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmcomplaints"
        CType(dgvComplaints, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvResolved, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnResolved As Button
    Friend WithEvents txtComplaintID As TextBox
    Friend WithEvents txtResidentID As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtActionTaken As TextBox
    Friend WithEvents dtpComplaintDate As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dgvComplaints As DataGridView
    Friend WithEvents btnBlotter As Button
    Friend WithEvents dgvResolved As DataGridView
    Friend WithEvents txtrespondentname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcomplaintname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIncidentDescription As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
