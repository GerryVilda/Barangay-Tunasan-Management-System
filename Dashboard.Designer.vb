<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Button7 = New Button()
        Button8 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        lbltime = New Label()
        lbldate = New Label()
        lblgreet = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(lbltime)
        Panel1.Controls.Add(lbldate)
        Panel1.Controls.Add(lblgreet)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 1012)
        Panel1.TabIndex = 0
        ' 
        ' Button7
        ' 
        Button7.Dock = DockStyle.Top
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(0, 741)
        Button7.Name = "Button7"
        Button7.Size = New Size(233, 78)
        Button7.TabIndex = 11
        Button7.Text = "Button7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Dock = DockStyle.Top
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(0, 663)
        Button8.Name = "Button8"
        Button8.Size = New Size(233, 78)
        Button8.TabIndex = 10
        Button8.Text = "Button8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Dock = DockStyle.Top
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(0, 585)
        Button5.Name = "Button5"
        Button5.Size = New Size(233, 78)
        Button5.TabIndex = 9
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(0, 507)
        Button6.Name = "Button6"
        Button6.Size = New Size(233, 78)
        Button6.TabIndex = 8
        Button6.Text = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(0, 429)
        Button3.Name = "Button3"
        Button3.Size = New Size(233, 78)
        Button3.TabIndex = 7
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Top
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(0, 351)
        Button4.Name = "Button4"
        Button4.Size = New Size(233, 78)
        Button4.TabIndex = 6
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(0, 273)
        Button2.Name = "Button2"
        Button2.Size = New Size(233, 78)
        Button2.TabIndex = 5
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(230), CByte(149), CByte(0))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(0, 195)
        Button1.Name = "Button1"
        Button1.Size = New Size(233, 78)
        Button1.TabIndex = 4
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lbltime
        ' 
        lbltime.AutoSize = True
        lbltime.Location = New Point(58, 946)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(63, 25)
        lbltime.TabIndex = 3
        lbltime.Text = "Label2"
        lbltime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Location = New Point(26, 906)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(63, 25)
        lbldate.TabIndex = 2
        lbldate.Text = "Label3"
        lbldate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblgreet.Location = New Point(17, 846)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(99, 38)
        lblgreet.TabIndex = 1
        lblgreet.Text = "Label2"
        lblgreet.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(233, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1327, 70)
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
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1560, 1012)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
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
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
