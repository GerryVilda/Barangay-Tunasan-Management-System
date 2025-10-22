<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSitio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSitio))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        txtID = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtSitio = New TextBox()
        txtDescription = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnClose = New Button()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(178, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(606, 46)
        Label1.TabIndex = 24
        Label1.Text = "Barangay Tunasan - Sitio Problems"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(245, 31)
        Label2.TabIndex = 25
        Label2.Text = "Sitio Problems Details"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(txtDescription)
        Panel1.Controls.Add(txtSitio)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(178, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 696)
        Panel1.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 28)
        Label3.TabIndex = 26
        Label3.Text = "ID:"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(259, 38)
        txtID.Name = "txtID"
        txtID.Size = New Size(611, 34)
        txtID.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 28)
        Label4.TabIndex = 28
        Label4.Text = "Sitio:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(203, 28)
        Label5.TabIndex = 29
        Label5.Text = "Problem Description:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(21, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 28)
        Label6.TabIndex = 30
        Label6.Text = "Report Date:"
        ' 
        ' txtSitio
        ' 
        txtSitio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSitio.Location = New Point(259, 81)
        txtSitio.Name = "txtSitio"
        txtSitio.PlaceholderText = "Enter Sitio Name"
        txtSitio.Size = New Size(611, 34)
        txtSitio.TabIndex = 31
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(259, 124)
        txtDescription.Name = "txtDescription"
        txtDescription.PlaceholderText = "Enter problem description"
        txtDescription.Size = New Size(611, 34)
        txtDescription.TabIndex = 32
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(259, 174)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(611, 27)
        DateTimePicker1.TabIndex = 33
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.DarkOrange
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(259, 219)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(78, 36)
        btnAdd.TabIndex = 34
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.DarkOrange
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(361, 219)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(78, 36)
        btnEdit.TabIndex = 35
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.DarkOrange
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(463, 219)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 36)
        btnDelete.TabIndex = 36
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DarkOrange
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(578, 219)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(90, 36)
        btnClear.TabIndex = 37
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.DarkOrange
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(691, 219)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(90, 36)
        btnClose.TabIndex = 38
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(17, 272)
        Label7.Name = "Label7"
        Label7.Size = New Size(165, 31)
        Label7.TabIndex = 39
        Label7.Text = "Sitio Problems"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(17, 306)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(909, 371)
        DataGridView1.TabIndex = 40
        ' 
        ' frmSitio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1130, 782)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "frmSitio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSitio"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSitio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClose As Button
End Class
