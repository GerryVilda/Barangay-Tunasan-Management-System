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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCertificates))
        Panel1 = New Panel()
        btnadd = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        dtpissueddate = New DateTimePicker()
        txtissuedby = New TextBox()
        txtremarks = New TextBox()
        txtresident_name = New TextBox()
        Label2 = New Label()
        CboCertificatesSearchBy = New ComboBox()
        btnGeneratePDF = New Button()
        dgvcertifications = New DataGridView()
        Label1 = New Label()
        txtresidentId = New TextBox()
        Label3 = New Label()
        cmbcertificatetype = New ComboBox()
        Panel1.SuspendLayout()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel1.Controls.Add(cmbcertificatetype)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtresidentId)
        Panel1.Controls.Add(btnadd)
        Panel1.Controls.Add(btnupdate)
        Panel1.Controls.Add(btndelete)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dtpissueddate)
        Panel1.Controls.Add(txtissuedby)
        Panel1.Controls.Add(txtremarks)
        Panel1.Controls.Add(txtresident_name)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CboCertificatesSearchBy)
        Panel1.Controls.Add(btnGeneratePDF)
        Panel1.Controls.Add(dgvcertifications)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(26, 30)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1775, 1142)
        Panel1.TabIndex = 4
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(565, 265)
        btnadd.Margin = New Padding(2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(162, 58)
        btnadd.TabIndex = 44
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(865, 265)
        btnupdate.Margin = New Padding(2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(162, 58)
        btnupdate.TabIndex = 43
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(1142, 265)
        btndelete.Margin = New Padding(2)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(162, 58)
        btndelete.TabIndex = 42
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label9.Location = New Point(24, 251)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 28)
        Label9.TabIndex = 40
        Label9.Text = "Issued Date:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.Location = New Point(24, 203)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 28)
        Label8.TabIndex = 39
        Label8.Text = "Issued By:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(24, 116)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 28)
        Label7.TabIndex = 38
        Label7.Text = "Resident ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label6.Location = New Point(556, 60)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 32)
        Label6.TabIndex = 37
        Label6.Text = "Remarks:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(24, 71)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 28)
        Label5.TabIndex = 36
        Label5.Text = "ID:"
        ' 
        ' dtpissueddate
        ' 
        dtpissueddate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpissueddate.Location = New Point(156, 246)
        dtpissueddate.Margin = New Padding(2)
        dtpissueddate.Name = "dtpissueddate"
        dtpissueddate.Size = New Size(355, 34)
        dtpissueddate.TabIndex = 33
        ' 
        ' txtissuedby
        ' 
        txtissuedby.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtissuedby.Location = New Point(156, 200)
        txtissuedby.Margin = New Padding(2)
        txtissuedby.Name = "txtissuedby"
        txtissuedby.Size = New Size(355, 34)
        txtissuedby.TabIndex = 32
        ' 
        ' txtremarks
        ' 
        txtremarks.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtremarks.Location = New Point(556, 93)
        txtremarks.Margin = New Padding(2)
        txtremarks.Multiline = True
        txtremarks.Name = "txtremarks"
        txtremarks.Size = New Size(748, 163)
        txtremarks.TabIndex = 31
        ' 
        ' txtresident_name
        ' 
        txtresident_name.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtresident_name.Location = New Point(156, 65)
        txtresident_name.Margin = New Padding(2)
        txtresident_name.Name = "txtresident_name"
        txtresident_name.Size = New Size(355, 34)
        txtresident_name.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 291)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 28)
        Label2.TabIndex = 25
        Label2.Text = "Search by:"
        ' 
        ' CboCertificatesSearchBy
        ' 
        CboCertificatesSearchBy.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CboCertificatesSearchBy.FormattingEnabled = True
        CboCertificatesSearchBy.Location = New Point(156, 288)
        CboCertificatesSearchBy.Margin = New Padding(2)
        CboCertificatesSearchBy.Name = "CboCertificatesSearchBy"
        CboCertificatesSearchBy.Size = New Size(355, 36)
        CboCertificatesSearchBy.TabIndex = 24
        ' 
        ' btnGeneratePDF
        ' 
        btnGeneratePDF.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGeneratePDF.Location = New Point(1320, 96)
        btnGeneratePDF.Margin = New Padding(2)
        btnGeneratePDF.Name = "btnGeneratePDF"
        btnGeneratePDF.Size = New Size(178, 237)
        btnGeneratePDF.TabIndex = 23
        btnGeneratePDF.Text = "📄 Generate PDF"
        btnGeneratePDF.UseVisualStyleBackColor = True
        ' 
        ' dgvcertifications
        ' 
        dgvcertifications.AllowUserToAddRows = False
        dgvcertifications.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        dgvcertifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        dgvcertifications.BackgroundColor = Color.White
        dgvcertifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcertifications.Location = New Point(14, 340)
        dgvcertifications.Margin = New Padding(2)
        dgvcertifications.Name = "dgvcertifications"
        dgvcertifications.ReadOnly = True
        dgvcertifications.RowHeadersWidth = 62
        dgvcertifications.Size = New Size(1722, 787)
        dgvcertifications.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(14, 12)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 54)
        Label1.TabIndex = 0
        Label1.Text = "Certifications"
        ' 
        ' txtresidentId
        ' 
        txtresidentId.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtresidentId.Location = New Point(156, 113)
        txtresidentId.Margin = New Padding(2)
        txtresidentId.Name = "txtresidentId"
        txtresidentId.Size = New Size(355, 34)
        txtresidentId.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(24, 158)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 28)
        Label3.TabIndex = 46
        Label3.Text = "Type:"
        ' 
        ' cmbcertificatetype
        ' 
        cmbcertificatetype.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbcertificatetype.FormattingEnabled = True
        cmbcertificatetype.Items.AddRange(New Object() {"Residency Certificate", "Barangay Clearance", "Indigency Certificate"})
        cmbcertificatetype.Location = New Point(156, 155)
        cmbcertificatetype.Name = "cmbcertificatetype"
        cmbcertificatetype.Size = New Size(355, 36)
        cmbcertificatetype.TabIndex = 47
        ' 
        ' FrmCertificates
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1539, 844)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "FrmCertificates"
        Text = "frmcertificates"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents dgvcertifications As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CboCertificatesSearchBy As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpissueddate As DateTimePicker
    Friend WithEvents txtissuedby As TextBox
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents txtresident_name As TextBox
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents cmbcertificatetype As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresidentId As TextBox
End Class
