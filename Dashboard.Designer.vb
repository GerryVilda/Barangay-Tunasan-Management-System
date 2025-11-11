<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        btnRequest = New Button()
        btnlogout = New Button()
        btnusers = New Button()
        btnofficials = New Button()
        btnsummary = New Button()
        btnpayment = New Button()
        btncertifications = New Button()
        btnblotter = New Button()
        btncomplaints = New Button()
        btnresidents = New Button()
        lbltime = New Label()
        lbldate = New Label()
        lblgreet = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lblfullname = New Label()
        Label1 = New Label()
        Timer1 = New Timer(components)
        PanelMain = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel1.Controls.Add(btnRequest)
        Panel1.Controls.Add(btnlogout)
        Panel1.Controls.Add(btnusers)
        Panel1.Controls.Add(btnofficials)
        Panel1.Controls.Add(btnsummary)
        Panel1.Controls.Add(btnpayment)
        Panel1.Controls.Add(btncertifications)
        Panel1.Controls.Add(btnblotter)
        Panel1.Controls.Add(btncomplaints)
        Panel1.Controls.Add(btnresidents)
        Panel1.Controls.Add(lbltime)
        Panel1.Controls.Add(lbldate)
        Panel1.Controls.Add(lblgreet)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 3, 2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(266, 882)
        Panel1.TabIndex = 0
        ' 
        ' btnRequest
        ' 
        btnRequest.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnRequest.FlatAppearance.BorderSize = 0
        btnRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnRequest.FlatStyle = FlatStyle.Flat
        btnRequest.Font = New Font("Tahoma", 16F)
        btnRequest.Location = New Point(-4, 628)
        btnRequest.Margin = New Padding(2, 3, 2, 3)
        btnRequest.Name = "btnRequest"
        btnRequest.Size = New Size(260, 75)
        btnRequest.TabIndex = 15
        btnRequest.Text = "📄 Request Form"
        btnRequest.TextAlign = ContentAlignment.MiddleLeft
        btnRequest.UseVisualStyleBackColor = False
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnlogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Tahoma", 16F)
        btnlogout.Location = New Point(-5, 1006)
        btnlogout.Margin = New Padding(2, 3, 2, 3)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(260, 75)
        btnlogout.TabIndex = 14
        btnlogout.Text = "🚪 Logout / Exit"
        btnlogout.TextAlign = ContentAlignment.MiddleLeft
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' btnusers
        ' 
        btnusers.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnusers.FlatAppearance.BorderSize = 0
        btnusers.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnusers.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnusers.FlatStyle = FlatStyle.Flat
        btnusers.Font = New Font("Tahoma", 16F)
        btnusers.Location = New Point(-5, 932)
        btnusers.Margin = New Padding(2, 3, 2, 3)
        btnusers.Name = "btnusers"
        btnusers.Size = New Size(260, 75)
        btnusers.TabIndex = 13
        btnusers.Text = "🔑 Users/Accounts"
        btnusers.TextAlign = ContentAlignment.MiddleLeft
        btnusers.UseVisualStyleBackColor = False
        ' 
        ' btnofficials
        ' 
        btnofficials.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnofficials.FlatAppearance.BorderSize = 0
        btnofficials.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnofficials.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnofficials.FlatStyle = FlatStyle.Flat
        btnofficials.Font = New Font("Tahoma", 16F)
        btnofficials.Location = New Point(-5, 855)
        btnofficials.Margin = New Padding(2, 3, 2, 3)
        btnofficials.Name = "btnofficials"
        btnofficials.Size = New Size(260, 75)
        btnofficials.TabIndex = 12
        btnofficials.Text = ChrW(55358) & ChrW(56785) & "‍💼 Officials"
        btnofficials.TextAlign = ContentAlignment.MiddleLeft
        btnofficials.UseVisualStyleBackColor = False
        ' 
        ' btnsummary
        ' 
        btnsummary.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnsummary.FlatAppearance.BorderSize = 0
        btnsummary.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnsummary.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnsummary.FlatStyle = FlatStyle.Flat
        btnsummary.Font = New Font("Tahoma", 16F)
        btnsummary.Location = New Point(-4, 774)
        btnsummary.Margin = New Padding(2, 3, 2, 3)
        btnsummary.Name = "btnsummary"
        btnsummary.Size = New Size(270, 92)
        btnsummary.TabIndex = 11
        btnsummary.Text = "📊 Reports Summary"
        btnsummary.TextAlign = ContentAlignment.MiddleLeft
        btnsummary.UseVisualStyleBackColor = False
        ' 
        ' btnpayment
        ' 
        btnpayment.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnpayment.FlatAppearance.BorderSize = 0
        btnpayment.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnpayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnpayment.FlatStyle = FlatStyle.Flat
        btnpayment.Font = New Font("Tahoma", 16F)
        btnpayment.Location = New Point(-4, 708)
        btnpayment.Margin = New Padding(2, 3, 2, 3)
        btnpayment.Name = "btnpayment"
        btnpayment.Size = New Size(260, 75)
        btnpayment.TabIndex = 10
        btnpayment.Text = "💵 Payment"
        btnpayment.TextAlign = ContentAlignment.MiddleLeft
        btnpayment.UseVisualStyleBackColor = False
        ' 
        ' btncertifications
        ' 
        btncertifications.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btncertifications.FlatAppearance.BorderSize = 0
        btncertifications.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btncertifications.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btncertifications.FlatStyle = FlatStyle.Flat
        btncertifications.Font = New Font("Tahoma", 16F)
        btncertifications.Location = New Point(-4, 546)
        btncertifications.Margin = New Padding(2, 3, 2, 3)
        btncertifications.Name = "btncertifications"
        btncertifications.Size = New Size(260, 75)
        btncertifications.TabIndex = 8
        btncertifications.Text = ChrW(55358) & ChrW(57002) & " Certifications"
        btncertifications.TextAlign = ContentAlignment.MiddleLeft
        btncertifications.UseVisualStyleBackColor = False
        ' 
        ' btnblotter
        ' 
        btnblotter.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnblotter.FlatAppearance.BorderSize = 0
        btnblotter.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnblotter.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnblotter.FlatStyle = FlatStyle.Flat
        btnblotter.Font = New Font("Tahoma", 16F)
        btnblotter.Location = New Point(-4, 458)
        btnblotter.Margin = New Padding(2, 3, 2, 3)
        btnblotter.Name = "btnblotter"
        btnblotter.Size = New Size(260, 75)
        btnblotter.TabIndex = 6
        btnblotter.Text = ChrW(55358) & ChrW(56830) & " Blotter Reports"
        btnblotter.TextAlign = ContentAlignment.MiddleLeft
        btnblotter.UseVisualStyleBackColor = False
        ' 
        ' btncomplaints
        ' 
        btncomplaints.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btncomplaints.FlatAppearance.BorderSize = 0
        btncomplaints.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btncomplaints.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btncomplaints.FlatStyle = FlatStyle.Flat
        btncomplaints.Font = New Font("Tahoma", 16F)
        btncomplaints.Location = New Point(-4, 377)
        btncomplaints.Margin = New Padding(2, 3, 2, 3)
        btncomplaints.Name = "btncomplaints"
        btncomplaints.Size = New Size(260, 75)
        btncomplaints.TabIndex = 5
        btncomplaints.Text = "💬 Complaints"
        btncomplaints.TextAlign = ContentAlignment.MiddleLeft
        btncomplaints.UseVisualStyleBackColor = False
        ' 
        ' btnresidents
        ' 
        btnresidents.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnresidents.FlatAppearance.BorderSize = 0
        btnresidents.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnresidents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnresidents.FlatStyle = FlatStyle.Flat
        btnresidents.Font = New Font("Tahoma", 16F)
        btnresidents.Location = New Point(-4, 295)
        btnresidents.Margin = New Padding(2, 3, 2, 3)
        btnresidents.Name = "btnresidents"
        btnresidents.Size = New Size(260, 75)
        btnresidents.TabIndex = 4
        btnresidents.Text = "👨‍👩‍👧‍👦 Residents"
        btnresidents.TextAlign = ContentAlignment.MiddleLeft
        btnresidents.UseVisualStyleBackColor = False
        ' 
        ' lbltime
        ' 
        lbltime.AutoSize = True
        lbltime.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lbltime.Location = New Point(59, 267)
        lbltime.Margin = New Padding(2, 0, 2, 0)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(53, 20)
        lbltime.TabIndex = 3
        lbltime.Text = "Label2"
        lbltime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lbldate.Location = New Point(27, 235)
        lbldate.Margin = New Padding(2, 0, 2, 0)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(53, 20)
        lbldate.TabIndex = 2
        lbldate.Text = "Label3"
        lbldate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgreet.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblgreet.Location = New Point(9, 187)
        lblgreet.Margin = New Padding(2, 0, 2, 0)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(103, 37)
        lblgreet.TabIndex = 1
        lblgreet.Text = "Label2"
        lblgreet.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2, 3, 2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(266, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel2.Controls.Add(lblfullname)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(266, 0)
        Panel2.Margin = New Padding(2, 3, 2, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1288, 56)
        Panel2.TabIndex = 1
        ' 
        ' lblfullname
        ' 
        lblfullname.AutoSize = True
        lblfullname.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblfullname.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblfullname.Location = New Point(822, 7)
        lblfullname.Margin = New Padding(2, 0, 2, 0)
        lblfullname.Name = "lblfullname"
        lblfullname.Size = New Size(54, 41)
        lblfullname.TabIndex = 1
        lblfullname.Text = "---"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(9, 11)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(658, 41)
        Label1.TabIndex = 0
        Label1.Text = "Barangay Tunasan Records Management Sytem"
        ' 
        ' Timer1
        ' 
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = SystemColors.AppWorkspace
        PanelMain.BackgroundImage = CType(resources.GetObject("PanelMain.BackgroundImage"), Image)
        PanelMain.BackgroundImageLayout = ImageLayout.Stretch
        PanelMain.Location = New Point(266, 52)
        PanelMain.Margin = New Padding(2, 3, 2, 3)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1782, 1227)
        PanelMain.TabIndex = 2
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1554, 882)
        Controls.Add(PanelMain)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lblgreet As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnsummary As Button
    Friend WithEvents btnpayment As Button
    Friend WithEvents btncertifications As Button
    Friend WithEvents btnblotter As Button
    Friend WithEvents btncomplaints As Button
    Friend WithEvents btnresidents As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnusers As Button
    Friend WithEvents btnofficials As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnRequest As Button
    Friend WithEvents lblfullname As Label
End Class