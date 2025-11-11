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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcertificates))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        txtcerttype = New TextBox()
        txtdate = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        txtresidentname = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        txtissuedby = New TextBox()
        txtID = New TextBox()
        Label2 = New Label()
        CboCertificatesSearchBy = New ComboBox()
        btnGeneratecertificate = New Button()
        dgvcertifications = New DataGridView()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel1.Controls.Add(txtcerttype)
        Panel1.Controls.Add(txtdate)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtresidentname)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtissuedby)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CboCertificatesSearchBy)
        Panel1.Controls.Add(btnGeneratecertificate)
        Panel1.Controls.Add(dgvcertifications)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 1428)
        Panel1.TabIndex = 4
        ' 
        ' txtcerttype
        ' 
        txtcerttype.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        txtcerttype.Location = New Point(492, 200)
        txtcerttype.Margin = New Padding(2)
        txtcerttype.Name = "txtcerttype"
        txtcerttype.ReadOnly = True
        txtcerttype.Size = New Size(523, 50)
        txtcerttype.TabIndex = 50
        ' 
        ' txtdate
        ' 
        txtdate.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        txtdate.Location = New Point(492, 308)
        txtdate.Margin = New Padding(2)
        txtdate.Name = "txtdate"
        txtdate.ReadOnly = True
        txtdate.Size = New Size(523, 50)
        txtdate.TabIndex = 49
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 2)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label3.Location = New Point(226, 195)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 45)
        Label3.TabIndex = 46
        Label3.Text = "Type:"
        ' 
        ' txtresidentname
        ' 
        txtresidentname.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        txtresidentname.Location = New Point(492, 146)
        txtresidentname.Margin = New Padding(2)
        txtresidentname.Name = "txtresidentname"
        txtresidentname.ReadOnly = True
        txtresidentname.Size = New Size(523, 50)
        txtresidentname.TabIndex = 45
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label9.Location = New Point(226, 311)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(202, 45)
        Label9.TabIndex = 40
        Label9.Text = "Issued Date:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label8.Location = New Point(226, 251)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(170, 45)
        Label8.TabIndex = 39
        Label8.Text = "Issued By:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label7.Location = New Point(226, 142)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(254, 45)
        Label7.TabIndex = 38
        Label7.Text = "Resident Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label5.Location = New Point(226, 86)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 45)
        Label5.TabIndex = 36
        Label5.Text = "ID:"
        ' 
        ' txtissuedby
        ' 
        txtissuedby.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        txtissuedby.Location = New Point(492, 254)
        txtissuedby.Margin = New Padding(2)
        txtissuedby.Name = "txtissuedby"
        txtissuedby.ReadOnly = True
        txtissuedby.Size = New Size(523, 50)
        txtissuedby.TabIndex = 32
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        txtID.Location = New Point(492, 92)
        txtID.Margin = New Padding(2)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(523, 50)
        txtID.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 380)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 45)
        Label2.TabIndex = 25
        Label2.Text = "Search by:"
        ' 
        ' CboCertificatesSearchBy
        ' 
        CboCertificatesSearchBy.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CboCertificatesSearchBy.FormattingEnabled = True
        CboCertificatesSearchBy.Location = New Point(202, 376)
        CboCertificatesSearchBy.Margin = New Padding(2)
        CboCertificatesSearchBy.Name = "CboCertificatesSearchBy"
        CboCertificatesSearchBy.Size = New Size(443, 53)
        CboCertificatesSearchBy.TabIndex = 24
        ' 
        ' btnGeneratecertificate
        ' 
        btnGeneratecertificate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGeneratecertificate.Location = New Point(1028, 92)
        btnGeneratecertificate.Margin = New Padding(2)
        btnGeneratecertificate.Name = "btnGeneratecertificate"
        btnGeneratecertificate.Size = New Size(189, 266)
        btnGeneratecertificate.TabIndex = 23
        btnGeneratecertificate.Text = "📄 Generate PDF"
        btnGeneratecertificate.UseVisualStyleBackColor = True
        ' 
        ' dgvcertifications
        ' 
        dgvcertifications.AllowUserToAddRows = False
        dgvcertifications.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        dgvcertifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        dgvcertifications.BackgroundColor = Color.White
        dgvcertifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcertifications.Location = New Point(18, 433)
        dgvcertifications.Margin = New Padding(2)
        dgvcertifications.Name = "dgvcertifications"
        dgvcertifications.ReadOnly = True
        dgvcertifications.RowHeadersWidth = 62
        dgvcertifications.Size = New Size(1863, 560)
        dgvcertifications.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(224, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 65)
        Label1.TabIndex = 0
        Label1.Text = "Certifications"
        ' 
        ' frmcertificates
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1924, 1055)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmcertificates"
        Text = "frmcertificates"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGeneratecertificate As Button
    Friend WithEvents dgvcertifications As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CboCertificatesSearchBy As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtissuedby As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresidentname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txtcerttype As TextBox
End Class
