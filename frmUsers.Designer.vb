﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Label10 = New Label()
        Label2 = New Label()
        txtFullName = New TextBox()
        Label3 = New Label()
        txtUsername = New TextBox()
        Label4 = New Label()
        txtPassword = New TextBox()
        Label5 = New Label()
        cmbRole = New ComboBox()
        btnSave = New Button()
        btnClear = New Button()
        btnSaveDB = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(11, 11)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(201, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(700, 54)
        Label1.TabIndex = 25
        Label1.Text = "Barangay Tunasan Users / Accounts"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 168)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(744, 602)
        DataGridView1.TabIndex = 26
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnSaveDB)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(cmbRole)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtFullName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(776, 168)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(359, 602)
        Panel1.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 12)
        Label10.Name = "Label10"
        Label10.Size = New Size(156, 31)
        Label10.TabIndex = 12
        Label10.Text = "Manage User"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 28)
        Label2.TabIndex = 13
        Label2.Text = "Full Name"
        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFullName.Location = New Point(20, 88)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(324, 34)
        txtFullName.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 28)
        Label3.TabIndex = 17
        Label3.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(20, 176)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(324, 34)
        txtUsername.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 28)
        Label4.TabIndex = 19
        Label4.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(20, 270)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(324, 34)
        txtPassword.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(20, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 28)
        Label5.TabIndex = 21
        Label5.Text = "Role"
        ' 
        ' cmbRole
        ' 
        cmbRole.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"User", "Admin"})
        cmbRole.Location = New Point(20, 364)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(324, 36)
        cmbRole.TabIndex = 22
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Chocolate
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(77, 439)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(78, 39)
        btnSave.TabIndex = 35
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Chocolate
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(203, 439)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(78, 39)
        btnClear.TabIndex = 36
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSaveDB
        ' 
        btnSaveDB.BackColor = Color.Chocolate
        btnSaveDB.FlatAppearance.BorderSize = 0
        btnSaveDB.FlatStyle = FlatStyle.Flat
        btnSaveDB.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveDB.ForeColor = Color.White
        btnSaveDB.Location = New Point(77, 492)
        btnSaveDB.Name = "btnSaveDB"
        btnSaveDB.Size = New Size(204, 39)
        btnSaveDB.TabIndex = 37
        btnSaveDB.Text = "Save to Database"
        btnSaveDB.UseVisualStyleBackColor = False
        ' 
        ' frmUsers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1147, 782)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "frmUsers"
        Text = "frmUsers"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnSaveDB As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
End Class
