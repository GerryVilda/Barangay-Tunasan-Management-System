<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmblotter
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmblotter))
        Label1 = New Label()
        Panel1 = New Panel()
        btndelete = New Button()
        txtlocation = New TextBox()
        cmbincident = New ComboBox()
        btnupdateblotter = New Button()
        dgvblotters = New DataGridView()
        txtdetails = New TextBox()
        dtpincidentdate = New DateTimePicker()
        dtpcreatedat = New DateTimePicker()
        txtremarks = New TextBox()
        txtrespondent = New TextBox()
        txtcomplaint = New TextBox()
        txtblotterid = New TextBox()
        cmbstatus = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(dgvblotters, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(12, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(365, 65)
        Label1.TabIndex = 0
        Label1.Text = "Blotter Reports"
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.Controls.Add(btndelete)
        Panel1.Controls.Add(txtlocation)
        Panel1.Controls.Add(cmbincident)
        Panel1.Controls.Add(btnupdateblotter)
        Panel1.Controls.Add(dgvblotters)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtdetails)
        Panel1.Controls.Add(dtpincidentdate)
        Panel1.Controls.Add(dtpcreatedat)
        Panel1.Controls.Add(txtremarks)
        Panel1.Controls.Add(txtrespondent)
        Panel1.Controls.Add(txtcomplaint)
        Panel1.Controls.Add(txtblotterid)
        Panel1.Controls.Add(cmbstatus)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(-1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2251, 1594)
        Panel1.TabIndex = 3
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.Red
        btndelete.FlatAppearance.BorderSize = 0
        btndelete.FlatStyle = FlatStyle.Flat
        btndelete.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndelete.Location = New Point(12, 1037)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(430, 101)
        btndelete.TabIndex = 26
        btndelete.Text = "🗑️ Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txtlocation
        ' 
        txtlocation.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtlocation.Location = New Point(12, 625)
        txtlocation.Name = "txtlocation"
        txtlocation.Size = New Size(395, 51)
        txtlocation.TabIndex = 25
        ' 
        ' cmbincident
        ' 
        cmbincident.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        cmbincident.FormattingEnabled = True
        cmbincident.Items.AddRange(New Object() {"Noise Complaint", "Domestic Dispute", "Vandalism", "Theft", "Verbal Altercation", "Traffic Violation", "Harassment", "Minor Injury"})
        cmbincident.Location = New Point(12, 420)
        cmbincident.Name = "cmbincident"
        cmbincident.Size = New Size(395, 53)
        cmbincident.TabIndex = 24
        ' 
        ' btnupdateblotter
        ' 
        btnupdateblotter.BackColor = Color.Cyan
        btnupdateblotter.FlatAppearance.BorderSize = 0
        btnupdateblotter.FlatStyle = FlatStyle.Flat
        btnupdateblotter.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnupdateblotter.Location = New Point(12, 930)
        btnupdateblotter.Name = "btnupdateblotter"
        btnupdateblotter.Size = New Size(430, 101)
        btnupdateblotter.TabIndex = 22
        btnupdateblotter.Text = "✏️ Update"
        btnupdateblotter.UseVisualStyleBackColor = False
        ' 
        ' dgvblotters
        ' 
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        dgvblotters.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        dgvblotters.BackgroundColor = Color.White
        dgvblotters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvblotters.Location = New Point(477, 394)
        dgvblotters.Name = "dgvblotters"
        dgvblotters.RowHeadersWidth = 62
        dgvblotters.Size = New Size(1200, 965)
        dgvblotters.TabIndex = 20
        ' 
        ' txtdetails
        ' 
        txtdetails.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        txtdetails.Location = New Point(477, 127)
        txtdetails.Multiline = True
        txtdetails.Name = "txtdetails"
        txtdetails.Size = New Size(500, 250)
        txtdetails.TabIndex = 19
        ' 
        ' dtpincidentdate
        ' 
        dtpincidentdate.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        dtpincidentdate.Location = New Point(12, 522)
        dtpincidentdate.Name = "dtpincidentdate"
        dtpincidentdate.Size = New Size(395, 51)
        dtpincidentdate.TabIndex = 18
        ' 
        ' dtpcreatedat
        ' 
        dtpcreatedat.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        dtpcreatedat.Location = New Point(12, 824)
        dtpcreatedat.Name = "dtpcreatedat"
        dtpcreatedat.Size = New Size(395, 51)
        dtpcreatedat.TabIndex = 17
        ' 
        ' txtremarks
        ' 
        txtremarks.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        txtremarks.Location = New Point(1004, 127)
        txtremarks.Multiline = True
        txtremarks.Name = "txtremarks"
        txtremarks.Size = New Size(500, 250)
        txtremarks.TabIndex = 16
        ' 
        ' txtrespondent
        ' 
        txtrespondent.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtrespondent.Location = New Point(12, 321)
        txtrespondent.Name = "txtrespondent"
        txtrespondent.Size = New Size(395, 51)
        txtrespondent.TabIndex = 13
        ' 
        ' txtcomplaint
        ' 
        txtcomplaint.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtcomplaint.Location = New Point(12, 222)
        txtcomplaint.Name = "txtcomplaint"
        txtcomplaint.Size = New Size(395, 51)
        txtcomplaint.TabIndex = 12
        ' 
        ' txtblotterid
        ' 
        txtblotterid.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtblotterid.Location = New Point(12, 126)
        txtblotterid.Name = "txtblotterid"
        txtblotterid.ReadOnly = True
        txtblotterid.Size = New Size(395, 51)
        txtblotterid.TabIndex = 11
        ' 
        ' cmbstatus
        ' 
        cmbstatus.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        cmbstatus.FormattingEnabled = True
        cmbstatus.Items.AddRange(New Object() {"Pending", "Under Investigation", "Resolved"})
        cmbstatus.Location = New Point(12, 722)
        cmbstatus.Name = "cmbstatus"
        cmbstatus.Size = New Size(395, 53)
        cmbstatus.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(12, 779)
        Label7.Name = "Label7"
        Label7.Size = New Size(180, 45)
        Label7.TabIndex = 9
        Label7.Text = "Created At"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label8.Location = New Point(1004, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 45)
        Label8.TabIndex = 8
        Label8.Text = "Remarks"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label9.Location = New Point(12, 678)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 45)
        Label9.TabIndex = 7
        Label9.Text = "Status"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label10.Location = New Point(12, 477)
        Label10.Name = "Label10"
        Label10.Size = New Size(223, 45)
        Label10.TabIndex = 6
        Label10.Text = "Incident Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(12, 178)
        Label11.Name = "Label11"
        Label11.Size = New Size(255, 45)
        Label11.TabIndex = 5
        Label11.Text = "Complainant ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label6.Location = New Point(477, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(123, 45)
        Label6.TabIndex = 4
        Label6.Text = "Details"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(12, 577)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 45)
        Label5.TabIndex = 3
        Label5.Text = "Location"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(12, 375)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 45)
        Label4.TabIndex = 2
        Label4.Text = "Incident Type"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 276)
        Label3.Name = "Label3"
        Label3.Size = New Size(243, 45)
        Label3.TabIndex = 1
        Label3.Text = "Respondent ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 45)
        Label2.TabIndex = 0
        Label2.Text = "Blotter ID"
        ' 
        ' frmblotter
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1539, 1186)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmblotter"
        Text = "frmblotter"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvblotters, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpincidentdate As DateTimePicker
    Friend WithEvents dtpcreatedat As DateTimePicker
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents txtrespondent As TextBox
    Friend WithEvents txtcomplaint As TextBox
    Friend WithEvents txtblotterid As TextBox
    Friend WithEvents cmbstatus As ComboBox
    Friend WithEvents txtdetails As TextBox
    Friend WithEvents dgvblotters As DataGridView
    Friend WithEvents btnupdateblotter As Button
    Friend WithEvents cmbincident As ComboBox
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents btndelete As Button
End Class
