<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecords))
        PictureBox1 = New PictureBox()
        lblRecords = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        txtRecordID = New TextBox()
        Label2 = New Label()
        txtResidentID = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtAge = New TextBox()
        cmbGender = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        cmbCategory = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        btnSave = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 2)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' lblRecords
        ' 
        lblRecords.AutoSize = True
        lblRecords.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblRecords.Location = New Point(180, 9)
        lblRecords.Name = "lblRecords"
        lblRecords.Size = New Size(150, 46)
        lblRecords.TabIndex = 23
        lblRecords.Text = "Records"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 170)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1106, 600)
        DataGridView1.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(180, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 28)
        Label1.TabIndex = 25
        Label1.Text = "Record ID:"
        ' 
        ' txtRecordID
        ' 
        txtRecordID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRecordID.Location = New Point(301, 59)
        txtRecordID.Name = "txtRecordID"
        txtRecordID.Size = New Size(125, 34)
        txtRecordID.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(180, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 28)
        Label2.TabIndex = 27
        Label2.Text = "Resident ID:"
        ' 
        ' txtResidentID
        ' 
        txtResidentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtResidentID.Location = New Point(301, 111)
        txtResidentID.Name = "txtResidentID"
        txtResidentID.Size = New Size(125, 34)
        txtResidentID.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(455, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 28)
        Label3.TabIndex = 29
        Label3.Text = "Age:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(455, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 28)
        Label4.TabIndex = 30
        Label4.Text = "Gender:"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(540, 61)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 34)
        txtAge.TabIndex = 31
        ' 
        ' cmbGender
        ' 
        cmbGender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        cmbGender.Location = New Point(540, 108)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(125, 36)
        cmbGender.TabIndex = 32
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(693, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 28)
        Label5.TabIndex = 33
        Label5.Text = "Category:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(693, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 28)
        Label6.TabIndex = 34
        Label6.Text = "Year Recorded:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Female", "Male"})
        cmbCategory.Location = New Point(845, 62)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(125, 36)
        cmbCategory.TabIndex = 35
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(845, 111)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(125, 34)
        DateTimePicker1.TabIndex = 36
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(1041, 105)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(77, 41)
        btnSave.TabIndex = 37
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' frmRecords
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1130, 782)
        Controls.Add(btnSave)
        Controls.Add(DateTimePicker1)
        Controls.Add(cmbCategory)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(cmbGender)
        Controls.Add(txtAge)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtResidentID)
        Controls.Add(Label2)
        Controls.Add(txtRecordID)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(lblRecords)
        Controls.Add(PictureBox1)
        Name = "frmRecords"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmRecords"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRecords As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResidentID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnSave As Button
End Class
