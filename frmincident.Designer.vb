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
        Panel3 = New Panel()
        dgvIncidents = New DataGridView()
        Panel4 = New Panel()
        txtIncidentType = New TextBox()
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
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvIncidents, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(244, 4)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1154, 65)
        Panel1.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Blue
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.Transparent
        btnRefresh.Location = New Point(992, 11)
        btnRefresh.Margin = New Padding(4, 4, 4, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(121, 40)
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
        btnDelete.Location = New Point(835, 11)
        btnDelete.Margin = New Padding(4, 4, 4, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(121, 40)
        btnDelete.TabIndex = 25
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Yellow
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(684, 11)
        btnEdit.Margin = New Padding(4, 4, 4, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(121, 40)
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
        btnAdd.Location = New Point(538, 11)
        btnAdd.Margin = New Padding(4, 4, 4, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(121, 40)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add New"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(4, 2)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 54)
        Label1.TabIndex = 22
        Label1.Text = "Incident Reports"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(4, 4)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 189)
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
        Panel2.Location = New Point(244, 76)
        Panel2.Margin = New Padding(4, 4, 4, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1154, 92)
        Panel2.TabIndex = 22
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(545, 51)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(25, 30)
        lblTotal.TabIndex = 10
        lblTotal.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(462, 48)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 32)
        Label8.TabIndex = 9
        Label8.Text = "Total:"
        ' 
        ' lblResolved
        ' 
        lblResolved.AutoSize = True
        lblResolved.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResolved.Location = New Point(404, 51)
        lblResolved.Margin = New Padding(4, 0, 4, 0)
        lblResolved.Name = "lblResolved"
        lblResolved.Size = New Size(25, 30)
        lblResolved.TabIndex = 8
        lblResolved.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(274, 48)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 32)
        Label6.TabIndex = 7
        Label6.Text = "Resolved:"
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPending.Location = New Point(200, 51)
        lblPending.Margin = New Padding(4, 0, 4, 0)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(25, 30)
        lblPending.TabIndex = 6
        lblPending.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(78, 48)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 32)
        Label4.TabIndex = 5
        Label4.Text = "Pending:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Zoom
        btnSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(841, 5)
        btnSearch.Margin = New Padding(4, 4, 4, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(52, 39)
        btnSearch.TabIndex = 4
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(535, 4)
        txtSearch.Margin = New Padding(4, 4, 4, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by complainant/respondent"
        txtSearch.Size = New Size(298, 35)
        txtSearch.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(431, 4)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 32)
        Label3.TabIndex = 2
        Label3.Text = "Search:"
        ' 
        ' cmbFilterStatus
        ' 
        cmbFilterStatus.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFilterStatus.FormattingEnabled = True
        cmbFilterStatus.Items.AddRange(New Object() {"All", "Pending" & vbTab, "Resolved"})
        cmbFilterStatus.Location = New Point(200, 4)
        cmbFilterStatus.Margin = New Padding(4, 4, 4, 4)
        cmbFilterStatus.Name = "cmbFilterStatus"
        cmbFilterStatus.Size = New Size(188, 36)
        cmbFilterStatus.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(4, 4)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 32)
        Label2.TabIndex = 0
        Label2.Text = "Filter by Status:"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(dgvIncidents)
        Panel3.Location = New Point(15, 199)
        Panel3.Margin = New Padding(4, 4, 4, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(990, 764)
        Panel3.TabIndex = 23
        ' 
        ' dgvIncidents
        ' 
        dgvIncidents.AllowUserToAddRows = False
        dgvIncidents.AllowUserToDeleteRows = False
        dgvIncidents.BackgroundColor = Color.White
        dgvIncidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvIncidents.Location = New Point(4, 4)
        dgvIncidents.Margin = New Padding(4, 4, 4, 4)
        dgvIncidents.Name = "dgvIncidents"
        dgvIncidents.ReadOnly = True
        dgvIncidents.RowHeadersWidth = 51
        dgvIncidents.Size = New Size(982, 756)
        dgvIncidents.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(txtIncidentType)
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
        Panel4.Location = New Point(1012, 202)
        Panel4.Margin = New Padding(4, 4, 4, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(385, 760)
        Panel4.TabIndex = 24
        ' 
        ' txtIncidentType
        ' 
        txtIncidentType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIncidentType.Location = New Point(4, 426)
        txtIncidentType.Margin = New Padding(4, 4, 4, 4)
        txtIncidentType.Name = "txtIncidentType"
        txtIncidentType.Size = New Size(376, 39)
        txtIncidentType.TabIndex = 23
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gray
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Transparent
        btnCancel.Location = New Point(195, 629)
        btnCancel.Margin = New Padding(4, 4, 4, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(116, 49)
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
        btnSave.Location = New Point(71, 629)
        btnSave.Margin = New Padding(4, 4, 4, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(116, 49)
        btnSave.TabIndex = 21
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"All", "Pending" & vbTab, "Resolved"})
        cmbStatus.Location = New Point(4, 529)
        cmbStatus.Margin = New Padding(4, 4, 4, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(376, 40)
        cmbStatus.TabIndex = 20
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(4, 490)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(78, 32)
        Label15.TabIndex = 19
        Label15.Text = "Status"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(4, 388)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(158, 32)
        Label14.TabIndex = 18
        Label14.Text = "Incident Type"
        ' 
        ' txtRespondent
        ' 
        txtRespondent.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRespondent.Location = New Point(4, 322)
        txtRespondent.Margin = New Padding(4, 4, 4, 4)
        txtRespondent.Name = "txtRespondent"
        txtRespondent.Size = New Size(376, 39)
        txtRespondent.TabIndex = 17
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(4, 284)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(141, 32)
        Label13.TabIndex = 16
        Label13.Text = "Respondent"
        ' 
        ' txtComplainant
        ' 
        txtComplainant.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComplainant.Location = New Point(4, 221)
        txtComplainant.Margin = New Padding(4, 4, 4, 4)
        txtComplainant.Name = "txtComplainant"
        txtComplainant.Size = New Size(376, 39)
        txtComplainant.TabIndex = 15
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(4, 182)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(150, 32)
        Label12.TabIndex = 14
        Label12.Text = "Complainant"
        ' 
        ' dtpIncidents
        ' 
        dtpIncidents.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpIncidents.Location = New Point(4, 121)
        dtpIncidents.Margin = New Padding(4, 4, 4, 4)
        dtpIncidents.Name = "dtpIncidents"
        dtpIncidents.Size = New Size(376, 39)
        dtpIncidents.TabIndex = 13
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(4, 82)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(141, 32)
        Label11.TabIndex = 12
        Label11.Text = "Report Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(4, 24)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(227, 38)
        Label10.TabIndex = 11
        Label10.Text = "Incident Details"
        ' 
        ' frmincident
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(2262, 1476)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Margin = New Padding(4, 4, 4, 4)
        Name = "frmincident"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmincident"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(dgvIncidents, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvIncidents As DataGridView
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
    Friend WithEvents txtIncidentType As TextBox
End Class
