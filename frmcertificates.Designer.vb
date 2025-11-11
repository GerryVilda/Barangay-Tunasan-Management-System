<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcertificates
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcertificates))
        Panel1 = New Panel()
        txtSearchBy = New TextBox()
        txtdate = New TextBox()
        Label3 = New Label()
        txtresidentname = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        txtissuedby = New TextBox()
        txtID = New TextBox()
        Label2 = New Label()
        cmbCertType = New ComboBox()
        btnGeneratecertificate = New Button()
        dgvcertifications = New DataGridView()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel1.Controls.Add(txtSearchBy)
        Panel1.Controls.Add(txtdate)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtresidentname)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtissuedby)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cmbCertType)
        Panel1.Controls.Add(btnGeneratecertificate)
        Panel1.Controls.Add(dgvcertifications)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1539, 1142)
        Panel1.TabIndex = 4
        ' 
        ' txtSearchBy
        ' 
        txtSearchBy.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        txtSearchBy.Location = New Point(725, 74)
        txtSearchBy.Margin = New Padding(2)
        txtSearchBy.Name = "txtSearchBy"
        txtSearchBy.ReadOnly = True
        txtSearchBy.Size = New Size(395, 43)
        txtSearchBy.TabIndex = 50
        ' 
        ' txtdate
        ' 
        txtdate.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        txtdate.Location = New Point(19, 511)
        txtdate.Margin = New Padding(2)
        txtdate.Name = "txtdate"
        txtdate.ReadOnly = True
        txtdate.Size = New Size(395, 43)
        txtdate.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        Label3.Location = New Point(19, 267)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 37)
        Label3.TabIndex = 46
        Label3.Text = "Type"
        ' 
        ' txtresidentname
        ' 
        txtresidentname.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        txtresidentname.Location = New Point(19, 217)
        txtresidentname.Margin = New Padding(2)
        txtresidentname.Name = "txtresidentname"
        txtresidentname.ReadOnly = True
        txtresidentname.Size = New Size(395, 43)
        txtresidentname.TabIndex = 45
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        Label9.Location = New Point(19, 465)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 37)
        Label9.TabIndex = 40
        Label9.Text = "Issued Date"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        Label8.Location = New Point(19, 367)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(132, 37)
        Label8.TabIndex = 39
        Label8.Text = "Issued By"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        Label7.Location = New Point(19, 171)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(202, 37)
        Label7.TabIndex = 38
        Label7.Text = "Resident Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        Label5.Location = New Point(19, 77)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 37)
        Label5.TabIndex = 36
        Label5.Text = "ID"
        ' 
        ' txtissuedby
        ' 
        txtissuedby.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        txtissuedby.Location = New Point(19, 413)
        txtissuedby.Margin = New Padding(2)
        txtissuedby.Name = "txtissuedby"
        txtissuedby.ReadOnly = True
        txtissuedby.Size = New Size(395, 43)
        txtissuedby.TabIndex = 32
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        txtID.Location = New Point(19, 120)
        txtID.Margin = New Padding(2)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(395, 43)
        txtID.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        Label2.Location = New Point(578, 77)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 37)
        Label2.TabIndex = 25
        Label2.Text = "Search By:"
        ' 
        ' cmbCertType
        ' 
        cmbCertType.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        cmbCertType.FormattingEnabled = True
        cmbCertType.Items.AddRange(New Object() {"Barangay Clearance (Personal Use)", "Barangay Clearance (Business)", "Barangay Clearance (First Job)", "Residency Certificate", "Indigency Certificate", "Community Tax Certificate / Cedula", "Barangay Business Clearance", "Good Moral Certificate", "Senior Citizen / PWD Certificate", "Solo Parent Certificate", "Certificate of Occupancy / Lot Clearance", "Certificate of Barangay Employment"})
        cmbCertType.Location = New Point(19, 313)
        cmbCertType.Margin = New Padding(2)
        cmbCertType.Name = "cmbCertType"
        cmbCertType.Size = New Size(395, 45)
        cmbCertType.TabIndex = 24
        ' 
        ' btnGeneratecertificate
        ' 
        btnGeneratecertificate.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnGeneratecertificate.Location = New Point(263, 578)
        btnGeneratecertificate.Margin = New Padding(2)
        btnGeneratecertificate.Name = "btnGeneratecertificate"
        btnGeneratecertificate.Size = New Size(151, 213)
        btnGeneratecertificate.TabIndex = 23
        btnGeneratecertificate.Text = "📄 Generate PDF"
        btnGeneratecertificate.UseVisualStyleBackColor = True
        ' 
        ' dgvcertifications
        ' 
        dgvcertifications.AllowUserToAddRows = False
        dgvcertifications.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        dgvcertifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvcertifications.BackgroundColor = Color.White
        dgvcertifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcertifications.Location = New Point(576, 130)
        dgvcertifications.Margin = New Padding(2)
        dgvcertifications.Name = "dgvcertifications"
        dgvcertifications.ReadOnly = True
        dgvcertifications.RowHeadersWidth = 62
        dgvcertifications.Size = New Size(1200, 965)
        dgvcertifications.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(11, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 54)
        Label1.TabIndex = 0
        Label1.Text = "Certifications"
        ' 
        ' frmcertificates
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1539, 844)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmcertificates"
        Text = "frmcertificates"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGeneratecertificate As Button
    Friend WithEvents dgvcertifications As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCertType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtissuedby As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresidentname As TextBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txtSearchBy As TextBox
End Class
