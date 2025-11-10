<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        lblpercent = New Label()
        ProgressBar1 = New ProgressBar()
        btnlogin = New Button()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        tmrlogin = New Timer(components)
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        Panel1.Controls.Add(lblpercent)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Controls.Add(btnlogin)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(txtusername)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(247, 53)
        Panel1.Margin = New Padding(2, 3, 2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(504, 591)
        Panel1.TabIndex = 0
        ' 
        ' lblpercent
        ' 
        lblpercent.AutoSize = True
        lblpercent.Location = New Point(235, 491)
        lblpercent.Margin = New Padding(2, 0, 2, 0)
        lblpercent.Name = "lblpercent"
        lblpercent.Size = New Size(0, 20)
        lblpercent.TabIndex = 8
        lblpercent.Visible = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(122, 475)
        ProgressBar1.Margin = New Padding(2, 3, 2, 3)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(281, 43)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 7
        ProgressBar1.Visible = False
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        btnlogin.BackgroundImageLayout = ImageLayout.None
        btnlogin.FlatAppearance.BorderSize = 0
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        btnlogin.Location = New Point(122, 475)
        btnlogin.Margin = New Padding(2, 3, 2, 3)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(281, 43)
        btnlogin.TabIndex = 6
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ActiveCaption
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(49, 383)
        PictureBox3.Margin = New Padding(2, 3, 2, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(49, 320)
        PictureBox2.Margin = New Padding(2, 3, 2, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = Color.WhiteSmoke
        txtpassword.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold Or FontStyle.Italic)
        txtpassword.Location = New Point(94, 383)
        txtpassword.Margin = New Padding(2, 3, 2, 3)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(369, 43)
        txtpassword.TabIndex = 3
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.WhiteSmoke
        txtusername.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold Or FontStyle.Italic)
        txtusername.Location = New Point(94, 320)
        txtusername.Margin = New Padding(2, 3, 2, 3)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(369, 43)
        txtusername.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Engravers MT", 19.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 232)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(485, 37)
        Label1.TabIndex = 1
        Label1.Text = "BARANGAY TUNASAN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(155, 51)
        PictureBox1.Margin = New Padding(2, 3, 2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(189, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' tmrlogin
        ' 
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(936, -3)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 81)
        Label2.TabIndex = 1
        Label2.Text = "X"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1002, 711)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents lblpercent As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents tmrlogin As Timer
    Friend WithEvents Label2 As Label

End Class
