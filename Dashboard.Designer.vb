﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        btnlogout = New Button()
        btnusers = New Button()
        btnofficials = New Button()
        btnsummary = New Button()
        btnsito = New Button()
        btnrecords = New Button()
        btncertifications = New Button()
        btnincidents = New Button()
        btnblotter = New Button()
        btncomplaints = New Button()
        btnresidents = New Button()
        lbltime = New Label()
        lbldate = New Label()
        lblgreet = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
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
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel1.Controls.Add(btnlogout)
        Panel1.Controls.Add(btnusers)
        Panel1.Controls.Add(btnofficials)
        Panel1.Controls.Add(btnsummary)
        Panel1.Controls.Add(btnsito)
        Panel1.Controls.Add(btnrecords)
        Panel1.Controls.Add(btncertifications)
        Panel1.Controls.Add(btnincidents)
        Panel1.Controls.Add(btnblotter)
        Panel1.Controls.Add(btncomplaints)
        Panel1.Controls.Add(btnresidents)
        Panel1.Controls.Add(lbltime)
        Panel1.Controls.Add(lbldate)
        Panel1.Controls.Add(lblgreet)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(276, 1037)
        Panel1.TabIndex = 0
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnlogout.Dock = DockStyle.Top
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnlogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnlogout.Location = New Point(0, 806)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(276, 59)
        btnlogout.TabIndex = 14
        btnlogout.Text = "🚪 Logout / Exit"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' btnusers
        ' 
        btnusers.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnusers.Dock = DockStyle.Top
        btnusers.FlatAppearance.BorderSize = 0
        btnusers.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnusers.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnusers.FlatStyle = FlatStyle.Flat
        btnusers.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnusers.Location = New Point(0, 747)
        btnusers.Name = "btnusers"
        btnusers.Size = New Size(276, 59)
        btnusers.TabIndex = 13
        btnusers.Text = "🔑 Users / Accounts"
        btnusers.UseVisualStyleBackColor = False
        ' 
        ' btnofficials
        ' 
        btnofficials.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnofficials.Dock = DockStyle.Top
        btnofficials.FlatAppearance.BorderSize = 0
        btnofficials.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnofficials.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnofficials.FlatStyle = FlatStyle.Flat
        btnofficials.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnofficials.Location = New Point(0, 688)
        btnofficials.Name = "btnofficials"
        btnofficials.Size = New Size(276, 59)
        btnofficials.TabIndex = 12
        btnofficials.Text = ChrW(55358) & ChrW(56785) & "‍💼 Officials"
        btnofficials.UseVisualStyleBackColor = False
        ' 
        ' btnsummary
        ' 
        btnsummary.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnsummary.Dock = DockStyle.Top
        btnsummary.FlatAppearance.BorderSize = 0
        btnsummary.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnsummary.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnsummary.FlatStyle = FlatStyle.Flat
        btnsummary.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsummary.Location = New Point(0, 608)
        btnsummary.Name = "btnsummary"
        btnsummary.Size = New Size(276, 80)
        btnsummary.TabIndex = 11
        btnsummary.Text = "📊 Reports Summary"
        btnsummary.UseVisualStyleBackColor = False
        ' 
        ' btnsito
        ' 
        btnsito.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnsito.Dock = DockStyle.Top
        btnsito.FlatAppearance.BorderSize = 0
        btnsito.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnsito.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnsito.FlatStyle = FlatStyle.Flat
        btnsito.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsito.Location = New Point(0, 549)
        btnsito.Name = "btnsito"
        btnsito.Size = New Size(276, 59)
        btnsito.TabIndex = 10
        btnsito.Text = "📍 Sitio Problems"
        btnsito.UseVisualStyleBackColor = False
        ' 
        ' btnrecords
        ' 
        btnrecords.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnrecords.Dock = DockStyle.Top
        btnrecords.FlatAppearance.BorderSize = 0
        btnrecords.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnrecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnrecords.FlatStyle = FlatStyle.Flat
        btnrecords.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnrecords.Location = New Point(0, 490)
        btnrecords.Name = "btnrecords"
        btnrecords.Size = New Size(276, 59)
        btnrecords.TabIndex = 9
        btnrecords.Text = "👴 Senior / Records"
        btnrecords.UseVisualStyleBackColor = False
        ' 
        ' btncertifications
        ' 
        btncertifications.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btncertifications.Dock = DockStyle.Top
        btncertifications.FlatAppearance.BorderSize = 0
        btncertifications.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btncertifications.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btncertifications.FlatStyle = FlatStyle.Flat
        btncertifications.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btncertifications.Location = New Point(0, 431)
        btncertifications.Name = "btncertifications"
        btncertifications.Size = New Size(276, 59)
        btncertifications.TabIndex = 8
        btncertifications.Text = ChrW(55358) & ChrW(57002) & " Certifications"
        btncertifications.UseVisualStyleBackColor = False
        ' 
        ' btnincidents
        ' 
        btnincidents.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnincidents.Dock = DockStyle.Top
        btnincidents.FlatAppearance.BorderSize = 0
        btnincidents.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnincidents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnincidents.FlatStyle = FlatStyle.Flat
        btnincidents.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnincidents.Location = New Point(0, 372)
        btnincidents.Name = "btnincidents"
        btnincidents.Size = New Size(276, 59)
        btnincidents.TabIndex = 7
        btnincidents.Text = "⚠️ Incident Reports"
        btnincidents.UseVisualStyleBackColor = False
        ' 
        ' btnblotter
        ' 
        btnblotter.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnblotter.Dock = DockStyle.Top
        btnblotter.FlatAppearance.BorderSize = 0
        btnblotter.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnblotter.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnblotter.FlatStyle = FlatStyle.Flat
        btnblotter.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnblotter.Location = New Point(0, 313)
        btnblotter.Name = "btnblotter"
        btnblotter.Size = New Size(276, 59)
        btnblotter.TabIndex = 6
        btnblotter.Text = ChrW(55358) & ChrW(56830) & " Blotter Reports"
        btnblotter.UseVisualStyleBackColor = False
        ' 
        ' btncomplaints
        ' 
        btncomplaints.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btncomplaints.Dock = DockStyle.Top
        btncomplaints.FlatAppearance.BorderSize = 0
        btncomplaints.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btncomplaints.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btncomplaints.FlatStyle = FlatStyle.Flat
        btncomplaints.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btncomplaints.Location = New Point(0, 254)
        btncomplaints.Name = "btncomplaints"
        btncomplaints.Size = New Size(276, 59)
        btncomplaints.TabIndex = 5
        btncomplaints.Text = "💬 Complaints"
        btncomplaints.UseVisualStyleBackColor = False
        ' 
        ' btnresidents
        ' 
        btnresidents.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        btnresidents.Dock = DockStyle.Top
        btnresidents.FlatAppearance.BorderSize = 0
        btnresidents.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        btnresidents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        btnresidents.FlatStyle = FlatStyle.Flat
        btnresidents.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnresidents.Location = New Point(0, 195)
        btnresidents.Name = "btnresidents"
        btnresidents.Size = New Size(276, 59)
        btnresidents.TabIndex = 4
        btnresidents.Text = "👨‍👩‍👧‍👦 Residents"
        btnresidents.UseVisualStyleBackColor = False
        ' 
        ' lbltime
        ' 
        lbltime.AutoSize = True
        lbltime.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lbltime.Location = New Point(76, 979)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(63, 25)
        lbltime.TabIndex = 3
        lbltime.Text = "Label2"
        lbltime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lbldate.Location = New Point(38, 939)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(63, 25)
        lbldate.TabIndex = 2
        lbldate.Text = "Label3"
        lbldate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgreet.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        lblgreet.Location = New Point(12, 879)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(123, 45)
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
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(276, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(276, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1486, 70)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(11, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(656, 48)
        Label1.TabIndex = 0
        Label1.Text = "Barangay Tunasan Management Sytem"
        ' 
        ' Timer1
        ' 
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = SystemColors.AppWorkspace
        PanelMain.BackgroundImage = CType(resources.GetObject("PanelMain.BackgroundImage"), Image)
        PanelMain.BackgroundImageLayout = ImageLayout.Stretch
        PanelMain.Location = New Point(276, 65)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1801, 1087)
        PanelMain.TabIndex = 2
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1762, 1037)
        Controls.Add(PanelMain)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
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
    Friend WithEvents btnsito As Button
    Friend WithEvents btnrecords As Button
    Friend WithEvents btncertifications As Button
    Friend WithEvents btnincidents As Button
    Friend WithEvents btnblotter As Button
    Friend WithEvents btncomplaints As Button
    Friend WithEvents btnresidents As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnusers As Button
    Friend WithEvents btnofficials As Button
    Friend WithEvents PanelMain As Panel
End Class
