<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummary))
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        Panel1 = New Panel()
        btnGenerate = New Button()
        Label1 = New Label()
        cmbSitio = New ComboBox()
        Panel2 = New Panel()
        lblHouseholds = New Label()
        lblTotalResidents = New Label()
        lblSitioName = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel3 = New Panel()
        lblSenior = New Label()
        lblAdulthood = New Label()
        lblChildhood = New Label()
        lblFemale = New Label()
        lblMale = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label13 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        dtpfrom = New DateTimePicker()
        dtpto = New DateTimePicker()
        btnfilter = New Button()
        btnpdf = New Button()
        Panel4 = New Panel()
        Label22 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(158, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(255, 37)
        lblTitle.TabIndex = 44
        lblTitle.Text = "Reports Summary"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel1.Controls.Add(btnGenerate)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbSitio)
        Panel1.Location = New Point(158, 54)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(513, 75)
        Panel1.TabIndex = 45
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.SandyBrown
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Color.Black
        btnGenerate.Location = New Point(396, 8)
        btnGenerate.Margin = New Padding(3, 2, 3, 2)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(96, 27)
        btnGenerate.TabIndex = 6
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 25)
        Label1.TabIndex = 1
        Label1.Text = "Sitio:"
        ' 
        ' cmbSitio
        ' 
        cmbSitio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbSitio.FormattingEnabled = True
        cmbSitio.Items.AddRange(New Object() {"Camella Homes III", "Lake Shore Subdivision", "Lindenwood Residences", "Midland II Subdivision", "Parkhomes Subdivision", "Planas", "Sto. Niño Village", "Susana Heights Subdivision", "Villa Carolina I", "Villa Carolina II"})
        cmbSitio.Location = New Point(69, 10)
        cmbSitio.Margin = New Padding(3, 2, 3, 2)
        cmbSitio.Name = "cmbSitio"
        cmbSitio.Size = New Size(285, 29)
        cmbSitio.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel2.Controls.Add(lblHouseholds)
        Panel2.Controls.Add(lblTotalResidents)
        Panel2.Controls.Add(lblSitioName)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(2, 143)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(493, 212)
        Panel2.TabIndex = 46
        ' 
        ' lblHouseholds
        ' 
        lblHouseholds.AutoSize = True
        lblHouseholds.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHouseholds.Location = New Point(216, 148)
        lblHouseholds.Name = "lblHouseholds"
        lblHouseholds.Size = New Size(23, 25)
        lblHouseholds.TabIndex = 56
        lblHouseholds.Text = "0"
        ' 
        ' lblTotalResidents
        ' 
        lblTotalResidents.AutoSize = True
        lblTotalResidents.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalResidents.Location = New Point(216, 110)
        lblTotalResidents.Name = "lblTotalResidents"
        lblTotalResidents.Size = New Size(23, 25)
        lblTotalResidents.TabIndex = 55
        lblTotalResidents.Text = "0"
        ' 
        ' lblSitioName
        ' 
        lblSitioName.AutoSize = True
        lblSitioName.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSitioName.Location = New Point(216, 74)
        lblSitioName.Name = "lblSitioName"
        lblSitioName.Size = New Size(23, 25)
        lblSitioName.TabIndex = 54
        lblSitioName.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label7.Location = New Point(52, 148)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 25)
        Label7.TabIndex = 49
        Label7.Text = "Households:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label6.Location = New Point(52, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 25)
        Label6.TabIndex = 48
        Label6.Text = "Total Residents:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(135, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(209, 32)
        Label5.TabIndex = 47
        Label5.Text = "Sitio Information"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(52, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 25)
        Label4.TabIndex = 7
        Label4.Text = "Sitio Name:"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel3.Controls.Add(lblSenior)
        Panel3.Controls.Add(lblAdulthood)
        Panel3.Controls.Add(lblChildhood)
        Panel3.Controls.Add(lblFemale)
        Panel3.Controls.Add(lblMale)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(502, 143)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(493, 212)
        Panel3.TabIndex = 55
        ' 
        ' lblSenior
        ' 
        lblSenior.AutoSize = True
        lblSenior.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSenior.Location = New Point(395, 149)
        lblSenior.Name = "lblSenior"
        lblSenior.Size = New Size(23, 25)
        lblSenior.TabIndex = 61
        lblSenior.Text = "0"
        ' 
        ' lblAdulthood
        ' 
        lblAdulthood.AutoSize = True
        lblAdulthood.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAdulthood.Location = New Point(395, 116)
        lblAdulthood.Name = "lblAdulthood"
        lblAdulthood.Size = New Size(23, 25)
        lblAdulthood.TabIndex = 60
        lblAdulthood.Text = "0"
        ' 
        ' lblChildhood
        ' 
        lblChildhood.AutoSize = True
        lblChildhood.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChildhood.Location = New Point(395, 83)
        lblChildhood.Name = "lblChildhood"
        lblChildhood.Size = New Size(23, 25)
        lblChildhood.TabIndex = 59
        lblChildhood.Text = "0"
        ' 
        ' lblFemale
        ' 
        lblFemale.AutoSize = True
        lblFemale.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFemale.Location = New Point(102, 132)
        lblFemale.Name = "lblFemale"
        lblFemale.Size = New Size(23, 25)
        lblFemale.TabIndex = 58
        lblFemale.Text = "0"
        ' 
        ' lblMale
        ' 
        lblMale.AutoSize = True
        lblMale.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMale.Location = New Point(102, 97)
        lblMale.Name = "lblMale"
        lblMale.Size = New Size(23, 25)
        lblMale.TabIndex = 57
        lblMale.Text = "0"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label16.Location = New Point(187, 149)
        Label16.Name = "Label16"
        Label16.Size = New Size(159, 25)
        Label16.TabIndex = 57
        Label16.Text = "Senior (60-80+):"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label15.Location = New Point(187, 116)
        Label15.Name = "Label15"
        Label15.Size = New Size(197, 25)
        Label15.TabIndex = 56
        Label15.Text = "Adulthood (18-50+):"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label14.Location = New Point(187, 83)
        Label14.Name = "Label14"
        Label14.Size = New Size(182, 25)
        Label14.TabIndex = 55
        Label14.Text = "Childhood (0-13+):"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(102, 11)
        Label12.Name = "Label12"
        Label12.Size = New Size(252, 32)
        Label12.TabIndex = 47
        Label12.Text = "Resident Information"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label11.Location = New Point(12, 97)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 25)
        Label11.TabIndex = 48
        Label11.Text = "Male:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label13.Location = New Point(12, 46)
        Label13.Name = "Label13"
        Label13.Size = New Size(78, 25)
        Label13.TabIndex = 7
        Label13.Text = "Gender"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label10.Location = New Point(12, 132)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 25)
        Label10.TabIndex = 49
        Label10.Text = "Female:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label9.Location = New Point(211, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 25)
        Label9.TabIndex = 50
        Label9.Text = "Age Group"
        ' 
        ' dtpfrom
        ' 
        dtpfrom.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpfrom.Location = New Point(712, 54)
        dtpfrom.Margin = New Padding(2)
        dtpfrom.Name = "dtpfrom"
        dtpfrom.Size = New Size(282, 29)
        dtpfrom.TabIndex = 57
        ' 
        ' dtpto
        ' 
        dtpto.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpto.Location = New Point(712, 81)
        dtpto.Margin = New Padding(2)
        dtpto.Name = "dtpto"
        dtpto.Size = New Size(282, 29)
        dtpto.TabIndex = 58
        ' 
        ' btnfilter
        ' 
        btnfilter.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnfilter.Location = New Point(676, 108)
        btnfilter.Margin = New Padding(2)
        btnfilter.Name = "btnfilter"
        btnfilter.Size = New Size(159, 28)
        btnfilter.TabIndex = 59
        btnfilter.Text = "Filter"
        btnfilter.UseVisualStyleBackColor = True
        ' 
        ' btnpdf
        ' 
        btnpdf.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnpdf.Location = New Point(836, 108)
        btnpdf.Margin = New Padding(2)
        btnpdf.Name = "btnpdf"
        btnpdf.Size = New Size(159, 28)
        btnpdf.TabIndex = 60
        btnpdf.Text = "Generate PDF"
        btnpdf.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel4.Controls.Add(Label22)
        Panel4.Location = New Point(253, 359)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(493, 212)
        Panel4.TabIndex = 62
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(119, 11)
        Label22.Name = "Label22"
        Label22.Size = New Size(255, 32)
        Label22.TabIndex = 47
        Label22.Text = "Sitio Incident Reports"
        ' 
        ' frmSummary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1555, 791)
        Controls.Add(Panel4)
        Controls.Add(btnpdf)
        Controls.Add(btnfilter)
        Controls.Add(dtpto)
        Controls.Add(dtpfrom)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSummary"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSitio As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblHouseholds As Label
    Friend WithEvents lblTotalResidents As Label
    Friend WithEvents lblSitioName As Label
    Friend WithEvents lblSenior As Label
    Friend WithEvents lblAdulthood As Label
    Friend WithEvents lblChildhood As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents lblMale As Label
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents btnfilter As Button
    Friend WithEvents btnpdf As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label22 As Label
End Class
