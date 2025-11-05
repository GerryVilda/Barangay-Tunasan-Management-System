<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmincident
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmincident))
        Panel1 = New Panel()
        btnRefresh = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lblTotal = New Label()
        Label8 = New Label()
        lblResolved = New Label()
        Label6 = New Label()
        lblPending = New Label()
        Label4 = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Label3 = New Label()
        cmbFilterStatus = New ComboBox()
        Label2 = New Label()
        Panel4 = New Panel()
        txtDescription = New TextBox()
        Label7 = New Label()
        txtid = New TextBox()
        Label5 = New Label()
        cmbincident = New ComboBox()
        btnCancel = New Button()
        btnSave = New Button()
        cmbStatus = New ComboBox()
        Label15 = New Label()
        Label14 = New Label()
        txtRespondent = New TextBox()
        Label13 = New Label()
        txtComplainant = New TextBox()
        Label12 = New Label()
        dtpIncidents = New DateTimePicker()
        Label11 = New Label()
        Label10 = New Label()
        dgvIncidents = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvIncidents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(195, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(923, 52)
        Panel1.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Blue
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.Transparent
        btnRefresh.Location = New Point(794, 9)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(97, 32)
        btnRefresh.TabIndex = 26
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Transparent
        btnDelete.Location = New Point(668, 9)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(97, 32)
        btnDelete.TabIndex = 25
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(547, 9)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(97, 32)
        btnEdit.TabIndex = 24
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.Transparent
        btnAdd.Location = New Point(430, 9)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(97, 32)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add New"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(3, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 46)
        Label1.TabIndex = 22
        Label1.Text = "Incident Reports"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblTotal)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(lblResolved)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(lblPending)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(cmbFilterStatus)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(195, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(923, 74)
        Panel2.TabIndex = 22
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(436, 41)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(22, 25)
        lblTotal.TabIndex = 10
        lblTotal.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(370, 38)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 28)
        Label8.TabIndex = 9
        Label8.Text = "Total:"
        ' 
        ' lblResolved
        ' 
        lblResolved.AutoSize = True
        lblResolved.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResolved.Location = New Point(323, 41)
        lblResolved.Name = "lblResolved"
        lblResolved.Size = New Size(22, 25)
        lblResolved.TabIndex = 8
        lblResolved.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(219, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 28)
        Label6.TabIndex = 7
        Label6.Text = "Resolved:"
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPending.Location = New Point(160, 41)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(22, 25)
        lblPending.TabIndex = 6
        lblPending.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(62, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 28)
        Label4.TabIndex = 5
        Label4.Text = "Pending:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Zoom
        btnSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(673, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(42, 31)
        btnSearch.TabIndex = 4
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(428, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by complainant/respondent"
        txtSearch.Size = New Size(239, 30)
        txtSearch.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(345, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 28)
        Label3.TabIndex = 2
        Label3.Text = "Search:"
        ' 
        ' cmbFilterStatus
        ' 
        cmbFilterStatus.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFilterStatus.FormattingEnabled = True
        cmbFilterStatus.Items.AddRange(New Object() {"All", "Pending" & vbTab, "Resolved"})
        cmbFilterStatus.Location = New Point(160, 3)
        cmbFilterStatus.Name = "cmbFilterStatus"
        cmbFilterStatus.Size = New Size(151, 31)
        cmbFilterStatus.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 28)
        Label2.TabIndex = 0
        Label2.Text = "Filter by Status:"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(txtDescription)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(txtid)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(cmbincident)
        Panel4.Controls.Add(btnCancel)
        Panel4.Controls.Add(btnSave)
        Panel4.Controls.Add(cmbStatus)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(txtRespondent)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(txtComplainant)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(dtpIncidents)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(1241, 159)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(490, 819)
        Panel4.TabIndex = 24
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(2, 577)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(485, 26)
        txtDescription.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 546)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 28)
        Label7.TabIndex = 26
        Label7.Text = "Description"
        ' 
        ' txtid
        ' 
        txtid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtid.Location = New Point(3, 94)
        txtid.Multiline = True
        txtid.Name = "txtid"
        txtid.Size = New Size(485, 26)
        txtid.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 28)
        Label5.TabIndex = 24
        Label5.Text = "ID"
        ' 
        ' cmbincident
        ' 
        cmbincident.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbincident.FormattingEnabled = True
        cmbincident.Items.AddRange(New Object() {"Clogged drainage or canal", "Streetlight not working", "Garbage collection delay", "Flooding during heavy rains", "Stray dogs/cats in the area", "Water supply interruption", "Minor road or property damage", "Illegal parking or obstruction", "Broken barangay facilities", "Community noise complaints"})
        cmbincident.Location = New Point(3, 494)
        cmbincident.Name = "cmbincident"
        cmbincident.Size = New Size(485, 36)
        cmbincident.TabIndex = 23
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gray
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Transparent
        btnCancel.Location = New Point(249, 708)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(174, 73)
        btnCancel.TabIndex = 22
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(54, 708)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(171, 73)
        btnSave.TabIndex = 21
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"All", "Pending" & vbTab, "Resolved"})
        cmbStatus.Location = New Point(3, 648)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(485, 36)
        cmbStatus.TabIndex = 20
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(3, 617)
        Label15.Name = "Label15"
        Label15.Size = New Size(65, 28)
        Label15.TabIndex = 19
        Label15.Text = "Status"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(3, 465)
        Label14.Name = "Label14"
        Label14.Size = New Size(128, 28)
        Label14.TabIndex = 18
        Label14.Text = "Incident Type"
        ' 
        ' txtRespondent
        ' 
        txtRespondent.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRespondent.Location = New Point(3, 422)
        txtRespondent.Multiline = True
        txtRespondent.Name = "txtRespondent"
        txtRespondent.Size = New Size(485, 26)
        txtRespondent.TabIndex = 17
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(3, 392)
        Label13.Name = "Label13"
        Label13.Size = New Size(116, 28)
        Label13.TabIndex = 16
        Label13.Text = "Respondent"
        ' 
        ' txtComplainant
        ' 
        txtComplainant.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComplainant.Location = New Point(3, 245)
        txtComplainant.Multiline = True
        txtComplainant.Name = "txtComplainant"
        txtComplainant.Size = New Size(485, 134)
        txtComplainant.TabIndex = 15
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(3, 214)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 28)
        Label12.TabIndex = 14
        Label12.Text = "Complainant"
        ' 
        ' dtpIncidents
        ' 
        dtpIncidents.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpIncidents.Location = New Point(3, 165)
        dtpIncidents.Name = "dtpIncidents"
        dtpIncidents.Size = New Size(485, 34)
        dtpIncidents.TabIndex = 13
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(3, 134)
        Label11.Name = "Label11"
        Label11.Size = New Size(117, 28)
        Label11.TabIndex = 12
        Label11.Text = "Report Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label10.Location = New Point(3, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 31)
        Label10.TabIndex = 11
        Label10.Text = "Incident Details"
        ' 
        ' dgvIncidents
        ' 
        dgvIncidents.AllowUserToAddRows = False
        dgvIncidents.AllowUserToDeleteRows = False
        dgvIncidents.BackgroundColor = Color.White
        dgvIncidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvIncidents.Location = New Point(3, 159)
        dgvIncidents.Name = "dgvIncidents"
        dgvIncidents.ReadOnly = True
        dgvIncidents.RowHeadersWidth = 51
        dgvIncidents.Size = New Size(1231, 1011)
        dgvIncidents.TabIndex = 0
        ' 
        ' frmincident
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1539, 844)
        Controls.Add(dgvIncidents)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmincident"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmincident"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvIncidents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFilterStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblResolved As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRespondent As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtComplainant As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpIncidents As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbincident As ComboBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvIncidents As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescription As TextBox
End Class
