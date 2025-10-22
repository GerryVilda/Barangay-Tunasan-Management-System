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
        DataGridView1 = New DataGridView()
        panelPending = New Panel()
        lblPendingCount = New Label()
        lblPending = New Label()
        panelResolved = New Panel()
        lblResolvedCount = New Label()
        lblResolved = New Label()
        panelTotal = New Panel()
        lblTotalCount = New Label()
        lblTotalComplaints = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        panelPending.SuspendLayout()
        panelResolved.SuspendLayout()
        panelTotal.SuspendLayout()
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
        lblTitle.Location = New Point(443, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(421, 46)
        lblTitle.TabIndex = 22
        lblTitle.Text = "Complaint Management"
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
        btnAdd.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(926, 60)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(162, 39)
        btnAdd.TabIndex = 26
        btnAdd.Text = "Add Complaint"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 257)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1123, 513)
        DataGridView1.TabIndex = 27
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
        ' frmcomplaints
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1147, 782)
        Controls.Add(panelTotal)
        Controls.Add(panelResolved)
        Controls.Add(panelPending)
        Controls.Add(DataGridView1)
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        panelPending.ResumeLayout(False)
        panelPending.PerformLayout()
        panelResolved.ResumeLayout(False)
        panelResolved.PerformLayout()
        panelTotal.ResumeLayout(False)
        panelTotal.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents panelPending As Panel
    Friend WithEvents panelResolved As Panel
    Friend WithEvents panelTotal As Panel
    Friend WithEvents lblPending As Label
    Friend WithEvents lblResolved As Label
    Friend WithEvents lblTotalComplaints As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblResolvedCount As Label
    Friend WithEvents lblTotalCount As Label
End Class
